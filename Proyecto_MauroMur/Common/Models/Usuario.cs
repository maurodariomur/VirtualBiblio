using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string? UserNombre { get; set; }
        public int TipoPerfil { get; set; }
        public int id_Persona { get; set; }
    }
}
