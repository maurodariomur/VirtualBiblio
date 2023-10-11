using Proyecto_MauroMur.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionGerente
{
    public partial class CRespaldo : Form
    {
        private FLobi instanciaFLobi;
        private string selectedFolderPath = "";
        private DatabaseBackupManagerModel backupModel = new DatabaseBackupManagerModel();

        public CRespaldo(FLobi flobi)
        {
            InitializeComponent();
            this.instanciaFLobi = flobi;
        }

        private void CRespaldo_Load(object sender, EventArgs e)
        {
        }

        private void iconSeleccionar_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Selecciona la carpeta para guardar la copia de seguridad";
                folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;

                // Establecer la ruta predeterminada en C:\
                folderBrowserDialog.SelectedPath = "C:\\";

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedFolderPath = folderBrowserDialog.SelectedPath;
                    textBoxRuta.Text = selectedFolderPath;
                }
            }
        }

        private void iconBackup_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(selectedFolderPath))
                {
                    bool backupSuccessful = backupModel.RealizarBackUp(selectedFolderPath);

                    if (backupSuccessful)
                    {
                        MessageBox.Show("Copia de seguridad realizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Error al realizar la copia de seguridad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    msgError("Selecciona una carpeta antes de realizar la copia de seguridad.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la copia de seguridad: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarCampos();
            }
        }

        private void msgError(string msg)
        {
            lbErrorModificar.Text = "     " + msg;
            lbErrorModificar.Visible = true;
        }

        private void LimpiarCampos()
        {
            textBoxRuta.Text = "";
            lbErrorModificar.Text = "";
        }

    }

}
