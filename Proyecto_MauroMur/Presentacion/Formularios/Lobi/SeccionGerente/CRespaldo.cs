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
                if (!string.IsNullOrEmpty(selectedFolderPath) && !string.IsNullOrEmpty(textBoxRuta.Text))
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

        private void iconImportar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Archivos de respaldo (*.bak)|*.bak";
                    openFileDialog.Title = "Selecciona el archivo de respaldo";
                    openFileDialog.InitialDirectory = selectedFolderPath; // Establece la carpeta inicial

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string rutaArchivoRespaldo = openFileDialog.FileName;
                        bool restauracionExitosa = backupModel.RealizarRestauracion(rutaArchivoRespaldo);

                        if (restauracionExitosa)
                        {
                            MessageBox.Show("Restauración de la base de datos exitosa.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("Error al restaurar la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al restaurar la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarCampos();
            }
        }

    }

}
