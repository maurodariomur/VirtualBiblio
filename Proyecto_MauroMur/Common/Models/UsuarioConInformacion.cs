using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class UsuarioConInformacion
    {
        public int Id { get; set; }
        public string? PersonaApellido { get; set; }
        public string? PersonaNombre { get; set; }
        public string? UserNombre { get; set; }
        public string? PerfilNombre { get; set; }
        public string? PersonaDNI { get; set; }
        public string? PersonaMail { get; set; }
        public DateTime PersonaFechaNacimiento { get; set; }
        public int TipoPerfil { get; set; }
        public int Id_Persona { get; set; }
        public string? PersonaBaja { get; set; }
    }
}
