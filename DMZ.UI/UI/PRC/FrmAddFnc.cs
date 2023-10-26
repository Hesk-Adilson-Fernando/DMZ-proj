using System;
using System.Data;
using DMZ.BL.Classes;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;

namespace DMZ.UI.UI.PRC
{
    public partial class FrmAddFnc : FrmClasse2
    {
        public FrmAddFnc()
        {
            InitializeComponent();
        }
        public Action<DataTable> SendData;
        public Action CarregarProdutos { get; set; }
        private void btnAddprocess_Click(object sender, EventArgs e)
        {
            var tab = GridProcess.GetBindedTable();
            if (tab == null) return;
            if (tab.HasOneRow("ok"))
            {
                tab = tab.HasRowsCopyToDataTable("ok");
                SendData?.Invoke(tab);
                CarregarProdutos?.Invoke();
                Close();
            }
            else
            {
                MsBox.Show($"{Messagem.ParteInicial()} Não é possível facturar em dois fornecedores simultaneamente!\r\nEscolha só um por cada vez, Obrigado");
            }
        }
        private DataTable _dtGrid;
        public void BindiGrid(DataTable dt)
        {
            _dtGrid.CopyColumnsFrom(dt);
            _dtGrid = dt;
            GridProcess.SetDataSource(dt); 
        }

        private void tbProdMesasProc_TextChanged(object sender, EventArgs e)
        {
            Helper.UpdateGrid(false, GridProcess, _dtGrid, tbProdMesasProc.Text);
        }

        private void GridProcess_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (GridProcess.CurrentRow != null && GridProcess.CurrentRow.Index < 0) return;
            if (GridProcess.CurrentRow != null && !GridProcess.CurrentRow.Cells["Status"].Value.ToBool())
            {
                GridProcess.CurrentRow.Cells["Status"].Value = true;
            }
            btnAddprocess.PerformClick();
        }

        private void FrmAddFnc_Load(object sender, EventArgs e)
        {

        }
    }
}
