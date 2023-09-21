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
    public partial class CClientesFactura : Form
    {
        private FLobi flobi = new FLobi();
        private CDetalleCatalogo cDetalleCatalogo;
        public CClientesFactura(CDetalleCatalogo detalleCatalogo)
        {
            InitializeComponent();
            this.cDetalleCatalogo = detalleCatalogo;
        }

        private void CClientesFactura_Load(object sender, EventArgs e)
        {

        }

        private void iconAtrasDet_Click(object sender, EventArgs e)
        {
            this.Hide();
            flobi.Show();
            cDetalleCatalogo.Show();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string nombre = lbNombreApellido.Text;

            if (string.IsNullOrEmpty(nombre) || nombre == "Nombre y Apellido")
            {
                msgError("Debe completar todos los campos");
            }
            else
            {
                this.Close();
                CFactura factura = new CFactura();
                factura.Show();
            }

           
        }

        private void msgError(string msg)
        {
            lbError.Text = "     " + msg;
            lbError.Visible = true;
        }
    }
}
