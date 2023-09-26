using Common.Cache;
using Domain;
using Microsoft.VisualBasic;
using Proyecto_MauroMur.Common.Cache;
using Proyecto_MauroMur.Common.Models;
using Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_MauroMur.Domain;

namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionVendedor
{
    public partial class CClientesFactura : Form
    {
        private ClientModel clientModel = new();
        public int IdClienteSeleccionado { get; set; }
        private ClienteConInformacion? cliente;
        private FLobi? lobi;
        private CDetalleCatalogo? detalle;
        private SaleModel saleModel = new SaleModel();

        public CClientesFactura(CDetalleCatalogo detalleCatalogo, FLobi fLobi)
        {
            InitializeComponent();
            lobi = fLobi;
            detalle = detalleCatalogo;
        }

        private void CClientesFactura_Load(object sender, EventArgs e)
        {
            opcionesPago();
            opcionesFacturas();
        }

        public void ActualizarDetallesCliente(int idCliente)
        {
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
            DateTime fechaHoy = DateTime.Now;
            float total = (float)Carrito.ObtenerTotal();
            int idCliente = cliente?.IdCliente ?? 0; // Si cliente es nulo, establece el ID a 0
            int idUsuario = UserLoginCache.Id;
            int idTipoFactura = saleModel.ObtenerIdTipoFactura(cbTipoFactura.Text);
            int idMetodoPago = saleModel.ObtenerIdMetodoPago(cbMetodoPago.Text);
            Venta_Cabecera venta_Cabecera = new Venta_Cabecera();
            List<Venta_Detalle> detallesVenta = new List<Venta_Detalle>();

            if (idCliente == 0 || cbTipoFactura.SelectedIndex == 0 || cbMetodoPago.SelectedIndex == 0)
            {
                msgError("Debe Completar todos los campos");
            }
            else
            {
                Ventas ventas = new Ventas()
                {
                    NombreCliente = nombre,
                    DNICliente = dni,
                    Telefono = cliente!.Telefono,
                    Domicilio = cliente!.Domicilio,
                    TipoPago = cbMetodoPago.Text,
                    TipoFactura = cbTipoFactura.Text,
                    NombreVendedor = UserLoginCache.Nombre + UserLoginCache.Apellido,
                    DNIVendedor = UserLoginCache.DNI,
                    FechaFactura = fechaHoy,
                    MontoTotal = total,
                };

                foreach (var libroEnCarrito in Carrito.LibrosEnCarrito)
                {
                    Venta_Detalle detalle = new Venta_Detalle
                    {
                        PrecioProducto = (float)libroEnCarrito.Item1.Precio,
                        Cantidad = libroEnCarrito.Item2,
                        SubTotalProducto = (float)libroEnCarrito.Item1.Precio * libroEnCarrito.Item2,
                        Id_Libro = libroEnCarrito.Item1.Id_Libro,
                        Id_VentaCabecera = venta_Cabecera.Id_VentaCabecera,
                    };

                    detallesVenta.Add(detalle);
                }

                bool ventaAgregada = saleModel.AgregarNuevaVenta(fechaHoy, total, idCliente, idUsuario, idMetodoPago, idTipoFactura, detallesVenta);

                if (ventaAgregada)
                {
                    foreach (var libroVendido in Carrito.LibrosEnCarrito)
                    {
                        saleModel.ActualizarStockLibro(libroVendido.Item1.Id_Libro, libroVendido.Item2);
                    }
                    Carrito.VaciarCarrito();
                    this.Close();
                    CFactura factura = new CFactura(lobi!, ventas);
                    factura.Show();
                }
            }
        }


        private void msgError(string msg)
        {
            lbError.Text = "     " + msg;
            lbError.Visible = true;
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

        private void opcionesFacturas()
        {
            SaleModel saleModel = new();
            var tipoFactura = saleModel.ObtenerFactura();

            tipoFactura.Insert(0, "Seleccione Factura");

            cbTipoFactura.DataSource = tipoFactura;

            cbTipoFactura.SelectedIndex = 0;
        }

        private void opcionesPago()
        {
            SaleModel saleModel = new();
            var tipoPago = saleModel.ObtenerPago();

            tipoPago.Insert(0, "Seleccione Pago");

            cbMetodoPago.DataSource = tipoPago;

            cbMetodoPago.SelectedIndex = 0;
        }

    }
}
