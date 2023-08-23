using Proyecto_MauroMur.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Proyecto_MauroMur.Modelos;

namespace Proyecto_MauroMur.Peticiones
{
    internal class PeticionUsuarios
    {
        private readonly ConnectMySQL connectMySQL;

        public PeticionUsuarios()
        {
            connectMySQL = new ConnectMySQL();
        }
        public List<User> obtenerUsuarios()
        {
            List<User> usuarios = new(); 
            string query = "SELECT * FROM usuarios";
            MySqlCommand command = new(query, connectMySQL.GetConnection());
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                User user = new()
                {
                    Id = reader.GetInt32(0),
                    Nombre = reader.GetString(1),
                    Apellido = reader.GetString(2),
                    Email = reader.GetString(3),
                    Usuario = reader.GetString(4),
                    Pass = reader.GetString(5),
                    Perfil_Id = reader.GetInt32(6),
                    Domicilio_Id = reader.GetInt32(7),
                    Baja = reader.GetString(8),
                };
                usuarios.Add(user);
            }
            connectMySQL.CloseConnection();
            return usuarios;
        }

    }
}
