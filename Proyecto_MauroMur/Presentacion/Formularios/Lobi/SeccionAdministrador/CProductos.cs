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

namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionAdministrador
{
    public partial class CProductos : Form
    {
        private const int maxCaracteres = 200;

        public CProductos()
        {
            InitializeComponent();
        }

        private void msgError(string msg)
        {
            lbErrorProd.Text = "     " + msg;
            lbErrorProd.Visible = true;
        }

        private void btRegistrarProd_Click(object sender, EventArgs e)
        {
            string nombreProd = txNameProducto.Text;
            string editorial = txEditorial.Text;
            string precio = txPrecio.Text;
            string descripcion = rtbDescripcion.Text;

            UserModel userModel = new UserModel();

            if (nombreProd == "Nombre" || editorial == "Editorial" || precio == "$ Precio" || descripcion == "Descripcion")
            {
                msgError("Debe completar todos los campos");
            }
            else if (string.IsNullOrWhiteSpace(nombreProd) || string.IsNullOrWhiteSpace(editorial) || string.IsNullOrWhiteSpace(precio)
                || string.IsNullOrWhiteSpace(descripcion))
            {
                msgError("Debe completar todos los campos");
            }
            else
            {
                // Mostrar mensaje de confirmación
                DialogResult confirmResult = MessageBox.Show("¿Está seguro que desea registrar este producto?", "Confirmar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    // bool usuarioAgregado = userModel.AgregarNuevoUsuario(nombre, apellido, dni, fechaNacimiento, mail, usuario, contrasena, tipoPerfil);
                    MessageBox.Show("Libro agregado exitosamente: " + nombreProd, "Libro Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
            }
        }
        private void LimpiarCampos()
        {
            txNameProducto.Text = "Nombre";
            txEditorial.Text = "Editorial";
            txPrecio.Text = "$ Precio";
            rtbDescripcion.Text = "Descripcion";
            txNameProducto.Focus();
        }

        private void rtbDescripcion_TextChanged(object sender, EventArgs e)
        {
            // Obtén la longitud actual del texto en el RichTextBox
            int longitudTexto = rtbDescripcion.TextLength;

            // Verifica si se excede el límite de caracteres
            if (longitudTexto > maxCaracteres)
            {
                // Si se excede, limita el texto a la longitud máxima
                rtbDescripcion.Text = rtbDescripcion.Text.Substring(0, maxCaracteres);
                rtbDescripcion.SelectionStart = maxCaracteres;
                rtbDescripcion.SelectionLength = 0;
            }

            // Actualiza el contador de caracteres restantes en lbLimite
            lbLimite.Text = "Caracteres restantes: " + (maxCaracteres - longitudTexto);
            lbLimite.Visible = longitudTexto > 0;
        }

        private void txNameProducto_Enter(object sender, EventArgs e)
        {
            if (txNameProducto.Text == "Nombre")
            {
                txNameProducto.Text = "";
            }
        }

        private void txNameProducto_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txNameProducto.Text))
            {
                txNameProducto.Text = "Nombre";
            }
        }

        private void txEditorial_Enter(object sender, EventArgs e)
        {
            if (txEditorial.Text == "Editorial")
            {
                txEditorial.Text = "";
            }
        }

        private void txEditorial_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txEditorial.Text))
            {
                txEditorial.Text = "Editorial";
            }
        }

        private void txPrecio_Enter(object sender, EventArgs e)
        {
            if (txPrecio.Text == "$ Precio")
            {
                txPrecio.Text = "";
            }
        }

        private void txPrecio_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txPrecio.Text))
            {
                txPrecio.Text = "$ Precio";
            }
        }

        private void txPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' && (sender as TextBox).Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        private void lbLimite_Click(object sender, EventArgs e)
        {

        }
    }



}
