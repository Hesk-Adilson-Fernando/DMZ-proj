using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMZ.UI.Classes
{
    public class GridDecorator
    {
        public static void MergeRows(DataGridView gridView)
        {
            for (int rowIndex = gridView.Rows.Count - 2; rowIndex >= 0; rowIndex--)
            {
                var row = gridView.Rows[rowIndex];
                var previousRow = gridView.Rows[rowIndex + 1];

                //for (int i = 0; i < row.Cells.Count; i++)
                //{
                //    if (row.Cells[i].Value.ToString().Trim() == previousRow.Cells[i].Value.ToString().Trim())
                //    {
                //        row.Cells[i]. = previousRow.Cells[i].RowSpan < 2 ? 2 : 
                //            previousRow.Cells[i].RowSpan + 1;
                //        previousRow.Cells[i].Value.Visible = false;
                //    }
                //}
            }
        }
    }
}
