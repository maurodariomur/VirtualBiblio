using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class Venta_Cabecera
    {
        public int Id_VentaCabecera { get; set; }
        public DateTime FechaFactura { get; set; }
        public float MontoTotal { get; set; }
        public int Id_Cliente { get; set; }
        public int Id_Usuario { get; set; }
        public int Id_MetodoPago { get; set; }
        public int Id_TipoFactura { get; set; }
        public string? Estado { get; set; }
    }
}
