using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Generic;
using DMZ.UI.Reports;

namespace DMZ.UI.UI.PJ
{
    public partial class FrmPjdi : FrmClasse
    {

        public FrmPjdi()
        {
            InitializeComponent();
        }

        private Tdi TmpTdoc { get; set; }
        private Di _di;
        private St _st;
        public DataRow DataRow { get; set; }
        private DataTable _dtSt;
        private DataTable _dtArm;
        private DataTable _dtIva;

        private void FrmPjdi_Load(object sender, EventArgs e)
        {
            Campo1 = "Numero";
            Campo2 = "nome";
            Ctabela = "di";
            TmpTdoc = SQL.GetRowToEnt<Tdi>($" Codigo='{Modulo}'", " inner join Docmodulo on tdi.tdistamp=Docmodulo.tdistamp ");
            RefreshControls();
            MultiDoc = true;
            gridFormasP1.BindGridView(EditMode);
           // tabControl1.TabPages.Remove(tabPageContabilidade);
            SetValues(TmpTdoc);
            
        }

        public string Modulo { get; set; }
        public Action<bool> SendRefresh { get; set; }
        private void SetValues(Tdi tmpTdi)
        {
            label1.Text = tmpTdi.Descricao;
            CCondicao = $"numdoc={TmpTdoc.Numdoc} and year(data) = {Pbl.SqlDate.Year}";
            gridFormasP1.Refresh(tmpTdi.Numdoc);
            gridFormasP1.Movtz = tmpTdi.Movtz;
            RefreshControls();
            gridFolhadeObra.Visible = TmpTdoc.Sigla.ToLower().Equals("fo");
        }
        public override void DefaultValues()
        {
            _di = GenDi.SetDiDefaultValues(_di, this, TmpTdoc);
            if (TmpTdoc.Noentid)
            {
                _di.No = "10000";
                _di.Nome = Pbl.Empresa.Nome;
            }

            tbCcusto.tb1.Text = Pbl.Usr.Ccusto;
            tbCcusto.Text2 = Pbl.Usr.Codccu;
            _di.Pjstamp = tbProjecto.Text3;

            base.DefaultValues();
            tbNumero.IsReadOnly = TmpTdoc.Alteranum;
            if (!TmpTdoc.TrfConta)
            {
                DataRow = Helper.NewGridRow(this);
            }
            else
            {
                gridFormasP1.btnAdd.PerformClick();
            }
            dmzGridButtons1.btnNovo.Visible = true;
            if (gridUIFt1 != null)
            {
                if (gridUIFt1.Columns != null)
                    gridUIFt1.Columns["Quant"].ReadOnly = false;
            }
            Helper.ShowHideMoedaColumns(false,"",gridUIFt1);
        }
      
        public void NewGridLine()
        {
            if (!TmpTdoc.TrfConta)
            {
                DataRow = Helper.NewGridRow(this);
            }
            else
            {
                gridFormasP1.btnAdd.PerformClick();
            }
        }

        public override bool BeforeSave()
        {
            #region Actualiza o Stamp do cl nas linhas 
            if (TmpTdoc.Movstk)
            {
                Helper.UpdateLinhas(gridUIFt1,_di.Entidadestamp);
            }
            #endregion
            _di.Data = dtData.dt1.Value;
            if (dtData.dt1.Value.Year>Pbl.SqlDate.Year)
            {
                MsBox.Show($"O ano do documento não pode ser superior que: {Pbl.SqlDate.Year}!");
                return false;
            }
            #region Verificação de Stock dos produtos a serem facturados
            if (TmpTdoc.Movstk)
            {
                var values = GenBl.CheckStock(_di, gridUIFt1.DsDt, TmpTdoc.Usalote);
                if (!values.StkExiste)
                {
                    MsBox.Show(values.Messagem);
                    return false;
                }
            }
            #endregion

            #region Verifica a formas de pagamento ou FormasP
            if (TmpTdoc.Movtz)
            {
                var vals = GenBl.CheckTesoura(gridFormasP1.Formaspdt, tbTotal.tb1.Text.ToDecimal(), _di.Movtz);
                if (!vals.Correcto)
                {
                    MsBox.Show(vals.Messagem);
                    return false;
                }
            }
            #endregion
            return base.BeforeSave();
        }

        public override void Save()
        {
            FillEntity(_di);
            EF.Save(_di);
            GenBl.ExecAudit(_di, Name);
        }
        public override void AfterSave()
        {
            var matricula = tbMatricula.tb1.Text.Trim();
            var km2 = tbKilometragem.tb1.Text.ToDecimal();
            SQL.SqlCmd($"update st set Refornec='{km2}' where matricula ='{matricula}'");
            if (!string.IsNullOrEmpty(_di.Pjstamp))
            {
                Helper.Updatepj(TmpTdoc.Lancacustopj,_di.Pjstamp,"TotGI","di","",false);
                SendRefresh?.Invoke(false);
            }
            var existe = SQL.CheckExist($"select matricula from Vtmanunt where matricula ='{matricula.Trim()}'");
            if (!TmpTdoc.Sigla.Equals("FO"))
            {
                var dt = SQL.GetGen2DT(
                    $@"select top 1 min(Valkm) km from StVtman join st on st.Ststamp=StVtman.St_Ststamp where
                                                        Feito=0 and st.Matricula='{matricula}' group by st.Matricula");
                if (dt?.Rows.Count > 0)
                {
                    if (!existe)
                    {
                        var km = dt.Rows[0]["km"].ToDecimal();
                        if (km <= km2)
                        {
                            var v = new Vtmanunt
                            {
                                Data = Pbl.SqlDate,
                                Km = km2,
                                Matricula = matricula,
                                Vtmanuntstamp = Pbl.Stamp(),
                                Motorista = tbEntidade.tb1.Text
                            };
                            EF.Save(v);
                        }
                    }
                }
            }
            
            if (TmpTdoc.Sigla.Equals("FO"))
            {
                if (!cbFechomanut.cb1.Checked) return;
                if (string.IsNullOrEmpty(matricula)) return;
                if (!existe) return;
                var qr =
                    $"update StVtman set Feito=1,Distamp='{_di.Distamp.Trim()}' where Valkm=(select top 1 Valkm from StVtman join st " +
                    $"on st.Ststamp=StVtman.St_Ststamp where Feito=0 and st.Matricula='{matricula.Trim()}' order by Valkm)";
                SQL.SqlCmd(qr);
                SQL.SqlCmd($"delete from Vtmanunt where matricula ='{matricula.Trim()}'");
            }
        }
 
        public string Origem { get; set; }
        public List<Usracessos> ListaUsracessos { get; set; }

        public override void PreencheCampos(DataTable dt, int i)
        {
            _di = FillControls(_di, dt, i);
            gridFormasP1.BindGridView(EditMode);
            tbDesconto.tb1.Text.SetMask();
            tbSubTotal.tb1.Text.SetMask();
            tbTotal.tb1.Text.SetMask();
            tbTotalIva.tb1.Text.SetMask();
            if (!_di.Fechomanut) return;
            dmzGridButtons1.btnNovo.Visible = false;
            if (gridUIFt1 != null) 
                gridUIFt1.Columns["Quant"].ReadOnly = true;
        }
        public override void Addline(string referenc)
        {
            if (!Procurou)
            {
                var tmpFound = SQL.GetRowToEnt<St>($" ltrim(rtrim(ststamp)) ='{referenc.Trim()}' ");// EF.QEnt<St>($" ltrim(rtrim(ststamp)) ='{referenc.Trim()}' ");
                GenBl.SetLineValues(DataRow, tmpFound, _di, false,null,false,ucMoeda.tb1.Text,MoedaCambio.tb1.Text.ToLower().Trim(),tbEntidade.Text3);
                //*------------------------
                if (TmpTdoc.Movtz)
                {
                    DataRow["Tabiva"] = 0;
                    DataRow["Txiva"] = 0;
                }
                GenBl.TotaisLinhas(DataRow);
                if (tmpFound.Composto)
                {
                    DataRow["composto"] = tmpFound.Composto;
                    GenBl.ArtigoCompost(tmpFound, gridUIFt1.DsDt, _di);
                }
            }
            else
            {
                if (gridUIFt1.CurrentRow != null)
                    DataRow = ((DataRowView)gridUIFt1.CurrentRow.DataBoundItem).Row;
                GenBl.TotaisLinhas(DataRow);
            }
            //*----------------
            gridUIFt1.Update();
            Helper.TotaisFt(gridUIFt1.DsDt, this);
            if (!TmpTdoc.Movtz) return;
            Helper.VendaDiheiro1(gridUIFt1.DsDt, this, 2);
            UpdGridFormasp();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (Usracessos.Imprimir)
            {
                MenuPrint.ShowMenuStrip(btnPrint);
            }
            else
            {
                MsBox.Show("Não tem permissão para imprimir. Contacte o administrador!");
            }
        }
        public void BindTdoc(DataRow tdoc, bool origem = false)
        {
             
            if (tdoc == null) return;
            TmpTdoc = tdoc.DrToEntity<Tdi>();
            SetValues(TmpTdoc);
            //Helper.ClearControls(this);
        }
        private void RefreshControls()
        {
            panelFolhaObra.Visible = false;
            //panelGuiaCarga.Visible = false;
            GenDi.SetEntidade(TmpTdoc, tbEntidade);
            label1.Text = TmpTdoc.Descricao;
            CCondicao = $"numdoc={TmpTdoc.Numdoc} and year(data) = {Pbl.SqlDate.Year}";
            gridFormasP1.Grelha.Columns["Bancoentrada"].Visible = false;
            gridFormasP1.Grelha.Columns["Contadestino"].Visible = false;
            tbNumero.IsReadOnly = TmpTdoc.Alteranum;
            gridUIFt1.Columns["Armazem"].Visible = TmpTdoc.Armazem;
            gridUIFt1.Columns["arm"].Visible = TmpTdoc.Armazem;
            gridUIFt1.Columns["Preco"].HeaderText = "Valor";
            gridFormasP1.Grelha.Columns["titulo"].HeaderText = "Tipo de movimento";
            //GenDI.SetEntidade(TmpTdi, tbEntidade);
            #region Requisicao de fundos.....

            gridFormasP1.Refresh(TmpTdoc.Movtz ? 2 : 0);

            Hidcolumns(TmpTdoc.Movtz);
            #endregion

            switch (TmpTdoc.Sigla)
            {
                case "FO":
                    panelFolhaObra.Visible = true;
                    tbBomba.Visible = false;
                    break;
                case "GC":
                    panelGuiaCarga.Visible = true;
                    panelFolhaObra.Visible = true;
                    break;
                case "RC":
                    panelFolhaObra.Visible = true;
                    dtFecho.Visible = false;
                    cbFechomanut.Visible = false;
                    tbBomba.Visible = true;
                    break;
            }
            tbProjecto.Visible = TmpTdoc.Ligapj;
        }
        public override void UpdGridFormasp()
        {
            Helper.Codmovtz(TmpTdoc.Movtz, TmpTdoc.Codmovtz, TmpTdoc.Descmovtz, gridFormasP1.Grelha,"Pjdi");
            if (!TmpTdoc.TrfConta) return;
            if (gridFormasP1.Grelha.CurrentRow == null) return;
            gridFormasP1.Grelha.CurrentRow.Cells["trf"].Value = true;
            gridFormasP1.Grelha.CurrentRow.Cells["Codmovtz2"].Value = TmpTdoc.Codmovtz2;
            gridFormasP1.Grelha.CurrentRow.Cells["Descmovtz2"].Value = TmpTdoc.Descmovtz2;
        }
        private void Hidcolumns(bool value)
        {
            gridUIFt1.Columns["Subtotal"].Visible = !value;
            gridUIFt1.Columns["Percdesc"].Visible = !value;
            gridUIFt1.Columns["Desconto"].Visible = !value;
            gridUIFt1.Columns["TabIVA"].Visible = !value;
            gridUIFt1.Columns["Ivainc"].Visible = !value;
            gridUIFt1.Columns["Unidade"].Visible = !value;
            gridUIFt1.Columns["txiva"].Visible = !value;
            gridUIFt1.Columns["ValorIVA"].Visible = !value;
            gridUIFt1.Columns["Ordem"].Visible = !value;
            gridUIFt1.Columns["arm"].Visible = !value;
        }
        private void btnTdi_Click(object sender, EventArgs e)
        {
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
        public void CallBrowdoc()
        {
            var bw = new Browdoc
            {
                Condicao = $" where codigo='{Modulo}'",
                InnerJoin = " inner join Docmodulo on tdi.tdistamp=Docmodulo.tdistamp ",
                Descricao = @"descricao",
                Sigla = @"sigla",
                Tabela = @"tdi",
                BindTdoc = BindTdoc
            };
            bw.ShowForm(this, true);
        }


        private void gridUIFt1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!EditMode) return;
            if (gridUIFt1.CurrentRow == null) return;
            Helper.CellValueChanged(gridUIFt1.CurrentCell, this);
        }
        private void gridUIFt1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (gridUIFt1.CurrentRow == null) return;
            var name = gridUIFt1.CurrentCell.OwningColumn.Name.ToLower();
            string qry;
             if (name.Equals("descricao") || name.Equals("ref1"))
             {
                 DataRow = ((DataRowView)gridUIFt1.CurrentRow.DataBoundItem).Row;
                 _dtSt = Helper.EditingControlShowing(e, name.ToLower());
             }
            else if (name.Equals("armazem"))
            {
                qry = "select Codigo,Descricao from Armazem";
                _dtArm = Helper.SetBinds(e.Control, "codigo", qry);
            }
            else if (name.Equals("arm"))
            {
                qry = "select Codigo,Descricao from Armazem";
                _dtArm = Helper.SetBinds(e.Control, "Descricao", qry);
            }
            else if (name.Equals("codarment"))
            {
                qry = "select Codigo,Descricao from Armazem";
                Helper.SetBinds(e.Control, "codigo", qry);
            }
            else if (name.Equals("tabiva"))
            {
                qry = "select Codigo,Descricao from Auxiliar where tabela = 5 order by Codigo";
                _dtIva = Helper.SetBinds(e.Control, "Codigo", qry);
            }
            else if (name.Equals("txiva"))
            {
                qry = "select Codigo,Descricao from Auxiliar where tabela = 5 order by Codigo";
                _dtIva = Helper.SetBinds(e.Control, "Descricao", qry);
            }
            else
            {
                _dtSt = null;
                var autoText = e.Control as TextBox;
                if (autoText != null) 
                    autoText.AutoCompleteCustomSource = null;
            }

        }

        private void gridUIFt1_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (!e.Exception.Message.Contains("DataGridViewComboBoxCell value is not valid")) return;
            if (gridUIFt1.Columns[e.ColumnIndex].Name.Equals("TabIVA"))
            {
                e.ThrowException = false;
            }
        }
        private void gridUIFt1_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
            var nome = gridUIFt1.CurrentCell.OwningColumn.Name.ToLower();
            if (nome.Equals("descricao"))
            {
                SetFactl("descricao");
            }
            if (nome.Equals("ref1"))
            {
                SetFactl("Referenc");
            }
            if (nome.Equals("arm"))
            {
                SetArmazem("descricao");
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
                var valor = gridUIFt1.CurrentCell.Value.ToString().Trim();
                if (_dtIva != null)
                {
                    DataRow dr;
                    switch (codigo)
                    {
                        case "descricao":
                            dr = _dtIva.AsEnumerable().FirstOrDefault(s => s.Field<string>(codigo).Equals(valor));
                            if (dr == null) return;
                            if (gridUIFt1.CurrentRow != null)
                                gridUIFt1.CurrentRow.Cells["tabiva"].Value = dr[0].ToString();
                            break;
                        case "codigo":
                            dr = _dtIva.AsEnumerable().FirstOrDefault(s => s.Field<decimal>(codigo).ToDecimal().Equals(valor.ToDecimal()));
                            if (dr == null) return;
                            if (gridUIFt1.CurrentRow != null)
                                gridUIFt1.CurrentRow.Cells["txiva"].Value = dr[1].ToString();
                            break;
                    }
                    Helper.Totaislinha(true, gridUIFt1.DsDt, this, TmpTdoc.Sigla);
                }

                gridUIFt1.Update();
            }
            private void SetArmazem(string referenc)
            {
                if (gridUIFt1.CurrentCell?.Value == null) return;
                var valor = gridUIFt1.CurrentCell.Value.ToString().Trim();
                if (!(_dtArm?.Rows.Count > 0)) return;
                var dr = _dtArm.AsEnumerable().FirstOrDefault(s => s.Field<string>(referenc).Trim().Equals(valor));
                if (dr == null) return;
                switch (referenc)
                {
                    case "descricao":
                        if (gridUIFt1.CurrentRow != null)
                            gridUIFt1.CurrentRow.Cells["Armazem"].Value = dr[0].ToString();
                        break;
                    default:
                        if (gridUIFt1.CurrentRow != null)
                            gridUIFt1.CurrentRow.Cells["arm"].Value = dr[1].ToString();
                        break;
                }

                gridUIFt1.Update();

            }
            private void SetFactl(string campo)
            {
                if (gridUIFt1.CurrentCell.Value == null) return;
                var valor = gridUIFt1.CurrentCell.Value.ToString().Trim();
                if (!(_dtSt?.Rows.Count > 0)) return;
                var dr = _dtSt.AsEnumerable().FirstOrDefault(s => s.Field<string>(campo).Trim().Equals(valor));
                if (dr != null)
                    Addline(dr["Ststamp"].ToString().Trim());

            }

            private void gridUIFt1_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode != Keys.Enter) return;
                NewGridLine();
                gridUIFt1.CurrentCell = gridUIFt1.Rows[gridUIFt1.Rows.Count - 1].Cells["Descricao"];
            }

        private void ArmazemOrigem_RefreshControls()
        {
            if (!(gridUIFt1.Rows.Count > 0)) return;
            foreach (DataGridViewRow r in gridUIFt1.Rows)
            {
                if (r == null) continue;
                r.Cells["arm"].Value = ArmazemOrigem.tb1.Text;
                r.Cells["Armazem"].Value = ArmazemOrigem.Text2;
            }
            gridUIFt1.Update();
        }

        private void ArmazemDestino_RefreshControls()
        {
            if (!(gridUIFt1.Rows.Count > 0)) return;
            foreach (DataGridViewRow r in gridUIFt1.Rows)
            {
                if (r == null) continue;
                // r.Cells["arm"].Value = ArmazemOrigem.tb1.Text;
                r.Cells["Codarment"].Value = ArmazemDestino.Text2;
            }
            gridUIFt1.Update();
        }

        private void gridUIFt1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void gridUIFt1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

        }

        private void gridUIFt1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (!NVerificar) return;
            NVerificar = false;
            Helper.CellValidated(gridUIFt1,this,TmpTdoc.Sigla);
           // Helper.Totaislinha(true, gridUIFt1.DsDt, this, TmpTdi.Tipodoc);
        }

        private void tabPageInicio_Click(object sender, EventArgs e)
        {

        }

        private void tbEntidade_Load(object sender, EventArgs e)
        {

        }

        private void tbDefault2_Load(object sender, EventArgs e)
        {

        }

        private void dmzGridButtons1_Load(object sender, EventArgs e)
        {

        }


        private void gridUIFt1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbMatricula_RefreshControls()
        {
            if (!TmpTdoc.Sigla.Equals("FO"))
            {
                var dt = SQL.GetGen2DT($"select st.Motorista,no from st join pe on pe.Nome=st.Motorista where Viatura =1 and ltrim(rtrim(matricula)) ='{tbMatricula.tb1.Text.Trim()}'");
                if (!(dt?.Rows.Count > 0)) return;
                tbEntidade.tb1.Text = dt.Rows[0][0].ToString();
                tbEntidade.Text2 = dt.Rows[0][1].ToString();
            }
            else
            {
                var dt = SQL.GetGen2DT($"select st.Motorista,no from st join pe on pe.Nome=st.Motorista where Viatura =1 and ltrim(rtrim(matricula)) ='{tbMatricula.tb1.Text.Trim()}'");
                if (!(dt?.Rows.Count > 0)) return;
                procura1.tb1.Text = dt.Rows[0][0].ToString();
                procura1.Text2 = dt.Rows[0][1].ToString();      
            }
        }

        private void tbEntidade_RefreshControls()
        {
            if (TmpTdoc.Sigla.Equals("RC"))
            {
                tbBomba.SqlComandText = $@"select Descricao from fnc join fncbomb on fnc.Fncstamp=fncbomb.Fncstamp
                where fnc.No='{tbEntidade.Text2}' ";
            }

        }

        private void procura2_Load(object sender, EventArgs e)
        {

        }

        public void UpdateObjects(DataTable di)
        {
            if (_di==null)
            {
                _di = new Di(); 
            }
            var numdoc = di.Rows[0]["Numdoc"].ToDecimal();
            TmpTdoc = SQL.GetRowToEnt<Tdi>($"numdoc={numdoc}");// EF.QEnt<Tdi>( $"numdoc={numdoc}");
            label1.Text = TmpTdoc.Descricao;
            panel1.Visible = false;
            panel3.Visible = false;
        }

        private void gridPreco_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (gridPreco.CurrentRow == null) return;
            var nome = gridPreco.CurrentCell.OwningColumn.Name.ToLower();
            var qry = "select no,nome from pe";
            if (nome.Equals("descricao"))
            {
                Dtpe=Helper.SetBinds(e.Control, "Descricao", qry);
            }
            else if (nome.Equals("referenc"))
            {
                Dtpe=Helper.SetBinds(e.Control, "Referenc", qry);
            }
            else
            {
                Dtpe = null;
                var autoText = e.Control as TextBox;
                autoText.AutoCompleteCustomSource = null;
            }
        }

        public DataTable Dtpe { get; set; }
        public decimal TaxaCambio { get; private set; }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnValorPanelShow_Click(object sender, EventArgs e)
        {
            panelContravalor.Visible = !panelContravalor.Visible ;
            btnValorPanelShow.Image = panelContravalor.Visible ? Properties.Resources.Show_Sidepanel_25px : Properties.Resources.Hide_Sidepanel_25px;
        }

        private void ucMoeda_RefreshControls()
        {
            if (!ucMoeda.tb1.Text.ToLower().Equals(Pbl.MoedaBase.ToLower()))
            {
               TaxaCambio= SQL.ExecCambio(ucMoeda.tb1.Text.Trim());
                tbTaxaCambio.tb1.Text=TaxaCambio.ToString();
                MoedaCambio.tb1.Text = Pbl.MoedaBase;
                Helper.ShowHideMoedaColumns(true,ucMoeda.tb1.Text.Trim(),gridUIFt1);
                Helper.UpDateCambioLinhas(TaxaCambio,gridUIFt1,tbSuttotalMoeda,tbIvaMoeda,tbtotalMoeda,tbDescontoMoeda);
            }
            else
            {
                MoedaCambio.tb1.Text = "";
                tbTaxaCambio.tb1.Text="";
                TaxaCambio=0;
                Helper.ShowHideMoedaColumns(false,"",gridUIFt1);
                Helper.UpDateCambioLinhas(0,gridUIFt1,tbSuttotalMoeda,tbIvaMoeda,tbtotalMoeda,tbDescontoMoeda);
            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            // Imprimir.DoPrint(CLocalStamp,Inserindo,label1.Text,"",TmpTdoc.Nomfile.Trim(),"DI",this,Linguas.PT);
        }

        private void nToolStripMenuItem_Click(object sender, EventArgs e)
        {
             //Imprimir.DoPrint(CLocalStamp,Inserindo,label1.Text,"",TmpTdoc.Nomfile.Trim(),"DI",this,Linguas.EN);
        }

        private void MoedaCambio_RefreshControls()
        {
            if (!MoedaCambio.tb1.Text.ToLower().Equals(Pbl.MoedaBase.ToLower()))
            {
               TaxaCambio= SQL.ExecCambio(MoedaCambio.tb1.Text.Trim());
                tbTaxaCambio.tb1.Text = TaxaCambio.ToString();
                ucMoeda.tb1.Text = Pbl.MoedaBase;
                Helper.ShowHideMoedaColumns(true,MoedaCambio.tb1.Text,gridUIFt1);
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
                TaxaCambio=0;
                tbTaxaCambio.tb1.Text="";
                ucMoeda.tb1.Text = Pbl.MoedaBase;
                Helper.ShowHideMoedaColumns(false,"", gridUIFt1);
                Helper.UpDateCambioLinhas(0,gridUIFt1,tbSuttotalMoeda,tbIvaMoeda,tbtotalMoeda,tbDescontoMoeda);
            }
        }
    }
}
