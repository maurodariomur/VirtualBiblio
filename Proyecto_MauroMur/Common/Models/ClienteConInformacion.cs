using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_MauroMur.Common.Models
{
    public class ClienteConInformacion
    {
        public int IdCliente { get; set; }
        public string? PersonaApellido { get; set; }
        public string? PersonaNombre { get; set; }
        public string? PersonaDNI { get; set; }
        public string? PersonaMail { get; set; }
        public DateTime PersonaFechaNacimiento { get; set; }
        public string? Telefono { get; set; }
        public string? Domicilio { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string? PersonaBaja { get; set; }
        public int Id_Persona { get; set; }
    }
}
