using Common.Models;
using Domain;
using Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionAdministrador;
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
using System.Windows.Interop;
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
            else if (clientModel.IsValidDni(dni))
            {
                msgError("El DNI ya está registrado...");
            }
            else if (clientModel.IsValidCorreo(mail))
            {
                msgError("El Correo ya esta registrado...");
            }
            else if (clientModel.IsValidEdad(nacimiento) == false)
            {
                msgError("No cumple con los requisitos de Edad");
            }
            else
            {
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
            dTBithAgCliente.Value = DateTime.Now; 
            txMailAgCliente.Text = "";
            tbTelefonoAgCliente.Text = "";
            tbDomicilioAgCliente.Text = "";
            txNombreAgCliente.Focus();
            lbErrorModificar.Text = "";
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
            else
            {
                formularioTablaCli = new CTablaClientes(_clienteFactura!);
                formularioTablaCli.Show();
            }
        }

        private void txNombreAgCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; 
            }
        }

        private void txApellidoAgCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txDNIAgCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; 
            }
        }

        private void tbTelefonoAgCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; 
            }
        }

        private void txNombreAgCliente_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txNombreAgCliente.Text))
            {
                string texto = txNombreAgCliente.Text;

                string textoFormateado = char.ToUpper(texto[0]) + texto.Substring(1).ToLower();

                txNombreAgCliente.Text = textoFormateado;

                txNombreAgCliente.SelectionStart = txNombreAgCliente.Text.Length;
            }
        }

        private void txApellidoAgCliente_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txApellidoAgCliente.Text))
            {
                string texto = txApellidoAgCliente.Text;

                string textoFormateado = char.ToUpper(texto[0]) + texto.Substring(1).ToLower();

                txApellidoAgCliente.Text = textoFormateado;

                txApellidoAgCliente.SelectionStart = txApellidoAgCliente.Text.Length;
            }
        }
    }
}
