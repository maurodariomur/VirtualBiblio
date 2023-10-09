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

namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionAdministrador
{
    public partial class CDetallesVentasEstadistica : Form
    {
        private List<Ventas> detallesVenta;

        public CDetallesVentasEstadistica(List<Ventas> detalles)
        {
            InitializeComponent();
            detallesVenta = detalles;
        }

        private void CDetallesVentas_Load(object sender, EventArgs e)
        {
            dataGridMisVentas.DataSource = detallesVenta;
            DatosOcultos();
            dataGridMisVentas.Columns["SubTotalProducto"].DisplayIndex = dataGridMisVentas.Columns.Count - 1;
        }
        private void DatosOcultos()
        {
            DataGridViewColumnCollection columns = dataGridMisVentas.Columns;
            columns["Id_VentaCabecera"].Visible = false;
            columns["FechaFactura"].Visible = false;
            columns["MontoTotal"].Visible = false;
            columns["Id_Cliente"].Visible = false;
            columns["NombreCliente"].Visible = false;
            columns["ApellidoCliente"].Visible = false;
            columns["DNICliente"].Visible = false;
            columns["Telefono"].Visible = false;
            columns["Domicilio"].Visible = false;
            columns["Id_Usuario"].Visible = false;
            columns["NombreVendedor"].Visible = false;
            columns["ApellidoVendedor"].Visible = false;
            columns["DNIVendedor"].Visible = false;
            columns["TipoPago"].Visible = false;
            columns["Id_Libro"].Visible = false;
            columns["PrecioProducto"].Visible = false;
            columns["Categoria"].Visible = false;
            columns["TipoFactura"].Visible = false;
            columns["Estado"].Visible = false;
            dataGridMisVentas.Columns["NombreEditorial"].HeaderText = "Editorial";
            dataGridMisVentas.Columns["NombreAutor"].HeaderText = "Autor";
            dataGridMisVentas.Columns["PrecioProducto"].HeaderText = "Precio Unitario";
            dataGridMisVentas.Columns["SubTotalProducto"].HeaderText = "Sub-Total";
        }

        private void btnVolverDetalles_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
