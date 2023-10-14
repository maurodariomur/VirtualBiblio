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
            lbNombreCliente.Text = "Cliente: " + factura.NombreCliente!.ToString() + " " + factura.ApellidoCliente!;
            lbDNICliente.Text = "DNI: " + factura.DNICliente!.ToString();
            lbTelefono.Text = "Telefono: " + factura.Telefono!.ToString();
            lbDireccion.Text = "Direccion: " + factura.Domicilio!.ToString();
            lbPago.Text = "Metodo De Pago: " + factura.TipoPago;
            lbFactura.Text = "Tipo De Factura: " + factura.TipoFactura;
            lbFechaFactura.Text = "Fecha " + factura.FechaFactura.ToString();
            lbNombreVendedor.Text = "Vendedor: " + factura.NombreVendedor!.ToString() + " " + factura.ApellidoVendedor;
            lbDNIVendedor.Text = "DNI: " + factura.DNIVendedor!.ToString();
            lbTotal.Text = "Total: $" + factura.MontoTotal.ToString();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            this.Close();
            flobi.FormClosed += (s, args) => this.Close();
            flobi.Show();
        }

        private void dataGridFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            Graphics graphics = e.Graphics!;
            Font fuente = new Font("Century Gothic", 10);
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

            //TITULO
            string titulo = "VirtualBiblio";
            SizeF sizeTitulo = graphics.MeasureString(titulo, fuenteTitulo);
            float xTitulo = anchoPagina - sizeTitulo.Width - 185;
            float yTitulo = y;
            graphics.DrawString(titulo, fuenteTitulo, Brushes.Black, xTitulo, yTitulo);
            yTitulo += sizeTitulo.Height + 5;
            y = yTitulo + 100;

            //NUMERO Y TIPO DE FACTURA
            graphics.DrawString("Factura N°: " + sale.ObtenerUltimoIdVentaCabecera().ToString(), new Font(fuente, FontStyle.Bold), Brushes.Black, x, y);
            string tipoFactura = "Tipo de Factura: " + factura.TipoFactura;
            SizeF sizeTipoFactura = graphics.MeasureString(tipoFactura, fuente);
            float xTipoFactura = x + sizeTipoFactura.Width + 10;
            graphics.DrawString(tipoFactura, new Font(fuente, FontStyle.Bold), Brushes.Black, xTipoFactura, y);
            y += Math.Max(sizeTipoFactura.Height, fuente.GetHeight()) + 20;

            //DATOS DEL CLIENTE
            string datosCliente = "Datos Cliente";
            graphics.DrawString(datosCliente, new Font(fuente.FontFamily, 12, FontStyle.Bold), Brushes.Black, x, y);
            y += new Font(fuente.FontFamily, 12, FontStyle.Bold).GetHeight() + 20;

            string cliente = "Cliente: " + factura.NombreCliente!.ToString() + " " + factura.ApellidoCliente;
            string dni = "DNI: " + factura.DNICliente!.ToString();
            SizeF sizeCliente = graphics.MeasureString(cliente, fuente);
            SizeF sizeDNI = graphics.MeasureString(dni, fuente);
            float xDNI = x + sizeCliente.Width + 25;
            graphics.DrawString(cliente, fuente, Brushes.Black, x, y);
            graphics.DrawString(dni, fuente, Brushes.Black, xDNI, y);
            y += Math.Max(sizeCliente.Height, sizeDNI.Height) + 10;

            string telefono = "Telefono: " + factura.Telefono?.ToString();
            string direccion = "Direccion: " + factura.Domicilio?.ToString();
            SizeF sizeTelefono = graphics.MeasureString(telefono, fuente);
            SizeF sizeDireccion = graphics.MeasureString(direccion, fuente);
            float xDireccion = x + sizeTelefono.Width + 25;
            graphics.DrawString(telefono, fuente, Brushes.Black, x, y);
            graphics.DrawString(direccion, fuente, Brushes.Black, xDireccion, y);
            y += Math.Max(sizeTelefono.Height, sizeDireccion.Height) + 20;

            //METODO DE PAGO Y FECHA
            graphics.DrawString("Metodo De Pago: " + factura.TipoPago, fuente, Brushes.Black, x, y);
            y += fuente.GetHeight() + 20;

            graphics.DrawString("Fecha: " + factura.FechaFactura.ToString(), new Font(fuente, FontStyle.Bold), Brushes.Black, x, y);
            y += fuente.GetHeight() + 20;

            //DATAGRID FACTURA
            string[] columnasDeseadas = { "Cantidad", "Titulo", "Editorial", "Autor", "Sub-Total" };
            int margenIzquierdo = 30;

            // Definir colores y fuentes para el encabezado y el contenido
            Color encabezadoColor = Color.FromArgb(27, 107, 147);
            Color contenidoColor = Color.FromArgb(221, 230, 237);
            Font encabezadoFont = new Font("Century Gothic", 10, FontStyle.Bold);
            Font contenidoFont = new Font("Century Gothic", 8, FontStyle.Regular);

            if (dataGridFactura.Rows.Count > 0)
            {
                y += 2;

                int rowHeight = dataGridFactura.RowTemplate.Height;
                int headerHeight = dataGridFactura.ColumnHeadersHeight;

                // Calcular el ancho total del DataGridView
                int totalWidth = 0;
                foreach (string colName in columnasDeseadas)
                {
                    DataGridViewColumn? col = dataGridFactura.Columns.Cast<DataGridViewColumn>().FirstOrDefault(c => c.Visible && c.HeaderText == colName);
                    if (col != null)
                    {
                        totalWidth += col.Width;
                    }
                }
                int xStart = (int)(x + margenIzquierdo);

                foreach (string colName in columnasDeseadas)
                {
                    DataGridViewColumn? col = dataGridFactura.Columns.Cast<DataGridViewColumn>().FirstOrDefault(c => c.Visible && c.HeaderText == colName);
                    if (col != null)
                    {
                        // Diferenciar el color y la fuente del encabezado
                        e.Graphics!.FillRectangle(new SolidBrush(encabezadoColor), xStart, y, col.Width, headerHeight);

                        // Establecer el ancho del trazo de línea en 0 para las líneas verticales
                        using (Pen pen = new Pen(Color.FromArgb(0, 0, 0), 0))
                        {
                            e.Graphics.DrawRectangle(pen, xStart, y, col.Width, headerHeight);
                        }

                        if (!string.IsNullOrEmpty(col.HeaderText))
                        {
                            float xText = xStart + (col.Width - e.Graphics.MeasureString(col.HeaderText, encabezadoFont).Width) / 2;
                            e.Graphics.DrawString(col.HeaderText, encabezadoFont, Brushes.White, xText, y + 6);
                        }

                        xStart += col.Width;
                    }
                }

                y += headerHeight;

                foreach (DataGridViewRow row in dataGridFactura.Rows)
                {
                    xStart = (int)(x + margenIzquierdo);
                    foreach (string colName in columnasDeseadas)
                    {
                        DataGridViewColumn? col = dataGridFactura.Columns.Cast<DataGridViewColumn>().FirstOrDefault(c => c.Visible && c.HeaderText == colName);
                        if (col != null)
                        {
                            e.Graphics!.FillRectangle(new SolidBrush(contenidoColor), xStart, y, col.Width, rowHeight);
                            using (Pen pen = new Pen(Color.FromArgb(0, 0, 0), 0))
                            {
                                e.Graphics.DrawRectangle(pen, xStart, y, col.Width, rowHeight);
                            }

                            string? cellValue = row.Cells[col.Index].Value != null ? row.Cells[col.Index].Value.ToString() : string.Empty;

                            float xText = xStart + (col.Width - e.Graphics.MeasureString(cellValue, contenidoFont).Width) / 2;
                            e.Graphics.DrawString(cellValue, contenidoFont, Brushes.Black, xText, y + 6);

                            xStart += col.Width;
                        }
                    }

                    y += rowHeight;
                }
            }
            int totalXStart = (int)(x + margenIzquierdo + 525);
            int totalYStart = (int)y + 10;

            string totalText = "Total: $" + factura.MontoTotal.ToString();
            Font totalFont = new Font(dataGridFactura.Font.FontFamily, 11, FontStyle.Bold);
            e.Graphics!.DrawString(totalText, totalFont, Brushes.Black, totalXStart, totalYStart);
            y = totalYStart + (int)e.Graphics.MeasureString(totalText, dataGridFactura.Font).Height + 250;

            // Datos del Vendedor
            string datosVendedor = "Datos Vendedor";
            graphics.DrawString(datosVendedor, new Font(fuente.FontFamily, 12, FontStyle.Bold), Brushes.Black, x, y);
            int button1X = (int)(x + graphics.MeasureString(datosVendedor, new Font(fuente.FontFamily, 12, FontStyle.Bold)).Width + 350); // Ajusta el espacio entre el texto y el botón
            Point button1Location = new Point(button1X, (int)y);
            Size button1Size = new Size(23, 23);
            DrawIconButton(graphics, IconChar.Shop, button1Location, button1Size);
            int textoX = button1X + button1Size.Width + 10; // Ajusta el espacio entre el botón y el texto
            graphics.DrawString("Empresa: VirtualBiblio", fuente, Brushes.Black, textoX, y);

            // Actualiza la posición Y para el siguiente elemento
            y += Math.Max(new Font(fuente.FontFamily, 12, FontStyle.Bold).GetHeight(), button1Size.Height) + 10;

            // Vendedor
            string vendedor = "Vendedor: " + factura.NombreVendedor!.ToString() + " " + factura.ApellidoVendedor;
            graphics.DrawString(vendedor, fuente, Brushes.Black, x, y);

            // Ajusta la posición Y para el DNI del Vendedor (debajo de "Vendedor")
            y += fuente.GetHeight() + 5;

            // Dibuja el segundo botón al lado derecho del texto "Vendedor"
            Size button2Size = new Size(23, 23);
            Point button2Location = new Point((int)(x + graphics.MeasureString(vendedor, fuente).Width + 300), (int)(y - button2Size.Height)); // Ajusta el espacio entre el texto y el botón

            DrawIconButton(graphics, IconChar.Instagram, button2Location, button2Size);
            int textoX2 = button2Location.X + button2Size.Width + 10;
            graphics.DrawString("@priscila_fernandez5", fuente, Brushes.Black, textoX2, button2Location.Y + (button2Size.Height / 2) - (fuente.GetHeight() / 2));
            y += fuente.GetHeight() + 15;
            string dniVendedor = "DNI: " + factura.DNIVendedor!.ToString();
            graphics.DrawString(dniVendedor, fuente, Brushes.Black, x, y - 20);
            Size button3Size = new Size(23, 23);
            Point button3Location = new Point((int)(x + graphics.MeasureString(vendedor, fuente).Width + 300), (int)(y - button3Size.Height));
            DrawIconButton(graphics, IconChar.Instagram, button3Location, button3Size);
            int textoX3 = button3Location.X + button3Size.Width + 10;
            graphics.DrawString("@mauro._mur", fuente, Brushes.Black, textoX3, button3Location.Y + (button3Size.Height / 2) - (fuente.GetHeight() / 2));

            if (pie != null)
            {
                graphics.DrawImage(pie, new RectangleF(0, e.PageBounds.Height - altoImagenPie, anchoPagina, altoImagenPie));
            }

            e.HasMorePages = false;

            if (pie != null)
            {
                graphics.DrawImage(pie, new RectangleF(0, e.PageBounds.Height - altoImagenPie, anchoPagina, altoImagenPie));
            }
            e.HasMorePages = false;
        }

        private void DrawIconButton(Graphics graphics, IconChar iconChar, Point location, Size size)
        {
            using (IconButton iconButton = new IconButton())
            {
                iconButton.BackColor = Color.Transparent;
                iconButton.FlatAppearance.BorderSize = 0;
                iconButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
                iconButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
                iconButton.FlatStyle = FlatStyle.Flat;
                iconButton.IconChar = iconChar;
                iconButton.IconColor = Color.Black;
                iconButton.IconFont = IconFont.Auto;
                iconButton.IconSize = Math.Min(size.Width, size.Height);
                iconButton.ImageAlign = ContentAlignment.MiddleCenter;
                iconButton.Location = location;
                iconButton.Size = size;
                iconButton.Text = string.Empty;
                iconButton.UseVisualStyleBackColor = true;

                Bitmap buttonBitmap = new Bitmap(iconButton.Width, iconButton.Height);
                iconButton.DrawToBitmap(buttonBitmap, new Rectangle(0, 0, buttonBitmap.Width, buttonBitmap.Height));
                graphics.DrawImage(buttonBitmap, location);
            }
        }
    }
}
