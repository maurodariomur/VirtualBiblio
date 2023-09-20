using Proyecto_MauroMur.Common.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionVendedor
{
    public partial class CDetalleCatalogo : Form
    {
        CCatalogo c;
        private bool columnasAgregadas = false;

        public CDetalleCatalogo(CCatalogo catalogo)
        {
            InitializeComponent();
            dataGridDetalleCat.Visible = false;
            c = catalogo;
        }

        private void CDetalleCatalogo_Load(object sender, EventArgs e)
        {
            if (Carrito.LibrosEnCarrito != null && Carrito.LibrosEnCarrito.Any())
            {
                // Configurar el DataGridView para mostrar el libro y la cantidad
                dataGridDetalleCat.DataSource = Carrito.LibrosEnCarrito.Select(t => new
                {
                    Titulo = t.Item1.Titulo,
                    Precio = t.Item2 * t.Item1.Precio,
                    Autor = t.Item1.Autor,
                    Editorial = t.Item1.Editorial,
                    Cantidad = t.Item2,
                }).ToList();

                if (!columnasAgregadas)
                {
                    agregarColumnas();
                    columnasAgregadas = true; // Marca que las columnas ya se han agregado
                }

                dataGridDetalleCat.Visible = true;
                lbMensaje.Visible = false;
                lbProductos.Visible = true;
                btVaciarCarrito.Visible = true;
                btnConfirmarCompra.Visible = true;

            }
            else
            {
                dataGridDetalleCat.Visible = false;
                lbMensaje.Visible = true;// Ocultar el DataGridView si no hay libros en el carrito
                lbProductos.Visible = false;
                btVaciarCarrito.Visible = false;
                btnConfirmarCompra.Visible = false;
            }
        }

        private void agregarColumnas()
        {
            BtnDataGrid agregarColumn = new BtnDataGrid();
            agregarColumn.Text = "+";
            agregarColumn.DisplayIndex = dataGridDetalleCat.Columns.Count - 1;
            dataGridDetalleCat.Columns.Add(agregarColumn);


            BtnDataGrid eliminarColumn = new BtnDataGrid();
            eliminarColumn.Text = "-";
            eliminarColumn.Name = "Eliminar";
            dataGridDetalleCat.Columns.Add(eliminarColumn);

            BtnDataGrid eliminarTodo = new BtnDataGrid();
            eliminarTodo.Text = "X";
            dataGridDetalleCat.Columns.Add(eliminarTodo);
        }

        private void btnDCSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btVaciarCarrito_Click(object sender, EventArgs e)
        {
            Carrito.VaciarCarrito();
            c.LoadLabelContador();
            CDetalleCatalogo_Load(sender, e);
            dataGridDetalleCat.Visible = false;
            lbMensaje.Visible = true;
            lbProductos.Visible = false;
            btVaciarCarrito.Visible = false;
            btnConfirmarCompra.Visible = false;
        }

        private void dataGridDetalleCat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
