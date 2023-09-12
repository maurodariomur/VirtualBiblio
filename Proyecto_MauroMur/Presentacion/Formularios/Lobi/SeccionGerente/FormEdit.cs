using Common.Models;
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
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionGerente
{
    public partial class FormEdit : Form
    {
        private int userId;
        private CTablas? _tablas;

        public FormEdit(CTablas tablas, int id)
        {
            InitializeComponent();
            this._tablas = tablas;
            userId = id;
            UserModel userModel = new();
            Usuarios? usuario = userModel.ImportarUsuarios(id);

            if (usuario != null)
            {
                txNameModificar.Text = usuario.Nombre;
                txLastNameModificar.Text = usuario.Apellido;
                dTBithModificar.Value = usuario.FechaNacimiento;
                txDNIModificar.Text = usuario.DNI;
                txMailModificar.Text = usuario.Mail;
                //userModel.GetRolName(usuario.TipoPerfil);
                //txcPerfilModificar.Text = userModel.GetRolName(usuario.TipoPerfil);
                opcionesPerfiles(id);
                txEmpleadoModificar.Text = usuario.Usuario;
                if (usuario.Baja == "SI")
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
            // Configura el formato personalizado para el DateTimePicker
            dTBithModificar.CustomFormat = "dd/MM/yyyy";
            // Asegúrate de que la propiedad Format esté establecida en Custom
            dTBithModificar.Format = DateTimePickerFormat.Custom;
        }

        private void opcionesPerfiles(int id)
        {
            UserModel userModel = new();
            Usuarios? usuario = userModel.ImportarUsuarios(id);
            var roles = userModel.ObtenerPerfiles();

            // Asigna la lista de categorías como DataSource del ComboBox
            txcPerfilModificar.DataSource = roles;
            // Establece el índice seleccionado por defecto en 0 para mostrar el mensaje predeterminado
            userModel.GetRolName(usuario.TipoPerfil);
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
            UserModel userModel = new UserModel();

            string nombre = txNameModificar.Text;
            string apellido = txLastNameModificar.Text;
            string dni = txDNIModificar.Text;
            string mail = txMailModificar.Text;
            string usuario = txEmpleadoModificar.Text;
            DateTime nacimiento = dTBithModificar.Value;
            string tipoPerfilNombre = txcPerfilModificar.Text;
            int tipoPerfilId = userModel.ObtenerIdTipoPerfil(tipoPerfilNombre);
            string baja = checkBoxSi.Checked ? "SI" : "NO";

            // Verificar si algún campo obligatorio está vacío
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(dni) || string.IsNullOrWhiteSpace(usuario))
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

            // Verificar si los datos no han cambiado
            Usuarios? usuarioActual = userModel.ImportarUsuarios(userId);
            if (usuarioActual != null &&
                nombre == usuarioActual.Nombre &&
                apellido == usuarioActual.Apellido &&
                dni == usuarioActual.DNI &&
                mail == usuarioActual.Mail &&
                usuario == usuarioActual.Usuario &&
                nacimiento == usuarioActual.FechaNacimiento &&
                tipoPerfilId == usuarioActual.TipoPerfil &&
                baja == usuarioActual.Baja)
            {
                MessageBox.Show("No se han realizado cambios en los datos.");
                this.Close();
                return;
            }

            // Realizar la actualización solo si se superan las validaciones
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
                e.Handled = true; // Suprime el carácter ingresado si no es una letra, espacio o tecla de retroceso (Backspace).
            }
        }

        private void txLastNameModificar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Suprime el carácter ingresado si no es una letra, espacio o tecla de retroceso (Backspace).
            }
        }

        private void txDNIModificar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
