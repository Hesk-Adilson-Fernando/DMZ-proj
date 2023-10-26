using System;
using System.Data;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Generic;

namespace DMZ.UI.UI
{
    public partial class FrmRltsql : FrmClasse2
    {
        public FrmRltsql()
        {
            InitializeComponent();
        }

        private DataTable Tabela = new DataTable();
        private void FrmRltsql_Load(object sender, EventArgs e)
        {
            gridDeb.Condicao = "";
            gridDeb.BindGridView();
            Tabela = gridDeb.DtDS;
        }

        private void gridDeb_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            var nome = gridDeb.CurrentCell.OwningColumn.Name;
            if (nome.Equals("Querry"))
            {
                var f = new FrmEditRlt { SendInfo = Receive, tbQuerry = { Text = gridDeb.CurrentCell.Value.ToString() } };
                f.ShowForm(this, true);
            }
        }

        void Receive(string str)
        {
            var nome = gridDeb.CurrentCell.OwningColumn.Name;
            if (nome.Equals("Querry"))
            {
                gridDeb.CurrentCell.Value = str;
            }
            if (nome.Equals("sel"))
            {
                gridDeb.CurrentRow.Cells["Xmlstring"].Value = str;
            }
            gridDeb.Update();
        }

        private void tbProcura_TextChanged(object sender, EventArgs e)
        {
            Helper.UpdateGrid(false, gridDeb, Tabela, tbProcura.Text,"descricao");
        }

        private void gridDeb_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (!gridDeb.CurrentCell.OwningColumn.Name.Equals("sel")) return;
            if (gridDeb.CurrentRow == null) return;
            var valor = gridDeb.CurrentRow.Cells["Xmlstring"].Value;
            var f = new FrmEditRlt { SendInfo = Receive, tbQuerry = { Text = valor==null?"": valor.ToString() } };
            f.ShowForm(this, true);
        }
    }
}
