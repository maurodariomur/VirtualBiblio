using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

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

        }

        private void btRegistrar_Click(object sender, EventArgs e)
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
            bool usuarioAgregado = userModel.AgregarNuevoUsuario(nombre, apellido, dni, fechaNacimiento, mail, usuario, contrasena, tipoPerfil);

            if (usuarioAgregado)
            {
                MessageBox.Show("Usuario agregado exitosamente.");
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("No se pudo agregar el usuario.");
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
            txName.Text = "";
            txLastName.Text = "";
            txDNI.Text = "";
            dTBith.Value = DateTime.Now; // Establecer la fecha actual o algún valor predeterminado
            txMail.Text = "";
            txEmpleado.Text = "";
            txPassword.Text = "";
            txcPerfil.SelectedIndex = -1; // Desseleccionar el ComboBox
        }

        private void txcPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
