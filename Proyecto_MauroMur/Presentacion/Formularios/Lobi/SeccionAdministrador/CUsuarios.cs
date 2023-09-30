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
using Microsoft.VisualBasic.ApplicationServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionAdministrador
{
    public partial class CUsuarios : Form
    {
        private FLobi instanciaFLobi;

        public CUsuarios(FLobi lobi)
        {
            InitializeComponent();
            this.instanciaFLobi = lobi;
        }

        private void CUsuarios_Load(object sender, EventArgs e)
        {
            txName.Focus();
            // Configura el formato personalizado para el DateTimePicker
            dTBith.CustomFormat = "dd/MM/yyyy";
            // Asegúrate de que la propiedad Format esté establecida en Custom
            dTBith.Format = DateTimePickerFormat.Custom;
            opcionesPerfiles();
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
            string tipoPerfil = txcPerfil.Text;

            UserModel userModel = new UserModel();

            int idTipoPerfil = userModel.ObtenerIdTipoPerfil(tipoPerfil);

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
            else if (idTipoPerfil == 0)
            {
                msgError("Debe seleccionar un tipo de usuario");
            }
            else if (!IsValidEmail(mail)) // Validación del correo electrónico
            {
                msgError("El correo electrónico ingresado no es válido");
            }
            else if (userModel.IsValidDni(dni))
            {
                msgError("El DNI ya está registrado...");
            }
            else if (userModel.IsValidCorreo(mail))
            {
                msgError("El Correo ya esta registrado...");
            }
            else if (userModel.IsValidNombreUsuario(usuario))
            {
                msgError("El Nombre de Usuario ya esta registrado...");
            }
            else if (userModel.IsValidEdad(fechaNacimiento) == false)
            {
                msgError("No cumple con los requisitos de Edad");
            }
            else
            {
                // Mostrar mensaje de confirmación
                DialogResult confirmResult = MessageBox.Show("¿Está seguro que desea registrar este usuario?", "Confirmar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    bool usuarioAgregado = userModel.AgregarNuevoUsuario(usuario, contrasena, idTipoPerfil, nombre, apellido, dni, mail, fechaNacimiento);
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

        private void opcionesPerfiles()
        {
            UserModel userModel = new();
            var roles = userModel.ObtenerPerfiles();

            roles.Insert(0, "Seleccione Perfil");

            txcPerfil.DataSource = roles;

            txcPerfil.SelectedIndex = 0;
        }

        private void LimpiarCampos()
        {
            txName.Text = "";
            txLastName.Text = "";
            txDNI.Text = "";
            dTBith.Value = DateTime.Now;
            txMail.Text = "";
            txEmpleado.Text = "";
            txPassword.Text = "";
            txcPerfil.SelectedIndex = 0;
            lbError.Text = "";
            txName.Focus();
            contraVisible.Visible = false;
            txPassword.UseSystemPasswordChar = true;
        }

        private void msgError(string msg)
        {
            lbError.Text = "     " + msg;
            lbError.Visible = true;
        }

        private void txName_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txLastName_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
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

            if (string.IsNullOrEmpty(txPassword.Text) && txPassword.Text != "Contraseña")
            {
                contraVisible.Visible = false;
            }
        }

        private void contraVisible_Click(object sender, EventArgs e)
        {
            txPassword.UseSystemPasswordChar = !txPassword.UseSystemPasswordChar;
        }

        private void btRegistrar_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void btRegistrar_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void btTablaUsuarios_Click(object sender, EventArgs e)
        {
            this.Close();
            instanciaFLobi.OpenChildForm(new SeccionAdministrador.CTablas(instanciaFLobi));
        }

        private void txName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txName.Text))
            {
                txName.Text = char.ToUpper(txName.Text[0]) + txName.Text.Substring(1);
                txName.SelectionStart = txName.Text.Length;
            }
        }

        private void txLastName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txLastName.Text))
            {
                txLastName.Text = char.ToUpper(txLastName.Text[0]) + txLastName.Text.Substring(1);
                txLastName.SelectionStart = txLastName.Text.Length;
            }
        }
    }
}
