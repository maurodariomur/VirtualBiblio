using Common.Models;
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
        private string? fileSavePath;
        private string? fileActualPath;
        private string? imagenName;
        private bool edicionRealizada = false;

        private FLobi objFLobi;

        public CTablaProductos(FLobi flobi)
        {
            InitializeComponent();
            this.objFLobi = flobi;
        }

        private void CTablaProductos_Load(object sender, EventArgs e)
        {
            libros = productModel.MostrarProducts();

            desactivarBotones();
            foreach (Libro libro in libros)
            {
                productModel.CargarImagen(libro);
            }

            dataGridProductos.DataSource = libros;

            dataGridProductos.Columns["Id_Categoria"].Visible = false;
            dataGridProductos.Columns["Id_Editorial"].Visible = false;
            dataGridProductos.Columns["Id_Autor"].Visible = false;
            dataGridProductos.Columns["Imagen"].Visible = false;
            dataGridProductos.Columns["Titulo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridProductos.Columns["Baja"].DisplayIndex = dataGridProductos.Columns.Count - 1;

            dataGridProductos.Columns["ImagenPortada"].Visible = true;
            dataGridProductos.Columns["ImagenPortada"].HeaderText = "Portada";
            dataGridProductos.Columns["ImagenPortada"].Width = 100; 
            dataGridProductos.RowTemplate.Height = 70;
            if (dataGridProductos.Columns["ImagenPortada"] is DataGridViewImageColumn)
            {
                ((DataGridViewImageColumn)dataGridProductos.Columns["ImagenPortada"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
            opcionesCategorias();
            opcionesAutores();
            opcionesEditoriales();
            editarOpcionesCategoria();
            dataGridProductos.RowPrePaint += DataGridProductos_RowPrePaint!;
            mostrarOpcionesAutor();
            mostrarOpcionesEditoriales();
        }

        private void DataGridProductos_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DataGridViewRow row = dataGridProductos.Rows[e.RowIndex];

            string? valorBaja = row.Cells["Baja"].Value.ToString();

            if (valorBaja == "SI")
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(243, 106, 106);
                row.DefaultCellStyle.ForeColor = Color.White; 
            }
            else
            {
                row.DefaultCellStyle.BackColor = SystemColors.Window;
                row.DefaultCellStyle.ForeColor = SystemColors.ControlText;
            }
        }

        private void loadLibros()
        {
            List<Libro> productos = productModel.MostrarProducts();

            if (checkBoxAZT.Checked)
            {
                productos.Sort((x, y) => string.Compare(x.Titulo, y.Titulo));
            }

            dataGridProductos.DataSource = productos;

            foreach (Libro libro in productos)
            {
                productModel.CargarImagen(libro);
            }
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

            dataGridProductos.DataSource = productosFiltrados;
        }


        private void opcionesCategorias()
        {
            ProductModel productModel = new();
            var categorias = productModel.ObtenerCategorias();

            categorias.Insert(0, "Categorias");

            cBBuscadorCategoria.DataSource = categorias;
            cBBuscadorCategoria.SelectedIndex = 0;
        }

        private void editarOpcionesCategoria()
        {
            ProductModel productModel = new();
            var editCategorias = productModel.ObtenerCategorias();

            editCategorias.Insert(0, "Seleccion Categorias");

            txEditarCategoria.DataSource = editCategorias;
            txEditarCategoria.SelectedIndex = 0;
        }

        private void opcionesAutores()
        {
            ProductModel productModel = new();
            var autores = productModel.ObtenerListaAutores();

            autores.Insert(0, "Autor");

            cBBuscadorAutor.DataSource = autores;
            cBBuscadorAutor.SelectedIndex = 0;
        }

        private void opcionesEditoriales()
        {
            ProductModel productModel = new();
            var editoriales = productModel.ObtenerListaEditoriales();

            editoriales.Insert(0, "Editoriales");

            cBBuscadorEditorial.DataSource = editoriales;
            cBBuscadorEditorial.SelectedIndex = 0;
        }

        private void desactivarBotones()
        {
            txEditarProducto.Enabled = false;
            rtbEditarDescripcion.Enabled = false;
            checkBoxSiEd.Enabled = false;
            checkBoxNoEd.Enabled = false;
            txEditarCategoria.Enabled = false;
            txEditarAutor.Enabled = false;
            txEditarEditorial.Enabled = false;
            txEditarPrecio.Enabled = false;
            txEditarStock.Enabled = false;
            iconEditarImagen.Enabled = false;
            btEditar.Enabled = false;
            iconLimpiar.Enabled = false;
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
            if (!edicionRealizada && e.RowIndex >= 0)
            {
                edicionRealizada = true;

                DialogResult confirmResult = MessageBox.Show("¿Desea Realizar una Modificacion al Libro?", "Informe de edición", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (confirmResult == DialogResult.OK)
                {
                    txEditarProducto.Enabled = true;
                    rtbEditarDescripcion.Enabled = true;
                    checkBoxSiEd.Enabled = true;
                    checkBoxNoEd.Enabled = true;
                    txEditarCategoria.Enabled = true;
                    txEditarAutor.Enabled = true;
                    txEditarEditorial.Enabled = true;
                    txEditarPrecio.Enabled = true;
                    txEditarStock.Enabled = true;
                    iconEditarImagen.Enabled = true;
                    btEditar.Enabled = true;
                    iconLimpiar.Enabled = true;

                    DataGridViewRow row = dataGridProductos.Rows[e.RowIndex];

                    libroSeleccionado = (Libro)row.DataBoundItem;
                    idLibroSeleccionado = libroSeleccionado.Id_Libro;
                    txEditarProducto.Text = libroSeleccionado.Titulo;
                    txEditarEditorial.Text = libroSeleccionado.Editorial;
                    txEditarAutor.Text = libroSeleccionado.Autor;
                    txEditarPrecio.Text = libroSeleccionado.Precio.ToString();
                    txEditarStock.Text = libroSeleccionado.Stock.ToString();
                    rtbEditarDescripcion.Text = libroSeleccionado.Descripcion;
                    pEditarProducts.Image = libroSeleccionado.ImagenPortada;

                    if (libroSeleccionado.Baja == "SI")
                    {
                        checkBoxSiEd.Checked = true;
                        checkBoxNoEd.Checked = false; 
                    }
                    else
                    {
                        checkBoxSiEd.Checked = false; 
                        checkBoxNoEd.Checked = true;
                    }
                    txEditarCategoria.SelectedItem = libroSeleccionado.Categoria;
                }
                else
                {
                    edicionRealizada = false;
                }
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
            string? imagenActual = null;
            edicionRealizada = false;

            if (libroSeleccionado != null)
            {
                imagenActual = libroSeleccionado.Imagen;
            }

            if (idLibroSeleccionado == -1)
            {
                MessageBox.Show("Por favor, seleccione un libro para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nuevoTitulo = txEditarProducto.Text;
            string nuevaDescripcion = rtbEditarDescripcion.Text;
            double nuevoPrecio;
            int nuevoStock;
            string nuevoEstado = checkBoxSiEd.Checked ? "SI" : "NO";
            string? nuevaCategoria = txEditarCategoria.SelectedItem as string;
            int idNuevaCategoria = productModel.ObtenerCategoria(nuevaCategoria!);
            string? nuevoAutor = txEditarAutor.Text;
            string? nuevaEditorial = txEditarEditorial.Text;

            if (string.IsNullOrWhiteSpace(nuevoTitulo) || string.IsNullOrWhiteSpace(nuevaDescripcion) ||
                !double.TryParse(txEditarPrecio.Text, out nuevoPrecio) || !int.TryParse(txEditarStock.Text, out nuevoStock) ||
                string.IsNullOrWhiteSpace(nuevaCategoria) || string.IsNullOrWhiteSpace(nuevoAutor) || string.IsNullOrWhiteSpace(nuevaEditorial) ||
                (checkBoxSiEd.Checked == false && checkBoxNoEd.Checked == false))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool cambiosRealizados = !string.Equals(nuevoTitulo, libroSeleccionado?.Titulo, StringComparison.OrdinalIgnoreCase) ||
                                     !string.Equals(nuevaDescripcion, libroSeleccionado?.Descripcion, StringComparison.OrdinalIgnoreCase) ||
                                     !double.Equals(nuevoPrecio, libroSeleccionado?.Precio) ||
                                     !int.Equals(nuevoStock, libroSeleccionado.Stock) ||
                                     !string.Equals(nuevoEstado, libroSeleccionado.Baja, StringComparison.OrdinalIgnoreCase) ||
                                     idNuevaCategoria != libroSeleccionado.Id_Categoria ||
                                     !string.Equals(nuevoAutor, libroSeleccionado.Autor, StringComparison.OrdinalIgnoreCase) ||
                                     !string.Equals(nuevaEditorial, libroSeleccionado.Editorial, StringComparison.OrdinalIgnoreCase) ||
                                     (!string.IsNullOrWhiteSpace(imagenName) && !string.Equals(imagenActual, imagenName, StringComparison.OrdinalIgnoreCase));

            if (!cambiosRealizados)
            {
                LimpiarCamposModificar();
                desactivarBotones();
                MessageBox.Show("Usted no realizó cambios.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult confirmacion = MessageBox.Show("¿Está seguro de realizar estas modificaciones?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                if (!string.IsNullOrWhiteSpace(imagenName) && !string.Equals(imagenActual, imagenName, StringComparison.OrdinalIgnoreCase))
                {
                    libroSeleccionado!.Imagen = imagenName;
                }

                bool exitoLibro = productModel.ActualizarLibro(
                    libroSeleccionado!.Id_Libro,
                    nuevoTitulo,
                    nuevaDescripcion,
                    nuevoPrecio,
                    libroSeleccionado.Imagen!,
                    nuevoStock,
                    nuevoEstado,
                    idNuevaCategoria,
                    nuevoAutor,
                    nuevaEditorial
                );

                if (exitoLibro)
                {
                    if (!string.IsNullOrWhiteSpace(imagenName) && !string.Equals(imagenActual, imagenName, StringComparison.OrdinalIgnoreCase))
                    {
                        libroSeleccionado!.Imagen = imagenName;
                        File.Copy(fileActualPath!, fileSavePath!);
                    }
                    imagenName= null;
                    MessageBox.Show("El producto se ha actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCamposModificar();
                    desactivarBotones();
                    CTablaProductos_Load(sender, e);
                }
                else
                {
                    desactivarBotones();
                    MessageBox.Show("Ha ocurrido un error al actualizar el producto. Por favor, intente de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                desactivarBotones();
                MessageBox.Show("No se realizaron cambios en el producto.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LimpiarCamposModificar()
        {
            edicionRealizada = false;
            txEditarProducto.Text = "";
            txEditarAutor.Text = "";
            txEditarStock.Text = "";
            rtbEditarDescripcion.Text = "";
            txEditarPrecio.Text = "";
            txEditarEditorial.Text = "";
            txEditarCategoria.SelectedIndex = 0;
            checkBoxSiEd.Checked = false;
            checkBoxNoEd.Checked = false;
            checkBoxAZT.Checked = false;
            pEditarProducts.Image = null;
        }

        private void iconEditarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new()
            {
                Filter = "Archivos de imagen (*.png) | *.png",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
                Multiselect = false,
                Title = "Seleccione Imagen a Editar",
            };

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                imagenName = Guid.NewGuid().ToString() + ".png";
                fileSavePath = Path.Combine("..", "..", "..", "Presentacion/Formularios/Pictures/Productos", imagenName);
                string selectedImagePath = openFile.FileName;
                fileActualPath = selectedImagePath;
                pEditarProducts.Image = Image.FromFile(fileActualPath);
            }
        }

        private void checkBoxAZT_CheckedChanged(object sender, EventArgs e)
        {
            loadLibros();
        }

        private void txEditarPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txEditarStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void iconLimpiar_Click(object sender, EventArgs e)
        {
            DialogResult limpiar = MessageBox.Show("Esta por realizar la limpieza de los campos. ¿Seguro?.", "Limpieza", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (limpiar == DialogResult.OK)
            {
                LimpiarCamposModificar();
                desactivarBotones();
            }

        }

        private void mostrarOpcionesAutor()
        {
            ProductModel productModel = new ProductModel();
            List<Autores> listaAutores = productModel.ObtenerNombresAutores();
            AutoCompleteStringCollection fuenteAutoCompletar = new AutoCompleteStringCollection();

            foreach (var autor in listaAutores)
            {
                fuenteAutoCompletar.Add(autor.Nombre); 
            }

            txEditarAutor.AutoCompleteCustomSource = fuenteAutoCompletar;
            txEditarAutor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txEditarAutor.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void mostrarOpcionesEditoriales()
        {
            ProductModel productModel = new ProductModel();
            List<Editoriales> listaEditoriales = productModel.ObtenerNombreEditoriales();

            AutoCompleteStringCollection fuenteAutoCompletar = new AutoCompleteStringCollection();

            foreach (var editorial in listaEditoriales)
            {
                fuenteAutoCompletar.Add(editorial.NombreEditorial);
            }

            txEditarEditorial.AutoCompleteCustomSource = fuenteAutoCompletar;
            txEditarEditorial.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txEditarEditorial.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void txEditarEditorial_TextChanged(object sender, EventArgs e)
        {
            txEditarEditorial.Text = txEditarEditorial.Text.ToUpper();
            txEditarEditorial.SelectionStart = txEditarEditorial.Text.Length;
        }

        private void txEditarAutor_TextChanged(object sender, EventArgs e)
        {
            txEditarAutor.Text = txEditarAutor.Text.ToUpper();
            txEditarAutor.SelectionStart = txEditarAutor.Text.Length;
        }

        private void iconAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            objFLobi.OpenChildForm(new SeccionAdministrador.CProductos(objFLobi));
        }

    }
}
