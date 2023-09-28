﻿using Common.Cache;
using Proyecto_MauroMur.Common.Models;
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

namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionVendedor
{
    public partial class CMisVentas : Form
    {
        private FLobi? lobi;
        SaleModel saleModel = new SaleModel();
        private bool formDetallesAbierto = false;

        public CMisVentas(FLobi? _lobi)
        {
            InitializeComponent();
            this.lobi = _lobi;
        }

        private void CMisVentas_Load(object sender, EventArgs e)
        {
            int idUsuarioActual = UserLoginCache.Id;
            List<Ventas> ventasDelUsuario = saleModel.ObtenerVentasPorUsuarioConNombres(idUsuarioActual);
            dataGridMisVentas.DataSource = ventasDelUsuario;
            dataGridMisVentas.Columns["Id_VentaCabecera"].HeaderText = "ID";
            dataGridMisVentas.Columns["FechaFactura"].HeaderText = "F.Factura";
            dataGridMisVentas.Columns["MontoTotal"].HeaderText = "Monto Total";
            dataGridMisVentas.Columns["NombreCliente"].HeaderText = "Nombre";
            dataGridMisVentas.Columns["ApellidoCliente"].HeaderText = "Apellido";
            dataGridMisVentas.Columns["DNICliente"].HeaderText = "D.N.I Cliente";
            dataGridMisVentas.Columns["Estado"].HeaderText = "Cancelar Factura";
            ocultarColumas();
            dataGridMisVentas.CellContentClick += dataGridMisVentas_CellContentClick!;
        }

        private void ocultarColumas()
        {
            dataGridMisVentas.Columns["Id_Cliente"].Visible = false;
            dataGridMisVentas.Columns["Telefono"].Visible = false;
            dataGridMisVentas.Columns["Domicilio"].Visible = false;
            dataGridMisVentas.Columns["Id_Usuario"].Visible = false;
            dataGridMisVentas.Columns["DNIVendedor"].Visible = false;
            dataGridMisVentas.Columns["TipoPago"].Visible = false;
            dataGridMisVentas.Columns["TipoFactura"].Visible = false;
            dataGridMisVentas.Columns["Id_Libro"].Visible = false;
            dataGridMisVentas.Columns["Titulo"].Visible = false;
            dataGridMisVentas.Columns["Categoria"].Visible = false;
            dataGridMisVentas.Columns["NombreEditorial"].Visible = false;
            dataGridMisVentas.Columns["NombreAutor"].Visible = false;
            dataGridMisVentas.Columns["PrecioProducto"].Visible = false;
            dataGridMisVentas.Columns["Cantidad"].Visible = false;
            dataGridMisVentas.Columns["SubTotalProducto"].Visible = false;
            dataGridMisVentas.Columns["NombreVendedor"].Visible = false;
            dataGridMisVentas.Columns["ApellidoVendedor"].Visible = false;
        }

        private void dataGridMisVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si el evento fue desencadenado por un clic en la columna "Estado" (o cualquier otra columna que quieras excluir).
            if (e.ColumnIndex != dataGridMisVentas.Columns["Estado"].Index && e.RowIndex >= 0)
            {
                // Evita que el formulario CMisDetalles se abra dos veces.
                if (!formDetallesAbierto)
                {
                    // Obtiene la fila seleccionada.
                    DataGridViewRow selectedRow = dataGridMisVentas.Rows[e.RowIndex];

                    // Obtén el ID de la venta cabecera de esa fila (asumiendo que la columna que contiene el ID se llama "Id_VentaCabecera").
                    int idVentaCabecera = Convert.ToInt32(selectedRow.Cells["Id_VentaCabecera"].Value);

                    // Llama a la función para obtener los detalles de la venta específica.
                    List<Ventas> detallesVenta = saleModel.ObtenerVentasDetalle(idVentaCabecera);

                    // Abre el formulario de detalle pasando los detalles de la venta.
                    CMisDetalles detalleForm = new(detallesVenta);
                    detalleForm.FormClosed += (s, args) => { formDetallesAbierto = false; }; // Cuando se cierre el formulario, establece la variable en false.
                    detalleForm.ShowDialog(); // Muestra el formulario de detalle de manera modal.

                    formDetallesAbierto = true; // Establece la variable en true para evitar que se abra nuevamente.
                }
            }
        }
    }
}
