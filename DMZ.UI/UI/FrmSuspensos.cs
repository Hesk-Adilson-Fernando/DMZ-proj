using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DMZ.Model.Model;
using DMZ.UI.Basic;

namespace DMZ.UI.UI
{
    public partial class FrmSuspensos : FrmClasse2
    {
        public Action<Fact,List<Factl>> SendData;
        public FrmSuspensos()
        {
            InitializeComponent();
        }

        public List<Fact> Lista { get; set; }
        public List<Factl> Listal { get; set; }

        private void FrmSuspensos_Load(object sender, EventArgs e)
        {
            gridProdutos.DataSource = null;
            gridProdutos.AutoGenerateColumns = false;
            gridProdutos.DataSource = Lista;
        }

        private void gridProdutos_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (!gridProdutos.CurrentCell.OwningColumn.Name.Equals("sel")) return;
            if (gridProdutos.SelectedRows.Count<=0) return;
            if (gridProdutos.CurrentRow == null) return;
            var xx = gridProdutos.CurrentRow.DataBoundItem as Fact;
            if (xx == null) return;
            var dt = Listal.Where(x=>x.Factstamp.Equals(xx.Factstamp)).ToList();
            SendData.Invoke(xx,dt);
        }
    }
}
