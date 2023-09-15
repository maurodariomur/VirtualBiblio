using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_MauroMur.Common.Models
{
    internal class Cliente
    {
        public int Id_Persona { get; set; }
        public string? Telefono { get; set; }
        public string? Domicilio { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int id_Persona { get; set; }
    }
}
