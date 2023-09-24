using FontAwesome.Sharp;
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
        public CFactura()
        {
            InitializeComponent();
        }

        private void CFactura_Load(object sender, EventArgs e)
        {
            string carpetaDestino = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Presentacion/Formularios/Pictures/Sistema/");
            carpetaDestino = Path.GetFullPath(carpetaDestino);
            pictureBox1.Image = Image.FromFile(carpetaDestino + "encabezado.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.Image = Image.FromFile(carpetaDestino + "pie.png");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            this.Close(); // Oculta el formulario actual
            FLobi flobi = new FLobi();
            flobi.FormClosed += (s, args) => this.Close(); // Cierra CFactura cuando se cierre FLobi
            flobi.Show();
        }
    }
}
