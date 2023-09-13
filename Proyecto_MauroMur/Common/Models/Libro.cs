using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    internal class Libro
    {
        public int Id_Libro { get; set; }
        public string? Titulo { get; set; }
        public string? Descripcion { get; set; }
        public double   Precio { get; set; }
        public string? Imagen { get; set; }
        public Image? ImagenPortada { get; set; }
        public int     Stock { get; set; }
        public string? Baja { get; set; }
        public int     Id_Categoria { get; set; }
        public int     Id_Editorial { get; set; }
        public int     Id_Autor { get; set; }
        public string? Categoria { get; set; }
        public string? Editorial { get; set; }
        public string? Autor { get; set; } 
    }
}
