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

        public List<Ventas> ObtenerVentasPorUsuarioConNombres(int idUsuario)
        {
            return saleDatos.ObtenerVentasPorUsuarioConNombres(idUsuario);
        }

        public List<Ventas> ObtenerTodasVentas()
        {
            return saleDatos.ObtenerHistorialVentas();
        }

        public List<Ventas> ObtenerVentasDetalle(int idCabecera)
        {
            return saleDatos.ObtenerDetallesVenta(idCabecera);
        }

        public List<Ventas> ObtenerVentasConFiltros(string nombreCliente, string apellidoCliente, string dniCliente)
        {
            return saleDatos.ObtenerVentasConFiltros(nombreCliente, apellidoCliente, dniCliente);
        }


        public List<Ventas> ObtenerFechas(DateTime? fechaFacturaDesde, DateTime? fechaFacturaHasta)
        {
            return saleDatos.ObtenerFechasFiltros(fechaFacturaDesde, fechaFacturaHasta);
        }

        public DateTime? ObtenerMinFechaFactura()
        {
            return saleDatos.ObtenerMinFechaFactura();
        }

        public DateTime? ObtenerMaxFechaFactura()
        {
            return saleDatos.ObtenerMaxFechaFactura();
        }

        public bool CambiarEstadoFactura(int idVentaCabecera)
        {
            return saleDatos.CambiarEstadoFactura(idVentaCabecera);
        }

        public Ventas ObtenerIdCabecera(int idCabecera)
        {
            return saleDatos.ObtenerVentaPorIdCabecera(idCabecera);
        }
    }
}
