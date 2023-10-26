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
    public partial class FrmPgf2 : FrmClasse
    {
        public Pgf _pgf;
        private DataTable _pgfl;

        public decimal Total { get; private set; }
        public decimal Mtotal { get; private set; }

        private DataTable _fpdt;
        public Fnc Fnc;

        public FrmPgf2()
        {
            InitializeComponent();
        }

        private void FrmPagamento_Load(object sender, EventArgs e)
        {
            Campo1 = "Numero";
            Campo2 = "nome";
            Ctabela = "Pgf";
            BindGrid();
            TmpTpgf =SQL.GetRowToEnt<Tpgf>(" Defa = 1 ");
            SetValues();
            MultiDoc = true;
            if (Origemsssss==1)
            {
                deb.Visible = cre.Visible = tipo.Visible = true;
                label1.Text = "Encontro de Contas";
                tbFornec.label1.Text = "Cliente/Fornecedor";
            }
            if (Origemsssss != 1)
            {
                deb.Visible = cre.Visible = tipo.Visible = false;
                dgvRcll.Size = new Size(819, 157);
                dgvFormasp2.Location = new Point(5, 207);
                barraText1.Location = new Point(4, 198);
                barraText1.Size = new Size(832, barraText1.Size.Height);
                barraText1.Label1Text = "Formas de Pagamentos";
                tbFornec.label1.Text = "Fornecedor";
                dgvFormasp2.Size = new Size(832, 153);
            }
            tipo.Visible = false;
        }
        private void SetValues()
        {
            if (TmpTpgf == null) return;
            label1.Text = TmpTpgf.Descricao;
            dgvFormasp2.Movtz = true;
            Helper.ClearControls(this);
            CCondicao = $"numdoc={TmpTpgf.Numdoc} and year(data) = {Pbl.SqlDate.Year} and Ccusto='{Pbl.Usr.Ccusto.Trim()}'";
            if (TmpTpgf.Rcladiant)
            {
                btnAddMov.Visible = true;
                btnMovimentos.Visible = false;
                valordoc.ReadOnly=true;
                PorPagar.ReadOnly=true;
            }
            else
            {
                btnAddMov.Visible = false;
                btnMovimentos.Visible = true;
                valordoc.ReadOnly = false;
                PorPagar.ReadOnly = false;
            }
            
        }
        public Tpgf TmpTpgf { get; set; }

        public override void DefaultValues()
        {
            _pgf = DoAddline<Pgf>();
            CLocalStamp = _pgf.Pgfstamp;
            ucMoeda.tb1.Text = Pbl.MoedaBase;
            _pgf.Numdoc = TmpTpgf.Numdoc;
            _pgf.Nomedoc = TmpTpgf.Descricao;
            _pgf.Ccusto= Pbl.Usr.Ccusto;
            _pgf.Codmovcc = TmpTpgf.Codmovcc;
            _pgf.Descmovcc = TmpTpgf.Descmovcc;
            _pgf.Codmovtz = TmpTpgf.Codmovtz;
            _pgf.Descmovtz = TmpTpgf.Descmovtz;
            _pgf.Sigla = TmpTpgf.Sigla;
            _pgf.Rcladiant = TmpTpgf.Rcladiant;
            _pgf.Tpgfstamp = TmpTpgf.Tpgfstamp;
            tbCcusto.tb1.Text= Pbl.Usr.Ccusto;
            base.DefaultValues();
            btnGravar.Enabled = true;
            Lblcancelado.Visible = false;
            if (Origemsssss==1)
            {
                label2.Text = "";
                label2.Visible = false;
                btnGravar.Visible = true;
                btnDelete.Visible = false;
            }
        }

        private DataTable DataTableDaMemoria { get; set; }
        public override bool BeforeSave()
        {
            bool ret = true;
            if (string.IsNullOrEmpty(tbFornec.tb1.Text))
            {
                MsBox.Show("Indique o nome do fornecedor!");
                return false;
            }
            #region ANIVA ENCONTRO DE CONTAS
            if (Origemsssss == 1)
            {
                //_pgf.Obs=label2.Text;
                if (_dataTable2Fnc.HasRows())
                {
                    savou = false;
                    var ssssssss = SQL.Initialize("pgfl");
                    foreach (var r in _dataTable2Fnc.AsEnumerable())
                    {
                        DataRow drRow = ssssssss.NewRow();
                        for (int i = 0; i < ssssssss.Columns.Count; i++)
                        {
                            var nam = ssssssss.Columns[i].ColumnName.ToTrim();
                            drRow[nam] = r[nam];
                            drRow[nam] = r[nam];
                            drRow[nam] = r[nam];
                        }
                        ssssssss.Rows.Add(drRow);
                    }
                    dgvRcll.DataSource = dgvRcll.DtDS = ssssssss;
                }
            }
            #endregion
            if (!ucMoeda.tb1.Text.Trim().Equals(Pbl.MoedaBase.Trim()))
            {
                var dtfp = dgvFormasp2.Grelha.DataSource as DataTable;
                if (dtfp?.Rows.Count > 0)
                {
                    foreach (var item in dtfp.AsEnumerable())
                    {
                        var moeda=SQL.GetField("moeda","contas",$"codigo='{item["codtz"].ToDecimal()}'").ToString();
                        if (!moeda.Trim().Equals(ucMoeda.tb1.Text.Trim()))
                        {
                            MsBox.Show(Messagem.ParteInicial()+$"A conta {item["Contatesoura"]} não pode ser movimentada! A sua moeda é: {moeda}, diferente do: {ucMoeda.tb1.Text}");
                            ret=false;
                            break;
                        }
                    }
                }
            }
            if (!ret)
            {
                return false;
            }

            if (TmpTpgf.Rcladiant)
            {
                var tot1 = dgvRcll.DtDS.Sum("Valorreg").ToDecimal();
                tbTotal.tb1.Text = tot1.ToString();
            }
            var tot = ucMoeda.tb1.Text.ToLower() == Pbl.MoedaBase.ToLower() ? dgvRcll.DtDS.Sum("Valorreg").ToDecimal() : dgvRcll.DtDS.Sum("mValorreg").ToDecimal();
            var vals = GenBl.CheckTesoura(dgvFormasp2.Formaspdt,tot, true);
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
                var mvalor  = dr["mvalor"].ToDecimal();
                var conta = SQL.GetRow($"select Saldo,mSaldo,Sigla,Numero,Noneg from contas where codigo={codtz}");
                if (ucMoeda.tb1.Text.Trim().Equals(Pbl.MoedaBase))
                {
                    if (valor>conta["Saldo"].ToDecimal())
                    {
                        if (Convert.ToBoolean(conta["Noneg"]))
                        {
                            MsBox.Show($"O saldo da conta {conta["Sigla"]} {conta["Numero"]} não é suficiente para o movimento \r\n O saldo existente é: {conta["Saldo"]}");
                            ret=false; 
                            break;
                        }
                    }

                }
                else
                {
                    if (mvalor>conta["mSaldo"].ToDecimal())
                    {
                        //if (!conta["Noneg"].ToBool())
                        //{
                        //    MsBox.Show($"O saldo da conta {conta["Sigla"]} {conta["Numero"]} não é suficiente para o movimento \r\n O saldo existente é: {conta["mSaldo"]}");
                        //    ret=false;
                        //    break;
                        //}
                    }
                }
            }
            if (!ret)
            {
                return false;
            }

            if (Origemsssss != 1)
            {
                label2.Text = "";
                label2.Visible = false;
            }
            return base.BeforeSave();
        }

        public override void Save()
        {
            _pgf.Fncstamp = tbFornec.Text3;
            tbDefault3.tb1.Text = _pgf.Obs;
            FillEntity(_pgf);

            var pd = _pgf.Obs; 
          
            var dt = dgvRcll.GetBindedTable();
            if (dt.HasRows())
            {
                var total = dt.Sum("valorreg");
                var mtotal = dt.Sum("mvalorreg");
                _pgf.Mtotal = mtotal;
                _pgf.Total = total;
            }
            EF.Save(_pgf);
            GenBl.ExecAudit(_pgf, Name);
        }
        private bool savou;
        public override void AfterSave()
        {
            if (!string.IsNullOrEmpty(_pgf.Pjstamp))
            {
                Helper.Updatepj(true,_pgf.Pjstamp,"TPago","pgf","totftiva",false,true);
                SendRefresh?.Invoke(false);
            }

            var pf = _pgf.Obs;
            if (Origemsssss==1)
            {
                foreach (DataRow r in dgvRcll.DtDS.AsEnumerable())
                {
                    var qry = $@"select distinct pgfl.Pgfstamp,debito=iif(Fcc.debito=Fcc.credito,0,Fcc.debito),credito=iif(Fcc.debito=Fcc.credito,0,Fcc.credito),fcc.Fccstamp,fcc.Origem,fcc.data,fcc.documento,fcc.Rcladiant from pgfl inner join pgf 
                           on  pgfl.Pgfstamp=pgf.Pgfstamp inner join Fcc  on  Fcc.Oristamp=pgf.Pgfstamp where Fcc.Fccstamp ='{r["Fccstamp"]}' and Fcc.Origem='PGFA'";
                    var dt1 = SQL.GetGenDT(qry);
                    if (dt1.HasRows())
                    {
                        if (r["valorreg"].ToDecimal()<0)
                        {
                            r["valorreg"] = r["valorreg"].ToDecimal() * -1;
                        }
                        for (int i = 0; i < dt1.Rows.Count; i++)
                        {
                            if (dt1.Rows[i]["Origem"].ToString().TrimStart().TrimEnd().ToUpper().Equals("PGFA"))
                            {
                                SQL.SqlCmd($@"update fcc set debito=debito+{r["valorreg"].ToDecimal()},Origem='{dt1.Rows[i]["Origem"].ToString().TrimStart().TrimEnd()}',
                                              documento='{dt1.Rows[i]["documento"].ToString().TrimStart().TrimEnd()}'
                                              where Fccstamp ='{dt1.Rows[i]["Fccstamp"]}'");
                            }
                        }
                    }
                }
                if (_frmRcl!=null)
                {
                    _frmRcl.dgvFormasp2.Formaspdt.Rows.Clear();
                    var formaspclientelocal = gridFormasCliente.Formaspdt;
                    _frmRcl.dgvFormasp2.Formaspdt = formaspclientelocal;
                    _frmRcl.dgvFormasp2.Grelha.SetDataSource(_frmRcl.dgvFormasp2.Formaspdt);
                    if (_frmRcl.dgvFormasp2.Formaspdt!=null)
                    {
                        if (_frmRcl.dgvFormasp2.Formaspdt.HasRows())
                        {
                            if (!savou)
                            {
                                _frmRcl.BeforeSave();
                                _frmRcl._rcl.Obs = tbDefault3.tb1.Text;
                                _frmRcl.btnGravar_Click(_frmRcl, EventArgs.Empty);
                            }
                        }
                    }
                    _frmRcl.Close();
                }
                savou = true;
            }
        }
        public Action<bool> SendRefresh { get; set; }
        public override void PreencheCampos(DataTable dt, int i)
        {
            _pgf = FillControls(_pgf, dt, i);
            #region Encontro de contas
            if (Origemsssss == 1)
            {
                label2.Text = _pgf.Obs;
                if (!_pgf.Obs.IsNullOrEmpty())
                {
                    label2.Visible = true;
                }
                if (!dgvRcll.DtDS.Columns.Contains("tipo"))
                {
                    dgvRcll.DtDS.Columns.Add("tipo", typeof(string));
                }
                if (!dgvRcll.DtDS.Columns.Contains("deb"))
                {
                    dgvRcll.DtDS.Columns.Add("deb", typeof(decimal));
                }
                if (!dgvRcll.DtDS.Columns.Contains("cre"))
                {
                    dgvRcll.DtDS.Columns.Add("cre", typeof(decimal));
                }
                var dtr = new DataTable();
                var st = SQL.GetGen2DT("SELECT *,tipo=1,deb=0,cre=0 FROM PGFl where 1=0 union all " +
                                       "SELECT [Rcllstamp] Pgflstamp,[Rclstamp] Pgfstamp,[Ccstamp] Fccstamp,[Nrdoc],[Valorpreg]" +
                                       ",[Valorreg],'0'Status," +
                                       "[data],[descricao],[Numinterno],[Origem],[Mvalorpreg]," +
                                       "[Mvalorreg],[ValorPend],[MvalorPend],[Valordoc],[Anulado],[Cambiousd]," +
                                       "[MValordoc],[Descontofin],[MDescontofin] ," +
                                       $"[Perdescfin]  ,[Rcladiant],tipo=1,deb=Valorreg,cre=0 " +
                                       $" FROM RCLl where Rclstamp='{CLocalStamp}'");
                if (st != null)
                {
                    var ss = st.Select("tipo=1");
                    if (ss.Length > 0)
                    {
                        dtr = ss.CopyToDataTable();
                    }
                }

                if (_pgf!=null)
                {
                    SQL.SqlCmd($"update rcl set anulado='{_pgf.Anulado}' where rclstamp='{_pgf.Pgfstamp}'");

                }
                foreach (DataRow r in dgvRcll.DtDS.AsEnumerable())
                {
                    r["tipo"] = 2;
                    r["cre"] = r["valorpreg"].ToDecimal();
                    r["deb"] = 0;
                }
                if (dtr.HasRows())
                {
                    foreach (DataRow rr in dtr.AsEnumerable())
                    {
                        var ddt = dgvRcll.DtDS.NewRow();
                        foreach (DataColumn col in dgvRcll.DtDS.Columns)
                        {
                            var nam = col.ColumnName.ToLower();
                            ddt[nam] = rr[nam];
                        }
                        dgvRcll.DtDS.Rows.Add(ddt);
                    }
                }
                dgvRcll.SetDataSource(dgvRcll.DtDS) ;
                btnGravar.Visible = false;
                btnDelete.Visible = false;
            } 
            #endregion
            BindGrid();
            UpdateInfo();
            ucMoeda_RefreshControls();
            Lblcancelado.Visible = _pgf.Anulado;
        }
        public override void UpdGridFormasp()
        {
            Helper.Codmovtz(true, TmpTpgf.Codmovtz, TmpTpgf.Descmovtz, dgvFormasp2.Grelha,"pgf");
        }
        public DataTable DtFncDataTable { get; set; }
        private void btnMovimentos_Click(object sender, EventArgs e)
        {
            if (!EditMode) return;
            if (string.IsNullOrEmpty(tbFornec.tb1.Text))
            {
                MsBox.Show("Por favor indica o fornecedor!..");
                return;
            }
            var orgem = 0;
            DataTable dt;
            #region Encontro de contas
            if (Origemsssss == 1)
            {
                orgem = 1;
                var qry = $@"select* from(
                        select*, novacolun= '', tipo= 1, deb= valorpreg, cre= 0 from clccf() where clstamp= '{tbFornec.Text3}'  
                        union all 
                        select upper('Ttl CC Cl'),'','',sum(valordoc),sum(valorpreg),sum(valorreg),0,'','','','{ucMoeda.tb1.Text}',0,'','',0,'','','','','','','',tipo = 0,sum(valorpreg),cre = 0 from clccf() where clstamp = '{tbFornec.Text3}' 
                        union all 
                        select *,'',tipo = 2,deb = 0,cre = valorpreg from fncccf() where fncstamp = '{tbFornec.Text3}' 
                        union all 
                        select upper('Ttl CC Fnc'),'','',sum(valordoc),sum(valorpreg),sum(valorreg),0,'','','','{ucMoeda.tb1.Text}',0,'','',0,'','','','','','','',tipo = 0,deb = 0,cre = sum(valorpreg) from fncccf() where fncstamp = '{tbFornec.Text3}' 
                        union all 
                        select upper('Total Geral'),'','',ss = ((select - (sum(valordoc)) from fncccf() where fncstamp = '{tbFornec.Text3}' )+(select sum(valordoc) from clccf() where clstamp = '{tbFornec.Text3}' )),sum(0),sum(0),0,'','','', '{ucMoeda.tb1.Text}',0,'','',0,'','','','','','','',tipo = 0,deb = 0,cre = 0 )temp where moeda = '{ucMoeda.tb1.Text}'; ";                
                dt = SQL.GetGenDT(qry);
                for (var i = 0; i < dt.Columns.Count; i++)
                {
                    var name = dt.Columns[i].ColumnName.ToLower();
                    if (name.Equals("ccstamp"))
                    {
                        dt.Columns[i].ColumnName = "fccstamp";
                    }
                }
            } 
            #endregion
            else
            {
                dt = GenBl.GetCc(tbFornec.Text3.Trim(), "fncccf", "fnc");
            }
            if(dt==null)
            {
                MsBox.Show("Lista de movimentos vazio");
                return;
            }

            if (!string.IsNullOrEmpty(tbPj.Text3))
            {
                var dc = new DataColumn { DataType = typeof(bool), ColumnName = "exite" };
                dt.Columns.Add(dc);
                foreach (var r in dt.AsEnumerable())
                {
                    r["exite"] = SQL.CheckExist($"select top 1 faccstamp from facc where faccstamp='{r["oristamp"].ToString().Trim()}' and pjstamp='{tbPj.Text3.Trim()}'");
                }
                var dt1 = dt.AsEnumerable().Where(x => x.Field<bool>("exite").Equals(true));
                if (dt1.Any())
                {
                    dt = dt1.CopyToDataTable();
                    if (dt.HasRows())
                    {
                        dt = dt.DefaultView.ToTable(true, "descricao", "nrdoc", "data", "valordoc", "valorpreg", "valorreg",
                            "ok", "fccstamp", "origem", "oristamp", "moeda", "cambiousd");
                    }
                }
                else
                {
                    MsBox.Show("O Fornecedor não tem movimentos");
                    return;
                }
            }
            if (dt?.Rows.Count > 0)
            {
                var f = new FrmReg2 { Tabela = dt, SendData = ReceiveData, OrigemDoc = true, Origemsssss = orgem, Totaissss = TotalDescricao };
                f.btnPrint.Visible = f.btnProcessar.Visible = f.tbClienteForn.Visible = f.tbMoeda.Visible = f.Ccusto.Visible = false;
                f.gridUi1.Size = new Size(759, 462);
                f.gridUi1.Location = new Point(12, 32);
                f.tipo.Visible = f.deb.Visible = f.cre.Visible = false;
                f.ShowForm(this);
            }
            else
            {
                MsBox.Show("O Fornecedor não tem movimentos");
            }
        }
        DataTable _dataTable2Fnc;
        DataTable _dataTable1Cl;
        private decimal _totaDecimalFnc;
        decimal _totaDecimalcl;

        void TotalDescricao(string totaescricao)
        {
            label2.Text = totaescricao;
            label2.Visible = true;
            if (_pgf!=null)
            {
                _pgf.Obs = totaescricao;
                tbDefault3.Text = totaescricao;
                tbDefault3.tb1.ReadOnly = true;
            }
        }
        private DataTable _dataTablepgf = null;

      
        public void ReceiveData(DataTable dataRows)
        {
            _totaDecimalFnc = 0;
            _totaDecimalcl= 0;
            _frmRcl = null;
            Total =0;
            Mtotal=0;
            _pgfl = dgvRcll.DataSource as DataTable;
            foreach (var r in dataRows.AsEnumerable().Where(r => r != null))
            {
                GetValue(r);
            }
            if (_pgfl != null)
            {
                foreach (var r in _pgfl.AsEnumerable().Where(r => r != null))
                {
                    Total += r["valorreg"].ToDecimal();
                    Mtotal += r["mvalorreg"].ToDecimal();
                    foreach (var vaRow in dataRows.AsEnumerable().Where(rr => rr != null))
                    {
                        if (r["fccstamp"] == vaRow["fccstamp"])
                        {
                            r["cambiousd"] = vaRow["cambiousd"];
                        }
                    }
                }
                tbTotal.tb1.Text = Total.ToString();
                tbmTotal.tb1.Text = Mtotal.ToString();
            }

            if (Origemsssss == 1)
            {
                if (dataRows != null && !dataRows.Columns.Contains("mvalorreg"))
                {
                    dataRows.Columns.Add("mvalorreg", typeof(decimal));
                }
                if (!_pgfl.Columns.Contains("tipo"))
                {
                    _pgfl.Columns.Add("tipo", typeof(string));
                }


                if (!_pgfl.Columns.Contains("deb"))
                {
                    _pgfl.Columns.Add("deb", typeof(decimal));
                }
                if (!_pgfl.Columns.Contains("cre"))
                {
                    _pgfl.Columns.Add("cre", typeof(decimal));
                }
                if (!_pgfl.Columns.Contains("moeda"))
                {
                    _pgfl.Columns.Add("moeda", typeof(string));
                }
                foreach (var r in dataRows.AsEnumerable().Where(r => r != null))
                {
                    for (int i = 0; i < _pgfl.Rows.Count; i++)
                    {
                        if (_pgfl.Rows[i]["fccstamp"].ToString().Equals(r["fccstamp"].ToString()))
                        {
                            r["mvalorreg"] = _pgfl.Rows[i]["mvalorreg"].ToDecimal();
                            _pgfl.Rows[i]["tipo"] = r["tipo"].ToString();
                            _pgfl.Rows[i]["deb"] = r["deb"].ToString();
                            _pgfl.Rows[i]["cre"] = r["cre"].ToString();
                            _pgfl.Rows[i]["moeda"] = r["moeda"].ToString();
                        }
                    }
                }
                if (_pgfl != null)
                {
                    var sssss = _pgfl.Select("tipo=2");
                    if (sssss.Length > 0)
                    {
                        Total = 0;
                        Mtotal = 0;
                        var sssssssss = sssss.CopyToDataTable();
                        Total = sssssssss.Sum("valorreg").ToDecimal();
                        Mtotal = sssssssss.Sum("mvalorreg").ToDecimal();
                        tbTotal.tb1.Text = Total.ToString();
                        tbmTotal.tb1.Text = Mtotal.ToString();
                        DataTableDaMemoria = dataRows;
                        var dt2 = sssssssss;
                        _dataTable2Fnc = dt2;
                        _dataTable2Fnc.TableName = "pgfl";
                        _totaDecimalFnc += _dataTable2Fnc.Compute("sum(cre)", string.Empty).ToDecimal();
                    }
                    var dt1 = _pgfl.Select("tipo=1");

                    if (dt1.Length > 0)
                    {
                           _dataTable1Cl = dt1.CopyToDataTable();
                           _dataTable1Cl.TableName = "rcll";
                        _totaDecimalcl += _dataTable1Cl.Compute("sum(deb)", string.Empty).ToDecimal();
                        var lista = Pbl.Usracessos.Where(x => x.Origem.Equals("TRcl")).ToList();
                        if (_dataTable1Cl!=null)
                        {
                            if (lista.AsEnumerable().Any(x => x.Ver.Equals(true)))
                            {
                                foreach (var r in _dataTable1Cl.AsEnumerable().Where(r => r != null))
                                {
                                    for (int i = 0; i < _pgfl.Rows.Count; i++)
                                    {
                                        if (_pgfl.Rows[i]["fccstamp"].ToString().Equals(r["fccstamp"].ToString()))
                                        {
                                            r["mvalorreg"] = _pgfl.Rows[i]["mvalorreg"].ToDecimal();
                                            _pgfl.Rows[i]["tipo"] = r["tipo"].ToString();
                                        }
                                    }
                                }

                                decimal TTotal = 0;
                                decimal MMtotal = 0;
                                if (_pgfl != null)
                                {
                                    var ssssss = _pgfl.Select("tipo=1");
                                    if (ssssss.Length > 0)
                                    {
                                        var ssssssssrs = _dataTable1Cl;
                                        TTotal = ssssssssrs.Sum("valorreg").ToDecimal();
                                        MMtotal = ssssssssrs.Sum("mvalorreg").ToDecimal();
                                        tbTotal.tb1.Text = Total.ToString();
                                        tbmTotal.tb1.Text = Mtotal.ToString();
                                    }
                                }

                                foreach (var r in _dataTable1Cl.AsEnumerable().Where(r => r != null))
                                {
                                    for (int i = 0; i < dgvRcll.Rows.Count; i++)
                                    {
                                        if (r["fccstamp"].ToString()
                                            .Equals(dgvRcll.Rows[i].Cells["fccstamp"].Value.ToString()))
                                        {
                                            dgvRcll.Rows[i].Cells["deb"].Value = r["deb"].ToString();
                                            dgvRcll.Rows[i].Cells["cre"].Value = r["cre"].ToString();
                                            dgvRcll.Rows[i].Cells["tipo"].Value = r["tipo"].ToString();
                                        }
                                    }
                                }

                                for (int i = 0; i < _dataTable1Cl.Columns.Count; i++)
                                {
                                    var name = _dataTable1Cl.Columns[i].ColumnName.ToLower();
                                    if (name.Equals("fccstamp"))
                                    {
                                        _dataTable1Cl.Columns[i].ColumnName = "ccstamp";
                                    }

                                    if (name.Equals("pgfstamp"))
                                    {
                                        _dataTable1Cl.Columns[i].ColumnName = "rclstamp";
                                    }

                                    if (name.Equals("pgflstamp"))
                                    {
                                        _dataTable1Cl.Columns[i].ColumnName = "rcllstamp";
                                    }
                                }

                                var defa = SQL.GetField("sigla", "TRcl", "defa=1").ToString();
                                var defaCond =
                                    lista.AsEnumerable().Where(x => x.Ecran.Equals(defa.Trim()))
                                        .Any(x => x.Ver.Equals(true))
                                        ? $"sigla ='{defa}'"
                                        : $"sigla ='{lista.AsEnumerable().First(x => x.Ver.Equals(true)).Ecran.Trim()}'";
                                var b = new FrmRcl
                                {
                                    Trclcondicao = defaCond,
                                    ListaUsracessos = lista.ToList(),
                                    OrigemEncontroContas = 1,
                                    DataTable1Cl = _dataTable1Cl,
                                    Total = TTotal,
                                    Mtotal = MMtotal
                                };
                                b._cl = SQL.GetRowToEnt<Cl>($"Clstamp='{tbFornec.Text3.Trim()}'");// EF.GetEnt<Cl>(x => x.Clstamp.Equals(tbFornec.Text3));
                                b.Usracessos = lista.FirstOrDefault();
                                if (!CheckOpened(this.Name))
                                {
                                    b.ShowForm(this);
                                }
                                else
                                {
                                    b.Show();
                                }
                                b.btnNovo.PerformClick();
                                b.Cliente.tb1.Text = tbFornec.tb1.Text;
                                b.Cliente.Text2 = tbFornec.Text2;
                                b.Cliente.Text3 = tbFornec.Text3;
                                b.CLocalStamp = CLocalStamp;
                                b._rcl.Rclstamp = CLocalStamp;
                                b._rcl.Nome = b.Cliente.tb1.Text;
                                b.ucMoeda.tb1.Text = ucMoeda.tb1.Text;
                                b.ucMoeda.Text2 = ucMoeda.Text2;
                                b.ucMoeda.Text3 = ucMoeda.Text3;
                                b.MoedaCambio.tb1.Text = MoedaCambio.tb1.Text;
                                b.MoedaCambio.Text2 = MoedaCambio.Text2;
                                b.MoedaCambio.Text3 = MoedaCambio.Text3;
                                foreach (var r in _dataTable1Cl.AsEnumerable().Where(r => r != null))
                                {
                                    r["Rclstamp"] = b._rcl.Rclstamp;
                                }
                                b.OrigemPgf = 1;
                                _dataTable1Cl.TableName = "Rcll";
                                var tot = _dataTable1Cl.Sum("valorreg").ToDecimal();
                                var mtot = _dataTable1Cl.Sum("mvalorreg").ToDecimal();
                                _dataTable1Cl.AcceptChanges();
                                b.GridFormasCliente = gridFormasCliente;
                                b.tbTotal.tb1.Text = tot.ToString();
                                b.tbmTotal.tb1.Text = mtot.ToString();
                                b.Frm = this;
                                //b.dgvRcll.SetDataSource(_dataTable1Cl);
                                b.ReceiveData(_dataTable1Cl);
                                b.CreateFormasP(tot.ToDecimal(), mtot.ToDecimal(), gridFormasCliente);
                                var ds = gridFormasCliente.Formaspdt;
                                var ddd = b.dgvFormasp2.Formaspdt;
                                b.FromEncontroContas = 1;
                                _frmRcl = b;
                                b.Hide();
                            }
                        }
                    }

                }
            }
            if (Mtotal>0)
            {
                ucMoeda.tb1.Text =dataRows.AsEnumerable().FirstOrDefault()["moeda"].ToString() ;
                ShowFormaspMoedas();
            }
            dgvRcll.DataSource = null;
            dgvRcll.DataSource = _pgfl;
            if (Origemsssss==1)
            {

                if (dataRows!=null)
                {
                    foreach (var r in dataRows.AsEnumerable().Where(r => r != null))
                    {
                        for (int i = 0; i < dgvRcll.Rows.Count; i++)
                        {
                            if (r["fccstamp"].ToString().Equals(dgvRcll.Rows[i].Cells["fccstamp"].Value.ToString()))
                            {
                                dgvRcll.Rows[i].Cells["deb"].Value = r["deb"].ToString();
                                dgvRcll.Rows[i].Cells["cre"].Value = r["cre"].ToString();
                                dgvRcll.Rows[i].Cells["tipo"].Value = r["tipo"].ToString();
                            }
                        }
                    } 
                }
            }
            CreateFormasP(Total.ToDecimal(),Mtotal.ToDecimal());
           
            Helper.UpdateFormaspMoeda(dgvFormasp2, ucMoeda.tb1.Text);
            Helper.UpdateFormaspMoeda(gridFormasCliente, ucMoeda.tb1.Text);
            dgvFormasp2.Grelha.Update();
            var texto = label2.Text;
        }

        public string Totaescricao { get; set; }

        private bool CheckOpened(string name)
        {
            var fc = Application.OpenForms;
            return fc.Cast<Form>().Any(frm => frm.Name == name);
        }
        private FrmRcl _frmRcl { get; set; }
        private void ShowFormaspMoedas()
        {
            dgvFormasp2.Grelha.Columns["mvalor"].Visible=true;
            dgvFormasp2.Grelha.Columns["mvalor"].HeaderText=$"Valor {ucMoeda.tb1.Text}";
            dgvRcll.Columns["mvalordoc"].Visible=true;
            dgvRcll.Columns["mvalordoc"].HeaderText=$"Valor Doc. {ucMoeda.tb1.Text}";
            dgvRcll.Columns["mvalorpreg"].Visible=true;
            dgvRcll.Columns["mvalorpreg"].HeaderText=$"Por Pagar {ucMoeda.tb1.Text}";
            dgvRcll.Columns["mvalorreg"].Visible=true;
            dgvRcll.Columns["mvalorreg"].HeaderText=$"Pago {ucMoeda.tb1.Text}";
            dgvRcll.Columns["mvalorpend"].Visible=true;
            dgvRcll.Columns["mvalorpend"].HeaderText=$"Pendente {ucMoeda.tb1.Text}";
        }
        private void CreateFormasP(decimal total, decimal mtotal)
        {
            dgvFormasp2.btnAdd.PerformClick();
            if (dgvFormasp2.Grelha.CurrentRow != null)
            {
                Helper.UpdateFormasp(total,mtotal,TmpTpgf.Codmovtz,TmpTpgf.Descmovtz,"PGF",dgvFormasp2);
                UpdGridFormasp();
            }
            dgvFormasp2.Grelha.Update();
        }
       

        private void GetValue(DataRow r)
        {
            Helper.FillRcl(_pgfl, r,_pgf.Pgfstamp,"pgf");
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

            if (dgvRcll == null || dgvRcll.CurrentCell==null)
            {
                return;
            }
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
                    MsBox.Show("Desculpe existem documentos de facturação para te. Mas sem permissão para ver!");
                }
            }
            else
            {
                MsBox.Show("Desculpa não tem acesso a documentos de facturação. contacte administrator!");
            }
           
        }

        private FrmReport _f;
        void ImprimirEncontrodeContas()
        {
            if (!Inserindo)
            {
                if (!CLocalStamp.IsNullOrEmpty())
                {
                    DS ds = new DS();
                    Imprimir.CallForm(ds.Encontro, null, CLocalStamp, Inserindo, label1.Text, tbFornec.Text2, TmpTpgf.ReportXml, "Encontro", this, TmpTpgf.XmlString2, true, ds, "", "");
                }
                else
                {
                    Messagem.DoNothingPrintMensagem();
                }
            }
            else
            {
                Messagem.DoDontPrintMessagem();
            }
        }
       
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (Origemsssss==1)
            {
                ImprimirEncontrodeContas();
            }
            else
            {
                DS ds = new DS();
                var Rcll = dgvRcll.GetBindedTable();
                var formasp = dgvFormasp2.Grelha.DataSource as DataTable;
                var ret = Imprimir.FillData(_pgf.ToDataTable(), Rcll, formasp, ds.Pgf, ds.Formasp);
                Imprimir.CallForm(ret.dtPrint, ret.fp, CLocalStamp, Inserindo, label1.Text, tbFornec.Text2, TmpTpgf.Nomfile, "PGF", this, TmpTpgf.XmlString, true, ds, "", "");
                //Imprimir.DoPrint(CLocalStamp, Inserindo, label1.Text, tbFornec.Text2, TmpTpgf.Nomfile, "PGF", this, Linguas.PT, TmpTpgf.XmlString);
            }
        }
        public void BindTdoc(DataRow tdoc, bool origem = false)
        {
            if (tdoc == null) return;
            TmpTpgf = tdoc.DrToEntity<Tpgf>();
            label1.Text = TmpTpgf.Descricao;
            SetValues();
        }
        private void btnTdi_Click(object sender, EventArgs e)
        {
            if (Procurou && Lista == null)
            {
                CallBrowdoc();
            }
            else
            {
                if (Inserindo)
                {
                    var res = MsBox.Show("Deseja Trocar do Documento ?", DResult.YesNo);
                    if (res.DialogResult == DialogResult.Yes)
                    {
                        LimparCampos2();
                        ClearDataGridView();

                        EstadoDaTela(AccaoNaTela.Padrao);
                        errorProvider1.Clear();
                        Cancelar();
                        CallBrowdoc();
                    }
                }
                else
                {
                    CallBrowdoc();
                }
            }
        }

        private void barraText2_Load(object sender, EventArgs e)
        {

        }
        private void btnDelLinha_Click(object sender, EventArgs e)
        {
            if (dgvRcll.CurrentRow == null) return;
            var valor = dgvRcll.CurrentRow.Cells["valorreg"].Value.ToDecimal();
            dgvRcll.DellLine();         
            tbTotal.tb1.Text = (tbTotal.tb1.Text.ToDecimal() - valor).ToString(CultureInfo.CurrentCulture);
            dgvFormasp2.UpdateLine(valor);
        }

        private void MoedaCambio_RefreshControls()
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
                tbValCambio.tb1.Text = GetValor(tbTotal);
            }
        }
        private string GetValor(TbDefault tbDefault)
        {
            TaxaCambio = SQL.ExecCambio(ucMoeda.tb1.Text.Trim());
            if (TaxaCambio.IsZero())
            {
                return "";
            }
            return Math.Round(tbDefault.tb1.Text.ToDecimal() / TaxaCambio,(int)Pbl.Param.Aredondamento).ToString();
        }
        public decimal TaxaCambio { get; set; }
        public List<Usracessos> ListaUsracessos { get; set; }
        public string Trclcondicao { get; set; }

        public int Origemsssss
        {
            get;
            set;
        } = 0;

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
            SQL.Save(pgfl, "pgfl",!Procurou,Ctabela,CLocalStamp);

            if (Origemsssss==1)
            {
                SQL.SqlCmd($"update rcl set anulado='{_pgf.Anulado}'" +
                           $" where rclstamp='{_pgf.Pgfstamp}'");
                SQL.Save(pgfl, "rcll", !Procurou, "rcl", CLocalStamp);
            }
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
            dgvRcll.Columns["valorreg"].ReadOnly = false;
        }
        public void CallBrowdoc()
        {
            if (ListaUsracessos == null)
            {
                ListaUsracessos = Pbl.Usracessos;
            }
            var cond = "";
            if (ListaUsracessos!=null)
            {
                if ( ListaUsracessos.Count > 0)
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
                }
                else
                {
                    MsBox.Show("Desculpa não tem acessos a recibos! \r\nContacte o administrator");
                }
            }
        }
        public void UpdateObjects(DataTable dt)
        {
            if (_pgf==null)
            {
                _pgf = new Pgf(); 
            }
            var numdoc = dt.Rows[0]["Numdoc"].ToDecimal();
            TmpTpgf = SQL.GetRowToEnt<Tpgf>( $"numdoc={numdoc}");
            label1.Text = TmpTpgf.Descricao;
            panel1.Visible = false;
            panel3.Visible = false;
        }
        private void dgvRcll_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (Origemsssss ==2)
            {
                if (dgvRcll == null) return;
                var cell = dgvRcll[dgvRcll.Columns["tipo"].Index, e.RowIndex];
                if (cell.Value.ToString().Equals("1"))
                {
                    e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                    e.CellStyle.ForeColor = Color.BlueViolet;
                }
                if (cell.Value.ToString().Equals("2"))
                {
                    e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                    e.CellStyle.ForeColor = Color.Blue;
                }
                if (cell.Value.ToString().Equals("0"))
                {
                    e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                    e.CellStyle.ForeColor = Color.Crimson;
                }
            }
        }
        private void FrmPgf2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_frmRcl!=null)
            {
                if (EditMode)
                {
                    EditMode=false;
                }
                if (_frmRcl.EditMode)
                {
                    _frmRcl.EditMode = false;
                }
                _frmRcl.Close();
            }
        }
        private void dgvRcll_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (TmpTpgf.Rcladiant)
            {
                SetFaccl("Referenc");
                if (dgvFormasp2.Grelha.Rows.Count == 0)
                {
                    dgvFormasp2.btnAdd.PerformClick();
                }
                if (dgvFormasp2.Grelha.CurrentRow != null)
                {
                    dgvFormasp2.Grelha.CurrentRow.Cells["valor"].Value = total1;
                    dgvFormasp2.Grelha.CurrentRow.Cells["mvalor"].Value = mtotal1;
                    dgvFormasp2.Grelha.CurrentRow.Cells["Dcheque"].Value = Pbl.SqlDate;
                    dgvFormasp2.Grelha.CurrentRow.Cells["Codmovtz"].Value = TmpTpgf.Codmovtz;
                    dgvFormasp2.Grelha.CurrentRow.Cells["Descmovtz"].Value = TmpTpgf.Descmovtz;
                    Helper.Codmovtz(true, TmpTpgf.Codmovtz, TmpTpgf.Descmovtz, dgvFormasp2.Grelha, "Pgf");
                }
                dgvFormasp2.Grelha.Update();
            }
        }
        private decimal total1, mtotal1 = 0;

        private void btnDuplicar_Click(object sender, EventArgs e)
        {
            dmzOptions.ShowMenuStrip(btnDuplicar);
        }
        private void importarFacturaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Helper.ChamaformImport("pgf", "pgfl", "", "Pagamentos");
           var dt = SQL.GetGen2DT("select Numdoc,Descricao from tpgf order by Numdoc");
            Helper.ChamaformImport("pgf", "pgfl", "", "Pagamentos",null,dt);
        }
        private void ucMoeda_RefreshControls()
        {
            if (ucMoeda.tb1.Text.ToLower().Equals(Pbl.MoedaBase.ToLower()))
            {
                Helper.SetColunas(true, dgvRcll,dgvFormasp2, ucMoeda);
                if (Origemsssss != 1)
                {
                    gridFormasCliente.Grelha.Columns["mvalor"].Visible = false;
                    gridFormasCliente.Grelha.Columns["Valor"].Visible = true;
                }
            }
            else
            {
                Helper.SetColunas(false, dgvRcll, dgvFormasp2, ucMoeda);
                if (Origemsssss == 1)
                {
                    gridFormasCliente.Grelha.Columns["mvalor"].Visible = true;
                    gridFormasCliente.Grelha.Columns["Valor"].Visible = false;
                }
            }
        }
        private void SetFaccl(string campo)
        {
            var nome = dgvRcll.CurrentCell.OwningColumn.Name.ToLower();
            if (nome.Equals("valorreg"))
            {
                if (dgvRcll.CurrentCell?.Value == null) return;
                dgvRcll.CurrentRow.Cells["valordoc"].Value = dgvRcll.CurrentCell?.Value;
                dgvRcll.CurrentRow.Cells["PorPagar"].Value = dgvRcll.CurrentCell?.Value;
                dgvRcll.CurrentCell.Value = dgvRcll.CurrentCell.Value.ToString().Trim();
                var valor = dgvRcll.CurrentCell.Value.ToString().Trim();

            }
            if (dgvRcll.DtDS.HasRows())
            {
                total1 = dgvRcll.DtDS.Sum("valorreg").ToDecimal();
                mtotal1 = dgvRcll.DtDS.Sum("mvalorreg").ToDecimal();
            }
            else
            {
                mtotal1 = total1 = 0;
            }
          

        }
    }
}
