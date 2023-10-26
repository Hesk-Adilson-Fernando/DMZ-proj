using System;
using System.Drawing;
using System.Windows.Forms;
using DMZ.BL.Classes;

namespace DMZ.UI.Generic
{
    public class DataGridViewDatetimePrickerColumn: DataGridViewTextBoxColumn
    {
        public bool IsDateTime { get; set; }
        //public override DataGridViewCellStyle DefaultCellStyle { get; set ;}

        public DataGridViewDatetimePrickerColumn()
        {

        }

    }

}
