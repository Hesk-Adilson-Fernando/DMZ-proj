using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using DMZ.UI.Reports;
using DataTable = System.Data.DataTable;
using Point = System.Drawing.Point;

namespace DMZ.UI.UI
{
    public partial class FrmDi : FrmClasse
    {
        public FrmDi()
        {
            InitializeComponent();
        }
        private Tdi TmpTdi { get; set; }
        public DataTable DtSt { get;  set; }
        public DataTable DtArm { get; set; }
        public DataRow DataRow { get; set; }
        public bool LRunStk { get; set; }
        private Di _di;

        private void FrmDi_Load(object sender, EventArgs e)
        {
            cbNTesoura.Visible = Pbl.Usr.Usradmin;
            Campo1 = "Numero";
            Campo2 = "nome";
            Ctabela = "di";
            TmpTdi = SQL.GetRowToEnt<Tdi>(TdiDefaultCondicao, " inner join Docmodulo on tdi.tdistamp=Docmodulo.tdistamp "); ;//EF.QEnt<Tdi>(" inner join Docmodulo on tdi.tdistamp=Docmodulo.tdistamp ",TdiDefaultCondicao);
            gridFormasP1.BindGridView(EditMode);
            tabControl1.TabPages.Remove(tabPageContabilidade);//
            MultiDoc = true;
            if (Pbl.Usracessos !=null)
            {
                ListaUsracessos = Pbl.Usracessos.Where(x => x.Origem.Equals("tdi")).ToList();
                if (!(ListaUsracessos?.Count > 0)) return;
                SetValues(TmpTdi);
            }
            if (TmpTdi.Sigla.Equals("EST") || TmpTdi.Sigla.Equals("GRF") || TmpTdi.Sigla.Equals("GRC"))
            {
                if (gridUIFt1 == null) return;
                gridUIFt1.Columns["ref1"].ReadOnly = true;
                gridUIFt1.Columns["Descricao"].ReadOnly = true;
            }
            gridUIFt1.Columns["Refornec"].Visible = Pbl.Param.Mostrarefornec;
        }

        public string TdiDefaultCondicao { get; set; } = " defa = 1 ";

        private void SetValues(Tdi tmpTdi)
        {
            Usracessos = ListaUsracessos.FirstOrDefault(x => x.Ecran.Equals(TmpTdi.Sigla.Trim()));
            label1.Text = tmpTdi.Descricao;
            CCondicao = $"numdoc={TmpTdi.Numdoc} and year(data) = {Pbl.SqlDate.Year}";
            gridFormasP1.Refresh(tmpTdi.Numdoc);
            gridFormasP1.Movtz=tmpTdi.Movtz;
            RefreshControls();
            Helper.MostraCentroNaLinha(gridUIFt1);
        }
        public override void DefaultValues()
        {
            _di = GenDi.SetDiDefaultValues(_di, this, TmpTdi);
            CLocalStamp = _di.Distamp;
            if (TmpTdi.Noentid)
            {
                _di.No = "10000";
                _di.Nome = Pbl.Empresa.Nome;
            }          
            base.DefaultValues();
            tbNumero.IsReadOnly = TmpTdi.Alteranum;
            cbMovstk.Update(_di.Movstk);
            //if (TmpTdi.Vendido) return;
            //if (!TmpTdi.TrfConta)
            //{
            //    if (!TmpTdi.Sigla.Equals("GRF") && !TmpTdi.Sigla.Equals("GRC") && !TmpTdi.Sigla.Equals("EST") )
            //    {
            //        DataRow =Helper.NewGridRow( this); 
            //    }
            //}
            //else
            //{
            //    gridFormasP1.AddLinha();
            //}
            Helper.SetCCustoMoeda(tbCcusto, ucMoeda);
            Helper.ShowHideMoedaColumns(false,"",gridUIFt1);
            tbNumero.IsReadOnly = !Pbl.Usr.AlteraNumero;
            cbNTesoura.Update(TmpTdi.Movtz);
        }
        public void NewGridLine()
        {
            if (!TmpTdi.TrfConta)
            {
                DataRow = Helper.NewGridRow(this);
                //if (TmpTdi.Vendido)
                //{
                //    if (string.IsNullOrEmpty(tbEntidade.tb1.Text))
                //    {
                //        MsBox.Show("Deve indicar o cliente!..");
                //    }
                //    else
                //    {
                //        var dt = SQL.GetGen2DT($@"select * from (
                //                    select no,nome,ref,Descricao,sum(Vendido-Vendidosaida) quant,Preco,Tabiva,Txiva,Codarm,Armazem=(select Descricao from Armazem where Codigo=Codarm),Unidade,Ivainc from mstk 
                //                    where Tipodoc in('FT','GRC') group by Ref,no,nome,Descricao,Preco,Codarm,Tabiva,Txiva,Unidade,Ivainc)tmp1 where tmp1.quant>0 and tmp1.No={tbEntidade.Text2} ");
                //        if (dt.Rows.Count <= 0) return;
                //        foreach (var row in dt.AsEnumerable())
                //        {
                //            if (row == null) continue;
                //            DataRow =Helper.NewGridRow( this);
                //            DataRow["Descricao"] = row["Descricao"];
                //            DataRow["quant"] = row["quant"];
                //            DataRow["ref"] = row["ref"];
                //            DataRow["Preco"] = row["Preco"];
                //            DataRow["Tabiva"] = row["Tabiva"];
                //            DataRow["Txiva"] = row["Txiva"];
                //            DataRow["Armazem"] = row["Codarm"];
                //            DataRow["Descarm"] = row["Armazem"];
                //            DataRow["Unidade"] = row["Unidade"];
                //            GenBl.TotaisLinhas(DataRow);
                //        }
                //        gridUIFt1.EndEdit();
                //        Helper.TotaisFt(gridUIFt1.DsDt, this);
                //        //Helper.Totaislinha();
                //    }
                //}
                //else
                //{
                //    DataRow = Helper.NewGridRow(this);      
                //}
            }
            else
            {
                gridFormasP1.AddLinha();
            }
        }
        public override void Save()
        {
            base.Save();
            FillEntity(_di);
            if (Cancelado) return;
            EF.Save(_di);
            if (MdiParent!=null)
            {
                GenBl.ExecAudit(_di, Name);
            }
            else if(ParentForm != null && ParentForm.Name.Equals("FrmPosPagamentos"))
            {
                GenBl.ExecAudit(_di, Name);  
            }
            else if(ParentForm != null && ParentForm.Name.Equals("FrmPosSup"))
            {
                GenBl.ExecAudit(_di, Name);  
            }
        }
        public override bool BeforeSave()
        {
            if (TmpTdi.Movstk)
            {
                if (!cbMovstk.cb1.Checked)
                {
                    var dr = MsBox.Show($"{_di.Nomedoc.Trim()}\r\nÉ um documento de movimento de Stock, Deseja continuar com essa opção desativada?!\r\nPara activar segue pela página de movimento de stock", DResult.YesNo);
                    if (dr.DialogResult == DialogResult.No)
                    {
                        return false;
                    }
                }
            }
            if (gridFormasP1.Grelha.Rows.Count>0)
            {
                foreach (DataGridViewRow r in gridFormasP1.Grelha.Rows)
                {
                    if (r!=null)
                    {
                        r.Cells["UsrLogin"].Value = Pbl.Usr.Usrstamp;
                    }
                }
                gridFormasP1.Grelha.Update();
            }
            // var retorno = true;
            if (_di.TrfConta)
            {
                var dt = gridFormasP1.Grelha.DataSource as DataTable;
                var valor =dt?.Select().Sum(x => x.Field<decimal>("valor")).ToString();
                //tbTotal.tB1.Text = valor;
                _di.Total = valor.ToDecimal();
                string contaentrada;
                if (dt != null)
                    foreach (var r in dt.AsEnumerable())
                    {
                        if (r == null) continue;
                        contaentrada = r["Contatesoura2"].ToString();
                        if (!string.IsNullOrEmpty(contaentrada)) continue;
                        MsBox.Show("A conta de entrada não pode ser vazio!");
                        return false;
                    }
            }
            _di.Data = dtDi.dt1.Value;
            #region Verificação de Stock dos produtos a serem facturados
            if (TmpTdi.Codmovstk>50)
            {
                if (TmpTdi.Trf)
                {
                    if (Inserindo)
                    {
                        var values = GenBl.CheckStock(_di, gridUIFt1.DsDt,false);
                        if (!values.StkExiste)
                        {
                            MsBox.Show(values.Messagem);
                            return values.StkExiste;
                        }
                    }
                }
                else
                {
                    var values = GenBl.CheckStock(_di, gridUIFt1.DsDt, false);
                    if (!values.StkExiste)
                    {
                        MsBox.Show(values.Messagem);
                        return values.StkExiste;
                    }
                }
            }

            if (TmpTdi.Movstk)
            {
                var dill = gridUIFt1.DataSource as DataTable;
                if (dill !=null)
                {
                    foreach (var dr in dill.AsEnumerable())
                    {
                        if (dr==null) continue;
                        if (dr["servico"].ToBool()) continue;
                        if (dr["Armazem"].ToDecimal() != 0) continue;
                        MsBox.Show($"O artigo {dr["Descricao"]} não tem armazen definido!");
                        return false;
                        break;
                    }
                }
                var ret = Helper.CheckStstamp(gridUIFt1);
                if (!ret.ret)
                {
                    MsBox.Show(ret.ms);
                    return false;
                }
            }
            #endregion
            #region Verifica o preenchimento da entidade 
            if (!TmpTdi.Noentid)
            {
                if (string.IsNullOrEmpty(tbEntidade.tb1.Text))
                {
                    MsBox.Show($"Por favor o campo {tbEntidade.label1.Text} não pode estar vazio");
                    return false;
                } 
            }
            #endregion
            #region Verificacao de formas de pagameto ou movimento de contas 
            (bool Correcto, string Messagem) vals;
            vals = GenBl.CheckTesoura(gridFormasP1.Formaspdt, _di.TrfConta ? _di.Total : tbTotal.tb1.Text.ToDecimal(), _di.Movtz);
            if (!vals.Correcto)
            {
                MsBox.Show(vals.Messagem);
                return vals.Correcto;
            }
            #endregion
            #region Verificacao dos armazens de saida e entrada ....
            if (_di.Trf)
            {
                var dtdil =gridUIFt1.DataSource as DataTable;
                if (dtdil?.Rows.Count>0)
                {
                    foreach (var r in dtdil.AsEnumerable())
                    {
                        if (r == null) continue;
                        if (r.RowState== DataRowState.Deleted) continue;
		                if (r["Armazem"].ToDecimal() == 0) 
                        {
                            MsBox.Show($"O artigo {r["Descricao"]} não tem armazen de saida definido!");
                            return false; 
                            break;
                        }
                        if (r["Armazem2"].ToDecimal() == 0) 
                        {
                            MsBox.Show($"O artigo {r["Descricao"]} não tem armazen de entrada definido!");
                            return false; 
                            break;
                        }
                    }
                }
                //if (string.IsNullOrEmpty(ArmazemOrigem.tb1.Text))
                //{
                //    MsBox.Show("Deve indicar armazem de saida");
                //    return false;
                //}
                //if (string.IsNullOrEmpty(ArmazemDestino.tb1.Text))
                //{
                //    MsBox.Show("Deve indicar armazem destino");
                //    return false;
                //}

                //if (ArmazemOrigem.tb1.Text==ArmazemDestino.tb1.Text)
                //{
                //    MsBox.Show("Desculpa mas o armazem origem não pode ser igual ao destino");
                //    return false;
                //}
            }

            if (TmpTdi.Movtz && TmpTdi.Codmovtz>50)
            {
                vals=GenBl.CheckSaldo(gridFormasP1.Formaspdt);
                if (vals.Correcto) return true;
                MsBox.Show(vals.Messagem);
                return vals.Correcto;
            }
            #endregion
            return base.BeforeSave();
        }

        public override void AfterSave()
        {
            if (UpdateOrigem)
            {
                var dt = gridUIFt1.GetBindedTable();
                if (dt.HasRows())
                {
                    foreach (var item in dt.AsEnumerable())
                    {
                        if (item != null)
                        {
                            var total = SQL.GetField($"select sum(quant) total from dil where remotestamp='{item["remotestamp"].ToTrim()}' and ststamp ='{item["ststamp"].ToTrim()}'");
                            SQL.SqlCmd($"update factl set quant2={total.ToDecimal()} where factlstamp='{item["remotestamp"].ToTrim()}' and ststamp ='{item["ststamp"].ToTrim()}'");
                        }
                    }
                }
            }
            UpdateOrigem = false;
            base.AfterSave();
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            _di = FillControls(_di, dt, i);
            gridFormasP1.BindGridView(EditMode);
            tbDesconto.tb1.Text.SetMask();
            tbSubTotal.tb1.Text.SetMask();
            tbTotal.tb1.Text.SetMask();
            tbTotalIva.tb1.Text.SetMask();
            if (!string.IsNullOrEmpty(MoedaCambio.tb1.Text))
            {
                if (!MoedaCambio.tb1.Text.Equals(Pbl.MoedaBase.Trim()))
                {
                    Helper.ShowHideMoedaColumns(true,MoedaCambio.tb1.Text.Trim(),gridUIFt1);
                }
                else if(MoedaCambio.tb1.Text.Equals(Pbl.MoedaBase.Trim()))
                {
                    Helper.ShowHideMoedaColumns(true,ucMoeda.tb1.Text.Trim(),gridUIFt1);
                }               
            }
        }
        public override void Addline(string referenc)
        {
            if (!Procurou)
            {
                var tmpFound = SQL.GetRowToEnt<St>($" ltrim(rtrim(ststamp)) ='{referenc.Trim()}' ");
                GenBl.SetLineValues(DataRow, tmpFound, _di,false,null,false,ucMoeda.tb1.Text,MoedaCambio.tb1.Text.Trim(),tbEntidade.Text3);
                //*----------------
                GenBl.TotaisLinhas(DataRow);
                if (tmpFound.Composto)
                {
                    DataRow["composto"] = tmpFound.Composto;
                    GenBl.ArtigoCompost(tmpFound, gridUIFt1.DsDt, _di);
                }
            }
            else
            {
                if (Usracessos.Altera)
                {
                    var tmpFound = SQL.GetRowToEnt<St>($" ltrim(rtrim(ststamp)) ='{referenc.Trim()}' ");
                    GenBl.SetLineValues(DataRow, tmpFound, _di,false,null,false,ucMoeda.tb1.Text,MoedaCambio.tb1.Text.ToLower().Trim(),tbEntidade.Text3);
                    //*----------------
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
            }
            //*----------------
            gridUIFt1.Update();
            Helper.TotaisFt(gridUIFt1.DsDt, this);
            if (!TmpTdi.Movtz) return;
            Helper.VendaDiheiro(gridUIFt1.DsDt, this, TmpTdi.Sigla,ucMoeda.tb1.Text);
            UpdGridFormasp();
        }

        private void btnTdi_Click(object sender, EventArgs e)
        {
            if (Procurou && Lista==null)
            {
                CallBrowdoc();
            }
            else
            {
                if (!Inserindo)
                {
                    EditMode = false;
                    Procurou = false;
                    CallBrowdoc();
                }
                else
                {
                    MsBox.Show("O formulário está em modo de edição. Porfavor Grave");
                }
            }
        }

        public string BrowdocCondicao { get; set; } = null;
        private List<Usracessos> ListaUsracessos { get; set; }
        private void CallBrowdoc()
        {
            var cond = "";   
            if (ListaUsracessos?.Count>0)
            {
                if (Controlacesso)
                {
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
                }
                var bw = new Browdoc
                {
                    Descricao = @"descricao",
                    Sigla = @"sigla",
                    Tabela = @"tdi",
                    InnerJoin = "inner join Docmodulo on tdi.tdistamp=Docmodulo.tdistamp",
                    BindTdoc = BindTdoc,
                    Condicao =$" where Codigo='{Modulo.Trim()}'"
                };
                bw.ShowForm(this, true);
            }
            else
            {
                MsBox.Show("Desculpe não há nenhum documento interno permitido para si!\r\nContacte o administrador.");
            }
        }

        public string Modulo { get; set; }
        public decimal TaxaCambio { get; private set; }
        public bool UpdateOrigem { get; private set; }

        public void BindTdoc(DataRow tdoc, bool origem = false)
        {
            if (tdoc == null) return;
            TmpTdi = tdoc.DrToEntity<Tdi>();
            SetValues(TmpTdi);
            Helper.ClearControls(this);
        }
        private void RefreshControls()
        {
            if (gridFormasP1 == null) return;
            gridFormasP1.Grelha.Columns["Bancoentrada"].Visible = false;
            gridFormasP1.Grelha.Columns["Contadestino"].Visible = false;
            tbNumero.IsReadOnly = TmpTdi.Alteranum;
            //gridUIFt1.Columns["Armazem"].Visible = TmpTdi.Armazem;
            gridUIFt1.Columns["arm"].Visible = TmpTdi.Armazem;
            gridUIFt1.Columns["Preco"].HeaderText = "Valor";
            gridFormasP1.Grelha.Columns["titulo"].HeaderText = "Tipo de movimento";
            GenDi.SetEntidade(TmpTdi, tbEntidade);
            tbEntidade.Visible = !TmpTdi.Noentid;
            #region Tranferencia entre armazens....
            Hidcolumns(TmpTdi.Trf);
            gridUIFt1.Columns["Desconto"].Visible = TmpTdi.Trf;
            gridUIFt1.Columns["descarm2"].Visible =TmpTdi.Trf; 
            //gridUIFt1.Columns["Percdesc"].Visible =!TmpTdi.Trf; 
            //gridUIFt1.Columns["TabIVA"].Visible =!TmpTdi.Trf;
            //gridUIFt1.Columns["txiva"].Visible =!TmpTdi.Trf;
            //gridUIFt1.Columns["servico"].Visible =!TmpTdi.Trf;
            gridUIFt1.Columns["arm"].HeaderText = TmpTdi.Trf ? "Armazem Saída" : "Armazem";

            #endregion
            #region Requisicao de fundos.....

            gridFormasP1.Refresh(TmpTdi.Movtz ? 2 : 0);

            Hidcolumns(TmpTdi.Movtz);

            #endregion
            #region Transferencia entre contas

            if (TmpTdi.TrfConta)
            {
                gridFormasP1.Refresh(2);
                if (gridFormasP1?.Grelha != null)
                {
                    gridFormasP1.Grelha.Columns["Contadestino"].Visible = true;
                }

                if (tabControl1.TabPages.Contains(tabPageInicio))
                {
                    tabControl1.TabPages.RemoveAt(0);
                }
            }
            else
            {
                if (!tabControl1.TabPages.Contains(tabPageInicio))
                {
                    tabControl1.TabPages.Insert(0, tabPageInicio);
                }
            }

            #endregion
        }
        public override void UpdGridFormasp()
        {
            Helper.Codmovtz(TmpTdi.Movtz, TmpTdi.Codmovtz, TmpTdi.Descmovtz, gridFormasP1.Grelha,"di");
            if (!TmpTdi.TrfConta) return;
            if (gridFormasP1.Grelha.CurrentRow == null) return;
            gridFormasP1.Grelha.CurrentRow.Cells["trf"].Value = true;
            gridFormasP1.Grelha.CurrentRow.Cells["Codmovtz2"].Value = TmpTdi.Codmovtz2;
            gridFormasP1.Grelha.CurrentRow.Cells["Descmovtz2"].Value = TmpTdi.Descmovtz2;
            gridFormasP1.Grelha.CurrentRow.Cells["UsrLogin"].Value = Pbl.Usr.Usrstamp;
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
        private void gridUIFt1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!EditMode) return;
            if (gridUIFt1.CurrentRow == null) return;
            Helper.CellValueChanged(gridUIFt1.CurrentCell, this);
        }
        DataTable _dtIva;
        private void gridUIFt1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (gridUIFt1.CurrentRow == null) return;
            var name = gridUIFt1.CurrentCell.OwningColumn.Name.ToLower();
            string qry;//Refornec
            if (name.Equals("descricao") || name.Equals("ref1") || name.Equals("refornec"))
            {
                DataRow = ((DataRowView)gridUIFt1.CurrentRow.DataBoundItem).Row;
                DtSt = Helper.EditingControlShowing(e, name.ToLower()); 
            }

            else if (name.Equals("arm"))
            {
                DtArm = Helper.SetBinds(e.Control, "Descricao", Helper.GetArmazemQry());
            }
            else if (name.Equals("descarm2"))
            {
                DtArm = Helper.SetBinds(e.Control, "Descricao", Helper.GetArmazemQry());
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
                DtSt = null;
                var autoText = e.Control as TextBox;
                autoText.AutoCompleteCustomSource = null;
            }
        }
        private void gridUIFt1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (!e.Exception.Message.Contains("DataGridViewComboBoxCell value is not valid")) return;
            if (gridUIFt1.Columns[e.ColumnIndex].Name.Equals("TabIVA"))
            {
                e.ThrowException = false;
            }
        }
        private void gridUIFt1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var nome = gridUIFt1.CurrentCell.OwningColumn.Name.ToLower();
            if (!TmpTdi.Sigla.Equals("GRC")&& !TmpTdi.Sigla.Equals("GRF")&& !TmpTdi.Sigla.Equals("EST"))
            {
                if (nome.Equals("descricao"))
                {
                    SetFactl("descricao");
                }
                if (nome.Equals("ref1"))
                {
                    SetFactl("Referenc");
                }
                if (nome.Equals("refornec"))
                {
                    SetFactl("Refornec");
                }
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
            }//descarm2
            if (nome.Equals("descarm2"))
            {
                SetArmazem2("descricao");
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
                Helper.Totaislinha(true, gridUIFt1.DsDt, this,TmpTdi.Sigla);
            }

            gridUIFt1.Update();
        }
        private void SetArmazem(string referenc)
        {
            if (gridUIFt1.CurrentCell?.Value == null) return;
            var valor = gridUIFt1.CurrentCell.Value.ToString().Trim();
            if (!(DtArm?.Rows.Count > 0)) return;
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

        private void SetArmazem2(string referenc)
        {
            if (gridUIFt1.CurrentCell?.Value == null) return;
            var valor = gridUIFt1.CurrentCell.Value.ToString().Trim();
            if (!(DtArm?.Rows.Count > 0)) return;
            var dr = DtArm.AsEnumerable().FirstOrDefault(s => s.Field<string>(referenc).Trim().Equals(valor));
            if (dr == null) return;
            switch (referenc)
            {
                case "descricao":
                    if (gridUIFt1.CurrentRow != null)
                    {
                        gridUIFt1.CurrentRow.Cells["Codarment"].Value = dr[0].ToString();
                        gridUIFt1.CurrentRow.Cells["Armazemstamp2"].Value = dr["Armazemstamp"].ToString();
                    }
                        
                    //
                    break;
                default:
                    if (gridUIFt1.CurrentRow != null)
                    {
                        gridUIFt1.CurrentRow.Cells["descarm2"].Value = dr[1].ToString();
                        gridUIFt1.CurrentRow.Cells["Armazemstamp2"].Value = dr["Armazemstamp"].ToString();
                    }
                        
                    break;
            }

            gridUIFt1.Update();

        }
        private void SetFactl(string campo)
        {
            //if (TmpTdi.Vendido) return;
            if (gridUIFt1.CurrentCell.Value == null) return;
            var valor = gridUIFt1.CurrentCell.Value.ToString().Trim();
            if (!(DtSt?.Rows.Count > 0)) return;
            var dr = DtSt.AsEnumerable().FirstOrDefault(s => s.Field<string>(campo).Trim().Equals(valor));
            if (dr != null)
                Addline(dr["Ststamp"].ToString().Trim());

        }
        private void gridUIFt1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //if (gridUIFt1.CurrentCell.OwningColumn.Name.Trim().ToLower().Equals("tabiva")) return;
            //Helper.CellEnter(sender,e);
        }
        private void gridUIFt1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (!NVerificar) return;
            NVerificar = false;
            Helper.CellValidated(gridUIFt1,this,TmpTdi.Sigla);
            //Helper.Totaislinha(true, gridUIFt1.DsDt, this,TmpTdi.Sigla);
            if (!TmpTdi.Movtz) return;
            if (gridFormasP1.Grelha.CurrentRow == null) return;
            gridFormasP1.Grelha.CurrentRow.Cells["Codmovtz"].Value = TmpTdi.Codmovtz;
            gridFormasP1.Grelha.CurrentRow.Cells["Descmovtz"].Value = TmpTdi.Descmovtz;
        }
        private void gridUIFt1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUIFt1.CurrentRow == null) return;
            if (!gridUIFt1.CurrentCell.OwningColumn.Name.ToLower().Trim().Equals("ivainc")) return;
            gridUIFt1.CurrentCell.Value = !gridUIFt1.CurrentCell.Value.ToBool();
            gridUIFt1.Update();
            Helper.Totaislinha(true, gridUIFt1.DsDt, this, TmpTdi.Sigla);
        }
        private void gridUIFt1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
;
        }
        public void Receive(DataGridViewRow dr)
        {
            if (gridUIFt1.CurrentRow == null) return;
            gridUIFt1.CurrentRow.Cells["TabIVA"].Value = dr.Cells[0].Value;
            gridUIFt1.CurrentRow.Cells["txiva"].Value = dr.Cells[1].Value;
            Helper.Totaislinha(true, gridUIFt1.DsDt, this, TmpTdi.Sigla);
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
        private void gridUIFt1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            NewGridLine();
            gridUIFt1.CurrentCell = gridUIFt1.Rows[gridUIFt1.Rows.Count - 1].Cells["Descricao"];
        }
        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            //MsBox.Show(e.TabPage.TabIndex.ToString());
            //if (e.TabPage.TabIndex==1)
            //{
            //    gridFormasP1.Grelha.EndEdit();
            //    var dt = gridFormasP1.Grelha.DataSource as DataTable;
            //    gridFormasP1.Grelha.DataSource = dt;
            //}
            
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            //if (TmpTdi.Trf)
            //{
            //    if (_di == null) return;
            //    var dt = GenBl.DiTrf(_di.Distamp);
            //    CallFormPrint(dt);
            //}
            //else if (TmpTdi.Sigla == "EN" || TmpTdi.Sigla == "SI" || TmpTdi.Sigla == "SD")
            //{
            //    if (_di == null) return;
            //    var dt = GenBl.DiMstk(_di.Distamp);
            //    CallFormPrint(dt);
            //}
            //else if (TmpTdi.Sigla == "RF" || TmpTdi.Sigla == "DB" || TmpTdi.Sigla == "LB")
            //{
            //    if (_di == null) return;
            //    var dt = GenBl.DiMvt(_di.Distamp);
            //    CallFormPrint(dt);
            //}
            //else
            //{
            //    if (_di == null) return;
            //    CallFormPrint();
            //}
            //if (_di == null) return;
            CallFormPrint();


        }

        private void CallFormPrint(DataTable dt=null)
        {
            //var p = new FrmReport
            //{
            //    Printstamp = _di.Distamp,
            //    Origem = "DI",
            //    ReportName = TmpTdi.Nomfile.Trim(),
            //    Dt = dt,
            //    CTituloRelatorio = _di.Nomedoc,
            //    RDLCXML = TmpTdi.XmlString,
            //    EntidadePrint = tbEntidade.label1.Text
            //};
            //p.ShowForm(this);

            DS ds = new DS();
            var dil = gridUIFt1.GetBindedTable();
            var formasp = gridFormasP1.Grelha.DataSource as DataTable;
            var ret = Imprimir.FillData(_di.ToDataTable(), dil, formasp, ds.Di, ds.Formasp);
            Imprimir.CallForm(ret.dtPrint, ret.fp, CLocalStamp, Inserindo, label1.Text, tbEntidade.Text2, TmpTdi.Nomfile, "DI", this, TmpTdi.XmlString, true, ds, "", "");
        }

        public void UpdateObjects(DataTable dt)
        {
            if (_di==null)
            {
                _di = new Di(); 
            }

            if (dt.HasRows())
            {
                var numdoc = dt.Rows[0]["Numdoc"].ToDecimal();
                TmpTdi = SQL.GetRowToEnt<Tdi>($"Numdoc={numdoc}"); //EF.GetEnt<Tdi>(p=>p.Numdoc.Equals($"{numdoc}"));
                panel1.Visible = false;
                panel3.Visible = false;
            }
        }

        //private bool dmzGridButtons1_BeforeAddLineEvent()
        //{

        //}
        public void ReceiveDataFromCopyLinhas(DataTable dt, DataTable dt2, string tabela, bool linhaResumo)
        {
            if (linhaResumo)
            {
                var dr = CriarLinha();
                var descricao = $@"{dt2.Rows[0]["Nomedoc"].ToString().Trim()} Nº: {dt2.Rows[0]["numero"].ToString().Trim()} de {dt2.Rows[0]["data"].ToDateTimeValue().ToShortDateString().Trim()}";
                dr["descricao"] = descricao;
                dr["servico"] = true;
                dr["Factstamp"] = CLocalStamp;
                dr["Factlstamp"] = Pbl.Stamp();
                gridUIFt1.DsDt.Rows.Add(dr);
            }
            if (dt.HasRows())
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
                        dr["distamp"] = CLocalStamp;
                        dr["dilstamp"] = Pbl.Stamp();
                        if (!row["servico"].ToBool())
                        {
                            if (row["Armazemstamp"].ToString().IsNullOrEmpty())
                            {
                                dr["Armazemstamp"] = Pbl.Usr.Armazemstamp;
                            }
                        }

                        if (!tabela.IsNullOrEmpty())
                        {
                            dr["remotestamp"] = row[$"{tabela.Trim()}lstamp"];
                            dr["Ststamp"] = row["Ststamp"];
                        }
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
                Helper.Totaislinha(true, gridUIFt1.DsDt, this, TmpTdi.Sigla);
            }
            if (dt2.HasRows())
            {
                _di.Oristamp = dt2.Rows[0]["stamp"].ToString();
                //.tb1.Text = dt2.Rows[0]["numero"].ToString();
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
        //public void ReceiveDataFromCopyLinhas(DataTable dt)
        //{
        //    if (!(dt?.Rows.Count > 0)) return;
        //    gridUIFt1.DsDt.Rows.Clear();
        //    foreach (var row in dt.AsEnumerable())
        //    {
        //        DataRow=Helper.NewGridRow(this);
        //        var tmpFound = EF.GetEnt<St>(x=>x.Referenc.Trim().Equals(row["ref"].ToString().Trim()));
        //        GenBl.SetLineValues(DataRow, tmpFound,_di,false,row,false,ucMoeda.tb1.Text,MoedaCambio.tb1.Text.ToLower().Trim(),tbEntidade.Text3);
        //        DataRow["Armazem"] = row["Codarm"];
        //        DataRow["Descarm"] = row["armazem"];
        //    }

        //   // di.Oristamp = dt.TableName.Equals("dil") ? dt.Rows[0]["distamp"].ToString() : dt.Rows[0]["Factstamp"].ToString();
        //    Helper.Totaislinha(true, gridUIFt1.DsDt, this, TmpTdi.Sigla);
        //}

        private void tbDefault2_Load(object sender, EventArgs e)
        {

        }

        private void gridPreco_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gridPreco.Anexos();
        }

        private void tbEntidade_RefreshControls()
        {

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

        private void btnValorPanelShow_Click(object sender, EventArgs e)
        {
            panelContravalor.Visible = !panelContravalor.Visible ;
            btnValorPanelShow.Image = panelContravalor.Visible ? Properties.Resources.Show_Sidepanel_25px : Properties.Resources.Hide_Sidepanel_25px;
        }

        private void btnDuplicar_Click(object sender, EventArgs e)
        {
            if (Procurou)
            {
                var drs = MsBox.Show("Deseja duplicar o presente documento?",DResult.YesNo);
                if (drs.DialogResult==DialogResult.Yes)
                {
                    CLocalStamp=Pbl.Stamp();
                    var maximo =SQL.Maximo("di","numero",CCondicao);
                    _di.Distamp = CLocalStamp;
                    dtDi.dt1.Value= Pbl.SqlDate;
                    dtVencimento.dt1.Value= Pbl.SqlDate.AddDays(30);
                    tbNumero.tb1.Text=maximo.ToString();
                    Helper.UpdateLinhas(CLocalStamp,gridUIFt1,gridFormasP1.Grelha,"di","dil");
                }
            }
        }

        private void cbNTesoura_CheckedChangeds()
        {

        }

        private void importarFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Helper.ChamaformImport("di", "dil", "", "Documentos Internos");
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (Procurou)
            {
                var drs = MsBox.Show("Deseja duplicar o presente documento?", DResult.YesNo);
                if (drs.DialogResult == DialogResult.Yes)
                {
                    CLocalStamp = Pbl.Stamp();
                    var maximo = SQL.Maximo("di", "numero", CCondicao);
                    _di.Distamp = CLocalStamp;
                    dtDi.dt1.Value = Pbl.SqlDate;
                    dtVencimento.dt1.Value = Pbl.SqlDate.AddDays(30);
                    tbNumero.tb1.Text = maximo.ToString();
                    Helper.UpdateLinhas(CLocalStamp, gridUIFt1, gridFormasP1.Grelha, "di", "dil");
                }
            }
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            if (Procurou)
            {
                CallBrowdoc();
            }
            else
            {
                MsBox.Show(Messagem.ParteInicial() + "Deve estar em modo de edição!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dmzOptions.ShowMenuStrip(button1);
        }

        private void copiarLinhasEmOutroDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!EditMode) return;
            var form = new FrmCopylinhas { SendData = ReceiveDataFromCopyLinhas };
            form.ShowForm(this, true);
        }

        private void importarGuiaDeEntregaParaRegularizaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!EditMode) return;
            if (!tbEntidade.tb1.Text.IsNullOrEmpty())
            {
                var form = new FrmCopylinhas { SendData = ReceiveDataFromCopyLinhas };
                var tab = SQL.GetGen2DT($"select numdoc,Descricao from tdoc where Ft=1");
                var campos = Helper.GetCampos<Factl>();
                campos = campos.Replace("Quant2", "xxxx");
                campos = campos.Replace("Quant", "Quant=(quant-quant2)");
                campos = campos.Replace("xxxx", "Quant2");
                if (tab.HasRows())
                {
                    form.documento.Text2 = tab.RowZero("numdoc").ToString();
                    form.documento.tb1.Text = tab.RowZero("Descricao").ToString();
                    form.cliente.Text2 = tbEntidade.Text2;
                    form.cliente.tb1.Text = tbEntidade.tb1.Text;
                    form.cbVendas.Update(true);
                    form.Campos = campos;
                }
                form.ShowForm(this, true);
                UpdateOrigem = true;
                cbMovstk.Update(false);
            }
            else
            {
                MsBox.Show("Deve indicar o cliente!");
            }
        }
    }
}
