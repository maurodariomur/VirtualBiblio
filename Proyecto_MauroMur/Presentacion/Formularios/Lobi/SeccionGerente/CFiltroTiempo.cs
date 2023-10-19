using Proyecto_MauroMur.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Domain;

namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionGerente
{
    public partial class CFiltroTiempo : Form
    {
        private Chart _chart;
        private CEstadistica _estadisticaForm;
        private SaleModel sale = new SaleModel();

        public CFiltroTiempo(CEstadistica estadisticaForm, Chart grafico)
        {
            InitializeComponent();
            _chart = grafico;
            _estadisticaForm = estadisticaForm;
        }

        private void CFiltroTiempo_Load(object sender, EventArgs e)
        {
            cbFiltroFechas.Items.Add("Seleccione una Opcion");
            cbFiltroFechas.Items.Add("Hoy");
            cbFiltroFechas.Items.Add("Último mes");
            cbFiltroFechas.Items.Add("Últimos 3 meses");
            cbFiltroFechas.Items.Add("Últimos 6 meses");
            cbFiltroFechas.Items.Add("Histórico");

            cbFiltroFechas.SelectedIndex = cbFiltroFechas.Items.IndexOf("Seleccione una Opcion");

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

        private void iconImprimirChart_Click(object sender, EventArgs e)
        {
            this.Close();
            ImprimirGrafico(_chart);
        }

        private void ImprimirGrafico(Chart chart)
        {
            int anchoImpresion = 630;
            int altoImpresion = 630;
            int resolucion = 600;
            string rutaImagen = "grafico.png";

            using (Bitmap chartImage = new Bitmap(anchoImpresion, altoImpresion))
            {
                chart.DrawToBitmap(chartImage, new Rectangle(0, 0, anchoImpresion, altoImpresion));
                chartImage.SetResolution(resolucion, resolucion);
                chartImage.Save(rutaImagen, ImageFormat.Png);
            }

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += (sender, e) =>
            {
                using (Image img = Image.FromFile(rutaImagen))
                {
                    e.Graphics!.DrawImage(img, e.MarginBounds);
                }
            };
            PrintDialog pdialog = new PrintDialog();
            pdialog.Document = pd;
            if (pdialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }

        }

        private void iconClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void filtrarFechas()
        {
            DateTime? fechaDesde = dateTimePickerDesde.Value;
            DateTime? fechaHasta = dateTimePickerHasta.Value.AddDays(1).AddSeconds(-1);

            if (fechaDesde > fechaHasta)
            {
                MessageBox.Show("Las fechas seleccionadas no son válidas. Asegúrese de que la fecha de inicio sea menor o igual a la fecha de fin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DateTime? minFechaFactura = sale.ObtenerMinFechaFactura();
                DateTime? maxFechaFactura = sale.ObtenerMaxFechaFactura();

                dateTimePickerDesde.MinDate = minFechaFactura ?? DateTime.MinValue;
                dateTimePickerDesde.MaxDate = maxFechaFactura ?? DateTime.MaxValue;
                dateTimePickerHasta.MinDate = minFechaFactura ?? DateTime.MinValue;
                dateTimePickerHasta.MaxDate = maxFechaFactura ?? DateTime.MaxValue;

                DateTime startDate = fechaDesde.Value;
                DateTime endDate = fechaHasta.Value;

                _chart.Series.Clear();
                _chart.Titles.Clear();
                _estadisticaForm.ActualizarGrafico(_chart, startDate, endDate);
            }
        }

        private void cbFiltroFechas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFilter = cbFiltroFechas.SelectedItem.ToString()!;
            DateTime currentDate = DateTime.Now;
            DateTime startDate = DateTime.MinValue;
            DateTime endDate = currentDate;

            if (selectedFilter == "Hoy")
            {
                startDate = DateTime.Today;
                endDate = currentDate;
            }
            else if (selectedFilter == "Último mes")
            {
                startDate = currentDate.AddMonths(-1);
                endDate = currentDate;
            }
            else if (selectedFilter == "Últimos 3 meses")
            {
                startDate = currentDate.AddMonths(-3);
                endDate = currentDate;
            }
            else if (selectedFilter == "Últimos 6 meses")
            {
                startDate = currentDate.AddMonths(-6);
                endDate = currentDate;
            }
            else if (selectedFilter == "Histórico")
            {
                startDate = DateTime.MinValue;
                endDate = currentDate;
            }

            _chart.Series.Clear();
            _chart.Titles.Clear();
            _estadisticaForm.ActualizarGrafico(_chart, startDate, endDate);
        }

        private void chBMarcador_CheckedChanged(object sender, EventArgs e)
        {
            if (chBMarcador.Checked)
            {
                lbDesde.Visible = true;
                lbHasta.Visible = true;
                dateTimePickerDesde.Visible = true;
                dateTimePickerHasta.Visible = true;
                cbFiltroFechas.Visible = false;
            }
            else
            {
                lbDesde.Visible = false;
                lbHasta.Visible = false;
                dateTimePickerDesde.Visible = false;
                dateTimePickerHasta.Visible = false;
                cbFiltroFechas.Visible = true;
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
    }
}
