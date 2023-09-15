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
using Proyecto_MauroMur.Common.Models;

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
            List<UsuarioConInformacion> usuarios = userModel.MostrarUsers();
            dataGridUsuarios.DataSource = usuarios;

            // Configura los nombres de las columnas personalizados
            dataGridUsuarios.Columns["Id"].HeaderText = "ID";
            dataGridUsuarios.Columns["UserNombre"].HeaderText = "Usuario";
            dataGridUsuarios.Columns["PerfilNombre"].HeaderText = "Perfil";
            dataGridUsuarios.Columns["PersonaNombre"].HeaderText = "Nombre";
            dataGridUsuarios.Columns["PersonaApellido"].HeaderText = "Apellido";
            dataGridUsuarios.Columns["PersonaDNI"].HeaderText = "Documento";
            dataGridUsuarios.Columns["PersonaMail"].HeaderText = "Correo Electronico";
            dataGridUsuarios.Columns["PersonaFechaNacimiento"].HeaderText = "Fecha de Nacimiento";
            dataGridUsuarios.Columns["PersonaBaja"].HeaderText = "Baja"; // Si tienes la columna PersonaBaja

            // Otras configuraciones que puedas necesitar
            dataGridUsuarios.Columns["TipoPerfil"].Visible = false;
            dataGridUsuarios.Columns["Id_Persona"].Visible = false;
            opcionesPerfiles();
            dataGridUsuarios.RowPrePaint += DataGridUsuarios_RowPrePaint!;
        }


        private void DataGridUsuarios_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            // Obtén la fila actual
            DataGridViewRow row = dataGridUsuarios.Rows[e.RowIndex];

            // Verifica el valor de la columna "Baja" (asegúrate de que el nombre de la columna sea correcto)
            string? valorBaja = row.Cells["PersonaBaja"].Value.ToString();

            // Define el color de fondo deseado para las filas con "Baja" en "SI"
            if (valorBaja == "SI")
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 140, 140);
                row.DefaultCellStyle.ForeColor = Color.Black; // Opcional: establecer el color de texto en blanco para mayor visibilidad
            }
            else
            {
                // Restablece el color de fondo y texto para las demás filas (opcional)
                row.DefaultCellStyle.BackColor = SystemColors.Window;
                row.DefaultCellStyle.ForeColor = SystemColors.ControlText;
            }
        }

        public void loadUsers()
        {
            List<UsuarioConInformacion> usuarios = userModel.MostrarUsers();
            UsuarioConInformacion usuarioConPersona = new();
            if (checkBoxAZ.Checked)
            {
                usuarios.Sort((x, y) => string.Compare(x.PersonaApellido, y.PersonaApellido));
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

            List<UsuarioConInformacion> usuariosFiltrados = userModel.MostrarUsers()
                .Where(usuario =>
                    (string.IsNullOrEmpty(textoBusquedaNombre) || usuario?.PersonaNombre?.ToLower()?.Contains(textoBusquedaNombre) == true) &&
                    (string.IsNullOrEmpty(textoBusquedaApellido) || usuario?.PersonaApellido?.ToLower()?.Contains(textoBusquedaApellido) == true) &&
                    (string.IsNullOrEmpty(textoBusquedaDNI) || usuario?.PersonaDNI?.ToLower()?.Contains(textoBusquedaDNI) == true) &&
                    (perfilSeleccionado == "Seleccione Perfil" || usuario?.PerfilNombre == perfilSeleccionado))
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
