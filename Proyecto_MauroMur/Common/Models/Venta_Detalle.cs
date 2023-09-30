using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_MauroMur.Common.Models
{
    public class Venta_Detalle
    {
        public int Id_VentaDetalle { get; set; }
        public float PrecioProducto { get; set; }
        public int Cantidad {get; set; }
        public float SubTotalProducto { get; set; }
        public int Id_Libro { get; set; }
        public int Id_VentaCabecera { get; set; }
    }
}
