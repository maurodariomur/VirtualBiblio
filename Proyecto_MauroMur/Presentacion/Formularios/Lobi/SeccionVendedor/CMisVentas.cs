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

            // Obtén las fechas mínimas y máximas de la base de datos
            DateTime? minFechaFactura = saleModel.ObtenerMinFechaFactura();
            DateTime? maxFechaFactura = saleModel.ObtenerMaxFechaFactura();

            // Configura los valores mínimos y máximos para el dateTimePickerDesde
            dateTimePickerDesde.MinDate = minFechaFactura ?? DateTime.MinValue;
            dateTimePickerDesde.MaxDate = maxFechaFactura ?? DateTime.MaxValue;

            // Configura los valores iniciales de dateTimePickerDesde y dateTimePickerHasta
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
            dataGridMisVentas.Columns["FechaFactura"].HeaderText = "F.Factura";
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
        }

        private void dataGridMisVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != dataGridMisVentas.Columns["Estado"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridMisVentas.Rows[e.RowIndex];

                int idVentaCabecera = Convert.ToInt32(selectedRow.Cells["Id_VentaCabecera"].Value);

                List<Ventas> detallesVenta = saleModel.ObtenerVentasDetalle(idVentaCabecera);

                CMisDetalles detalleForm = new(detallesVenta);
                detalleForm.ShowDialog();
            }
        }

        private void FiltrarFacturas()
        {
            string textoBusquedaNombre = txBuscadorNombre.Text.ToLower();
            string textoBusquedaApellido = txBuscadorApellido.Text.ToLower();
            string textoBusquedaDNI = txBuscadorDni.Text.ToLower();

            List<Ventas> ventasFiltradas = saleModel.ObtenerVentasConFiltros(textoBusquedaNombre, textoBusquedaApellido, textoBusquedaDNI);

            dataGridMisVentas.DataSource = ventasFiltradas;
        }

        private void filtrarFechas()
        {
            DateTime? fechaDesde = dateTimePickerDesde.Value;
            DateTime? fechaHasta = dateTimePickerHasta.Value;

            // Obtén las fechas mínimas y máximas de la base de datos
            DateTime? minFechaFactura = saleModel.ObtenerMinFechaFactura();
            DateTime? maxFechaFactura = saleModel.ObtenerMaxFechaFactura();

            // Establece los valores mínimos y máximos para los seleccionadores de fecha
            dateTimePickerDesde.MinDate = minFechaFactura ?? DateTime.MinValue;
            dateTimePickerDesde.MaxDate = maxFechaFactura ?? DateTime.MaxValue;
            dateTimePickerHasta.MinDate = minFechaFactura ?? DateTime.MinValue;
            dateTimePickerHasta.MaxDate = maxFechaFactura ?? DateTime.MaxValue;

            // Asegúrate de que las fechas seleccionadas estén dentro del rango válido
            if (fechaDesde < minFechaFactura)
            {
                fechaDesde = minFechaFactura;
            }

            if (fechaHasta > maxFechaFactura)
            {
                fechaHasta = maxFechaFactura;
            }

            // Actualiza los valores de los seleccionadores de fecha
            dateTimePickerDesde.Value = fechaDesde.Value;
            dateTimePickerHasta.Value = fechaHasta.Value;

            // Verifica que las fechas estén dentro del rango válido
            if (fechaDesde <= fechaHasta)
            {
                // Realiza la consulta con las fechas seleccionadas
                List<Ventas> ventasFiltradas = saleModel.ObtenerFechas(fechaDesde, fechaHasta);
                dataGridMisVentas.DataSource = ventasFiltradas;
            }
            else
            {
                // Si las fechas no están en orden válido, puedes mostrar un mensaje al usuario o tomar la acción adecuada.
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
