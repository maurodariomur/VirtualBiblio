using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public CUsuarios()
        {
            InitializeComponent();
        }

        private void CUsuarios_Load(object sender, EventArgs e)
        {
            txName.Focus();
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
            else
            {
                bool usuarioAgregado = userModel.AgregarNuevoUsuario(nombre, apellido, dni, fechaNacimiento, mail, usuario, contrasena, tipoPerfil);
                MessageBox.Show("Usuario agregado exitosamente.");
                LimpiarCampos();
            }
        }



        private int ObtenerTipoPerfilSeleccionado()
        {
            if (txcPerfil.SelectedItem != null)
            {
                string tipoSeleccionado = txcPerfil.SelectedItem.ToString();

                switch (tipoSeleccionado)
                {
                    case "1-Gerente":
                        return 1;
                    case "2-Administrador":
                        return 2;
                    case "3-Vendedor":
                        return 3;
                    default:
                        return 0; // Otra opción por defecto
                }
            }

            return 0; // Opción por defecto si no se selecciona nada
        }

        private void LimpiarCampos()
        {
            txName.Text = "Nombre";
            txLastName.Text = "Apellido";
            txDNI.Text = "DNI";
            dTBith.Value = DateTime.Now; // Puedes establecer la fecha actual u otra fecha predeterminada
            txMail.Text = "Correo Electronico";
            txEmpleado.Text = "Usuario";
            txPassword.Text = "Contrasela";
            txcPerfil.SelectedIndex = -1; // Desseleccionar el ComboBox
            txcPerfil.Text = "Seleccione un Tipo de perfil";
            txName.Focus();
        }


        private void msgError(string msg)
        {
            lbError.Text = "        " + msg;
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

    }
}
