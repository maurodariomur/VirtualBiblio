using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Domain
{
    public class UserModel
    {
        UserDatos userDatos = new UserDatos();
        public bool LoginUser(string user,string pass)
        {
            return userDatos.Login(user,pass);
        }
        public bool AgregarNuevoUsuario(string nombre, string apellido, string dni, DateTime fechaNacimiento, string mail, string usuario, string contrasena, int tipoPerfil)
        {
            // Generar el hash de la contraseña
            string hashContrasena = BCrypt.Net.BCrypt.HashPassword(contrasena);

            // Llamar al método para agregar usuario de UserDatos
            return userDatos.AgregarUsuario(nombre, apellido, dni, fechaNacimiento, mail, usuario, hashContrasena, tipoPerfil);
        }
    }
}