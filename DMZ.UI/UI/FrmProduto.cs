using System;
using System.Collections.Generic;
using System.Data;
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


namespace DMZ.UI.UI
{
    public partial class FrmProduto : FrmClasse
    {

        //this.dmzOptionGroup2.Location = new System.Drawing.Point(575, 61);
        public FrmProduto() 
        {
            InitializeComponent();
            cMenu.BackColor = Color.FromArgb(39, 59, 80);
            cMenu.ForeColor = Color.White;
            cMenu.Font= new Font("Century Gothic",8,FontStyle.Regular );

            // Item 1, null in constructor to say : no picture on the label
            mi=new ToolStripMenuItem("Ver documentos",null , (s,a)=> VerDocumentos());
            //mi.BackColor = Color.Red;
            mi.Image = Properties.Resources.Accounting_22px;
            cMenu.Items.Add(mi);

            // Separator
            cMenu.Items.Add(new ToolStripSeparator());

            // Item 2
            mi=new ToolStripMenuItem("Copy",null , (s,a)=> CopyClick(s,a));
            //mi.BackColor = Color.Blue;
            cMenu.Items.Add(mi);
        }
        private St _st;
        public DataTable DtFnc { get; set; }
        public DataTable DtArm { get; set; }
        private DataTable DtCcu { get; set; }
        public bool Servico { get;  set; }
        public DataTable DtSt { get;  set; }
        public DataRow DataRow { get; set; }
        ContextMenuStrip cMenu = new ContextMenuStrip();
        ToolStripMenuItem mi;
        DataGridViewCell ActiveCell2;
        public string Origem { get; set; }
        private void FrmProduto_Load(object sender, EventArgs e)
        {
            Campo1 = "Referenc";
            Campo2 = "descricao";
            Ctabela ="st";
            switch (Origem)
            {
                case "Pr": 
                    label1.Text = "Cadastro de Produtos" ;
                    CCondicao = "Servico=0 and Viatura=0 and Activo=0";
                    btnMenuLateral.Visible = true;
                    Codigo = Pbl.Param.Codprod;
                    break;
                case "Sr":
                    tabControl1.Controls.Remove(tabPageArm);
                    tabControl1.Controls.Remove(tabPageFnc);
                    label1.Text = "Cadastro de Serviços" ;
                    btnMenuLateral.Visible = false;
                    CCondicao = "Servico=1";
                    Codigo = "SC";
                    Codigo = Pbl.Param.Codsrc;
                    break;
                case "AT":
                    tabControl1.Controls.Remove(tabPageFnc);
                    label1.Text = "Cadastro de Activos" ;
                    btnMenuLateral.Visible = false;
                    CCondicao = "Activo=1";
                    Codigo = "AT";
                    break;
            }
            tbDefault8.AutoIncrimento = false;
            tbDefault9.AutoIncrimento = false;
            if (gridPreco != null)
            {
                if (ParentForm == null) return;
                if (Pbl.Usr.Mostraprcompra)
                {
                    gridPreco.Columns["Pcompra"].Visible = false;
                    gridPreco.Columns["Perlucro"].Visible = false;
                }
                else
                {
                    gridPreco.Columns["Pcompra"].Visible = true;
                    gridPreco.Columns["Perlucro"].Visible = true;
                }
            }
            tbReferenc.IsUnique = true;
            Helper.UpdateGridColumns(gridPreco);
            if (gridPreco != null)
            {
                gridPreco.Columns["Preco"].HeaderText = Pbl.Param.Preconormal.IsNullOrEmpty() ? "Preço venda" : Pbl.Param.Preconormal;
            }
            
        }

        public string Codigo { get; set; }
        public override void DefaultValues()
        {
            _st = DoAddline<St>();
            if (Pbl.Param.Prodenum)
            {
                var xx = $@"Select Max(convert(bigint,dbo.UDF_ExtractNumbers(referenc)))+1 as maxvalue  from st";
                    //$@" select isnull(max(isnull(TRY_PARSE(right(ltrim(rtrim(Referenc)),{Pbl.Param.CodprodMascra.Length - 1})AS INT),0)),0)+1 as maxvalue from st where {CCondicao}";
                var dt = SQL.GetGenDT(xx);
                if (dt.HasRows())
                {
                    tbReferenc.tb1.Text = Helper.GetValueByMascara(Codigo, Pbl.Param.CodprodMascra, dt);
                }
            }
            switch (Origem)
            {
                case "Pr":
                    _st.Servico = false;
                    _st.Viatura = false;
                    _st.Activo=false;
                    cbServico.Update(false);
                    break;
                case "Sr":
                    _st.Viatura = false;
                    _st.Activo=false;
                    cbServico.Update(true);
                    break;
                case "Vt": 
                    _st.Servico = false;
                    _st.Viatura = true;
                    _st.Activo=false;
                    cbServico.Update(false);
                    break;
                case "AT": 
                    _st.Servico = false;
                    _st.Viatura = true;
                    _st.Activo=true;
                    cbServico.Update(false);
                    break;
            }
            status.SetStatusValue();
            var tabiva = SQL.GetGen2DT("select codigo,descricao from Auxiliar where Tabela=5 and Padrao=1 ");
            if (tabiva.HasRows())
            {
                TabIVa.tb1.Text = tabiva.Rows[0]["descricao"].ToString();
                TabIVa.Text2=tabiva.Rows[0]["codigo"].ToString();
            }
            var tabUnid = SQL.GetGen2DT("select codigo,descricao from Auxiliar where Tabela=6 and Padrao=1 ");
            if (tabUnid.HasRows())
            {
                Unidade.tb1.Text = tabUnid.Rows[0]["descricao"].ToString();
                Unidade.Text2 = tabUnid.Rows[0]["codigo"].ToString();
            }
           // gridPreco.AddLine();
            //if (gridPreco.CurrentRow != null)
            //{
            //    gridPreco.CurrentRow.Cells["Preco"].Value = 0;
            //    gridPreco.CurrentRow.Cells["ccusto"].Value = Pbl.Ccusto;
            //    gridPreco.CurrentRow.Cells["clnCodCCu"].Value = Pbl.Codccu;
            //}
            base.DefaultValues();
        }
        public override void Save()
        {
            
            FillEntity(_st);
            switch (Origem)
            {
                case "Sr":
                    _st.Viatura = false;
                    cbServico.Update(true);
                    break;
            }
            var xx = EF.Save(_st);
            if (xx.ret<0)
            {
                MsBox.Show(xx.msg, ScrollBars.Both);
            }
        }
        public override bool CheckDelete()
        {
            var dt = SQL.GetGenDT($"select top 1 ref from mstk where ref ='{tbReferenc.tb1.Text}'");
            if (!(dt?.Rows.Count > 0)) return base.CheckDelete();
            MsBox.Show($"Descupla mas o produto: \r\n {tbDescricao.tb1.Text} tem movimentos de stock emitidos já não se pode eliminar!.. ");
            return false;
        }
        public override bool BeforeSave()
        {
            if (!_st.Servico && string.IsNullOrEmpty(Unidade.tb1.Text))
            {
                MsBox.Show("Deve indicar a unidade de entrada!");
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
                        MsBox.Show("Estimado(a), Já exite Produto com a mesma referência, Verifique!");
                        return false;  
                    }
                }
            }
            if (!Servico)
            {
                if (_st.Usaquant2)
                {
                    if (gridUi2.DtDS?.Rows.Count == 0)
                    {
                        MsBox.Show("Deve indicar o preço de venda na tabela especical!");
                        return false;
                    }
                }
                else
                {
                    if (gridPreco.DtDS?.Rows.Count == 0)
                    {
                        MsBox.Show("Deve indicar o preço de compra e venda do produto!");
                        return false;
                    }
                }

                //if (!(gridPreco.DtDS?.Rows.Count > 0)) return base.BeforeSave();
                //foreach (var item in gridPreco.DtDS.AsEnumerable())
                //{
                //    if (item == null) continue;
                //    if (item["Preco"].ToDecimal()==0)
                //    {
                //        var dr =MsBox.Show("O Produto tem preço Zerro(0), deseja gravar?",DResult.YesNo);
                //        if (dr.DialogResult == DialogResult.No)
                //        {
                //            tabControl1.SelectTab(tabPagePrecos);
                //            return false;
                //        }
                //        continue;
                //    }
                //    if (!string.IsNullOrEmpty(item["CCusto"].ToString())) continue;
                //    MsBox.Show("Deve indicar o centro de custo, na tabela de preços!");
                //    return false;
                //}
                return base.BeforeSave();
            }

            return base.BeforeSave();
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            _st = FillControls(_st, dt, i);
            CLocalStamp=_st.Ststamp.Trim();
            GetStock();
        }

        private void GetStock()
        {
            var str =$@"Select * from STExtratoficha('{CLocalStamp.Trim()}') where stock <>0 order by descarm  ";           
            var dt=SQL.GetGen2DT(str);
            gridStock.SetDataSource(dt);
        }

        private void gridPreco_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var colName = gridPreco.CurrentCell.OwningColumn.Name.ToLower().Trim();
            if (colName.Equals("ccusto"))
            {
                DtCcu = Helper.SetBinds(e.Control, "descricao", "select codccu, descricao,Ccustamp from ccu");
            }
            else if(colName.Equals("moeda"))
            {
                Helper.SetBinds(e.Control, "Moeda", "select Moeda from moedas ");   
            }
        }
        private void gridPreco_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            var colName = gridPreco.CurrentCell.OwningColumn.Name;
            if (colName.Trim().Equals("ccusto"))
            {
                if (gridPreco.CurrentRow == null) return;//
                var valor = gridPreco.CurrentRow.Cells["ccusto"].Value.ToString().Trim();
                DataRow dr = null;
                if (!(DtCcu.HasRows())) return;
                foreach (var r in DtCcu.AsEnumerable())
                {
                    if (r == null) continue;
                    if (!r["descricao"].ToString().Trim().Equals(valor)) continue;
                    dr = r;
                    break;
                }
                if (dr == null) return;
                gridPreco.CurrentRow.Cells["codccu"].Value = dr["codccu"].ToString();//
                gridPreco.CurrentRow.Cells["Ccustamp"].Value = dr["Ccustamp"].ToString();//
            }

            if (colName.Trim().Equals("Perlucro"))
            {
                var perc = gridPreco.CurrentCell.Value.ToDecimal();
                if (gridPreco.CurrentRow == null) return;
                var valcompra = gridPreco.CurrentRow.Cells["Pcompra"].Value.ToDecimal();
                var valorVenda = valcompra + valcompra * perc / 100;
                gridPreco.CurrentRow.Cells["Preco"].Value = valorVenda;
            }

            if (!colName.Trim().Equals("Preco")) return;
            {
                if (gridPreco.CurrentRow == null) return;
                var valcompra = gridPreco.CurrentRow.Cells["Pcompra"].Value.ToDecimal();
                if (valcompra == 0) return;
                var valvenda = gridPreco.CurrentRow.Cells["Preco"].Value.ToDecimal();
                var perlucro = (valvenda - valcompra) * 100 / valcompra;
                gridPreco.CurrentRow.Cells["Perlucro"].Value = perlucro;
            }
        }

        private void gridUI1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (gridUI1.CurrentRow == null) return;
            var nome = gridUI1.CurrentCell.OwningColumn.Name.ToLower();
            var qry = "select Ststamp,Referenc,Descricao,preco=(select top 1 preco  from StPrecos where Ststamp=st.Ststamp ) from st ";
            if (nome.Equals("descricao"))
            {
                DtSt=Helper.SetBinds(e.Control, "Descricao", qry);
            }
            else if (nome.Equals("referenc"))
            {
                DtSt=Helper.SetBinds(e.Control, "Referenc", qry);
            }
            else
            {
                DtSt = null;
                var autoText = e.Control as TextBox;
                autoText.AutoCompleteCustomSource = null;
            }
        }
        private void gridUI1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var nome = gridUI1.CurrentCell.OwningColumn.Name.ToLower();
            if (nome.Equals("descricao"))            
                SetStcp("descricao");
            if (nome.Equals("referenc")) 
                SetStcp("Referenc");
        }

        private decimal _preco;
        private void SetStcp(string campo)
        {
            var valor = gridUI1.CurrentCell.Value.ToString().Trim();
            if (DtSt == null) return;
            var dr = DtSt.AsEnumerable().FirstOrDefault(s => s.Field<string>(campo).Trim().Equals(valor));
            if (dr == null) return;
            _preco = dr["preco"].ToDecimal();
            Addline(dr["Ststamp"].ToString().Trim());
        }
        private void SetStlValues(St st)
        {
            if (gridUI1.CurrentRow == null) return;
            gridUI1.CurrentRow.Cells["Quant"].Value = 1;
            gridUI1.CurrentRow.Cells["descricao"].Value = st.Descricao.Trim();
            gridUI1.CurrentRow.Cells["referenc"].Value = st.Referenc.Trim();
            gridUI1.CurrentRow.Cells["Valor"].Value = _preco;
            gridUI1.CurrentRow.Cells["servico"].Value = false;
            gridUI1.CurrentRow.Cells["Oristamp"].Value = st.Ststamp.Trim();
            gridUI1.CurrentRow.Cells["Total"].Value = _preco*1;            
        }
        public override void Addline(string referenc)
        {
            var tmpFound = SQL.GetRowToEnt<St>($" ltrim(rtrim(ststamp)) ='{referenc.Trim()}' ");
            SetStlValues(tmpFound);
            TotalCp();
        }

        private void TotalCp()
        {
            gridUI1.Update();
            tbTotal.tb1.Text = gridUI1.GetBindedTable().Sum("totall").ToString();
            tbTotal.tb1.Text.SetMask();
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

        private void gridUi3_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var colName = gridUi3.CurrentCell.OwningColumn.Name.ToLower().Trim();
            if (!colName.Equals("nome")) return;
            var auto = e.Control as TextBox;
            if (auto == null) return;
            var qry = "select no,nome from fnc ";
            DtFnc = Helper.SetBinds(e.Control, "nome", qry);
        }

        private void gridUi3_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUi3.CurrentCell == null) return;
            var valor = gridUi3.CurrentCell.Value.ToString().Trim();
            var dr = DtFnc?.AsEnumerable().FirstOrDefault(s => s.Field<string>("nome").Trim().Equals(valor));
            if (dr == null) return;
            if (gridUi3.CurrentRow != null)
                gridUi3.CurrentRow.Cells[0].Value = dr[0].ToString();
        }

        private void GridArmazens_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var colName = GridArmazens.CurrentCell.OwningColumn.Name.ToLower().Trim();
            if (!colName.Equals("arm")) return;
            var auto = e.Control as TextBox;
            if (auto == null) return;
            var qry = "select codigo, descricao from Armazem ";
            DtArm = Helper.SetBinds(e.Control, "descricao", qry);
        }

        private void GridArmazens_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (GridArmazens.CurrentCell == null) return;
            //if (Procurou) return;
            var valor = GridArmazens.CurrentCell.Value.ToString().Trim();
            var dr = DtArm?.AsEnumerable().FirstOrDefault(s => s.Field<string>("descricao").Trim().Equals(valor));
            if (dr == null) return;
            if (GridArmazens.CurrentRow != null)
                GridArmazens.CurrentRow.Cells[0].Value = dr[0].ToString();
        }

        private void gridUi3_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //ActiveCell(sender, e);
        }

        private void ActiveCell(object sender, DataGridViewCellEventArgs e)
        {
            var validClick = e.RowIndex != -1 && e.ColumnIndex != -1;
            if (!validClick) return;
            var datagridview = sender as DataGridView;
            if (!(datagridview?.Columns[e.ColumnIndex] is DataGridViewTextBoxColumn)) return;
            datagridview.BeginEdit(true);
        }

        private void GridArmazens_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           // ActiveCell(sender, e);
        }

        private void gridUI1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //ActiveCell(sender, e);
        }

        private void gridPreco_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //ActiveCell(sender, e);
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

        private void GravaProduto()
        {
            var lista = Helper.CamposObrigatorios(this);
            if (GravarNovo)
            {
                
                if (lista.Count == 0)
                {
                    if (BeforeSave())
                    {
                        Save();
                        OnGravaFilhas();
                        AfterSave();
                        Procurou = true;
                        //progressBar1.Value = 0;
                        lblMessage.Text = "Gravado com sucesso";
                        //timer1.Start();
                    }
                    else
                    {
                        Cancelado = true;
                    }
                }
                else
                {
                    Helper.CheckRequered(lista);
                }
            }
            if (Actualizando)
            {
                if (lista.Count == 0)
                {
                    Save();
                    OnGravaFilhas();
                    AfterSave();
                    Lista = new List<string>();
                    //progressBar1.Value = 0;
                    //lblMessage.Text = "Actualizado com Sucesso";
                    //timer1.Start();
                }
                else
                {
                    Helper.CheckRequered(lista);
                }
            }

            if (!Cancelado)
            {
                EstadoDaTela(AccaoNaTela.Padrao);
                HabilitaCampo();
            }
            Cancelado = false;
        }

        //private string GetCodFam(string tb1Text)
        //{
        //    var retorno="";
        //        var dt= SQL.GetGen2DT($"select codigo from Familia where descricao='{tb1Text.Trim()}' ");
        //        if (dt?.Rows.Count>0)
        //        {
        //            retorno = dt.Rows[0][0].ToString();
        //        }
        //        return retorno;
        //}

        private void GridArmazens_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            var hittestinfo = GridArmazens.HitTest(e.X, e.Y);
            if (hittestinfo == null || hittestinfo.Type != DataGridViewHitTestType.Cell) return;
            ActiveCell2 = GridArmazens[hittestinfo.ColumnIndex, hittestinfo.RowIndex];
            var nome = ActiveCell2.OwningColumn.Name;
            if (!nome.Equals("Reservado") && !nome.Equals("Encomendado")) return;
            ActiveCell2.Selected = true;
            cMenu.Show(GridArmazens,new Point(e.X,e.Y));
        }
        private void CopyClick(object sender, EventArgs e)
        {
            if (ActiveCell2 != null && ActiveCell2.Value != null)
                Clipboard.SetText(ActiveCell2.Value.ToString());
        }

        private void VerDocumentos()
        {
            if (ActiveCell2 == null || ActiveCell2.Value == null) return;
            var nome = ActiveCell2.OwningColumn.Name;
            var row = ActiveCell2.OwningRow;
            var f= new FrmViewDocs();
            if (nome != null && nome.Equals("Reservado"))
            {
                f.Condicao = $"ref ='{row.Cells["refere"].Value}' and Reserva=1";
                f.Encomenda = false;
            }
            if (nome != null && nome.Equals("Encomendado"))
            {
                f.Condicao = $"ref ='{row.Cells["refere"].Value}' and Encomenda=1";
                f.Encomenda = true;
            }
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowForm(this);
        }

        private void gridPanel21_AfterAddLineEvent()
        {
            if (gridPreco.CurrentRow == null) return;
            gridPreco.CurrentRow.Cells["ccusto"].Value = Pbl.Usr.Ccusto;
            gridPreco.CurrentRow.Cells["codccu"].Value = Pbl.Usr.Codccu;
            gridPreco.CurrentRow.Cells["Ccustamp"].Value = Pbl.Usr.Ccustamp;
            gridPreco.CurrentRow.Cells["Moeda"].Value = Pbl.MoedaBase;
        }

        private void Familia_RefreshControls()
        {
            subFamilia.Condicao = $"f.Codigo ='{Familia.Text2.Trim()}'";
            var val = SQL.GetValue($"select cpoc from Familia where Codigo='{Familia.Text2.Trim()}'");
            if (!string.IsNullOrEmpty(val))
            {
                cpoc.tb1.Text = val;
            }
        }

        private void listagemDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FrmProdListOptions();
            f.ShowForm(this);
        }

        private void extratoPorFamiliasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FrmExtprodfam() ;
            f.ShowForm(this);
        }

        private void procura8_RefreshControls()
        {
            tbModelo.Condicao = $"a.Codigo={procura8.Text2.ToDecimal()}";
        }

        private void GridArmazens_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            var col = GridArmazens.CurrentCell.OwningColumn.Name;
            decimal stockmin = 0;
            if (col.Equals("clnstockmin"))
            {
                foreach (DataGridViewRow row in GridArmazens.Rows)
                {
                    if (row==null) continue;
                    stockmin = stockmin + row.Cells["clnstockmin"].Value.ToDecimal();
                }

                //Stockmin.tB1.Text = stockmin.ToString();
            }
            decimal stockmax = 0;
            if (col.Equals("stockmax"))
            {
                foreach (DataGridViewRow row in GridArmazens.Rows)
                {
                    if (row==null) continue;
                    stockmax = stockmax + row.Cells["stockmax"].Value.ToDecimal();
                }

                //tbDefault7.tB1.Text = stockmax.ToString();
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

        private void gridPreco_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridPreco.CurrentRow ==null) return;
                gridPreco.BeginEdit(true);
        }

        private void btnRefreshCc_Click(object sender, EventArgs e)
        {
            GetStock();
        }

        private void gridStock_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //if (gridStock.CurrentRow.Cells["descarm"].Value.ToString().Trim().Equals("TOTAL ARMAZENS"))
            //{
            //    gridStock.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
            //}
                //foreach (DataGridViewRow Myrow in gridStock.Rows)
                //{
                //    if (Myrow.Cells)
                //    {
                //        Myrow.DefaultCellStyle.ForeColor = Color.Red;                      
                //    }
                //}
        }

        private void importarProdutosSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void gridUI1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUI1.CurrentRow == null) return;
            NVerificar = true;
            gridUI1.CurrentRow.Cells["total"].Value = gridUI1.CurrentRow.Cells["Valor"].Value.ToDecimal() * gridUI1.CurrentRow.Cells["Quant"].Value.ToDecimal();
        }

        private void gridUI1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUI1.CurrentRow == null) return;
            if (NVerificar)
            {
                TotalCp();
            }
            NVerificar=false;
        }

        private void btnSettingTextBox_Click(object sender, EventArgs e)
        {
            TextBoxSetting.ShowMenuStrip(btnSettingTextBox);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            tbDescricao.tb1.ToUpperX();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            tbDescricao.tb1.ToLowerX();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            tbDescricao.tb1.ToTitleCaseX();
        }

        private void btnActpreco_Click(object sender, EventArgs e)
        {
            if (EditMode)
            {
                if (gridPreco.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in gridPreco.Rows)
                    {
                        if (row != null)
                        {
                            row.Cells["Preco"].Value = tbTotal.tb1.Text;
                        }
                    }
                }
                else
                {
                    gridPanelPreco.btnNovo.PerformClick();
                    if (gridPreco.CurrentRow == null) return;
                        gridPreco.CurrentRow.Cells["Preco"].Value = tbTotal.tb1.Text;                 
                }
                gridPreco.Update();
            }
        }
        private void iNFODMZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helper.ChamaformImport("st", "StPrecos", "", "Produtos");
        }
        private void pRIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helper.ChamaformImport("Artigo", "StPrecos", "", "Produtos","PRI");
        }
    }
}
