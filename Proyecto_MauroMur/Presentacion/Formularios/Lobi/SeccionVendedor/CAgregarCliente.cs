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
    public partial class CAgregarCliente : Form
    {
        public CAgregarCliente()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string nombre = txNombreAgCliente.Text;
            string apellido = txApellidoAgCliente.Text;
            string dni = txDNIAgCliente.Text;
            string mail = txMailAgCliente.Text;
            DateTime nacimiento = dTBithAgCliente.Value;
            string domicilio = tbDomicilioAgCliente.Text;
            string telefono = tbTelefonoAgCliente.Text;
            string baja = checkBoxSi.Checked ? "SI" : "NO";

            // Verificar si algún campo obligatorio está vacío
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(dni)
                || (checkBoxSi.Checked == false && checkBoxNo.Checked == false))
            {
                msgError("Por favor, completa todos los campos obligatorios");
                return;
            }

            // Verificar si el correo electrónico está vacío
            if (string.IsNullOrWhiteSpace(mail))
            {
                msgError("Por favor, ingresa una dirección de correo electrónico.");
                return;
            }

            // Validar dirección de correo electrónico
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (!Regex.IsMatch(mail, emailPattern))
            {
                msgError("Por favor, ingresa una dirección de correo electrónico válida.");
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
            CTablaClientes? formularioTablaCli = Application.OpenForms.OfType<CTablaClientes>().FirstOrDefault();

            if (formularioTablaCli != null)
            {
                formularioTablaCli.Show();
            }
        }

        private void txNombreAgCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ignora el carácter ingresado si no es una letra o espacio en blanco
            }
        }

        private void txApellidoAgCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ignora el carácter ingresado si no es una letra o espacio en blanco
            }
        }

        private void txDNIAgCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ignora el carácter ingresado si no es una letra o espacio en blanco
            }
        }

        private void tbTelefonoAgCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ignora el carácter ingresado si no es una letra o espacio en blanco
            }
        }
    }
}
