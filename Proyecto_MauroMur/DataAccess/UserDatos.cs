using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Dos librerias importadas
using System.Data;
using System.Data.SqlClient;
using Common.Cache;
using Common.Models;
using BCrypt.Net;
using Org.BouncyCastle.Crypto.Generators;
using Microsoft.VisualBasic.ApplicationServices;
using Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionGerente;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net;
using Proyecto_MauroMur.Common.Models;



//Clase para los datos del usuario
namespace DataAccess
{
    public class UserDatos : ConnectionToSql
    {
        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT U.*, P.Nombre AS NombrePersona, P.Apellido AS ApellidoPersona, P.DNI AS DNIPersona, P.Mail AS MailPersona, P.FechaNacimiento AS FechaNacimientoPersona, P.Baja AS BajaPersona, U.Contraseña AS ContraseñaUsuario " +
                                          "FROM Usuario U " +
                                          "INNER JOIN Persona P ON U.id_Persona = P.Id_Persona " +
                                          "WHERE U.UserNombre COLLATE Latin1_General_CS_AS = @UserNombre " +
                                          "AND P.Baja != 'SI'";
                    command.Parameters.AddWithValue("@UserNombre", user);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            // Obtener la contraseña cifrada almacenada en la base de datos
                            string contrasenaCifrada = reader.GetString(reader.GetOrdinal("ContraseñaUsuario"));

                            // Verificar si la contraseña ingresada coincide con la contraseña cifrada
                            if (BCrypt.Net.BCrypt.Verify(pass, contrasenaCifrada))
                            {
                                // Las contraseñas coinciden, puedes continuar con el inicio de sesión
                                UserLoginCache.Id = reader.GetInt32(0);
                                UserLoginCache.User = reader.GetString(1);
                                UserLoginCache.TipoPerfil = reader.GetInt32(3);
                                int tipoPerfil = UserLoginCache.TipoPerfil;
                                string? rol = GetRoleName(tipoPerfil); 
                                UserLoginCache.Rol = rol;
                                UserLoginCache.id_Persona = reader.GetInt32(4);
                                UserLoginCache.Nombre = reader["NombrePersona"] as string;
                                UserLoginCache.Apellido = reader["ApellidoPersona"] as string;
                                UserLoginCache.DNI = reader["DNIPersona"] as string;
                                UserLoginCache.Mail = reader["MailPersona"] as string;
                                UserLoginCache.FechaNacimiento = reader.GetDateTime(reader.GetOrdinal("FechaNacimientoPersona"));
                                UserLoginCache.Baja = reader["BajaPersona"] as string;

                                return true;
                            }
                        }
                    }
                    // Si llegamos aquí, no se encontró una coincidencia de usuario y contraseña
                    return false;
                }
            }
        }


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


        public bool AgregarUsuario(string nombre, string apellido, string dni, DateTime fechaNacimiento, string mail, string user, string contrasena, int tipoPerfil)
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
                        command.CommandText = "INSERT INTO Usuario (UserNombre, Contraseña, TipoPerfil, Id_Persona) VALUES (@User, @Contraseña, @TipoPerfil, @Id_Persona);";

                        command.Parameters.AddWithValue("@User", user);
                        command.Parameters.AddWithValue("@Contraseña", contrasena);
                        command.Parameters.AddWithValue("@TipoPerfil", tipoPerfil);
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

        public List<UsuarioConInformacion> ObtenerUsuarios()
        {
            List<UsuarioConInformacion> usuarios = new List<UsuarioConInformacion>();

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"SELECT u.Id, u.UserNombre, tp.Nombre AS TipoPerfilNombre, 
                                        p.Nombre AS PersonaNombre, p.Apellido AS PersonaApellido, 
                                        p.DNI AS PersonaDNI, p.Mail AS PersonaMail, 
                                        p.FechaNacimiento AS PersonaFechaNacimiento, p.Baja AS PersonaBaja
                                        FROM Usuario u
                                        INNER JOIN Persona p ON u.Id_Persona = p.Id_Persona
                                        INNER JOIN TipoPerfiles tp ON u.TipoPerfil = tp.Id";

                    try
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                UsuarioConInformacion usuario = new UsuarioConInformacion
                                {
                                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                    PersonaApellido = reader["PersonaApellido"].ToString(),
                                    PersonaNombre = reader["PersonaNombre"].ToString(),
                                    UserNombre = reader["UserNombre"].ToString(),
                                    PersonaDNI = reader["PersonaDNI"].ToString(),
                                    PersonaMail = reader["PersonaMail"].ToString(),
                                    PersonaFechaNacimiento = (DateTime)reader["PersonaFechaNacimiento"],
                                    PerfilNombre = reader["TipoPerfilNombre"].ToString(),
                                    PersonaBaja = reader["PersonaBaja"].ToString(),
                                };

                                usuarios.Add(usuario);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                    }
                }
            }

            return usuarios;
        }

        public UsuarioConInformacion? TraerUsuariosId(int id)
        {
            UsuarioConInformacion? usuario = null; // Declarar una variable para almacenar el usuario

            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = @"SELECT u.Id, p.Nombre AS PersonaNombre, p.Apellido AS PersonaApellido, p.DNI AS PersonaDNI, 
                                           p.Mail AS PersonaMail, p.FechaNacimiento AS PersonaFechaNacimiento, 
                                           u.UserNombre, u.TipoPerfil, p.Id_Persona, p.Baja AS PersonaBaja 
                                    FROM Usuario u
                                    INNER JOIN Persona p ON u.Id_Persona = p.Id_Persona
                                    WHERE u.Id = @Id";
                    comando.Parameters.AddWithValue("@Id", id); // Agregar el parámetro Id

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario = new UsuarioConInformacion(); // Crear una instancia de UsuarioConInformacion
                            usuario.Id = reader.GetInt32(0);
                            usuario.PersonaNombre = reader.GetString(1);
                            usuario.PersonaApellido = reader.GetString(2);
                            usuario.PersonaDNI = reader.GetString(3);
                            usuario.PersonaMail = reader.GetString(4);
                            usuario.PersonaFechaNacimiento = reader.GetDateTime(5);
                            usuario.UserNombre = reader.GetString(6);
                            usuario.TipoPerfil = reader.GetInt32(7);
                            usuario.Id_Persona = reader.GetInt32(8);
                            usuario.PersonaBaja = reader.GetString(9);
                        }
                    }
                }
            }
            return usuario;
        }


        public string? GetRoleName(int tipoPerfil)
        {
            string? roleName = "Desconocido";

            using (var connection = GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT Nombre FROM TipoPerfiles WHERE Id = @TipoPerfil";
                    command.Parameters.AddWithValue("@TipoPerfil", tipoPerfil);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        roleName = result.ToString();
                    }
                }
            }

            return roleName;
        }

        public int ObtenerIdTipoPerfil(string tipoSeleccionado)
        {
            int tipoPerfilId = 0;

            using (var connection = GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT Id FROM TipoPerfiles WHERE Nombre = @TipoPerfil";
                    command.Parameters.AddWithValue("@TipoPerfil", tipoSeleccionado);

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        tipoPerfilId = Convert.ToInt32(result);
                    }
                }
            }
            return tipoPerfilId;
        }

        public bool ActualizarPersona(string nombre, string apellido, string dni, string mail, DateTime fechaNacimiento,string baja)
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
                    command.CommandText = "UPDATE Persona SET Nombre = @Nombre, Apellido = @Apellido, Mail = @Mail, FechaNacimiento = @FechaNacimiento,Baja=@Baja WHERE DNI = @DNI;";

                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Apellido", apellido);
                    command.Parameters.AddWithValue("@DNI", dni);
                    command.Parameters.AddWithValue("@Mail", mail);
                    command.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
                    command.Parameters.AddWithValue("@Baja", baja);

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

        public bool ActualizarUsuario(int userId, string nombre, string apellido, string dni, string mail, string user, DateTime fechaNacimiento, int tipoPerfil, string baja)
        {
            bool personaActualizada = ActualizarPersona(nombre, apellido, dni, mail, fechaNacimiento,baja);

            if (!personaActualizada)
            {
                return false;
            }

            // Obtén la persona que acabas de actualizar
            Persona persona = ObtenerPersonaPorDNI(dni); // Implementa este método en tu capa intermedia para buscar por DNI

            // Verifica si se encontró la persona
            if (persona != null)
            {
                // Si la persona existe, puedes continuar con la actualización del usuario
                int personaId = persona.Id_Persona;

                if (EsTipoPerfilValido(tipoPerfil))
                {
                    using (var connection = GetConnection())
                    {
                        connection.Open();

                        using (var command = new SqlCommand())
                        {
                            command.Connection = connection;

                            command.CommandText = "UPDATE Usuario SET UserNombre = @UserNombre, TipoPerfil = @TipoPerfil WHERE Id_Persona = @Id_Persona";

                            command.Parameters.AddWithValue("@Id", userId);
                            command.Parameters.AddWithValue("@UserNombre", user);
                            command.Parameters.AddWithValue("@TipoPerfil", tipoPerfil);
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
            else
            {
                return false; // La persona no se encontró, por lo tanto, no se puede actualizar el usuario
            }
        }


        private bool EsTipoPerfilValido(int tipoPerfil)
        {
            return tipoPerfil >= 1 && tipoPerfil < 4;
        }

        public List<string> ObtenerRoles()
        {
            using (var connection = GetConnection())
            {
                List<string> roles = new List<string>();
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    string query = "SELECT Nombre FROM TipoPerfiles";
                    command.CommandText = query;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            roles.Add(reader["Nombre"].ToString());
                        }
                    }
                }

                return roles;
            }
        }

        public bool ExisteDNI(string dni)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT COUNT(*) FROM Persona WHERE DNI = @DNI;";
                    command.Parameters.AddWithValue("@DNI", dni);

                    try
                    {
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        public bool ExisteMail(string mail)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT COUNT(*) FROM Persona WHERE Mail = @Mail;";
                    command.Parameters.AddWithValue("@Mail", mail);

                    try
                    {
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        public bool ExisteNombreUsuario(string userNombre)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT COUNT(*) FROM Usuario WHERE UserNombre = @UserNombre;";
                    command.Parameters.AddWithValue("@UserNombre", userNombre);

                    try
                    {
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                        return false;
                    }
                }
            }
        }
    }
}
