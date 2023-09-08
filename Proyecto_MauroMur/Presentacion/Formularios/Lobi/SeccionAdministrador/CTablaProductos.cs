using Common.Models;
using Domain;
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

namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionAdministrador
{
    public partial class CTablaProductos : Form
    {
        private ProductModel productModel = new ProductModel();
        private List<Libro> libros = new List<Libro>();

        public CTablaProductos()
        {
            InitializeComponent();
        }

        private void CTablaProductos_Load(object sender, EventArgs e)
        {
            libros = productModel.MostrarProducts();

            // Cargar las imágenes para cada libro

            foreach (Libro libro in libros)
            {
                productModel.CargarImagen(libro);
            }

            // Asigna la lista de libros al DataSource del DataGridView
            dataGridProductos.DataSource = libros;

            // Configuración adicional de las columnas
            dataGridProductos.Columns["Id_Categoria"].Visible = false;
            dataGridProductos.Columns["Id_Editorial"].Visible = false;
            dataGridProductos.Columns["Id_Autor"].Visible = false;
            dataGridProductos.Columns["Titulo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridProductos.Columns["Baja"].DisplayIndex = dataGridProductos.Columns.Count - 1;

            // Configura la columna de la imagen (asegúrate de que el nombre de la columna sea correcto)
            dataGridProductos.Columns["ImagenPortada"].Visible = true;
            dataGridProductos.Columns["ImagenPortada"].HeaderText = "Portada";
            dataGridProductos.Columns["ImagenPortada"].Width = 100; // Ajusta el ancho según tus necesidades
            dataGridProductos.RowTemplate.Height = 70;
            if (dataGridProductos.Columns["ImagenPortada"] is DataGridViewImageColumn)
            {
                ((DataGridViewImageColumn)dataGridProductos.Columns["ImagenPortada"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
            opcionesCategorias();
        }

        private void FiltrarProducts()
        {
            string textoBusquedaTitulo = txBuscadorTitulo.Text.ToLower();
            string autorSeleccionado = cBBuscadorAutor.SelectedItem as string;
            string editorialSeleccionado = cBBuscadorEditorial.SelectedItem as string;
            string categoriaSeleccionada = cBBuscadorCategoria.SelectedItem as string;

            // Aplicar el filtro y obtener los libros filtrados
            List<Libro> productosFiltrados = libros
                .Where(libro =>
                    (string.IsNullOrEmpty(textoBusquedaTitulo) || libro?.Titulo?.ToLower()?.Contains(textoBusquedaTitulo) == true) &&
                    (string.IsNullOrEmpty(autorSeleccionado) || libro?.AutorNombre?.ToLower()?.Contains(autorSeleccionado.ToLower()) == true) &&
                    (string.IsNullOrEmpty(editorialSeleccionado) || libro?.EditorialNombre?.ToLower()?.Contains(editorialSeleccionado.ToLower()) == true) &&
                    (string.IsNullOrEmpty(categoriaSeleccionada) || libro?.CategoriaNombre?.ToLower()?.Contains(categoriaSeleccionada.ToLower()) == true))
                .ToList();

            // Cargar imÃ¡genes para los libros filtrados
            foreach (Libro libro in productosFiltrados)
            {
                productModel.CargarImagen(libro);
            }

            // Actualizar el DataGridView con los libros filtrados
            dataGridProductos.DataSource = productosFiltrados;
        }


        private void opcionesCategorias()
        {
            ProductModel productModel = new();
            var categorias = productModel.ObtenerCategorias();

            // Agrega el mensaje predeterminado al comienzo de la lista
            categorias.Insert(0, "Categorias");

            // Asigna la lista de categorías como DataSource del ComboBox
            cBBuscadorCategoria.DataSource = categorias;

            // Establece el índice seleccionado por defecto en 0 para mostrar el mensaje predeterminado
            cBBuscadorCategoria.SelectedIndex = 0;
        }

        private void cBBuscadorAutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarProducts();
        }

        private void cBBuscadorEditorial_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarProducts();
        }

        private void cBBuscadorCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarProducts();
        }

        private void txBuscadorTitulo_TextChanged(object sender, EventArgs e)
        {
            FiltrarProducts();
        }
    }
}
