using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_MauroMur.Common.Models
{
    public class Ventas
    {
        //VENTAS CABECERA
        public int Id_VentaCabecera { get; set; }
        public DateTime FechaFactura { get; set; }
        public string? Estado { get; set; }

        //CLIENTE
        public int Id_Cliente { get; set; }
        public string? NombreCliente { get; set; }
        public string? ApellidoCliente { get; set; }
        public string? DNICliente { get; set; }
        public string? Telefono { get; set; }
        public string? Domicilio { get; set; }

        //USUARIO
        public int Id_Usuario { get; set; }
        public string? NombreVendedor { get; set; }
        public string? ApellidoVendedor { get; set; }
        public string? DNIVendedor { get; set; }

        //VENTA DETALLE
        public string? TipoPago { get; set; }
        public string? TipoFactura { get; set; }
        public float MontoTotal { get; set; }
        public int Cantidad { get; set; }
        public float SubTotalProducto { get; set; }

        //LIBRO
        public int Id_Libro { get; set; }
        public string? Titulo { get; set; }
        public string? Categoria { get; set; }
        public string? NombreEditorial { get; set; }
        public string? NombreAutor { get; set; }
        public float PrecioProducto { get; set; }
        
    }
}
