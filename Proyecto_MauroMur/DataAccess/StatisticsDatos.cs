using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Common.Models;
using Proyecto_MauroMur.Common.Models;

namespace Proyecto_MauroMur.DataAccess
{
    internal class StatisticsDatos : ConnectionToSql
    {
        public float ObtenerTotalVentas()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT SUM(vd.SubTotalProducto) AS TotalVentas " +
                                          "FROM Venta_Detalle vd " +
                                          "INNER JOIN Venta_Cabecera vc ON vd.Id_VentaCabecera = vc.Id_VentaCabecera " +
                                          "WHERE vc.Estado = 'activo'"; 

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return Convert.ToSingle(reader["TotalVentas"]);
                        }
                    }
                }
            }

            return 0.0f;
        }

        public int ObtenerLibroMasVendido()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT TOP 1 Id_Libro, SUM(Cantidad) AS TotalVendido " +
                                          "FROM Venta_Detalle vd " +
                                          "INNER JOIN Venta_Cabecera vc ON vd.Id_VentaCabecera = vc.Id_VentaCabecera " +
                                          "WHERE vc.Estado = 'activo' " + 
                                          "GROUP BY Id_Libro " +
                                          "ORDER BY TotalVendido DESC";

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return Convert.ToInt32(reader["Id_Libro"]);
                        }
                    }
                }
            }

            return -1;
        }


        public int ObtenerLibroMenosVendido()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT TOP 1 Id_Libro, SUM(Cantidad) AS TotalVendido " +
                                          "FROM Venta_Detalle vd " +
                                          "INNER JOIN Venta_Cabecera vc ON vd.Id_VentaCabecera = vc.Id_VentaCabecera " +
                                          "WHERE vc.Estado = 'activo' " + // Filtra las ventas activas
                                          "GROUP BY Id_Libro " +
                                          "ORDER BY TotalVendido ASC";

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return Convert.ToInt32(reader["Id_Libro"]);
                        }
                    }
                }
            }

            return -1;
        }

        public int ObtenerVendedorMasExitoso()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT TOP 1 Id_Usuario, SUM(MontoTotal) AS TotalVentas " +
                                          "FROM Venta_Cabecera vc " +
                                          "WHERE vc.Estado = 'activo' " + 
                                          "GROUP BY Id_Usuario " +
                                          "ORDER BY TotalVentas DESC";

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return Convert.ToInt32(reader["Id_Usuario"]);
                        }
                    }
                }
            }

            return -1;
        }

        public List<Ventas> ObtenerLibrosMasVendidos(int cantidad)
        {
            List<Ventas> librosMasVendidos = new List<Ventas>();

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT TOP " + cantidad + " l.NombreProducto, SUM(vd.Cantidad) AS TotalVendido " +
                                          "FROM Venta_Detalle vd " +
                                          "INNER JOIN Venta_Cabecera vc ON vd.Id_VentaCabecera = vc.Id_VentaCabecera " +
                                          "INNER JOIN Libro l ON vd.Id_Libro = l.Id_Libro " +
                                          "WHERE vc.Estado = 'activo' " +
                                          "GROUP BY l.NombreProducto " +
                                          "ORDER BY TotalVendido DESC";

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Ventas libroMasVendido = new Ventas
                            {
                                Titulo = reader["NombreProducto"].ToString(),
                                Cantidad = Convert.ToInt32(reader["TotalVendido"])
                            };
                            librosMasVendidos.Add(libroMasVendido);
                        }
                    }
                }
            }

            return librosMasVendidos;
        }

        public List<Tuple<string, float>> ObtenerTresUsuariosMasExitosos()
        {
            List<Tuple<string, float>> usuariosMasExitosos = new List<Tuple<string, float>>();

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT TOP 3 p.Nombre, p.Apellido, SUM(vc.MontoTotal) AS TotalVentas " +
                                          "FROM Usuario u " +
                                          "INNER JOIN Persona p ON u.Id_Persona = p.Id_Persona " +
                                          "INNER JOIN Venta_Cabecera vc ON u.Id = vc.Id_Usuario " +
                                          "WHERE vc.Estado = 'activo' " +
                                          "GROUP BY p.Nombre, p.Apellido " +
                                          "ORDER BY TotalVentas DESC";

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nombre = reader["Nombre"].ToString()!;
                            string apellido = reader["Apellido"].ToString()!;
                            float totalVentas = Convert.ToSingle(reader["TotalVentas"]);
                            string nombreCompleto = $"{nombre} {apellido}";
                            usuariosMasExitosos.Add(new Tuple<string, float>(nombreCompleto, totalVentas));
                        }
                    }
                }
            }

            return usuariosMasExitosos;
        }

        public List<Tuple<string, float>> MejoresClientes()
        {
            List<Tuple<string, float>> usuariosMasExitosos = new List<Tuple<string, float>>();

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT TOP 3 p.Nombre, p.Apellido, SUM(vd.SubTotalProducto) AS TotalVentas " +
                                          "FROM Cliente c " +
                                          "INNER JOIN Persona p ON c.Id_Persona = p.Id_Persona " +
                                          "INNER JOIN Venta_Cabecera vc ON c.Id_Cliente = vc.Id_Cliente " +
                                          "INNER JOIN Venta_Detalle vd ON vc.Id_VentaCabecera = vd.Id_VentaCabecera " +
                                          "WHERE vc.Estado = 'activo' " +
                                          "GROUP BY p.Nombre, p.Apellido " +
                                          "ORDER BY TotalVentas DESC";

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nombre = reader["Nombre"].ToString()!;
                            string apellido = reader["Apellido"].ToString()!;
                            float totalVentas = Convert.ToSingle(reader["TotalVentas"]);
                            string nombreCompleto = $"{nombre} {apellido}";
                            usuariosMasExitosos.Add(new Tuple<string, float>(nombreCompleto, totalVentas));
                        }
                    }
                }
            }
            return usuariosMasExitosos;
        }

        public List<Tuple<DateTime, float>> ObtenerCincoMayoresVentas()
        {
            List<Tuple<DateTime, float>> cincoMayoresVentas = new List<Tuple<DateTime, float>>();

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT TOP 5 vc.FechaFactura, SUM(vd.SubTotalProducto) AS TotalVentas " +
                                          "FROM Venta_Detalle vd " +
                                          "INNER JOIN Venta_Cabecera vc ON vd.Id_VentaCabecera = vc.Id_VentaCabecera " +
                                          "WHERE vc.Estado = 'activo' " +
                                          "GROUP BY vc.Id_VentaCabecera, vc.FechaFactura " +
                                          "ORDER BY TotalVentas DESC";

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateTime fechaVenta = Convert.ToDateTime(reader["FechaFactura"]);
                            float montoVenta = Convert.ToSingle(reader["TotalVentas"]);
                            cincoMayoresVentas.Add(new Tuple<DateTime, float>(fechaVenta, montoVenta));
                        }
                    }
                }
            }

            return cincoMayoresVentas;
        }
    }
}
