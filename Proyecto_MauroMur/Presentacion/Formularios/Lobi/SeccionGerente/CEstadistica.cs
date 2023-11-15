using System.Windows.Forms.DataVisualization.Charting;
using Common.Models;
using Domain;
using Proyecto_MauroMur.Common.Models;
using Proyecto_MauroMur.Domain;
using Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionAdministrador;

namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionGerente
{
    public partial class CEstadistica : Form
    {
        private StatisticsModel statistics = new();
        private ProductModel product = new ProductModel();
        private UserModel user = new UserModel();
        private SaleModel sale = new SaleModel();
        private FLobi instanciaFLobi;

        public CEstadistica(FLobi lobi)
        {
            this.instanciaFLobi = lobi;
            InitializeComponent();
        }

        private void EndResponsive()
        {
            if (this.Width < 994)
            {
                tableLayoutPanel2.ColumnStyles[1].Width = 350;

            }
            else if (this.Width < 1010)
            {
                tableLayoutPanel2.ColumnStyles[1].Width = tableLayoutPanel2.Width - (chart1.Width + chart1.Margin.Right);
                chart1.Width = 328;
                chart2.Width = 328;
            }
            else
            {
                tableLayoutPanel2.ColumnStyles[1].Width = tableLayoutPanel2.Width - (chart1.Width + chart2.Width + chart1.Margin.Right + chart2.Margin.Right);
            }

            if (this.Height <= 736)
            {
                panel8.Height = 342;
            }

        }

        private void CEstadistica_Load(object sender, EventArgs e)
        {
            EndResponsive();
            obtenerLibroMayorVenta();
            obtenerLibroMenorVenta();
            lbTotal.Text = "$ " + statistics.ObtenerTotalVendido().ToString();
            obtenerEmpleadoMasExitoso();
            estadisticasVentas(DateTime.MinValue, DateTime.Now);
            estadisticasVendedores(DateTime.MinValue, DateTime.Now);
            estadisticasClientes(DateTime.MinValue, DateTime.Now);
            estadisticasLibros(DateTime.MinValue, DateTime.Now);

            List<Ventas> ventas = sale.ObtenerTodasVentas();
            dgVentas.DataSource = ventas;
            dgVentas.Columns["Id_VentaCabecera"].HeaderText = "ID";
            dgVentas.Columns["FechaFactura"].HeaderText = "F.Factura";
            dgVentas.Columns["MontoTotal"].HeaderText = "Monto Total";
            dgVentas.Columns["NombreCliente"].HeaderText = "Nombre";
            dgVentas.Columns["ApellidoCliente"].HeaderText = "Apellido";
            concatenacion();
            dgVentas.Columns["DNICliente"].HeaderText = "D.N.I Cliente";
            dgVentas.Columns["Estado"].HeaderText = "Estado";
            dgVentas.Columns["Estado"].DisplayIndex = dgVentas.Columns.Count - 1;
            ocultarColumas();
            dateTimePickerDesde.CustomFormat = "dd/MM/yyyy";
            dateTimePickerDesde.Format = DateTimePickerFormat.Custom;
            dateTimePickerHasta.CustomFormat = "dd/MM/yyyy";
            dateTimePickerHasta.Format = DateTimePickerFormat.Custom;

            DateTime? minFechaFactura = sale.ObtenerMinFechaFactura();
            DateTime? maxFechaFactura = sale.ObtenerMaxFechaFactura();

            dateTimePickerDesde.MinDate = minFechaFactura ?? DateTime.MinValue;
            dateTimePickerDesde.MaxDate = maxFechaFactura ?? DateTime.MaxValue;

            dateTimePickerDesde.Value = minFechaFactura ?? DateTime.Now;
            dateTimePickerHasta.Value = maxFechaFactura ?? DateTime.Now;
        }

        private void dgVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgVentas.Columns["Estado"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgVentas.Rows[e.RowIndex];

                string estadoFactura = selectedRow.Cells["Estado"].Value.ToString()!;

                if (estadoFactura != "inactivo")
                {
                    int idVentaCabecera = Convert.ToInt32(selectedRow.Cells["Id_VentaCabecera"].Value);

                    DialogResult advertencia = MessageBox.Show("¿Esta seguro que desea Cancelar la Factura?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    if (advertencia == DialogResult.OK)
                    {
                        bool estadoCambiado = sale.CambiarEstadoFactura(idVentaCabecera);

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
                DataGridViewRow selectedRow = dgVentas.Rows[e.RowIndex];
                int idVentaCabecera = Convert.ToInt32(selectedRow.Cells["Id_VentaCabecera"].Value);

                List<Ventas> detallesVenta = sale.ObtenerVentasDetalle(idVentaCabecera);
                CDetallesVentasEstadistica detalleForm = new(detallesVenta);
                detalleForm.ShowDialog();
            }
        }

        private void concatenacion()
        {
            dgVentas.Columns.Add("NombreApellidoVendedor", "Nom-Ap.Vendedor");

            dgVentas.CellFormatting += (sender, e) =>
            {
                if (e.ColumnIndex == dgVentas.Columns["NombreApellidoVendedor"].Index && e.RowIndex >= 0)
                {
                    var nombreVendedor = dgVentas.Rows[e.RowIndex].Cells["NombreVendedor"].Value?.ToString();
                    var apellidoVendedor = dgVentas.Rows[e.RowIndex].Cells["ApellidoVendedor"].Value?.ToString();
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
            dgVentas.Columns["Id_Cliente"].Visible = false;
            dgVentas.Columns["Telefono"].Visible = false;
            dgVentas.Columns["Domicilio"].Visible = false;
            dgVentas.Columns["Id_Usuario"].Visible = false;
            dgVentas.Columns["DNIVendedor"].Visible = false;
            dgVentas.Columns["TipoPago"].Visible = false;
            dgVentas.Columns["TipoFactura"].Visible = false;
            dgVentas.Columns["Id_Libro"].Visible = false;
            dgVentas.Columns["Titulo"].Visible = false;
            dgVentas.Columns["Categoria"].Visible = false;
            dgVentas.Columns["NombreEditorial"].Visible = false;
            dgVentas.Columns["NombreAutor"].Visible = false;
            dgVentas.Columns["PrecioProducto"].Visible = false;
            dgVentas.Columns["Cantidad"].Visible = false;
            dgVentas.Columns["SubTotalProducto"].Visible = false;
            dgVentas.Columns["NombreVendedor"].Visible = false;
            dgVentas.Columns["ApellidoVendedor"].Visible = false;
        }

        private void filtrarFechas()
        {
            DateTime? fechaDesde = dateTimePickerDesde.Value.Date;
            DateTime? fechaHasta = dateTimePickerHasta.Value.Date;

            DateTime? minFechaFactura = sale.ObtenerMinFechaFactura();
            DateTime? maxFechaFactura = sale.ObtenerMaxFechaFactura();

            dateTimePickerDesde.MinDate = minFechaFactura ?? DateTime.MinValue;
            dateTimePickerDesde.MaxDate = maxFechaFactura ?? DateTime.MaxValue;
            dateTimePickerHasta.MinDate = minFechaFactura ?? DateTime.MinValue;
            dateTimePickerHasta.MaxDate = maxFechaFactura ?? DateTime.MaxValue;

            if (fechaDesde.HasValue && fechaHasta.HasValue)
            {
                List<Ventas> ventasFiltradas = sale.ObtenerFechas(fechaDesde.Value, fechaHasta.Value.AddDays(1));
                dgVentas.DataSource = ventasFiltradas;

                if (fechaDesde.Value > fechaHasta.Value)
                {
                    MessageBox.Show("Las fechas seleccionadas no son válidas. Asegúrese de que la fecha de inicio sea menor o igual a la fecha de fin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void filtrarFacturas()
        {
            string dniCliente = txBuscadorDni.Text;
            string nombreCliente = txBuscadorNCliente.Text;
            string apellidoCliente = txBuscadorApellidoC.Text;

            List<Ventas> ventasFiltradas = sale.ObtenerVentasConFiltros(nombreCliente, apellidoCliente, dniCliente);

            dgVentas.DataSource = ventasFiltradas;
        }

        private void obtenerLibroMayorVenta()
        {
            Libro libro = new Libro();
            int idLibroMayorVendido = statistics.ObtenerLibroMayorVendido();
            libro = product.ObtenerLibroId(idLibroMayorVendido);
            lbLibroMasVendido.Text = libro.Titulo!;

        }

        private void obtenerLibroMenorVenta()
        {
            Libro libro = new Libro();
            int idLibroMenorVendido = statistics.ObtenerLibroMenorVendido();
            libro = product.ObtenerLibroId(idLibroMenorVendido);
            lbLibroMenosVendido.Text = libro.Titulo!;
        }

        private void obtenerEmpleadoMasExitoso()
        {
            Persona persona = new Persona();
            int empleadoMasExitoso = statistics.ObtenerEmpleadoMayoresVenta();

            if (empleadoMasExitoso > 0)
            {
                persona = user.ImportarUsuario(empleadoMasExitoso);
                lbMejorVendedor.Text = persona.Apellido + " " + persona.Nombre;
            }
            else
            {
                lbMejorVendedor.Text = "";
            }
        }

        public void estadisticasVentas(DateTime startDate, DateTime endDate)
        {
            List<Tuple<DateTime, float>> cincoMayoresVentas = statistics.ObtenerCincoMayoresVentas(startDate, endDate);
            chart4.Series.Clear();
            Series series = new Series();
            series.ChartType = SeriesChartType.Column;
            series.Name = "Cinco Mayores Ventas";

            for (int i = 0; i < cincoMayoresVentas.Count; i++)
            {
                DataPoint dataPoint = new DataPoint();
                dataPoint.AxisLabel = cincoMayoresVentas[i].Item1.ToShortDateString();
                dataPoint.YValues = new double[] { (double)cincoMayoresVentas[i].Item2 };
                series.Points.Add(dataPoint);
            }
            chart4.Series.Add(series);
            chart4.Titles.Add("Cinco Mayores Ventas").Font = new Font("Century Gothic", 11, FontStyle.Regular);
            chart4.ChartAreas[0].AxisX.TitleFont = new Font("Century Gothic", 9, FontStyle.Regular);
            chart4.ChartAreas[0].AxisY.TitleFont = new Font("Century Gothic", 9, FontStyle.Regular);
            chart4.ChartAreas[0].AxisX.Title = "Fecha de Venta";
            chart4.ChartAreas[0].AxisY.Title = "Monto Total";
            chart4.Invalidate();
        }

        public void estadisticasLibros(DateTime startDate, DateTime endDate)
        {
            List<Ventas> librosMasVendidos = statistics.MostrarCantidadLibros(startDate, endDate);

            chart3.Series.Clear();
            chart3.Series.Add("Libros Más Vendidos");
            chart3.Series["Libros Más Vendidos"].ChartType = SeriesChartType.Doughnut;

            foreach (Ventas libroMasVendido in librosMasVendidos)
            {
                DataPoint dataPoint = new DataPoint();
                dataPoint.SetValueY(libroMasVendido.Cantidad);
                dataPoint.LegendText = libroMasVendido.Titulo;
                dataPoint.Label = libroMasVendido.Cantidad.ToString();
                dataPoint.LabelForeColor = Color.White;
                dataPoint.Font = new Font("Century Gothic", 14, FontStyle.Italic);
                chart3.Series["Libros Más Vendidos"].Points.Add(dataPoint);
            }

            chart3.Titles.Add("Libros Más Vendidos").Font = new Font("Century Gothic", 11, FontStyle.Regular);
            chart3.Invalidate();
        }

        private void estadisticasVendedores(DateTime startDate, DateTime endDate)
        {
            List<Tuple<string, float>> empleadosDestacados = statistics.EmpleadosDestacados(startDate, endDate);
            chart2.Series.Clear();
            Series series = new Series();
            series.ChartType = SeriesChartType.Column;
            series.Name = "Destacados";

            foreach (var empleado in empleadosDestacados)
            {
                DataPoint dataPoint = new DataPoint();
                dataPoint.YValues = new double[] { empleado.Item2 };

                dataPoint.AxisLabel = empleado.Item1;

                series.Points.Add(dataPoint);
                dataPoint.LabelAngle = -90;
            }
            chart2.Series.Add(series);

            chart2.Titles.Add("Vendedores Destacados").Font = new Font("Century Gothic", 11, FontStyle.Regular);
            chart2.ChartAreas[0].AxisX.TitleFont = new Font("Century Gothic", 9, FontStyle.Regular);
            chart2.ChartAreas[0].AxisY.TitleFont = new Font("Century Gothic", 9, FontStyle.Regular);
            chart2.ChartAreas[0].AxisX.Title = "Vendedores";
            chart2.ChartAreas[0].AxisY.Title = "Total-Ventas";
            chart2.Invalidate();
        }

        private void estadisticasClientes(DateTime startDate, DateTime endDate)
        {
            List<Tuple<string, float>> clientesDestacados = statistics.ClientesDestacados(startDate, endDate);
            chart1.Series.Clear();
            Series series = new Series();
            series.ChartType = SeriesChartType.Bar;
            series.Name = "Destacados";

            foreach (var cliente in clientesDestacados)
            {
                DataPoint dataPoint = new DataPoint();
                dataPoint.YValues = new double[] { cliente.Item2 };
                dataPoint.AxisLabel = cliente.Item1;
                dataPoint.LegendText = cliente.Item1;
                series.Points.Add(dataPoint);
                dataPoint.LabelAngle = -90;
            }
            chart1.Series.Add(series);

            chart1.Titles.Add("Clientes Destacados").Font = new Font("Century Gothic", 11, FontStyle.Regular);
            chart1.ChartAreas[0].AxisX.TitleFont = new Font("Century Gothic", 8, FontStyle.Regular);
            chart1.ChartAreas[0].AxisY.TitleFont = new Font("Century Gothic", 8, FontStyle.Regular);
            chart1.ChartAreas[0].AxisX.Title = "Clientes";
            chart1.ChartAreas[0].AxisY.Title = "Total-Ventas";
            chart1.Invalidate();
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

        private void chart1_Click(object sender, EventArgs e)
        {
            CFiltroTiempo filtro = new(this, chart1);
            filtro.ShowDialog();
        }

        private void chart2_Click(object sender, EventArgs e)
        {
            CFiltroTiempo filtro = new(this, chart2);
            filtro.ShowDialog();
        }

        private void chart3_Click(object sender, EventArgs e)
        {
            CFiltroTiempo filtro = new(this, chart3);
            filtro.ShowDialog();
        }

        private void chart4_Click(object sender, EventArgs e)
        {
            CFiltroTiempo filtro = new(this, chart4);
            filtro.ShowDialog();
        }

        public void ActualizarGrafico(Chart chart, DateTime startDate, DateTime endDate)
        {
            if (chart == chart3)
            {
                estadisticasLibros(startDate, endDate);
            }
            else if (chart == chart2)
            {
                estadisticasVendedores(startDate, endDate);
            }
            else if (chart == chart1)
            {
                estadisticasClientes(startDate, endDate);
            }
            else if (chart == chart4)
            {
                estadisticasVentas(startDate, endDate);
            }
        }

    }
}
