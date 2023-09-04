using Common.Models;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
                userModel.GetRolName(usuario.TipoPerfil);
                txcPerfilModificar.Text = userModel.GetRolName(usuario.TipoPerfil);
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
            // Obtener el nombre del tipo de perfil desde el campo de texto
            string tipoPerfilNombre = txcPerfilModificar.Text;
            int tipoPerfilId = userModel.ObtenerIdTipoPerfil(tipoPerfilNombre);
            string baja = checkBoxSi.Checked ? "SI" : "NO";

            // Crea una instancia del modelo de usuario para actualizar los datos.
            ;

            // Llama a un método en el modelo de usuario para actualizar los datos del usuario.
            bool actualizacionExitosa = userModel.ActualizacionEmpleado(userId, nombre, apellido, dni, mail, usuario, nacimiento, tipoPerfilId, baja);

            if (actualizacionExitosa)
            {
                MessageBox.Show("Los datos del usuario se han actualizado correctamente.");
                _tablas!.loadUsers();
                // Cierra el formulario de edición si la actualización fue exitosa.
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al actualizar los datos del usuario. Por favor, inténtalo de nuevo.");
            }
        }

    }
}
