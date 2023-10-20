using Common.Cache;
using Proyecto_MauroMur.Common.Models;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Models;
using Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionAdministrador;

namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionVendedor
{
    public partial class CMisVentas : Form
    {
        private FLobi? lobi;
        SaleModel saleModel = new SaleModel();

        public CMisVentas(FLobi? _lobi)
        {
            InitializeComponent();
            this.lobi = _lobi;
            dateTimePickerDesde.CustomFormat = "dd/MM/yyyy";
            dateTimePickerDesde.Format = DateTimePickerFormat.Custom;
            dateTimePickerHasta.CustomFormat = "dd/MM/yyyy";
            dateTimePickerHasta.Format = DateTimePickerFormat.Custom;

            DateTime? minFechaFactura = saleModel.ObtenerMinFechaFactura();
            DateTime? maxFechaFactura = saleModel.ObtenerMaxFechaFactura();

            dateTimePickerDesde.MinDate = minFechaFactura ?? DateTime.MinValue;
            dateTimePickerDesde.MaxDate = maxFechaFactura ?? DateTime.MaxValue;

            dateTimePickerDesde.Value = minFechaFactura ?? DateTime.Now;
            dateTimePickerHasta.Value = maxFechaFactura ?? DateTime.Now;
        }

        private void CMisVentas_Load(object sender, EventArgs e)
        {
            int idUsuarioActual = UserLoginCache.Id;
            List<Ventas> ventasDelUsuario = saleModel.ObtenerVentasPorUsuarioConNombres(idUsuarioActual);
            ventasDelUsuario = ventasDelUsuario.Where(venta => venta.Estado == "activo").ToList();
            dataGridMisVentas.DataSource = ventasDelUsuario;
            dataGridMisVentas.Columns["Id_VentaCabecera"].HeaderText = "ID";
            dataGridMisVentas.Columns["FechaFactura"].HeaderText = "Fecha Factura";
            dataGridMisVentas.Columns["MontoTotal"].HeaderText = "Monto Total";
            dataGridMisVentas.Columns["NombreCliente"].HeaderText = "Nombre";
            dataGridMisVentas.Columns["ApellidoCliente"].HeaderText = "Apellido";
            dataGridMisVentas.Columns["DNICliente"].HeaderText = "D.N.I Cliente";
            ocultarColumas();
        }

        private void ocultarColumas()
        {
            dataGridMisVentas.Columns["Id_Cliente"].Visible = false;
            dataGridMisVentas.Columns["Telefono"].Visible = false;
            dataGridMisVentas.Columns["Domicilio"].Visible = false;
            dataGridMisVentas.Columns["Id_Usuario"].Visible = false;
            dataGridMisVentas.Columns["DNIVendedor"].Visible = false;
            dataGridMisVentas.Columns["TipoPago"].Visible = false;
            dataGridMisVentas.Columns["TipoFactura"].Visible = false;
            dataGridMisVentas.Columns["Id_Libro"].Visible = false;
            dataGridMisVentas.Columns["Titulo"].Visible = false;
            dataGridMisVentas.Columns["Categoria"].Visible = false;
            dataGridMisVentas.Columns["NombreEditorial"].Visible = false;
            dataGridMisVentas.Columns["NombreAutor"].Visible = false;
            dataGridMisVentas.Columns["PrecioProducto"].Visible = false;
            dataGridMisVentas.Columns["Cantidad"].Visible = false;
            dataGridMisVentas.Columns["SubTotalProducto"].Visible = false;
            dataGridMisVentas.Columns["NombreVendedor"].Visible = false;
            dataGridMisVentas.Columns["ApellidoVendedor"].Visible = false;
            dataGridMisVentas.Columns["Estado"].Visible = false;
        }

        private void dataGridMisVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != dataGridMisVentas.Columns["Estado"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridMisVentas.Rows[e.RowIndex];

                int idVentaCabecera = Convert.ToInt32(selectedRow.Cells["Id_VentaCabecera"].Value);

                Ventas cabeceraVentas = saleModel.ObtenerIdCabecera(idVentaCabecera);
                List<Ventas> detallesVenta = saleModel.ObtenerVentasDetalle(idVentaCabecera);

                CFacturaReImpresion detalleForm = new(detallesVenta, cabeceraVentas);
                detalleForm.ShowDialog();
            }
        }

        private void FiltrarFacturas()
        {
            int idUsuarioActual = UserLoginCache.Id;
            string textoBusquedaNombre = txBuscadorNombre.Text.ToLower();
            string textoBusquedaApellido = txBuscadorApellido.Text.ToLower();
            string textoBusquedaDNI = txBuscadorDni.Text.ToLower();

            List<Ventas> ventasDelUsuario = saleModel.ObtenerVentasPorUsuarioConNombres(idUsuarioActual);
            List<Ventas> ventasFiltradas = ventasDelUsuario
                .Where(venta =>
                    (string.IsNullOrEmpty(textoBusquedaNombre) || venta.NombreCliente!.ToLower().Contains(textoBusquedaNombre)) &&
                    (string.IsNullOrEmpty(textoBusquedaApellido) || venta.ApellidoCliente!.ToLower().Contains(textoBusquedaApellido)) &&
                    (string.IsNullOrEmpty(textoBusquedaDNI) || venta.DNICliente!.ToLower().Contains(textoBusquedaDNI))
                )
                .ToList();
            dataGridMisVentas.DataSource = ventasFiltradas;
        }

        private void filtrarFechas()
        {
            DateTime? fechaDesde = dateTimePickerDesde.Value;
            DateTime? fechaHasta = dateTimePickerHasta.Value;

            DateTime? minFechaFactura = saleModel.ObtenerMinFechaFactura();
            DateTime? maxFechaFactura = saleModel.ObtenerMaxFechaFactura();

            dateTimePickerDesde.MinDate = minFechaFactura ?? DateTime.MinValue;
            dateTimePickerDesde.MaxDate = maxFechaFactura ?? DateTime.MaxValue;
            dateTimePickerHasta.MinDate = minFechaFactura ?? DateTime.MinValue;
            dateTimePickerHasta.MaxDate = maxFechaFactura ?? DateTime.MaxValue;

            // Obtener todas las ventas del usuario
            int idUsuarioActual = UserLoginCache.Id;
            List<Ventas> ventasDelUsuario = saleModel.ObtenerVentasPorUsuarioConNombres(idUsuarioActual);

            if (fechaHasta != null)
            {
                // Ajustar la fecha final para incluir todas las ventas del día
                fechaHasta = fechaHasta.Value.AddDays(1).AddSeconds(-1);
            }

            // Realizar el filtro por fechas
            List<Ventas> ventasFiltradasPorFecha = ventasDelUsuario
                .Where(venta =>
                    venta.FechaFactura >= fechaDesde &&
                    (!fechaHasta.HasValue || venta.FechaFactura <= fechaHasta)
                )
                .ToList();

            dataGridMisVentas.DataSource = ventasFiltradasPorFecha;

            if (fechaDesde > fechaHasta)
            {
                MessageBox.Show("Las fechas seleccionadas no son válidas. Asegúrese de que la fecha de inicio sea menor o igual a la fecha de fin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txBuscadorNombre_TextChanged(object sender, EventArgs e)
        {
            FiltrarFacturas();
        }

        private void txBuscadorApellido_TextChanged(object sender, EventArgs e)
        {
            FiltrarFacturas();
        }

        private void txBuscadorDni_TextChanged(object sender, EventArgs e)
        {
            FiltrarFacturas();
        }

        private void dateTimePickerDesde_ValueChanged(object sender, EventArgs e)
        {
            filtrarFechas();
        }

        private void dateTimePickerHasta_ValueChanged(object sender, EventArgs e)
        {
            filtrarFechas();
        }
    }
}
