using Common.Cache;
using Domain;
using Proyecto_MauroMur.Common.Models;
using Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionVendedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionAdministrador
{
    public partial class CHistorialVentas : Form
    {
        private FLobi _lobi;
        SaleModel saleModel = new SaleModel();

        public CHistorialVentas(FLobi lobi)
        {
            InitializeComponent();
            _lobi = lobi;
        }

        private void CHistorialVentas_Load(object sender, EventArgs e)
        {
            List<Ventas> ventas = saleModel.ObtenerTodasVentas();
            dataGridVentas.DataSource = ventas;
            dataGridVentas.Columns["Id_VentaCabecera"].HeaderText = "ID";
            dataGridVentas.Columns["FechaFactura"].HeaderText = "F.Factura";
            dataGridVentas.Columns["MontoTotal"].HeaderText = "Monto Total";
            dataGridVentas.Columns["NombreCliente"].HeaderText = "Nombre";
            dataGridVentas.Columns["ApellidoCliente"].HeaderText = "Apellido";
            concatenacion();
            dataGridVentas.Columns["DNICliente"].HeaderText = "D.N.I Cliente";
            dataGridVentas.Columns["Estado"].HeaderText = "Estado";
            dataGridVentas.Columns["Estado"].DisplayIndex = dataGridVentas.Columns.Count - 1;
            ocultarColumas();
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

            dataGridVentas.RowPrePaint += DataGridProductos_RowPrePaint!;
        }

        private void concatenacion()
        {
            dataGridVentas.Columns.Add("NombreApellidoVendedor", "Nom-Ap.Vendedor");

            dataGridVentas.CellFormatting += (sender, e) =>
            {
                if (e.ColumnIndex == dataGridVentas.Columns["NombreApellidoVendedor"].Index && e.RowIndex >= 0)
                {
                    var nombreVendedor = dataGridVentas.Rows[e.RowIndex].Cells["NombreVendedor"].Value?.ToString();
                    var apellidoVendedor = dataGridVentas.Rows[e.RowIndex].Cells["ApellidoVendedor"].Value?.ToString();
                    if (!string.IsNullOrEmpty(nombreVendedor) && !string.IsNullOrEmpty(apellidoVendedor))
                    {
                        e.Value = $"{nombreVendedor} {apellidoVendedor}";
                        e.FormattingApplied = true;
                    }
                }
            };
        }

        private void ocultarColumas()
        {
            dataGridVentas.Columns["Id_Cliente"].Visible = false;
            dataGridVentas.Columns["Telefono"].Visible = false;
            dataGridVentas.Columns["Domicilio"].Visible = false;
            dataGridVentas.Columns["Id_Usuario"].Visible = false;
            dataGridVentas.Columns["DNIVendedor"].Visible = false;
            dataGridVentas.Columns["TipoPago"].Visible = false;
            dataGridVentas.Columns["TipoFactura"].Visible = false;
            dataGridVentas.Columns["Id_Libro"].Visible = false;
            dataGridVentas.Columns["Titulo"].Visible = false;
            dataGridVentas.Columns["Categoria"].Visible = false;
            dataGridVentas.Columns["NombreEditorial"].Visible = false;
            dataGridVentas.Columns["NombreAutor"].Visible = false;
            dataGridVentas.Columns["PrecioProducto"].Visible = false;
            dataGridVentas.Columns["Cantidad"].Visible = false;
            dataGridVentas.Columns["SubTotalProducto"].Visible = false;
            dataGridVentas.Columns["NombreVendedor"].Visible = false;
            dataGridVentas.Columns["ApellidoVendedor"].Visible = false;
        }

        private void dataGridVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridVentas.Columns["Estado"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridVentas.Rows[e.RowIndex];

                string estadoFactura = selectedRow.Cells["Estado"].Value.ToString()!;

                if (estadoFactura != "inactivo")
                {
                    int idVentaCabecera = Convert.ToInt32(selectedRow.Cells["Id_VentaCabecera"].Value);

                    DialogResult advertencia = MessageBox.Show("¿Esta seguro que desea Cancelar la Factura?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    if (advertencia == DialogResult.OK)
                    {
                        bool estadoCambiado = saleModel.CambiarEstadoFactura(idVentaCabecera);

                        if (estadoCambiado)
                        {
                            MessageBox.Show("El estado de la factura ha sido cambiado a 'inactivo'.");
                            selectedRow.Cells["Estado"].Value = "inactivo";
                        }
                        else
                        {
                            MessageBox.Show("Error al cambiar el estado de la factura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("La factura ya está en estado 'Inactivo'. No se puede cambiar el estado nuevamente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridVentas.Rows[e.RowIndex];
                int idVentaCabecera = Convert.ToInt32(selectedRow.Cells["Id_VentaCabecera"].Value);

                List<Ventas> detallesVenta = saleModel.ObtenerVentasDetalle(idVentaCabecera);
                Ventas cabeceraVentas = saleModel.ObtenerIdCabecera(idVentaCabecera);

                CFacturaReImpresionAdmin detalleForm = new(detallesVenta, cabeceraVentas);
                detalleForm.ShowDialog();
            }
        }

        private void DataGridProductos_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DataGridViewRow row = dataGridVentas.Rows[e.RowIndex];

            string? valorBaja = row.Cells["Estado"].Value.ToString();

            if (valorBaja == "inactivo")
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(243, 106, 106);
                row.DefaultCellStyle.ForeColor = Color.White;
            }
            else
            {
                row.DefaultCellStyle.BackColor = SystemColors.Window;
                row.DefaultCellStyle.ForeColor = SystemColors.ControlText;
            }
        }

        private void filtrarFacturas()
        {
            string dniCliente = txBuscadorDni.Text;
            string nombreCliente = txBuscadorNCliente.Text;
            string apellidoCliente = txBuscadorApellidoC.Text;

            List<Ventas> ventasFiltradas = saleModel.ObtenerVentasConFiltros(nombreCliente, apellidoCliente, dniCliente);

            dataGridVentas.DataSource = ventasFiltradas;
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

            if (fechaDesde < minFechaFactura)
            {
                fechaDesde = minFechaFactura;
            }

            if (fechaHasta > maxFechaFactura)
            {
                fechaHasta = maxFechaFactura;
            }

            dateTimePickerDesde.Value = fechaDesde.Value;
            dateTimePickerHasta.Value = fechaHasta.Value;

            if (fechaDesde <= fechaHasta)
            {
                List<Ventas> ventasFiltradas = saleModel.ObtenerFechas(fechaDesde, fechaHasta);
                dataGridVentas.DataSource = ventasFiltradas;
            }
            else
            {
                MessageBox.Show("Las fechas seleccionadas no son válidas. Asegúrese de que la fecha de inicio sea menor o igual a la fecha de fin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePickerDesde_ValueChanged(object sender, EventArgs e)
        {
            filtrarFechas();
        }

        private void dateTimePickerHasta_ValueChanged(object sender, EventArgs e)
        {
            filtrarFechas();
        }

        private void txBuscadorNCliente_TextChanged(object sender, EventArgs e)
        {
            filtrarFacturas();
        }

        private void txBuscadorApellidoC_TextChanged(object sender, EventArgs e)
        {
            filtrarFacturas();
        }

        private void txBuscadorDni_TextChanged(object sender, EventArgs e)
        {
            filtrarFacturas();
        }
    }
}
