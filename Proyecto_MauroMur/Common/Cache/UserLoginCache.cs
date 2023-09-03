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
        public static string? Nombre { get; set; }
        public static string? Apellido { get; set; }
        public static string? DNI { get; set; }
        public static string? Mail { get; set; }
        public static string? Usuario { get; set; }  
        public static int TipoPerfil { get; set; }

        public static void Logout()
        {
            Id = 0; Nombre = null; Apellido = null; DNI = null;Mail = null;Usuario = null;TipoPerfil = 0;
        }
    }
}
