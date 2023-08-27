using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Dos librerias importadas
using System.Data;
using System.Data.SqlClient;
using Common.Cache;


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
    }
}
