using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_MauroMur.Common.Cache
{
    public static class Carrito
    {
        public static int? contador { get; set; } 
        public static List<Libro>? libros { get; set; }
    }
}
