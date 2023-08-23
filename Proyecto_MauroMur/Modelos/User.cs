using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_MauroMur.Modelos
{
    internal class User
    {
        public int Id {get; set;}

        public string? Nombre { get; set; }

        public string? Apellido { get; set;}

        public string? Email { get; set; }

        public string? Usuario { get; set; }

        public string? Pass { get; set; }

        public int Perfil_Id { get; set; }

        public int Domicilio_Id { get; set; }

        public string? Baja { get; set; }




    }
}
