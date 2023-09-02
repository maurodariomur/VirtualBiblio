using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Common.Models;

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

        public List<Usuarios> MostrarUsers()
        {
            return userDatos.ObtenerUsuarios();
        }

        public Usuarios? ImportarUsuarios(int id)
        {
            return userDatos.TraerUsuariosId(id);
        }

        public string? GetRolName(int tipoPerfil)
        {
            return userDatos.GetRoleName(tipoPerfil);
        }

        public int ObtenerIdTipoPerfil(string tipoSeleccionado)
        {
            int tipoPerfilId = userDatos.ObtenerIdTipoPerfil(tipoSeleccionado);
            return tipoPerfilId;
        }

        public bool ActualizacionEmpleado(int id,string nombre, string apellido, string dni, string mail, string usuario, DateTime fechaNacimiento, int tipoPerfil,string baja)
        {
            // Llamar al método para agregar usuario de UserDatos
            return userDatos.ActualizarUsuario(id,nombre,apellido,dni,mail,usuario,fechaNacimiento,tipoPerfil,baja);
        }
    }
}