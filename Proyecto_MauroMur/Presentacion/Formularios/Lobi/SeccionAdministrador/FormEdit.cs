using Common.Models;
using Domain;
using Proyecto_MauroMur.Common.Models;
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
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionAdministrador
{
    public partial class FormEdit : Form
    {
        private int userId;
        private CTablas? _tablas;
        UserModel userModel = new();
        UsuarioConInformacion? usuario;

        public FormEdit(CTablas tablas, int id)
        {
            InitializeComponent();
            this._tablas = tablas;
            userId = id;
            usuario = userModel.ImportarUsuarios(userId);

            if (usuario != null)
            {
                txNameModificar.Text = usuario.PersonaNombre;
                txLastNameModificar.Text = usuario.PersonaApellido;
                dTBithModificar.Value = usuario.PersonaFechaNacimiento;
                txDNIModificar.Text = usuario.PersonaDNI;
                txMailModificar.Text = usuario.PersonaMail;
                opcionesPerfiles();
                txEmpleadoModificar.Text = usuario.UserNombre;
                if (usuario.PersonaBaja == "SI")
                {
                    checkBoxSi.Checked = true;
                }
                else
                {
                    checkBoxNo.Checked = true;
                }
            }
        }


        private void FormEdit_Load(object sender, EventArgs e)
        {
            dTBithModificar.CustomFormat = "dd/MM/yyyy";
            dTBithModificar.Format = DateTimePickerFormat.Custom;
        }

        private void opcionesPerfiles()
        {
            var roles = userModel.ObtenerPerfiles();

            txcPerfilModificar.DataSource = roles;
            userModel.GetRolName(usuario!.TipoPerfil);
            txcPerfilModificar.Text = userModel.GetRolName(usuario.TipoPerfil);
        }

        private void msgError(string msg)
        {
            lbErrorModificar.Text = "     " + msg;
            lbErrorModificar.Visible = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void checkBoxSi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSi.Checked)
            {
                checkBoxNo.Checked = !checkBoxSi.Checked;

            }
        }

        private void checkBoxNo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNo.Checked)
            {
                checkBoxSi.Checked = !checkBoxNo.Checked;

            }
        }

        private void btGuardarDatos_Click(object sender, EventArgs e)
        {
            string nombre = txNameModificar.Text;
            string apellido = txLastNameModificar.Text;
            string dni = txDNIModificar.Text;
            string mail = txMailModificar.Text;
            string usuario = txEmpleadoModificar.Text;
            DateTime nacimiento = dTBithModificar.Value;
            string tipoPerfilNombre = txcPerfilModificar.Text;
            int tipoPerfilId = userModel.ObtenerIdTipoPerfil(tipoPerfilNombre);
            string baja = checkBoxSi.Checked ? "SI" : "NO";

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(dni) || string.IsNullOrWhiteSpace(usuario) || (checkBoxSi.Checked == false && checkBoxNo.Checked == false))
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

            UsuarioConInformacion? usuarioActual = userModel.ImportarUsuarios(userId);
            if (usuarioActual != null &&
                nombre == usuarioActual.PersonaNombre &&
                apellido == usuarioActual.PersonaApellido &&
                dni == usuarioActual.PersonaDNI &&
                mail == usuarioActual.PersonaMail &&
                usuario == usuarioActual.UserNombre &&
                nacimiento == usuarioActual.PersonaFechaNacimiento &&
                tipoPerfilId == usuarioActual.TipoPerfil &&
                baja == usuarioActual.PersonaBaja)
            {
                MessageBox.Show("No se han realizado cambios en los datos.");
                this.Close();
                return;
            }

            bool actualizacionExitosa = userModel.ActualizacionEmpleado(userId, nombre, apellido, dni, mail, usuario, nacimiento, tipoPerfilId, baja);

            if (actualizacionExitosa)
            {
                MessageBox.Show("Los datos del usuario se han actualizado correctamente.");
                _tablas!.loadUsers();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al actualizar los datos del usuario. Por favor, inténtalo de nuevo.");
            }
        }

        private void txNameModificar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txLastNameModificar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txDNIModificar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txNameModificar_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txNameModificar.Text))
            {
                txNameModificar.Text = char.ToUpper(txNameModificar.Text[0]) + txNameModificar.Text.Substring(1);
                txNameModificar.SelectionStart = txNameModificar.Text.Length;
            }
        }

        private void txLastNameModificar_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txLastNameModificar.Text))
            {
                txLastNameModificar.Text = char.ToUpper(txLastNameModificar.Text[0]) + txLastNameModificar.Text.Substring(1);
                txLastNameModificar.SelectionStart = txLastNameModificar.Text.Length;
            }
        }
    }
}
