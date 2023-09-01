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

        private void CTablas_Load(object sender, EventArgs e)
        {
            List<Usuarios> usuarios = userModel.MostrarUsers();
            dataGridUsuarios.DataSource = usuarios;
        }
    }
}
