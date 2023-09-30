using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using System.Windows.Forms;

namespace Proyecto_MauroMur.Presentacion.Formularios.Lobi.SeccionGerente
{
    public partial class CEstadistica : Form
    {
        public CEstadistica()
        {
            InitializeComponent();
        }


        private void EndResponsive()
        {
            if (this.Width < 994)
            {
                tableLayoutPanel2.ColumnStyles[1].Width = 350;

            }
            else if (this.Width < 1010)
            {
                tableLayoutPanel2.ColumnStyles[1].Width = tableLayoutPanel2.Width - (chart1.Width + chart1.Margin.Right);
                chart1.Width = 328;
                chart2.Width = 328;
            }
            else
            {
                tableLayoutPanel2.ColumnStyles[1].Width = tableLayoutPanel2.Width - (chart1.Width + chart2.Width + chart1.Margin.Right + chart2.Margin.Right);
            }

            if (this.Height <= 736)
            {
                panel8.Height = 342;
            }

        }

        private void CEstadistica_Load(object sender, EventArgs e)
        {
            EndResponsive();
        }
    }
}
