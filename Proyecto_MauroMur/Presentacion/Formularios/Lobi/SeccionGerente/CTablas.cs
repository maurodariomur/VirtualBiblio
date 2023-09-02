using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Common.Models;
using System.Drawing.Drawing2D;
using Microsoft.VisualBasic.Logging;

namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionGerente
{
    public partial class CTablas : Form
    {
        private UserModel userModel = new UserModel();

        public CTablas()
        {
            InitializeComponent();
        }

        private void dataGridUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult consulta = MessageBox.Show("¿Desea Editar los datos Del Empleado?", "Editar Datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (consulta == DialogResult.OK)
            {
                if (e.RowIndex >= 0) // Asegurarse de que el clic ocurrió en una fila válida
                {
                    // Obtener la fila seleccionada
                    DataGridViewRow selectedRow = dataGridUsuarios.Rows[e.RowIndex];

                    // Obtener los datos necesarios de la fila (suponiendo que la columna 0 contiene el ID)
                    int selectedId = Convert.ToInt32(selectedRow.Cells[0].Value);

                    // Crear y mostrar el formulario de edición
                    FormEdit editForm = new FormEdit(selectedId);
                    editForm.ShowDialog();
                }
            }
        }

        private void CTablas_Load(object sender, EventArgs e)
        {
            List<Usuarios> usuarios = userModel.MostrarUsers();
            dataGridUsuarios.DataSource = usuarios;
        }

        private void FiltrarUsuarios()
        {

            string textoBusquedaNombre = txBuscadorNombre.Text.ToLower();
            string textoBusquedaApellido = txBuscadorApellido.Text.ToLower();
            string textoBusquedaDNI = txBuscadorDni.Text.ToLower();
            string? perfilSeleccionado = cBBuscadorPerfil.SelectedItem as string;
            int tipoPerfilId = -1;

            if (!string.IsNullOrEmpty(perfilSeleccionado))
            {
                tipoPerfilId = userModel.ObtenerIdTipoPerfil(perfilSeleccionado);
            }


            List<Usuarios> usuariosFiltrados = userModel.MostrarUsers()
                .Where(usuario =>
                    (string.IsNullOrEmpty(textoBusquedaNombre) || usuario?.Nombre?.ToLower()?.Contains(textoBusquedaNombre) == true) ||
                    (string.IsNullOrEmpty(textoBusquedaApellido) || usuario?.Apellido?.ToLower()?.Contains(textoBusquedaApellido) == true) ||
                    (string.IsNullOrEmpty(textoBusquedaDNI) || usuario?.DNI?.ToLower()?.Contains(textoBusquedaDNI) == true) ||
                    (usuario?.TipoPerfil == tipoPerfilId && tipoPerfilId != -1))
                .ToList();

            dataGridUsuarios.DataSource = usuariosFiltrados;
        }


        private void txBuscadorNombre_TextChanged(object sender, EventArgs e)
        {
            FiltrarUsuarios();
        }

        private void txBuscadorApellido_TextChanged(object sender, EventArgs e)
        {
            FiltrarUsuarios();
        }

        private void txBuscadorDni_TextChanged(object sender, EventArgs e)
        {
            FiltrarUsuarios();
        }

        private void cBBuscadorPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarUsuarios();
        }

        private void txBuscadorNombre_Enter(object sender, EventArgs e)
        {
            if (txBuscadorNombre.Text == "Nombre")
            {
                txBuscadorNombre.Text = null;
            }
        }

        private void txBuscadorNombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txBuscadorNombre.Text))
            {
                txBuscadorNombre.Text = "Nombre";
            }
        }

        private void txBuscadorApellido_Enter(object sender, EventArgs e)
        {
            if (txBuscadorApellido.Text == "Apellido")
            {
                txBuscadorApellido.Text = null;
            }
        }

        private void txBuscadorApellido_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txBuscadorApellido.Text))
            {
                txBuscadorApellido.Text = "Apellido";
            }
        }

        private void txBuscadorDni_Enter(object sender, EventArgs e)
        {
            if (txBuscadorDni.Text == "DNI")
            {
                txBuscadorDni.Text = null;
            }
        }

        private void txBuscadorDni_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txBuscadorDni.Text))
            {
                txBuscadorDni.Text = "DNI";
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Color colorInicio = Color.FromArgb(147, 177, 166); // Rojo más claro
            Color colorFin = Color.FromArgb(221, 230, 237);     // Azul

            // Ajusta la posición de inicio y fin del degradado verticalmente.
            int yInicio = 0; // Cambia esto para ajustar la posición de inicio del rojo
            int yFin = panel1.Height; // La posición de fin es la parte inferior del Panel

            // Crea un objeto LinearGradientBrush para el degradado.
            LinearGradientBrush gradientBrush = new LinearGradientBrush(
                new Point(0, yInicio), new Point(0, yFin), colorInicio, colorFin);

            // Dibuja el degradado en el Panel.
            e.Graphics.FillRectangle(gradientBrush, panel1.ClientRectangle);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBoxAZ_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
