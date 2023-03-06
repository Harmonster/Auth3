using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auth3
{
    class DataGridViewImageButtons
    {
        public class DataGridViewDeleteCell : DataGridViewButtonCell
        {
            Image delete = Properties.Resources.delete;
            protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates elementState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
            {
                base.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);
                graphics.DrawImage(delete, cellBounds);
            }
        }
        public class DataGridViewDeleteColumn : DataGridViewButtonColumn
        {
            public DataGridViewDeleteColumn()
            {
                this.CellTemplate = new DataGridViewDeleteCell();
                this.Width = 20;
            }
        }

        public class DataGridViewEditCell : DataGridViewButtonCell
        {
            Image edit = Properties.Resources.edit;
            protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates elementState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
            {
                base.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);
                graphics.DrawImage(edit, cellBounds);
            }
        }

        public class DataGridViewEditColumn : DataGridViewButtonColumn
        {
            public DataGridViewEditColumn()
            {
                this.CellTemplate = new DataGridViewEditCell();
                this.Width = 20;
            }
        }

        public class DataGridViewAddCell : DataGridViewButtonCell
        {
            Image add = Properties.Resources.add;
            protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates elementState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
            {
                base.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);
                graphics.DrawImage(add, cellBounds);
            }
        }

        public class DataGridViewAddColumn : DataGridViewButtonColumn
        {
            public DataGridViewAddColumn()
            {
                this.CellTemplate = new DataGridViewAddCell();
                this.Width = 20;
            }
        }
    }
}
