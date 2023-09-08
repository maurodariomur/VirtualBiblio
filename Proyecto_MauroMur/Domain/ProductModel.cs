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
        
        public async Task<bool> AgregarNuevoProducto(string nombreTitle, string descripcion, float precio, string imagen, int stock, int idCategoria, int idEditorial, int idAutor)
        {
            // Llamar al método para agregar usuario de UserDatos
            return await productModel.AgregarProducto(nombreTitle,descripcion,precio,imagen,stock,idCategoria,idEditorial,idAutor);
        }

        public async Task<bool> AgregarNuevoAutor(string nombreAutor)
        {
            // Verifica si el autor ya existe en la base de datos
            int idAutorExistente = await productModel.ObtenerIdAutor(nombreAutor);

            if (idAutorExistente != -1)
            {
                // El autor ya existe, no es necesario agregarlo nuevamente
                return true;
            }
            else
            {
                // El autor no existe, agrégalo a la base de datos
                return await productModel.AgregarAutor(nombreAutor);
            }
        }

        public async Task<bool> AgregarNuevaEditorial(string nombreEditorial)
        {
            // Verifica si la editorial ya existe en la base de datos
            int idEditorialExistente = await productModel.ObtenerIdEditorial(nombreEditorial);

            if (idEditorialExistente != -1)
            {
                // La editorial ya existe, no es necesario agregarla nuevamente
                return true;
            }
            else
            {
                // La editorial no existe, agrégala a la base de datos
                return await productModel.AgregarEditorial(nombreEditorial);
            }
        }

        public async Task<int> ObtenerIdEditorial(string editorial)
        {
            int IdEditorial = await productModel.ObtenerIdEditorial(editorial);
            return IdEditorial;
        }

        public async Task<int> ObtenerIdAutor(string autor)
        {
            int IdAutor = await productModel.ObtenerIdAutor(autor);
            return IdAutor;
        }

        public async Task<List<string>> ObtenerCategorias()
        {
            return await productModel.ObtenerCategorias();
        }

        public async Task<List<string>> ObtenerListaAutores()
        {
            return await productModel.ObtenerAutores();
        }

        public async Task<List<string>> ObtenerListaEditoriales()
        {
            return await productModel.ObtenerEditoriales();
        }

        public async Task<int> ObtenerCategoria(string nameCategoria)
        {
            int IdCategoria =  await productModel.ObtenerIdCategoria(nameCategoria);
            return IdCategoria;
        }

        public async Task<List<Autores>> ObtenerNombresAutores()
        {
            return await productModel.ObtenerNombresA();
        }

        public async Task<List<Editoriales>> ObtenerNombreEditoriales()
        {
            return await productModel.ObtenerNombresE();
        }

        public async Task<List<Libro>> MostrarProducts()
        {
            return  await productModel.ObtenerProductos();
        }

        public void CargarImagen(Libro libro)
        {
          
            if (!string.IsNullOrEmpty(libro.Portada) && File.Exists(libro.Portada))
            {
                libro.ImagenPortada = Image.FromFile(libro.Portada);
            }
        }

        // Método para obtener la ruta del archivo de la imagen
        public string? ObtenerRutaImagen(Libro libro)
        {
            return libro.Portada;
        }

    }
}
