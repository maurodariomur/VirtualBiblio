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
            ocultarColumas();
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
            dateTimePickerDesde.Value = minFechaFactura ?? DateTime.Now; // Establece la fecha mínima o la fecha actual
            dateTimePickerHasta.Value = maxFechaFactura ?? DateTime.Now;

            dataGridVentas.RowPrePaint += DataGridProductos_RowPrePaint!;
        }

        private void concatenacion()
        {
            dataGridVentas.Columns.Add("NombreApellidoVendedor", "Nom-Ap.Vendedor");

            // Luego, puedes usar el evento CellFormatting para concatenar el nombre y el apellido del vendedor en la nueva columna.
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
            // Verifica si el evento fue desencadenado por un clic en la columna "Estado".
            if (e.ColumnIndex == dataGridVentas.Columns["Estado"].Index && e.RowIndex >= 0)
            {
                // Obtiene la fila seleccionada.
                DataGridViewRow selectedRow = dataGridVentas.Rows[e.RowIndex];

                // Verifica el estado actual de la factura.
                string estadoFactura = selectedRow.Cells["Estado"].Value.ToString()!;

                if (estadoFactura != "inactivo")
                {
                    // La factura no está en estado "Inactivo", por lo que se puede cambiar el estado.
                    // Obtén el ID de la venta cabecera de esa fila (asumiendo que la columna que contiene el ID se llama "Id_VentaCabecera").
                    int idVentaCabecera = Convert.ToInt32(selectedRow.Cells["Id_VentaCabecera"].Value);

                    DialogResult advertencia = MessageBox.Show("¿Esta seguro que desea Cancelar la Factura?","Advertencia",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
                    if (advertencia== DialogResult.OK)
                    {
                        bool estadoCambiado = saleModel.CambiarEstadoFactura(idVentaCabecera);

                        if (estadoCambiado)
                        {
                            // Muestra un mensaje o realiza alguna acción después de cambiar el estado de la factura.
                            MessageBox.Show("El estado de la factura ha sido cambiado a 'inactivo'.");

                            // Actualiza la columna "Estado" en la fila seleccionada.
                            selectedRow.Cells["Estado"].Value = "inactivo";
                        }
                        else
                        {
                            // Muestra un mensaje de error si no se pudo cambiar el estado de la factura.
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
                // Si se hace clic en una fila diferente de la columna "Estado", realiza la acción original.
                // Obtiene la fila seleccionada.
                DataGridViewRow selectedRow = dataGridVentas.Rows[e.RowIndex];

                // Obtén el ID de la venta cabecera de esa fila (asumiendo que la columna que contiene el ID se llama "Id_VentaCabecera").
                int idVentaCabecera = Convert.ToInt32(selectedRow.Cells["Id_VentaCabecera"].Value);

                // Llama a la función para obtener los detalles de la venta específica.
                List<Ventas> detallesVenta = saleModel.ObtenerVentasDetalle(idVentaCabecera);

                // Abre el formulario de detalle pasando los detalles de la venta.
                CDetallesVentas detalleForm = new(detallesVenta);
                detalleForm.ShowDialog();
            }
        }

        private void DataGridProductos_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            // Obtén la fila actual
            DataGridViewRow row = dataGridVentas.Rows[e.RowIndex];

            // Verifica el valor de la columna "Baja" (asegúrate de que el nombre de la columna sea correcto)
            string? valorBaja = row.Cells["Estado"].Value.ToString();

            // Define el color de fondo deseado para las filas con "Baja" en "SI"
            if (valorBaja == "inactivo")
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(243, 106, 106);
                row.DefaultCellStyle.ForeColor = Color.White; // Opcional: establecer el color de texto en blanco para mayor visibilidad
            }
            else
            {
                // Restablece el color de fondo y texto para las demás filas (opcional)
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
                dataGridVentas.DataSource = ventasFiltradas;
            }
            else
            {
                // Si las fechas no están en orden válido, puedes mostrar un mensaje al usuario o tomar la acción adecuada.
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
