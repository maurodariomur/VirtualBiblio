using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionVendedor
{
    public class BtnDataGrid : DataGridViewButtonColumn
    {
        public BtnDataGrid()
        {
            this.HeaderText = " ";
            this.UseColumnTextForButtonValue = true; // Para mostrar el texto en lugar de un botón


            DataGridViewCellStyle buttonStyle = new DataGridViewCellStyle();
            buttonStyle.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            buttonStyle.BackColor = Color.Red; // Cambia el color de fondo aquí
            buttonStyle.ForeColor = Color.Blue;
            this.DefaultCellStyle = buttonStyle;
        }

    }

}
