using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Generic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DMZ.UI.Extensions;
using DMZ.UI.Properties;
using Application = System.Windows.Forms.Application;
using DataTable = System.Data.DataTable;
using Util = DMZ.UI.Generic.Util;

namespace DMZ.UI.UI
{
    public partial class FrmPosSup : FrmClasse2
    {
        public DataTable DtProdutos;
        public DataTable DtSecFam;
        private Param _param;
        public DataTable Fatl;//Factl
        private Timer _mTimer;
        public Fact ft;
        public Cl Cl;
        private Caixa _caixa;
        public DataRow DataRow { get; set; }
        public DataRow DataRow1 { get; set; }
        public DataTable Factl { get; set; }
        public Tdoc TmpTdoc { get; set; }
        public bool NVerificar { get; set; }
        public string CLocalStamp { get; set; } = "";
        public string Ctabela { get; set; }
        public string Campo2 { get; set; }
        public bool Updating { get; set; }
        public bool Podepagar { get; set; }
        public string Campo1 { get; set; }
        public bool Editemode { get; set; }
        public string Usrsupervidor { get; set; }
        public FrmPosSup()
        {
            InitializeComponent();
        }
        public void Alert(string msg, Form_Alert.EnmType type)
        {
            var frm = new Form_Alert();
            frm.ShowAlert(msg, type);
        }
        public bool OpenFromModulo { get; set; }
        // public Moedas Moeda;
        public DataTable PrintDt { get; set; }
        public DataTable DtUsrmudapreco { get; set; }
        public bool AddNewRecord { get; set; }
        public bool EditMode { get; set; }
        public List<Fact> Suspenso { get; set; }
        public List<Factl> Suspensol { get; set; }
        private void FrmPosSup_Load(object sender, EventArgs e)
        {
            lblTotal.Text = @"0,00";
            flowMenuPanel.Width = 0;
            if (gridFactl != null)
            {
                gridFactl.Columns["Desconto"].Visible = Pbl.Usr.Desconto;
            }
            if (!string.IsNullOrEmpty(Pbl.Param.Tipooperacao))
            {
                switch (Pbl.Param.Tipooperacao)
                {
                    case "FT":
                        TmpTdoc = SQL.GetRowToEnt<Tdoc>("FT=1");
                        GrupoFactura();
                        break;
                    case "VD":
                        TmpTdoc = SQL.GetRowToEnt<Tdoc>("VD=1");
                        GrupoVD();
                        break;
                }
            }
            else
            {
                TmpTdoc = SQL.GetRowToEnt<Tdoc>("FT=1");
                //btnGravar.Text = @"Gravar";
                //btnGravar.Image= Resources.Save_as_25px;
                Panel_info_caixa.Visible = false;
                //btnMenuLateral.Image = Resources.Registration_28px;
                dmzToolTip1.SetToolTip(btnMenuLateral, "Cadastro de clientes");
                lblcaixa.Visible = false;
                lblPosto.Visible = false;
            }
            referencia.Visible = false;
            PrintDt = GenBl.PrintPos("", 0);
            SetValues(TmpTdoc);
            Ctabela = "fact";
            Campo1 = @"Numero";
            Campo2 = "nome";
            BindGrid();
            KeyPreview = true;
            dmzImgLabel1.label1.Text = Pbl.Usr.Nome;
            lblCcusto.label1.Text = "Loja: " + Pbl.Usr.Ccusto;
            Empresa.label1.Text = Pbl.Empresa.Nome;
            WindowState = FormWindowState.Maximized;
            dmzImgLabel4.label1.Text = Pbl.SqlDate.ToShortDateString();
            DtUsrmudapreco = SQL.Initialize("Usrmudapreco");
            CallEmpresa();
            // btnShowHidePanel.Visible = btnShowHidePanel.Visible = btnDevoluc.Visible = btnMenuLateral.Visible = btnDocs.Visible =
            // btnPrint.Visible = btnFamilias.Visible = false;
            //= btnLateralMenu.Visible = false;
            // btnFamilias.Visible = false;
            label2.Text = $"DMZ SOFTWARE -POS {Pbl.Param.Ano}";
            // btnGravar.Visible = false;

            Pbl.Usracessos = SQL.GetDT("Usracessos", $"usrstamp='{Pbl.Usr.Usrstamp.Trim()}'").DtToList<Usracessos>();
            // FillBackGroundPanel();
            _caixa = GenBl.GetCaixa(Pbl.SqlDate, Pbl.Usr.Usrstamp);
            if (_caixa == null)
            {
                Panel_info_caixa.Visible = true;
            }
            else
            {
                Panel_info_caixa.Visible = false;
            }
        }

        private void GrupoVD()
        {
            //btnGravar.Text = @"Pagar";
            // btnGravar.Image= Resources.Card_Security_Code_32px;
            GetCaixa();
            lblPosto.Visible = true;
        }

        private void GrupoFactura()
        {
            //btnGravar.Text = @"Gravar";
            // btnGravar.Image= Resources.Save_as_25px;
            Panel_info_caixa.Visible = false;
            lblcaixa.Visible = false;
            lblPosto.Visible = false;
        }

        private void GetCaixa()
        {
            tbNome.Enabled = true;
            Panel_info_caixa.Visible = true;
            if (Pbl.SqlDate.Day < DateTime.Now.Day)
            {
                Pbl.SqlDate = DateTime.Now;
            }
            var caixa = GenBl.GetCaixa(Pbl.SqlDate, Pbl.Usr.Usrstamp.Trim());
            if (!(caixa != null))
            {


                if (Pbl.Param.Origem == 1)
                {
                    var f = new FrmCaixa();
                    f.OrigemPgf = 1;
                    f.Enviar = Receber;
                    f.btnNovo_Click(this, EventArgs.Empty);
                    f.Origem = 1;
                    f.tbValor.tb1.Text = 0.ToString();
                    f.btnGravar_Click(this, EventArgs.Empty);
                    f.Close();
                    caixa = GenBl.GetCaixa(Pbl.SqlDate, Pbl.Usr.Usrstamp.Trim());
                }

                if (caixa != null)
                {
                    lblcaixa.label1.Text = caixa.Contatesoura;
                    Pbl.Usr.ContaTesoura = caixa.Contatesoura;
                    Pbl.Usr.Codtz = caixa.Codtz;
                }
            }
            Panel_info_caixa.Visible = false;
            lblcaixaAberta.Visible = true;
        }

        private void BindGrid()
        {
            Factl = SQL.GetGen2DT($" select * from factl where factstamp='{CLocalStamp.Trim()}'");
            gridFactl.SetDataSource(Factl);
        }

        private void SetValues(Tdoc tmpTdoc)
        {
            label1.Text = tmpTdoc.Descricao.ToUpper();
        }
        public bool Cancelando { get; set; }
        public bool Inserindo { get; set; }
        public virtual void EstadoDaTela(AccaoNaTela acaoNaTela)
        {
            switch (acaoNaTela)
            {
                case AccaoNaTela.Inserir:
                    btnIntroduzir.Image = Resources.Undo_251px;
                    Cancelando = true;
                    Inserindo = true;
                    EditMode = true;
                    //Refresh();
                    break;
                case AccaoNaTela.Padrao:
                    btnIntroduzir.Image = Resources.Novo_25px;
                    Cancelando = false;
                    Inserindo = false;
                    EditMode = false;
                    //  Refresh();
                    break;
            }
        }

        private void CallEmpresa()
        {
            //var imagem = Utilities.ByteToImage(Pbl.Empresa.Logo1);
            //panelItems.BackgroundImage = imagem;
        }

        private void btnIntroduzir_Click(object sender, EventArgs e)
        {

            //try
            //{
            //    if (!Inserindo)
            //    {
            //        btnGravar.Visible = true;
            //        if (TmpTdoc.Movcc)
            //        {
            //            NovoRegisto();  
            //        }
            //        if (TmpTdoc.Movtz)
            //        {
            //            if (_caixa != null)
            //            {
            //                NovoRegisto();
            //            }
            //            else
            //            {
            //                MsBox.Show("Deve proceder com abertura de caixa!");
            //            }
            //        }
            //        if (!TmpTdoc.Movcc && !TmpTdoc.Movtz)
            //        {
            //            NovoRegisto();  
            //        }
            //    }
            //    else
            //    {
            //        //if (!Cancelando) return;
            //        //var res = MsBox.Show("Deseja Cancelar a Operação ?", DResult.YesNo);
            //        //if (res.DialogResult != DialogResult.Yes) return;
            //        //Cancelar();
            //        //btnGravar.Visible = false;

            //        var dr = MsBox.Show("Deseja cancelar a operação?", DResult.YesNo);
            //        if (dr.DialogResult != DialogResult.Yes) return;
            //        RefreshCtrl();
            //        btnPagamento.Visible = false;
            //        btnSalvar.Visible = false;
            //    }
            //}
            //catch (Exception)
            //{
            //    // ignored
            //}
        }
        private void LimpaTudo()
        {
            var dt = gridFactl.DataSource as DataTable;
            if (dt.HasRows())
            {
                dt.Rows.Clear();
            }
            gridFactl.SetDataSource(dt);
            CleanCtrl();
        }
        private void Doprocess()
        {
            if (!AddNewRecord && !Updating)
            {
                LimpaTudo();
                DefaultValues();
                //if (TmpTdoc.Vd)
                //{
                //    btnTodosProdutos.PerformClick();
                //}
                //if (TmpTdoc.Ft)
                //{
                //    btnSector.PerformClick();
                //}
                SetImagens();
                AddNewRecord = true;
                Podepagar = false;
                Updating = false;
                btnPagamento.Visible = false;
                btnSalvar.Visible = true;
                if (!TmpTdoc.Vd)
                {
                    EditMode = true;
                }
            }
            else
            {
                var dr = MsBox.Show("Deseja cancelar a operação?", DResult.YesNo);
                if (dr.DialogResult != DialogResult.Yes) return;
                RefreshCtrl();
                btnPagamento.Visible = false;
                btnSalvar.Visible = false;

                EditMode = false;
                //btnIntroduzir.PerformClick();
            }
        }

        private void SetImagens()
        {
            //btnIntroduzir.Image = Resources.Save_25px;
            btnIntroduzir.Text = "Cancelar";
            //btnPagamento.Text = "Cancelar";
            btnIntroduzir.Image = Resources.Undo_251px;
        }
        private void Cancelar()
        {
            RefreshCtrl();
            EstadoDaTela(AccaoNaTela.Padrao);
            btnIntroduzir.Text = @"Venda";
            var dt = gridFactl.DataSource as DataTable;
            if (dt?.Rows.Count > 0)
            {
                dt.Rows.Clear();
            }
            gridFactl.DataSource = null;
            gridFactl.DataSource = dt;
            CleanCtrl();
            panelItems.Controls.Clear();
            FactstampSuspenso = "";
            //FillBackGroundPanel();
        }

        public void Padrao()
        {
            RefreshCtrl();
            EstadoDaTela(AccaoNaTela.Padrao);
            //btnIntroduzir.Text = @"Venda";
            CleanCtrl();
            btnPagamento.Visible = false;
            //FillBackGroundPanel();
            //Alert("Gravado com sucesso",Form_Alert.EnmType.Success);
            //Padrao();  
        }

        public void Gravar()
        {
            ft.Nome = tbNome.Text;
            if (string.IsNullOrEmpty(ft.No))
            {
                ft.No = "100000";
            }
            ft.Nuit = tbNUIT.Text.ToDecimal();
            ft.Morada = tbMorada.Text;
            ft.Vendido = cbSemSaidaStock.cb1.Checked;
            EF.Save(ft);
            SQL.Save(Factl, "factl", true, Ctabela, CLocalStamp);
            SQL.Save(DtUsrmudapreco, "Usrmudapreco", true, Ctabela, CLocalStamp);
            Alert($"{label1.Text} gravada com sucesso", Form_Alert.EnmType.Success);
            GaravarClinte();
            AddNewRecord = false;
            Updating = false;
            Padrao();
            EditMode = false;
        }

        public bool BeforeSave()
        {
            #region Verificação de Stock dos produtos a serem facturados
            var dt = gridFactl.DataSource as DataTable;
            var values = GenBl.CheckStock(ft, dt, TmpTdoc.Usalote);
            if (!values.StkExiste)
            {
                MsBox.Show(values.Messagem);
                return false;
            }
            #endregion
            return true;
        }

        //private bool BeforeSave()
        //{
        //    if (tbNome.Text.Equals(""))
        //    {
        //        MsBox.Show("Indicar o Cliente!...");
        //        return false;
        //    }
        //    if (ft==null)
        //    {
        //        MsBox.Show("Não pode gravar documento vazio!");
        //        return false;
        //    }
        //    if (Pbl.Param.Origem==1)
        //    {
        //        var dd = SQL.Initialize(" Factl");
        //        foreach (DataRow dr in Factl.Rows)
        //        {
        //            var ddssssssss = dr["quant"].ToDecimal();
        //            for (int i = 0; i < ddssssssss; i++)
        //            {
        //                dr["quant"] = 1;
        //                GenBl.TotaisLinhas(dr);
        //                var dr1 = dd.NewRow().Inicialize();
        //                foreach (DataColumn col in Factl.Columns)
        //                {
        //                    dr1[col.ColumnName] = dr[col.ColumnName];
        //                }
        //                dr1["factlstamp"] = Pbl.Stamp();
        //                dd.Rows.Add(dr1);
        //            }
        //        }
        //        Factl = dd; 
        //    }
        //    gridFactl.SetDataSource(Factl);
        //    var max = SQL.Maximo("fact", "numero",$"numdoc={TmpTdoc.Numdoc} and year(data)={Pbl.SqlDate.Year}");
        //    if (Pbl.Param.Origem==1)
        //    {
        //        ft.Origem = "VD";
        //    }
        //    if (max>ft.Numero.ToInt32())
        //    {
        //        ft.Numero = max.ToString();
        //        tbNumero.Text = max.ToString();
        //    }
        //    var dt = gridFactl.DataSource as DataTable;
        //    if (dt?.Rows.Count>0)
        //    {
        //        var values = GenBl.CheckStock(ft, dt, TmpTdoc.Usalote,true);
        //        if (values.StkExiste) 
        //            return true;
        //        MsBox.Show(values.Messagem);
        //    }
        //    else
        //    {
        //        MsBox.Show("Desculpe não tem nenhum produto facturado! não pode gravar");
        //        return false;
        //    }
        //    return false;
        //}
        public void DefaultValues()
        {
            //ft = Utilities.DoAddline<Fact>();
            //ft.Factstamp = Pbl.Stamp("POSSUP");
            //CLocalStamp = ft.Factstamp;
            //ft.Sigla = TmpTdoc.Sigla;
            //ft.Data = Pbl.SqlDate;
            //textBox2.Text = ft.Data.ToShortDateString();
            //ft.Datcaixa = Pbl.SqlDate;
            //ft.Numdoc = TmpTdoc.Numdoc;
            //ft.Nomedoc = TmpTdoc.Descricao;
            //ft.Movtz = TmpTdoc.Movtz;
            //ft.Movstk = TmpTdoc.Movstk;
            //ft.Descmovstk = TmpTdoc.Descmovstk;
            //ft.Codmovstk = TmpTdoc.Codmovstk;
            //ft.Movcc = TmpTdoc.Movcc;
            //ft.Origem = "FT";
            //FillData(Pbl.CL);
            //Cl = Pbl.CL;
            //ft.Usrstamp = Pbl.Usr.Usrstamp;
            //ft.Ccustamp = Pbl.CCu.Ccustamp;
            //ft.Descmovcc = TmpTdoc.Descmovcc;
            //ft.Codmovcc = TmpTdoc.Codmovcc;
            //ft.Moeda = Pbl.MoedaBase;
            //ft.Ccusto = Pbl.Usr.Ccusto;
            //var max = SQL.Maximo("fact", "numero",$"numdoc={TmpTdoc.Numdoc} and year(data)={Pbl.SqlDate.Year}");
            //ft.Numero = max.ToString();
            //tbNumero.Text = max.ToString();
            //ft.Codsec = Codsec;
            //ft.Descsector = Descsector;


            ft = Utilities.DoAddline<Fact>();
            ft.Factstamp = Pbl.Stamp("POSSUP");
            CLocalStamp = ft.Factstamp;
            ft.Sigla = TmpTdoc.Sigla;
            ft.Data = Pbl.SqlDate;
            //tbData.Text = ft.Data.ToShortDateString();
            ft.Datcaixa = Pbl.SqlDate;
            ft.Origem = "FT";
            ft.Pos = true;
            ft.Tdocstamp = TmpTdoc.Tdocstamp;
            HelperFact.SetDefaultValues(ft, TmpTdoc);
            var max = SQL.VMax("fact", TmpTdoc.Numdoc, ft.Data.Year);
            ft.Numero = max.ToString();
            tbNumero.Text = max.ToString();
            tbNUIT.Text = ""; ;
            ft.Codsec = Codsec;
            ft.Descsector = Descsector;
            Cl = Pbl.CL;
            if (TmpTdoc.Vd)
            {
                tbNome.Text = Pbl.CL.Nome;
                ft.Nome = Pbl.CL.Nome;
                ft.No = Pbl.CL.No;
                ft.Clstamp = Pbl.CL.Clstamp;
                ft.Morada = Pbl.CL.Morada;
                tbMorada.Text = Pbl.CL.Morada;
            }
        }
        public string Descsector { get; set; }
        public decimal Codsec { get; set; }
        private void CleanCtrl()
        {
            textBox2.Text = "";
            tbNumero.Text = "";
            tbNUIT.Text = "";
            tbMorada.Text = "";
            tbNome.Text = "";
            tbdescontos.Text = "";
            tbivat.Text = "";
            tbSubTotall.Text = "";
            tbTotalValor.Text = "";
            tbProdutos.Text = "";
            pictureBox2.Controls.Clear();
            lblTotal.Text = "0,00";
            pictureBox2.Controls.Clear();
            cbSemSaidaStock.Update(false);
            cbDefault1.Update(false);

        }

        public decimal Valor;
        public bool fromAddArtigo;

        public void AddLine(string value, bool update, bool origem = false)
        {
            var condicao = origem ? $"ltrim(rtrim(codigobarras)) ='{value.Trim()}'" : $"ltrim(rtrim(ststamp)) ='{value.Trim()}'";
            var tmpFound = SQL.GetRowToEnt<St>(condicao);
            if (tmpFound == null) return;

            string cond = string.Empty;


            if (Pbl.Param.Origem == 1)
            {
                if (!_novadescricap.IsNullOrEmpty())
                {
                    cond = $"descricao='{tmpFound.Descricao.Trim() + "-" + _novadescricap}' and preco={_valorrrr.ToDecimal()}";

                    //cond = $"descricao like '%{tmpFound.Descricao.Trim() + "-" }%' and preco={_valorrrr.ToDecimal()}";
                }
                else
                {
                }
            }
            else
            {

                cond = $"ststamp='{tmpFound.Ststamp.Trim()}'";
            }

            var conct = cond;
            var rows = Factl?.Select($"{conct}");
            #region Se For para não acumular as quantidadtes
            //if (Origem != 1)
            //{
            //    if (rows?.Length > 0)
            //    {
            //        foreach (var r in rows)
            //        {
            //            if (update)
            //            {
            //                r["quant"] = r["quant"].ToDecimal() + 1;
            //            }
            //            else
            //            {
            //                if (r["quant"].ToDecimal() > 0)
            //                {
            //                    r["quant"] = r["quant"].ToDecimal() - 1;
            //                }
            //            }
            //            Totaislinha(true);
            //        }
            //    }
            //    else
            //    {
            //        GetValueNewLine(tmpFound);
            //    }
            //}
            //else
            //{
            //    GetValueNewLine(tmpFound);
            //} 
            #endregion

            if (Factl.HasRows())
            {
                if (rows?.Length > 0)
                {
                    foreach (var r in rows)
                    {
                        if (update)
                        {
                            r["quant"] = r["quant"].ToDecimal() + 1;
                        }
                        else
                        {
                            if (r["quant"].ToDecimal() > 0)
                            {
                                r["quant"] = r["quant"].ToDecimal() - 1;
                            }
                        }

                        if (TmpTdoc.Nc)
                        {
                            if (r["quant"].ToDecimal() > 0)
                            {
                                r["quant"] = (-1) * r["quant"].ToDecimal();
                            }
                        }
                        Totaislinha(true);
                    }
                }
                else
                {

                    cond = $"Ststamp='{tmpFound.Ststamp.Trim()}'";
                    var row1S = Factl?.Select($"{cond}");

                    if (row1S != null && row1S.Length > 0)
                    {
                        GetValueNewLine(tmpFound);
                    }
                    else
                    {
                        if (Pbl.Param.Origem == 1)
                        {
                            MsBox.Show("Desculpe não pode facturar outra rota antes de salvar a actual!".ToUpper());
                            return;
                        }
                        GetValueNewLine(tmpFound);
                    }

                }
            }
            else
            {

                GetValueNewLine(tmpFound);
            }

            SomarQuant();
            pictureBox2.Image = Util.ByteToImage(tmpFound.Imagem);
            //AddNewRecord = true;
            if (!Updating) return;
            Podepagar = false;
            // AddNewRecord = true;
        }

        private void GetValueNewLine(St tmpFound)
        {
            if (ft == null) return;
            if (Factl != null)
            {
                DataRow = Factl.NewRow().Inicialize();
                DataRow["factstamp"] = ft.Factstamp;
                string dd;
                if (Pbl.Param.Origem == 1)
                {
                    dd = tmpFound.Descricao + "-" + _novadescricap;
                }
                else
                {
                    dd = tmpFound.Descricao;
                }
                
                GenBl.SetLineValues(DataRow, tmpFound, ft, false, null, false, Pbl.MoedaBase, "", "");
                if (TmpTdoc.Nc)
                {
                    if (DataRow["quant"].ToDecimal() > 0)
                    {
                        DataRow["quant"] = (-1) * DataRow["quant"].ToDecimal();
                    }
                }
                GenBl.TotaisLinhas(DataRow, true);
                DataRow["Entidadestamp"] = Cl.Clstamp; 
               
                Factl.Rows.Add(DataRow);
                var nMaxOrdem = Factl.Rows.Count;
                nMaxOrdem = nMaxOrdem + 1;
                DataRow["ordem"] = nMaxOrdem;
                DataRow["descricao"] = dd;
              
                if (Pbl.Param.Origem == 1)
                {
                    DataRow["preco"] = _valorrrr;
                }
                Helper.TotaislinhaClasse2(true, Factl, this, "FTF", 2);
                gridFactl.Update();
                TotaisFt();
            }
        }

        private void SomarQuant()
        {
            if (ft != null)
            {
                var qtt = Factl.Sum("quant");
                tbProdutos.Text = qtt.ToString(CultureInfo.InvariantCulture);
                ft.Obs = tbProdutos.Text;
            }
        }

        public void Totaislinha(bool origem)
        {
            if (!origem) return;
            foreach (var dr in Enumerable.Where(Factl.AsEnumerable(), dr => dr != null))
            {
                GenBl.TotaisLinhas(dr);
            }
            TotaisFt();
            gridFactl.EndEdit();
            Refresh();
            NVerificar = false;
        }

        public void TotaisFt()
        {
            var desconto = Factl.AsEnumerable().Where(k => k.RowState != DataRowState.Deleted).Sum(x => x.Field<decimal>("Descontol")).ToString().SetMask();
            var subTotal = Factl.AsEnumerable().Where(k => k.RowState != DataRowState.Deleted).Sum(x => x.Field<decimal>("subtotall")).ToString().SetMask();
            var total = Math.Round(Factl.AsEnumerable().Where(k => k.RowState != DataRowState.Deleted).Sum(x => x.Field<decimal>("totall")), 0).ToString().SetMask();
            lblTotal.Text = total;
            tbTotalValor.Text = total;
            var totalIva = Factl.AsEnumerable().Where(k => k.RowState != DataRowState.Deleted).Sum(x => x.Field<decimal>("valival")).ToString().SetMask();
            ft.Desconto = desconto.ToDecimal();
            ft.Subtotal = subTotal.ToDecimal();
            ft.Totaliva = totalIva.ToDecimal();
            ft.Total = lblTotal.Text.ToDecimal();
            tbdescontos.Text = desconto;
            tbivat.Text = totalIva;
            tbSubTotall.Text = subTotal;
        }

        private void Showform2(Form f)
        {
            f.TopLevel = false;
            f.Size = new Size(panelItems.Size.Width - 10, panelItems.Size.Height - 5);
            panelItems.Controls.Clear();
            panelItems.Controls.Add(f);
            f.FormClosing += F_FormClosing;
            //f.Dock= DockStyle.Fill;
            f.Show();
            //FillBackGroundPanel();
        }
        private void F_FormClosing(object sender, FormClosingEventArgs e)
        {
            // FillBackGroundPanel();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (Editemode) return;
            if (!OpenFromModulo)
            {
                Application.Exit();
            }
            else
            {
                Close();
            }
        }
        private void btnPrint_Click(object sender, EventArgs e) => MenuPrint.ShowMenuStrip(btnPrint);

        private void btnMenuLateral_Click(object sender, EventArgs e)
        {
            var f = new FrmCl();
            f.Usracessos = Pbl.Usracessos.FirstOrDefault();
            Showform2(f);
        }
        void Receber(Caixa caixa)
        {
            _caixa = caixa;
            if (_caixa != null)
            {
                lblcaixa.label1.Text = caixa.Contatesoura;
                Panel_info_caixa.Visible = false;
                lblcaixaAberta.Visible = true;
            }
            else
            {
                FrmPosSup_Load(this, null);
            }
        }


        private void gridUI1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //Subtotal();
            //TotaisFt();
        }
        public void Subtotal()
        {
            if (gridFactl.CurrentRow == null) return;
            var valor = gridFactl.CurrentRow.Cells["Quant"].Value.ToDecimal();
            var valor2 = gridFactl.CurrentRow.Cells["preco"].Value.ToDecimal();
            var total = valor * valor2;
            gridFactl.CurrentRow.Cells["subtotall"].Value = total.ToString("N2");
            gridFactl.Update();
        }
        public void ReceberDados()
        {
            Gravar();
        }
        public void RefreshCtrl()
        {
            //CLocalStamp = "";
            //BindGrid();
            //CleanCtrl();
            //ft = null;
            //AddNewRecord = false;
            //cbSemSaidaStock.cb1.Checked = false;
            //EditMode = false;
            CLocalStamp = "";
            // BindCC();
            BindGrid();
            CleanCtrl();
            ft = null;
            AddNewRecord = false;
            Updating = false;
            Podepagar = false;
            btnIntroduzir.Image = Resources.Novo_25px;
            btnIntroduzir.Text = "Novo+";
            btnPagamento.Text = "Pagar";
        }
        private void Showform(Form f)
        {
            f.TopLevel = true;
            f.ShowDialog();
        }
        private void btnSelCl_Click(object sender, EventArgs e)
        {
            if (!EditMode) return;
            var tmpFound = GetCl();
            if (!tmpFound.HasRows()) return;
            var qr = new Querry
            {
                Campo1 = "no",
                Campo2 = "nome",
                Campo3 = "",
                PControl2 = UpdateCl,
                ShowStk = false,
                Width1 = 90,
                Origem = true,
                Width2 = 270,
                Caption1 = "Código",
                Caption2 = "Descrição"
            };
            qr.Dt = tmpFound;
            qr.radGridView1.SetDataSource(tmpFound);
            qr.cbPorReferencia.Text = @"Número";
            qr.cbPorReferencia.Checked = true;
            qr.labelX1.Text = tmpFound.Rows.Count + @" registos encontados";
            qr.ShowForm(this, true);
        }

        private DataTable GetCl(string condicao = null)
        {
            string cond = "";
            if (!condicao.IsNullOrEmpty())
            {
                cond = $"where {condicao}";
            }
            return SQL.GetGen2DT($"select * from cl {cond} order by no  ");
        }

        private void UpdateCl(DataRow dr)
        {
            if (dr != null)
            {
                Cl = dr.DrToEntity<Cl>();
                if (Cl != null)
                {
                    FillData(Cl);
                }
            }
        }

        private void FillData(Cl cL)
        {
            ft.Clstamp = cL.Clstamp;
            tbNome.Text = cL.Nome;
            ft.Nome = cL.Nome;
            ft.No = cL.No;
            ft.Morada = cL.Morada;
            ft.Nuit = cL.Nuit;
            tbMorada.Text = cL.Morada;
            tbNUIT.Text = cL.Nuit.ToString();

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddLine(tbBarcode.Text.Replace("\r\n", ""), true, true);
                tbBarcode.Text = "";
            }


            //if (Procurou)
            //{
            //    if (ModeloUI.Equals("FT"))
            //    {
            //        var lista = new List<SqlParameter>();
            //        var dData1 = new SqlParameter("@factstamp", SqlDbType.Char) {Value =Ft.Factstamp.Trim() };
            //        lista.Add(dData1);
            //        var dData2 = new SqlParameter("@cMoedaBase", SqlDbType.Char) {Value = "MZN"};
            //        lista.Add(dData2);
            //        var dt= SQL.SqlSP("CheckFactRegl", lista);
            //        if (dt?.Rows.Count>0)
            //        {
            //            AddLine(textBox1.Text, true, true);
            //            textBox1.Text = "";
            //        }
            //        else
            //        {
            //            MsBox.Show("Não é permitido adicionar produtos a factura paga!..");   
            //        }
            //    }
            //    else
            //    {
            //        MsBox.Show("Não é permitido adicionar produtos a VD regularizada!..");    
            //    }
            //}
            //else
            //{
            //    if (AddNewRecord)
            //    {
            //        AddLine(textBox1.Text, true, true);
            //        textBox1.Text = "";
            //    }
            //    else
            //    {
            //        MsBox.Show("Deve iniciar uma venda!");
            //    }
            //}
        }

        private void gridUI1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridFactl.CurrentRow == null || !gridFactl.CurrentRow.Cells["apagar"].Selected) return;
            if (Podepagar) return;
            if (!Procurou)
            {
                if (AddNewRecord)
                {
                    gridFactl.Rows.Remove(gridFactl.CurrentRow);
                    TotaisFt();
                    Subtotal();
                    SomarQuant();
                }
                else
                {
                    MsBox.Show("Não pode eliminar registo gravado! Essa operação é possível para supervisor!");
                }
            }
            else
            {
                if (Pbl.Usr.Supervisor)
                {
                    gridFactl.Rows.Remove(gridFactl.CurrentRow);
                    TotaisFt();
                    Subtotal();
                    SomarQuant();
                }
                else
                {
                    MsBox.Show("Não pode eliminar! Por favor contacte o supervisor!");
                }

            }
        }

        private void btnFamilias_Click(object sender, EventArgs e)
        {
            if (Procurou)
            {
                if (Pbl.Param.Tipooperacao.Equals("FT"))
                {
                    var lista = new List<SqlParameter>();
                    var dData1 = new SqlParameter("@factstamp", SqlDbType.Char) { Value = ft.Factstamp.Trim() };
                    lista.Add(dData1);
                    var dData2 = new SqlParameter("@cMoedaBase", SqlDbType.Char) { Value = "MZN" };
                    lista.Add(dData2);
                    var dt = SQL.SqlSP("CheckFactRegl", lista);
                    if (dt.HasRows())
                    {
                        CallArtigos();
                    }
                    else
                    {
                        MsBox.Show("Não é permitido adicionar produtos a factura paga!..");
                    }
                }
                else
                {
                    MsBox.Show("Não é permitido adicionar produtos a VD regularizada!..");
                }
            }
            else
            {
                if (AddNewRecord)
                {
                    CallArtigos();
                }
                else
                {
                    MsBox.Show("Deve iniciar uma venda!");
                }
            }

        }

        private FrmArtigos _frmArtigosf;
        private void CallArtigos()
        {
            _frmArtigosf = new FrmArtigos { SendData = ReceiveData, Ccusto = Pbl.Usr.Ccusto };
            switch (Pbl.Param.Origem)
            {
                case 1:
                    _frmArtigosf.label1.Text = "ROTAS";
                    break;
                case 2:
                    _frmArtigosf.label1.Text = "PRODUTOS";
                    break;
            }
            Showform2(_frmArtigosf);
            // FillBackGroundPanel();
        }

        private decimal _valorrrr = 0;
        public void ReceiveData(string barcode, decimal valor, string novades)
        {
            _novadescricap = novades;
            _valorrrr = valor;
            fromAddArtigo = true;
            AddLine(barcode, true);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void fichaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // FillBackGroundPanel();
            var f = new FrmCl();
            f.Usracessos = Pbl.Usracessos.FirstOrDefault();
            Showform2(f);
        }

        private void aberturaDoCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // FillBackGroundPanel();
            //Helper.AbrirCaixa(Receber);

            if (Pbl.Usr.Abrecaixa || Pbl.Usr.Supervisor)
            {
                var f = new FrmCaixa();
                f.Enviar = Receber;
                Showform2(f);
            }
            else
            {
                MsBox.Show("Não tem permissão para abertura de caixa. \n\r Por favor contacte o administrador do sistema!");
            }
        }

        private void folhaDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_caixa != null)
            {
                var f = new FrmConsultacx
                {
                    Codlocal = _caixa.Codtz.ToDecimal(),
                    Origem = TmpTdoc.Sigla,
                    label1 = { Text = @"Conta: " + _caixa.Contatesoura }
                };
                Showform2(f);
            }
            else
            {
                MsBox.Show(Messagem.ParteInicial() + "Não temos conta aberta!");
            }
            // FillBackGroundPanel();
        }

        private void fechoDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // FillBackGroundPanel();
            if (_caixa == null)
            {
                MsBox.Show("Realize abertura do caixa");
            }
            else
            {
                var f = new Frmfecharcx
                {
                    Origem = "VD"
                };
                f.Caixa = _caixa;
                f.Enviar = Receber;
                Showform2(f);
            }

        }



        private void timer3_Tick(object sender, EventArgs e)
        {
            dmzImgLabel5.label1.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Editemode) return;
            if (!OpenFromModulo)
            {
                Application.Exit();
            }
            else
            {
                Close();
            }
        }

        private void gridUI1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (gridFactl.CurrentRow == null) return;
            var name = gridFactl.CurrentCell.OwningColumn.Name.ToLower().Trim();
            if (name.Equals("quant") || name.Equals("desconto") || name.Equals("preco"))
            {
                NVerificar = true;
            }
        }

        private void gridUI1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (!NVerificar) return;
            NVerificar = false;
            if (gridFactl.CurrentRow != null)
                if (TmpTdoc.Nc)
                {
                    if (gridFactl.CurrentRow.Cells["Quant"].Value.ToDecimal() > 0)
                    {
                        gridFactl.CurrentRow.Cells["Quant"].Value =
                            -1 * gridFactl.CurrentRow.Cells["Quant"].Value.ToDecimal();
                    }
                }
            GenBl.TotaisLinhas(Factl.Rows[gridFactl.CurrentRow.Index]);
            TotaisFt();
            SomarQuant();

            if (gridFactl.CurrentCell.OwningColumn.Name.Equals("preco"))
            {
                if (gridFactl.CurrentRow != null)
                {
                    var referenc = gridFactl.CurrentRow.Cells["referencia"].Value.ToString().Trim();
                    var preco = SQL.GetValue("preco", "stprecos", $"CCusto='{Pbl.Usr.Ccusto}' and  ststamp =(select ststamp from st where Referenc='{referenc}')").ToDecimal();

                    if (gridFactl.CurrentRow != null)
                    {
                        var r = DtUsrmudapreco.AsEnumerable().Where(x => x.Field<string>("Referenc").Equals(referenc))
                            .FirstOrDefault();
                        if (r != null)
                        {
                            r["Precoalter"] = gridFactl.CurrentRow.Cells["preco"].Value;
                        }
                        else
                        {
                            var row = DtUsrmudapreco.NewRow();
                            row["Usrmudaprecostamp"] = Pbl.Stamp();
                            row["Usrstamp"] = Pbl.Usr.Usrstamp;
                            row["Usrvenda"] = Pbl.Usr.Login;
                            row["Usrsupervidor"] = Usrsupervidor;
                            row["Preco"] = preco;
                            row["Data"] = Pbl.SqlDate;
                            row["Docstamp"] = ft.Factstamp;
                            row["Origem"] = "POSSUP";
                            row["Precoalter"] = gridFactl.CurrentRow.Cells["preco"].Value;
                            row["Referenc"] = gridFactl.CurrentRow.Cells["referencia"].Value;
                            DtUsrmudapreco.Rows.Add(row);
                        }

                    }
                }
            }
            if (gridFactl != null)
                gridFactl.Columns["preco"].ReadOnly = true;
            Usrsupervidor = "";
        }



        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (!BeforeSave()) return;
            if (TmpTdoc.Movtz)
            {
                eeve = e;
                Finalizar();
            }

            if (TmpTdoc.Ft || TmpTdoc.Nd || TmpTdoc.Nc)
            {
                Gravar();
            }

            if (!TmpTdoc.Movcc && !TmpTdoc.Movtz)
            {
                Gravar();
            }
            if (Suspenso?.Count > 0)
            {
                if (!string.IsNullOrEmpty(FactstampSuspenso))
                {
                    var ft = Suspenso.Find(x => x.Factstamp.Equals(FactstampSuspenso));
                    Suspenso.Remove(ft);
                    Suspensol.RemoveAll(x => x.Factstamp.Trim().Equals(FactstampSuspenso));
                    FactstampSuspenso = "";
                }
            }
            pictureBox2.Image = null;

            // FillBackGroundPanel();
        }

        void GaravarClinte()
        {
            if (cbDefault1.cb1.Checked)
            {
                var cl = new Cl { Clstamp = Pbl.Stamp(), Nuit = tbNUIT.Text.ToDecimal(), Morada = tbMorada.Text };
                var mx = SQL.VMax("no", "cl");
                cl.No = mx.ToString();
                cl.Nome = tbNome.Text;
                cl.Datacl = Pbl.SqlDate;
                cl.Anoingresso = Pbl.SqlDate;
                cl.Datanasc = Pbl.SqlDate;
                EF.Save(cl);
                //Alert("Cliente gravado com sucesso",Form_Alert.EnmType.Success);
            }
            cbDefault1.Update(false);
        }
        private bool Valido()
        {
            if (SQL.CheckExist($"select factstamp from fact where factstamp='{CLocalStamp}'"))
            {
                if (Factl.HasRows())
                {
                    if (ft != null)
                    {
                        if (SQL.CheckExist($"select factstamp from fact where factstamp='{CLocalStamp}'"))
                        {
                            return true;
                        }
                        else
                        {
                            MsBox.Show("Deve gravar primeiro");
                            return false;
                        }
                    }
                    else
                    {
                        MsBox.Show("Desculpe a Factura esta vazia!");
                        return false;
                    }
                }
                else
                {
                    MsBox.Show("Desculpe o documento não tem linhas!");
                    return false;
                }
            }
            else
            {
                MsBox.Show("Deve gravar primeiro");
                return false;
            }
        }
        private void Finalizar()
        {

            ft.Nome = tbNome.Text;
            ft.Nuit = tbNUIT.Text.ToDecimal();
            ft.Morada = tbMorada.Text;
            ft.Vendido = cbSemSaidaStock.cb1.Checked;
            if (string.IsNullOrEmpty(ft.No))
            {
                ft.No = "1985";
            }
            EF.Save(ft);
            var ret = SQL.Save(Factl, "factl", true, CLocalStamp, "fact");
            if (ret.numero == 0)
            {
                MsBox.Show($"A gravação não correu com sucesso \r\n {ret.messagem}");
                return;
            }
            AddNewRecord = false;
            Podepagar = true;
            Updating = false;
            if (TmpTdoc.Sigla.Equals("FP")) return;
            if (Podepagar)
            {
                if (Valido())
                {
                    var f = new FrmPagamentos
                    {
                        tbDivida = { Text = lblTotal.Text },
                        tbCliente = { Text = tbNome.Text },
                        tbPago = { Text = lblTotal.Text },
                        TopLevel = true,
                        StartPosition = FormStartPosition.CenterScreen,
                        TmpTdoc = TmpTdoc,
                        ft = ft,
                        Beginvoke = Padrao
                    };
                    f.ShowInTaskbar = false;
                    f.Show();
                    f.Visible = false;
                    f.cbImprimir.Update(true);
                    f.cbPOS.Update(true);
                    f.Factl = Factl;
                    if (Pbl.Param.Origem == 1)
                    {
                        f.btnAceitar_Click(this, eeve);
                        f.Close();
                    }
                    else
                    {
                        f.ShowInTaskbar = true;
                        f.Visible = true;
                        f.BringToFront();
                    }
                }
                //if (!string.IsNullOrEmpty(tbNumero.Text))
                //{
                //    if (SQL.CheckExist($"select factstamp from fact where factstamp='{CLocalStamp}'"))
                //    {
                //        if (string.IsNullOrEmpty(lblTotal.Text)) return;
                //        if (Factl.HasRows())
                //        {
                //            var f = new FrmPagamentos
                //            {
                //                tbDivida = { Text = lblTotal.Text },
                //                tbCliente = { Text = tbNome.Text },
                //                //Cl = Cl,
                //                tbPago = { Text = lblTotal.Text },
                //                TopLevel = true,
                //                StartPosition = FormStartPosition.CenterScreen,
                //                TmpTdoc = TmpTdoc,
                //                ft = Ft,
                //                Beginvoke = Padrao
                //            };
                //            f.ShowInTaskbar = false;
                //            f.Show();
                //            f.Visible = false;
                //            f.cbImprimir.Update(true);
                //            f.cbPOS.Update(true);
                //            f.Factl = Factl;
                //            if (Pbl.Param.Origem == 1)
                //            {
                //                f.btnAceitar_Click(this, eeve);
                //                f.Close();
                //                _frmArtigosf.Close();
                //            }
                //            else
                //            {
                //                f.ShowInTaskbar = true;
                //                f.Visible = true;
                //                f.BringToFront();
                //            }
                //            btnGravar.Visible = false;
                //        }
                //        else
                //        {
                //            MsBox.Show("Desculpe o documento não tem linhas!");
                //        }
                //    }
                //    else
                //    {
                //        MsBox.Show("Deve gravar primeiro");
                //    }
                //}
                //else
                //{
                //    MsBox.Show("Não tem dados a pagar");
                //}
            }
            else
            {
                if (!string.IsNullOrEmpty(tbNumero.Text))
                {
                    MsBox.Show("Não tem dados a pagar");
                }
            }
            GaravarClinte();
        }

        private EventArgs eeve;
        private void BindForm(PosProc f)
        {
            f.Multidocumento = true;
            f.Condicao1 = $"numdoc={TmpTdoc.Numdoc} and factstamp like('%POSSUP%')";
            f.cbProc.Visible = false;
            f.PControl = PControl;
            f.Tabela = "fact";
        }

        private void PControl(Fact fact, bool origem = false)
        {
            PreencheCampos(fact, origem);
            if (!origem)
            {
                Procurou = true;
                AddNewRecord = false;
            }
        }
        private void PreencheCampos(Fact fact, bool origem = false)
        {
            ft = fact;
            tbNome.Text = fact.Nome;
            textBox2.Text = fact.Data.ToShortDateString();
            tbNumero.Text = fact.Numero;
            lblTotal.Text = fact.Total.ToString();
            lblPosto.label1.Text = "Terminal: " + fact.Campo1;
            tbNUIT.Text = fact.Nuit.ToString();
            tbMorada.Text = fact.Morada;
            if (!origem)
            {
                Factl = SQL.GetGenDT($"select * from factl where factstamp='{fact.Factstamp.Trim()}'");
            }
            gridFactl.DataSource = null;
            gridFactl.AutoGenerateColumns = false;
            gridFactl.DataSource = Factl;
            gridFactl.Update();
            tbTotalValor.Text = fact.Total.ToString();
            tbdescontos.Text = fact.Desconto.ToString();
            tbivat.Text = fact.Totaliva.ToString();
            tbSubTotall.Text = fact.Subtotal.ToString();
            tbProdutos.Text = Factl?.AsEnumerable().Sum(x => x.Field<decimal>("quant")).ToDecimal().ToString();
        }
        public bool Procurou { get; set; }
        private void btnCliente_Click(object sender, EventArgs e)
        {
            var f = new PosProc { Tipodados = "varchar", Campo = "nome" };
            BindForm(f);
            Showform(f);
        }

        private void btnProcNumero_Click(object sender, EventArgs e)
        {
            var f = new PosProc { Tipodados = "decimal", Campo = "numero" };
            BindForm(f);
            Showform(f);
        }

        private void btnDocs_Click(object sender, EventArgs e)
        {
            if (!AddNewRecord)
            {
                CallBrowdoc();
            }
            else
            {
                MsBox.Show("O formulário está em modo de edição. Porfavor Grave");
            }
        }
        private void CallBrowdoc()
        {
            string cond;
            //if (string.IsNullOrEmpty(ModeloUI))
            //{
            //    cond = "pos=1";
            //}
            //else
            //{
            //    cond = ModeloUI.Equals("VD") ? "pos=1 and sigla not in('FT')" : "pos=1 and sigla not in('VD')";    
            //}
            cond = "pos=1";
            var bw = new Browdoc
            {
                Condicao = " where " + cond,
                Descricao = @"descricao",
                Sigla = @"sigla",
                Tabela = @"tdoc",
                BindTdoc = BindTdoc
            };
            bw.ShowForm(this, true);
        }
        public void BindTdoc(DataRow tdoc, bool origem = false)
        {
            if (tdoc == null) return;
            TmpTdoc = tdoc.DrToEntity<Tdoc>();
            SetValues(TmpTdoc);
            if (TmpTdoc.Movcc)
            {
                GrupoFactura();
            }

            if (TmpTdoc.Movtz)
            {
                GrupoVD();
            }

            if (!TmpTdoc.Movcc && !TmpTdoc.Movtz)
            {
                GrupoFactura();
            }
            CleanCtrl();
        }

        private void btnPw_Click(object sender, EventArgs e)
        {
            var p = new FrmPw();
            p.ShowForm(this, true);
        }

        private void btnDevoluc_Click(object sender, EventArgs e)
        {
            var b = new FrmFt { btnTdi = { Visible = false }, Tdoccondicao = "nc=1", Origem = "POSSUP" };
            b.ListaUsracessos = Pbl.Usracessos;
            Showform2(b);
            //if (Pbl.Param.Tipooperacao.Equals("FT"))
            //{

            //}
        }

        private void tbNUIT_Leave(object sender, EventArgs e)
        {
            if (tbNUIT.Text.Length <= 0) return;
            if (tbNUIT.Text.ToDecimal() != 0) return;
            MsBox.Show("O NUIT deve ter números apenas!");
            tbNUIT.Text = "";
        }

        private void btnSuspender_Click(object sender, EventArgs e)
        {
            if (ft == null) return;
            if (!Factl.HasRows()) return;
            ft.Nome = tbNome.Text;
            ft.Nuit = tbNUIT.Text.ToDecimal();
            ft.Morada = tbMorada.Text;

            var dr = MsBox.Show("Tem certeza que deseja suspender a venda?", DResult.YesNo);
            if (dr.DialogResult != DialogResult.Yes) return;
            if (!string.IsNullOrEmpty(tbNome.Text))
            {
                if (Suspenso == null)
                {
                    Suspenso = new List<Fact>();
                }

                Suspenso.Add(ft);
                foreach (DataRow dr2 in Factl.Rows)
                {
                    if (Suspensol == null)
                    {
                        Suspensol = new List<Factl>();
                    }
                    else
                    {
                        Suspensol.Add(dr2.DrToEntity<Factl>());
                    }
                }
                Cancelar();
            }
            else
            {
                MsBox.Show("Nome não pode estar vazio!");
            }
        }

        private void btnShowHidePanel_Click(object sender, EventArgs e)
        {
            if (flowMenuPanel.Visible)
            {
                _isShown = false;
                timerSlidePanel.Start();
            }
            else
            {
                _isShown = true;
                flowMenuPanel.Show();

                timerSlidePanel.Start();
            }
        }

        private bool _isShown;
        private string _novadescricap = string.Empty;

        private void timerSlidePanel_Tick(object sender, EventArgs e)
        {
            if (_isShown)
            {
                if (flowMenuPanel.Width >= 95)
                {
                    timerSlidePanel.Stop();
                }
                flowMenuPanel.Width = flowMenuPanel.Width + 10;
                panelItems.Width = 750;

            }
            else
            {
                if (flowMenuPanel.Width <= 0)
                {
                    panelItems.Width = 850;
                    timerSlidePanel.Stop();
                    flowMenuPanel.Hide();
                }
                flowMenuPanel.Width = flowMenuPanel.Width - 20;

            }
        }

        private void btnSuspensas_Click(object sender, EventArgs e)
        {
            var f = new FrmSuspensos { SendData = ReceiveSuspenso, Lista = Suspenso, Listal = Suspensol };
            Showform2(f);
        }

        private void ReceiveSuspenso(Fact f, List<Factl> factl)
        {
            FactstampSuspenso = f.Factstamp;
            foreach (var dr2 in factl)
            {
                if (Factl == null)
                {
                    Factl = new DataTable();
                }
                else
                {
                    var d = Factl.NewRow().Inicialize();
                    var prop = dr2.GetType().GetProperties();
                    foreach (var p in prop)
                    {
                        if (!p.Name.Equals("Fact") && !p.Name.Equals("Mstk"))
                        {
                            d[p.Name.Trim()] = p.GetValue(dr2, null);
                        }

                    }
                    Factl.Rows.Add(d);
                }
            }
            PreencheCampos(f, true);
        }

        public string FactstampSuspenso { get; set; }
        public int Origem { get; set; }

        private void panelItems_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (ft != null)
            {
                var dt = gridFactl.DataSource as DataTable;
                if (dt?.Rows.Count > 0)
                {
                    var nomefile = SQL.GetValue("Printfile", "param");
                    //ReportHelper.PrintReport(ft.Factstamp,"",nomefile,"fact",0,true);
                }
                else
                {
                    MsBox.Show("Desculpe o documento não tem linhas!");
                }
            }
            else
            {
                MsBox.Show("Deve indicar o documento á imprimir!");
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            //if (ft==null) return;
            //var p = new FrmReport {Printstamp = ft.Factstamp, Origem = "FT", ReportName = TmpTdoc.Nomfile.Trim()};
            //p.ShowForm(this);
        }

        private void documentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var b = new FrmDi { TdiDefaultCondicao = "Sigla='EFM'", BrowdocCondicao = "VisivelPOS=1" };
            //Showform2(b);
        }

        private void gridFactl_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!gridFactl.CurrentCell.OwningColumn.Name.Equals("preco")) return;
            var dr = MsBox.Show("Deseja alterar o preço de venda?\r\nAtenção essa operação ficará registada!", DResult.YesNo);
            if (dr.DialogResult != DialogResult.Yes) return;
            var f = new FrmCheckUsr { SendData = ReceiveInfo };
            f.ShowForm(this, true);
        }
        private void ReceiveInfo(string login, bool abilita)
        {
            gridFactl.CurrentCell.OwningColumn.ReadOnly = !abilita;
            if (!abilita) return;
            Usrsupervidor = login;
        }

        private void nORMALDIRECTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ft != null)
            {
                //PrintDt=Helper.FillPrintDt(Ft.Factstamp);
                // ReportHelper.PrintReport(ft.Factstamp,"",TmpTdoc.Nomfile,"fact",0,true);
            }
            else
            {
                Alert("O documento não tem linhas para impressão!", Form_Alert.EnmType.Warning);
            }
        }

        private void btnLateralMenu_Click(object sender, EventArgs e)
        {
            MenuPrincipal.ShowMenuStrip(btnMenuLateral);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmRelatorios { Modulo = "POSM" };
            b.ShowForm(this);
        }

        private void tbBarcode_TextChanged(object sender, EventArgs e)
        {

            //tbBarcode.Text = "";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var valido = Validado();
            if (valido.Tudovalido)
            {
                if (!BeforeSave()) return;
                ft.Nuit = tbNUIT.Text.ToDecimal();
                EF.Save(ft);
                SQL.Save(Factl, "factl", true, Ctabela, CLocalStamp);
                GenBl.ExecAudit(ft, Name);
                //if (TmpTdoc.Ft)
                //{
                //    BindCC();
                //    // ft = null;
                //}
                AddNewRecord = false;
                Podepagar = true;
                btnIntroduzir.Image = Resources.Novo_25px;
                btnIntroduzir.Text = "Novo+";
                btnPagamento.Visible = true;
                Updating = false;
                if (Pbl.Usr.Tipousr == 2)
                {
                    btnPagamento.Visible = false;
                }
                Helper.Alert("Gravado com sucesso", Form_Alert.EnmType.Success);
            }
            else
            {
                MsBox.Show($"Não é possivel gravar: {valido.Messagem}!");
            }
            btnSalvar.Visible = false;
            if (TmpTdoc.Vd)
            {
                btnPagamento.PerformClick();
            }
        }

        private (bool Tudovalido, string Messagem) Validado()
        {
            if (string.IsNullOrEmpty(tbNome.Text))
            {
                return (false, "Cliente não Indicado");
            }
            if (ft == null)
            {
                return (false, "Factura não criada");
            }
            if (Factl?.Rows.Count == 0)
            {
                return (false, "Nenhum artigo facturado");
            }
            return (true, "");
        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            if (Pbl.Usr.Tipousr == 1)
            {
                if (Podepagar)
                {
                    if (Valido())
                    {
                        var f = new FrmPagamentos
                        {
                            tbDivida = { Text = lblTotal.Text },
                            tbCliente = { Text = tbNome.Text },
                            tbPago = { Text = lblTotal.Text },
                            TopLevel = true,
                            StartPosition = FormStartPosition.CenterScreen,
                            TmpTdoc = TmpTdoc,
                            ft = ft,
                            Beginvoke = Padrao,
                            ShowInTaskbar = false
                        };
                        f.Show();
                        f.Visible = false;
                        f.cbImprimir.Update(true);
                        f.cbPOS.Update(true);
                        f.Factl = Factl;
                        if (Pbl.Param.Origem == 1)
                        {
                            f.btnAceitar_Click(this, eeve);
                            f.Close();
                        }
                        else
                        {
                            f.ShowInTaskbar = true;
                            f.Visible = true;
                            f.BringToFront();
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch (Pbl.Usr.Tipousr)
            {
                case 1:
                    if (_caixa != null)
                    {
                        Doprocess();
                    }
                    else
                    {
                        MsBox.Show("Deve abrir o caixa!");
                    }
                    break;
                case 2:
                    Doprocess();
                    break;
            }
        }
    }
}
