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
            return productModel.AgregarProducto(nombreTitle,descripcion,precio,imagen,stock,idCategoria,idEditorial,idAutor);
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
          
            if (!string.IsNullOrEmpty(libro.Portada) && File.Exists(libro.Portada))
            {
                libro.ImagenPortada = Image.FromFile(libro.Portada);
            }
        }

        // Método para obtener la ruta del archivo de la imagen
        public string ObtenerRutaImagen(Libro libro)
        {
            return libro.Portada;
        }

    }
}
