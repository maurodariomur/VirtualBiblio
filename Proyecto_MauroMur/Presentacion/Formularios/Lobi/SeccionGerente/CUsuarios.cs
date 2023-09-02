using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionGerente
{
    public partial class CUsuarios : Form
    {
        private FLobi intanciaFLobi;

        public CUsuarios(FLobi lobi)
        {
            InitializeComponent();
            this.intanciaFLobi = lobi;
        }

        private void CUsuarios_Load(object sender, EventArgs e)
        {
            txName.Focus();
            // Configura el formato personalizado para el DateTimePicker
            dTBith.CustomFormat = "dd/MM/yyyy";
            // Asegúrate de que la propiedad Format esté establecida en Custom
            dTBith.Format = DateTimePickerFormat.Custom;
        }

        private void btRegistrar_Click_1(object sender, EventArgs e)
        {
            string nombre = txName.Text;
            string apellido = txLastName.Text;
            string dni = txDNI.Text;
            DateTime fechaNacimiento = dTBith.Value;
            string mail = txMail.Text;
            string usuario = txEmpleado.Text;
            string contrasena = txPassword.Text;
            int tipoPerfil = ObtenerTipoPerfilSeleccionado();

            UserModel userModel = new UserModel();

            if (nombre == "Nombre" || apellido == "Apellido" || dni == "DNI" || mail == "Correo Electronico" || usuario == "Usuario")
            {
                msgError("Debe completar todos los campos");
            }
            else if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(dni)
                || string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasena) || string.IsNullOrWhiteSpace(mail))
            {
                msgError("Debe completar todos los campos");
            }
            else if (fechaNacimiento == DateTime.MinValue) // Validación del DateTime
            {
                msgError("Debe seleccionar una fecha de nacimiento válida");
            }
            else if (ObtenerTipoPerfilSeleccionado() == 0)
            {
                msgError("Debe seleccionar un tipo de usuario");
            }
            else if (!IsValidEmail(mail)) // Validación del correo electrónico
            {
                msgError("El correo electrónico ingresado no es válido");
            }
            else
            {
                // Mostrar mensaje de confirmación
                DialogResult confirmResult = MessageBox.Show("¿Está seguro que desea registrar este usuario?", "Confirmar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    bool usuarioAgregado = userModel.AgregarNuevoUsuario(nombre, apellido, dni, fechaNacimiento, mail, usuario, contrasena, tipoPerfil);
                    MessageBox.Show("Usuario agregado exitosamente: " + nombre + " " + apellido, "Empleado Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
            }
        }


        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private int ObtenerTipoPerfilSeleccionado()
        {
            UserModel userModel = new UserModel();

            if (txcPerfil.SelectedItem != null)
            {
                string? tipoSeleccionado = txcPerfil.SelectedItem.ToString();

                // Verificar que tipoSeleccionado no sea nulo o vacío antes de usarlo
                if (!string.IsNullOrWhiteSpace(tipoSeleccionado))
                {
                    // Utiliza el método ObtenerIdTipoPerfil para obtener el Id del tipo de perfil
                    int tipoPerfilId = userModel.ObtenerIdTipoPerfil(tipoSeleccionado);

                    // Si se encontró el tipo de perfil en la base de datos, devuelve su Id
                    if (tipoPerfilId != -1)
                    {
                        return tipoPerfilId;
                    }
                }
            }
            return 0; // Opción por defecto si no se selecciona nada o no se encuentra en la base de datos
        }

        private void LimpiarCampos()
        {
            txName.Text = "Nombre";
            txLastName.Text = "Apellido";
            txDNI.Text = "DNI";
            dTBith.Value = DateTime.Now; // Puedes establecer la fecha actual u otra fecha predeterminada
            txMail.Text = "Correo Electronico";
            txEmpleado.Text = "Usuario";
            txPassword.Text = "Contraseña";
            txcPerfil.SelectedIndex = -1; // Desseleccionar el ComboBox
            txcPerfil.Text = "Seleccione un Tipo de perfil";
            txName.Focus();

            // Hacer invisible el botón contraVisible
            contraVisible.Visible = false;

            // Asegurarse de que el campo de contraseña oculte el texto
            txPassword.UseSystemPasswordChar = true;
        }

        private void msgError(string msg)
        {
            lbError.Text = "     " + msg;
            lbError.Visible = true;
        }

        private void txName_Enter_1(object sender, EventArgs e)
        {
            if (txName.Text == "Nombre")
            {
                txName.Text = "";
            }
        }

        private void txName_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txName.Text))
            {
                txName.Text = "Nombre";
            }
        }

        private void txLastName_Enter_1(object sender, EventArgs e)
        {
            if (txLastName.Text == "Apellido")
            {
                txLastName.Text = "";
            }
        }

        private void txLastName_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txLastName.Text))
            {
                txLastName.Text = "Apellido";
            }
        }

        private void txMail_Enter_1(object sender, EventArgs e)
        {
            if (txMail.Text == "Correo Electronico")
            {
                txMail.Text = "";
            }
        }

        private void txMail_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txMail.Text))
            {
                txMail.Text = "Correo Electronico";
            }
        }

        private void txEmpleado_Enter_1(object sender, EventArgs e)
        {
            if (txEmpleado.Text == "Usuario")
            {
                txEmpleado.Text = "";
            }
        }

        private void txEmpleado_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txEmpleado.Text))
            {
                txEmpleado.Text = "Usuario";
            }
        }

        private void txPassword_Enter_1(object sender, EventArgs e)
        {
            if (txPassword.Text == "Contraseña")
            {
                txPassword.Text = "";
            }
        }

        private void txPassword_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txPassword.Text))
            {
                txPassword.Text = "Contraseña";
            }
        }

        private void txDNI_Enter_1(object sender, EventArgs e)
        {
            if (txDNI.Text == "DNI")
            {
                txDNI.Text = "";
            }
        }

        private void txDNI_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txDNI.Text))
            {
                txDNI.Text = "DNI";
            }
        }

        private void txName_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txLastName_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txDNI_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txPassword_TextChanged(object sender, EventArgs e)
        {
            contraVisible.Visible = !string.IsNullOrEmpty(txPassword.Text) && txPassword.Text != "Contraseña";


            // Si el campo de contraseña está vacío, también ocultar el botón
            if (string.IsNullOrEmpty(txPassword.Text) && txPassword.Text != "Contraseña")
            {
                contraVisible.Visible = false;
            }
        }


        private void contraVisible_Click(object sender, EventArgs e)
        {
            txPassword.UseSystemPasswordChar = !txPassword.UseSystemPasswordChar;
        }

        private void lbContraseña_Click(object sender, EventArgs e)
        {

        }

        private void btRegistrar_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void btRegistrar_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void lbError_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btTablaUsuarios_Click(object sender, EventArgs e)
        {
            this.Close();
            intanciaFLobi.OpenChildForm(new SeccionGerente.CTablas());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dTBith_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txcPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
