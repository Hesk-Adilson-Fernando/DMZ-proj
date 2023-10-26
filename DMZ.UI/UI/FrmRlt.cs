using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Classes;
using DMZ.UI.Generic;
using DMZ.UI.UC;

namespace DMZ.UI.UI
{
    public partial class FrmRlt : Basic.FrmClasse
    {
        private Rlt _rlt;
        public DataTable DtCcu { get; set; }
        public FrmRlt()
        {
            InitializeComponent();
        }
        private void FrmRlt_Load(object sender, EventArgs e)
        {
            Campo1 = "Numero";
            Campo2 = "descricao";
            Ctabela = "Rlt";
        }
        public override void DefaultValues()
        {
            _rlt = DoAddline<Rlt>();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(_rlt);
            EF.Save(_rlt);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            _rlt = FillControls(_rlt, dt, i);
        }
        private void btnMais_Click(object sender, EventArgs e)
        {
            var size = tbScript.tb1.Font.Size;
            tbScript.tb1.Font = new Font(tbScript.Font.Name,size + 1);
        }
        private void btnMenos_Click(object sender, EventArgs e)
        {
            var size = tbScript.tb1.Font.Size;
            tbScript.tb1.Font = new Font(tbScript.Font.Name, size - 1);
        }
        private void gridCC_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (gridCC == null) return;
            var colName = gridCC.CurrentCell.OwningColumn.Name.ToLower().Trim();
            if (colName != "ccusto") return;
            var auto = e.Control as TextBox;
            if (auto == null) return;
            DtCcu = Helper.SetBinds(e.Control, "descricao", "select codccu, descricao from ccu");
        }

        private void gridCC_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var nome = gridCC.CurrentCell.OwningColumn.Name.ToLower();
            if (!nome.Equals("ccusto")) return;
            if (gridCC.CurrentCell?.Value == null) return;
            var valor = gridCC.CurrentCell.Value.ToString().Trim();
            var dr = DtCcu.AsEnumerable().FirstOrDefault(s => s.Field<string>("descricao").Trim().Equals(valor));
            if (dr == null) return;
            if (gridCC.CurrentRow != null) 
                gridCC.CurrentRow.Cells["codccu"].Value = dr["codccu"].ToString();
            gridCC.Update();
        }

        private void gridCC_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Helper.CellEnter(sender, e);
        }

        private void gridUi1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var colName = gridUi1.CurrentCell.OwningColumn.Name.ToLower().Trim();
            var qry = "select Login,Nome from usr ";
            if (colName.Equals("descricao"))
            {

                Dtusr = Helper.SetBinds(e.Control, "Nome", qry);
            }
            else if (colName.Equals("codigo"))
            {
                Dtusr = Helper.SetBinds(e.Control, "Login", qry);
            }
            else
            {
                Dtusr = null;
                var autoText = e.Control as TextBox;
                if (autoText != null) 
                    autoText.AutoCompleteCustomSource = null;
            }
        }
        public DataTable Dtusr { get; set; }
        private void gridUi1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var nome = gridUi1.CurrentCell.OwningColumn.Name.ToLower();
            if (nome.Equals("descricao"))
            {
                SetUsr("Nome");
            }
            if (nome.Equals("login"))
            {
                SetUsr("Login");
            }
        }

        private void SetUsr(string p0)
        {
            if (gridUi1.CurrentCell?.Value == null) return;
            var valor = gridUi1.CurrentCell.Value.ToString().Trim();
            var dr = Dtusr?.AsEnumerable().FirstOrDefault(s => s.Field<string>(p0.Trim()).Trim().Equals(valor));
            if (dr == null) return;
            switch (p0)
            {
                case "Nome":
                    if (gridUi1.CurrentRow != null) 
                        gridUi1.CurrentRow.Cells["Login"].Value = dr[0].ToString();
                    break;
                default:
                    if (gridUi1.CurrentRow != null) 
                        gridUi1.CurrentRow.Cells["descricao"].Value = dr[1].ToString();
                    break;
            }
            gridUi1.Update();
        }

        private void gridPanel2_CallForm()
        {
            var f = new FrmAddlines("Módulos Disponíveis", "Select Descricao,obs, OK = CAST(0 as bit) from modulos") { PControl = ReceiveData };
            f.ShowForm(this);
        }
        public void ReceiveData(DataTable dt)
        {
            if (!(dt?.Rows.Count > 0)) return;
            var tab = gridUi2.DataSource as DataTable;
            foreach (var r in dt.AsEnumerable())
            {
                if (r == null) continue;
                if (tab == null) continue;
                var dr = tab.NewRow().Inicialize();
                dr["codigo"]=r["descricao"].ToString();
                dr["descricao"]=r["obs"].ToString();
                dr["Rltstamp"]=CLocalStamp;
                tab.Rows.Add(dr);
            }
            gridUi2.DataSource = null;
            gridUi2.DataSource = tab;
            gridUi2.Update();
        }

        private void gridUi3_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (gridUi3 == null) return;
            var colname = gridUi3.CurrentCell.OwningColumn.Name;
            if (colname.Equals("Alinhamento"))
            {
                var lista = Helper.EnumToDataTable(Alinhamento.DefaultCellStyle.Alignment);
                var auto = e.Control as TextBox;
                if (auto == null) return;
                Helper.SetBinds(e.Control, lista);
            }
            if (colname.Equals("Autosizemode"))
            {
                var lista = Helper.EnumToDataTable(Alinhamento.AutoSizeMode);
                var auto = e.Control as TextBox;
                if (auto == null) return;
                Helper.SetBinds(e.Control, lista);
            }
            if (colname.Equals("ColumnType"))
            {
                
                var lista = Helper.TiposColuna();
                var auto = e.Control as TextBox;
                if (auto == null) return;
                Helper.SetBinds(e.Control, lista);
            }
        }

        private void tbDefault9_Load(object sender, EventArgs e)
        {

        }

        private void tbDefault13_Load(object sender, EventArgs e)
        {

        }

        private void cbDefault16_Load(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void btnDuplicar_Click(object sender, EventArgs e)
        {
            dmzOptions.ShowMenuStrip(btnDuplicar);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (Procurou)
            {
                var drs = MsBox.Show("Deseja duplicar o presente Relatório?", DResult.YesNo);
                if (drs.DialogResult == DialogResult.Yes)
                {
                    CLocalStamp = Pbl.Stamp();
                    var maximo = SQL.Maximo("rlt", "numero","");
                    _rlt.Rltstamp = CLocalStamp;
                    tbDefault2.tb1.Text = maximo.ToString();
                    Helper.UpdateLinhasRlt(CLocalStamp,  "rlt", this);
                }
            }
            else
            {
                MsBox.Show($@"{Messagem.ParteInicial()}Para duplicar um determinado dado, deve primeiro carregar o tal dado!");
            }
        }
    }
}
