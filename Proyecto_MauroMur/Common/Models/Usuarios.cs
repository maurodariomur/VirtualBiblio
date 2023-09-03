using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class Usuarios
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? DNI { get; set; }
        public string? Mail { get; set; }
        public string? Usuario { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int TipoPerfil { get; set; }
        public string? Baja { get; set; }
    }
  

}
