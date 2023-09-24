using Domain;
using Proyecto_MauroMur.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionVendedor
{
    public partial class CClientesFactura : Form
    {
        private int maxLength = 16;
        private ClientModel clientModel = new();
        public int IdClienteSeleccionado { get; set; }
        private ClienteConInformacion? cliente;
        FLobi? lobi;
        CDetalleCatalogo? detalle;

        public CClientesFactura(CDetalleCatalogo detalleCatalogo)
        {
            InitializeComponent();
            lobi = new();
            detalle = detalleCatalogo;
        }

        private void CClientesFactura_Load(object sender, EventArgs e)
        {

        }

        public void ActualizarDetallesCliente(int idCliente)
        {
            // Obtén el cliente utilizando el idCliente
            cliente = clientModel.ImportarCliente(idCliente);

            if (cliente != null)
            {
                lbNombreApellido.Text = cliente.PersonaNombre + " " + cliente.PersonaApellido;
                lbDNI.Text = cliente.PersonaDNI;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string nombre = lbNombreApellido.Text;
            string dni = lbDNI.Text;

            if (string.IsNullOrEmpty(nombre) || nombre == "Nombre y Apellido" || string.IsNullOrEmpty(dni) || dni == "DNI")
            {
                msgError("Debe seleccionar un Cliente");

            }
            //else if (cbEfectivo.Checked == false || cbMercadoPago.Checked == false || cbTarjeta.Checked == false)
            //{
            //    msgError("Debe seleccionar un metodo de pago");
            //}
            else
                {
                this.Close();
                CFactura factura = new CFactura();
                factura.Show();
            }
        }

        private void msgError(string msg)
        {
            lbError.Text = "     " + msg;
            lbError.Visible = true;
        }

        private void cbEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEfectivo.Checked == true)
            {
                cbMercadoPago.Visible = false;
                cbTarjeta.Visible = false;
            }
            else
            {
                cbMercadoPago.Visible = true;
                cbTarjeta.Visible = true;
            }
        }

        private void cbTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTarjeta.Checked == true)
            {
                tbNumeroTarjeta.Visible = true;
                cbMercadoPago.Visible = false;
                cbEfectivo.Visible = false;
            }
            else
            {
                tbNumeroTarjeta.Visible = false;
                cbMercadoPago.Visible = true;
                cbEfectivo.Visible = true;
            }
        }

        private void cbMercadoPago_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMercadoPago.Checked == true)
            {
                tbMP.Visible = true;
                cbTarjeta.Visible = false;
                cbEfectivo.Visible = false;
            }
            else
            {
                tbMP.Visible = false;
                cbTarjeta.Visible = true;
                cbEfectivo.Visible = true;
            }
        }

        private void iconAtrasDet_Click(object sender, EventArgs e)
        {
            this.Close();
            lobi!.OpenChildForm(new SeccionVendedor.CCatalogo(lobi));
            lobi!.Show();
            detalle!.Show();
        }

        private void ibAgregarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            CTablaClientes tablaClientes = new CTablaClientes(this);
            tablaClientes.Show();
        }

        private void tbNumeroTarjeta_TextChanged(object sender, EventArgs e)
        {
            // Obtén el texto actual del TextBox
            string numeroTarjeta = tbNumeroTarjeta.Text;

            // Elimina cualquier guión existente para que no se acumulen
            numeroTarjeta = numeroTarjeta.Replace("-", "");

            // Verifica si el número de tarjeta tiene más dígitos de los permitidos
            if (numeroTarjeta.Length > maxLength)
            {
                // Trunca el número de tarjeta para que no exceda la longitud máxima
                numeroTarjeta = numeroTarjeta.Substring(0, maxLength);
            }

            // Verifica si el número de tarjeta tiene al menos 4 caracteres y es múltiplo de 4
            if (numeroTarjeta.Length >= 4 && numeroTarjeta.Length % 4 == 0)
            {
                // Formatea el número de tarjeta con guiones cada 4 caracteres
                string numeroFormateado = string.Join("-", Enumerable.Range(0, numeroTarjeta.Length / 4)
                    .Select(i => numeroTarjeta.Substring(i * 4, 4)));

                // Establece el texto formateado en el TextBox
                tbNumeroTarjeta.Text = numeroFormateado;
                // Coloca el cursor al final del texto
                tbNumeroTarjeta.SelectionStart = tbNumeroTarjeta.Text.Length;
            }
        }

        private void tbMP_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbNombreApellido_Click(object sender, EventArgs e)
        {

        }
    }
}
