using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class DatabaseBackupManager : ConnectionToSql
    {
        public DatabaseBackupManager() : base() { }

        public DataTable ObtenerBasesDeDatos()
        {
            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();

                    string query = "SELECT name FROM sys.databases WHERE databaseid > 4";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        DataTable dt = new DataTable();
                        dt.Load(cmd.ExecuteReader());
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool RealizarBackup(string nombreBaseDeDatos, string rutaCarpeta)
        {
            try
            {
                string backupFileName = rutaCarpeta + "\\Backup" + nombreBaseDeDatos + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".bak";

                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = $"BACKUP DATABASE [{nombreBaseDeDatos}] TO DISK = '{backupFileName}'";
                        cmd.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool RealizarRestauracion(string nombreBaseDeDatos, string rutaArchivoRespaldo)
        {
            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();

                    // Asegúrate de que no haya conexiones activas a la base de datos que deseas restaurar
                    CerrarConexionesActivas(nombreBaseDeDatos, connection);

                    // Realizar la restauración
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = $"USE master; RESTORE DATABASE [{nombreBaseDeDatos}] FROM DISK = '{rutaArchivoRespaldo}' WITH REPLACE;";
                        cmd.ExecuteNonQuery();
                    }

                    // Volver a la base de datos original
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = $"USE [{nombreBaseDeDatos}];";
                        cmd.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CerrarConexionesActivas(string nombreBaseDeDatos, SqlConnection connection)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = connection;
                cmd.CommandText = $@"
            ALTER DATABASE [{nombreBaseDeDatos}]
            SET SINGLE_USER
            WITH ROLLBACK IMMEDIATE;
        ";
                cmd.ExecuteNonQuery();
            }
        }
    }
}