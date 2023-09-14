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
    public partial class CDetalleCatalogo : Form
    {
        public CDetalleCatalogo()
        {
            InitializeComponent();
        }

        private void btnDCSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
