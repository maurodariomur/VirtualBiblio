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



//Clase para los datos del usuario
namespace DataAccess
{
     public class UserDatos:ConnectionToSql
    {
        public bool Login(string user,string pass)
        {
            //Se crea un Bloque de conexion y se abre esa conexion y no es 
            //necesario cerrar esa conexion por usar using,solo existiran en ese bloque 
            using (var connetion = GetConnection())
            {
                connetion.Open();
                using(var command=new SqlCommand())
                {
                    command.Connection=connetion;
                    command.CommandText = "select * from Usuarios where Usuario=@Usuario and Contraseña=@Contraseña";
                    command.Parameters.AddWithValue("@Usuario", user);//envia el usuario al metodo login
                    command.Parameters.AddWithValue("@Contraseña", pass);//envia el contraseña al metodo login
                    SqlDataReader reader = command.ExecuteReader();//decimos que es de tipo consulta de base de datos
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserLoginCache.Id = reader.GetInt32(0);
                            UserLoginCache.Nombre = reader.GetString(1);
                            UserLoginCache.Apellido = reader.GetString(2);
                            UserLoginCache.DNI = reader.GetString(3);
                            UserLoginCache.Mail = reader.GetString(4); // Asignar valor leído a la propiedad Mail
                            UserLoginCache.Usuario = reader.GetString(5); // Asignar valor leído a la propiedad Usuario
                            UserLoginCache.TipoPerfil = reader.GetInt32(8); // Asignar valor leído a la propiedad TipoPerfil    
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
        }

        // Metodo Para Agregar Usuarios
        public bool AgregarUsuario(string nombre, string apellido, string dni, DateTime fechaNacimiento, string mail, string usuario, string contrasena, int tipoPerfil)
        {

            if (fechaNacimiento == DateTime.MinValue)
            {
                return false; // Fecha de nacimiento no válida
            }

            using (var connetion = GetConnection())
            {
                connetion.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connetion;
                    command.CommandText = "INSERT INTO Usuarios (Nombre, Apellido, DNI, Mail, Usuario, Contraseña, FechaNacimiento, TipoPerfil) VALUES (@Nombre, @Apellido, @DNI, @Mail, @Usuario, @Contraseña, @FechaNacimiento, @TipoPerfil)";

                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Apellido", apellido);
                    command.Parameters.AddWithValue("@DNI", dni);
                    command.Parameters.AddWithValue("@Mail", mail);
                    command.Parameters.AddWithValue("@Usuario", usuario);
                    command.Parameters.AddWithValue("@Contraseña", contrasena); // Guardar el hash en lugar de la contraseña
                    command.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
                    command.Parameters.AddWithValue("@TipoPerfil", tipoPerfil);

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

        public List<Usuarios> ObtenerUsuarios()
        {
            List<Usuarios> usuarios = new List<Usuarios>();

            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "SELECT * FROM Usuarios";

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Usuarios usuario = new Usuarios();
                            usuario.Id = reader.GetInt32(0);
                            usuario.Nombre = reader.GetString(1);
                            usuario.Apellido = reader.GetString(2);
                            usuario.DNI = reader.GetString(3);
                            usuario.Mail = reader.GetString(4);
                            usuario.Usuario = reader.GetString(5);
                            usuario.FechaNacimiento = reader.GetDateTime(7);
                            usuario.TipoPerfil = reader.GetInt32(8);
                            usuario.Baja = reader.GetString(9);
                            usuarios.Add(usuario);
                        }
                    }
                }
            }

            return usuarios;
        }

        public Usuarios? TraerUsuariosId(int id)
        {
            Usuarios? usuario = null; // Declarar una variable para almacenar el usuario

            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "SELECT Id, Nombre, Apellido, DNI, Mail, Usuario, TipoPerfil, FechaNacimiento, Baja FROM Usuarios WHERE Id = @Id";
                    comando.Parameters.AddWithValue("@Id", id); // Agregar el parámetro Id

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario = new Usuarios();
                            usuario.Id = reader.GetInt32(0);
                            usuario.Nombre = reader.GetString(1);
                            usuario.Apellido = reader.GetString(2);
                            usuario.DNI = reader.GetString(3);
                            usuario.Mail = reader.GetString(4);
                            usuario.Usuario = reader.GetString(5);
                            usuario.TipoPerfil = reader.GetInt32(6);
                            usuario.FechaNacimiento = reader.GetDateTime(7);
                            usuario.Baja = reader.GetString(8);
                        }
                    }
                }
            }
            return usuario;
        }

    }
}
