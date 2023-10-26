using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using DMZ.UI.Reports;
using DMZ.UI.UI.PRC;


namespace DMZ.UI.UI
{
    public partial class FrmCp : FrmClasse
    {
        public FrmCp()
        {
            InitializeComponent();
        }
        public Tdocf TmpTdoc;
        public DataTable DtArm { get; set; }
        public DataRow DataRow { get; set; }
        public bool LRunStk { get; set; }
        private Facc _facc;
        public Fnc Cl;
        private DataTable fnc;
        private Fnc _fnc;
        private List<Usracessos> lista;
        public string Pjstamp { get; set; } = "";
        public DataTable DtSt { get; private set; }

        public void BindTdoc(DataRow tdoc, bool origem = false)
        {
            if (tdoc == null) return;
            TmpTdoc = tdoc.DrToEntity<Tdocf>();
            SetValues(TmpTdoc);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!EditMode) return;
            if (!string.IsNullOrEmpty(tbFornec.tb1.Text))
            {
                if (DtArtigos != null)
                {
                    DtSt = DtArtigos;
                    var qry = $"select* from (select quant =" +
                              $" isnull((select top 1  pl.Quant " +
                              $" from faccl fl join facc fc on fl.Faccstamp = " +
                              $" fc.Faccstamp where fl.ststamp = pl.ststamp " +
                              $" and Pjstamp = '{Pjstamp}' " +
                              $"and pl.fncstamp='{tbFornec.Text3}'" +
                              $"), pl.Quant),Descricao,pl.Ref," +
                              $"pl.Nome, pl.Preco,pl.Procurmlstamp,pl.Txiva," +
                              $"pl.Tabiva,pl.Perdesc,pl.Descontol,pl.Ivainc,pl.Factura,pl.No,pl.Fncstamp,pl.Ststamp" +
                              $" from Procurml pl where Procurmstamp = '{Pjstamp}' " +
                              $"and pl.fncstamp='{tbFornec.Text3}') " +
                              $"temp";
                    var dtst = SQL.GetGenDT(qry);
                    var dc = new DataColumn { DataType = typeof(bool), ColumnName = "ok" };
                    dtst.Columns.Add(dc);
                    var dc2 = new DataColumn { DataType = typeof(bool), ColumnName = "facturado" };
                    dtst.Columns.Add(dc2);

                    var dc3 = new DataColumn { DataType = typeof(string), ColumnName = "familia" };
                    dtst.Columns.Add(dc3);
                    foreach (var r in dtst.AsEnumerable())
                    {
                        r["ok"] = false;
                        r["facturado"] = true;
                        var _qrt = $"select top 1 isnull(iif(Familia='','Não definida',Familia),'Não definida') Familia from st where ststamp='{r["ststamp"].ToString().Trim()}'";
                        var dtfam = SQL.GetGenDT(_qrt);
                        if (dtfam.Rows.Count > 0)
                        {
                            r["familia"] = dtfam.Rows[0][0].ToString();
                        }
                        else
                        {
                            r["familia"] = "Não definida";
                        }
                    }
                    var bw = new FrmAddArtigos1
                    {
                        SendData = ReceiveDt2
                    };
                    bw.BindiGrid(dtst);
                    bw.ShowForm(this, true);
                }
            }
        }
        private void ReceiveDt2(DataTable dt)
        {
            foreach (var r in dt.AsEnumerable())
            {
                if (r == null) continue;
                dmzGridButtons1.btnNovo.PerformClick();
                var ss = r["preco"];
                
                var qry = $"select Ststamp,Referenc,Descricao from st where ststamp='{r["ststamp"]}'";
                var dt1 = SQL.GetGenDT(qry);
                var valor = r["ststamp"].ToString().Trim();
                var dr = dt1.AsEnumerable().
                    FirstOrDefault(s => s.Field<string>("ststamp").Trim()
                        .Equals(valor));
                if (dr != null)
                    Addline(dr["Ststamp"].ToString().Trim());
                DataRow["ref"] = r["ref"];
                DataRow["ststamp"] = r["ststamp"];
                DataRow["Descricao"] = r["Descricao"];
                DataRow["quant"] = r["quant"];
                DataRow["preco"] = r["preco"];
                DataRow["oristampl"] = r[$"Procurmlstamp"];
                DataRow["Txiva"] = r["Txiva"];
                DataRow["Tabiva"] = r["Tabiva"];
                DataRow["Perdesc"] = r["Perdesc"];
                DataRow["Descontol"] = r["Descontol"];
                DataRow["Ivainc"] = r["Ivainc"];//
                GenBl.TotaisLinhas(DataRow);
            }
            gridUIFt1.Update();
            Helper.TotaisFt(gridUIFt1.DsDt, this);
        }

        private void SetValues(Tdocf tmpTdocf)
        {
            label1.Text = tmpTdocf.Descricao;
            Helper.ClearControls(this);
            gridFormasP1.Refresh(TmpTdoc.Numdoc);
            gridFormasP1.Movtz = tmpTdocf.Movtz;
            panelPaneReembolso.Visible = tmpTdocf.Nc;
            panelAprovaPagamento.Visible = tmpTdocf.Usaprovacao;
            Checkfactura();
            //panelFornecedor.Visible = tmpTdocf.Vd;
            CCondicao = $"numdoc={tmpTdocf.Numdoc} and year(data) = {Pbl.SqlDate.Year} and Ccusto='{Pbl.Usr.Ccusto.Trim()}'";
            Helper.MostraCentroNaLinha(gridUIFt1);
        }
        private void Checkfactura()
        {
            if (TmpTdoc.Ft)
            {
                btnAnular.Visible = true;
                btnDelete.Visible = false;
            }
            else
            {
                btnAnular.Visible = false;
                btnDelete.Visible = true;
                btnDelete.Enabled = true; 
            }
            if (!TmpTdoc.Vd) return;
            btnAnular.Visible = false;
            btnDelete.Enabled = false;
        }
        public bool OrigReserva { get; set; }
        private void FrmCompra_Load(object sender, EventArgs e)
        {
            Campo1 = "Numero";
            Campo2 = "Nome";
            Ctabela = "facc";
            TmpTdoc = SQL.GetRowToEnt<Tdocf>(Tdocfcondicao);//EF.QEnt<Tdocf>(Tdocfcondicao);
            SetValues(TmpTdoc);
            gridFormasP1.BindGridView(EditMode);
            MultiDoc = true;
            tbNumero.IsReadOnly = !Pbl.Usr.AlteraNumero;
            gridUIFt1.Columns["Refornec"].Visible = Pbl.Param.Mostrarefornec;
        }

       private void MostraProdutosDoFornecedor()
        {
            btnPrdtProcurment.PerformClick();
        }

        private DataTable DtArtigos { get; set; }
        public void Produtos(DataTable dt)
        {
            DtArtigos = dt;
            var camposfnc = new[]
            {
                "no","Nome","fncstamp","ok","facturado","familia"
            };
            var fnc = dt.DefaultView.ToTable(true, camposfnc).
                AsEnumerable().CopyToDataTable();
            var bw = new FrmAddFnc
            {
                SendData = ReceiveDt,
                CarregarProdutos= MostraProdutosDoFornecedor
            };
            bw.label1.Text = "Marcação de fornecedor".ToUpper();
            bw.BindiGrid(fnc);
            bw.ShowForm(this, true);
        }
        private void ReceiveDt(DataTable dt)
        {
            foreach (var r in dt.AsEnumerable())
            {
                if (r == null) continue;
                tbFornec.tb1.Text = r["nome"].ToString();
                tbFornec.Text2 = r["no"].ToString();
                tbFornec.Text3 = r["fncstamp"].ToString();
                //dmzGridButtons1.btnNovo.PerformClick();
                //DataRow["ref"] = r["ref"];
                //DataRow["ststamp"] = r["ststamp"];
                //DataRow["Descricao"] = r["Descricao"];
                //DataRow["quant"] = r["quant"];
                //DataRow["preco"] = r["preco"];
                //DataRow["oristampl"] = r[$"{dt.Columns[4].ColumnName}"];
                //DataRow["Txiva"] = r["Txiva"];
                //DataRow["Tabiva"] = r["Tabiva"];
                //DataRow["Perdesc"] = r["Perdesc"];
                //DataRow["Descontol"] = r["Descontol"];
                //DataRow["Ivainc"] = r["Ivainc"];//
                //GenBl.TotaisLinhas(DataRow);
            }
            //if (TmpTdocf.Movtz)
            //{
            //    Helper.VendaDiheiro(gridUIFt1.DsDt, this, 2);
            //    UpdGridFormasp();
            //}
            //gridUIFt1.Update();
            //Helper.TotaisFt(gridUIFt1.DsDt, this);
        }
        //public void Produtos(DataTable dt)
        //{
        //    var bw = new FrmAddArtigos
        //    {
        //        SendData = ReceiveDt
        //    };
        //    bw.BindiGrid(dt);
        //    bw.ShowForm(this, true);

        //}

        //private void ReceiveDt(DataTable dt)
        //{
        //    if (!ucMoeda.tb1.Text.Trim().Equals(Pbl.MoedaBase))
        //    {
        //        TaxaCambio = SQL.ExecCambio(ucMoeda.tb1.Text);
        //        MoedaCambio.tb1.Text = Pbl.MoedaBase;
        //        tbTaxaCambio.tB1.Text = TaxaCambio.ToString();
        //        Helper.ShowHideMoedaColumns(true, ucMoeda.tb1.Text.Trim(), gridUIFt1);
        //    }
        //    foreach (var r in dt.AsEnumerable())
        //    {
        //        if (r == null) continue;
        //        dmzGridButtons1.btnNovo.PerformClick();
        //        DataRow["ref"] = r["ref"];
        //        DataRow["Descricao"] = r["Descricao"];
        //        DataRow["quant"] = r["quant"];
        //        DataRow["preco"] = r["preco"];
        //        DataRow["oristampl"] = r["Pjescstamp"];
        //        DataRow["Txiva"] = r["Txiva"];
        //        DataRow["Tabiva"] = r["Tabiva"];
        //        DataRow["Perdesc"] = r["Perdesc"];
        //        DataRow["Descontol"] = r["Descontol"];
        //        DataRow["Ivainc"] = r["Ivainc"];//
        //        if (!ucMoeda.tb1.Text.Trim().Equals(Pbl.MoedaBase))
        //        {
        //            DataRow["Cambiousd"] = TaxaCambio;
        //            DataRow["mpreco"] = r["preco"];
        //            DataRow["preco"] = r["preco"].ToDecimal() * TaxaCambio;
        //        }
        //        GenBl.TotaisLinhas(DataRow);
        //    }
        //    if (TmpTdoc.Movtz)
        //    {
        //        Helper.VendaDiheiro(gridUIFt1.DsDt, this, TmpTdoc.Sigla);
        //        UpdGridFormasp();
        //    }
        //    gridUIFt1.Update();
        //    Helper.TotaisFt(gridUIFt1.DsDt, this);
        //}

        public override void DefaultValues()
        {
            _facc = DoAddline<Facc>();
            Noneg = TmpTdoc.Noneg;
            _facc.Sigla = TmpTdoc.Sigla;
            _facc.Numdoc = TmpTdoc.Numdoc;
            _facc.Nomedoc = TmpTdoc.Descricao;
            _facc.Codmovstk = TmpTdoc.Codmovstk;
            _facc.Descmovstk = TmpTdoc.Descmovstk;
            _facc.Movtz = TmpTdoc.Movtz;
            _facc.Movstk = TmpTdoc.Movstk;
            _facc.Movcc = TmpTdoc.Movcc;
            _facc.Nc = TmpTdoc.Nc;
            _facc.Vd = TmpTdoc.Vd;
            _facc.Nd = TmpTdoc.Nd;
            _facc.Ft = TmpTdoc.Ft;
            _facc.Tdocfstamp = TmpTdoc.Tdocfstamp;
            _facc.Pjstamp = tbPj.Text3;
            dtVencimento.dt1.Value = Pbl.GetDate(30);
            _facc.Descmovcc = TmpTdoc.Descmovcc;
            _facc.Codmovcc = TmpTdoc.Codmovcc;
            _facc.Encomenda = OrigReserva;
            _facc.Usrstamp = Pbl.Usr.Usrstamp;
            Helper.SetCCustoMoeda(tbCcusto, ucMoeda);
            base.DefaultValues();
            dtVencimento.dt1.Value = Pbl.GetDate((int)TmpTdoc.Dias);
            if (TmpTdoc.Usaprovacao)
            {
                if (Pbl.Usr.AprovaPagamento)
                {
                    tbAprodador.Text2 = Pbl.Usr.Numero.ToString();
                    tbAprodador.tb1.Text = Pbl.Usr.Nome;
                }
            }
            Helper.ShowHideMoedaColumns(false,"",gridUIFt1);
            tbNumero.IsReadOnly=!Pbl.Usr.AlteraNumero;        
        }
        public void NewGridLine()
        {
            DataRow = Helper.NewGridRow(this);
        }
        public override bool CheckDelete()
        {
            var tmpChk = SQL.GetGen2DT($"Select fccstamp from pgfl where fccstamp = '{_facc.Faccstamp.Trim()}'");
            if (!(tmpChk?.Rows.Count > 0)) return true;
            MsBox.Show("Desculpe mas este documento já foi regularizado.Obrigado");
            return false;
        }
        public override void Save()
        {
            FillEntity(_facc);
            EF.Save(_facc);
            if (TmpTdoc.Ft || TmpTdoc.Nc || TmpTdoc.Vd)
            {
                GenBl.ExecAudit(_facc, Name);
            }
        }
        public override bool BeforeSave()
        {
            _facc.Data = dtFact.dt1.Value;
            #region Actualiza o Stamp do cl nas linhas 
            if (TmpTdoc.Movstk)
            {
                Helper.UpdateLinhas(gridUIFt1,_facc.Fncstamp);
                var ret =Helper.CheckStstamp(gridUIFt1);
                if (!ret.ret)
                {
                    MsBox.Show(ret.ms);
                    return false;
                }
            }
            #endregion
            #region Verifica se tem stamp na linha se for produto 

            #endregion
            #region Verifica se a factura é fazia ou igual a zero ou nao

            if (TmpTdoc.Ft || TmpTdoc.Vd || TmpTdoc.Nd)
            {
                if (tbTotal.tb1.Text.ToDecimal()<=0)
                {
                    MsBox.Show("Os Documentos: \r\nFactura\r\nVenda a Dinheiro\r\nNota de débito\r\nNão podem gravar com valor zero");
                    return false;
                }
            }

            #endregion

            #region Verificação de Stock dos produtos a serem facturados 
            var values = GenBl.CheckStock(_facc, gridUIFt1.DsDt, TmpTdoc.Usalote);
            if (!values.StkExiste)
            {
                MsBox.Show(values.Messagem);
                return false;
            }
            #endregion
            var vals = GenBl.CheckTesoura(gridFormasP1.Formaspdt, tbTotal.tb1.Text.ToDecimal(), _facc.Movtz);
            if (!vals.Correcto)
            {
                MsBox.Show(vals.Messagem);
                return false;
            }
            if (TmpTdoc.Nc)
            {
                if (!cbNcMovcc.cb1.Checked && !cbNcMovtz.cb1.Checked )
                {
                    MsBox.Show(Messagem.ParteInicial()+"Deve indicar o tipo de reenbolso ");
                    return false;
                }

                if (cbNcMovtz.cb1.Checked)
                {
                    if (gridFormasP1.Grelha.Rows.Count==0)
                    {
                        MsBox.Show(Messagem.ParteInicial()+"Deve indicar o pagamento");
                        return false;
                    }
                }
            }
            if (cbAprovado.cb1.Checked)
            {
                if (Pbl.Usr.AprovaPagamento)
                {
                    if (Pbl.Usr.ValorMaxPagamento < tbTotal.tb1.Text.ToDecimal())
                    {
                        MsBox.Show($"O Usuário: {Pbl.Usr.Nome} não autorizar o valor acima do seu parametro!");
                        return false;
                    }
                }
                else
                {
                    MsBox.Show($"O Usuário: {Pbl.Usr.Nome} não tem permissão de aprovar compras!");
                    return false;
                }
            }
            return base.BeforeSave();
        }

        public override void AfterSave()
        {
            if (TmpTdoc.Ft || TmpTdoc.Vd)
            {
                var dt = gridUIFt1.GetBindedTable();
                if (dt.HasRows())
                {
                    if (Pbl.Param.Actualizapreco)
                    {
                        if (Pbl.Param.Perlucro>0)
                        {
                            if (dt != null)
                            {
                                foreach (var r in dt.AsEnumerable())
                                {
                                    if (r == null) continue;
                                    var preco = r["preco"].ToDecimal();
                                    var precovenda = preco + preco * Pbl.Param.Perlucro / 100;
                                    UpdateDbase(precovenda, preco, r["ststamp"].ToString(), Pbl.Param.Perlucro);
                                }
                            }
                        }
                        else
                        {
                            MsBox.Show(Messagem.ParteInicial() +
                                       "Deve indicar percentagem do lucro nos parametros de gestão,\r\nApercentagem nao pode ser zerro!");
                        }
                    }

                    if (SQL.CheckExist("select sigla from EmpresaMod where sigla='IMB'"))
                    {
                        foreach (var r in dt.AsEnumerable())
                        {
                            if (!r["activo"].ToBool()) continue;
                            var activo = SQL.GetRowToEnt<St2>($"ststamp='{r["Ststamp"].ToString().Trim()}'"); 
                            if (activo == null) continue;
                            activo.ValAquis = r["preco"].ToDecimal();
                            activo.Quantdep = r["preco"].ToDecimal();
                            activo.Valdepact = r["preco"].ToDecimal();
                            activo.ValAquisact = r["preco"].ToDecimal();
                            activo.ValFiscal = r["preco"].ToDecimal();
                            activo.Data = dtFact.dt1.Value;
                            activo.Datain = dtFact.dt1.Value;
                            activo.Valquantesc = r["preco"].ToDecimal();
                            activo.Nrelement = r["quant"].ToDecimal();

                            activo.Origem = TmpTdoc.Sigla;
                            activo.Oristamp = CLocalStamp;
                            activo.Moeda = ucMoeda.tb1.Text;
                            activo.Cambio = tbTaxaCambio.tb1.Text.ToDecimal();
                            EF.Save(activo, "ststamp");
                        }
                    }
                }
            }
            if (!string.IsNullOrEmpty(_facc.Pjstamp))
            {
                Helper.Updatepj(TmpTdoc.Lancacustopj,_facc.Pjstamp,"TotComp","facc","TotCompIva",true);
                SendRefresh?.Invoke(false);
            }
            base.AfterSave();
        }

        private void UpdateDbase(decimal precovenda, decimal preco, string referenc, decimal perc)
        {
            SQL.SqlCmd($@"update StPrecos set PrecoCompra =Convert(decimal,{preco}), preco =Convert(decimal,{precovenda}), Perc=Convert(decimal,{perc}) where 
                                        Ststamp ='{referenc}'");
        }

        private void UpdateDatabase(decimal precovenda, decimal preco,string referenc,decimal factor)
        {
            var per = factor.ToString().Substring(2,2).ToDecimal();
            SQL.SqlCmd($@"update StPrecos set PrecoCompra =Convert(decimal,{preco}), preco =Convert(decimal,{precovenda}), Perc=Convert(decimal,{per}) where 
                                        Ststamp =(select Ststamp from st where Referenc='{referenc}') and ltrim(rtrim(CCusto))='{_facc.Ccusto.Trim()}'");
        }

        public override void PreencheCampos(DataTable dt, int i)
        {
            _facc = FillControls(_facc, dt, i);
            gridFormasP1.BindGridView(EditMode);
            tbDesconto.tb1.Text.SetMask();
            tbSubTotal.tb1.Text.SetMask();
            tbTotal.tb1.Text.SetMask();
            tbTotalIva.tb1.Text.SetMask();
            if (!Pbl.Usr.AprovaPagamento) return;
            tbAprodador.Text2 = Pbl.Usr.Numero.ToString();
            tbAprodador.tb1.Text = Pbl.Usr.Nome;
            if (_facc.Movtz)
            {
                gridFormasP1.Refresh(2);
                
            }

            tbDesconto.tb1.Text = _facc.Desconto.ToString().SetMask();
            tbSubTotal.tb1.Text = _facc.Subtotal.ToString().SetMask();
            tbTotal.tb1.Text = _facc.Total.ToString().SetMask();
            tbTotalIva.tb1.Text = _facc.Totaliva.ToString().SetMask();

            tbDescontoMoeda.tb1.Text = _facc.Mdesconto.ToString().SetMask();
            tbSuttotalMoeda.tb1.Text = _facc.Msubtotal.ToString().SetMask();
            tbtotalMoeda.tb1.Text = _facc.Mtotal.ToString().SetMask();
            tbIvaMoeda.tb1.Text = _facc.Mtotaliva.ToString().SetMask();
        }
        public override void Addline(string referenc)
        {
            if (!Procurou)
            {
                var tmpFound = SQL.GetRowToEnt<St>($"Ststamp='{referenc.Trim()}'");  //EF.GetEnt<St>(p=>p.Ststamp.Trim().Equals($"{referenc.Trim()}"));

                GenBl.SetLineValues(DataRow, tmpFound,_facc,true,null,TmpTdoc.Nc,ucMoeda.tb1.Text,MoedaCambio.tb1.Text.Trim(),tbFornec.Text3);
                //*----------------
                GenBl.TotaisLinhas(DataRow);
                if (tmpFound.Composto)
                {
                    DataRow["composto"] = tmpFound.Composto;
                    GenBl.ArtigoCompost(tmpFound, gridUIFt1.DsDt, _facc);
                }
            }
            else
            {
                if (gridUIFt1.CurrentRow != null)
                {
                    DataRow = ((DataRowView) gridUIFt1.CurrentRow.DataBoundItem).Row;
                    GenBl.TotaisLinhas(DataRow);
                }
            }
            //*----------------
            gridUIFt1.Update();
            Helper.TotaisFt(gridUIFt1.DsDt, this);
            Helper.VendaDiheiro(gridUIFt1.DsDt, this,TmpTdoc.Sigla,ucMoeda.tb1.Text);
            UpdGridFormasp();
        }

        public override void UpdGridFormasp()
        {
            Helper.Codmovtz(TmpTdoc.Movtz,TmpTdoc.Codmovtz,TmpTdoc.Descmovtz,gridFormasP1.Grelha,"facc");
        }
        private void btnTdi_Click(object sender, EventArgs e)
        {
           // MenuLateral.ShowMenuStrip(btnTdi);
            if (Procurou && Lista == null)
            {
                CallBrowdoc();
            }
            else
            {
                EditMode=false;
                Procurou=false;
                CallBrowdoc();
                //if (!EditMode)
                //{
                //    CallBrowdoc();
                //}
                //else
                //{
                //    MsBox.Show("O formulário está em modo de edição. Porfavor Grave");
                //}
            }
        }
        public void CallBrowdoc(bool origem = false)
        {
            //var lista = ((DemoMdi)ParentForm)?.Usracessos.Where(x=>x.Origem.Equals("tdocf"));
            var cond = "";
            for (var i = 0; i < ListaUsracessos.Count; i++)
            {
                if (!ListaUsracessos.ToArray()[i].Ver) continue;
                if (i==0)
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
                        cond = $"{cond}"+$",'{ListaUsracessos.ToArray()[i].Ecran}'"; 
                    }
                }
            }
            
            var bw = new Browdoc
            {
                Condicao = $" where sigla in ({cond}) ",
                Descricao = @"descricao",
                Sigla = @"sigla",
                Tabela = @"tdocf",
                BindTdoc = BindTdoc
            };
            bw.ShowForm(this, true);
        }
        private void gridUIFt1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUIFt1.CurrentRow == null) return;
            if (!gridUIFt1.CurrentCell.OwningColumn.Name.ToLower().Trim().Equals("ivainc")) return;
            gridUIFt1.CurrentCell.Value = !gridUIFt1.CurrentCell.Value.ToBool();
            gridUIFt1.Update();
            Helper.Totaislinha(true, gridUIFt1.DsDt, this, TmpTdoc.Sigla);
        }
        private void gridUIFt1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //var nome = gridUIFt1.CurrentCell.OwningColumn.Name.ToLower();
            //if (!nome.Equals("tabiva")) return;
            //var f = new ShowItem
            //{
            //    MdiParent = MdiParent,
            //    Condicao = "where tabela = 5",
            //    Selected = "CODIGO, Descricao",
            //    Tabela = "Auxiliar",
            //    Sender = Receive
            //};
            //f.ShowForm(this, new Point(624, 345));
        }
        public void Receive(DataGridViewRow dr)
        {
            if (gridUIFt1.CurrentRow == null) return;
            gridUIFt1.CurrentRow.Cells["TabIVA"].Value = dr.Cells[0].Value;
            gridUIFt1.CurrentRow.Cells["txiva"].Value = dr.Cells[1].Value;
            Helper.Totaislinha(true, gridUIFt1.DsDt, this, TmpTdoc.Sigla);
        }
        private void gridUIFt1_MouseDown(object sender, MouseEventArgs e)
        {
            if (gridUIFt1.Rows.Count <= 0) return;
            // Load context menu on right mouse click
            DataGridView.HitTestInfo hitTestInfo;
            if (e.Button != MouseButtons.Right) return;
            hitTestInfo = gridUIFt1.HitTest(e.X, e.Y);
            gridUIFt1.Rows[hitTestInfo.RowIndex].Selected = true;
            var rowIndex = hitTestInfo.RowIndex;
            // If column is first column
            if (hitTestInfo.Type == DataGridViewHitTestType.Cell)
                DeleteRow.Show(gridUIFt1, new Point(e.X, e.Y));
        }
        private void gridUIFt1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (!NVerificar) return;
            NVerificar = false;
            Helper.CellValidated(gridUIFt1,this,TmpTdoc.Sigla);
        }

        private void gridUIFt1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var nome = gridUIFt1.CurrentCell.OwningColumn.Name.ToLower();
            if (!OrigReserva)
            {
                if (nome.Equals("descricao"))
                {
                    SetFaccl("descricao");
                }
                if (nome.Equals("ref1"))
                {
                    SetFaccl("referenc");
                }
                if (nome.Equals("refornec"))
                {
                    SetFaccl("refornec");
                }
            }
            if (nome.Equals("descarm"))
            {
                SetArmazem( "descricao");
            }
            if (nome.Equals("armazem"))
            {
                SetArmazem("codigo");
            }
            if (nome.Equals("tabiva"))
            {
                SetTabIva("codigo");
            }
            if (nome.Equals("txiva"))
            {
                SetTabIva("descricao");
            }
        }
        private void SetTabIva(string codigo)
        {
            if (gridUIFt1.CurrentCell?.Value == null) return;
            gridUIFt1.CurrentCell.Value = gridUIFt1.CurrentCell.Value.ToString().Trim().ToUpper();
            var valor = gridUIFt1.CurrentCell.Value.ToString().Trim();
            if (DtIva != null)
            {
                DataRow dr;
                switch (codigo)
                {
                    case "descricao":
                        dr = DtIva.AsEnumerable().FirstOrDefault(s => s.Field<string>(codigo).Equals(valor));
                        if (dr == null) return;
                        if (gridUIFt1.CurrentRow != null) 
                            gridUIFt1.CurrentRow.Cells["tabiva"].Value = dr[0].ToString();
                        break;
                    case "codigo":
                        dr = DtIva.AsEnumerable().FirstOrDefault(s => s.Field<decimal>(codigo).ToDecimal().Equals(valor.ToDecimal()));
                        if (dr == null) return;
                        if (gridUIFt1.CurrentRow != null) 
                            gridUIFt1.CurrentRow.Cells["txiva"].Value = dr[1].ToString();
                        break;
                }
                Helper.Totaislinha(true, gridUIFt1.DsDt, this,TmpTdoc.Sigla);
            }

            gridUIFt1.Update();
        }
        private void SetArmazem(string referenc)
        {
            if (gridUIFt1.CurrentCell?.Value == null) return;
            gridUIFt1.CurrentCell.Value = gridUIFt1.CurrentCell.Value.ToString().Trim().ToUpper();
            var valor = gridUIFt1.CurrentCell.Value.ToString().Trim();
            var dr = DtArm.AsEnumerable().FirstOrDefault(s => s.Field<string>(referenc).Trim().Equals(valor));
            if (dr == null) return;
            switch (referenc)
            {
                case "descricao":
                    if (gridUIFt1.CurrentRow != null)
                    {
                        gridUIFt1.CurrentRow.Cells["Armazem"].Value = dr[0].ToString();//Armazemstamp
                        gridUIFt1.CurrentRow.Cells["Armazemstamp"].Value = dr["Armazemstamp"].ToString();//Armazemstamp
                    }
                    break;
                default:
                    if (gridUIFt1.CurrentRow != null)
                    {
                        gridUIFt1.CurrentRow.Cells["descarm"].Value = dr[1].ToString();
                        gridUIFt1.CurrentRow.Cells["Armazemstamp"].Value = dr["Armazemstamp"].ToString();
                    }
                    break;
            }
               
            gridUIFt1.Update();
        }
        private void SetFaccl(string campo)
        {
            if (gridUIFt1.CurrentCell?.Value == null) return;
            if (TmpTdoc.Nc)
            {
                if (gridUIFt1.CurrentRow != null && gridUIFt1.CurrentRow.Cells["Quant"].Value.ToDecimal() > 0)
                {
                    gridUIFt1.CurrentRow.Cells["Quant"].Value = (-1 * gridUIFt1.CurrentRow.Cells["Quant"].Value.ToDecimal()).ToString();
                }
            }
            gridUIFt1.CurrentCell.Value = gridUIFt1.CurrentCell.Value.ToString().Trim().ToUpper();
            var valor = gridUIFt1.CurrentCell.Value.ToString().Trim();
            var dr = DtSt.AsEnumerable().FirstOrDefault(s => s.Field<string>(campo).Trim().Equals(valor));
            if (dr != null)
            {
                Addline(dr["Ststamp"].ToString().Trim());
            }
            else
            {
                if (tbTaxaCambio.tb1.Text.ToDecimal()>0)
                {
                    DataRow["Cambiousd"] = tbTaxaCambio.tb1.Text.ToDecimal();
                }                
            }
                
        }
        private void gridUIFt1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (gridUIFt1.CurrentRow == null) return;
            DataRow = ((DataRowView)gridUIFt1.CurrentRow.DataBoundItem).Row;
            string qry;
            var cond = string.Empty;
            if (DtArtigos != null)
            {
                string gr = string.Empty;
                qry = $"select* from (select quant =" +
                      $" isnull((select top 1  pl.Quant " +
                      $" from faccl fl join facc fc on fl.Faccstamp = " +
                      $" fc.Faccstamp where fl.Ststamp = pl.Ststamp " +
                      $" and Pjstamp = '{Pjstamp}' " +
                      $"and pl.no='{tbFornec.Text2}'" +
                      $"), pl.Quant),Descricao,pl.Ststamp," +
                      $"pl.Nome, pl.Preco,pl.Procurmlstamp,pl.Txiva," +
                      $"pl.Tabiva,pl.Perdesc,pl.Descontol,pl.Ivainc,pl.Factura,pl.No" +
                      $" from Procurml pl where Procurmstamp = '{Pjstamp}' " +
                      $"and pl.no='{tbFornec.Text2}') " +
                      $"temp ";
                var dtst = SQL.GetGenDT(qry);

                for (int i = 0; i < dtst.Rows.Count; i++)
                {
                    if (i == 0)
                    {
                        gr += $"'{dtst.Rows[i]["Ststamp"]}'";
                    }
                    else
                    {
                        gr += $",'{dtst.Rows[i]["Ststamp"]}'";
                    }
                }
                var subs = gr.Split(',');

                var sssss = new List<string>(subs.Distinct());
                for (int i = 0; i < sssss.Count; i++)
                {
                    if (i == 0)
                    {
                        cond += $"{sssss[i]}";
                    }
                    else
                    {
                        cond += $",{sssss[i]}";
                    }
                }
               

                //for (var i = 0; i < subs.Length; i++)
                //{
                //    if (i == 0)
                //    {
                //        cond += $"{subs[i]}";
                //    }
                //    else
                //    {
                //        cond += $",{subs[i]}";
                //    }
                //}
                cond = $" where Ststamp in ({cond})";
            }
            qry = $"select Ststamp,Referenc,Descricao,refornec from st  {cond}";
            var name = gridUIFt1.CurrentCell.OwningColumn.Name.ToLower();
            if (name.Equals("descricao"))
            {
                DtSt = Helper.SetBinds(e.Control, "Descricao", qry);
            }
            else if (name.Equals("ref1"))
            {
                DtSt = Helper.SetBinds(e.Control, "Referenc", qry);
            }
            else if (name.Equals("refornec"))
            {
                DtSt = Helper.SetBinds(e.Control, "Refornec", qry);
            }
            else if (name.Equals("armazem"))
            {
                DtArm = Helper.SetBinds(e.Control, "codigo", Helper.GetArmazemQry());
            }
            else if (name.Equals("descarm"))
            {
                DtArm = Helper.SetBinds(e.Control, "Descricao", Helper.GetArmazemQry());
            }            
            else if (name.Equals("tabiva"))
            {
                qry = "select Codigo,Descricao from Auxiliar where tabela = 5 order by Codigo";
                DtIva = Helper.SetBinds(e.Control, "Codigo", qry);
            }
            else if (name.Equals("txiva"))
            {
                qry = "select Codigo,Descricao from Auxiliar where tabela = 5 order by Codigo";
                DtIva = Helper.SetBinds(e.Control, "Descricao", qry);
            }
            else
            {
                DtSt = null;
                var autoText = e.Control as TextBox;
                autoText.AutoCompleteCustomSource = null;
            }
        }

        public DataTable DtIva { get; set; }

        internal void UpdateObjects(Di di, DataTable dt)
        {
            tbFornec.tb1.Text = di.Nome;
            tbFornec.Text2 = di.No;
            tbCcusto.tb1.Text = di.Ccusto;
            ucMoeda.tb1.Text = di.Moeda;
            _facc.Oristamp = di.Distamp;
            Distamp = di.Distamp;
            _facc.Reserva = true;
            FillGrid(dt);
            OrigReserva = false;
        }
        private void ReceiveDataFromCopyLinhas(DataTable dt)
        {
            if (!(dt?.Rows.Count > 0)) return;
            gridUIFt1.DsDt.Rows.Clear();
            foreach (var row in dt.AsEnumerable())
            {
                DataRow=Helper.NewGridRow(this);
                var tmpFound = SQL.GetRowToEnt<St>($"Referenc='{row["ref"].ToString().Trim()}'");// EF.GetEnt<St>(x=>x.Referenc.Trim().Equals(row["ref"].ToString().Trim()));
                GenBl.SetLineValues(DataRow, tmpFound,_facc,true,row,false,ucMoeda.tb1.Text,MoedaCambio.tb1.Text.Trim(),tbFornec.Text3);
                DataRow["Armazem"] = row["Codarm"];
                DataRow["Descarm"] = row["armazem"];
            }

            // di.Oristamp = dt.TableName.Equals("dil") ? dt.Rows[0]["distamp"].ToString() : dt.Rows[0]["Factstamp"].ToString();
            Helper.Totaislinha(true, gridUIFt1.DsDt, this, TmpTdoc.Sigla);
        }
        private void FillGrid(DataTable dt)
        {
            if (!(dt?.Rows.Count > 0)) return;
            for (var i = 0; i < dt.Rows.Count; i++)
            {
                DataRow=Helper.NewGridRow(this);
                var tmpFound = SQL.GetRowToEnt<St>($"Ststamp='{dt.Rows[i]["ref"].ToString().Trim()}'"); //EF.GetEnt<St>(x=>x.Referenc.Trim().Equals(dt.Rows[i]["ref"].ToString().Trim()));
                GenBl.SetLineValues(DataRow, tmpFound,_facc,true,dt.Rows[i],TmpTdoc.Nc,ucMoeda.tb1.Text,MoedaCambio.tb1.Text.Trim(),tbFornec.Text3);
            }
            _facc.Oristamp = dt.Rows[0]["distamp"].ToString();
            Helper.Totaislinha(true, gridUIFt1.DsDt, this, TmpTdoc.Sigla);
        }

        public string Distamp { get; set; }
        public string Tdocfcondicao { get; set; }
        public string Origem { get; set; }
        public List<Usracessos> ListaUsracessos { get; set; }
        public Action<bool> SendRefresh { get; set; }
        public decimal TaxaCambio { get; private set; }
        private void gridUIFt1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!EditMode) return;
            if (gridUIFt1.CurrentRow == null) return;
            if (TmpTdoc.Nc)
            {
                if (gridUIFt1.CurrentRow != null && gridUIFt1.CurrentRow.Cells["Quant"].Value.ToDecimal() > 0)
                {
                    gridUIFt1.CurrentRow.Cells["Quant"].Value = (-1 * gridUIFt1.CurrentRow.Cells["Quant"].Value.ToDecimal()).ToString();
                }
            }
            Helper.CellValueChanged(gridUIFt1.CurrentCell, this);
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {

            if (Inserindo)
            {
                FillEntity(_facc);
                gridUIFt1.Update();
                gridFormasP1.Grelha.Update();
            }
            DS ds = new DS();
            var factl = gridUIFt1.GetBindedTable();
            var formasp = gridFormasP1.Grelha.DataSource as DataTable;
            Utilities.AllTrim(_facc);
            var ret = Imprimir.FillData(_facc.ToDataTable(), factl, formasp, ds.Facc, ds.Formasp);
            Imprimir.CallForm(ret.dtPrint, ret.fp, CLocalStamp, Inserindo, label1.Text, tbFornec.Text2, TmpTdoc.Nomfile, "CP", this, TmpTdoc.XmlString, true, ds, "", "");
        }
        private void Cliente_RefreshControls()
        {

            fnc = SQL.GetGen2DT($"select * from fnc where no ='{tbFornec.Text2}'");
            if (fnc?.Rows.Count>0)
            {
                tbMorada.tb1.Text=fnc.Rows[0]["morada"].ToString();
                tbNuit.tb1.Text=fnc.Rows[0]["nuit"].ToString();
                tbEmail.tb1.Text=fnc.Rows[0]["email"].ToString();
                tbCelular.tb1.Text=fnc.Rows[0]["Celular"].ToString();

                _fnc =fnc.DtToList<Fnc>().First();
            if (!string.IsNullOrEmpty(_fnc.Moeda))
            {              
                if (!Pbl.MoedaBase.Equals(_fnc.Moeda))
                {
                    MoedaCambio.tb1.Text=Pbl.MoedaBase;
                    ucMoeda.tb1.Text=_fnc.Moeda;
                    TaxaCambio=SQL.ExecCambio(_fnc.Moeda.Trim());
                    tbTaxaCambio.tb1.Text=TaxaCambio.ToString();
                    Helper.ShowHideMoedaColumns(true,_fnc.Moeda,gridUIFt1);
                }
                else
                {
                    if (tbTaxaCambio.tb1.Text.ToDecimal()==0)
                    {
                        MoedaCambio.tb1.Text = "";
                        Helper.ShowHideMoedaColumns(false, "", gridUIFt1);  
                    }
                }                
            }
            }
            if (gridUIFt1.Rows.Count <= 0) return;
            foreach (DataGridViewRow r in gridUIFt1.Rows)
            {
                r.Cells["Fornec"].Value = tbFornec.Text2;
            }
            gridUIFt1.Update();
        }

        private void Ccusto_RefreshControls()
        {
            _facc.Ccusto = tbCcusto.tb1.Text;
        }

        public void UpdateObjects(DataTable dt)
        {
            if (_facc==null)
            {
                _facc = new Facc(); 
            }
            var numdoc = dt.Rows[0]["Numdoc"].ToDecimal();
            TmpTdoc = SQL.GetRowToEnt<Tdocf>($"numdoc={numdoc}");
            label1.Text = TmpTdoc.Descricao;
            panel1.Visible = false;
            panel3.Visible = false;
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (!TmpTdoc.Ft) return;
            var drl = MsBox.Show("Deseja Cancelar este documento ? ", DResult.YesNo);
            if (drl.DialogResult != DialogResult.Yes) return;
            var dt = SQL.GetGenDT($"select debitof from fcc where oristamp ='{_facc.Faccstamp.Trim()}'");
            if (!(dt?.Rows.Count > 0)) return;
            if (dt.Rows[0][0].ToDecimal() > 0)
            {
                MsBox.Show("Não se pode cancelar o documento! Existe um recibo emitido!");
                return;
            }
            _facc.Anulado = true;
            EF.Save(_facc);
            var factl = gridUIFt1.DataSource as DataTable;
            if (factl == null) return;
            //foreach (var dr in factl.AsEnumerable())
            //{
            //    if (dr == null) continue;
            //    dr["LineAnulado"] = true;
            //}
            //SQL.GravaTabela(factl, "factl",!Procurou,CLocalStamp,Ctabela);
            SQL.SqlCmd($"delete from fcc where faccstamp ='{_facc.Faccstamp.Trim()}'");
            foreach (var dr in factl.AsEnumerable())
            {
                if (dr == null) continue;
                var lista = new List<SqlParameter>
                {
                    new SqlParameter("@Faccstamp", SqlDbType.VarChar) {Value = dr["Faccstamp"].ToString().Trim()},
                    new SqlParameter("@ref", SqlDbType.VarChar) {Value =""},
                    new SqlParameter("@MaxRownum", SqlDbType.Int) {Value = 0},
                    new SqlParameter("@Iter", SqlDbType.Int) {Value =0}
                };
                SQL.SqlExec("UpdMstkFaccl", lista);
                UpdateInfo();
            }
            MsBox.Show("Documento cancelado com sucesso");
        }

        private void UpdateInfo()
        {
            Lblcancelado.Text = @"Documento Cancelado";
            Lblcancelado.ForeColor = Color.DarkRed;
            Lblcancelado.Visible = true;
        }

        //novos metodos 
        public void CallBrowdoc1()
        {
            var bw = new Browdoc
            {
                Condicao = "",
                Descricao = @"descricao",
                Sigla = @"sigla",
                Tabela = @"tdocf",
                BindTdoc = BindTdoc1
            };
            bw.ShowForm(this, true);
        }
        public void BindTdoc1(DataRow tdoc, bool origem = false)
        {
            if (tdoc == null) return;
            TmpTdoc = tdoc.DrToEntity<Tdocf>();
            SetValues1(TmpTdoc);

        }
        private void SetValues1(Tdocf tmpTdocf)
        {
            label1.Text = tmpTdocf.Descricao;
            // Helper.ClearControls(this);
            gridFormasP1.Refresh(this.TmpTdoc.Numdoc);
            gridFormasP1.Movtz = tmpTdocf.Movtz;
            panelAprovaPagamento.Visible = tmpTdocf.Usaprovacao;
        }

        public string Origemsss { get; set; } = string.Empty;
        private bool dmzGridButtons1_BeforeAddLineEvent()
        {
           // if (!OrigReserva) return false;
            if (!string.IsNullOrEmpty(tbFornec.Text2))
            {
                //var f = new FrmGuiaList
                //{
                //    No = Cliente.Text2.ToDecimal(),
                //    SendData = ReceiveDataFromCopyLinhas,
                //    Sumcampos = "Encomenda-Encomendaentrada",
                //    Nome = Cliente.tb1.Text.Trim()
                //};
                //f.ShowForm(this);
                return false;
            }
            else
            {
                if (!string.IsNullOrEmpty(Origemsss))
                {
                    return false;
                }
                MsBox.Show(Messagem.ParteInicial()+"Deve indicar o Fornecedor!");
            }
            return true;
        }

        private void btnDocsfact_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (_facc==null)
            {
                MsBox.Show("Deve indicar o documento pretendido!");
            }
            else
            {
                var str = $@" select Documento ='PAGAMENTO'+' - '+Convert(char,Numero),nome as Fornecedor,Convert(DATE,pgf.Data) Data, Valorreg as Valor 
                    from PGF join PGFL on pgf.pgfstamp= pgfl.pgfstamp where fCcstamp ='{_facc.Faccstamp.Trim()}' order by Numero";
                var dt = SQL.GetGen2DT(str);
                if (dt?.Rows.Count>0)
                {
                    var f = new FrmShowData
                    {
                        gridUi1 = {DataSource = null},
                        label1 = {Text = $"Pagamentos emitidos da factura - {_facc.Numero}/{_facc.Data.Year}"}
                    };
                    f.gridUi1.DataSource = dt;
                    f.CamposToFill="Documento,Fornecedor";
                    f.ShowForm(this,true);
                }
                else
                {
                    MsBox.Show("Não foi encontrado nenhum pagamento para este documento");
                }
            }
        }

        private void gridPreco_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gridPreco.Anexos();
        }

        private void gridUIFt1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUIFt1.CurrentRow != null)
            {
                gridUIFt1.BeginEdit(true);
            }
        }

        private void cbNcMovtz_CheckedChangeds()
        {
            cbNcMovcc.Update(!cbNcMovtz.cb1.Checked);
            if (cbNcMovtz.cb1.Checked)
            {
                gridFormasP1.Refresh(2);
                _facc.Movcc = false;
                _facc.Movtz = true;
            }
            else
            {
                gridFormasP1.Refresh(0);
                _facc.Movcc = true;
                _facc.Movtz = false;
            }
        }

        private void cbNcMovcc_CheckedChangeds()
        {
            cbNcMovtz.Update(!cbNcMovcc.cb1.Checked);

            if (cbNcMovcc.cb1.Checked)
            {
                gridFormasP1.Refresh(0);
                _facc.Movcc = true;
                _facc.Movtz = false;  
            }
            else
            {
                gridFormasP1.Refresh(2);
                _facc.Movcc = false;
                _facc.Movtz = true;    
            }
        }

        private void tbDefault2_Load(object sender, EventArgs e)
        {

        }

        private void tbDefault5_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdateFnc_Click(object sender, EventArgs e)
        {
            if (fnc?.Rows.Count>0)
            {
                SaveFnc();
                Helper.Alert("Fornecedor actualizado com sucesso!",Form_Alert.EnmType.Success);
            }
            else
            {
                fnc = SQL.Initialize("fnc");
                var r= fnc.NewRow().Inicialize();
                r["no"] = SQL.Maximo("fnc", "no", "");
                tbFornec.Text2 = r["no"].ToString();
                r["nome"] = tbFornec.tb1.Text;
                r["morada"]=tbMorada.tb1.Text;
                r["nuit"]=tbNuit.tb1.Text;
                r["email"] =tbEmail.tb1.Text;
                r["Celular"]=tbCelular.tb1.Text;
                fnc.Rows.Add(r);
                SQL.Save(fnc,"fnc",true,"","");
                Helper.Alert("Fornecedor actualizado com sucesso!",Form_Alert.EnmType.Success);
            }  
            
        }
        private void SaveFnc()
        {
                fnc.Rows[0]["morada"]=tbMorada.tb1.Text;
                fnc.Rows[0]["nuit"]=tbNuit.tb1.Text;
                fnc.Rows[0]["email"] =tbEmail.tb1.Text;
                fnc.Rows[0]["Celular"]=tbCelular.tb1.Text;
                SQL.Save(fnc,"fnc",true,"","");
        }

        private void btnDuplicar_Click(object sender, EventArgs e)
        {
            dmzOptions.ShowMenuStrip(btnDuplicar);
        }

        private void MoedaCambio_RefreshControls()
        {
            if (!MoedaCambio.tb1.Text.ToLower().Equals(Pbl.MoedaBase.ToLower()))
            {
                TaxaCambio = SQL.ExecCambio(MoedaCambio.tb1.Text.Trim());
                tbTaxaCambio.tb1.Text = TaxaCambio.ToString();
                ucMoeda.tb1.Text = Pbl.MoedaBase;
                Helper.ShowHideMoedaColumns(true, MoedaCambio.tb1.Text, gridUIFt1);
                if (gridUIFt1.Rows.Count > 0)
                {
                    var dt = gridUIFt1.DataSource as DataTable;
                    if (dt?.Rows.Count > 0)
                    {
                        dt = GenBl.CambiaLinhas(dt, TaxaCambio, MoedaCambio.tb1.Text, ucMoeda.tb1.Text);
                        gridUIFt1.DataSource = null;
                        gridUIFt1.DataSource = dt;
                        Helper.TotaisFt(dt,this);
                    }
                }
            }
            else
            {
                MoedaCambio.tb1.Text = "";
                tbTaxaCambio.tb1.Text="";
                TaxaCambio=0;
                ucMoeda.tb1.Text = Pbl.MoedaBase;
                Helper.ShowHideMoedaColumns(false, "", gridUIFt1);
            }
        }


        private void ucMoeda_RefreshControls()
        {
            if (!ucMoeda.tb1.Text.ToLower().Equals(Pbl.MoedaBase.ToLower()))
            {
                TaxaCambio= SQL.ExecCambio(ucMoeda.tb1.Text.Trim());
                tbTaxaCambio.tb1.Text=TaxaCambio.ToString();
                MoedaCambio.tb1.Text = Pbl.MoedaBase;
                Helper.ShowHideMoedaColumns(true, ucMoeda.tb1.Text.Trim(), gridUIFt1);
                Helper.UpDateCambioLinhas(TaxaCambio,gridUIFt1,tbSuttotalMoeda,tbIvaMoeda,tbtotalMoeda,tbDescontoMoeda);
            }
            else
            {
                MoedaCambio.tb1.Text = "";
                tbTaxaCambio.tb1.Text="";
                TaxaCambio=0;
                Helper.ShowHideMoedaColumns(false, "", gridUIFt1);
                Helper.UpDateCambioLinhas(0,gridUIFt1,tbSuttotalMoeda,tbIvaMoeda,tbtotalMoeda,tbDescontoMoeda);
            }
            if (!string.IsNullOrEmpty(ucMoeda.tb1.Text))
            {
                Helper.UpdateFormaspMoeda(gridFormasP1, ucMoeda.tb1.Text);
            }
        }

        //private void ShowHideMoedaColumns(bool value, string Moeda)
        //{
        //    gridUIFt1.Columns["Mpreco"].Visible = value;//Preco
        //    gridUIFt1.Columns["Mpreco"].HeaderText = "Preço " + Moeda.Trim();
        //    gridUIFt1.Columns["msubtotall"].Visible = value;
        //    gridUIFt1.Columns["msubtotall"].HeaderText = "SubTotal " + Moeda.Trim();
        //    gridUIFt1.Columns["mvalival"].Visible = value;
        //    gridUIFt1.Columns["mvalival"].HeaderText = "Valor Iva " + Moeda.Trim();
        //    gridUIFt1.Columns["mdescontol"].Visible = value;
        //    gridUIFt1.Columns["mdescontol"].HeaderText = "Desconto " + Moeda.Trim();
        //    gridUIFt1.Columns["mtotall"].Visible = value;
        //    gridUIFt1.Columns["mtotall"].HeaderText = "Total " + Moeda.Trim();
        //}

       
        private void btnValorPanelShow_Click_1(object sender, EventArgs e)
        {
            panelContravalor.Visible = !panelContravalor.Visible;
            btnValorPanelShow.Image = panelContravalor.Visible ? Properties.Resources.Show_Sidepanel_25px : Properties.Resources.Hide_Sidepanel_25px;
        }

        private void btnRecEmitidos_Click(object sender, EventArgs e)
        {
            if (_facc==null)
            {
                MsBox.Show("Deve indicar o documento pretendido!");
            }
            else
            {
                var str = $@" select Documento ='PAGAMENTO'+' - '+Convert(char,Numero),nome as Fornecedor,Convert(DATE,pgf.Data) Data, Valorreg as Valor 
                    from PGF join PGFL on pgf.pgfstamp= pgfl.pgfstamp where fCcstamp ='{_facc.Faccstamp.Trim()}' order by Numero";
                var dt = SQL.GetGen2DT(str);
                if (dt?.Rows.Count>0)
                {
                    var f = new FrmShowData
                    {
                        gridUi1 = {DataSource = null},
                        label1 = {Text = $"Pagamentos emitidos da factura - {_facc.Numero}/{_facc.Data.Year}"}
                    };
                    f.gridUi1.DataSource = dt;
                    f.CamposToFill="Documento,Fornecedor";
                    f.ShowForm(this,true);
                }
                else
                {
                    MsBox.Show("Não foi encontrado nenhum pagamento para este documento");
                }
            }
        }

        private void btnRCL_Click(object sender, EventArgs e)
        {
            if (!TmpTdoc.Ft && !TmpTdoc.Nc && !TmpTdoc.Nc) return;
            if (!Inserindo)
            {
                if (!string.IsNullOrEmpty(tbFornec.tb1.Text))
                {
                    var dt = GenBl.GetCc(tbFornec.Text3,"fncccf","fnc");
                    if (!(dt?.Rows.Count > 0)) return;
                    if (dt.AsEnumerable().Any(x => x.Field<string>("oristamp").Trim().Equals(CLocalStamp.Trim())))
                    {
                        var dtft = dt.AsEnumerable().Where(x => x.Field<string>("oristamp").Trim().Equals(CLocalStamp.Trim())).CopyToDataTable();
                        var retorno = IsAllValido("tpgf");
                        if (!retorno.valido) return;
                        lista = retorno.lista;
                        var f = new FrmPgf2
                        {
                            ListaUsracessos = lista,
                            Usracessos = lista.FirstOrDefault(),
                             Fnc = SQL.GetRowToEnt<Fnc>($"no='{tbFornec.Text2}'"), //EF.GetEnt<Fnc>(x => x.No.Equals(tbFornec.Text2))
                        };

                        f.brrtextCliente.Visible = f.gridFormasCliente.Visible = false;
                        f.Trclcondicao ="sigla ='PGF'";
                        //f.CCondicao = $"numdoc={_tmpTRcl.Numdoc} and year(data) = {Pbl.SqlDate.Year} and Ccusto='{Pbl.Ccusto.Trim()}'";
                        f.ShowForm(this);
                        f.btnNovo.PerformClick();                    
                        f.tbFornec.tb1.Text = tbFornec.tb1.Text;
                        f.tbCcusto.tb1.Text = tbCcusto.tb1.Text;
                        f.tbFornec.button1.Enabled = false;
                        f.tbFornec.Text2 = tbFornec.Text2;
                        f.ReceiveData(dtft);

                    }
                    else
                    {
                        MsBox.Show(Messagem.ParteInicial() + "Não encontramos nenhuma conta corrente para este documento!");
                    }
                }
                else
                {
                    MsBox.Show(Messagem.ParteInicial() + "Deve indicar o fornecedor ou o documento a emitir o pagamento!");
                }
            }
            else
            {
                MsBox.Show(Messagem.ParteInicial() + "Não podemos emitir o pagamento, o documento está em criação!");
            }
        }

        private  (bool valido, List<Usracessos> lista) IsAllValido(string tdoc)
        {
            (bool valido, List<Usracessos> lista) ret = (false, null);
            if (!Inserindo)
            {
                lista = Pbl.Usracessos.Where(x => x.Origem.ToLower().Equals(tdoc.ToLower())).ToList();
                if (lista?.Count>0)
                {
                    if (!string.IsNullOrEmpty(tbFornec.Text2))
                    {
                        var lista2 = lista.Where(linha => linha.Ver).ToList();
                        if (lista2.Count>0)
                        {
                            ret = (true, lista2);
                        }
                        else
                        {
                            MsBox.Show($"Estimado(a) {Pbl.Usr.Nome} não tem acesso a factura . contacte administrator!");
                        }
                    }
                    else
                    {
                        MsBox.Show($"Estimado(a) {Pbl.Usr.Nome} o documento não tem cliente definido. \r\nNão é possivel emitir o documento pretendido! "); 
                    }
                }
                else
                {
                    MsBox.Show($"Desculpa não tem acessos definidos para {Pbl.Usr.Nome}. contacte administrator!");     
                }
            }
            else
            {
                MsBox.Show($"Estimado(a) {Pbl.Usr.Nome},o documento  está em criação. \r\nNão é possivel emitir o documento pretendido!");
            }
            return ret;
        }

        private void btnCopylinhas_Click(object sender, EventArgs e)
        {

        }
        public void ReceiveDataFromCopyLinhas(DataTable dt, DataTable dt2, string tabela, bool linhaResumo)
        {
            if (linhaResumo)
            {
                var dr = CriarLinha();
                var descricao = $@"{dt2.Rows[0]["Nomedoc"].ToString().Trim()} Nº: {dt2.Rows[0]["numero"].ToString().Trim()} de {dt2.Rows[0]["data"].ToDateTimeValue().ToShortDateString().Trim()}";
                dr["descricao"] = descricao;
                dr["servico"] = true;
                dr["Faccstamp"] = CLocalStamp;
                dr["Facclstamp"] = Pbl.Stamp();
                gridUIFt1.DsDt.Rows.Add(dr);
            }
            if (dt?.Rows.Count > 0)
            {
                foreach (var row in dt.AsEnumerable())
                {
                    if (row != null)
                    {
                        var dr = CriarLinha();
                        foreach (DataColumn col in dt.Columns)
                        {
                            if (dr.Table.Columns.Contains(col.ColumnName))
                            {
                                dr[col.ColumnName.ToLower().Trim()] = row[col.ColumnName.ToLower().Trim()];
                            }
                        }
                        if (TmpTdoc.Nc)
                        {
                            dr["Quant"] = -1 * dr["Quant"].ToDecimal();
                        }
                        dr["Faccstamp"] = CLocalStamp;
                        dr["Facclstamp"] = Pbl.Stamp();
                        if (!row["servico"].ToBool())
                        {
                            if (row["Armazemstamp"].ToString().IsNullOrEmpty())
                            {
                                dr["Armazemstamp"] = Pbl.Usr.Armazemstamp;
                            }
                        }
                        gridUIFt1.DsDt.Rows.Add(dr);
                    }
                    linhaResumo = false;
                }
                Helper.Totaislinha(true, gridUIFt1.DsDt, this, TmpTdoc.Sigla);
            }
            if (dt2?.Rows.Count > 0)
            {
                _facc.Oristamp = dt2.Rows[0]["stamp"].ToString();
                //tbNumdocanulado.tB1.Text = dt2.Rows[0]["numero"].ToString();
            }
        }
        private DataRow CriarLinha()
        {
            var dr = gridUIFt1.DsDt.NewRow().Inicialize();
            var nMaxOrdem = gridUIFt1.DsDt.Rows.Count;
            nMaxOrdem = nMaxOrdem + 1;
            dr["ordem"] = nMaxOrdem;
            return dr;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            //Imprimir.DoPrint(CLocalStamp, Inserindo, label1.Text, tbFornec.Text2, TmpTdoc.Nomfile, "CP", this, Linguas.PT, TmpTdoc.XmlString);
        }

        private void nToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Imprimir.DoPrint(CLocalStamp, Inserindo, label1.Text, tbFornec.Text2, TmpTdoc.Nomfile, "CP", this, Linguas.EN, TmpTdoc.XmlString);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (Procurou)
            {
                var drs = MsBox.Show("Deseja duplicar o presente documento?", DResult.YesNo);
                if (drs.DialogResult == DialogResult.Yes)
                {
                    CLocalStamp = Pbl.Stamp();
                    var maximo = SQL.Maximo("facc", "numero", CCondicao);
                    _facc.Faccstamp = CLocalStamp;
                    dtFact.dt1.Value = Pbl.SqlDate;
                    dtVencimento.dt1.Value = Pbl.SqlDate.AddDays(30);
                    tbNumero.tb1.Text = maximo.ToString();
                    Helper.UpdateLinhas(CLocalStamp, gridUIFt1, gridFormasP1.Grelha, "facc", "faccl");
                }
            }
        }

        private void copiarLinhasEmOutroDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!EditMode) return;
            var form = new FrmCopylinhas { SendData = ReceiveDataFromCopyLinhas };
            form.ShowForm(this, true);
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            if (Procurou)
            {
                CallBrowdoc(true);
            }
            else
            {
                MsBox.Show(Messagem.ParteInicial() + "Deve estar em modo de edição!");
            }
        }

        private void emitirReciboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!TmpTdoc.Ft && !TmpTdoc.Nc && !TmpTdoc.Nc) return;
            if (!Inserindo)
            {
                if (!string.IsNullOrEmpty(tbFornec.tb1.Text))
                {
                    var dt = GenBl.GetCc(tbFornec.Text3.Trim(), "Fncccf", "fnc");
                    if (!(dt?.Rows.Count > 0)) return;
                    if (dt.AsEnumerable().Any(x => x.Field<string>("oristamp").Trim().Equals(CLocalStamp.Trim())))
                    {
                        var dtft = dt.AsEnumerable().Where(x => x.Field<string>("oristamp").Trim().Equals(CLocalStamp.Trim())).CopyToDataTable();
                        var retorno = IsAllValido("tpgf");
                        if (!retorno.valido) return;
                        lista = retorno.lista;
                        var f = new FrmPgf
                        {
                            ListaUsracessos = lista,
                            Usracessos = lista.FirstOrDefault(),
                            Fnc = SQL.GetRowToEnt<Fnc>($"no='{tbFornec.Text2}'"),//EF.GetEnt<Fnc>(x => x.No.Equals(tbFornec.Text2))
                        };
                        f.Trclcondicao = "sigla ='RC'";
                        f.ShowForm(this);
                        f.btnNovo.PerformClick();
                        f.tbFornec.tb1.Text = tbFornec.tb1.Text;
                        f.tbCcusto.tb1.Text = tbCcusto.tb1.Text;
                        f.tbFornec.button1.Enabled = false;
                        f.tbFornec.Text2 = tbFornec.Text2;
                        f.ReceiveData(dtft);

                    }
                    else
                    {
                        MsBox.Show(Messagem.ParteInicial() + "Não encontramos nenhuma conta corrente para este documento!");
                    }
                }
                else
                {
                    MsBox.Show(Messagem.ParteInicial() + "Deve indicar o cliente ou documento a emitir o recibo");
                }
            }
            else
            {
                MsBox.Show(Messagem.ParteInicial() + "Não podemos emitir o recibo, a factura está em criação!");
            }
        }
        private DataTable GetCC()
        {
            var str = $@"select * from pgf join pgfl on pgf.pgfstamp = pgfl.pgfstamp
                         where ltrim(rtrim(fccstamp))='{_facc.Faccstamp.Trim()}' ";
            return SQL.GetGen2DT(str);
        }
        private void recibosEmitidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TmpTdoc.Ft || TmpTdoc.Nd || TmpTdoc.Nc)
            {
                if (string.IsNullOrEmpty(tbFornec.tb1.Text))
                {
                    MsBox.Show("Deve indicar o documento pretendido!");
                }
                else
                {
                    var dt = GetCC();
                    if (dt.HasRows())
                    {
                        var f = new FrmShowData
                        {
                            gridUi1 = { DataSource = null },
                            label1 = { Text = $"Pagamentos emitidos da factura - {_facc.Numero}/{_facc.Data.Year}" }
                        };
                        f.gridUi1.DataSource = dt;
                        f.CamposToFill = "Documento,Fornecedor";
                        f.ShowForm(this, true);
                    }
                    else
                    {
                        MsBox.Show("Não foi encontrado nenhum Pagamento para este documento");
                    }
                }
            }
        }

        private void importarFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 
            var dt = SQL.GetGen2DT("select Numdoc,Descricao from tdocf order by Numdoc");
            Helper.ChamaformImport("facc", "faccl", "", "Facturação de fornecedores",null,dt);
        }
    }
}
