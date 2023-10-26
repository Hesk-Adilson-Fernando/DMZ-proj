using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using DMZ.UI.Reports;
using DMZ.UI.UC;

namespace DMZ.UI.UI.RH
{
    public partial class FrmPeRcl : FrmClasse
    {
        public FrmPeRcl()
        {
            InitializeComponent();
        }
        private Percl _percl;
        private DataTable _pgfl;
        internal Fnc Fnc;
        public decimal TaxaCambio { get; set; }
        public string Trclcondicao { get; set; }
        private void Cliente_Load(object sender, EventArgs e)
        {

        }

        private void FrmPeRcl_Load(object sender, EventArgs e)
        {
            Campo1 = "Numero";
            Campo2 = "nome";
            Ctabela = "percl";
            BindGrid();
            TmpTpgp = SQL.GetRowToEnt<Tpgp>(" defa=1 ");
            SetValues();
            MultiDoc = true;
        }
        private void SetValues()
        {
            if (TmpTpgp == null) return;
            label1.Text = TmpTpgp.Descricao;
            dgvFormasp2.Movtz = true;
            CCondicao = $"numdoc={TmpTpgp.Numdoc} and year(data) = {Pbl.SqlDate.Year}";
            //if (TmpTpgf.Sigla.Equals("PGFA"))
            //{
            //    btnAddMov.Visible = true;
            //    btnMovimentos.Visible = false;
            //}
            //else
            //{
            //    btnAddMov.Visible = false;
            //    btnMovimentos.Visible = true;
            //}
            
        }
        public Tpgp TmpTpgp { get; set; }

        public override void DefaultValues()
        {
            _percl = DoAddline<Percl>();
            var m = SQL.GetRowToEnt<Moedas>(" princip = 1 ");
            ucMoeda.tb1.Text = m.Moeda.Trim();
            ucMoeda.Text2 = m.Descricao.Trim();
            _percl.Numdoc = TmpTpgp.Numdoc;
            _percl.Nomedoc = TmpTpgp.Descricao;
            _percl.Ccusto= Pbl.Usr.Ccusto;
            _percl.Codmovcc = TmpTpgp.Codmovcc;
            _percl.Descmovcc = TmpTpgp.Descmovcc;
            _percl.Codmovtz = TmpTpgp.Codmovtz;
            _percl.Descmovtz = TmpTpgp.Descmovtz;
            _percl.Sigla = TmpTpgp.Sigla;
            _percl.Rcladiant = TmpTpgp.Rcladiant;
            tbCcusto.tb1.Text= Pbl.Usr.Ccusto;
            _percl.Usrstamp = Pbl.Usr.Usrstamp;
            base.DefaultValues();
            btnGravar.Enabled = true;
            Lblcancelado.Visible = false;
        }

        public override bool BeforeSave()
        {
            var vals = GenBl.CheckTesoura(dgvFormasp2.Formaspdt, tbTotal.tb1.Text.ToDecimal(), true);
            if (!vals.Correcto)
            {
                MsBox.Show(vals.Messagem);
                return false;
            }
            var dtRcll = dgvRcll.DataSource as DataTable;
            if (dtRcll?.Rows.Count==0)
            {
                MsBox.Show("Não pode gravar recibo sem movimentos, por favor verifique!.");
                return false; 
            }
            var dt = dgvFormasp2.Grelha.DataSource as DataTable;
            if (dt == null) return true;
            foreach (var dr in dt.AsEnumerable())
            {
                if (dr == null) continue;
                var codtz = dr["Codtz"].ToDecimal();
                var valor  = dr["valor"].ToDecimal();
                var conta = SQL.GetRowToEnt<Contas>($"Codigo ={codtz}");// EF.GetEnt<Contas>(x => x.Codigo.Equals(codtz));
                if (valor <= conta.Saldo) continue;
                if (conta.Noneg) continue;
                MsBox.Show($"O saldo da conta {conta.Sigla} {conta.Numero} não é suficiente para o movimento \r\n O saldo existente é: {conta.Saldo}");
                return false;
            }
            return base.BeforeSave();
        }

        public override void Save()
        {
            FillEntity(_percl);
            EF.Save(_percl);
            GenBl.ExecAudit(_percl, Name);
        }
        public override void AfterSave()
        {
            if (!string.IsNullOrEmpty(_percl.Pjstamp))
            {
                Helper.Updatepj(true,_percl.Pjstamp,"TPago","pgf","totftiva",false,true);
                SendRefresh?.Invoke(false);
            }
        }
        public Action<bool> SendRefresh { get; set; }
        public override void PreencheCampos(DataTable dt, int i)
        {
            _percl = FillControls(_percl, dt, i);
            BindGrid();
            UpdateInfo();
        }
        private void UpdateInfo()
        {
            if (!_percl.Anulado) return;
            Lblcancelado.Text = @"Documento Cancelado";
            Lblcancelado.ForeColor = Color.DarkRed;
            Lblcancelado.Visible = true;
            btnGravar.Enabled = false;
        }
        void BindGrid()
        {
            var listagridFp = Helper.GetAll(this, typeof(GridFormasP)).ToList();
            if (listagridFp.Count <= 0) return;
            foreach (var l in listagridFp)
            {
                if (l == null) return;
                ((GridFormasP)l).BindGridView(EditMode);
            }
            listagridFp.Clear();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            var retorno = Imprimir.Valido(Usracessos, tbFornec.tb1.Text,false);
            if (retorno.Imprimir)
            {
                DS Ds = new DS();
                var Rcll = dgvRcll.GetBindedTable();
                var formasp = dgvFormasp2.Grelha.DataSource as DataTable;
                var ret = Imprimir.FillData(_percl.ToDataTable(), Rcll, formasp, Ds.Percl, Ds.Formasp);
                Imprimir.CallForm(ret.dtPrint, ret.fp, CLocalStamp, Inserindo, label1.Text, tbFornec.Text2, TmpTpgp.Nomfile, "percl", this, TmpTpgp.XmlString, true, Ds, "", "", null,null, TmpTpgp.Nomfile2, TmpTpgp.XmlStringa5);
                //Imprimir.CallForm(ret.dtPrint, ret.fp, CLocalStamp, Inserindo, label1.Text, tbFornec.Text2, TmpTpgp.Nomfile, "percl", this, TmpTpgp.XmlString, true, Ds, "", "");
            }
            else
            {
                MsBox.Show(retorno.Messagem);
            }
        }

        private void btnTdi_Click(object sender, EventArgs e)
        {
            if (Procurou && Lista == null)
            {
                CallBrowdoc();
            }
            else
            {
                if (!EditMode)
                {
                    CallBrowdoc();
                }
                else
                {
                    MsBox.Show("O formulário está em modo de edição. Porfavor Grave");
                }
            }
        }
        public void CallBrowdoc()
        {
            var bw = new Browdoc
            {
                Condicao = "",
                Descricao = "descricao",
                Sigla = "sigla",
                Tabela = "Tpgp",
                BindTdoc = BindTdoc
            };
            bw.ShowForm(this);
        }
        public void UpdateObjects(DataTable dt)
        {
            if (_percl==null)
            {
                _percl = new Percl(); 
            }
            var numdoc = dt.Rows[0]["Numdoc"].ToDecimal();
            TmpTpgp = SQL.GetRowToEnt<Tpgp>( $"numdoc={numdoc}");
            label1.Text = TmpTpgp.Descricao;
            panel1.Visible = false;
            panel3.Visible = false;
        }
        public void BindTdoc(DataRow tdoc, bool origem = false)
        {
            if (tdoc == null) return;
            TmpTpgp = tdoc.DrToEntity<Tpgp>();
            label1.Text = TmpTpgp.Descricao;
            SetValues();
            //gridFormasP.Refresh(TmpTpgf.Numdoc);
        }

        private void btnMovimentos_Click(object sender, EventArgs e)
        {
            if (!EditMode) return;
            if (string.IsNullOrEmpty(tbFornec.tb1.Text))
            {
                MsBox.Show("Por favor indica o fornecedor!..");
                return;
            }
            var dt = GenBl.PeCc(tbFornec.Text2.ToDecimal(),"MZN");
            if (dt.HasRows()) 
            {
                var dc2 = new DataColumn { DataType = typeof(bool), ColumnName = "Ok2" };
                dt.Columns.Add(dc2);
                var f = new FrmReg {Tabela = dt, SendData = ReceiveData, OrigemDoc = true};
                f.ShowForm(this);
            }
            else
            {
                MsBox.Show("O Fornecedor não tem movimentos");
            }
        }
        
        public void ReceiveData(DataTable dataRows)
        {
            _pgfl = dgvRcll.DataSource as DataTable;
            foreach (var r in dataRows.AsEnumerable().Where(r => r != null))
            {
                GetValue(r);
            }
            dgvRcll.DataSource = null;
            dgvRcll.DataSource = _pgfl;
            var total = _pgfl?.AsEnumerable().Sum(x => x.Field<decimal>("valorreg"));
            if (_pgfl != null)
            {
                tbTotal.tb1.Text = total.ToString();
            }
            CreateFormasP(total.ToDecimal());
            dgvFormasp2.Grelha.Update();
            _percl.Processtamp = dataRows.RowZero("oristamp").ToString();
        }
        private void CreateFormasP(decimal total)
        {
            dgvFormasp2.btnAdd.PerformClick();
            if (dgvFormasp2.Grelha.CurrentRow != null)
            {
                Helper.UpdateFormasp(total,0,TmpTpgp.Codmovtz,TmpTpgp.Descmovtz,"PERCL",dgvFormasp2);
                UpdGridFormasp();
            }
            dgvFormasp2.Grelha.Update();
        }



        private void GetValue(DataRow r)
        {
            var r2 = _pgfl.NewRow().Inicialize();
            r2["descricao"] = r["descricao"];
            r2["valorpreg"] = r["valorpreg"];
            r2["valorreg"] = r["valorreg"];
            r2["data"] = r["data"];
            r2["Pccstamp"] = r["peccstamp"];
            r2["Percllstamp"] = Pbl.Stamp();
            r2["Perclstamp"] = _percl.Perclstamp;
            r2["ValorPend"] = r["valorpreg"].ToDecimal()-r["valorreg"].ToDecimal();
            r2["Valordoc"] = r["Valordoc"];
            //r2["numinterno"] = r["numinterno"];
            r2["nrdoc"] = r["nrdoc"];
            _pgfl.Rows.Add(r2);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            //Imprimir.DoPrint(CLocalStamp, Inserindo, label1.Text, tbFornec.Text2, TmpTpgp.Nomfile.Trim(), "PERCL", this, Linguas.PT);
        }

        private void nToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Imprimir.DoPrint(CLocalStamp, Inserindo, label1.Text, tbFornec.Text2, TmpTpgp.Nomfile2.Trim(), "PERCL", this, Linguas.PT);
        }

        private void ucMoeda_RefreshControls()
        {
            if (!string.IsNullOrEmpty(ucMoeda.tb1.Text))
            {
                if (!ucMoeda.tb1.Text.Equals(Pbl.MoedaBase))
                {
                    ShowFormaspMoedas();
                }
                Helper.UpdateFormaspMoeda(dgvFormasp2, ucMoeda.tb1.Text);
            }
        }
        private void ShowFormaspMoedas(GridFormasP dFormasP = null)
        {
            if (dFormasP == null)
            {
                Helper.SetColunas(false, null, dgvFormasp2, ucMoeda);
            }
            //else
            //{
            //    //Helper.SetColunas(false, Frm.dgvRcll, Frm.dgvFormasp2, Frm.ucMoeda);
            //}
        }
    }
}
