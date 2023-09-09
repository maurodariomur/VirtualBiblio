using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using System.Threading.Tasks;
using Proyecto_MauroMur.DataAccess;
using Common.Models;
using Proyecto_MauroMur.Common.Models;

namespace Proyecto_MauroMur.Domain
{
    internal class ProductModel
    {
        private ProductsDatos productModel = new();

        public bool AgregarNuevoProducto(string nombreTitle, string descripcion, float precio, string imagen, int stock, int idCategoria, int idEditorial, int idAutor)
        {
            // Llamar al método para agregar usuario de UserDatos
            return productModel.AgregarProducto(nombreTitle, descripcion, precio, imagen, stock, idCategoria, idEditorial, idAutor);
        }

        public bool AgregarNuevoAutor(string nombreAutor)
        {
            // Verifica si el autor ya existe en la base de datos
            int idAutorExistente = productModel.ObtenerIdAutor(nombreAutor);

            if (idAutorExistente != -1)
            {
                // El autor ya existe, no es necesario agregarlo nuevamente
                return true;
            }
            else
            {
                // El autor no existe, agrégalo a la base de datos
                return productModel.AgregarAutor(nombreAutor);
            }
        }

        public bool AgregarNuevaEditorial(string nombreEditorial)
        {
            // Verifica si la editorial ya existe en la base de datos
            int idEditorialExistente = productModel.ObtenerIdEditorial(nombreEditorial);

            if (idEditorialExistente != -1)
            {
                // La editorial ya existe, no es necesario agregarla nuevamente
                return true;
            }
            else
            {
                // La editorial no existe, agrégala a la base de datos
                return productModel.AgregarEditorial(nombreEditorial);
            }
        }

        public int ObtenerIdEditorial(string editorial)
        {
            int IdEditorial = productModel.ObtenerIdEditorial(editorial);
            return IdEditorial;
        }

        public int ObtenerIdAutor(string autor)
        {
            int IdAutor = productModel.ObtenerIdAutor(autor);
            return IdAutor;
        }

        public List<string> ObtenerCategorias()
        {
            return productModel.ObtenerCategorias();
        }

        public List<string> ObtenerListaAutores()
        {
            return productModel.ObtenerAutores();
        }

        public List<string> ObtenerListaEditoriales()
        {
            return productModel.ObtenerEditoriales();
        }

        public int ObtenerCategoria(string nameCategoria)
        {
            int IdCategoria = productModel.ObtenerIdCategoria(nameCategoria);
            return IdCategoria;
        }

        public List<Autores> ObtenerNombresAutores()
        {
            return productModel.ObtenerNombresA();
        }

        public List<Editoriales> ObtenerNombreEditoriales()
        {
            return productModel.ObtenerNombresE();
        }

        public List<Libro> MostrarProducts()
        {
            return productModel.ObtenerProductos();
        }

        public void CargarImagen(Libro libro)
        {

            if (!string.IsNullOrEmpty(libro.Ruta) && File.Exists(libro.Ruta))
            {
                libro.ImagenPortada = Image.FromFile(libro.Ruta);
            }
        }

        // Método para obtener la ruta del archivo de la imagen
        public string? ObtenerRutaImagen(Libro libro)
        {
            return libro.Ruta;
        }


        public bool ActualizarLibro(string titulo, string descripcion, double precio, string portada, int stock, string baja, int idCategoria, int idLibro)
        {
            // Suponiendo que Libro tiene propiedades como IdLibro, Titulo, Descripcion, Precio, Portada, Stock, Baja, Id_Categoria, Id_Editorial, Id_Autor, etc.
            return productModel.ActualizarLibro(titulo, descripcion, precio, portada, stock, baja, idCategoria, idLibro);
        }

        public bool ActualizarAutor(string nombreAutor)
        {
            // Suponiendo que Autor tiene propiedades como IdAutor y Nombre.
            return productModel.ActualizarAutor(nombreAutor);
        }

        public bool ActualizarEditorial(string nombreEditorial)
        {
            // Suponiendo que Editorial tiene propiedades como IdEditorial y NombreEditorial.
            return productModel.ActualizarEditorial(nombreEditorial);
        }


    }
}