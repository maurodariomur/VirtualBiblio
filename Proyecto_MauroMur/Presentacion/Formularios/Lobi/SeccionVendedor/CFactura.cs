using FontAwesome.Sharp;
using Proyecto_MauroMur.Common.Models;
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
    public partial class CFactura : Form
    {
        FLobi flobi = new FLobi();
        private Ventas factura = new Ventas();

        public CFactura(FLobi flobi, Ventas _venta)
        {
            InitializeComponent();
            this.flobi = flobi;
            factura = _venta;
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
            dataGridFactura.DataSource = factura.venta_Detalles;
        }

        private void datosCabecera()
        {
            lbNumeroFactura.Text = "Factura N°:" + factura.Id_VentaCabecera.ToString();
            lbNombreCliente.Text = "Cliente: " + factura.NombreCliente!.ToString();
            lbDNICliente.Text = "DNI: " + factura.DNICliente!.ToString();
            lbTelefono.Text = "Telefono: " + factura.Telefono!.ToString();
            lbDireccion.Text = "Direccion: " + factura.Domicilio!.ToString();
            lbFechaFactura.Text = "Fecha " + factura.FechaFactura.ToString();
            lbNombreVendedor.Text = "Vendedor: " + factura.NombreVendedor!.ToString();
            lbDNIVendedor.Text = "DNI: " + factura.DNIVendedor!.ToString();
            lbTotal.Text = "Total: " + factura.MontoTotal.ToString();
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
    }
}
