using Common.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Common.Cache;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_MauroMur.Common.Models;

namespace DataAccess
{
    internal class SaleDatos : ConnectionToSql
    {
        public bool AgregarFactura(DateTime fechaFactura, float montoTotal, int idCliente, int idUsuario, int idMetodoPago, int idTipoFactura)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Venta_Cabecera (FechaFactura, MontoTotal, Id_Cliente, Id_Usuario, Id_MetodoPago,Id_TipoFactura) " +
                                           "VALUES (@FechaFactura, @MontoTotal, @Id_Cliente, @Id_Usuario, @Id_MetodoPago, @Id_TipoFactura); ";

                    command.Parameters.AddWithValue("@FechaFactura", fechaFactura);
                    command.Parameters.AddWithValue("@MontoTotal", montoTotal);
                    command.Parameters.AddWithValue("@Id_Cliente", idCliente);
                    command.Parameters.AddWithValue("@Id_Usuario", idUsuario);
                    command.Parameters.AddWithValue("@Id_MetodoPago", idMetodoPago);
                    command.Parameters.AddWithValue("@Id_TipoFactura", idTipoFactura);

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

        public int ObtenerUltimoIdVentaCabecera()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT MAX(Id_VentaCabecera) FROM Venta_Cabecera;";

                    try
                    {
                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            return Convert.ToInt32(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al obtener el último ID de Venta_Cabecera: " + ex.Message);
                    }
                }
            }

            return 0; 
        }

        public bool AgregarVentaConDetalle(DateTime fechaFactura, float montoTotal, int idCliente, int idUsuario, int idMetodoPago, int idTipoFactura, List<Venta_Detalle> detalles)
        {
            bool cabeceraAgregada = AgregarFactura(fechaFactura, montoTotal, idCliente, idUsuario, idMetodoPago, idTipoFactura);

            if (!cabeceraAgregada)
            {
                return false;
            }

            int idVentaCabecera = ObtenerUltimoIdVentaCabecera();

            if (idVentaCabecera > 0)
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            foreach (var detalle in detalles)
                            {
                                using (var detalleCommand = new SqlCommand())
                                {
                                    detalleCommand.Connection = connection;
                                    detalleCommand.Transaction = transaction;
                                    detalleCommand.CommandText = "INSERT INTO Venta_Detalle (PrecioProducto, Cantidad, SubTotalProducto, Id_Libro, Id_VentaCabecera) " +
                                                                "VALUES (@PrecioProducto, @Cantidad, @SubTotalProducto, @Id_Libro, @Id_VentaCabecera);";

                                    detalleCommand.Parameters.AddWithValue("@PrecioProducto", detalle.PrecioProducto);
                                    detalleCommand.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
                                    detalleCommand.Parameters.AddWithValue("@SubTotalProducto", detalle.SubTotalProducto);
                                    detalleCommand.Parameters.AddWithValue("@Id_Libro", detalle.Id_Libro);
                                    detalleCommand.Parameters.AddWithValue("@Id_VentaCabecera", idVentaCabecera);

                                    detalleCommand.ExecuteNonQuery();
                                }
                            }

                            transaction.Commit(); 
                            return true;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                            transaction.Rollback(); // Revertir la transacción en caso de error
                            return false;
                        }
                    }
                }
            }
            else
            {
                return false;
            }
        }

        public List<string> ObtenerTipoFacturas()
        {
            using (var connection = GetConnection())
            {
                List<string> facturas = new List<string>();
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    string query = "SELECT TipoFactura FROM Tipo_Factura";
                    command.CommandText = query;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            facturas.Add(reader["TipoFactura"].ToString()!);
                        }
                    }
                }

                return facturas;
            }
        }

        public List<string> ObtenerMetodoPago()
        {
            using (var connection = GetConnection())
            {
                List<string> tipoPagos = new List<string>();
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    string query = "SELECT TipoPago FROM Metodo_Pago";
                    command.CommandText = query;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tipoPagos.Add(reader["TipoPago"].ToString()!);
                        }
                    }
                }

                return tipoPagos;
            }
        }

        public int ObtenerIdMetodoPago(string metodoPago)
        {
            int metodoPagoId = -1;

            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();

                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT Id_MetodoPago FROM Metodo_Pago WHERE TipoPago = @TipoPago";
                        command.Parameters.AddWithValue("@TipoPago", metodoPago);

                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            metodoPagoId = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return metodoPagoId;
        }

        public bool ActualizarStockLibro(int idLibro, int cantidadVendida)
        {
            int nuevoStock = ObtenerStockLibro(idLibro) - cantidadVendida;

            if (nuevoStock >= 0)
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "UPDATE Libro SET Stock = @Stock WHERE Id_Libro = @Id_Libro;";
                        command.Parameters.AddWithValue("@Stock", nuevoStock);
                        command.Parameters.AddWithValue("@Id_Libro", idLibro);

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
            else
            {
                return false;
            }
        }

        private int ObtenerStockLibro(int idLibro)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT Stock FROM Libro WHERE Id_Libro = @Id_Libro;";
                    command.Parameters.AddWithValue("@Id_Libro", idLibro);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.GetInt32(reader.GetOrdinal("Stock"));
                        }
                        else
                        {
                            return 0; 
                        }
                    }
                }
            }
        }

        public int ObtenerIdTipoFactura(string tipoFactura)
        {
            int tipoFacturaId = -1;

            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();

                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT Id_TipoFactura FROM Tipo_Factura WHERE TipoFactura = @TipoFactura";
                        command.Parameters.AddWithValue("@TipoFactura", tipoFactura);

                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            tipoFacturaId = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return tipoFacturaId;
        }

        public List<Ventas> ObtenerDetalleFacturaUltimaCabecera()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT VD.PrecioProducto, VD.Cantidad, VD.SubTotalProducto, " +
                                          "L.NombreProducto, A.Nombre, E.NombreEditorial " +
                                          "FROM Venta_Detalle VD " +
                                          "INNER JOIN Libro L ON VD.Id_Libro = L.Id_Libro " +
                                          "INNER JOIN Autor A ON L.Id_Autor = A.Id_Autor " +
                                          "INNER JOIN Editorial E ON L.Id_Editorial = E.Id_Editorial " +
                                          "WHERE VD.Id_VentaCabecera = (SELECT MAX(Id_VentaCabecera) FROM Venta_Cabecera);";

                    List<Ventas> detalles = new List<Ventas>();

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Ventas detalle = new Ventas
                            {
                                PrecioProducto = Convert.ToSingle(reader["PrecioProducto"]),
                                Cantidad = Convert.ToInt32(reader["Cantidad"]),
                                SubTotalProducto = Convert.ToSingle(reader["SubTotalProducto"]),
                                Titulo = reader["NombreProducto"].ToString(),
                                NombreAutor = reader["Nombre"].ToString(),
                                NombreEditorial = reader["NombreEditorial"].ToString()
                            };

                            detalles.Add(detalle);
                        }
                    }

                    return detalles;
                }
            }
        }

        public List<Ventas> ObtenerVentasPorUsuarioConNombres(int idUsuario)
        {
            List<Ventas> ventasList = new List<Ventas>();
            string query = "SELECT VC.Id_VentaCabecera, VC.FechaFactura, VC.MontoTotal, " +
                           "PC.Nombre AS NombreCliente, PC.Apellido AS ApellidoCliente, PC.DNI AS DNICliente, " +
                           "PV.Nombre AS NombreVendedor, PV.Apellido AS ApellidoVendedor, " +
                           "MP.TipoPago, TF.TipoFactura, VC.Estado " +
                           "FROM Venta_Cabecera VC " +
                           "INNER JOIN Cliente C ON VC.Id_Cliente = C.Id_Cliente " +
                           "INNER JOIN Usuario U ON VC.Id_Usuario = U.Id " +
                           "INNER JOIN Persona PC ON C.Id_Persona = PC.Id_Persona " +
                           "INNER JOIN Persona PV ON U.Id_Persona = PV.Id_Persona " +
                           "INNER JOIN Metodo_Pago MP ON VC.Id_MetodoPago = MP.Id_MetodoPago " +
                           "INNER JOIN Tipo_Factura TF ON VC.Id_TipoFactura = TF.Id_TipoFactura " +
                           "WHERE VC.Id_Usuario = @IdUsuario";

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {

                        Ventas venta = new Ventas
                        {
                            Id_VentaCabecera = Convert.ToInt32(reader["Id_VentaCabecera"]),
                            FechaFactura = Convert.ToDateTime(reader["FechaFactura"]),
                            MontoTotal = Convert.ToSingle(reader["MontoTotal"]),
                            NombreCliente = reader["NombreCliente"].ToString(),
                            ApellidoCliente = reader["ApellidoCliente"].ToString(),
                            DNICliente = reader["DNICliente"].ToString(),
                            NombreVendedor = reader["NombreVendedor"].ToString(),
                            ApellidoVendedor = reader["ApellidoVendedor"].ToString(),
                            TipoPago = reader["TipoPago"].ToString(),
                            TipoFactura = reader["TipoFactura"].ToString(),
                            Estado = reader["Estado"].ToString(),
                        };

                        ventasList.Add(venta);
                    }
                }
            }
            return ventasList;
        }

        public List<Ventas> ObtenerHistorialVentas()
        {
            List<Ventas> ventasList = new List<Ventas>();
            string query = "SELECT VC.Id_VentaCabecera, VC.FechaFactura, VC.MontoTotal, " +
                           "PC.Nombre AS NombreCliente, PC.Apellido AS ApellidoCliente, PC.DNI AS DNICliente, " +
                           "PV.Nombre AS NombreVendedor, PV.Apellido AS ApellidoVendedor, " +
                           "MP.TipoPago, TF.TipoFactura, VC.Estado " +
                           "FROM Venta_Cabecera VC " +
                           "INNER JOIN Cliente C ON VC.Id_Cliente = C.Id_Cliente " +
                           "INNER JOIN Usuario U ON VC.Id_Usuario = U.Id " +
                           "INNER JOIN Persona PC ON C.Id_Persona = PC.Id_Persona " +
                           "INNER JOIN Persona PV ON U.Id_Persona = PV.Id_Persona " +
                           "INNER JOIN Metodo_Pago MP ON VC.Id_MetodoPago = MP.Id_MetodoPago " +
                           "INNER JOIN Tipo_Factura TF ON VC.Id_TipoFactura = TF.Id_TipoFactura";

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Ventas venta = new Ventas
                        {
                            Id_VentaCabecera = Convert.ToInt32(reader["Id_VentaCabecera"]),
                            FechaFactura = Convert.ToDateTime(reader["FechaFactura"]),
                            MontoTotal = Convert.ToSingle(reader["MontoTotal"]),
                            NombreCliente = reader["NombreCliente"].ToString(),
                            ApellidoCliente = reader["ApellidoCliente"].ToString(),
                            DNICliente = reader["DNICliente"].ToString(),
                            NombreVendedor = reader["NombreVendedor"].ToString(),
                            ApellidoVendedor = reader["ApellidoVendedor"].ToString(),
                            TipoPago = reader["TipoPago"].ToString(),
                            TipoFactura = reader["TipoFactura"].ToString(),
                            Estado = reader["Estado"].ToString(),
                        };

                        ventasList.Add(venta);
                    }
                }
            }
            return ventasList;
        }


        public List<Ventas> ObtenerDetallesVenta(int idVentaCabecera)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT VD.Id_Libro, VD.PrecioProducto, VD.Cantidad, VD.SubTotalProducto, " +
                                                      "L.NombreProducto, A.Nombre, E.NombreEditorial " +
                                                      "FROM Venta_Detalle VD " +
                                                      "INNER JOIN Libro L ON VD.Id_Libro = L.Id_Libro " +
                                                      "INNER JOIN Autor A ON L.Id_Autor = A.Id_Autor " +
                                                      "INNER JOIN Editorial E ON L.Id_Editorial = E.Id_Editorial " +
                                                      "WHERE VD.Id_VentaCabecera = @IdVentaCabecera";

                    command.Parameters.AddWithValue("@IdVentaCabecera", idVentaCabecera);

                    List<Ventas> detalles = new List<Ventas>();

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Ventas detalle = new Ventas
                            {
                                PrecioProducto = Convert.ToSingle(reader["PrecioProducto"]),
                                Cantidad = Convert.ToInt32(reader["Cantidad"]),
                                SubTotalProducto = Convert.ToSingle(reader["SubTotalProducto"]),
                                Id_Libro= Convert.ToInt32(reader["Id_Libro"]),
                                Titulo = reader["NombreProducto"].ToString(),
                                NombreAutor = reader["Nombre"].ToString(),
                                NombreEditorial = reader["NombreEditorial"].ToString()
                            };

                            detalles.Add(detalle);
                        }
                    }

                    return detalles;
                }
            }
        }

        public List<Ventas> ObtenerVentasConFiltros(string nombreCliente, string apellidoCliente, string dniCliente)
        {
            List<Ventas> ventasList = new List<Ventas>();
            string query = "SELECT VC.Id_VentaCabecera, VC.FechaFactura, VC.MontoTotal, " +
                           "PC.Nombre AS NombreCliente, PC.Apellido AS ApellidoCliente, PC.DNI AS DNICliente, " +
                           "PV.Nombre AS NombreVendedor, PV.Apellido AS ApellidoVendedor, " +
                           "MP.TipoPago, TF.TipoFactura, VC.Estado " +
                           "FROM Venta_Cabecera VC " +
                           "INNER JOIN Cliente C ON VC.Id_Cliente = C.Id_Cliente " +
                           "INNER JOIN Usuario U ON VC.Id_Usuario = U.Id " +
                           "INNER JOIN Persona PC ON C.Id_Persona = PC.Id_Persona " +
                           "INNER JOIN Persona PV ON U.Id_Persona = PV.Id_Persona " +
                           "INNER JOIN Metodo_Pago MP ON VC.Id_MetodoPago = MP.Id_MetodoPago " +
                           "INNER JOIN Tipo_Factura TF ON VC.Id_TipoFactura = TF.Id_TipoFactura " +
                           "WHERE 1 = 1"; 

            // Agrega los filtros según los parámetros proporcionados
            if (!string.IsNullOrEmpty(nombreCliente))
            {
                query += " AND PC.Nombre LIKE @NombreCliente";
            }

            if (!string.IsNullOrEmpty(apellidoCliente))
            {
                query += " AND PC.Apellido LIKE @ApellidoCliente";
            }

            if (!string.IsNullOrEmpty(dniCliente))
            {
                query += " AND PC.DNI LIKE @DNICliente";
            }

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (!string.IsNullOrEmpty(nombreCliente))
                    {
                        command.Parameters.AddWithValue("@NombreCliente", "%" + nombreCliente + "%");
                    }

                    if (!string.IsNullOrEmpty(apellidoCliente))
                    {
                        command.Parameters.AddWithValue("@ApellidoCliente", "%" + apellidoCliente + "%");
                    }

                    if (!string.IsNullOrEmpty(dniCliente))
                    {
                        command.Parameters.AddWithValue("@DNICliente", "%" + dniCliente + "%");
                    }

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Ventas venta = new Ventas
                        {
                            Id_VentaCabecera = Convert.ToInt32(reader["Id_VentaCabecera"]),
                            FechaFactura = Convert.ToDateTime(reader["FechaFactura"]),
                            MontoTotal = Convert.ToSingle(reader["MontoTotal"]),
                            NombreCliente = reader["NombreCliente"].ToString(),
                            ApellidoCliente = reader["ApellidoCliente"].ToString(),
                            DNICliente = reader["DNICliente"].ToString(),
                            NombreVendedor = reader["NombreVendedor"].ToString(),
                            ApellidoVendedor = reader["ApellidoVendedor"].ToString(),
                            TipoPago = reader["TipoPago"].ToString(),
                            TipoFactura = reader["TipoFactura"].ToString(),
                            Estado = reader["Estado"].ToString(),
                        };

                        ventasList.Add(venta);
                    }
                }
            }

            return ventasList;
        }

        public List<Ventas> ObtenerFechasFiltros(DateTime? fechaDesde, DateTime? fechaHasta)
        {
            List<Ventas> ventasList = new List<Ventas>();
            string query = "SELECT VC.Id_VentaCabecera, VC.FechaFactura, VC.MontoTotal, " +
                           "PC.Nombre AS NombreCliente, PC.Apellido AS ApellidoCliente, PC.DNI AS DNICliente, " +
                           "PV.Nombre AS NombreVendedor, PV.Apellido AS ApellidoVendedor, " +
                           "MP.TipoPago, TF.TipoFactura, VC.Estado " +
                           "FROM Venta_Cabecera VC " +
                           "INNER JOIN Cliente C ON VC.Id_Cliente = C.Id_Cliente " +
                           "INNER JOIN Usuario U ON VC.Id_Usuario = U.Id " +
                           "INNER JOIN Persona PC ON C.Id_Persona = PC.Id_Persona " +
                           "INNER JOIN Persona PV ON U.Id_Persona = PV.Id_Persona " +
                           "INNER JOIN Metodo_Pago MP ON VC.Id_MetodoPago = MP.Id_MetodoPago " +
                           "INNER JOIN Tipo_Factura TF ON VC.Id_TipoFactura = TF.Id_TipoFactura " +
                           "WHERE 1 = 1";

            if (fechaDesde.HasValue)
            {
                query += " AND VC.FechaFactura >= @FechaDesde";
            }

            if (fechaHasta.HasValue)
            {
                query += " AND VC.FechaFactura <= @FechaHasta";
            }

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    if (fechaDesde.HasValue)
                    {
                        command.Parameters.AddWithValue("@FechaDesde", fechaDesde.Value);
                    }

                    if (fechaHasta.HasValue)
                    {
                        command.Parameters.AddWithValue("@FechaHasta", fechaHasta.Value);
                    }

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Ventas venta = new Ventas
                        {
                            Id_VentaCabecera = Convert.ToInt32(reader["Id_VentaCabecera"]),
                            FechaFactura = Convert.ToDateTime(reader["FechaFactura"]),
                            MontoTotal = Convert.ToSingle(reader["MontoTotal"]),
                            NombreCliente = reader["NombreCliente"].ToString(),
                            ApellidoCliente = reader["ApellidoCliente"].ToString(),
                            DNICliente = reader["DNICliente"].ToString(),
                            NombreVendedor = reader["NombreVendedor"].ToString(),
                            ApellidoVendedor = reader["ApellidoVendedor"].ToString(),
                            TipoPago = reader["TipoPago"].ToString(),
                            TipoFactura = reader["TipoFactura"].ToString(),
                            Estado = reader["Estado"].ToString(),
                        };

                        ventasList.Add(venta);
                    }
                }
            }

            return ventasList;
        }

        public DateTime? ObtenerMinFechaFactura()
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();

                string query = "SELECT MIN(FechaFactura) FROM Venta_Cabecera";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        return (DateTime)result;
                    }
                }
            }

            return null;
        }

        public DateTime? ObtenerMaxFechaFactura()
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();

                string query = "SELECT MAX(FechaFactura) FROM Venta_Cabecera";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        return (DateTime)result;
                    }
                }
            }

            return null;
        }

        public bool CambiarEstadoFactura(int idVentaCabecera)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // 1. Cambia el estado de la factura a "inactivo".
                        using (var command = new SqlCommand())
                        {
                            command.Connection = connection;
                            command.Transaction = transaction;
                            command.CommandText = "UPDATE Venta_Cabecera SET Estado = 'inactivo' WHERE Id_VentaCabecera = @Id_VentaCabecera;";
                            command.Parameters.AddWithValue("@Id_VentaCabecera", idVentaCabecera);
                            command.ExecuteNonQuery();
                        }

                        List<Ventas> detalles = ObtenerDetallesVenta(idVentaCabecera);

                        foreach (var detalle in detalles)
                        {
                            using (var detalleCommand = new SqlCommand())
                            {
                                detalleCommand.Connection = connection;
                                detalleCommand.Transaction = transaction;
                                detalleCommand.CommandText = "UPDATE Libro SET Stock = Stock + @Cantidad WHERE Id_Libro = @Id_Libro;";
                                detalleCommand.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
                                detalleCommand.Parameters.AddWithValue("@Id_Libro", detalle.Id_Libro);
                                detalleCommand.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al cambiar el estado de la factura: " + ex.Message);
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }

        public Ventas ObtenerVentaPorIdCabecera(int idCabeceraVenta)
        {
            Ventas venta = null!;
            string query = "SELECT VC.Id_VentaCabecera, VC.FechaFactura, VC.MontoTotal, " +
                           "PC.Nombre AS NombreCliente, PC.Apellido AS ApellidoCliente, PC.DNI AS DNICliente, C.Telefono, C.Domicilio, " +
                           "PV.Nombre AS NombreVendedor, PV.Apellido AS ApellidoVendedor, PV.DNI AS DNIVendedor, " +
                           "MP.TipoPago, TF.TipoFactura, VC.Estado " +
                           "FROM Venta_Cabecera VC " +
                           "INNER JOIN Cliente C ON VC.Id_Cliente = C.Id_Cliente " +
                           "INNER JOIN Usuario U ON VC.Id_Usuario = U.Id " +
                           "INNER JOIN Persona PC ON C.Id_Persona = PC.Id_Persona " +
                           "INNER JOIN Persona PV ON U.Id_Persona = PV.Id_Persona " +
                           "INNER JOIN Metodo_Pago MP ON VC.Id_MetodoPago = MP.Id_MetodoPago " +
                           "INNER JOIN Tipo_Factura TF ON VC.Id_TipoFactura = TF.Id_TipoFactura " +
                           "WHERE VC.Id_VentaCabecera = @IdCabeceraVenta";

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdCabeceraVenta", idCabeceraVenta);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        venta = new Ventas
                        {
                            Id_VentaCabecera = Convert.ToInt32(reader["Id_VentaCabecera"]),
                            FechaFactura = Convert.ToDateTime(reader["FechaFactura"]),
                            MontoTotal = Convert.ToSingle(reader["MontoTotal"]),
                            NombreCliente = reader["NombreCliente"].ToString(),
                            ApellidoCliente = reader["ApellidoCliente"].ToString(),
                            DNICliente = reader["DNICliente"].ToString(),
                            Telefono = reader["Telefono"].ToString(),
                            Domicilio = reader["Domicilio"].ToString(),
                            NombreVendedor = reader["NombreVendedor"].ToString(),
                            ApellidoVendedor = reader["ApellidoVendedor"].ToString(),
                            DNIVendedor = reader["DNIVendedor"].ToString(),
                            TipoPago = reader["TipoPago"].ToString(),
                            TipoFactura = reader["TipoFactura"].ToString(),
                            Estado = reader["Estado"].ToString(),
                        };
                    }
                }
            }
            return venta!;
        }
    }
}
