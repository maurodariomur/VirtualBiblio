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
using Proyecto_MauroMur.Common.Models;
using Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionGerente;
using System.Net;
using System.Drawing.Imaging;

namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionAdministrador
{
    public partial class CProductos : Form
    {
        private FLobi objFLobi;
        private const int maxCaracteres = 200;

        public CProductos(FLobi flobi)
        {
            InitializeComponent();
            this.objFLobi = flobi;
        }

        private void CProductos_Load(object sender, EventArgs e)
        {
            opcionesCategoria();
            mostrarOpcionesAutor();
            mostrarOpcionesEditoriales();
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
            Image imagenAGuardar = pProducts.Image;
            string carpetaDestino = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Presentacion/Formularios/Pictures/Productos");
            carpetaDestino = Path.GetFullPath(carpetaDestino);
            string stockStr = txStock.Text;
            string categoria = txCategoria.Text;
            ProductModel producModel = new();

            if (nombreProd == "Titulo" || nombreEditorial == "Editorial" || nombreAutor == "Autor")
            {
                msgError("Debe completar todos los campos");
            }
            else if (string.IsNullOrWhiteSpace(nombreProd) || string.IsNullOrWhiteSpace(nombreEditorial) || string.IsNullOrWhiteSpace(precioStr) || string.IsNullOrWhiteSpace(descripcion))
            {
                msgError("Debe completar todos los campos");
            }
            else if (ObtenerCategoria() == 0)
            {
                msgError("Debe seleccionar una categoria");
            }
            else if (!float.TryParse(precioStr, out float precio) || !int.TryParse(stockStr, out int stock))
            {
                msgError("Ingrese valores válidos en los campos numéricos (Precio, Stock)");
            }
            else if (imagen == "Path: Producto")
            {
                msgError("Ingrese una imagen");
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

                        // Actualiza la variable "imagen" con la ruta completa
                        string nombreArchivo = Path.GetFileName(lbPathTittleP.Text);
                        string rutaCompleta = Path.Combine(carpetaDestino, nombreArchivo);
                        imagen = rutaCompleta; // Actualiza la variable "imagen" con la ruta completa

                        bool productoAgregado = producModel.AgregarNuevoProducto(nombreProd, descripcion, precio, imagen, stock, idCategoria, idEditorial, idAutor);

                        if (productoAgregado)
                        {
                            // Copia la imagen a la carpeta de destino
                            File.Copy(lbPathTittleP.Text, rutaCompleta, true);

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
            txAutor.Text = "Autor";
            txStock.Text = "Stock";
            txCategoria.SelectedIndex = 0;
            txNameProducto.Focus();
        }

        private int ObtenerCategoria()
        {
            ProductModel userModel = new ProductModel();

            if (txCategoria.SelectedItem != null)
            {
                string? categoria = txCategoria.SelectedItem.ToString();

                // Verificar que tipoSeleccionado no sea nulo o vacío antes de usarlo
                if (!string.IsNullOrWhiteSpace(categoria))
                {
                    // Utiliza el método ObtenerIdTipoPerfil para obtener el Id del tipo de perfil
                    int tipoCategoria = userModel.ObtenerCategoria(categoria);

                    // Si se encontró el tipo de perfil en la base de datos, devuelve su Id
                    if (tipoCategoria != -1)
                    {
                        return tipoCategoria;
                    }
                }
            }
            return 0; // Opción por defecto si no se selecciona nada o no se encuentra en la base de datos
        }

        //LIMITAR CARACTERES EN DESCRIPCION
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

        //TITULOS DE LOS TEXTBOXS
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
            if (txEditorial.Text == "Editorial" || txEditorial.Text == "EDITORIAL")
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
            if (txAutor.Text == "Autor" || txAutor.Text == "AUTOR")
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

        //MOSTRAR IMAGENES
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

        //MOSTRAR OPCIONES DE CATEGORIAS EN EL CHECKEDLISTBOX
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

        //AUTOCOMPLETAR TEXTBOX
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

        private void mostrarOpcionesEditoriales()
        {
            ProductModel productModel = new ProductModel();
            // Cargar la lista de objetos Autores desde la base de datos
            List<Editoriales> listaEditoriales = productModel.ObtenerNombreEditoriales();

            // Configurar la fuente personalizada de autocompletar
            AutoCompleteStringCollection fuenteAutoCompletar = new AutoCompleteStringCollection();

            // Extraer nombres de autores y agregarlos a la colección de autocompletar
            foreach (var editorial in listaEditoriales)
            {
                fuenteAutoCompletar.Add(editorial.NombreEditorial); // Reemplaza "Nombre" con el nombre de la propiedad que almacena el nombre del autor en tu clase Autores
            }

            // Asignar la fuente personalizada al TextBox
            txEditorial.AutoCompleteCustomSource = fuenteAutoCompletar;
            txEditorial.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txEditorial.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void txEditorial_TextChanged(object sender, EventArgs e)
        {
            txEditorial.Text = txEditorial.Text.ToUpper();
            txEditorial.SelectionStart = txEditorial.Text.Length;
        }

        private void txAutor_TextChanged(object sender, EventArgs e)
        {
            txAutor.Text = txAutor.Text.ToUpper();
            txAutor.SelectionStart = txAutor.Text.Length;
        }

        private void btTablaProductos_Click(object sender, EventArgs e)
        {
            this.Close();
            objFLobi.OpenChildForm(new SeccionAdministrador.CTablaProductos());
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
