using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Generic;
using DMZ.UI.UC;
namespace DMZ.UI.UI
{



    #region Código

    public partial class FrmPgfCrzcnt : FrmClasse
    {
        public Pgf _pgf;
        private DataTable _pgfl;

        public decimal Total { get; private set; }
        public decimal Mtotal { get; private set; }

        private DataTable _fpdt;
        public Fnc Fnc;

        public FrmPgfCrzcnt()
        {
            InitializeComponent();
        }

        private void FrmPagamento_Load(object sender, EventArgs e)
        {
            var qry = $"select descricao,valordoc,valorpreg,valorreg,tipo,deb,cre " +
                      $"from(select *,tipo=1,deb=valorpreg,cre=0 from clccf() where clstamp='635D20221DMZ25111155' " +
                      $"union  all select upper('Ttl CC Cl'),'','',sum(valordoc),sum(valorpreg),sum(valorreg),0,'','','','',0,'','',0,'','',''," +
                      $"'',tipo=1,sum(valorpreg),cre=0 from clccf() where clstamp='635D20221DMZ25111155' union  all select *,tipo=2,deb=0,cre=valorpreg " +
                      $"from fncccf() where fncstamp='469D20222DMZ518132' union  all select upper('Ttl CC Fnc'),'',''," +
                      $"sum(valordoc),sum(valorpreg),sum(valorreg),0,'','','','',0,'','',0,'','','','',tipo=2,deb=0,cre=sum(valorpreg)  " +
                      $"from fncccf() where fncstamp='469D20222DMZ518132' union  all select upper('Total Geral'),'','',ss=((select -(sum(valordoc)) from fncccf() " +
                      $"where fncstamp='469D20222DMZ518132' )+(select sum(valordoc)from clccf() where clstamp='635D20221DMZ25111155' )),sum(0),sum(0),0,'','',''," +
                      $"'',0,'','',0,'','','','',tipo=0,deb=0,cre=0 )temp ";


            Campo1 = "Numero";
            Campo2 = "nome";
            Ctabela = "Pgf";
            BindGrid();
            TmpTpgf = SQL.GetRowToEnt<Tpgf>(" Defa = 1 ");
            SetValues();
            MultiDoc = true;
            
            dgvRcll.DtDS=SQL.GetGen2DT(qry);
            dgvRcll.DataSource = dgvRcll.DtDS;


        }
        private void SetValues()
        {
            if (TmpTpgf == null) return;
            label1.Text = TmpTpgf.Descricao;
            dgvFormasp2.Movtz = true;
            Helper.ClearControls(this);
            CCondicao = $"numdoc={TmpTpgf.Numdoc} and year(data) = {Pbl.SqlDate.Year} and Ccusto='{Pbl.Usr.Ccusto.Trim()}'";
            if (TmpTpgf.Sigla.Equals("PGFA"))
            {
                btnAddMov.Visible = true;
                btnMovimentos.Visible = false;
            }
            else
            {
                btnAddMov.Visible = false;
                btnMovimentos.Visible = true;
            }

        }
        public Tpgf TmpTpgf { get; set; }

        public override void DefaultValues()
        {
            _pgf = DoAddline<Pgf>();
            var m = SQL.GetRowToEnt<Moedas>(" princip = 1 ");
            ucMoeda.tb1.Text = m.Moeda.Trim();
            ucMoeda.Text2 = m.Descricao.Trim();
            _pgf.Numdoc = TmpTpgf.Numdoc;
            _pgf.Nomedoc = TmpTpgf.Descricao;
            _pgf.Ccusto = Pbl.Usr.Ccusto;
            _pgf.Codmovcc = TmpTpgf.Codmovcc;
            _pgf.Descmovcc = TmpTpgf.Descmovcc;
            _pgf.Codmovtz = TmpTpgf.Codmovtz;
            _pgf.Descmovtz = TmpTpgf.Descmovtz;
            _pgf.Sigla = TmpTpgf.Sigla;
            _pgf.Rcladiant = TmpTpgf.Rcladiant;
            tbCcusto.tb1.Text = Pbl.Usr.Ccusto;
            base.DefaultValues();
            //var numero = Helper.GetNumero(TmpTpgf.Tpgfstamp.Trim()); 
            //if (numero == 0) return;
            //if (numero <= tbNumero.tB1.Text.ToDecimal()) return;
            //tbNumero.tB1.Text = numero.ToString();
            btnGravar.Enabled = true;
            Lblcancelado.Visible = false;
        }

        public override bool BeforeSave()
        {
            bool ret = true;
            if (!ucMoeda.tb1.Text.Trim().Equals(Pbl.MoedaBase.Trim()))
            {
                var dtfp = dgvFormasp2.Grelha.DataSource as DataTable;
                if (dtfp?.Rows.Count > 0)
                {
                    foreach (var item in dtfp.AsEnumerable())
                    {
                        var moeda = SQL.GetField("moeda", "contas", $"codigo='{item["codtz"].ToDecimal()}'").ToString();
                        if (!moeda.Trim().Equals(ucMoeda.tb1.Text.Trim()))
                        {
                            MsBox.Show(Messagem.ParteInicial() + $"A conta {item["Contatesoura"].ToString()} não pode ser movimentada! A sua moeda é: {moeda}, diferente do: {ucMoeda.tb1.Text}");
                            ret = false;
                            break;
                        }
                    }
                }
            }
            if (!ret)
            {
                return false;
            }
            var vals = GenBl.CheckTesoura(dgvFormasp2.Formaspdt, tbTotal.tb1.Text.ToDecimal(), true);
            if (!vals.Correcto)
            {
                MsBox.Show(vals.Messagem);
                return false;
            }
            var dtRcll = dgvRcll.DataSource as DataTable;
            if (dtRcll?.Rows.Count == 0)
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
                var valor = dr["valor"].ToDecimal();
                var mvalor = dr["mvalor"].ToDecimal();
                var conta = SQL.GetRow($"select Saldo,mSaldo,Sigla,Numero,Noneg from contas where codigo={codtz}");
                if (ucMoeda.tb1.Text.Trim().Equals(Pbl.MoedaBase))
                {
                    if (valor > conta["Saldo"].ToDecimal())
                    {
                        if (!conta["Noneg"].ToBool())
                        {
                            MsBox.Show($"O saldo da conta {conta["Sigla"]} {conta["Numero"]} não é suficiente para o movimento \r\n O saldo existente é: {conta["Saldo"]}");
                            ret = false;
                            break;
                        }
                    }

                }
                else
                {
                    if (mvalor > conta["mSaldo"].ToDecimal())
                    {
                        if (!conta["Noneg"].ToBool())
                        {
                            MsBox.Show($"O saldo da conta {conta["Sigla"]} {conta["Numero"]} não é suficiente para o movimento \r\n O saldo existente é: {conta["mSaldo"]}");
                            ret = false;
                            break;
                        }
                    }
                }

            }
            if (!ret)
            {
                return false;
            }
            return base.BeforeSave();
        }

        public override void Save()
        {
            FillEntity(_pgf);
            EF.Save(_pgf);
            GenBl.ExecAudit(_pgf, Name);
        }
        public override void AfterSave()
        {
            if (!string.IsNullOrEmpty(_pgf.Pjstamp))
            {
                Helper.Updatepj(true, _pgf.Pjstamp, "TPago", "pgf", "totftiva", false, true);
                SendRefresh?.Invoke(false);
            }
        }
        public Action<bool> SendRefresh { get; set; }
        public override void PreencheCampos(DataTable dt, int i)
        {
            _pgf = FillControls(_pgf, dt, i);
            BindGrid();
            UpdateInfo();
        }
        public override void UpdGridFormasp()
        {
            Helper.Codmovtz(true, TmpTpgf.Codmovtz, TmpTpgf.Descmovtz, dgvFormasp2.Grelha, "pgf");
        }
        private void btnMovimentos_Click(object sender, EventArgs e)
        {
            if (!EditMode) return;
            if (string.IsNullOrEmpty(tbFornec.tb1.Text))
            {
                MsBox.Show("Por favor indica o fornecedor!..");
                return;
            }
            var dt = GenBl.GetCc(tbFornec.Text3.Trim(), "fncccf", "fnc");
            if (!string.IsNullOrEmpty(tbPj.Text3))
            {
                var dc = new DataColumn { DataType = typeof(bool), ColumnName = "exite" };
                dt.Columns.Add(dc);
                foreach (var r in dt.AsEnumerable())
                {
                    r["exite"] = SQL.CheckExist($"select top 1 faccstamp from facc where faccstamp='{r["oristamp"].ToString().Trim()}' and pjstamp='{tbPj.Text3.Trim()}'");
                }
                dt = dt.AsEnumerable().Where(x => x.Field<bool>("exite").Equals(true)).CopyToDataTable();
                if (dt?.Rows.Count > 0)
                {
                    dt = dt.DefaultView.ToTable(true, "descricao", "nrdoc", "data", "valordoc", "valorpreg", "valorreg",
                        "ok", "fccstamp", "origem", "oristamp", "moeda", "cambiousd");
                }
            }
            if (dt?.Rows.Count > 0)
            {
                var f = new FrmReg { Tabela = dt, SendData = ReceiveData, OrigemDoc = true };
                f.ShowForm(this);
            }
            else
            {
                MsBox.Show("O Fornecedor não tem movimentos");
            }
        }

        public void ReceiveData(DataTable dataRows)
        {
            Total = 0;
            Mtotal = 0;
            _pgfl = dgvRcll.DataSource as DataTable;
            foreach (var r in dataRows.AsEnumerable().Where(r => r != null))
            {
                GetValue(r);
            }
            if (_pgfl != null)
            {
                foreach (var r in _pgfl.AsEnumerable().Where(r => r != null))
                {
                    Total = Total + r["valorreg"].ToDecimal();
                    Mtotal = Mtotal + r["mvalorreg"].ToDecimal();
                    //if (r["valorreg"].ToDecimal()>0)
                    //{

                    //}
                    //if (r["mvalorreg"].ToDecimal()>0)
                    //{

                    //}
                }
                tbTotal.tb1.Text = Total.ToString();
                tbmTotal.tb1.Text = Mtotal.ToString();
            }
            CreateFormasP(Total.ToDecimal(), Mtotal.ToDecimal());
            if (Mtotal > 0)
            {

                ucMoeda.tb1.Text = dataRows.AsEnumerable().FirstOrDefault()["moeda"].ToString();
                ShowFormaspMoedas();
            }
            dgvRcll.DataSource = null;
            dgvRcll.DataSource = _pgfl;
            dgvFormasp2.Grelha.Update();
        }
        private void ShowFormaspMoedas()
        {
            dgvFormasp2.Grelha.Columns["mvalor"].Visible = true;
            dgvFormasp2.Grelha.Columns["mvalor"].HeaderText = $"Valor {ucMoeda.tb1.Text}";
            dgvRcll.Columns["mvalordoc"].Visible = true;
            dgvRcll.Columns["mvalordoc"].HeaderText = $"Valor Doc. {ucMoeda.tb1.Text}";

            dgvRcll.Columns["mvalorpreg"].Visible = true;
            dgvRcll.Columns["mvalorpreg"].HeaderText = $"Por Pagar {ucMoeda.tb1.Text}";

            dgvRcll.Columns["mvalorreg"].Visible = true;
            dgvRcll.Columns["mvalorreg"].HeaderText = $"Pago {ucMoeda.tb1.Text}";

            dgvRcll.Columns["mvalorpend"].Visible = true;
            dgvRcll.Columns["mvalorpend"].HeaderText = $"Pendente {ucMoeda.tb1.Text}";
        }
        private void CreateFormasP(decimal total, decimal mtotal)
        {
            dgvFormasp2.btnAdd.PerformClick();
            if (dgvFormasp2.Grelha.CurrentRow != null)
            {
                Helper.UpdateFormasp(total, mtotal, TmpTpgf.Codmovtz, TmpTpgf.Descmovtz, "PGF", dgvFormasp2);
                UpdGridFormasp();
            }
            dgvFormasp2.Grelha.Update();
        }
        private void GetValue(DataRow r)
        {
            Helper.FillRcl(_pgfl, r, _pgf.Pgfstamp, "pgf");
            //var r2 = _pgfl.NewRow().Inicialize();
            //r2["descricao"] = r["descricao"];
            //r2["valorpreg"] = r["valorpreg"];
            //r2["valorreg"] = r["valorreg"];
            //r2["data"] = r["data"];
            //r2["Fccstamp"] = r["fccstamp"];
            //r2["Pgflstamp"] = Pbl.Stamp();
            //r2["Pgfstamp"] = _pgf.Pgfstamp;
            //r2["ValorPend"] = r["valorpreg"].ToDecimal()-r["valorreg"].ToDecimal();
            //r2["Valordoc"] = r["Valordoc"];
            ////r2["numinterno"] = r["numinterno"];
            //r2["nrdoc"] = r["nrdoc"];
            //_pgfl.Rows.Add(r2);
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
        private void dgvRcll_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRcll == null || !dgvRcll.CurrentCell.OwningColumn.Name.Equals("Origem")) return;
            if (dgvRcll.CurrentRow == null) return;
            var ccstamp = dgvRcll.CurrentRow.Cells["fccstamp"].Value.ToString();
            if (string.IsNullOrEmpty(ccstamp)) return;
            var dt = SQL.GetGenDT("facc", $" where faccstamp='{ccstamp}'", "*");
            var lista = Pbl.Usracessos.Where(x => x.Origem.Equals("tdocf")).ToList();
            if (lista.Count > 0)
            {
                var lista2 = lista.Where(linha => linha.Ver).ToList();
                if (lista2.Count > 0)
                {
                    var defa = SQL.GetField("sigla", "tdocf", "defa=1").ToString();
                    var defaCond = lista.AsEnumerable().Where(x => x.Ecran.Equals(defa.Trim())).Any(x => x.Ver.Equals(true)) ? $"sigla ='{defa}'" : $"sigla ='{lista.AsEnumerable().First(x => x.Ver.Equals(true)).Ecran.Trim()}'";

                    var fact = new FrmCp
                    {
                        Tdocfcondicao = defaCond,
                        ListaUsracessos = lista,
                        Usracessos = lista.First(),
                        Pjstamp = CLocalStamp,
                    };
                    fact.UpdateObjects(dt);
                    fact.Procurou = true;
                    fact.ShowForm(this);
                    fact.PreencheCampos(dt, 0);
                }
                else
                {
                    MsBox.Show("Desculpe exitem documentos de facturação para te. Mas sem permissão para ver!");
                }
            }
            else
            {
                MsBox.Show("Desculpa não tem acesso a documentos de facturação. contacte administrator!");
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(CLocalStamp)) return;
            //var f = new FrmReport
            //{
            //    label1 = {Text = $"Imprimir {label1.Text}"},
            //    Printstamp = CLocalStamp,
            //    Origem = "PGF",
            //    No = tbFornec.Text2,
            //    ReportName = TmpTpgf.Nomfile
            //};
            //f.ShowForm(this);
           // Imprimir.DoPrint(CLocalStamp, Inserindo, label1.Text, tbFornec.Text2, TmpTpgf.Nomfile, "PGF", this, Linguas.PT);
        }
        public void BindTdoc(DataRow tdoc, bool origem = false)
        {
            if (tdoc == null) return;
            TmpTpgf = tdoc.DrToEntity<Tpgf>();
            label1.Text = TmpTpgf.Descricao;
            SetValues();
            //gridFormasP.Refresh(TmpTpgf.Numdoc);
        }
        private void btnTdi_Click(object sender, EventArgs e)
        {

        }

        private void barraText2_Load(object sender, EventArgs e)
        {

        }
        private void btnDelLinha_Click(object sender, EventArgs e)
        {
            if (dgvRcll.CurrentRow == null) return;
            var valor = dgvRcll.CurrentRow.Cells["pago"].Value.ToDecimal();
            dgvRcll.DellLine();
            tbTotal.tb1.Text = (tbTotal.tb1.Text.ToDecimal() - valor).ToString(CultureInfo.CurrentCulture);
            dgvFormasp2.UpdateLine(valor);
        }

        private void MoedaCambio_RefreshControls()
        {
            var dt = SQL.GetDT("Cambio", "top 1 Venda", $" Moeda='{MoedaCambio.tb1.Text.Trim()}' ", "data desc");
            if (dt?.Rows.Count > 0)
            {
                tbTaxaCambio.tb1.Text = dt.Rows[0][0].ToString();
                TaxaCambio = dt.Rows[0][0].ToDecimal();
            }
            Cambiar();
        }
        private void Cambiar()
        {
            if (TaxaCambio <= 0) return;
            if (!string.IsNullOrEmpty(tbTotal.tb1.Text))
            {
                tbValCambio.tb1.Text = GetValor(tbTotal);
            }
        }
        private string GetValor(TbDefault tbDefault)
        {
            return Math.Round(tbDefault.tb1.Text.ToDecimal() / TaxaCambio, 0).ToString();
        }
        public decimal TaxaCambio { get; set; }
        public List<Usracessos> ListaUsracessos { get; set; }
        public string Trclcondicao { get; set; }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            var drl = MsBox.Show("Deseja Cancelar este pagamento? ", DResult.YesNo);
            if (drl.DialogResult != DialogResult.Yes) return;
            _pgf.Anulado = true;
            EF.Save(_pgf);
            var pgfl = dgvRcll.DataSource as DataTable;
            if (pgfl == null) return;
            foreach (var dr in pgfl.AsEnumerable())
            {
                if (dr == null) continue;
                dr["anulado"] = true;
            }
            SQL.Save(pgfl, "pgfl", !Procurou, Ctabela, CLocalStamp);
            dgvFormasp2.BindGridView(EditMode);
            UpdateInfo();
        }
        private void UpdateInfo()
        {
            if (!_pgf.Anulado) return;
            Lblcancelado.Text = @"Documento Cancelado";
            Lblcancelado.ForeColor = Color.DarkRed;
            Lblcancelado.Visible = true;
            btnGravar.Enabled = false;
        }

        private void btnAddMov_Click(object sender, EventArgs e)
        {
            dgvRcll.AddLine();
            dgvRcll.DataRowr["data"] = Pbl.SqlDate;
        }

        public void CallBrowdoc()
        {
            var cond = "";
            if (ListaUsracessos.Count > 0)
            {
                for (var i = 0; i < ListaUsracessos.Count; i++)
                {
                    if (!ListaUsracessos.ToArray()[i].Ver) continue;
                    if (i == 0)
                    {
                        cond = $"'{ListaUsracessos.ToArray()[i].Ecran}'";
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(cond))
                        {
                            cond = $"'{ListaUsracessos.ToArray()[i].Ecran}'";
                        }
                        else
                        {
                            cond = $"{cond}" + $",'{ListaUsracessos.ToArray()[i].Ecran}'";
                        }
                    }
                }
                var bw = new Browdoc
                {
                    Condicao = $" where sigla in ({cond}) ",
                    Descricao = "descricao",
                    Sigla = "sigla",
                    Tabela = "Tpgf",
                    BindTdoc = BindTdoc
                };
                bw.ShowForm(this);
                //var bw = new Browdoc
                //{
                //    Condicao = $" where sigla in ({cond}) ",
                //    Descricao = @"descricao",
                //    Sigla = @"sigla",
                //    Tabela = @"TRcl",
                //    BindTdoc = BindTdoc
                //};
                //bw.ShowForm(this, true);
            }
            else
            {
                MsBox.Show("Desculpa não tem acessos a recibos! \r\nContacte o administrator");
            }
        }

        public void UpdateObjects(DataTable dt)
        {
            if (_pgf == null)
            {
                _pgf = new Pgf();
            }
            var numdoc = dt.Rows[0]["Numdoc"].ToDecimal();
            TmpTpgf = SQL.GetRowToEnt<Tpgf>($"numdoc={numdoc}");
            label1.Text = TmpTpgf.Descricao;
            panel1.Visible = false;
            panel3.Visible = false;
        }
    }
    #endregion
   
}
