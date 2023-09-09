﻿using Common.Models;
using Domain;
using Google.Protobuf;
using Proyecto_MauroMur.Common.Models;
using Proyecto_MauroMur.Domain;
using Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionGerente;
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
        private Libro? libroSeleccionado;
        private int idLibroSeleccionado = -1;


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
            dataGridProductos.Columns["Ruta"].Visible = false;
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
            opcionesAutores();
            opcionesEditoriales();
            editarOpcionesCategoria();
            dataGridProductos.CellClick += new DataGridViewCellEventHandler(dataGridProductos_CellContentClick);
        }

        private void FiltrarProducts()
        {
            string textoBusquedaTitulo = txBuscadorTitulo.Text.ToLower();
            string? autorSeleccionado = cBBuscadorAutor.SelectedItem as string;
            string? editorialSeleccionado = cBBuscadorEditorial.SelectedItem as string;
            string? categoriaSeleccionada = cBBuscadorCategoria.SelectedItem as string;
            int categoria = 0;
            int autor = -1;
            int editorial = -1;

            categoria = productModel.ObtenerCategoria(categoriaSeleccionada!);
            autor = productModel.ObtenerIdAutor(autorSeleccionado!);
            editorial = productModel.ObtenerIdEditorial(editorialSeleccionado!);

            // Aplicar el filtro y obtener los libros filtrados
            List<Libro> productosFiltrados = productModel.MostrarProducts()
            .Where(libro =>
                    (string.IsNullOrEmpty(textoBusquedaTitulo) || libro?.Titulo?.ToLower()?.Contains(textoBusquedaTitulo) == true) &&
                    (categoria == 0 || libro?.Id_Categoria == categoria) &&
                    (autor == -1 || libro?.Id_Autor == autor) &&
                    (editorial == -1 || libro?.Id_Editorial == editorial))
                .ToList();


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

        private void editarOpcionesCategoria()
        {
            ProductModel productModel = new();
            var editCategorias = productModel.ObtenerCategorias();

            // Agrega el mensaje predeterminado al comienzo de la lista
            editCategorias.Insert(0, "Seleccion Categorias");

            // Asigna la lista de categorías como DataSource del ComboBox
            txEditarCategoria.DataSource = editCategorias;
            // Establece el índice seleccionado por defecto en 0 para mostrar el mensaje predeterminado
            txEditarCategoria.SelectedIndex = 0;
        }


        private void opcionesAutores()
        {
            ProductModel productModel = new();
            var autores = productModel.ObtenerListaAutores();

            // Agrega el mensaje predeterminado al comienzo de la lista
            autores.Insert(0, "Autor");

            // Asigna la lista de categorías como DataSource del ComboBox
            cBBuscadorAutor.DataSource = autores;

            // Establece el índice seleccionado por defecto en 0 para mostrar el mensaje predeterminado
            cBBuscadorAutor.SelectedIndex = 0;
        }

        private void opcionesEditoriales()
        {
            ProductModel productModel = new();
            var editoriales = productModel.ObtenerListaEditoriales();

            // Agrega el mensaje predeterminado al comienzo de la lista
            editoriales.Insert(0, "Editoriales");

            // Asigna la lista de categorías como DataSource del ComboBox
            cBBuscadorEditorial.DataSource = editoriales;

            // Establece el índice seleccionado por defecto en 0 para mostrar el mensaje predeterminado
            cBBuscadorEditorial.SelectedIndex = 0;
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

        private void dataGridProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridProductos.Rows[e.RowIndex];
                libroSeleccionado = (Libro)row.DataBoundItem;
                idLibroSeleccionado = libroSeleccionado.Id_Libro;

                // Llena los controles con los detalles del libro
                txEditarProducto.Text = libroSeleccionado.Titulo;
                txEditarEditorial.Text = libroSeleccionado.Editorial;
                txEditarAutor.Text = libroSeleccionado.Autor;
                txEditarPrecio.Text = libroSeleccionado.Precio.ToString();
                txEditarStock.Text = libroSeleccionado.Stock.ToString();
                rtbEditarDescripcion.Text = libroSeleccionado.Descripcion;
                string? rutaImagen = libroSeleccionado.Ruta;
                MostrarImagen(rutaImagen);

                if (libroSeleccionado.Baja == "SI")
                {
                    checkBoxSiEd.Checked = true;
                    checkBoxNoEd.Checked = false; // Desmarcar checkBoxNoEd si está marcado
                }
                else
                {
                    checkBoxSiEd.Checked = false; // Desmarcar checkBoxSiEd si está marcado
                    checkBoxNoEd.Checked = true;
                }

                // Selecciona la categoría en el ComboBox
                txEditarCategoria.SelectedItem = libroSeleccionado.Categoria;
            }
        }


        private void MostrarImagen(string rutaImagen)
        {
            try
            {
                if (!string.IsNullOrEmpty(rutaImagen) && System.IO.File.Exists(rutaImagen))
                {
                    pEditarProducts.Image = Image.FromFile(rutaImagen);
                }
                else
                {
                    pEditarProducts.Image = null; // Si la ruta de la imagen es nula o el archivo no existe, limpia el PictureBox
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que pueda ocurrir al cargar la imagen
                MessageBox.Show("Error al cargar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBoxSiEd_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSiEd.Checked)
            {
                checkBoxNoEd.Checked = false;

            }
        }

        private void checkBoxNoEd_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNoEd.Checked)
            {
                checkBoxSiEd.Checked = false;

            }
        } 

        private void btEditar_Click(object sender, EventArgs e)
        {

            if (idLibroSeleccionado == -1)
            {
                MessageBox.Show("Por favor, seleccione un libro para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Recopila los datos editados
            string nuevoTitulo = txEditarProducto.Text;
            string nuevaDescripcion = rtbEditarDescripcion.Text;
            double nuevoPrecio;
            string imagen = txEditarProducto.Text;
            int nuevoStock;
            string nuevoEstado = checkBoxSiEd.Checked ? "SI" : "NO";
            string? nuevaCategoria = txEditarCategoria.SelectedItem as string;
            int idNuevaCategoria = productModel.ObtenerCategoria(nuevaCategoria);
            string? nuevoAutor = txEditarAutor.Text;
            string? nuevaEditorial = txEditarEditorial.Text;
         

            // Valida que no haya campos vacíos
            if (string.IsNullOrWhiteSpace(nuevoTitulo) || string.IsNullOrWhiteSpace(nuevaDescripcion) ||
                !double.TryParse(txEditarPrecio.Text, out nuevoPrecio) || !int.TryParse(txEditarStock.Text, out nuevoStock) ||
                string.IsNullOrWhiteSpace(nuevaCategoria) || string.IsNullOrWhiteSpace(nuevoAutor) || string.IsNullOrWhiteSpace(nuevaEditorial))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirma con el usuario si está seguro de realizar las modificaciones
            DialogResult confirmacion = MessageBox.Show("¿Está seguro de realizar estas modificaciones?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                bool exitoAutor = productModel.ActualizarAutor(nuevoAutor);

                // Llamada al método ActualizarEditorial
                bool exitoEditorial = productModel.ActualizarEditorial(nuevaEditorial);
                
                bool exitoLibro = productModel.ActualizarLibro(
                    nuevoTitulo,
                    nuevaDescripcion,
                    nuevoPrecio,
                    imagen,
                    nuevoStock,
                    nuevoEstado,
                    idNuevaCategoria,
                    idLibroSeleccionado // Pasa el ID del libro seleccionado
                );

                if (exitoLibro && exitoAutor && exitoEditorial)
                {
                    MessageBox.Show("El producto se ha actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al actualizar el producto. Por favor, intente de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se realizaron cambios en el producto.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
