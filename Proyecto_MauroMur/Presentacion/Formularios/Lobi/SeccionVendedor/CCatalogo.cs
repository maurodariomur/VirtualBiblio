﻿using Proyecto_MauroMur.Domain;
using Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_MauroMur.Common.Cache;
using Proyecto_MauroMur.Common.Models;

namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionVendedor
{
    public partial class CCatalogo : Form
    {
        private ProductModel productModel = new ProductModel();
        public List<BotonesLibros> listaDeBotones = new List<BotonesLibros>();
        private List<BotonesLibros>? listaBotonesResguardo;
        private List<BotonesLibros>? todosLosLibros;
        private FLobi flobi;
        private int contador;
        CDetalleCatalogo cDetalleCatalogo;

        public CCatalogo(FLobi flobi)
        {
            InitializeComponent();
            LlenarProductos();
            this.flobi = flobi;
            cDetalleCatalogo = new CDetalleCatalogo(this,flobi);

            contador = 0;

            if (Carrito.contador != null)
            {
                contador = (int)Carrito.contador;
                lbContador.Text = Carrito.contador.ToString();
            }

            foreach (BotonesLibros btn in listaDeBotones)
            {
                btn.añadirEvento += añadirEvento!;
            }
        }

        private void añadirEvento(object sender, EventArgs e)
        {
            BotonesLibros btn = (BotonesLibros)sender;
            Libro libro = productModel.ObtenerLibroId(btn.idLibro);

            Carrito.AgregarLibro(libro);

            lbContador.Text = Carrito.contador.ToString();
        }

        private void LlenarProductos()
        {
            productModel.LlenarCatalogo(flowLayoutPanel, this);
            listaBotonesResguardo = listaDeBotones;
            todosLosLibros = listaBotonesResguardo.ToList();
        }

        private void CCatalogo_Load(object sender, EventArgs e)
        {
            opcionesAutores();
            opcionesCategorias();
            opcionesEditoriales();
        }

        public void LoadLabelContador()
        {
            lbContador.Text = Carrito.contador.ToString();
        }

        private void BusquedaProductos()
        {
            string textoBusquedaTitulo = txCatalogoTitulo.Text.ToLower();
            if (string.IsNullOrEmpty(textoBusquedaTitulo))
            {
                foreach (var libro in listaBotonesResguardo!)
                {
                    flowLayoutPanel.Controls.Add(libro); 
                }
                return;
            }
            var librosFiltrados = flowLayoutPanel.Controls.OfType<BotonesLibros>()
                .Where(libro => string.IsNullOrEmpty(textoBusquedaTitulo) || libro.tituloLibro.ToLower().Contains(textoBusquedaTitulo))
                .ToList();

            flowLayoutPanel.Controls.Clear(); 

            foreach (var libro in librosFiltrados)
            {
                flowLayoutPanel.Controls.Add(libro); 
            }
        }

        private void FiltrarProductos()
        {
            string textoBusqueda = cBCatalogoAutor.Text;
            string textoBusquedaCategoria = cBCatalogoCategoria.Text;
            string textoBusquedaEditorial = cBCatalogoEditorial.Text;

            if (textoBusqueda.Equals("Autor", StringComparison.OrdinalIgnoreCase))
            {
                MostrarTodosLosLibros();
            }
            else
            {
                var librosFiltrados = todosLosLibros!
                    .Where(libro => libro.Autor.Equals(textoBusqueda, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                flowLayoutPanel.Controls.Clear();

                foreach (var libro in librosFiltrados)
                {
                    flowLayoutPanel.Controls.Add(libro);
                }
            }
        }

        private void FiltrarProductosEditorial()
        {
            string textoBusquedaEditorial = cBCatalogoEditorial.Text;

            if (textoBusquedaEditorial.Equals("Editoriales", StringComparison.OrdinalIgnoreCase))
            {
                MostrarTodosLosLibros();
            }
            else
            {
                var librosFiltrados = todosLosLibros!
                    .Where(libro => libro.Editoriales.Equals(textoBusquedaEditorial, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                flowLayoutPanel.Controls.Clear(); 

                foreach (var libro in librosFiltrados)
                {
                    flowLayoutPanel.Controls.Add(libro);
                }
            }
        }
        private void FiltrarProductosCategoria()
        {
            string textoBusquedaCategoria = cBCatalogoCategoria.Text;

            if (textoBusquedaCategoria.Equals("Categorias", StringComparison.OrdinalIgnoreCase))
            {
                MostrarTodosLosLibros();
            }
            else
            {
                var librosFiltrados = todosLosLibros!
                    .Where(libro => libro.Categorias.Equals(textoBusquedaCategoria, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                flowLayoutPanel.Controls.Clear(); 

                foreach (var libro in librosFiltrados)
                {
                    flowLayoutPanel.Controls.Add(libro); 
                }
            }
        }

        private void MostrarTodosLosLibros()
        {
            flowLayoutPanel.Controls.Clear(); 

            foreach (var libro in todosLosLibros!)
            {
                flowLayoutPanel.Controls.Add(libro); 
            }
        }

        private void opcionesCategorias()
        {
            ProductModel productModel = new();
            var categorias = productModel.ObtenerCategorias();

            categorias.Insert(0, "Categorias");

            cBCatalogoCategoria.DataSource = categorias;
            cBCatalogoCategoria.SelectedIndex = 0;
        }

        private void opcionesAutores()
        {
            var autores = productModel.ObtenerListaAutores();

            autores.Insert(0, "Autor");
            cBCatalogoAutor.DataSource = autores;

            cBCatalogoAutor.SelectedIndex = 0;
        }

        private void opcionesEditoriales()
        {
            var editoriales = productModel.ObtenerListaEditoriales();

            editoriales.Insert(0, "Editoriales");

            cBCatalogoEditorial.DataSource = editoriales;
            cBCatalogoEditorial.SelectedIndex = 0;
        }

        private void txCatalogoTitulo_TextChanged(object sender, EventArgs e)
        {
            BusquedaProductos();
        }

        private void cBCatalogoAutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarProductos();
        }

        private void cBCatalogoEditorial_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarProductosEditorial();
        }

        private void cBCatalogoCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarProductosCategoria();
        }

        private void iconCatalogo_Click(object sender, EventArgs e)
        {
            cDetalleCatalogo.ShowDialog();
        }
    }
}
