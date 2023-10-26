using System;
using System.Data;
using DMZ.BL.Classes;
using DMZ.UI.Basic;
using DMZ.UI.UI.PJ;

namespace DMZ.UI.UI
{
    public partial class FrmPjStatus : FrmClasse2
    {
        private FrmPj frmPj; 
        public FrmPjStatus(FrmPj _frmPj)
        {
            InitializeComponent();
            frmPj = _frmPj;
        }

        private void FrmPjStatus_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid(string cond = "")
        {
            var dt = SQL.GetGen2DT($"select * from pj where Status='{PjStatus}'{cond} order by codigo");
            gridUi1.DataSource = null;
            gridUi1.AutoGenerateColumns = false;
            gridUi1.DataSource = dt;
            if (dt?.Rows.Count>0)
            {
                if (dt.Rows.Count==1)
                {
                    lblQuantidade.Text =@"1 PROCESSOS ENCONTRADO";
                }
                else
                {
                    lblQuantidade.Text = dt.Rows.Count +@" PROCESSOS ENCONTRADOS";
                }
            }
            else
            {
                lblQuantidade.Text = @"0 PROCESSO ENCONTRADO"; 
            }
        }

        public string PjStatus { get; set; }
        private void dmzProcura1_RefreshControls()
        {

        }

        private void btnSerach_Click(object sender, EventArgs e)
        {
            PjStatus = dmzStatus.tb1.Text.ToLower();
            BindGrid($"and no={dmzProcura1.Text2.ToDecimal()}");
        }

        private void gridUi1_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (gridUi1.SelectedRows.Count <= 0) return;
            var dt = gridUi1.DataSource as DataTable;
            if (!(dt?.Rows.Count > 0)) return;
            frmPj.GenTable = dt;
            frmPj.Procurou = true;
            frmPj.PreencheCampos(dt,gridUi1.SelectedRows[0].Index);
            Close();
        }
    }
}
