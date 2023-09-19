using Common.Models;
using DataAccess;
using Proyecto_MauroMur.Common.Models;
using Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionAdministrador;
using Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionVendedor;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proyecto_MauroMur.DataAccess
{
    internal class ProductsDatos : ConnectionToSql
    {
        public bool AgregarEditorial(string nombreEditorial)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Editorial (NombreEditorial) VALUES (@NombreEditorial)";

                    command.Parameters.AddWithValue("@NombreEditorial", nombreEditorial);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        public bool AgregarAutor(string nombreAutor)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Autor (Nombre) VALUES (@Nombre)";

                    command.Parameters.AddWithValue("@Nombre", nombreAutor);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        public int ObtenerIdEditorial(string nameEditorial)
        {
            int editorialId = -1;

            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();

                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT Id_Editorial FROM Editorial WHERE NombreEditorial = @NombreEditorial";
                        command.Parameters.AddWithValue("@NombreEditorial", nameEditorial);

                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            editorialId = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción adecuadamente, por ejemplo, registrarla o lanzar una excepción personalizada.
                Console.WriteLine("Error: " + ex.Message);
                // También puedes lanzar una excepción personalizada aquí si lo prefieres.
            }

            return editorialId;
        }

        public int ObtenerIdAutor(string nameAutor)
        {

            int autor = -1;
            string nombreAutor = nameAutor != null ? nameAutor : "";

            using (var connection = GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT Id_Autor FROM Autor WHERE Nombre = @Nombre";
                    command.Parameters.AddWithValue("@Nombre", nombreAutor);

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        autor = Convert.ToInt32(result);
                    }
                }
            }
            return autor;
        }

        public bool AgregarProducto(string nombreTitle, string descripcion, float precio, string imagen, int stock, int idCategoria, int idEditorial, int idAutor)
        {
            using (var connetion = GetConnection())
            {
                connetion.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connetion;
                    command.CommandText = "INSERT INTO Libro (NombreProducto,Descripcion,PrecioUnitario,Imagen,Stock,Id_Categoria,Id_Editorial,Id_Autor) VALUES (@NombreProducto,@Descripcion,@PrecioUnitario,@Imagen,@Stock,@Id_Categoria,@Id_Editorial,@Id_Autor)";

                    command.Parameters.AddWithValue("@NombreProducto", nombreTitle);
                    command.Parameters.AddWithValue("@Descripcion", descripcion);
                    command.Parameters.AddWithValue("@PrecioUnitario", precio);
                    command.Parameters.AddWithValue("@Imagen", imagen);
                    command.Parameters.AddWithValue("@Stock", stock);
                    command.Parameters.AddWithValue("@Id_Categoria", idCategoria);
                    command.Parameters.AddWithValue("@Id_Editorial", idEditorial);
                    command.Parameters.AddWithValue("@Id_Autor", idAutor);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        public List<string> ObtenerCategorias()
        {
            using (var connection = GetConnection())
            {
                List<string> categorias = new List<string>();
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    string query = "SELECT Nombre FROM Categoria";
                    command.CommandText = query;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            categorias.Add(reader["Nombre"].ToString());
                        }
                    }
                }

                return categorias;
            }
        }

        public List<string> ObtenerAutores()
        {
            using (var connection = GetConnection())
            {
                List<string> autores = new List<string>();
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    string query = "SELECT Nombre FROM Autor";
                    command.CommandText = query;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            autores.Add(reader["Nombre"].ToString());
                        }
                    }
                }

                return autores;
            }
        }

        public List<string> ObtenerEditoriales()
        {
            using (var connection = GetConnection())
            {
                List<string> editoriales = new List<string>();
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    string query = "SELECT NombreEditorial FROM Editorial";
                    command.CommandText = query;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            editoriales.Add(reader["NombreEditorial"].ToString());
                        }
                    }
                }

                return editoriales;
            }
        }

        public int ObtenerIdCategoria(string nameCategoria)
        {

            int categoria = 0;

            using (var connection = GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT Id_Categoria FROM Categoria WHERE Nombre = @Nombre";
                    command.Parameters.AddWithValue("@Nombre", nameCategoria);

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        categoria = Convert.ToInt32(result);
                    }
                }
            }
            return categoria;
        }

        public List<Autores> ObtenerNombresA()
        {
            List<Autores> autores = new();

            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "SELECT * FROM Autor";

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Autores autor = new();
                            autor.Id_Autor = reader.GetInt32(0);
                            autor.Nombre = reader.GetString(1);
                            autores.Add(autor);
                        }
                    }
                }
            }

            return autores;
        }

        public List<Editoriales> ObtenerNombresE()
        {
            List<Editoriales> editoriales = new();

            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "SELECT * FROM Editorial";

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Editoriales editorial = new();
                            editorial.Id_Editorial = reader.GetInt32(0);
                            editorial.NombreEditorial = reader.GetString(1);
                            editoriales.Add(editorial);
                        }
                    }
                }
            }

            return editoriales;
        }

        public List<Libro> ObtenerProductos()
        {
            List<Libro> productos = new List<Libro>();

            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "SELECT L.*, A.Nombre AS Autor, E.NombreEditorial AS Editorial, C.Nombre AS Categoria " +
                                          "FROM Libro L " +
                                          "INNER JOIN Autor A ON L.Id_Autor = A.Id_Autor " +
                                          "INNER JOIN Editorial E ON L.Id_Editorial = E.Id_Editorial " +
                                          "INNER JOIN Categoria C ON L.Id_Categoria = C.Id_Categoria";

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Libro libro = new Libro();
                            libro.Id_Libro = reader.GetInt32(0);
                            libro.Titulo = reader.GetString(1);
                            libro.Descripcion = reader.GetString(2);
                            libro.Precio = reader.GetDouble(3);
                            libro.Imagen = reader.GetString(4);
                            libro.Stock = reader.GetInt32(5);
                            libro.Baja = reader.GetString(6);
                            libro.Id_Categoria = reader.GetInt32(7);
                            libro.Categoria = reader.GetString(12);
                            libro.Id_Editorial = reader.GetInt32(8);
                            libro.Editorial = reader.GetString(11);
                            libro.Id_Autor = reader.GetInt32(9);
                            libro.Autor = reader.GetString(10);
                            productos.Add(libro);
                        }
                    }
                }
            }

            return productos;
        }

        public Libro ObtenerProductoId(int idLibro)
        {
            Libro producto = new();

            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "SELECT L.*, A.Nombre AS Autor, E.NombreEditorial AS Editorial, C.Nombre AS Categoria " +
                                          "FROM Libro L " +
                                          "INNER JOIN Autor A ON L.Id_Autor = A.Id_Autor " +
                                          "INNER JOIN Editorial E ON L.Id_Editorial = E.Id_Editorial " +
                                          "INNER JOIN Categoria C ON L.Id_Categoria = C.Id_Categoria " +
                                          "WHERE L.Id_Libro = @ProductId";
                   
                    comando.Parameters.AddWithValue("@ProductId", idLibro);
                    
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read()) // Verificar si hay datos para leer
                        {
                            producto.Id_Libro = reader.GetInt32(0);
                            producto.Titulo = reader.GetString(1);
                            producto.Descripcion = reader.GetString(2);
                            producto.Precio = reader.GetDouble(3);
                            producto.Imagen = reader.GetString(4);
                            producto.Stock = reader.GetInt32(5);
                            producto.Baja = reader.GetString(6);
                            producto.Id_Categoria = reader.GetInt32(7);
                            producto.Categoria = reader.GetString(12);
                            producto.Id_Editorial = reader.GetInt32(8);
                            producto.Editorial = reader.GetString(11);
                            producto.Id_Autor = reader.GetInt32(9);
                            producto.Autor = reader.GetString(10);
                        }
                    }
                }
            }

            return producto;
        }

        public bool ActualizarLibro(int idLibro,string titulo, string descripcion, double precio, string imagen, int stock, string baja, int idCategoria,string autor,string editorial)
        {
           Libro libroEditar = ObtenerProductoId(idLibro);

            if (libroEditar.Autor != autor)
            {
                AgregarAutor(autor);

            }
            if (libroEditar.Editorial != editorial)
            {
                AgregarEditorial(editorial);

            }

            int idAutor = ObtenerIdAutor(autor);
            int idEditorial=ObtenerIdEditorial(editorial);

            using (var connection = GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Libro SET NombreProducto = @NombreProducto, Descripcion = @Descripcion, PrecioUnitario = @PrecioUnitario, Imagen = @Imagen, Stock = @Stock, Baja = @Baja, Id_Categoria = @Id_Categoria, Id_Editorial = @Id_Editorial, Id_Autor = @Id_Autor WHERE Id_Libro = @Id_Libro";

                    command.Parameters.AddWithValue("@NombreProducto", titulo);
                    command.Parameters.AddWithValue("@Descripcion", descripcion);
                    command.Parameters.AddWithValue("@PrecioUnitario", precio);
                    command.Parameters.AddWithValue("@Imagen", imagen);
                    command.Parameters.AddWithValue("@Stock", stock);
                    command.Parameters.AddWithValue("@Baja", baja);
                    command.Parameters.AddWithValue("@Id_Categoria", idCategoria);
                    command.Parameters.AddWithValue("@Id_Libro", idLibro);
                    command.Parameters.AddWithValue("@Id_Autor", idAutor);
                    command.Parameters.AddWithValue("@Id_Editorial", idEditorial);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                        return false;
                    }
                }
            }
        }



        public bool ActualizarAutor(string nombreAutor)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Autor SET Nombre = @Nombre WHERE Id_Autor = @Id_Autor";

                    command.Parameters.AddWithValue("@Nombre", nombreAutor);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        public bool ActualizarEditorial(string nombreEditorial)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Editorial SET NombreEditorial = @NombreEditorial WHERE Id_Editorial = @Id_Editorial";

                    command.Parameters.AddWithValue("@NombreEditorial", nombreEditorial);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        public void LlenarBotones(FlowLayoutPanel Contenedor,CCatalogo catalog)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Libro WHERE baja = 'NO' AND stock > 0";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Libro libro = new Libro();
                            libro.Id_Libro = Convert.ToInt32(reader[0]);
                            libro.Titulo = reader.GetString(1);
                            libro.Descripcion = reader.GetString(2);
                            libro.Precio = Convert.ToDouble(reader[3]);
                            libro.Imagen = reader.GetString(4);
                            libro.Stock = Convert.ToInt32(reader[5]);

                            BotonesLibros btn = new BotonesLibros();
                            btn.idLibro = libro.Id_Libro;
                            btn.tituloLibro = libro.Titulo;
                            btn.descripcionLibro = libro.Descripcion;
                            btn.precioLibro = "$" + libro.Precio.ToString("N2");
                            btn.stockLibro = "Stock " + libro.Stock.ToString();

                            // Cargar la imagen desde el archivo y establecerla en el botón
                            string libroPath = Path.Combine("..", "..", "..", "Presentacion/Formularios/Pictures/Productos", libro.Imagen!);
                            if (File.Exists(libroPath))
                            {
                                btn.imagenLibro = Image.FromFile(libroPath);
                            }

                            Contenedor.Controls.Add(btn);
                            catalog.listaDeBotones.Add(btn);
                        }
                    }
                }
            }
        }

    }
}