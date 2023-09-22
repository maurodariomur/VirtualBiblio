using System;
using System.Data.SqlClient;

namespace DataAccess
{
    public abstract class ConnectionToSql
    {
        //Atributos de la Conexion
        private readonly string connectionString;
        protected SqlConnection sqlConnection;

        //Entras la informacion necesaria de tu servidor y instancias una para la conexion
        public ConnectionToSql()
        {
<<<<<<< HEAD
            connectionString = "Server = DESKTOP-FPMGBET\\SQLEXPRESS;Database=bd_virtualBiblio;Integrated Security=true;";
=======
            connectionString = "Server = DESKTOP-KVRTQ1T\\SQLEXPRESS;Database=bd_virtualBiblio;Integrated Security=true;";
>>>>>>> 9129013455edb0a63ab8dc33159872a65dc339f0
            sqlConnection = new SqlConnection(connectionString);
        }

        //es para crear una cadena de conexion
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

    }
}