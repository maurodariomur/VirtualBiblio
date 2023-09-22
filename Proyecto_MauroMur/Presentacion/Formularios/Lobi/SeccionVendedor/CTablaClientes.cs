using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionVendedor
{
    public partial class CTablaClientes : Form
    {
        public CTablaClientes()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CAgregarCliente agregarCliente = new CAgregarCliente();
            agregarCliente.Show();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string nombre = txNombreCliente.Text;
            string apellido = txApellidoCliente.Text;
            string dni = txDNICliente.Text;
            string mail = txMailCliente.Text;
            DateTime nacimiento = dTFNCliente.Value;
            string baja = checkBoxSi.Checked ? "SI" : "NO";

            // Verificar si algún campo obligatorio está vacío
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) ||
                string.IsNullOrWhiteSpace(dni) || (checkBoxSi.Checked == false && checkBoxNo.Checked == false))
            {
                msgError("Todos los campos obligatorios");
                return;
            }

            // Verificar si el correo electrónico está vacío
            if (string.IsNullOrWhiteSpace(mail))
            {
                msgError("Ingresa una dirección de correo electrónico.");
                return;
            }

            // Validar dirección de correo electrónico
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (!Regex.IsMatch(mail, emailPattern))
            {
                msgError("Ingresa una dirección de correo electrónico válida.");
                return;
            }
        }

        private void msgError(string msg)
        {
            lbErrorModificar.Text = "     " + msg;
            lbErrorModificar.Visible = true;
        }

        private void iconAtrasU_Click(object sender, EventArgs e)
        {
            this.Close();
            CClientesFactura? formularioClienteFac = Application.OpenForms.OfType<CClientesFactura>().FirstOrDefault();

            if (formularioClienteFac != null)
            {
                formularioClienteFac.Show();
            }
        }
    }
}
