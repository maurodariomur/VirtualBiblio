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

        private void CTablas_Load(object sender, EventArgs e)
        {
            List<Usuarios> usuarios = userModel.MostrarUsers();
            dataGridUsuarios.DataSource = usuarios;
            dataGridUsuarios.Columns["TipoPerfil"].Visible = false;
            opcionesPerfiles();
        }

        public void loadUsers()
        {
            List<Usuarios> usuarios = userModel.MostrarUsers();
            if (checkBoxAZ.Checked)
            {
                usuarios.Sort((x, y) => string.Compare(x.Apellido, y.Apellido));
            }
            dataGridUsuarios.DataSource = usuarios;
        }

        private void dataGridUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si el clic ocurrió en una fila válida (no en la cabecera)
            if (e.RowIndex >= 0)
            {
                DialogResult consulta = MessageBox.Show("¿Desea Editar los datos Del Empleado?", "Editar Datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (consulta == DialogResult.OK)
                {
                    // Obtener la fila seleccionada
                    DataGridViewRow selectedRow = dataGridUsuarios.Rows[e.RowIndex];

                    // Obtener los datos necesarios de la fila (suponiendo que la columna 0 contiene el ID)
                    int selectedId = Convert.ToInt32(selectedRow.Cells[0].Value);

                    // Crear y mostrar el formulario de edición
                    FormEdit editForm = new FormEdit(this, selectedId);
                    editForm.ShowDialog();
                }
            }
        }

        private void opcionesPerfiles()
        {
            UserModel userModel = new();
            var roles = userModel.ObtenerPerfiles();

            // Agrega el mensaje predeterminado al comienzo de la lista
            roles.Insert(0, "Seleccione Perfil");

            // Asigna la lista de categorías como DataSource del ComboBox
            cBBuscadorPerfil.DataSource = roles;

            // Establece el índice seleccionado por defecto en 0 para mostrar el mensaje predeterminado
            cBBuscadorPerfil.SelectedIndex = 0;
        }

        private void FiltrarUsuarios()
        {
            string textoBusquedaNombre = txBuscadorNombre.Text.ToLower();
            string textoBusquedaApellido = txBuscadorApellido.Text.ToLower();
            string textoBusquedaDNI = txBuscadorDni.Text.ToLower();
            string? perfilSeleccionado = cBBuscadorPerfil.SelectedItem as string;
            int tipoPerfilId = 0;

            tipoPerfilId = userModel.ObtenerIdTipoPerfil(perfilSeleccionado);
            
            List<Usuarios> usuariosFiltrados = userModel.MostrarUsers()
                .Where(usuario =>
                    (string.IsNullOrEmpty(textoBusquedaNombre) || usuario?.Nombre?.ToLower()?.Contains(textoBusquedaNombre) == true) &&
                    (string.IsNullOrEmpty(textoBusquedaApellido) || usuario?.Apellido?.ToLower()?.Contains(textoBusquedaApellido) == true) &&
                    (string.IsNullOrEmpty(textoBusquedaDNI) || usuario?.DNI?.ToLower()?.Contains(textoBusquedaDNI) == true) &&
                   (tipoPerfilId == 0 || (usuario?.TipoPerfil == tipoPerfilId)))
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

        private void checkBoxAZ_CheckedChanged(object sender, EventArgs e)
        {
            loadUsers();
        }

        private void txBuscadorNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txBuscadorApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txBuscadorDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
