using Proyecto_MauroMur.Domain;
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
using Proyecto_MauroMur.Common.Cache;

namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionVendedor
{
    public partial class CCatalogo : Form
    {
        private ProductModel productModel = new ProductModel();
        public List<BotonesLibros> listaDeBotones = new List<BotonesLibros>();
        private List<BotonesLibros> listaBotonesResguardo = new List<BotonesLibros>();
        private List<BotonesLibros>? todosLosLibros;
        private List<BotonesLibros>? todasLasEditoriales;
        private List<BotonesLibros>? todasLasCategorias;
        private FLobi flobi;
        private int contador;
        private int contLibro;
        CDetalleCatalogo cDetalleCatalogo;

        public CCatalogo(FLobi flobi)
        {
            InitializeComponent();
            LlenarProductos();
            this.flobi = flobi;
            cDetalleCatalogo = new CDetalleCatalogo(this);

            contador = 0;

            if (Carrito.contador != null)
            {
                contador = (int)Carrito.contador;
                lbContador.Text = Carrito.contador.ToString();
            }

            foreach (BotonesLibros btn in listaDeBotones)
            {
                btn.añadirEvento += añadirEvento!;
            }
        }

        private void añadirEvento(object sender, EventArgs e)
        {
            BotonesLibros btn = (BotonesLibros)sender;
            Libro libro = productModel.ObtenerLibroId(btn.idLibro);

            Carrito.AgregarLibro(libro);

            lbContador.Text = Carrito.contador.ToString();

        }

        private void LlenarProductos()
        {
            productModel.LlenarCatalogo(flowLayoutPanel, this);
            listaBotonesResguardo = listaDeBotones;
            todosLosLibros = listaBotonesResguardo.ToList();
            todasLasEditoriales = listaBotonesResguardo.ToList();
            todasLasCategorias = listaBotonesResguardo.ToList();
        }

        private void CCatalogo_Load(object sender, EventArgs e)
        {
            opcionesAutores();
            opcionesCategorias();
            opcionesEditoriales();
        }

        public void LoadLabelContador()
        {
            lbContador.Text = Carrito.contador.ToString();
        }

        private void BusquedaProductos()
        {
            string textoBusquedaTitulo = txCatalogoTitulo.Text.ToLower();
            if (string.IsNullOrEmpty(textoBusquedaTitulo))
            {
                foreach (var libro in listaBotonesResguardo)
                {
                    flowLayoutPanel.Controls.Add(libro); // Agrega los botones filtrados al FlowLayoutPanel
                }
                return;
            }
            var librosFiltrados = flowLayoutPanel.Controls.OfType<BotonesLibros>()
                .Where(libro => string.IsNullOrEmpty(textoBusquedaTitulo) || libro.tituloLibro.ToLower().Contains(textoBusquedaTitulo))
                .ToList();

            flowLayoutPanel.Controls.Clear(); // Limpia los botones existentes

            foreach (var libro in librosFiltrados)
            {
                flowLayoutPanel.Controls.Add(libro); // Agrega los botones filtrados al FlowLayoutPanel
            }
        }

        private void FiltrarProductos()
        {
            string textoBusqueda = cBCatalogoAutor.Text;
            string textoBusquedaCategoria = cBCatalogoCategoria.Text;
            string textoBusquedaEditorial = cBCatalogoEditorial.Text;


            if (textoBusqueda.Equals("Autor", StringComparison.OrdinalIgnoreCase))
            {
                MostrarTodosLosLibros();
            }
            else if (textoBusqueda.Equals("Editoriales", StringComparison.OrdinalIgnoreCase))
            {
                MostrarTodasLasEditoriales();
            }
            else if (textoBusqueda.Equals("Categorias", StringComparison.OrdinalIgnoreCase))
            {
                MostrarTodasLasCategorias();
            }
            else
            {
                var librosFiltrados = todosLosLibros!
                    .Where(libro => libro.Autor.Equals(textoBusqueda, StringComparison.OrdinalIgnoreCase) || libro.Editoriales.Equals(textoBusquedaCategoria, StringComparison.OrdinalIgnoreCase) ||
                            libro.Editoriales.Equals(textoBusquedaEditorial, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                flowLayoutPanel.Controls.Clear(); // Limpia los botones existentes

                foreach (var libro in librosFiltrados)
                {
                    flowLayoutPanel.Controls.Add(libro); // Agrega los botones filtrados al FlowLayoutPanel
                }
            }
        }

        private void MostrarTodosLosLibros()
        {
            flowLayoutPanel.Controls.Clear(); // Limpia los botones existentes

            foreach (var libro in todosLosLibros!)
            {
                flowLayoutPanel.Controls.Add(libro); // Agrega todos los botones originales al FlowLayoutPanel
            }
        }

        private void MostrarTodasLasEditoriales()
        {
            flowLayoutPanel.Controls.Clear();

            foreach (var libro in todasLasEditoriales!)
            {
                flowLayoutPanel.Controls.Add(libro);
            }
        }

        private void MostrarTodasLasCategorias()
        {
            flowLayoutPanel.Controls.Clear();

            foreach (var libro in todasLasCategorias!)
            {
                flowLayoutPanel.Controls.Add(libro);
            }
        }


        private void opcionesCategorias()
        {
            ProductModel productModel = new();
            var categorias = productModel.ObtenerCategorias();

            // Agrega el mensaje predeterminado al comienzo de la lista
            categorias.Insert(0, "Categorias");

            // Asigna la lista de categorías como DataSource del ComboBox
            cBCatalogoCategoria.DataSource = categorias;
            // Establece el índice seleccionado por defecto en 0 para mostrar el mensaje predeterminado
            cBCatalogoCategoria.SelectedIndex = 0;
        }

        private void opcionesAutores()
        {

            var autores = productModel.ObtenerListaAutores();

            // Agrega el mensaje predeterminado al comienzo de la lista
            autores.Insert(0, "Autor");

            // Asigna la lista de categorías como DataSource del ComboBox
            cBCatalogoAutor.DataSource = autores;

            // Establece el índice seleccionado por defecto en 0 para mostrar el mensaje predeterminado
            cBCatalogoAutor.SelectedIndex = 0;
        }

        private void opcionesEditoriales()
        {

            var editoriales = productModel.ObtenerListaEditoriales();

            // Agrega el mensaje predeterminado al comienzo de la lista
            editoriales.Insert(0, "Editoriales");

            // Asigna la lista de categorías como DataSource del ComboBox
            cBCatalogoEditorial.DataSource = editoriales;

            // Establece el índice seleccionado por defecto en 0 para mostrar el mensaje predeterminado
            cBCatalogoEditorial.SelectedIndex = 0;
        }

        private void txCatalogoTitulo_TextChanged(object sender, EventArgs e)
        {
            BusquedaProductos();
        }

        private void cBCatalogoAutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarProductos();
        }

        private void cBCatalogoEditorial_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarProductos();
        }

        private void cBCatalogoCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarProductos();
        }

        private void iconCatalogo_Click(object sender, EventArgs e)
        {

            cDetalleCatalogo.ShowDialog();
        }
    }
}
