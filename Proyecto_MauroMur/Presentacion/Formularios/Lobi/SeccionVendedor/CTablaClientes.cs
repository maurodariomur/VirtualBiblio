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

        public CTablaClientes()
        {
            InitializeComponent();
        }

        private void CTablaClientes_Load(object sender, EventArgs e)
        {
            List<ClienteConInformacion> clientes = clienteModel.MostrarClientes().Where(c => c.PersonaBaja == "NO").ToList();
            dataGridClientes.DataSource = clientes;
            dataGridClientes.Columns["IdCliente"].HeaderText = "ID";
            dataGridClientes.Columns["PersonaNombre"].HeaderText = "Nombre";
            dataGridClientes.Columns["PersonaApellido"].HeaderText = "Apellido";
            dataGridClientes.Columns["PersonaDNI"].HeaderText = "DNI";
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
            ClienteConInformacion clienteConPersona = new();
            if (checkApellidos.Checked)
            {
                clientes.Sort((x, y) => string.Compare(x.PersonaApellido, y.PersonaApellido));
            }
            dataGridClientes.DataSource = clientes;
        }

        private void DataGridClientes_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            // Obtén la fila actual
            DataGridViewRow row = dataGridClientes.Rows[e.RowIndex];

            // Verifica el valor de la columna "Baja" (asegúrate de que el nombre de la columna sea correcto)
            string? valorBaja = row.Cells["PersonaBaja"].Value.ToString();

            // Define el color de fondo deseado para las filas con "Baja" en "SI"
            if (valorBaja == "SI")
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 140, 140);
                row.DefaultCellStyle.ForeColor = Color.Black; // Opcional: establecer el color de texto en blanco para mayor visibilidad
            }
            else
            {
                // Restablece el color de fondo y texto para las demás filas (opcional)
                row.DefaultCellStyle.BackColor = SystemColors.Window;
                row.DefaultCellStyle.ForeColor = SystemColors.ControlText;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            CAgregarCliente agregarCliente = new CAgregarCliente();
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

            // Verificar si algún campo obligatorio está vacío
            if (string.IsNullOrWhiteSpace(nuevoNombre) || string.IsNullOrWhiteSpace(nuevoApellido) ||
                string.IsNullOrWhiteSpace(nuevoDni) || (checkBoxSi.Checked == false && checkBoxNo.Checked == false))
            {
                msgError("Todos los campos obligatorios");
                return;
            }

            // Verificar si el correo electrónico está vacío
            if (string.IsNullOrWhiteSpace(nuevoMail))
            {
                msgError("Ingresa una dirección de correo electrónico.");
                return;
            }

            // Validar dirección de correo electrónico
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (!Regex.IsMatch(nuevoMail, emailPattern))
            {
                msgError("Ingresa una dirección de correo electrónico válida.");
                return;
            }
            // Comprueba si se ha realizado algún cambio en los campos
            bool cambiosRealizados = !string.Equals(nuevoNombre, clienteSeleccionado?.PersonaNombre, StringComparison.OrdinalIgnoreCase) ||
                                     !string.Equals(nuevoApellido, clienteSeleccionado?.PersonaApellido, StringComparison.OrdinalIgnoreCase) ||
                                     !string.Equals(nuevoDni, clienteSeleccionado?.PersonaDNI, StringComparison.OrdinalIgnoreCase) ||
                                     !string.Equals(nuevoMail, clienteSeleccionado?.PersonaMail) ||
                                     !string.Equals(nuevoTelefono, clienteSeleccionado?.Telefono, StringComparison.OrdinalIgnoreCase) ||
                                     !string.Equals(nuevoDomicilio, clienteSeleccionado?.Domicilio, StringComparison.OrdinalIgnoreCase) ||
                                     !string.Equals(baja, clienteSeleccionado?.PersonaBaja, StringComparison.OrdinalIgnoreCase) ||
                                     !DateTime.Equals(nuevoNacimiento, clienteSeleccionado?.PersonaFechaNacimiento);

            // Si no se realizaron cambios, muestra un mensaje y regresa
            if (!cambiosRealizados)
            {
                LimpiarCamposModificar();
                desactivarBotones();
                MessageBox.Show("Usted no realizó cambios.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Confirma con el usuario si está seguro de realizar las modificaciones
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
                    msgError("Ha ocurrido un error.Por favor, intente de nuevo.");
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
                e.Handled = true; // Ignora el carácter ingresado si no es una letra o espacio en blanco
            }
        }

        private void txApellidoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ignora el carácter ingresado si no es una letra o espacio en blanco
            }
        }

        private void txDNICliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ignora el carácter ingresado si no es una letra o espacio en blanco
            }
        }

        private void tbTelefonoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ignora el carácter ingresado si no es una letra o espacio en blanco
            }
        }

        private void dataGridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si la edición ya se realizó y si se hizo clic en una fila válida
            if (!edicionRealizada && e.RowIndex >= 0)
            {
                // Marca que la edición se ha realizado
                edicionRealizada = true;

                // Muestra el mensaje de confirmación
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

                    // Obtiene la fila seleccionada
                    DataGridViewRow row = dataGridClientes.Rows[e.RowIndex];

                    // Obtén el objeto 'Cliente' correspondiente a la fila seleccionada
                    clienteSeleccionado = (ClienteConInformacion)row.DataBoundItem;
                    idClienteSeleccionado = clienteSeleccionado.IdCliente;

                    // Llena los controles con los detalles del libro
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
                        checkBoxNo.Checked = false; // Desmarcar checkBoxNoEd si está marcado
                    }
                    else
                    {
                        checkBoxSi.Checked = false; // Desmarcar checkBoxSiEd si está marcado
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
            // Mostrar el cuadro de diálogo de confirmación solo si no hay problemas
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

            List<ClienteConInformacion> clientesFiltrados = clienteModel.MostrarClientes()
                .Where(cliente =>
                    (string.IsNullOrEmpty(textoBusquedaNombre) || cliente?.PersonaNombre?.ToLower()?.Contains(textoBusquedaNombre) == true) &&
                    (string.IsNullOrEmpty(textoBusquedaApellido) || cliente?.PersonaApellido?.ToLower()?.Contains(textoBusquedaApellido) == true) &&
                    (string.IsNullOrEmpty(textoBusquedaDNI) || cliente?.PersonaDNI?.ToLower()?.Contains(textoBusquedaDNI) == true))
                .ToList();

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
                // Mostrar solo los clientes con "PersonaBaja" igual a "SI" (activado)
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
            // Verifica si se ha seleccionado un cliente
            if (clienteSeleccionado != null)
            {
                // Obtén el ID del cliente seleccionado
                int idClienteSeleccionado = clienteSeleccionado.IdCliente;

                // Crea una instancia del formulario CClientesFactura
                CClientesFactura formularioClienteFac = new CClientesFactura();

                // Configura la propiedad IdClienteSeleccionado en CClientesFactura
                formularioClienteFac.IdClienteSeleccionado = idClienteSeleccionado;

                // Muestra el formulario CClientesFactura
                formularioClienteFac.Show();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente antes de enviar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
