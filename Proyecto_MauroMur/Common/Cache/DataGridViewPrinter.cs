using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_MauroMur.Common.Cache
{
    public class DataGridViewPrinter
    {
        private DataGridView dataGridView;
        private Font cellFont;
        private Brush cellBrush;
        private Pen cellBorderPen;
        private Font headerFont;
        private Brush headerBrush;
        private Pen headerBorderPen;
        private Dictionary<string, string> columnHeaders;

        public DataGridViewPrinter(
            DataGridView dataGridView,
            Font cellFont,
            Brush cellBrush,
            Pen cellBorderPen,
            Font headerFont,
            Brush headerBrush,
            Pen headerBorderPen,
            Dictionary<string, string> columnHeaders)
        {
            this.dataGridView = dataGridView;
            this.cellFont = cellFont;
            this.cellBrush = cellBrush;
            this.cellBorderPen = cellBorderPen;
            this.headerFont = headerFont;
            this.headerBrush = headerBrush;
            this.headerBorderPen = headerBorderPen;
            this.columnHeaders = columnHeaders;
        }

        public void DrawDataGridView(Graphics graphics, Point location)
        {
            int x = location.X;
            int y = location.Y;

            foreach (var columnHeader in columnHeaders.Values)
            {
                SizeF headerSize = graphics.MeasureString(columnHeader, headerFont);
                RectangleF headerRect = new RectangleF(x, y, headerSize.Width, headerSize.Height);

                // Dibuja el encabezado de columna
                graphics.DrawString(columnHeader, headerFont, headerBrush, headerRect);
                graphics.DrawRectangle(headerBorderPen, headerRect.X, headerRect.Y, headerRect.Width, headerRect.Height);

                x += (int)headerSize.Width;
            }

            y += (int)headerFont.Height;

            for (int rowIndex = 0; rowIndex < dataGridView.Rows.Count; rowIndex++)
            {
                x = location.X;

                foreach (var columnName in columnHeaders.Keys)
                {
                    if (dataGridView.Columns.Contains(columnName) && dataGridView.Columns[columnName].Visible)
                    {
                        object cellValue = dataGridView.Rows[rowIndex].Cells[columnName].Value;
                        if (cellValue != null)
                        {
                            string cellText = cellValue.ToString();
                            SizeF cellSize = graphics.MeasureString(cellText, cellFont);
                            RectangleF cellRect = new RectangleF(x, y, cellSize.Width, cellSize.Height);

                            // Dibuja la celda
                            graphics.DrawString(cellText, cellFont, cellBrush, cellRect);
                            graphics.DrawRectangle(cellBorderPen, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);

                            x += (int)cellSize.Width;
                        }
                    }
                }

                y += dataGridView.Rows[rowIndex].Height;
            }
        }
    }
}
