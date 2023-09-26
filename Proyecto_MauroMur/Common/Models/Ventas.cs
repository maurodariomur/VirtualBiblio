using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_MauroMur.Common.Models
{
    public class Ventas
    {
        public int Id_VentaCabecera { get; set; }
        public DateTime FechaFactura { get; set; }
        public float MontoTotal { get; set; }
        public int Id_Cliente { get; set; }
        public string? NombreCliente { get; set; }
        public string? ApellidoCliente { get; set; }
        public string? DNICliente { get; set; }
        public string? Telefono { get; set; }
        public string? Domicilio { get; set; }
        public int Id_Usuario { get; set; }
        public string? NombreVendedor { get; set; }
        public string? ApellidoVendedor { get; set; }
        public string? DNIVendedor { get; set; }
        public string? TipoPago { get; set; }
        public int Id_VentaDetalle { get; set; }
        public int Id_Libro { get; set; }
        public string? Titulo { get; set; }
        public string? Categoria { get; set; }
        public string? Editorial { get; set; }
        public string? Autor { get; set; }
        public double Precio { get; set; }
        public float PrecioProducto { get; set; }
        public int Cantidad { get; set; }
        public float SubTotalProducto { get; set; }
        public List<Venta_Detalle>? venta_Detalles { get; set; }
        
    }
}
