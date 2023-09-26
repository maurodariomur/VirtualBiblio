using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_MauroMur.Common.Cache
{
    public static class Carrito
    {
        public static int? contador { get; set; }
        public static List<Tuple<Libro, int>> LibrosEnCarrito { get; } = new List<Tuple<Libro, int>>();
        public static List<Libro> TodosLosLibrosEnCarrito { get; set; } = new List<Libro>();
        static Carrito()
        {
            contador = 0;
        }

        public static void AgregarLibro(Libro libro)
        {
            Tuple<Libro, int>? libroEnCarrito = LibrosEnCarrito.FirstOrDefault(l => l.Item1.Id_Libro == libro.Id_Libro);

            if (libroEnCarrito != null)
            {
                var index = LibrosEnCarrito.IndexOf(libroEnCarrito);
                var cantidadEnCarrito = libroEnCarrito.Item2;

                // Verifica si la cantidad en el carrito es menor que el stock disponible
                if (cantidadEnCarrito < libro.Stock)
                {
                    var cantidad = cantidadEnCarrito + 1;
                    LibrosEnCarrito[index] = Tuple.Create(libro, cantidad);
                    contador++;
                }
            }
            else
            {
                // Verifica si el stock disponible es mayor que 0 antes de agregar el libro.
                if (libro.Stock > 0)
                {
                    LibrosEnCarrito.Add(Tuple.Create(libro, 1));
                    contador++;
                }
            }
        }

        public static void EliminarLibro(int idLibro)
        {
            Tuple<Libro, int>? libroEnCarrito = LibrosEnCarrito.FirstOrDefault(l => l.Item1.Id_Libro == idLibro);

            if (libroEnCarrito != null)
            {
                var index = LibrosEnCarrito.IndexOf(libroEnCarrito);
                var cantidad = libroEnCarrito.Item2 - 1;

                if (cantidad > 0)
                {
                    LibrosEnCarrito[index] = Tuple.Create(libroEnCarrito.Item1, cantidad);
                }
                else
                {
                    LibrosEnCarrito.Remove(libroEnCarrito);
                }

                contador--;
            }
        }

        public static void VaciarCarrito()
        {
            LibrosEnCarrito.Clear();
            contador = 0;
        }

        public static void EliminarOneLibro(int idLibro)
        {
            Tuple<Libro, int>? libroEnCarrito = LibrosEnCarrito.FirstOrDefault(l => l.Item1.Id_Libro == idLibro);

            if (libroEnCarrito != null)
            {
                LibrosEnCarrito.Remove(libroEnCarrito);
                contador -= libroEnCarrito.Item2;
            }
        }

        public static double ObtenerTotal()
        {
            double total = 0;

            foreach (var libroEnCarrito in LibrosEnCarrito)
            {
                    double precioLibro = libroEnCarrito.Item1.Precio;
                    int cantidad = libroEnCarrito.Item2;

                    total +=precioLibro * cantidad;
            }

            return total;
        }
    }
}

