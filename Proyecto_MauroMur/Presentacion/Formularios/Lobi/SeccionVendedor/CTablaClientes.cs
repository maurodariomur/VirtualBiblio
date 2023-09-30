using Common.Models;
using Domain;
using Proyecto_MauroMur.Common.Models;
using Proyecto_MauroMur.Domain;
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

namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionVendedor
{
    public partial class CTablaClientes : Form
    {
        private ClientModel clienteModel = new ClientModel();
        private ClienteConInformacion? clienteSeleccionado;
        private int idClienteSeleccionado = -1;
        private bool edicionRealizada = false;
        private CClientesFactura? _clienteFactura;

        public CTablaClientes(CClientesFactura clienteFactura)
        {
            InitializeComponent();
            _clienteFactura= clienteFactura;
            desactivarBotones();
        }

        private void CTablaClientes_Load(object sender, EventArgs e)
        {
            List<ClienteConInformacion> clientes = clienteModel.MostrarClientes().Where(c => c.PersonaBaja == "NO").ToList();
            dataGridClientes.DataSource = clientes;
            dataGridClientes.Columns["IdCliente"].HeaderText = "ID";
            dataGridClientes.Columns["PersonaNombre"].HeaderText = "Nombre";
            dataGridClientes.Columns["PersonaApellido"].HeaderText = "Apellido";
            dataGridClientes.Columns["PersonaDNI"].HeaderText = "D.N.I";
            dataGridClientes.Columns["PersonaMail"].HeaderText = "Correo";
            dataGridClientes.Columns["PersonaFechaNacimiento"].HeaderText = "F.Nacimiento";
            dataGridClientes.Columns["FechaRegistro"].HeaderText = "F.Registro";
            dataGridClientes.Columns["PersonaBaja"].HeaderText = "Baja";
            dataGridClientes.Columns["Id_Persona"].Visible = false;
            dTFNCliente.CustomFormat = "dd/MM/yyyy";
            dTFNCliente.Format = DateTimePickerFormat.Custom;
            dataGridClientes.RowPrePaint += DataGridClientes_RowPrePaint!;
        }

        private void loadClientes()
        {
            List<ClienteConInformacion> clientes = clienteModel.MostrarClientes();

            if (checkApellidos.Checked)
            {
                clientes.Sort((x, y) => string.Compare(x.PersonaApellido, y.PersonaApellido));
            }

            if (cbBaja.Checked)
            {
                clientes = clientes.Where(c => c.PersonaBaja == "SI").ToList();
            }
            else
            {
                clientes = clientes.Where(c => c.PersonaBaja == "NO").ToList();
            }
            dataGridClientes.DataSource = clientes;
        }


        private void DataGridClientes_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DataGridViewRow row = dataGridClientes.Rows[e.RowIndex];

            string? valorBaja = row.Cells["PersonaBaja"].Value.ToString();

            if (valorBaja == "SI")
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 140, 140);
                row.DefaultCellStyle.ForeColor = Color.Black; 
            }
            else
            {
                row.DefaultCellStyle.BackColor = SystemColors.Window;
                row.DefaultCellStyle.ForeColor = SystemColors.ControlText;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            CAgregarCliente agregarCliente = new CAgregarCliente(_clienteFactura!);
            agregarCliente.Show();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            edicionRealizada = false;
            if (idClienteSeleccionado == -1)
            {
                MessageBox.Show("Por favor, seleccione un Cliente para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string nuevoNombre = txNombreCliente.Text;
            string nuevoApellido = txApellidoCliente.Text;
            string nuevoDni = txDNICliente.Text;
            string nuevoMail = txMailCliente.Text;
            string nuevoTelefono = tbTelefonoCliente.Text;
            string nuevoDomicilio = tbDomicilioCliente.Text;
            DateTime nuevoNacimiento = dTFNCliente.Value;
            string baja = checkBoxSi.Checked ? "SI" : "NO";

            if (string.IsNullOrWhiteSpace(nuevoNombre) || string.IsNullOrWhiteSpace(nuevoApellido) ||
                string.IsNullOrWhiteSpace(nuevoDni) || (checkBoxSi.Checked == false && checkBoxNo.Checked == false))
            {
                msgError("Todos los campos obligatorios");
                return;
            }

            if (string.IsNullOrWhiteSpace(nuevoMail))
            {
                msgError("Ingresa una dirección de correo electrónico.");
                return;
            }

            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (!Regex.IsMatch(nuevoMail, emailPattern))
            {
                msgError("Ingresa una dirección de correo electrónico válida.");
                return;
            }
            bool cambiosRealizados = !string.Equals(nuevoNombre, clienteSeleccionado?.PersonaNombre, StringComparison.OrdinalIgnoreCase) ||
                                     !string.Equals(nuevoApellido, clienteSeleccionado?.PersonaApellido, StringComparison.OrdinalIgnoreCase) ||
                                     !string.Equals(nuevoDni, clienteSeleccionado?.PersonaDNI, StringComparison.OrdinalIgnoreCase) ||
                                     !string.Equals(nuevoMail, clienteSeleccionado?.PersonaMail) ||
                                     !string.Equals(nuevoTelefono, clienteSeleccionado?.Telefono, StringComparison.OrdinalIgnoreCase) ||
                                     !string.Equals(nuevoDomicilio, clienteSeleccionado?.Domicilio, StringComparison.OrdinalIgnoreCase) ||
                                     !string.Equals(baja, clienteSeleccionado?.PersonaBaja, StringComparison.OrdinalIgnoreCase) ||
                                     !DateTime.Equals(nuevoNacimiento, clienteSeleccionado?.PersonaFechaNacimiento);
            if (!cambiosRealizados)
            {
                LimpiarCamposModificar();
                desactivarBotones();
                MessageBox.Show("Usted no realizó cambios.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult confirmacion = MessageBox.Show("¿Está seguro de realizar estas modificaciones?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                bool exitoCliente = clienteModel.ActualizacionClient(
                    clienteSeleccionado!.IdCliente,
                    nuevoNombre,
                    nuevoApellido,
                    nuevoDni,
                    nuevoMail,
                    nuevoNacimiento,
                    nuevoTelefono,
                    nuevoDomicilio,
                    baja
                );

                if (exitoCliente)
                {
                    MessageBox.Show("El cliente" + nuevoApellido + " " + nuevoNombre + " " + "se ha actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCamposModificar();
                    desactivarBotones();
                    CTablaClientes_Load(sender, e);
                }
                else
                {
                    desactivarBotones();
                    msgError("Ha ocurrido un error.");
                }
            }
            else
            {
                desactivarBotones();
                msgError("No se realizaron cambios al Cliente.");
            }
        }

        private void LimpiarCamposModificar()
        {
            edicionRealizada = false;
            txNombreCliente.Text = "";
            txApellidoCliente.Text = "";
            txDNICliente.Text = "";
            txMailCliente.Text = "";
            tbTelefonoCliente.Text = "";
            tbDomicilioCliente.Text = "";
            dTFNCliente.Value = DateTime.Now;
            checkBoxSi.Checked = false;
            checkBoxNo.Checked = false;
            lbErrorModificar.Text = "";
            checkApellidos.Checked = false;
        }

        private void desactivarBotones()
        {
            txNombreCliente.Enabled = false;
            txApellidoCliente.Enabled = false;
            checkBoxSi.Enabled = false;
            checkBoxNo.Enabled = false;
            txDNICliente.Enabled = false;
            txMailCliente.Enabled = false;
            tbTelefonoCliente.Enabled = false;
            tbDomicilioCliente.Enabled = false;
            dTFNCliente.Enabled = false;
            iconLimpiar.Enabled = false;
            btnConfirmar.Enabled = false;
            btnEnviar.Enabled = false;
        }

        private void msgError(string msg)
        {
            lbErrorModificar.Text = "     " + msg;
            lbErrorModificar.Visible = true;
        }

        private void iconAtrasU_Click(object sender, EventArgs e)
        {
            this.Close();
            CClientesFactura? formularioClienteFac = Application.OpenForms.OfType<CClientesFactura>().FirstOrDefault();

            if (formularioClienteFac != null)
            {
                formularioClienteFac.Show();
            }
        }

        private void txNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txApellidoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txDNICliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; 
            }
        }

        private void tbTelefonoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; 
            }
        }

        private void dataGridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!edicionRealizada && e.RowIndex >= 0)
            {
                edicionRealizada = true;
                DialogResult confirmResult = MessageBox.Show("Usted esta por realizar una Edición.En caso de que no lo desee vacie Los campos", "Informe de edición", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (confirmResult == DialogResult.OK)
                {
                    txNombreCliente.Enabled = true;
                    txApellidoCliente.Enabled = true;
                    checkBoxSi.Enabled = true;
                    checkBoxNo.Enabled = true;
                    txDNICliente.Enabled = true;
                    txMailCliente.Enabled = true;
                    tbTelefonoCliente.Enabled = true;
                    tbDomicilioCliente.Enabled = true;
                    dTFNCliente.Enabled = true;
                    iconLimpiar.Enabled = true;
                    btnConfirmar.Enabled = true;
                    btnEnviar.Enabled = true;

                    DataGridViewRow row = dataGridClientes.Rows[e.RowIndex];

                    clienteSeleccionado = (ClienteConInformacion)row.DataBoundItem;
                    idClienteSeleccionado = clienteSeleccionado.IdCliente;

                    txNombreCliente.Text = clienteSeleccionado.PersonaNombre;
                    txApellidoCliente.Text = clienteSeleccionado.PersonaApellido;
                    txDNICliente.Text = clienteSeleccionado.PersonaDNI;
                    txMailCliente.Text = clienteSeleccionado.PersonaMail;
                    tbTelefonoCliente.Text = clienteSeleccionado.Telefono;
                    tbDomicilioCliente.Text = clienteSeleccionado.Domicilio;
                    dTFNCliente.Value = clienteSeleccionado.PersonaFechaNacimiento;

                    if (clienteSeleccionado.PersonaBaja == "SI")
                    {
                        checkBoxSi.Checked = true;
                        checkBoxNo.Checked = false;
                    }
                    else
                    {
                        checkBoxSi.Checked = false; 
                        checkBoxNo.Checked = true;
                    }
                }
            }
        }

        private void checkBoxSi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSi.Checked)
            {
                checkBoxNo.Checked = false;

            }
        }

        private void checkBoxNo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNo.Checked)
            {
                checkBoxSi.Checked = false;

            }
        }

        private void iconLimpiar_Click(object sender, EventArgs e)
        {
            DialogResult limpiar = MessageBox.Show("Esta por realizar la limpieza de los campos. ¿Seguro?.", "Limpieza", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (limpiar == DialogResult.OK)
            {
                LimpiarCamposModificar();
                desactivarBotones();
            }
        }

        private void checkApellidos_CheckedChanged(object sender, EventArgs e)
        {
            loadClientes();
        }

        private void FiltrarClientes()
        {
            string textoBusquedaNombre = txBuscadorNombre.Text.ToLower();
            string textoBusquedaApellido = txBuscadorApellido.Text.ToLower();
            string textoBusquedaDNI = txBuscadorDni.Text.ToLower();

            List<ClienteConInformacion> clientesFiltrados;

            if (cbBaja.Checked)
            {
                clientesFiltrados = clienteModel.MostrarClientes()
                    .Where(cliente =>
                        (cliente.PersonaBaja == "SI") &&
                        (string.IsNullOrEmpty(textoBusquedaNombre) || cliente.PersonaNombre?.ToLower()?.Contains(textoBusquedaNombre) == true) &&
                        (string.IsNullOrEmpty(textoBusquedaApellido) || cliente.PersonaApellido?.ToLower()?.Contains(textoBusquedaApellido) == true) &&
                        (string.IsNullOrEmpty(textoBusquedaDNI) || cliente.PersonaDNI?.ToLower()?.Contains(textoBusquedaDNI) == true))
                    .ToList();
            }
            else
            {
                clientesFiltrados = clienteModel.MostrarClientes()
                    .Where(cliente =>
                        (cliente.PersonaBaja == "NO") &&
                        (string.IsNullOrEmpty(textoBusquedaNombre) || cliente.PersonaNombre?.ToLower()?.Contains(textoBusquedaNombre) == true) &&
                        (string.IsNullOrEmpty(textoBusquedaApellido) || cliente.PersonaApellido?.ToLower()?.Contains(textoBusquedaApellido) == true) &&
                        (string.IsNullOrEmpty(textoBusquedaDNI) || cliente.PersonaDNI?.ToLower()?.Contains(textoBusquedaDNI) == true))
                    .ToList();
            }

            dataGridClientes.DataSource = clientesFiltrados;
        }


        private void txBuscadorNombre_TextChanged(object sender, EventArgs e)
        {
            FiltrarClientes();
        }

        private void txBuscadorApellido_TextChanged(object sender, EventArgs e)
        {
            FiltrarClientes();
        }

        private void txBuscadorDni_TextChanged(object sender, EventArgs e)
        {
            FiltrarClientes();
        }

        private void cbBaja_CheckedChanged(object sender, EventArgs e)
        {
            List<ClienteConInformacion> clientes;

            if (cbBaja.Checked)
            {
                clientes = clienteModel.MostrarClientes().Where(c => c.PersonaBaja == "SI").ToList();
            }
            else
            {
                clientes = clienteModel.MostrarClientes().Where(c => c.PersonaBaja == "NO").ToList();
            }
            dataGridClientes.DataSource = clientes;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (clienteSeleccionado != null)
            {
                if (clienteSeleccionado.PersonaBaja=="NO")
                {
                    int idClienteSeleccionado = clienteSeleccionado.IdCliente;

                    _clienteFactura!.ActualizarDetallesCliente(idClienteSeleccionado);

                    this.Close();
                    _clienteFactura.Show();
                }
                else
                {
                    MessageBox.Show("Cliente no disponible, seleccione otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente antes de enviar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
