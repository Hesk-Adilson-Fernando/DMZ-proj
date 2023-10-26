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
using DMZ.UI.UC;
using DMZ.UI.UI;
using Utilities = DMZ.BL.Classes.Utilities;

namespace DMZ.UI.IMB
{
    public partial class FrmActivo : FrmClasse
    {
        public FrmActivo() 
        {
            InitializeComponent();
        }
        private St _st;
        private St2 _st2;
        public bool Servico { get;  set; }

        public string Origem { get; set; }
        private void FrmProduto_Load(object sender, EventArgs e)
        {
            tbDescricao.ToUpperCase = true;
            tbReferenc.ToUpperCase = true;
            Campo1 = "Referenc";
            Campo2 = "descricao";
            Ctabela ="st"; 
            para = Pbl.Param;
            CCondicao = "Activo=1";
            Codigo = "IMO";
            tbDefault8.AutoIncrimento = false;
            tbDefault9.AutoIncrimento = false;

            tbReferenc.IsUnique = true;
        }
        public string Codigo { get; set; }

        private Param para { get; set; }
        public override void DefaultValues()
        {
            _st = DoAddline<St>();
            _st2 = DoAddline<St2>();
            _st2.Ststamp=_st.Ststamp;
            _st2.Duodessimos = SQL.GetValue("Duodessimos", "param").ToBool();
            if (para != null)
            {
                if (para.Prodenum)
                {
                    var xx = $@" select isnull(max(isnull(TRY_PARSE(right(ltrim(rtrim(Referenc)),{para.CodprodMascra.Length - 1})AS INT),0)),0)+1 as maxvalue from st where {CCondicao}";
                    var dt = SQL.GetGenDT(xx);
                    if (dt?.Rows.Count > 0)
                    {
                        tbReferenc.tb1.Text =Helper.GetValueByMascara(Codigo,para.CodprodMascra,dt);
                    }
                }
            }
            _st.Servico = false;
            _st.Activo = true;
            _st.Viatura = false;
            status.SetStatusValue();
            var tabiva = SQL.GetGen2DT("select codigo,descricao from Auxiliar where Tabela=5 and Padrao=1 ");
            if (tabiva?.Rows.Count>0)
            {
                TabIVa.tb1.Text = tabiva.Rows[0]["descricao"].ToString();
                TabIVa.Text2=tabiva.Rows[0]["codigo"].ToString();
            }
            var tabUnid = SQL.GetGen2DT("select codigo,descricao from Auxiliar where Tabela=6 and Padrao=1 ");
            if (tabUnid?.Rows.Count > 0)
            {
                Unidade.tb1.Text = tabUnid.Rows[0]["descricao"].ToString();
                Unidade.Text2 = tabUnid.Rows[0]["codigo"].ToString();
            }
            base.DefaultValues();
        }
        public override void Save()
        {            
            FillEntity(_st);
            FillEntity(_st2);
            _st.Servico=false;
            _st.Viatura=false;
            _st.Activo=true;
            EF.Save(_st);
            EF.Save(_st2,"ststamp");
        }
        public DataTable DtFnc { get; private set; }

        public override bool BeforeSave()
        {
            if (!_st.Servico && string.IsNullOrEmpty(Unidade.tb1.Text))
            {
                MsBox.Show(Messagem.ParteInicial()+"Deve indicar a unidade de entrada!");
                return false;
            }
            if (tbReferenc.IsUnique)
            {
                if (Inserindo)
                {
                    if (SQL.CheckExist($"select referenc from st where referenc='{tbReferenc.tb1.Text.Trim()}' and servico=0 and viatura =0"))
                    {
                        MsBox.Show("Estimado(a), Já exite Produto com a mesma referência, Verifique!");
                        return false;  
                    }
                }
                if (Procurou)
                {
                    var dt = SQL.GetGen2DT($"select referenc from st where referenc='{tbReferenc.tb1.Text.Trim()}' and servico=0 and viatura =0 and ltrim(rtrim(ststamp)) ='{CLocalStamp.Trim()}'");
                    if (dt?.Rows.Count>1)
                    {
                        MsBox.Show(Messagem.ParteInicial()+"Estimado(a), Já exite Produto com a mesma referência, Verifique!");
                        return false;  
                    }
                }
            }
            return base.BeforeSave();
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            _st = FillControls(_st, dt, i);
            _st2= SQL.GetRowToEnt<St2>($"Ststamp='{_st.Ststamp.Trim()}'"); // EF.GetEnt<St2>(x=>x.Ststamp.Trim().Equals(_st.Ststamp.Trim()));
            if (_st2!=null)
            {
                //FillControls(_st2, dt, i,true);
                FillControls(_st2);
            }
            else
            {
                _st2 = DoAddline<St2>();
                _st2.Ststamp = _st.Ststamp.Trim();
                FillControls(_st2);
            }
            CLocalStamp=_st.Ststamp.Trim();

        }
        public void FillControls(St2 entity) 
        {
            var controls = Helper.GetAll(this, typeof(TbDefault)).ToList();
            var dtp = Helper.GetAll(this, typeof(DtDefault)).ToList();
            controls.AddRange(dtp);
            var pr = Helper.GetAll(this, typeof(Procura)).ToList();
            controls.AddRange(pr);
            var cb = Helper.GetAll(this, typeof(CbDefault)).ToList();
            controls.AddRange(cb);
            var imgGroup = Helper.GetAll(this, typeof(ImgGroup)).ToList();
            controls.AddRange(imgGroup);
            var dmzOptionGroup = Helper.GetAll(this, typeof(DmzOptionGroup)).ToList();
            controls.AddRange(dmzOptionGroup);
            foreach (var ctrl in controls)
            {
                switch (ctrl)
                {
                    case DmzOptionGroup opt:
                        {
                            opt.ClearAllValue();
                            if (opt.Value != null)
                            {
                                var p = Utilities.GetProperty(opt.Value, entity);
                                opt.BindValue(p.GetValue(entity, null).ToString());
                            }

                            break;
                        }
                    case TbDefault tb:
                        {
                            if (!tb.Value.IsNullOrEmpty())
                            {
                                var p = Utilities.GetProperty(tb.Value, entity);
                                if (p != null)
                                {
                                    tb.tb1.Text = p.GetValue(entity, null)?.ToString();
                                    if (tb.IsNumeric)
                                    {
                                        tb.tb1.Text = tb.tb1.Text.SetMask();
                                    }
                                    if (!string.IsNullOrEmpty(tb.Value2))
                                    {
                                        var p2 = Utilities.GetProperty(tb.Value2, entity);
                                        tb.Text2 = p2.GetValue(entity, null).ToString();
                                    }
                                }
                            }
                            break;
                        }
                    case DtDefault dp:
                        {
                            if (!dp.Value.IsNullOrEmpty())
                            {
                                var p2 = Utilities.GetProperty(dp.Value, entity);
                                if (p2 != null)
                                {
                                    dp.dt1.Value = p2.GetValue(entity, null)==null? Pbl.SqlDate: p2.GetValue(entity, null).ToDateTimeValue();
                                }

                            }
                            break;
                        }
                    case Procura prx:
                        {

                            if (prx.Value != null)
                            {
                                var p = Utilities.GetProperty(prx.Value, entity);
                                if (p != null)
                                {
                                    prx.tb1.Text = p.GetValue(entity, null)?.ToString();
                                }
                            }
                            if (!string.IsNullOrEmpty(prx.Value2))
                            {
                                var p2 = Utilities.GetProperty(prx.Value2, entity);
                                if (p2 != null)
                                {
                                    prx.Text2 = p2.GetValue(entity, null)?.ToString();
                                }
                            }
                            if (!string.IsNullOrEmpty(prx.Value3))
                            {
                                var p3 = Utilities.GetProperty(prx.Value3, entity);
                                if (p3 != null)
                                {
                                    prx.Text3 = p3.GetValue(entity, null)?.ToString();
                                }
                            }
                            break;
                        }
                    case CbDefault default3:
                        {
                            if (!(default3.Parent is DmzOptionGroup))
                            {
                                var cbx = default3;
                                if (cbx.Value != null)
                                {
                                    var p = Utilities.GetProperty(cbx.Value, entity);
                                    if (p != null)
                                    {
                                        cbx.cb1.Checked = p.GetValue(entity, null).ToBool();
                                        cbx.btnCheck.Image = cbx.cb1.Checked ? Properties.Resources.Checked_Checkbox_2_23px : Properties.Resources.Unchecked_Checkbox_23px;
                                    }
                                }
                            }
                            break;
                        }

                    //case ImgGroup img:
                    //    {
                    //        if (img.Value != null)
                    //        {
                    //            var p = BL.Classes.Utilities.GetProperty(img.Value, entity);

                    //            if (p != null)
                    //            {
                    //                if (p.GetValue(entity, null) != null)
                    //                {
                    //                    //var array = Encoding.ASCII.GetBytes(valor.ToString());
                    //                    var imagem = Utilities.ByteToImage((byte[])p.GetValue(entity, null));
                    //                    img.pictureBox1.Image = imagem;
                    //                }
                    //                else
                    //                {
                    //                    img.pictureBox1.Image = null;
                    //                }
                    //            }
                    //        }
                    //        break;
                    //    }
                }
            }

        }
        public override void Addline(string referenc)
        {
            //var tmpFound = EF.QEnt<St>($" ltrim(rtrim(ststamp)) ='{referenc.Trim()}' ");
            //SetStlValues(tmpFound);
            //gridUI1.Update();
        }

        private void extratoDoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CLocalStamp))
            {
                var f = new FrmExtprod {Ststamp = CLocalStamp, txtDescricao = {Text = _st.Descricao}};
                f.ShowForm(this);
            }
            else
            {
                MsBox.Show("Deve indicar  um produto que pretender ver o extrato!");
            }
        }
        private void btnMenuLateral_Click(object sender, EventArgs e)
        {
            dmzContextMenuStrip1.ShowMenuStrip(btnMenuLateral);
        }

        private void importarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ipor = new DataImport
            {
                TopLevel = true,
                ShowInTaskbar = false,
                StartPosition = FormStartPosition.CenterScreen
            };
            ipor.Enviadados += RecebeDados;
            ipor.ShowDialog();
        }

        private void RecebeDados(DataRow dr)
        {
            BeginInvoke((Action) delegate
            {
                btnNovo.PerformClick();
                _st.Ststamp = Pbl.Stamp("MMC");
                Familia.tb1.Text = dr["Familia"].ToString();
                Familia.Text2 = dr["Codfam"].ToString();
                tbDescricao.tb1.Text = dr["Descricao"].ToString();
                tbReferenc.tb1.Text = string.IsNullOrEmpty(dr["Referenc"].ToString()) ? dr["Descricao"].ToString() : dr["Referenc"].ToString();
                _st.Obs = dr["Obs"].ToString();
                //Stockmin.tB1.Text = "100";
                TabIVa.Text2 = dr["Tabiva"].ToString();
                TabIVa.tb1.Text = dr["Txiva"].ToString();
                Unidade.tb1.Text = dr["Unidade"].ToString();
                subFamilia.tb1.Text=dr["Subfamilia"].ToString();
                var stpreco = SQL.GetGen2DT("select * from stprecos where 1=0");
                var dr2 = stpreco.NewRow();
                dr2["StPrecostamp"]= Pbl.Stamp();
                dr2["Ststamp"]= _st.Ststamp;
                dr2["CodCCu"]= dr["CodCcu"];
                dr2["CCusto"] = dr["CCusto"];
                dr2["Preco"] = dr["Preco"];
                dr2["ivainc"] = true;
                stpreco.Rows.Add(dr2);


                var starm = SQL.GetGen2DT("select * from Starm where 1=0");
                var dr3 = starm.NewRow();
                dr3["Starmstamp"]= Pbl.Stamp();
                dr3["Ststamp"]= _st.Ststamp;
                dr3["Codarm"]= dr["Codarm"];
                dr3["Descricao"]= dr["Armazem"];
                dr3["ref"] = tbReferenc.tb1.Text.Trim();
                starm.Rows.Add(dr3);
                FillEntity(_st);
                _st.Stockmin = 100;
                EF.Save(_st);
                SQL.Save(stpreco, "StPrecos", true, CLocalStamp, "st");
                SQL.Save(starm, "Starm", true, CLocalStamp, "st");
                EstadoDaTela(AccaoNaTela.Padrao);
            });

        }

        private void listagemDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FrmProdListOptions();
            f.ShowForm(this);
        }
        private void extratoPorFamiliasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!tbDescricao.tb1.Text.IsNullOrEmpty())
            {
                if (!cbNaodep.cb1.Checked)
                {
                    var f = new FrmDep(this) ;
                    f.txtPercentagem.tB1.Text = tbPercent.tb1.Text;
                    f.cbDuod.Update(cbDuodessimos.cb1.Checked); 
                    f.cbQuotas.Update(cbQuotas.cb1.Checked); 
                    f.ShowForm(this);
                }
                else
                {
                    MsBox.Show(Messagem.ParteInicial() + "Desculpa este artigo não pode ser depreciado, veja a opção na página de dados fiscais!");
                    //tabControl1.SelectedTab = tabPageFiscais;
                }
            }
            else
            {
                MsBox.Show(Messagem.ParteInicial() + "Deve seleçionar o artigo a depreciar!");
            }
        }
        private void mapaDeVendasPorMesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FrmProdVend {Origem = "VENDA",Titulo = "Listagem de produtos vendidos"};
            f.cbDetalhado.Update(true);
            f.ShowForm(this);
        }

        private void últimasComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FrmProdVend {Origem = "COMPRA", Titulo = "Listagem de produtos comprados"};
            f.cbDetalhado.Update(true);
            f.ShowForm(this);
        }
        private void gridUi1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // determine if click was on our date column
            var nome =gridUi1.CurrentCell.OwningColumn.Name.Trim();
            if (nome.Equals("DtTermino") || nome.Equals("Inicio"))
            {
                Helper.AddDateTimePicker(gridUi1, e);
            }
            gridUi1.Anexos();
        }

        private void gridUi1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (gridUi1.CurrentRow == null) return;
            var qry = "select Descricao from Auxiliar where tabela=17";
            var name = gridUi1.CurrentCell.OwningColumn.Name.ToLower();
            if (name.Equals("tipodoc"))
            {
                Helper.SetBinds(e.Control, "Descricao", qry);
            }
            else if (name.Equals("entidade"))
            {
                qry = "select Descricao from Auxiliar where tabela in('15','16','18')";
                Helper.SetBinds(e.Control, "Descricao", qry);
            }
        }
        private void gridUi7_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var colName = gridUi7.CurrentCell.OwningColumn.Name.ToLower().Trim();
            if (!colName.Equals("nome")) return;
            var auto = e.Control as TextBox;
            if (auto == null) return;
            var qry = "select no,nome from fnc ";
            DtFnc = Helper.SetBinds(e.Control, "nome", qry);
        }

        private void gridUi7_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUi7.CurrentCell == null) return;
            var valor = gridUi7.CurrentCell.Value.ToString().Trim();
            var dr = DtFnc?.AsEnumerable().FirstOrDefault(s => s.Field<string>("nome").Trim().Equals(valor));
            if (dr == null) return;
            if (gridUi7.CurrentRow != null)
                gridUi7.CurrentRow.Cells[0].Value = dr[0].ToString();
        }

        private void procura1_RefreshControls()
        {
            var campos =SQL.GetRow($"select subgrupo,Grupo,Perc1 from TabelaAmort where codigo='{procura1.Text2.Trim()}'");
            if (campos == null) return;
            tbGrupo.tb1.Text=campos["Grupo"].ToString();
            tbSubgrupo.tb1.Text=campos["subgrupo"].ToString();
            tbPercent.tb1.Text = campos["Perc1"].ToString();
            tbVidaFiscal.tb1.Text = (100 / campos["Perc1"].ToDecimal()).ToDecimal().ToRound((int)Pbl.Param.Aredondamento).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gridUiContabilistico.DellLine();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gridUiFiscal.DellLine();
        }

        private void cbDegressiva_CheckedChangeds()
        {
            cbDuodessimos.Update(!cbQuotas.cb1.Checked);
        }

        private void cbDuodessimos_CheckedChangeds()
        {
            cbQuotas.Update(!cbDuodessimos.cb1.Checked);
        }
    }
}
