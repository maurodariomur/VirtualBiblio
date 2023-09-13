using Proyecto_MauroMur.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_MauroMur.DataAccess;
using Common.Models;

namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionVendedor
{
    public partial class CCatalogo : Form
    {
        private ProductModel productModel = new ProductModel();
        public CCatalogo()
        {
            InitializeComponent();
            LlenarProductos();
        }

        private void LlenarProductos()
        {
            productModel.LlenarCatalogo(flowLayoutPanel);
        }

        private void CCatalogo_Load(object sender, EventArgs e)
        {
            opcionesAutores();
            opcionesCategorias();
            opcionesEditoriales();
        }

        private void FiltrarProducts()
        {
            // Obtén los valores de búsqueda
            string textoBusquedaTitulo = txCatalogoTitulo.Text.ToLower();
            string? autorSeleccionado = cBCatalogoAutor.SelectedItem as string;
            string? editorialSeleccionado = cBCatalogoEditorial.SelectedItem as string;
            string? categoriaSeleccionada = cBCatalogoCategoria.SelectedItem as string;

            // Limpia el flowLayoutPanel antes de agregar nuevos controles
            flowLayoutPanel.Controls.Clear();

            // Filtra los libros
            List<Libro> productosFiltrados = productModel.MostrarProducts()
                .Where(libro =>
                    (string.IsNullOrEmpty(textoBusquedaTitulo) || libro?.Titulo?.ToLower()?.Contains(textoBusquedaTitulo) == true) &&
                    (string.IsNullOrEmpty(categoriaSeleccionada) || libro?.Categoria == categoriaSeleccionada) &&
                    (string.IsNullOrEmpty(autorSeleccionado) || libro?.Autor == autorSeleccionado) &&
                    (string.IsNullOrEmpty(editorialSeleccionado) || libro?.Editorial == editorialSeleccionado))
                .ToList();

            foreach (Libro libro in productosFiltrados)
            {
                // Crea un control personalizado para mostrar el libro (por ejemplo, un Panel)
                Panel libroPanel = new Panel();
                libroPanel.BorderStyle = BorderStyle.FixedSingle;
                libroPanel.Size = new Size(200, 200); // Ajusta el tamaño según tus necesidades

                // Agrega etiquetas, imágenes u otros controles para mostrar los detalles del libro
                // Por ejemplo:
                Label titleLabel = new Label();
                titleLabel.Text = libro.Titulo;
                titleLabel.Dock = DockStyle.Top;

                // Puedes agregar más etiquetas o imágenes aquí según tus necesidades

                // Agrega el panel del libro al flowLayoutPanel
                flowLayoutPanel.Controls.Add(libroPanel);
            }
        }

        private void opcionesCategorias()
        {
            
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
            FiltrarProducts();
        }

        private void cBCatalogoAutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarProducts();
        }

        private void cBCatalogoEditorial_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarProducts();
        }

        private void cBCatalogoCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarProducts();
        }
    }
}
