using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Common.Models;
using Domain;
using Proyecto_MauroMur.Common.Models;
using Proyecto_MauroMur.Domain;

namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionGerente
{
    public partial class CEstadistica : Form
    {
        private StatisticsModel statistics = new();
        private ProductModel product = new ProductModel();
        private UserModel user = new UserModel();
        private SaleModel sale = new SaleModel();

        public CEstadistica()
        {
            InitializeComponent();
            estadisticasVentas();
            estadisticasLibros();
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
            estadisticasVendedores();
            estadisticasClientes();
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
            persona = user.ImportarUsuario(empleadoMasExitoso);
            lbMejorVendedor.Text = persona.Apellido + " " + persona.Nombre;
        }

        private void estadisticasVentas()
        {
            List<Tuple<DateTime, float>> cincoMayoresVentas = statistics.ObtenerCincoMayoresVentas();
            chart4.Series.Clear();
            Series series = new Series();
            series.ChartType = SeriesChartType.Line;
            series.Name = "Cinco Mayores Ventas";

            for (int i = 0; i < cincoMayoresVentas.Count; i++)
            {
                DataPoint dataPoint = new DataPoint();
                dataPoint.AxisLabel = cincoMayoresVentas[i].Item1.ToShortDateString(); // Etiqueta del eje X con la fecha
                dataPoint.YValues = new double[] { (double)cincoMayoresVentas[i].Item2 }; // Monto de la venta
                series.Points.Add(dataPoint);
            }
            chart4.Series.Add(series);
            chart4.Titles.Add("Cinco Mayores Ventas");
            chart4.ChartAreas[0].AxisX.Title = "Fecha de Venta";
            chart4.ChartAreas[0].AxisY.Title = "Monto Total";
            chart4.Invalidate();
        }




        private void estadisticasLibros()
        {
            List<Ventas> librosMasVendidos = statistics.MostrarCantidadLibros();

            chart3.Series.Clear();
            chart3.Series.Add("Libros Más Vendidos");
            chart3.Series["Libros Más Vendidos"].ChartType = SeriesChartType.Pie;

            foreach (Ventas libroMasVendido in librosMasVendidos)
            {
                DataPoint dataPoint = new DataPoint();
                dataPoint.SetValueY(libroMasVendido.Cantidad);
                dataPoint.LegendText = libroMasVendido.Titulo;
                dataPoint.Label = "Venta= " + libroMasVendido.Cantidad;
                chart3.Series["Libros Más Vendidos"].Points.Add(dataPoint);
            }

            chart3.Titles.Add("Libros Más Vendidos");
            chart3.Invalidate();
        }

        private void estadisticasVendedores()
        {
            List<Tuple<string, float>> empleadosDestacados = statistics.EmpleadosDestacados();
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

            chart2.Titles.Add("Vendedores Destacados");
            chart2.ChartAreas[0].AxisX.Title = "Vendedores";
            chart2.ChartAreas[0].AxisY.Title = "Total-Ventas";
            chart2.Invalidate();
        }

        private void estadisticasClientes()
        {
            List<Tuple<string, float>> clientesDestacados = statistics.ClientesDestacados();
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

            chart1.Titles.Add("Clientes Destacados");
            chart1.ChartAreas[0].AxisX.Title = "Clientes";
            chart1.ChartAreas[0].AxisY.Title = "Total-Ventas";
            chart1.Invalidate();
        }

    }
}
