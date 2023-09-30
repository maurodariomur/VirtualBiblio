using Common.Cache;
using Common.Models;
using Microsoft.VisualBasic.ApplicationServices;
using Proyecto_MauroMur.Common.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ClientDatos : ConnectionToSql
    {
        public bool AgregarPersona(string nombre, string apellido, string dni, string mail, DateTime fechaNacimiento)
        {
            if (fechaNacimiento == DateTime.MinValue)
            {
                return false; // Fecha de nacimiento no válida
            }

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Persona (Nombre, Apellido, DNI, Mail, FechaNacimiento) VALUES (@Nombre, @Apellido, @DNI, @Mail, @FechaNacimiento);";

                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Apellido", apellido);
                    command.Parameters.AddWithValue("@DNI", dni);
                    command.Parameters.AddWithValue("@Mail", mail);
                    command.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        public Persona ObtenerPersonaPorDNI(string dni)
        {
            Persona persona = new();

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT Id_Persona, Nombre, Apellido, DNI, Mail, FechaNacimiento " +
                                          "FROM Persona " +
                                          "WHERE DNI = @DNI;";
                    command.Parameters.AddWithValue("@DNI", dni);

                    try
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Si se encontró una persona con el DNI especificado, crea un objeto Persona y asigna sus propiedades.
                                persona = new Persona
                                {
                                    Id_Persona = reader.GetInt32(reader.GetOrdinal("Id_Persona")),
                                    Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                                    Apellido = reader.GetString(reader.GetOrdinal("Apellido")),
                                    DNI = reader.GetString(reader.GetOrdinal("DNI")),
                                    Mail = reader.GetString(reader.GetOrdinal("Mail")),
                                    FechaNacimiento = reader.GetDateTime(reader.GetOrdinal("FechaNacimiento"))
                                };
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                    }
                }
            }

            return persona;
        }


        public bool AgregarCliente(string nombre, string apellido, string dni, DateTime fechaNacimiento, string mail, string telefono, string domicilio, DateTime fechaRegistro)
        {
            // Primero, intenta agregar la persona
            bool personaAgregada = AgregarPersona(nombre, apellido, dni, mail, fechaNacimiento);

            if (!personaAgregada)
            {
                // Si no se pudo agregar la persona, retorna false
                return false;
            }

            // Obtén la persona que acabas de agregar
            Persona persona = ObtenerPersonaPorDNI(dni); // Implementa este método en tu capa intermedia para buscar por DNI

            // Verifica si se encontró la persona
            if (persona != null)
            {
                // Si la persona existe, puedes continuar con la inserción del usuario
                int personaId = persona.Id_Persona;

                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "INSERT INTO Cliente (Telefono,Domicilio,FechaRegistro,Id_Persona) VALUES (@Telefono, @Domicilio, @FechaRegistro, @Id_Persona);";

                        command.Parameters.AddWithValue("@Telefono", telefono);
                        command.Parameters.AddWithValue("@Domicilio", domicilio);
                        command.Parameters.AddWithValue("@FechaRegistro", fechaRegistro);
                        command.Parameters.AddWithValue("@Id_Persona", personaId);

                        try
                        {
                            int rowsAffected = command.ExecuteNonQuery();
                            return rowsAffected > 0;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                            return false;
                        }
                    }
                }
            }
            else
            {
                // La persona no existe, por lo que no se puede agregar el usuario
                return false;
            }
        }

        public List<ClienteConInformacion> ObtenerClientes()
        {
            List<ClienteConInformacion> clientes = new List<ClienteConInformacion>();

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"SELECT c.Id_Cliente, c.Telefono,c.Domicilio,c.FechaRegistro, 
                                        p.Nombre AS PersonaNombre, p.Apellido AS PersonaApellido, 
                                        p.DNI AS PersonaDNI, p.Mail AS PersonaMail, 
                                        p.FechaNacimiento AS PersonaFechaNacimiento, p.Baja AS PersonaBaja
                                        FROM Cliente c
                                        INNER JOIN Persona p ON c.Id_Persona = p.Id_Persona";

                    try
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ClienteConInformacion cliente = new ClienteConInformacion
                                {
                                    IdCliente = reader.GetInt32(reader.GetOrdinal("Id_Cliente")),
                                    PersonaApellido = reader["PersonaApellido"].ToString(),
                                    PersonaNombre = reader["PersonaNombre"].ToString(),
                                    PersonaDNI = reader["PersonaDNI"].ToString(),
                                    PersonaMail = reader["PersonaMail"].ToString(),
                                    PersonaFechaNacimiento = (DateTime)reader["PersonaFechaNacimiento"],
                                    Telefono = reader["Telefono"].ToString(),
                                    Domicilio = reader["Domicilio"].ToString(),
                                    FechaRegistro = (DateTime)reader["FechaRegistro"],
                                    PersonaBaja = reader["PersonaBaja"].ToString()
                                };

                                clientes.Add(cliente);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                    }
                }
            }

            return clientes;
        }

        public ClienteConInformacion? TraerClientesId(int id)
        {
            ClienteConInformacion? cliente = null; // Declarar una variable para almacenar el usuario

            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = @"SELECT c.Id_Cliente, p.Nombre AS PersonaNombre, p.Apellido AS PersonaApellido, p.DNI AS PersonaDNI, 
                                           p.Mail AS PersonaMail, p.FechaNacimiento AS PersonaFechaNacimiento, 
                                           c.Telefono, c.Domicilio,c.FechaRegistro, p.Id_Persona, p.Baja AS PersonaBaja 
                                           FROM Cliente c
                                           INNER JOIN Persona p ON c.Id_Persona = p.Id_Persona
                                           WHERE c.Id_Cliente = @Id_Cliente";
                    comando.Parameters.AddWithValue("@Id_Cliente", id);

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cliente = new ClienteConInformacion(); // Crear una instancia de UsuarioConInformacion
                            cliente.IdCliente = reader.GetInt32(0);
                            cliente.PersonaNombre = reader.GetString(1);
                            cliente.PersonaApellido = reader.GetString(2);
                            cliente.PersonaDNI = reader.GetString(3);
                            cliente.PersonaMail = reader.GetString(4);
                            cliente.PersonaFechaNacimiento = reader.GetDateTime(5);
                            cliente.Telefono = reader.GetString(6);
                            cliente.Domicilio = reader.GetString(7);
                            cliente.FechaRegistro = reader.GetDateTime(8);
                            cliente.Id_Persona = reader.GetInt32(9);
                            cliente.PersonaBaja = reader.GetString(10);
                        }
                    }
                }
            }
            return cliente;
        }

        public bool ActualizarPersona(int personaId, string nombre, string apellido, string dni, string mail, DateTime fechaNacimiento, string baja)
        {
            if (fechaNacimiento == DateTime.MinValue)
            {
                return false; // Fecha de nacimiento no válida
            }

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Persona SET Nombre = @Nombre, Apellido = @Apellido, DNI = @DNI, Mail = @Mail, FechaNacimiento = @FechaNacimiento, Baja = @Baja WHERE Id_Persona = @Id_Persona;";

                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Apellido", apellido);
                    command.Parameters.AddWithValue("@DNI", dni);
                    command.Parameters.AddWithValue("@Mail", mail);
                    command.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
                    command.Parameters.AddWithValue("@Baja", baja);
                    command.Parameters.AddWithValue("@Id_Persona", personaId);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        public Persona ObtenerPersonaPorIdCliente(int idCliente)
        {
            Persona persona = null!;

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT p.Id_Persona, p.Nombre, p.Apellido, p.DNI, p.Mail, p.FechaNacimiento, p.Baja " +
                                          "FROM Persona p " +
                                          "INNER JOIN Cliente u ON p.Id_Persona = u.Id_Persona " +
                                          "WHERE u.Id_Cliente = @IdCliente;";

                    command.Parameters.AddWithValue("@IdCliente", idCliente);

                    try
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                persona = new Persona
                                {
                                    Id_Persona = reader.GetInt32(reader.GetOrdinal("Id_Persona")),
                                    Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                                    Apellido = reader.GetString(reader.GetOrdinal("Apellido")),
                                    DNI = reader.GetString(reader.GetOrdinal("DNI")),
                                    Mail = reader.GetString(reader.GetOrdinal("Mail")),
                                    FechaNacimiento = reader.GetDateTime(reader.GetOrdinal("FechaNacimiento"))
                                };
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                    }
                }
            }

            return persona;
        }

        public bool ActualizarCliente(int clientId, string nombre, string apellido, string dni, string mail, DateTime fechaNacimiento, string telefono, string domicilio, string baja)
        {
            Persona persona = ObtenerPersonaPorIdCliente(clientId);
            if (persona != null)
            {
                int personaId = persona.Id_Persona;
                bool personaActualizada = ActualizarPersona(personaId, nombre, apellido, dni, mail, fechaNacimiento, baja);

                if (!personaActualizada)
                {
                    return false;
                }

                using (var connection = GetConnection())
                {
                    connection.Open();

                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;

                        command.CommandText = "UPDATE Cliente SET Telefono = @Telefono, Domicilio = @Domicilio WHERE Id_Persona = @Id_Persona";

                        command.Parameters.AddWithValue("@Id", clientId);
                        command.Parameters.AddWithValue("@Telefono", telefono);
                        command.Parameters.AddWithValue("@Domicilio", domicilio);
                        command.Parameters.AddWithValue("@Id_Persona", personaId);

                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            else
            {
                return false; 
            }
        }
    }
}
