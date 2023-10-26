using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;

namespace DMZ.UI.UI
{
    public partial class FrmDisc : Basic.FrmClasse
    {
        private St _disc;

        public FrmDisc()
        {
            InitializeComponent();
        }

        private void FrmDisc_Load(object sender, EventArgs e)
        {
            Campo1 = "Referenc";
            Campo2 = "descricao";
            Ctabela = "st";
            CCondicao = "Disciplina = 1";
        }

        public override void DefaultValues()
        {
            _disc = DoAddline<St>();
            var tabiva = SQL.GetGen2DT("select codigo,descricao from Auxiliar where Tabela=5 and Padrao=1 ");
            if (tabiva.HasRows())
            {
                TabIVa.tb1.Text = tabiva.Rows[0]["descricao"].ToString();
                TabIVa.Text2 = tabiva.Rows[0]["codigo"].ToString();
            }
            base.DefaultValues();
            _disc.Disciplina = true;
            status.SetStatusValue();
        }
        public override bool BeforeSave()
        {
            if (!Procurou)
            {
                return CheckDisciplina();
            }
            if (Procurou)
            {
                if (!_disc.Referenc.ToLower().Trim().Equals(tbReferenc.tb1.Text.ToLower().Trim()))
                {
                    return CheckDisciplina();
                }
            }
            return base.BeforeSave();
        }

        private bool CheckDisciplina()
        {
            if (SQL.CheckExist($"select referenc from st where referenc ='{tbReferenc.tb1.Text.Trim()}'"))
            {
                MsBox.Show("O código da disciplina já existe, deve trocar ");
                return false;
            }
            return true;
        }

        public override void Save()
        {
            FillEntity(_disc);
            EF.Save(_disc);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            _disc = FillControls(_disc, dt, i);
           // tbReferenc.IsReadOnly = true;
        }

        private void gridUI1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            Dt = Helper.ShowDisciplina(gridUI1.CurrentCell, e);
        }

        public DataTable Dt { get; set; }
        public DataTable DtCcu { get; private set; }

        private void gridUI1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Helper.SetDisciplina(gridUI1,Dt);
        }
        private void gridPreco_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var colName = gridPreco.CurrentCell.OwningColumn.Name.ToLower().Trim();
            if (colName.Equals("ccusto"))
            {
                DtCcu = Helper.SetBinds(e.Control, "descricao", "select codccu, descricao,Ccustamp from ccu");
            }
            else if (colName.Equals("moeda"))
            {
                Helper.SetBinds(e.Control, "Moeda", "select Moeda from moedas ");
            }
        }

        private void gridPreco_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var colName = gridPreco.CurrentCell.OwningColumn.Name;
            if (colName.Trim().Equals("ccusto"))
            {
                if (gridPreco.CurrentRow == null) return;//
                var valor = gridPreco.CurrentRow.Cells["ccusto"].Value.ToString().Trim();
                DataRow dr = null;
                if (!(DtCcu.HasRows())) return;
                foreach (var r in DtCcu.AsEnumerable())
                {
                    if (r == null) continue;
                    if (!r["descricao"].ToString().Trim().Equals(valor)) continue;
                    dr = r;
                    break;
                }
                if (dr == null) return;
                gridPreco.CurrentRow.Cells["codccu"].Value = dr["codccu"].ToString();//
                gridPreco.CurrentRow.Cells["Ccustamp"].Value = dr["Ccustamp"].ToString();//
            }

            if (colName.Trim().Equals("Perlucro"))
            {
                var perc = gridPreco.CurrentCell.Value.ToDecimal();
                if (gridPreco.CurrentRow == null) return;
                var valcompra = gridPreco.CurrentRow.Cells["Pcompra"].Value.ToDecimal();
                var valorVenda = valcompra + valcompra * perc / 100;
                gridPreco.CurrentRow.Cells["Preco"].Value = valorVenda;
            }

            if (!colName.Trim().Equals("Preco")) return;
            {
                if (gridPreco.CurrentRow == null) return;
                var valcompra = gridPreco.CurrentRow.Cells["Pcompra"].Value.ToDecimal();
                if (valcompra == 0) return;
                var valvenda = gridPreco.CurrentRow.Cells["Preco"].Value.ToDecimal();
                var perlucro = (valvenda - valcompra) * 100 / valcompra;
                gridPreco.CurrentRow.Cells["Perlucro"].Value = perlucro;
            }
        }
    }
}
