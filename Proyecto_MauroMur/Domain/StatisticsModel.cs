using Proyecto_MauroMur.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_MauroMur.Common.Models;

namespace Domain
{
    internal class StatisticsModel
    {
        private StatisticsDatos statisticsDatos = new();

        public int ObtenerLibroMayorVendido()
        {
            int idLibroVendido = statisticsDatos.ObtenerLibroMasVendido();
            return idLibroVendido;
        }

        public int ObtenerLibroMenorVendido()
        {
            int idLibroVendido = statisticsDatos.ObtenerLibroMenosVendido();
            return idLibroVendido;
        }

        public float ObtenerTotalVendido()
        {
            return statisticsDatos.ObtenerTotalVentas();
        }

        public int ObtenerEmpleadoMayoresVenta()
        {
            int idMejorEmpleado = statisticsDatos.ObtenerVendedorMasExitoso();
            return idMejorEmpleado;
        }

        public List<Ventas> MostrarCantidadLibros(DateTime startDate, DateTime endDate)
        {
            int cantidad = 5;
            return statisticsDatos.ObtenerLibrosMasVendidos(cantidad, startDate, endDate);
        }

        public List<Tuple<string, float>> EmpleadosDestacados(DateTime startDate, DateTime endDate)
        {
            return statisticsDatos.ObtenerTresUsuariosMasExitosos(startDate,endDate);
        }


        public List<Tuple<string, float>> ClientesDestacados(DateTime startDate, DateTime endDate)
        {
            return statisticsDatos.MejoresClientes(startDate, endDate);
        }

        public List<Tuple<DateTime, float>> ObtenerCincoMayoresVentas(DateTime startDate, DateTime endDate)
        {
            return statisticsDatos.ObtenerCincoMayoresVentas(startDate, endDate);
        }
    }
}
