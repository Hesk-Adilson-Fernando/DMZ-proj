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
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using DMZ.UI.Reports;
using DMZ.UI.UC;

namespace DMZ.UI.UI
{
    public partial class FrmRcl : FrmClasse
    {
        public FrmRcl()
        {
            InitializeComponent();
        }
        #region ANIVA ENCONTRO DE CONTAS
        public int OrigemEncontroContas { get; set; }
        public DataTable DataTable1Cl { get; set; }
        public GridFormasP GridFormasCliente { get; set; }
        public FrmPgf2 Frm { get; set; }
        #endregion

        public RCL _rcl;
        private DataTable _rcll;
        public List<Usracessos> ListaUsracessos { get; set; }
        private void FrmRecibo_Load(object sender, EventArgs e)
        {
            Loads();
        }
        public void Loads()
        {
            Campo1 = "Numero";
            Campo2 = "nome";
            Ctabela = "Rcl";
            OrderByCampos = "convert(decimal,Numero)";
            BindGrid();
            _tmpTRcl = SQL.GetRowToEnt<TRcl>(Trclcondicao);
            SetValues();
            tbTotal.tb1.TextChanged += TB1OnTextChanged;
            MultiDoc = true;
        }
        private void SetValues()
        {
            if (_tmpTRcl == null) return;
            label1.Text = _tmpTRcl.Descricao;
            dgvFormasp2.Movtz = true;
            CCondicao = $"numdoc={_tmpTRcl.Numdoc} and year(data) = {Pbl.SqlDate.Year} ";
            Helper.ClearControls(this);
            if (_tmpTRcl.Rcladiant)
            {
                btnAddMov.Visible = true;
                btnMovimentos.Visible = false;
            }
            else
            {
                btnAddMov.Visible = false;
                btnMovimentos.Visible = true;
            }
            dgvRcll.Columns["Doc"].ReadOnly = !_tmpTRcl.Rcladiant;
            dgvRcll.Columns["valordoc"].ReadOnly = !_tmpTRcl.Rcladiant;
            dgvRcll.Columns["Nrdocu"].ReadOnly = !_tmpTRcl.Rcladiant;
        }
        private void TB1OnTextChanged(object sender, EventArgs e)
        {
            Cambiar();
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
        public TRcl _tmpTRcl;
        public Cl _cl;

        public override void DefaultValues()
        {
            _rcl = DoAddline<RCL>();

            //var m = EF.QEnt<Moedas>( " princip = 1 ");
            ucMoeda.tb1.Text = Pbl.MoedaBase;
            //ucMoeda.Text2 = m.Descricao.Trim();
            _rcl.Numdoc = _tmpTRcl.Numdoc;
            _rcl.Nomedoc = _tmpTRcl.Descricao;
            _rcl.Ccusto = Pbl.Usr.Ccusto;           
            _rcl.Codmovcc = _tmpTRcl.Codmovcc;
            _rcl.Descmovcc = _tmpTRcl.Descmovcc;
            _rcl.Sigla = _tmpTRcl.Sigla;
            _rcl.Codmovtz = _tmpTRcl.Codmovtz;
            _rcl.Descmovtz = _tmpTRcl.Descmovtz;
            _rcl.Rcladiant = _tmpTRcl.Rcladiant;
            _rcl.Pjstamp = tbPj.Text3;
            _rcl.TRclstamp = _tmpTRcl.TRclstamp;
            tbCcusto.tb1.Text = Pbl.Usr.Ccusto;
            CLocalStamp = _rcl.Rclstamp;
            base.DefaultValues();
            BindGrid();
            Lblcancelado.Visible = false;
            btnGravar.Enabled = true;
            tbNumero.IsReadOnly = !Pbl.Usr.AlteraNumero;
            _rcl.Usrstamp = Pbl.Usr.Usrstamp;
        }

        public override bool BeforeSave()
        {
            if (Pbl.Param.Usacademia)
            {
                if (_tmpTRcl.Rcladiant)
                {
                    if (tbCurso.tb1.Text.IsNullOrEmpty())
                    {
                        MsBox.Show("O curso não pode estar vazio, veja na página ACADEMIA");
                        return false;
                    }
                    if (tbTurma.tb1.Text.IsNullOrEmpty())
                    {
                        MsBox.Show("A Turma não pode estar vazio, veja na página ACADEMIA");
                        return false;
                    }
                }
            }
            if (tbTotal.tb1.Text.ToDecimal()< 0)
            {
                MsBox.Show("Não se pode  gravar recibo com valor negativo, verifique!");
                return false;
            }
            if (string.IsNullOrEmpty(Cliente.tb1.Text))
            {
                MsBox.Show("Indique o nome do Cliente!");
                return false;
            }
            var dtfp = dgvFormasp2.Grelha.DataSource as DataTable;
            if (dtfp.HasRows())
            {
                if (dtfp?.Rows.Count==1 && dtfp.AsEnumerable().Any(x=>x.RowState==DataRowState.Deleted))
                {
                    MsBox.Show("Não pode gravar a conta já foi eliminada!");
                    return false;
                }
                if (!MoedasDiferentes(dtfp)) return false;
                var tot = ucMoeda.tb1.Text.ToLower()==Pbl.MoedaBase.ToLower() ? dgvRcll.DtDS.Sum("Valorreg").ToDecimal() : dgvRcll.DtDS.Sum("mValorreg").ToDecimal();
                var vals = GenBl.CheckTesoura(dgvFormasp2.Formaspdt, tot,true);
                if (!vals.Correcto)
                {
                    MsBox.Show(vals.Messagem);
                    return false;
                }
                var dtRcll = dgvRcll.DataSource as DataTable;
                if (!dtRcll.HasRows())
                {
                    MsBox.Show("Não pode gravar recibo sem linhas do recibo, por favor verifique!.");
                    return false; 
                }
                if (_tmpTRcl.Rcladiant)
                {
                    tbTotal.tb1.Text = tot.ToString();
                }
                return base.BeforeSave();
            }
            return false;
        }

        private bool MoedasDiferentes(DataTable dtfp)
        {
            var ret = true;
                        if (dtfp?.Rows.Count > 0)
                        {
                            foreach (var item in dtfp.AsEnumerable())
                            {
                                if (item.RowState== DataRowState.Deleted) continue;
                                if (item["codtz"].ToDecimal()>0)
                                {
                                    var ff = SQL.GetField("moeda", "contas", $"codigo='{item["codtz"].ToDecimal()}'");
                        var moeda = ff == null ? $"MZN" : ff.ToString();
                        //var moeda=SQL.GetField("moeda","contas",$"codigo='{item["codtz"].ToDecimal()}'").ToString();
                                    if (!moeda.Trim().Equals(ucMoeda.tb1.Text.Trim()))
                                    {
                                        MsBox.Show($"A conta {item["Contatesoura"]} não pode receber o valor! A sua moeda é: {moeda}, diferente do: {ucMoeda.tb1.Text}");
                                        ret=false;
                                        break;
                                    }
                                }
                                else
                                {
                                        MsBox.Show($"Deve indicar a conta de movimento nas formas de pagamento!");
                                }

                            }
                        }
                    return ret;
        }

        public override void Save()
        {
            FillEntity(_rcl);
            var dt = dgvRcll.GetBindedTable();
            if (dt.HasRows())
            {
                var total = dt.Sum("valorreg");
                var mtotal = dt.Sum("mvalorreg");
                _rcl.Mtotal = mtotal;
                _rcl.Total = total;
            }
            //_rcl.Mtotal=tbmTotal.tb1.Text.ToDecimal();
            var xx=EF.Save(_rcl);
            if (xx.ret==-1)
            {
                MsBox.Show(xx.msg);
                return;
            }
            GenBl.ExecAudit(_rcl, Name);
        }

        public override void AfterSave()
        {
            if (!string.IsNullOrEmpty(_rcl.Pjstamp))
            {
                Helper.Updatepj(true,_rcl.Pjstamp,"TRecebido","RCL","totftiva",false,true);
                SendRefresh?.Invoke(false);
            }
        }
        public Action<bool> SendRefresh { get; set; }

        public override void PreencheCampos(DataTable dt, int i)
        {
            _rcl = FillControls(_rcl, dt, i);
            if (_rcl!=null)
            {
                _cl = SQL.GetRowToEnt<Cl>($"Clstamp='{_rcl.Clstamp.Trim()}'");
                BindGrid();
                if (_rcl.Anulado)
                {
                    UpdateInfo();
                    btnGravar.Enabled = false;
                    btnGravar.BackColor = Color.FromArgb(39, 59, 80);
                }
                else
                {
                    Lblcancelado.Visible = false;
                }
                if (!_rcl.Moeda.Trim().Equals(Pbl.MoedaBase))
                {
                    ShowFormaspMoedas();
                }
            }
        }

        private void UpdateInfo()
        {
            Lblcancelado.Text = @"Documento Cancelado";
            Lblcancelado.ForeColor = Color.DarkRed;
            Lblcancelado.Visible = true;
        }

        private DataTable _dt;

        private void btnMovimentos_Click(object sender, EventArgs e)
        {
            if (!EditMode) return;
            if (string.IsNullOrEmpty(Cliente.tb1.Text))
            {
                MsBox.Show("Por favor indica o cliente!..");
                return;
            }
            _dt = _tmpTRcl.Especial ?  GenBl.GetCc(Cliente.Text3.Trim(),"clcce","cl") : GenBl.GetCc(Cliente.Text3.Trim(),"clccf","cl");
            var dc2 = new DataColumn { DataType = typeof(bool), ColumnName = "Ok2" };
            _dt.Columns.Add(dc2);
            if (!string.IsNullOrEmpty(tbPj.Text3))
            {
                var dc = new DataColumn {DataType = typeof(bool), ColumnName = "exite"};
                _dt.Columns.Add(dc);
                foreach (var r in _dt.AsEnumerable())
                {
                    r["exite"] = SQL.CheckExist($"select top 1 factstamp from fact where factstamp='{r["oristamp"].ToString().Trim()}' and pjstamp='{tbPj.Text3.Trim()}'");
                }
                var dttemp = _dt.AsEnumerable().Where(x => x.Field<bool>("exite").Equals(true));
                if (dttemp.Any())
                {
                    _dt = dttemp.CopyToDataTable();
                }
                else
                {
                    MsBox.Show("O Cliente não tem movimentos");
                    return;
                }
            }
            if (_dt.HasRows())
            {
                var f = new FrmReg {Tabela = _dt, SendData = ReceiveData, OrigemDoc = true};
                f.ShowForm(this);
            }
            else
            {
                MsBox.Show("O Cliente não tem movimentos");
            }
        }

        public void ReceiveData(DataTable dataRows)
        {
            //dgvRcll
            _rcll = dgvRcll.DataSource as DataTable;
            if (dataRows != null)
                Total = 0;
            Mtotal = 0;
            foreach (var r in dataRows.AsEnumerable().Where(r => r != null))
            {
                GetValue(r);
            }
            if (_rcll != null)
            {
                foreach (var r in _rcll.AsEnumerable().Where(r => r != null))
                {
                    Total += r["valorreg"].ToDecimal();
                    Mtotal += r["mvalorreg"].ToDecimal();
                }

                if (Total<0)
                {
                    tbTotal.tb1.Text = (-1*Total).ToString();
                }
                else
                {

                    tbTotal.tb1.Text = Total.ToString();
                }
                tbmTotal.tb1.Text = Mtotal.ToString();
            }
            if (Mtotal > 0)
            {
                ucMoeda.tb1.Text = dataRows.AsEnumerable().FirstOrDefault()["moeda"].ToString();
                if (GridFormasCliente != null)
                {
                    ShowFormaspMoedas(GridFormasCliente);
                }
                ShowFormaspMoedas();
            }
            dgvRcll.SetDataSource(_rcll);
            CreateFormasP(Total.ToDecimal(), Mtotal.ToDecimal());
            Helper.UpdateFormaspMoeda(dgvFormasp2, ucMoeda.tb1.Text);
            dgvFormasp2.Grelha.Update();
        }
        public override void UpdGridFormasp()
        {
            Helper.Codmovtz(true, _tmpTRcl.Codmovtz, _tmpTRcl.Descmovtz, dgvFormasp2.Grelha,"Rcl");
        }
        public void CreateFormasP(decimal total, decimal mtotal, GridFormasP gdView = null)
        {
            if (gdView != null)
            {
                if (!gdView.Grelha.HasRows())
                {
                    gdView.btnAdd.PerformClick();
                }
                if (gdView.Grelha.CurrentRow != null)
                {
                    gdView.Grelha.CurrentRow.Cells["valor"].Value = total;
                    gdView.Grelha.CurrentRow.Cells["mvalor"].Value = mtotal;
                    gdView.Grelha.CurrentRow.Cells["Dcheque"].Value = Pbl.SqlDate;
                    gdView.Grelha.CurrentRow.Cells["Codmovtz"].Value = _tmpTRcl.Codmovtz;
                    gdView.Grelha.CurrentRow.Cells["Descmovtz"].Value = _tmpTRcl.Descmovtz;//UsrLogin
                    gdView.Grelha.CurrentRow.Cells["UsrLogin"].Value = Pbl.Usr.Usrstamp; //
                    gdView.Grelha.CurrentRow.Cells["Moeda"].Value = ucMoeda.tb1.Text; //
                    if (_cl == null)
                    {
                        SetValores(gdView);
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(_cl.Tesouraria))
                        {
                            gdView.Grelha.CurrentRow.Cells["contatesoura"].Value = _cl.Tesouraria;
                            gdView.Grelha.CurrentRow.Cells["Codtz"].Value = _cl.Codtz; //Contasstamp
                            gdView.Grelha.CurrentRow.Cells["Contasstamp"].Value = _cl.Contasstamp;
                        }
                        else
                        {
                            SetValores(gdView);
                        }
                    }

                    Helper.Codmovtz(true, _tmpTRcl.Codmovtz, _tmpTRcl.Descmovtz, gdView.Grelha, "Rcl");
                    //UpdGridFormasp();
                }
                gdView.Grelha.Update();
            }
            else
            {
                if (!dgvFormasp2.Grelha.HasRows())
                {
                    dgvFormasp2.btnAdd.PerformClick();
                }
                if (dgvFormasp2.Grelha.CurrentRow != null)
                {
                    dgvFormasp2.Grelha.CurrentRow.Cells["valor"].Value = total;
                    dgvFormasp2.Grelha.CurrentRow.Cells["mvalor"].Value = mtotal;
                    dgvFormasp2.Grelha.CurrentRow.Cells["Dcheque"].Value = Pbl.SqlDate;
                    dgvFormasp2.Grelha.CurrentRow.Cells["Codmovtz"].Value = _tmpTRcl.Codmovtz;
                    dgvFormasp2.Grelha.CurrentRow.Cells["Descmovtz"].Value = _tmpTRcl.Descmovtz;
                    dgvFormasp2.Grelha.CurrentRow.Cells["UsrLogin"].Value = Pbl.Usr.Usrstamp; //
                    dgvFormasp2.Grelha.CurrentRow.Cells["Contasstamp"].Value = Pbl.Usr.Contasstamp;
                    dgvFormasp2.Grelha.CurrentRow.Cells["Codtz"].Value = Pbl.Usr.Codtz; //Contasstamp//
                    if (_cl == null)
                    {
                        SetValores();
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(_cl.Tesouraria))
                        {
                            dgvFormasp2.Grelha.CurrentRow.Cells["contatesoura"].Value = _cl.Tesouraria;
                            dgvFormasp2.Grelha.CurrentRow.Cells["Codtz"].Value = _cl.Codtz; //Contasstamp
                            dgvFormasp2.Grelha.CurrentRow.Cells["Contasstamp"].Value = _cl.Contasstamp;
                        }
                        else
                        {
                            SetValores();
                        }
                    }
                    UpdGridFormasp();
                }
                dgvFormasp2.Grelha.Update();
            }
        }

        private void SetValores(GridFormasP gridFormas = null)
        {
            if (gridFormas != null)
            {
                gridFormas.Grelha.CurrentRow.Cells["contatesoura"].Value = Pbl.Usr.ContaTesoura;
                gridFormas.Grelha.CurrentRow.Cells["Codtz"].Value = Pbl.Usr.Codtz;
                gridFormas.Grelha.CurrentRow.Cells["Contasstamp"].Value = Pbl.Usr.Contasstamp.Trim();
            }
            else
            {
                dgvFormasp2.Grelha.CurrentRow.Cells["contatesoura"].Value = Pbl.Usr.ContaTesoura;
                dgvFormasp2.Grelha.CurrentRow.Cells["Codtz"].Value = Pbl.Usr.Codtz;
                dgvFormasp2.Grelha.CurrentRow.Cells["Contasstamp"].Value = Pbl.Usr.Contasstamp.Trim();
            }
        }

        private void GetValue(DataRow r)
        {
            Helper.FillRcl(_rcll, r,_rcl.Rclstamp,"rcl");
        }
        public static void FillRcl1(DataTable rcll, DataRow r, string rclstamp, string tabela)
        {
            var r2 = rcll.NewRow();
            if (!r["moeda"].ToString().Equals(Pbl.MoedaBase.Trim()))
            {
                if (r["Cambiousd"].ToDecimal().IsZero())
                {
                    r["Cambiousd"] = SQL.ExecCambio($"{r["moeda"]}");
                }
            }
            var cambiousd = r["Cambiousd"].ToDecimal();
            if (r["moeda"].ToString().Equals(Pbl.MoedaBase.Trim()))
            {
                r2["valorpreg"] = r["valorpreg"];
                r2["valorreg"] = r["valorreg"];
                r2["ValorPend"] = r["valorpreg"].ToDecimal() - r["valorreg"].ToDecimal();
                r2["Valordoc"] = r["Valordoc"];
            }
            else
            {
                //var mdoc = r["mValordoc"].ToDecimal();
                //if (r["mValordoc"].ToDecimal()!=0 && r["Valordoc"].ToDecimal() == 0)
                //{
                //    r["Valordoc"] = mdoc * cambiousd;
                //}
                //if (r["mvalorpreg"].ToDecimal() != 0 && r["valorpreg"].ToDecimal() == 0)
                //{
                //    r["valorpreg"] = r["mvalorpreg"].ToDecimal() * cambiousd;
                //}
                //if (r["mValorPend"].ToDecimal() != 0 && r["ValorPend"].ToDecimal() == 0)
                //{
                //    r["ValorPend"] = r["mValorPend"].ToDecimal() * cambiousd;
                //}
                //if (r["mvalorreg"].ToDecimal() != 0 && r["valorreg"].ToDecimal() == 0)
                //{
                //    r["valorreg"] = r["mvalorreg"].ToDecimal() * cambiousd;
                //}
                //var ss = r["Valordoc"].ToDecimal();
                //r2["Valordoc"] = r["Valordoc"].ToDecimal();
                //ss = r["valorpreg"].ToDecimal();
                //r2["valorpreg"] = r["valorpreg"].ToDecimal();
                //ss = r["valorpreg"].ToDecimal();
                //r2["valorreg"] = r["valorreg"].ToDecimal();
                //ss = r["valorreg"].ToDecimal();
                //r2["ValorPend"] = (r["valorpreg"].ToDecimal() - r["valorreg"].ToDecimal()).ToDecimal();
                ////
                //r2["mvalorpreg"] = r["valorpreg"].ToDecimal() / cambiousd;
                //r2["mvalorreg"] = r["valorreg"].ToDecimal() / cambiousd;
                //r2["mValorPend"] = (r["valorpreg"].ToDecimal() - r["valorreg"].ToDecimal()).ToDecimal() / cambiousd;
                //r2["mValordoc"] = r["Valordoc"];






                r2["Valordoc"] = r["Valordoc"].ToDecimal() * cambiousd;
                r2["valorpreg"] = r["valorpreg"].ToDecimal() * cambiousd;
                r2["valorreg"] = r["valorreg"].ToDecimal() * cambiousd;
                r2["ValorPend"] = (r["valorpreg"].ToDecimal() - r["valorreg"].ToDecimal()).ToDecimal() * cambiousd;
                //
                r2["mvalorpreg"] = r["valorpreg"];
                r2["mvalorreg"] = r["valorreg"];
                r2["mValorPend"] = r["valorpreg"].ToDecimal() - r["valorreg"].ToDecimal();
                r2["mValordoc"] = r["Valordoc"];
            }
            r2["descricao"] = r["descricao"];
            r2["data"] = r["data"];
            if (tabela.ToLower().Equals("rcl"))
            {
                r2["Ccstamp"] = r["Ccstamp"];
            }
            else
            {
                r2["fccstamp"] = r["fccstamp"];
            }
            r2[$"{tabela.Trim()}lstamp"] = Pbl.Stamp();
            r2[$"{tabela.Trim()}stamp"] = rclstamp;
            r2["Rcladiant"] = r["Rcladiant"];
            r2["nrdoc"] = r["nrdoc"];
            rcll.Rows.Add(r2);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var retorno = Imprimir.Valido(Usracessos, Cliente.tb1.Text);
            if (retorno.Imprimir)
            {
                DS ds = new DS();
                var Rcll = dgvRcll.GetBindedTable();
                var formasp = dgvFormasp2.Grelha.DataSource as DataTable;
                var ret = Imprimir.FillData(_rcl.ToDataTable(), Rcll, formasp, ds.Rcl, ds.Formasp);
                Imprimir.RepreencherCl(ret, _cl);
                Imprimir.CallForm(ret.dtPrint, ret.fp, CLocalStamp, Inserindo, label1.Text, Cliente.Text2, _tmpTRcl.Nomfile, "RCL", this, _tmpTRcl.XmlString, true, ds,"","");
            }
            else
            {
                MsBox.Show(retorno.Messagem);
            }
        }

        private void PrintDocument(Linguas Lingua)
        {
            //Imprimir.DoPrint(CLocalStamp,Inserindo,label1.Text,Cliente.Text2,_tmpTRcl.Nomfile,"RCL",this,Lingua, _tmpTRcl.XmlString);
        }

        private void btnDelLinha_Click(object sender, EventArgs e)
        {
            if (dgvRcll.CurrentRow == null) return;
            var valor = dgvRcll.CurrentRow.Cells["valorreg"].Value.ToDecimal();
            var mvalor = dgvRcll.CurrentRow.Cells["mvalorpreg"].Value.ToDecimal();
            var ccstamp= dgvRcll.CurrentRow.Cells["localstamp"].Value.ToString().Trim();
            dgvRcll.DellLine();         
            tbTotal.tb1.Text = (tbTotal.tb1.Text.ToDecimal() - valor).ToString(CultureInfo.CurrentCulture);
            tbmTotal.tb1.Text = (tbmTotal.tb1.Text.ToDecimal() - mvalor).ToString(CultureInfo.CurrentCulture);
            dgvFormasp2.UpdateLine(valor);
            //if (Procurou)
            //{
            //   // SQL.SqlCmd($"update cc set debitof =debitof-{valor} where ccstamp='{ccstamp}'");
            //}
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            var drl = MsBox.Show("Deseja Cancelar este Recibo? ", DResult.YesNo);
            if (drl.DialogResult != DialogResult.Yes) return;
            _rcl.Anulado = true;
            EF.Save(_rcl);
            var rcll = dgvRcll.DataSource as DataTable;
            if (rcll == null) return;
            foreach (var dr in rcll.AsEnumerable())
            {
                if (dr == null) continue;
                dr["anulado"] = true;
            }
            SQL.Save(rcll, "rcll",!Procurou,Ctabela,_rcl.Rclstamp);
            dgvFormasp2.BindGridView(EditMode);
            UpdateInfo();
        }

        private void dgvRcll_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRcll.CurrentCell.OwningColumn.Name.ToLower().Trim().Equals("origem"))
            {
                Helper.CallForm("fact","FrmFt",dgvRcll,this,ListaUsracessos);
            }           
        }

        private void moedaCambio_RefreshControls()
        {
            var dt = SQL.GetDT("Cambio", "top 1 Venda", $" Moeda='{MoedaCambio.tb1.Text.Trim()}' ", "data desc");
            if (dt?.Rows.Count>0)
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
                tbmTotal.tb1.Text = GetValor(tbTotal);
            }
        }

        private string GetValor(TbDefault tbDefault)
        {
            return Math.Round(tbDefault.tb1.Text.ToDecimal() / TaxaCambio,0).ToString();
        }
        public decimal TaxaCambio { get; set; }
        public string Trclcondicao { get; set; }
        public decimal Total { get;  set; }
        public decimal Mtotal { get;  set; }
        public int FromEncontroContas { get; internal set; }

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
            var cond = "";
            if (ListaUsracessos.Count>0)
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
                    Descricao = @"descricao",
                    Sigla = @"sigla",
                    Tabela = @"TRcl",
                    BindTdoc = BindTdoc
                };
                bw.ShowForm(this, true);
            }
            else
            {
                MsBox.Show("Desculpa não tem acessos a recibos! \r\nContacte o administrator");
            }
        }
        public void BindTdoc(DataRow tdoc, bool origem = false)
        {
            if (tdoc == null) return;
            _tmpTRcl = tdoc.DrToEntity<TRcl>();
            SetValues();
        }

        public void UpdateObjects(DataTable dt)
        {
            if (_rcl==null)
            {
                _rcl = new RCL(); 
            }
            if (dt?.Rows.Count>=0)
            {
                var numdoc = dt.Rows[0]["Numdoc"].ToDecimal();
                _tmpTRcl = SQL.GetRowToEnt<TRcl>($"numdoc={numdoc}"); 
            }
            label1.Text = _tmpTRcl.Descricao;
            panel1.Visible = false;
            panel3.Visible = false;
        }

        public void Cliente_RefreshControls()
        {
            _cl = SQL.GetRowToEnt<Cl>($"clstamp='{Cliente.Text3.Trim()}'");
            if (_cl !=null)
            {
                tbCurso.tb1.Text = _cl.Curso;
                tbCurso.Text2 = _cl.Codcurso;
            }
        }

        private void btnAddMov_Click(object sender, EventArgs e)
        {
            dgvRcll.AddLine();
            dgvRcll.DataRowr["data"] = Pbl.SqlDate;
            dgvRcll.Columns["valordoc"].ReadOnly = false;
            dgvRcll.Columns["PorPagar"].ReadOnly = false;
            dgvRcll.Columns["valorreg"].ReadOnly = false;
            if (dgvRcll.CurrentRow != null) dgvRcll.CurrentRow.Cells["Rcladiant"].Value = true;
        }
        private void dgvFormasp2_Load(object sender, EventArgs e)
        {

        }
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            PrintDocument(Linguas.PT);
        }

        private void nToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument(Linguas.EN);
        }

        private void ucMoeda_RefreshControls()
        {
            if (!string.IsNullOrEmpty(ucMoeda.tb1.Text))
            {
                if (!ucMoeda.tb1.Text.Equals(Pbl.MoedaBase))
                {
                     ShowFormaspMoedas();
                }
                Helper.UpdateFormaspMoeda(dgvFormasp2,ucMoeda.tb1.Text);
            }
        }

        private void ShowFormaspMoedas(GridFormasP dFormasP = null)
        {
            if (dFormasP == null)
            {
                Helper.SetColunas(false, dgvRcll, dgvFormasp2, ucMoeda);
            }
            else
            {
                Helper.SetColunas(false, Frm.dgvRcll, Frm.dgvFormasp2, Frm.ucMoeda);
            }
        }


        private void nORMALDIRECTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // ReportHelper.PrintReport(CLocalStamp,true,_tmpTRcl.Nomfile);
        }

        private void btnPrdtProcurment_Click(object sender, EventArgs e)
        {

        }

        private void btnDuplicar_Click(object sender, EventArgs e)
        {
            dmzOptions.ShowMenuStrip(btnDuplicar);
        }

        private void importarFacturaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            var dt = SQL.GetGen2DT("select Numdoc,Descricao from trcl order by Numdoc");
            Helper.ChamaformImport("rcl", "rcll", "", "Recibos",null,dt);
            //Helper.ChamaformImport("fact", "factl", "", "Facturacao", null, dt);
        }

        private void tbTurma_RefreshControls()
        {
            tbAnosem.tb1.Text = tbTurma.Text3;
            tbEtapa.tb1.Text = tbTurma.Text4;
        }
    }
}
