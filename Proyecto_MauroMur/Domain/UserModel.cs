using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Common.Models;
using Proyecto_MauroMur.Domain;

namespace Domain
{
    public class UserModel
    {
        UserDatos userDatos = new UserDatos();
        public bool LoginUser(string user,string pass)
        {
            return userDatos.Login(user,pass);
        }

        public bool AgregarNuevoUsuario(string user, string contrasena, int tipoPerfil, string nombre, string apellido, string dni, string mail, DateTime fechaNacimiento)
        {
            // Generar el hash de la contraseña
            string hashContrasena = BCrypt.Net.BCrypt.HashPassword(contrasena);

            // Llamar al método para agregar usuario de UserDatos
            return userDatos.AgregarUsuario(nombre, apellido, dni, fechaNacimiento, mail, user, hashContrasena, tipoPerfil);
        }


        public List<UsuarioConInformacion> MostrarUsers()
        {
            return userDatos.ObtenerUsuarios();
        }

        public UsuarioConInformacion? ImportarUsuarios(int id)
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
            return userDatos.ActualizarUsuario(id,nombre,apellido,dni,mail,usuario,fechaNacimiento,tipoPerfil,baja);
        }

        public List<string> ObtenerPerfiles()
        {
            return userDatos.ObtenerRoles();
        }

        public bool IsValidDni(string dni)
        {
            return userDatos.ExisteDNI(dni);
        }

        public bool IsValidCorreo(string mail)
        {
            return userDatos.ExisteMail(mail);
        }

        public bool IsValidNombreUsuario(string userNombre)
        {
            return userDatos.ExisteNombreUsuario(userNombre);
        }

        public bool IsValidEdad(DateTime fechaNacimiento)
        {
            return userDatos.CumpleCondicionesFechaNacimiento(fechaNacimiento);
        }
    }
}