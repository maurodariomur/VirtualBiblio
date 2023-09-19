using Org.BouncyCastle.Bcpg.OpenPgp;
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
    public partial class BotonesLibros : UserControl
    {
        private int id = 0;

        public BotonesLibros()
        {
            InitializeComponent();
            btAñadir.Click += delegate { añadirEvento?.Invoke(this, EventArgs.Empty); };
        }

        public int idLibro
        {
            get { return id; }
            set { id = value; }
        }

        public string descripcionLibro
        {
            get { return rtbDescripcionCatalogo.Text; }
            set { rtbDescripcionCatalogo.Text = value; }
        }

        public Image imagenLibro
        {
            get { return pbImagenCatalogo.Image; }
            set { pbImagenCatalogo.Image = value; }
        }

        public string tituloLibro
        {
            get { return lbTituloCatalogo.Text; }
            set { lbTituloCatalogo.Text = value; }
        }

        public string precioLibro
        {
            get { return lbPrecioCatalogo.Text; }
            set { lbPrecioCatalogo.Text = value; }
        }

        public string stockLibro
        {
            get { return lbStockCatalogo.Text; }
            set { lbStockCatalogo.Text = value; }
        }

        public event EventHandler? añadirEvento;
    }
}
