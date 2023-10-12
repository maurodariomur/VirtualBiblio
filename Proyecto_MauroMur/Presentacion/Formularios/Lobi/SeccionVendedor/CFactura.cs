using Domain;
using FontAwesome.Sharp;
using Proyecto_MauroMur.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionVendedor
{
    public partial class CFactura : Form
    {
        FLobi flobi = new FLobi();
        private Ventas factura = new Ventas();
        private SaleModel sale = new SaleModel();
        int pagina = 0;

        public CFactura(FLobi flobi, Ventas _venta)
        {
            InitializeComponent();
            this.flobi = flobi;
            factura = _venta;

            printReporte.Text = "Factura";
            printReporte.WindowState = FormWindowState.Maximized;
        }

        private void CFactura_Load(object sender, EventArgs e)
        {
            string carpetaDestino = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Presentacion/Formularios/Pictures/Sistema/");
            carpetaDestino = Path.GetFullPath(carpetaDestino);
            pictureBox1.Image = Image.FromFile(carpetaDestino + "encabezado.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = Image.FromFile(carpetaDestino + "pie.png");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            datosCabecera();
            dataGridFactura.DataSource = sale.ObtenerDetalleFacturaUltimaCabecera()!;
            DatosOcultos();
        }

        private void DatosOcultos()
        {
            DataGridViewColumnCollection columns = dataGridFactura.Columns;
            columns["Id_VentaCabecera"].Visible = false;
            columns["FechaFactura"].Visible = false;
            columns["MontoTotal"].Visible = false;
            columns["Id_Cliente"].Visible = false;
            columns["NombreCliente"].Visible = false;
            columns["ApellidoCliente"].Visible = false;
            columns["DNICliente"].Visible = false;
            columns["Telefono"].Visible = false;
            columns["Domicilio"].Visible = false;
            columns["Id_Usuario"].Visible = false;
            columns["NombreVendedor"].Visible = false;
            columns["ApellidoVendedor"].Visible = false;
            columns["DNIVendedor"].Visible = false;
            columns["TipoPago"].Visible = false;
            columns["Id_Libro"].Visible = false;
            columns["PrecioProducto"].Visible = false;
            columns["Categoria"].Visible = false;
            columns["TipoFactura"].Visible = false;
            columns["Estado"].Visible = false;
            dataGridFactura.Columns["NombreEditorial"].HeaderText = "Editorial";
            dataGridFactura.Columns["NombreAutor"].HeaderText = "Autor";
            dataGridFactura.Columns["PrecioProducto"].HeaderText = "Precio Unitario";
            dataGridFactura.Columns["SubTotalProducto"].HeaderText = "Sub-Total";
            dataGridFactura.Columns["SubTotalProducto"].DisplayIndex = dataGridFactura.Columns.Count - 1;
        }

        private void datosCabecera()
        {
            lbNumeroFactura.Text = "Factura N°:" + sale.ObtenerUltimoIdVentaCabecera().ToString();
            lbNombreCliente.Text = "Cliente: " + factura.NombreCliente!.ToString();
            lbDNICliente.Text = "DNI: " + factura.DNICliente!.ToString();
            lbTelefono.Text = "Telefono: " + factura.Telefono!.ToString();
            lbDireccion.Text = "Direccion: " + factura.Domicilio!.ToString();
            lbPago.Text = "Metodo De Pago: " + factura.TipoPago;
            lbFactura.Text = "Tipo De Factura: " + factura.TipoFactura;
            lbFechaFactura.Text = "Fecha " + factura.FechaFactura.ToString();
            lbNombreVendedor.Text = "Vendedor: " + factura.NombreVendedor!.ToString();
            lbDNIVendedor.Text = "DNI: " + factura.DNIVendedor!.ToString();
            lbTotal.Text = "Total: $" + factura.MontoTotal.ToString();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            this.Close(); // Oculta el formulario actual
            flobi.FormClosed += (s, args) => this.Close(); // Cierra CFactura cuando se cierre FLobi
            flobi.Show();
        }

        private void dataGridFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconImprimir_Click(object sender, EventArgs e)
        {
            PrintDocument document = new PrintDocument();
            document.DefaultPageSettings.Color = true;
            document.DefaultPageSettings.PaperSize = new PaperSize("Carta", 850, 1100);
            document.DefaultPageSettings.Landscape = false;
            pagina = 0;

            document.DocumentName = "Factura";
            printReporte.Document = document;

            //document.PrintPage += new PrintPageEventHandler();

            printReporte.Activate();
            printReporte.ShowDialog();
            document.Dispose();

        }
    }
}
