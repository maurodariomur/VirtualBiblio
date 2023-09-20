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
        public static int? contador { get; private set; }
        public static List<Tuple<Libro, int>> LibrosEnCarrito { get; } = new List<Tuple<Libro, int>>();

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
                var cantidad = libroEnCarrito.Item2 + 1;
                LibrosEnCarrito[index] = Tuple.Create(libro, cantidad);
            }
            else
            {
                LibrosEnCarrito.Add(Tuple.Create(libro, 1));
            }

            contador++;
        }

        public static void EliminarLibro(int idLibro)
        {
            Tuple<Libro, int> libroEnCarrito = LibrosEnCarrito.FirstOrDefault(l => l.Item1.Id_Libro == idLibro);

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
    }
}

