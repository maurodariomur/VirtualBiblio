using Domain;
using FontAwesome.Sharp;
using Proyecto_MauroMur.Common.Models;
using Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionAdministrador;
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
    public partial class CFacturaReImpresion : Form
    {
        private SaleModel sale = new SaleModel();
        private List<Ventas> _detallesVenta;
        Ventas _cabeceraVentas;

        public CFacturaReImpresion(List<Ventas> detallesVenta, Ventas cabeceraVentas)
        {
            InitializeComponent();
            _detallesVenta = detallesVenta;
            _cabeceraVentas = cabeceraVentas;
        }

        private void CFacturaReImpresion_Load(object sender, EventArgs e)
        {
            string carpetaDestino = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Presentacion/Formularios/Pictures/Sistema/");
            carpetaDestino = Path.GetFullPath(carpetaDestino);
            pictureBox1.Image = Image.FromFile(carpetaDestino + "encabezado.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = Image.FromFile(carpetaDestino + "pie.png");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            datosCabecera();
            dataGridFactura.DataSource = _detallesVenta;
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
            lbNumeroFactura.Text = "Factura N°:" + _cabeceraVentas.Id_VentaCabecera.ToString();
            lbNombreCliente.Text = "Cliente: " + _cabeceraVentas.NombreCliente!.ToString();
            lbDNICliente.Text = "DNI: " + _cabeceraVentas.DNICliente!.ToString();
            lbTelefono.Text = "Telefono: " + _cabeceraVentas.Telefono?.ToString();
            lbDireccion.Text = "Direccion: " + _cabeceraVentas.Domicilio?.ToString();
            lbPago.Text = "Metodo De Pago: " + _cabeceraVentas.TipoPago;
            lbFactura.Text = "Tipo De Factura: " + _cabeceraVentas.TipoFactura;
            lbFechaFactura.Text = "Fecha " + _cabeceraVentas.FechaFactura.ToString();
            lbNombreVendedor.Text = "Vendedor: " + _cabeceraVentas.NombreVendedor!.ToString();
            lbDNIVendedor.Text = "DNI: " + _cabeceraVentas.DNIVendedor?.ToString();
            lbTotal.Text = "Total: $" + _cabeceraVentas.MontoTotal.ToString();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconImprimir_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintPage);
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1169);
                printDocument.DefaultPageSettings.Landscape = false;
                printDocument.DefaultPageSettings.Margins = new Margins(50, 50, 50, 50);

                printDocument.PrintPage += (s, ev) =>
                {
                    Graphics graphics = ev.Graphics!;
                    ev.HasMorePages = false;
                };

                printDocument.Print();
            }
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font fuente = new Font("Century Gothic", 12);
            Font fuenteTitulo = new Font("Britannic Bold", 20);


            string carpetaDestino = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Presentacion/Formularios/Pictures/Sistema/");
            carpetaDestino = Path.GetFullPath(carpetaDestino);
            Image encabezado = Image.FromFile(carpetaDestino + "encabezado.png");

            Image pie = Image.FromFile(carpetaDestino + "pie.png");

            float x = 100;
            float y = 100;

            float anchoPagina = e.PageBounds.Width;
            float altoImagenEncabezado = (encabezado.Height * anchoPagina) / encabezado.Width;

            float altoImagenPie = (pie.Height * anchoPagina) / pie.Width;

            if (encabezado != null)
            {
                graphics.DrawImage(encabezado, new RectangleF(0, 0, anchoPagina, altoImagenEncabezado));
                y = 85;
            }

            string titulo = "VirtualBiblio";
            SizeF sizeTitulo = graphics.MeasureString(titulo, fuenteTitulo);
            float xTitulo = anchoPagina - sizeTitulo.Width - 185; // 40 es el espacio desde el margen derecho
            float yTitulo = y;
            graphics.DrawString(titulo, fuenteTitulo, Brushes.Black, xTitulo, yTitulo);
            yTitulo += sizeTitulo.Height + 5; // Incrementa el valor de 'y' para colocar el contenido debajo del título

            // Imprimir los datos debajo del título
            y = yTitulo + 100; // Establece un margen de 10 unidades debajo del título
            graphics.DrawString("Factura N°: " + _cabeceraVentas.Id_VentaCabecera.ToString(), fuente, Brushes.Black, x, y);

            string tipoFactura = "Tipo de Factura: " + _cabeceraVentas.TipoFactura;
            SizeF sizeTipoFactura = graphics.MeasureString(tipoFactura, fuente);
            float xTipoFactura = x + sizeTipoFactura.Width + 25; // Añade un margen de 25 unidades entre "Número de Factura" y "Tipo de Factura"
            graphics.DrawString(tipoFactura, fuente, Brushes.Black, xTipoFactura, y);

            y += Math.Max(sizeTipoFactura.Height, fuente.GetHeight()); 

            string cliente = "Cliente: " + _cabeceraVentas.NombreCliente!.ToString();
            string dni = "DNI: " + _cabeceraVentas.DNICliente!.ToString();
            SizeF sizeCliente = graphics.MeasureString(cliente, fuente);
            SizeF sizeDNI = graphics.MeasureString(dni, fuente);
            float xDNI = x + sizeCliente.Width + 25; // Añade un margen de 10 unidades entre "Cliente" y "DNI"
            graphics.DrawString(cliente, fuente, Brushes.Black, x, y);
            graphics.DrawString(dni, fuente, Brushes.Black, xDNI, y);
            y += Math.Max(sizeCliente.Height, sizeDNI.Height); // Asegura que la altura sea la mayor de ambas

            string telefono = "Telefono: " + _cabeceraVentas.Telefono?.ToString();
            string direccion = "Direccion: " + _cabeceraVentas.Domicilio?.ToString();
            SizeF sizeTelefono = graphics.MeasureString(telefono, fuente);
            SizeF sizeDireccion = graphics.MeasureString(direccion, fuente);
            float xDireccion = x + sizeTelefono.Width + 25; // Añade un margen de 10 unidades entre "Telefono" y "Direccion"
            graphics.DrawString(telefono, fuente, Brushes.Black, x, y);
            graphics.DrawString(direccion, fuente, Brushes.Black, xDireccion, y);
            y += Math.Max(sizeTelefono.Height, sizeDireccion.Height); // Asegura que la altura sea la mayor de ambas

            graphics.DrawString("Metodo De Pago: " + _cabeceraVentas.TipoPago, fuente, Brushes.Black, x, y);
            y += fuente.GetHeight();

            graphics.DrawString("Fecha: " + _cabeceraVentas.FechaFactura.ToString(), fuente, Brushes.Black, x, y);
            y += fuente.GetHeight();

            if (pie != null)
            {
                graphics.DrawImage(pie, new RectangleF(0, e.PageBounds.Height - altoImagenPie, anchoPagina, altoImagenPie));
            }
            e.HasMorePages = false;
        }
    }
}
