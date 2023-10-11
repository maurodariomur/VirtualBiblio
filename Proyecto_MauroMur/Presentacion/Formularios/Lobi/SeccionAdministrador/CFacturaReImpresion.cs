using Domain;
using FontAwesome.Sharp;
using Proyecto_MauroMur.Common.Models;
using Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionAdministrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionVendedor
{
    public partial class CFacturaReImpresionAdmin : Form
    {
        private SaleModel sale = new SaleModel();
        private List<Ventas> _detallesVenta;
        Ventas _cabeceraVentas;

        public CFacturaReImpresionAdmin(List<Ventas> detallesVenta,Ventas cabeceraVentas)
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

    }
}
