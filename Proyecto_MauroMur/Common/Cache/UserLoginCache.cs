using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
    public static class UserLoginCache
    {
        // Propiedades
        public static int Id { get; set; }
        public static string? User { get; set; }
        public static int TipoPerfil { get; set; }
        public static string? Rol { get; set; }
        public static int id_Persona { get; set; }
        public static string? Nombre { get; set; }
        public static string? Apellido { get; set; }
        public static string? DNI { get; set; }
        public static string? Mail { get; set; }
        public static DateTime FechaNacimiento { get; set; }
        public static string? Baja { get; set; }

        public static void Logout()
        {
            Id = 0;
            User = null;
            TipoPerfil = 0;
            Rol = null;
            id_Persona = 0;
            Nombre = null;
            Apellido = null;
            DNI = null;
            Mail = null;
            FechaNacimiento = DateTime.MinValue;
            Baja = null;
        }
    }

}
