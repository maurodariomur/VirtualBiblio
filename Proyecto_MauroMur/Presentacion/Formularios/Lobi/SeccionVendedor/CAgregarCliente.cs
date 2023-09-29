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

namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionVendedor
{
    public partial class CAgregarCliente : Form
    {
        ClientModel clientModel = new ClientModel();
        private CClientesFactura? _clienteFactura;
        public CAgregarCliente(CClientesFactura clienteFactura)
        {
            InitializeComponent();
            _clienteFactura = clienteFactura;
        }

        private void CAgregarCliente_Load(object sender, EventArgs e)
        {
            dTBithAgCliente.CustomFormat = "dd/MM/yyyy";
            // Asegúrate de que la propiedad Format esté establecida en Custom
            dTBithAgCliente.Format = DateTimePickerFormat.Custom;
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
            DateTime fechaRegistro = DateTime.Now;
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Verificar si algún campo obligatorio está vacío
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(dni))
            {
                msgError("Por favor, completa todos los campos obligatorios");
                return;
            }
            else if (string.IsNullOrWhiteSpace(mail))
            {
                msgError("Por favor, ingresa una dirección de correo electrónico.");
                return;
            }
            else if (!Regex.IsMatch(mail, emailPattern))
            {
                msgError("Por favor, ingresa una dirección de correo electrónico válida.");
                return;
            }
            else
            {
                // Mostrar mensaje de confirmación
                DialogResult confirmResult = MessageBox.Show("¿Está seguro que desea registrar este usuario?", "Confirmar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    bool clienteAgregado = clientModel.AgregarNuevoCliente(telefono, domicilio, fechaRegistro, nombre, apellido, dni, mail, nacimiento);
                    MessageBox.Show("Usuario agregado exitosamente: " + nombre + " " + apellido, "Empleado Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
            }
        }

        private void LimpiarCampos()
        {
            txNombreAgCliente.Text = "";
            txApellidoAgCliente.Text = "";
            txDNIAgCliente.Text = "";
            dTBithAgCliente.Value = DateTime.Now; // Puedes establecer la fecha actual u otra fecha predeterminada
            txMailAgCliente.Text = "";
            tbTelefonoAgCliente.Text = "";
            tbDomicilioAgCliente.Text = "";
            txNombreAgCliente.Focus();
        }

        private void msgError(string msg)
        {
            lbErrorModificar.Text = "     " + msg;
            lbErrorModificar.Visible = true;
        }

        private void iconAtrasU_Click(object sender, EventArgs e)
        {
            // Cierra el formulario actual
            this.Close();

            // Intenta abrir el formulario deseado
            CTablaClientes? formularioTablaCli = Application.OpenForms.OfType<CTablaClientes>().FirstOrDefault();
            if (formularioTablaCli != null)
            {
                formularioTablaCli.Show();
            }
            else
            {
                // Si el formulario no existe, crea una nueva instancia y ábrelo
                formularioTablaCli = new CTablaClientes(_clienteFactura!);
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
