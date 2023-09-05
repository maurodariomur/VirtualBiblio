using Domain;
using Microsoft.Win32;
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
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Common.Models;



namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionAdministrador
{
    public partial class CProductos : Form
    {
        private const int maxCaracteres = 200;

        public CProductos()
        {
            InitializeComponent();
        }

        private void CProductos_Load(object sender, EventArgs e)
        {

            opcionesCategoria();
            mostrarOpcionesAutor();

        }

        private void msgError(string msg)
        {
            lbErrorProd.Text = "     " + msg;
            lbErrorProd.Visible = true;
        }

        private void btRegistrarProd_Click(object sender, EventArgs e)
        {
            string nombreProd = txNameProducto.Text;
            string nombreEditorial = txEditorial.Text;
            string nombreAutor = txAutor.Text;
            string precioStr = txPrecio.Text;
            string descripcion = rtbDescripcion.Text;
            string imagen = lbPathTittleP.Text;
            string stockStr = txStock.Text;
            string categoria = txCategoria.Text;

            ProductModel producModel = new();

            if (string.IsNullOrWhiteSpace(nombreProd) || string.IsNullOrWhiteSpace(nombreEditorial) || string.IsNullOrWhiteSpace(precioStr) || string.IsNullOrWhiteSpace(descripcion))
            {
                msgError("Debe completar todos los campos");
            }
            else if (!float.TryParse(precioStr, out float precio) || !int.TryParse(stockStr, out int stock))
            {
                msgError("Ingrese valores válidos en los campos numéricos (Precio, Stock)");
            }
            else
            {
                // Mostrar mensaje de confirmación
                DialogResult confirmResult = MessageBox.Show("¿Está seguro que desea registrar este producto?", "Confirmar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    bool AutorAgregado = producModel.AgregarNuevoAutor(nombreAutor);
                    bool EditorialAgregado = producModel.AgregarNuevaEditorial(nombreEditorial);
                    if (AutorAgregado && EditorialAgregado)
                    {
                        // Ambos autor y editorial se agregaron correctamente o ya existían
                        // Llama al método AgregarNuevoProducto con los valores convertidos
                        int idEditorial = producModel.ObtenerIdEditorial(nombreEditorial);
                        int idAutor = producModel.ObtenerIdAutor(nombreAutor);
                        int idCategoria = producModel.ObtenerCategoria(categoria);

                        bool productoAgregado = producModel.AgregarNuevoProducto(nombreProd, descripcion, precio, imagen, stock, idCategoria, idEditorial, idAutor);

                        if (productoAgregado)
                        {
                            MessageBox.Show("Libro agregado exitosamente: " + nombreProd, "Libro Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("Hubo un problema al agregar el libro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hubo un problema al agregar el autor o la editorial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void LimpiarCampos()
        {
            txNameProducto.Text = "Nombre";
            txEditorial.Text = "Editorial";
            txPrecio.Text = "$ Precio";
            rtbDescripcion.Text = "Descripcion";
            txNameProducto.Focus();
        }

        private void rtbDescripcion_TextChanged(object sender, EventArgs e)
        {
            // Obtén la longitud actual del texto en el RichTextBox
            int longitudTexto = rtbDescripcion.TextLength;

            // Verifica si se excede el límite de caracteres
            if (longitudTexto > maxCaracteres)
            {
                // Si se excede, limita el texto a la longitud máxima
                rtbDescripcion.Text = rtbDescripcion.Text.Substring(0, maxCaracteres);
                rtbDescripcion.SelectionStart = maxCaracteres;
                rtbDescripcion.SelectionLength = 0;
            }

            // Actualiza el contador de caracteres restantes en lbLimite
            lbLimite.Text = "Caracteres restantes: " + (maxCaracteres - longitudTexto);
            lbLimite.Visible = longitudTexto > 0;
        }

        private void txNameProducto_Enter(object sender, EventArgs e)
        {
            if (txNameProducto.Text == "Titulo")
            {
                txNameProducto.Text = "";
            }
        }

        private void txNameProducto_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txNameProducto.Text))
            {
                txNameProducto.Text = "Titulo";
            }
        }

        private void txEditorial_Enter(object sender, EventArgs e)
        {
            if (txEditorial.Text == "Editorial")
            {
                txEditorial.Text = "";
            }
        }

        private void txEditorial_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txEditorial.Text))
            {
                txEditorial.Text = "Editorial";
            }
        }

        private void txPrecio_Enter(object sender, EventArgs e)
        {
            if (txPrecio.Text == "$ Precio")
            {
                txPrecio.Text = "";
            }
        }

        private void txPrecio_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txPrecio.Text))
            {
                txPrecio.Text = "$ Precio";
            }
        }

        private void txPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' && (sender as TextBox).Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        private void lbLimite_Click(object sender, EventArgs e)
        {

        }

        private void lbStock_Click(object sender, EventArgs e)
        {

        }

        private void txStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void txStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txStock_Enter(object sender, EventArgs e)
        {
            if (txStock.Text == "Stock")
            {
                txStock.Text = "";
            }
        }

        private void txStock_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txStock.Text))
            {
                txStock.Text = "Stock";
            }
        }

        private void txAutor_Enter(object sender, EventArgs e)
        {
            if (txAutor.Text == "Autor")
            {
                txAutor.Text = "";
            }
        }

        private void txAutor_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txAutor.Text))
            {
                txAutor.Text = "Autor";
            }
        }

        private void iconImagen_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFile = new();
            openFile.Filter = "Archivos de imagen|*.jpg;*jpeg;*png;*.gif;*.bmp";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFile.FileName;

                // Verificar si el archivo seleccionado es una imagen
                if (IsImageFile(selectedImagePath))
                {
                    // Mostrar la imagen en el PictureBox
                    pProducts.Image = Image.FromFile(selectedImagePath);

                    // Mostrar la ruta del archivo en el TextBox
                    lbPathTittleP.Text = selectedImagePath;
                }
                else
                {
                    MessageBox.Show("El archivo seleccionado no es una imagen válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private bool IsImageFile(string filePath)
        {
            string extension = Path.GetExtension(filePath);
            if (extension != null)
            {
                string ext = extension.ToLower();
                return ext == ".jpg" || ext == ".jpeg" || ext == ".png" || ext == ".gif" || ext == ".bmp";
            }
            return false;
        }

        private void txNameProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void opcionesCategoria()
        {
            ProductModel productModel = new ProductModel();
            var categorias = productModel.ObtenerCategorias();

            // Agrega el mensaje predeterminado al comienzo de la lista
            categorias.Insert(0, "Seleccione Categoría");

            // Asigna la lista de categorías como DataSource del ComboBox
            txCategoria.DataSource = categorias;

            // Establece el índice seleccionado por defecto en 0 para mostrar el mensaje predeterminado
            txCategoria.SelectedIndex = 0;
        }

        private void mostrarOpcionesAutor()
        {
            ProductModel productModel = new ProductModel();
            // Cargar la lista de objetos Autores desde la base de datos
            List<Autores> listaAutores = productModel.ObtenerNombresAutores();

            // Configurar la fuente personalizada de autocompletar
            AutoCompleteStringCollection fuenteAutoCompletar = new AutoCompleteStringCollection();

            // Extraer nombres de autores y agregarlos a la colección de autocompletar
            foreach (var autor in listaAutores)
            {
                fuenteAutoCompletar.Add(autor.Nombre); // Reemplaza "Nombre" con el nombre de la propiedad que almacena el nombre del autor en tu clase Autores
            }

            // Asignar la fuente personalizada al TextBox
            txAutor.AutoCompleteCustomSource = fuenteAutoCompletar;
            txAutor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txAutor.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
    }
}
