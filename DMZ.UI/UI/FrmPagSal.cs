using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Basic;

namespace DMZ.UI.UI
{
    public partial class FrmPagSal : Basic.FrmClasse2
    {
        public FrmPagSal()
        {
            InitializeComponent();
        }

        private Di di;
        private Tdi _tmpTdi;
        private DataTable dt;
        private DataTable dt2;
        private void FrmPagSal_Load(object sender, EventArgs e)
        {
            dtDefault1.dt1.Value = Pbl.SqlDate;
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            _tmpTdi = SQL.GetRowToEnt<Tdi>($"Sigla='PS'"); //EF.GetEnt<Tdi>(x => x.Sigla.Equals("PS"));
            tbDocumento.Text = _tmpTdi.Nome;
            dt = SQL.GetGen2DT("select no,Nome,ValBasico from pe ");
            if (dt?.Rows.Count > 0)
            {
                gridPreco.DataSource = null;
                gridPreco.AutoGenerateColumns = false;
                gridPreco.DataSource = dt;
            }
             dt2 = SQL.GetGen2DT("select no,Nome,ValBasico from pe where 1=0");
            if (dt?.Rows.Count > 0)
            {
                gridRH.DataSource = null;
                gridRH.AutoGenerateColumns = false;
                gridRH.DataSource = dt2;
            }
        }

        private void btnSeguinte_Click(object sender, EventArgs e)
        {
            switch(tabControl1.SelectedTab.TabIndex)
            {

                case 0:

                    tabControl1.SelectTab(tabPageSelect);
                    
                    break;

                case 1:

                    tabControl1.SelectTab(tabPageProcess);

                    break;

                case 2:

                    tabControl1.SelectTab(tabPageProcess);

                    break;
            }
            //
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            foreach (var r in gridRH.DtDS.AsEnumerable())
            {
                if (r == null) continue;
                di=Utilities.DoAddline<Di>();
                di.Numero = SQL.Maximo("di", "Numero", $"numdoc={_tmpTdi.Numdoc} and year(data) = {Pbl.SqlDate.Year}");
                di.Data = dtDefault1.dt1.Value;
                di.No = r["no"].ToString();
                di.Nome = r["Nome"].ToString();
                di.Total = r["ValBasico"].ToDecimal();
                di.Numdoc = _tmpTdi.Numdoc;
                di.Nomedoc = _tmpTdi.Nome;
                di.Movstk = _tmpTdi.Movstk;
                di.Movtz = _tmpTdi.Movtz;
                #region Codigo de movimento de stock
                di.Descmovstk = _tmpTdi.Descmovstk;
                di.Codmovstk = _tmpTdi.Codmovstk;
                di.Descmovstk2 = _tmpTdi.Descmovstk2;
                di.Codmovstk2 = _tmpTdi.Codmovstk2;
                #endregion
                #region Codigos de movimento de tesouraria
                di.Descmovtz = _tmpTdi.Descmovtz;
                di.Codmovtz = _tmpTdi.Codmovtz;
                di.Descmovtz2 = _tmpTdi.Descmovtz2;
                di.Codmovtz2 = _tmpTdi.Codmovtz2;
                #endregion

                #region Conta padrão a movimentar
                di.Codtz = _tmpTdi.Codtz;
                di.Contatesoura = _tmpTdi.Contastesoura;
                #endregion
                di.Ccusto = Pbl.Usr.Ccusto;
                EF.Save(di);
                GenBl.ExecAudit(di, Name);
                #region Filhas 
                var dil=Utilities.DoAddline<Dil>();
                dil.Distamp = di.Distamp;
                dil.Quant = 1;
                dil.Ref = "sal";
                dil.Descricao = $"Salário do mês de {tbMes.tb1.Text}";
                dil.Preco = r["ValBasico"].ToDecimal();
                dil.Subtotall = r["ValBasico"].ToDecimal();
                EF.Save(dil);

                var f=Utilities.DoAddline<Formasp>();
                f.Distamp = di.Distamp;
                f.Titulo = tbTitulo.tb1.Text;
                f.Dcheque = dtDefault1.dt1.Value;
                f.Banco = tbTesoura.Text2;
                f.Codtz = tbTesoura.Text2.ToDecimal();
                f.Valor = r["ValBasico"].ToDecimal();
                f.UsrLogin=Pbl.Usr.Usrstamp;
                EF.Save(f);
                #endregion
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            switch(tabControl1.SelectedTab.TabIndex)
            {

                case 0:

                    tabControl1.SelectTab(tabPageHome);

                    break;

                case 1:
                    tabControl1.SelectTab(tabPageHome);
                    break;

                case 2:
                    tabControl1.SelectTab(tabPageSelect);
                    break;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in gridPreco.Rows)
            {
                if (r == null) continue;
                if (!r.Cells["Padrao"].Value.ToBool()) continue;
                var row = dt2.NewRow();
                row["nome"] = r.Cells["nome"].Value;
                row["ValBasico"] = r.Cells["ValBasico"].Value;
                row["no"] = r.Cells["no"].Value;
                dt2.Rows.Add(row);
                gridPreco.Rows.Remove(r);
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in gridRH.SelectedRows)
            {
                if (r == null) continue;
                var row = dt.NewRow();
                row["nome"] = r.Cells[0].Value;
                row["ValBasico"] = r.Cells["ValBasico"].Value;
                row["no"] = r.Cells[2].Value;
                dt2.Rows.Add(row);
                gridPreco.Rows.Remove(r);
            }
        }
    }
}
