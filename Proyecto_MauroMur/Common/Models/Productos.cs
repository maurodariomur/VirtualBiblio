using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_MauroMur.Common.Models
{
    internal class Productos
    {
        public int Id_Libro { get; set; }
        public string? NombreProducto { get; set; }
        public string? Descripcion { get; set; }
        public float   PrecioUnitario { get; set; }
        public string? Imagen { get; set; }
        public int     Stock { get; set; }
        public string? Baja { get; set; }
        public int     Id_Categoria { get; set; }
        public int     Id_Editorial { get; set; }
        public int     Id_Autor { get; set; }

    }
}
