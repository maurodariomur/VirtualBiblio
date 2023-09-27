using Proyecto_MauroMur.Common.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_MauroMur.Domain;


namespace Domain
{
    internal class SaleModel
    {
        private SaleDatos saleDatos = new();

        public bool AgregarNuevaVenta(DateTime fechaFactura, float montoTotal, int idCliente, int idUsuario, int idMetodoPago,int idTipoFactura, List<Venta_Detalle> detalles)
        {
            return saleDatos.AgregarVentaConDetalle(fechaFactura, montoTotal, idCliente, idUsuario, idMetodoPago, idTipoFactura, detalles);
        }

        public bool AgregarNuevaVentaCabecera(DateTime fechaFactura, float montoTotal, int idCliente, int idUsuario, int idMetodoPago, int idTipoFactura)
        {
            return saleDatos.AgregarFactura(fechaFactura, montoTotal, idCliente, idUsuario, idMetodoPago, idTipoFactura);
        }

        public List<string> ObtenerFactura()
        {
            return saleDatos.ObtenerTipoFacturas();
        }

        public List<string> ObtenerPago()
        {
            return saleDatos.ObtenerMetodoPago();
        }

        public int ObtenerIdMetodoPago(string metodoPago)
        {
            int IdMetodoPago = saleDatos.ObtenerIdMetodoPago(metodoPago);
            return IdMetodoPago;
        }

        public int ObtenerIdTipoFactura(string tipoFactura)
        {
            int IdTipoFactura = saleDatos.ObtenerIdTipoFactura(tipoFactura);
            return IdTipoFactura;
        }

        public bool ActualizarStockLibro(int idLibro, int cantidadVendida)
        {
            return saleDatos.ActualizarStockLibro(idLibro, cantidadVendida);
        }

        public int ObtenerUltimoIdVentaCabecera()
        {
            return saleDatos.ObtenerUltimoIdVentaCabecera();
        }

        public List<Ventas> ObtenerDetalleFacturaUltimaCabecera()
        {
            return saleDatos.ObtenerDetalleFacturaUltimaCabecera();
        }

    }
}
