using System;
using System.Windows.Forms;
using DMZ.UI.Basic;
using DMZ.UI.Generic;

namespace DMZ.UI.UI
{
    public partial class FrmRdlcxml : FrmClasse2
    {
        public FrmRdlcxml()
        {
            InitializeComponent();
        }

        private void FrmRdlcxml_Load(object sender, EventArgs e)
        {
            gridDeb.Condicao = "";
            gridDeb.BindGridView();
        }
        void Receive(string str)
        {
            if (gridDeb.CurrentRow != null) 
                gridDeb.CurrentRow.Cells["Xmlstring"].Value = str;
        }
        void Receive2(string str)
        {
            if (gridDeb.CurrentRow != null)
                gridDeb.CurrentRow.Cells["Querry"].Value = str;
        }
        private void gridDeb_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!gridDeb.CurrentCell.OwningColumn.Name.Equals("Querry")) return;
            if (gridDeb.CurrentRow == null) return;
            var f = new FrmEditRlt { SendInfo = Receive2, tbQuerry = { Text = gridDeb.CurrentRow.Cells["Querry"].Value.ToString() } };
            f.ShowForm(this, true);
        }

        private void gridDeb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!gridDeb.CurrentCell.OwningColumn.Name.Equals("sel")) return;
            var valor = gridDeb.CurrentRow.Cells["Xmlstring"].Value;
            var f = new FrmEditRlt { SendInfo = Receive, tbQuerry = { Text = valor == null ? "" : valor.ToString() } };
            f.ShowForm(this, true);
        }
    }
}
