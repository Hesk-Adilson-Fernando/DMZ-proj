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
using DMZ.UI.Generic;
using DMZ.UI.Reports;

namespace DMZ.UI.UI.PRC
{
    public partial class FrmCp1 : FrmClasse
    {
        public FrmCp1()
        {
            InitializeComponent();
        }
        public Tdocf TmpTdocf;
        public DataTable DtArm { get; set; }
        public DataRow DataRow { get; set; }
        public bool LRunStk { get; set; }
        private Facc _facc;
        public Fnc Cl;
        public string Pjstamp { get; set; } = "";
        public DataTable DtSt { get; private set; }

        public void BindTdoc(DataRow tdoc, bool origem = false)
        {
            if (tdoc == null) return;
            TmpTdocf = tdoc.DrToEntity<Tdocf>();
            SetValues(TmpTdocf);
        }

        private void SetValues(Tdocf tmpTdocf)
        {
            label1.Text = tmpTdocf.Descricao;
            Helper.ClearControls(this);
            gridFormasP1.Refresh(TmpTdocf.Numdoc);
            gridFormasP1.Movtz = tmpTdocf.Movtz;
            panelAprovaPagamento.Visible = tmpTdocf.Usaprovacao;
            Checkfactura();
            CCondicao = $"numdoc={tmpTdocf.Numdoc} and year(data) = {Pbl.SqlDate.Year} ";
        }
        private void Checkfactura()
        {
            if (TmpTdocf.Ft)
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
            if (!TmpTdocf.Vd) return;
            btnAnular.Visible = false;
            btnDelete.Enabled = false;
        }
        public Usr Us { get; set; }
        public Usr Usrr { get; set; }
        public bool OrigReserva { get; set; }

        private void FrmCompra_Load(object sender, EventArgs e)
        {
            Campo1 = "Numero";
            Campo2 = "Nome";
            Ctabela = "facc";
            TmpTdocf = SQL.GetRowToEnt<Tdocf>(Tdocfcondicao);
            try
            {
                if (Origem != "Pos")
                {
                    Us = Pbl.Usr;
                }
                else
                {
                    Us = Usrr;
                }
            }
            catch (Exception)
            {
                //
            }
            SetValues(TmpTdocf);
            gridFormasP1.BindGridView(EditMode);
            MultiDoc = true;
        }
        public override void DefaultValues()
        {
            _facc = DoAddline<Facc>();
            Noneg = TmpTdocf.Noneg;
            _facc.Sigla = TmpTdocf.Sigla;
            _facc.Numdoc = TmpTdocf.Numdoc;
            _facc.Nomedoc = TmpTdocf.Descricao;
            _facc.Codmovstk = TmpTdocf.Codmovstk;
            _facc.Descmovstk = TmpTdocf.Descmovstk;
            _facc.Movtz = TmpTdocf.Movtz;
            _facc.Movstk = TmpTdocf.Movstk;
            _facc.Movcc = TmpTdocf.Movcc;
            _facc.Pjstamp = tbPj.Text3;
            dtVencimento.dt1.Value = Pbl.GetDate(30);
            _facc.Descmovcc = TmpTdocf.Descmovcc;
            _facc.Codmovcc = TmpTdocf.Codmovcc;
            //_facc.Ccusto = Pbl.Ccusto;
            //tbCcusto.tb1.Text= Pbl.Ccusto;
            _facc.Encomenda = OrigReserva;
            //var m = SQL.GetRowToEnt<Moedas>($"Ststamp='{referenc.Trim()}'"); //EF.GetEnt<Moedas>(p=>p.Princip.Equals(true));
            ucMoeda.tb1.Text = Pbl.MoedaBase; //m.Moeda.Trim();
           // ucMoeda.Text2 = m.Descricao.Trim();
            base.DefaultValues();
            if (!OrigReserva)
            {
                DataRow = Helper.NewGridRow(this);
            }

            if (TmpTdocf.Coment.ToDecimal() != 0)
            {
                if (TmpTdocf.Coment.ToDecimal() > tbNumero.tb1.Text.ToDecimal())
                {
                    //if (_param.Usamascfact) return;
                    tbNumero.tb1.Text = TmpTdocf.Coment;
                }
            }
            dtVencimento.dt1.Value = Pbl.GetDate((int)TmpTdocf.Dias);
            if (TmpTdocf.Usaprovacao)
            {
                if (Us.AprovaPagamento)
                {
                    tbAprodador.Text2 = Us.Numero.ToString();
                    tbAprodador.tb1.Text = Us.Nome;
                }
            }
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
            if (TmpTdocf.Ft || TmpTdocf.Nc || TmpTdocf.Vd)
            {
                var us = Pbl.Usr;
                //GenBl.ExecAudit(_facc, Name, us);
            }
        }
        public override bool BeforeSave()
        {
            _facc.Data = dtFact.dt1.Value;

            #region Verifica se a factura é fazia ou igual a zero ou nao

            if (TmpTdocf.Ft || TmpTdocf.Vd || TmpTdocf.Nc || TmpTdocf.Nd)
            {
                if (tbTotal.tb1.Text.ToDecimal()<=0)
                {
                    MsBox.Show("Os Documentos: \r\nFactura\r\nVenda a Dinheiro\r\nNota de crédito\r\nNota de débito\r\nNão podem gravar com valor zero");
                    return false;
                }
            }

            #endregion

            #region Verificação de Stock dos produtos a serem facturados 
            var values = GenBl.CheckStock(_facc, gridUIFt1.DsDt, TmpTdocf.Usalote);
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
            if (cbAprovado.cb1.Checked)
            {
                if (Us.AprovaPagamento)
                {
                    if (Us.ValorMaxPagamento < tbTotal.tb1.Text.ToDecimal())
                    {
                        MsBox.Show($"O Usuário: {Us.Nome} não autorizar o valor acima do seu parametro!");
                        return false;
                    }
                }
                else
                {
                    MsBox.Show($"O Usuário: {Us.Nome} não tem permissão de aprovar compras!");
                    return false;
                }
            }
            return base.BeforeSave();
        }

        public override void AfterSave()
        {
            if (TmpTdocf.Ft || TmpTdocf.Vd)
            {
                //var dt = gridUIFt1.DataSource as DataTable;
                //var actualizapreco = SQL.GetFieldValue("param", "Autoprecos");
                //if (actualizapreco.ToBool())
                //{
                //    var dtPrcparam = SQL.GetGen2DT("select * from parampv");
                //    if (dtPrcparam?.Rows.Count<=0) return;
                //    if (dt?.Rows.Count<=0) return;
                //    decimal preco;
                //    decimal precovenda;
                //    decimal factor;
                //    var count = dtPrcparam?.Rows.Count;
                //        switch (count)
                //        {
                //            case 1:
                //            {
                //                foreach (var r in dt.AsEnumerable())
                //                {
                //                    if (r == null) continue;
                //                    if (r["servico"].ToBool()) continue;
                //                    preco = r["preco"].ToDecimal();
                //                    factor = dtPrcparam.Rows[0]["factor"].ToDecimal();
                //                    precovenda = preco * factor;
                //                    UpdateDatabase(precovenda,preco,r["ref"].ToString(),factor);
                //                }

                    //                break;
                    //            }
                    //            case 2:
                    //            {
                    //                foreach (var r in dt.AsEnumerable())
                    //                {
                    //                    if (r == null) continue;
                    //                    preco = r["preco"].ToDecimal();
                    //                    var val1 = dtPrcparam.Rows[0]["valor"].ToDecimal();
                    //                    var val2 = dtPrcparam.Rows[1]["valor"].ToDecimal();
                    //                    if (preco<val1) continue;
                    //                    if (val1>=preco && preco<val2 )
                    //                    {
                    //                        factor=dtPrcparam.Rows[0]["factor"].ToDecimal();
                    //                        precovenda = preco * factor;
                    //                    }
                    //                    else
                    //                    {

                    //                        factor=dtPrcparam.Rows[1]["factor"].ToDecimal();
                    //                        precovenda = preco * factor;
                    //                    }
                    //                    UpdateDatabase(precovenda,preco,r["ref"].ToString(),factor);
                    //                }

                    //                break;
                    //            }
                    //            case 3:
                    //            {
                    //                foreach (var r in dt.AsEnumerable())
                    //                {
                    //                    if (r == null) continue;
                    //                    preco = r["preco"].ToDecimal();
                    //                    var val1 = dtPrcparam.Rows[0]["valor"].ToDecimal();
                    //                    var val2 = dtPrcparam.Rows[1]["valor"].ToDecimal();
                    //                    var val3 = dtPrcparam.Rows[2]["valor"].ToDecimal();
                    //                    if (preco<val1) continue;
                    //                    if (val1>=preco && preco<val2 )
                    //                    {
                    //                        factor=dtPrcparam.Rows[0]["factor"].ToDecimal();
                    //                        precovenda = preco * factor;
                    //                    }
                    //                    else if(val2>=preco && preco<val3)
                    //                    {
                    //                        factor= dtPrcparam.Rows[1]["factor"].ToDecimal();
                    //                        precovenda = preco * factor;
                    //                    }
                    //                    else
                    //                    {
                    //                        factor=dtPrcparam.Rows[2]["factor"].ToDecimal();
                    //                        precovenda = preco * factor;
                    //                    }
                    //                    UpdateDatabase(precovenda,preco,r["ref"].ToString(),factor);
                    //                }

                    //                break;
                    //            }
                    //            case 4:
                    //            {
                    //                foreach (var r in dt.AsEnumerable())
                    //                {
                    //                    if (r == null) continue;
                    //                    preco = r["preco"].ToDecimal();
                    //                    var val1 = dtPrcparam.Rows[0]["valor"].ToDecimal();
                    //                    var val2 = dtPrcparam.Rows[1]["valor"].ToDecimal();
                    //                    var val3 = dtPrcparam.Rows[2]["valor"].ToDecimal();
                    //                    var val4 = dtPrcparam.Rows[3]["valor"].ToDecimal();
                    //                    if (preco<val1) continue;
                    //                    if (val1<=preco && preco<val2 )
                    //                    {
                    //                        factor=dtPrcparam.Rows[0]["factor"].ToDecimal();
                    //                        precovenda = preco * factor;
                    //                    }
                    //                    else if(val2<=preco && preco<val3)
                    //                    {
                    //                        factor=dtPrcparam.Rows[1]["factor"].ToDecimal();
                    //                        precovenda = preco * factor;
                    //                    }
                    //                    else if(val3<=preco && preco<val4)
                    //                    {
                    //                        factor= dtPrcparam.Rows[2]["factor"].ToDecimal();
                    //                        precovenda = preco * factor;
                    //                    }
                    //                    else
                    //                    {
                    //                        factor=dtPrcparam.Rows[3]["factor"].ToDecimal(); 
                    //                        precovenda = preco * factor;
                    //                    }
                    //                    UpdateDatabase(precovenda,preco,r["ref"].ToString(),factor);
                    //                }

                    //                break;
                    //            }
                    //        }
                    //}
                    //else if(SQL.GetFieldValue("param", "Actualizapreco").ToBool())
                    //{
                    //    if (dt != null)
                    //    {
                    //        foreach (var r in dt.AsEnumerable())
                    //        {
                    //            if (r == null) continue;
                    //            var preco = r["preco"].ToDecimal();
                    //            var perc = SQL.GetFieldValue("param", "Perlucro").ToDecimal();
                    //            var precovenda = preco +preco* perc/100;
                    //            UpdateDbase(precovenda,preco,r["ref"].ToString(),perc);
                    //        }
                    //    }  
                    //}
                    //

                var dt = gridUIFt1.DataSource as DataTable;
                if (SQL.GetFieldValue("param", "Actualizapreco").ToBool())
                {
                    var perc = SQL.GetFieldValue("param", "Perlucro").ToDecimal();
                    if (perc==0)
                    {
                        if (dt != null)
                        {
                            foreach (var r in dt.AsEnumerable())
                            {
                                if (r == null) continue;
                                var preco = r["preco"].ToDecimal();
                                var precovenda = preco + preco * perc / 100;
                                UpdateDbase(precovenda, preco, r["ref"].ToString(), perc);
                            }
                        }
                    }
                    else
                    {
                        MsBox.Show(Messagem.ParteInicial() +
                                   "Deve indicar percentagem do lucro nos parametros de gestão,\r\nApercentagem nao pode ser zerro!");
                    }
                }
            }
            if (!string.IsNullOrEmpty(_facc.Pjstamp))
            {
                Helper.Updatepj(TmpTdocf.Lancacustopj,_facc.Pjstamp,"TotComp","facc","TotCompIva",true);
                SendRefresh?.Invoke(false);
            }
            DtArtigos = null;
            base.AfterSave();
        }

        private void UpdateDbase(decimal precovenda, decimal preco, string referenc, decimal perc)
        {
            SQL.SqlCmd($@"update StPrecos set PrecoCompra =Convert(decimal,{preco}), preco =Convert(decimal,{precovenda}), Perc=Convert(decimal,{perc}) where 
                                        Ststamp =(select Ststamp from st where Referenc='{referenc}') and ltrim(rtrim(CCusto))='{_facc.Ccusto.Trim()}'");
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
            if (!Us.AprovaPagamento) return;
            tbAprodador.Text2 = Us.Numero.ToString();
            tbAprodador.tb1.Text = Us.Nome;
        }
        public override void Addline(string referenc)
        {
            if (!Procurou)
            {
                var tmpFound = SQL.GetRowToEnt<St>($"Ststamp='{referenc.Trim()}'"); // EF.GetEnt<St>(p=>p.Ststamp.Trim().Equals($"{referenc.Trim()}"));
                //GenBl.SetLineValues(DataRow, tmpFound,_facc,true,null,TmpTdocf.Nc);
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
            //Helper.VendaDiheiro(gridUIFt1.DsDt, this,TmpTdocf.Tipodoc);
            UpdGridFormasp();
        }
        public override void UpdGridFormasp()
        {
            Helper.Codmovtz(TmpTdocf.Movtz,TmpTdocf.Codmovtz,TmpTdocf.Descmovtz,gridFormasP1.Grelha,"facc");
        }
        private void btnTdi_Click(object sender, EventArgs e)
        {
            MenuLateral.ShowMenuStrip(btnTdi);
        }
        public void CallBrowdoc()
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
        private DataTable DtArtigos { get; set; }
        public void Produtos(DataTable dt)
        {
            DtArtigos = dt;
            var camposfnc = new[]
            {
                "no","Nome","ok","facturado","familia"
            };
            var fnc = dt.DefaultView.ToTable(true, camposfnc).
                AsEnumerable().CopyToDataTable();
            var bw = new FrmAddFnc
            {
                SendData = ReceiveDt
            };
            bw.BindiGrid(fnc);
            bw.ShowForm(this, true);
        }

        private void ReceiveDt2(DataTable dt)
        {
            foreach (var r in dt.AsEnumerable())
            {
                if (r == null) continue;
                dmzGridButtons1.btnNovo.PerformClick();
                DataRow["ref"] = r["ref"];
                DataRow["Descricao"] = r["Descricao"];
                DataRow["quant"] = r["quant"];
                DataRow["preco"] = r["preco"];
                DataRow["oristampl"] = r[$"Procurmlstamp"];
                DataRow["Txiva"] = r["Txiva"];
                DataRow["Tabiva"] = r["Tabiva"];
                DataRow["Perdesc"] = r["Perdesc"];
                DataRow["Descontol"] = r["Descontol"];
                DataRow["Ivainc"] = r["Ivainc"];//
                var qry = $"select Ststamp,Referenc,Descricao from st where Referenc='{r["ref"]}'";
                var dt1 = SQL.GetGenDT(qry);
                var valor = r["ref"].ToString().Trim();
                var dr = dt1.AsEnumerable().
                    FirstOrDefault(s => s.Field<string>("Referenc").Trim()
                        .Equals(valor));
                if (dr != null)
                    Addline(dr["Ststamp"].ToString().Trim());

                GenBl.TotaisLinhas(DataRow);
            }
            if (TmpTdocf.Movtz)
            {
                //Helper.VendaDiheiro(gridUIFt1.DsDt, this, 2);
                UpdGridFormasp();
            }
            gridUIFt1.Update();
            Helper.TotaisFt(gridUIFt1.DsDt, this);
        }

        private void ReceiveDt(DataTable dt)
        {
            foreach (var r in dt.AsEnumerable())
            {
                if (r == null) continue;
                Cliente.tb1.Text = r["nome"].ToString();
                Cliente.Text2 = r["no"].ToString();
                //dmzGridButtons1.btnNovo.PerformClick();
                //DataRow["ref"] = r["ref"];
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


        private void gridUIFt1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUIFt1.CurrentRow == null) return;
            if (!gridUIFt1.CurrentCell.OwningColumn.Name.ToLower().Trim().Equals("ivainc")) return;
            gridUIFt1.CurrentCell.Value = !gridUIFt1.CurrentCell.Value.ToBool();
            gridUIFt1.Update();
            //Helper.Totaislinha(true, gridUIFt1.DsDt, this, TmpTdocf.Tipodoc);
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
            //Helper.Totaislinha(true, gridUIFt1.DsDt, this, TmpTdocf.Tipodoc);
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
           // Helper.Totaislinha(true, gridUIFt1.DsDt, this, TmpTdocf.Tipodoc);
        }
        private void gridUIFt1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //if (gridUIFt1.CurrentCell.OwningColumn.Name.Trim().ToLower().Equals("tabiva")) return;
            //var validClick = e.RowIndex != -1 && e.ColumnIndex != -1; //Make sure the clicked row/column is valid.
            //var datagridview = sender as DataGridView;

            //// Check to make sure the cell clicked is the cell containing the combobox 
            //if (!(datagridview?.Columns[e.ColumnIndex] is DataGridViewTextBoxColumn) || !validClick) return;
            
            //// ((TextBox)datagridview.EditingControl). = true;
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
                    SetFaccl("Referenc");
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
            gridUIFt1.CurrentCell.Value = gridUIFt1.CurrentCell.Value.ToString().ToUpper();
            if (gridUIFt1.CurrentCell.Value != null)
            {
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
                    // Helper.Totaislinha(true, gridUIFt1.DsDt, this,TmpTdocf.Tipodoc);
                }
            }

            gridUIFt1.Update();
        }
        private void SetArmazem(string referenc)
        {
            if (gridUIFt1.CurrentCell?.Value == null) return;
            gridUIFt1.CurrentCell.Value = gridUIFt1.CurrentCell.Value.ToString().ToUpper();
            var valor = gridUIFt1.CurrentCell.Value.ToString().Trim();
            var dr = DtArm.AsEnumerable().FirstOrDefault(s => s.Field<string>(referenc).Trim().Equals(valor));
            if (dr == null) return;
            switch (referenc)
            {
                case "descricao":
                    if (gridUIFt1.CurrentRow != null)
                        gridUIFt1.CurrentRow.Cells["Armazem"].Value = dr[0].ToString();
                    break;
                default:
                    if (gridUIFt1.CurrentRow != null)
                        gridUIFt1.CurrentRow.Cells["descarm"].Value = dr[1].ToString();
                    break;
            }
               
            gridUIFt1.Update();
        }
        private void SetFaccl(string campo)
        {
            try
            {
                if (gridUIFt1.CurrentCell?.Value == null) return;
                gridUIFt1.CurrentCell.Value = gridUIFt1.CurrentCell.Value.ToString().ToUpper();
                var valor = gridUIFt1.CurrentCell.Value.ToString().ToUpper().Trim();
                var dr = DtSt.AsEnumerable().FirstOrDefault(s => s.Field<string>(campo).Trim().Equals(valor));

                if (dr != null)
                    Addline(dr["Ststamp"].ToString().Trim());
            }
            catch
            {
                //
            }
        }
        private void gridUIFt1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (gridUIFt1.CurrentRow == null) return;
            DataRow = ((DataRowView)gridUIFt1.CurrentRow.DataBoundItem).Row;
            var cond = string.Empty;
            string qry;
            if (DtArtigos != null)
            {
                //DtSt = DtArtigos;
                string gr = string.Empty;

                qry = $"select* from (select quant =" +
                      $" isnull((select top 1  pl.Quant " +
                      $" from faccl fl join facc fc on fl.Faccstamp = " +
                      $" fc.Faccstamp where fl.Ref = pl.Ref " +
                      $" and Pjstamp = '{Pjstamp}' " +
                      $"and pl.no='{Cliente.Text2}'" +
                      $"), pl.Quant),Descricao,pl.Ref," +
                      $"pl.Nome, pl.Preco,pl.Procurmlstamp,pl.Txiva," +
                      $"pl.Tabiva,pl.Perdesc,pl.Descontol,pl.Ivainc,pl.Factura,pl.No" +
                      $" from Procurml pl where Procurmstamp = '{Pjstamp}' " +
                      $"and pl.no='{Cliente.Text2}') " +
                      $"temp ";
                var dtst = SQL.GetGenDT(qry);

                for (int i = 0; i < dtst.Rows.Count; i++)
                {
                    if (i == 0)
                    {
                        gr += $"'{dtst.Rows[i]["ref"]}'";
                    }
                    else
                    {
                        gr += $",'{dtst.Rows[i]["ref"]}'";
                    }
                }
                var subs = gr.Split(',');

                for (var i = 0; i < subs.Length; i++)
                {
                    if (i == 0)
                    {
                        cond += $"{subs[i]}";
                    }
                    else
                    {
                        cond += $",{subs[i]}";
                    }
                }
                cond = $" where Referenc in ({cond})";
            }
            
            qry = $"select Ststamp,Referenc,Descricao from st {cond}";

            var name = gridUIFt1.CurrentCell.OwningColumn.Name.ToLower();
            if (name.Equals("descricao"))
            {
                DtSt = Helper.SetBinds(e.Control, "Descricao", qry); 

            }
            else if (name.Equals("ref1"))
            {
                DtSt = Helper.SetBinds(e.Control, "Referenc", qry);
               
            }
            else if (name.Equals("armazem"))
            {
                qry = "select Codigo,Descricao from Armazem";
                DtArm = Helper.SetBinds(e.Control, "codigo", qry); 

                
            }
            else if (name.Equals("descarm"))
            {
                qry = "select Codigo,Descricao from Armazem";
                DtArm = Helper.SetBinds(e.Control, "Descricao", qry);
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
            Cliente.tb1.Text = di.Nome;
            Cliente.Text2 = di.No;
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
                var tmpFound = SQL.GetRowToEnt<St>($"Referenc='{row["ref"].ToString().Trim()}'"); //EF.GetEnt<St>(x=>x.Referenc.Trim().Equals(row["ref"].ToString().Trim()));
                //GenBl.SetLineValues(DataRow, tmpFound,_facc,true,row);
                DataRow["Armazem"] = row["Codarm"];
                DataRow["Descarm"] = row["armazem"];
            }

            // di.Oristamp = dt.TableName.Equals("dil") ? dt.Rows[0]["distamp"].ToString() : dt.Rows[0]["Factstamp"].ToString();
           // Helper.Totaislinha(true, gridUIFt1.DsDt, this, TmpTdocf.Tipodoc);
        }
        private void FillGrid(DataTable dt)
        {
            if (!(dt?.Rows.Count > 0)) return;
            for (var i = 0; i < dt.Rows.Count; i++)
            {
                DataRow=Helper.NewGridRow(this);
                var tmpFound = SQL.GetRowToEnt<St>($"Referenc='{dt.Rows[i]["ref"].ToString().Trim()}'");//EF.GetEnt<St>(x=>x.Referenc.Trim().Equals(dt.Rows[i]["ref"].ToString().Trim()));
                //GenBl.SetLineValues(DataRow, tmpFound,_facc,true,dt.Rows[i],TmpTdocf.Nc,);
            }
            _facc.Oristamp = dt.Rows[0]["distamp"].ToString();
            //Helper.Totaislinha(true, gridUIFt1.DsDt, this, TmpTdocf.Tipodoc);
        }

        public string Distamp { get; set; }
        public string Tdocfcondicao { get; set; }
        public string Origem { get; set; }
        public List<Usracessos> ListaUsracessos { get; set; }
        public Action<bool> SendRefresh { get; set; }

        private void gridUIFt1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!EditMode) return;
            if (gridUIFt1.CurrentRow == null) return;
            var name = gridUIFt1.CurrentCell.OwningColumn.Name.ToLower().Trim();
            if (name.Equals("percdesc") || name.Equals("quant") || name.Equals("preco") || name.Equals("ivainc"))
            {
                NVerificar = true;
            }
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CLocalStamp)) return;
            //var f = new FrmReport
            //{
            //    label1 = {Text = $@"Imprimir {label1.Text}"},
            //    Printstamp = CLocalStamp,
            //    Origem = "CP",
            //    ReportName = TmpTdocf.Nomfile
            //};
            //f.ShowForm(this);

        }
        private void Cliente_RefreshControls()
        {
            if (gridUIFt1.Rows.Count <= 0) return;
            foreach (DataGridViewRow r in gridUIFt1.Rows)
            {
                r.Cells["Fornec"].Value = Cliente.Text2;
            }
            gridUIFt1.Update();
        }
        private void Ccusto_RefreshControls()
        {
            _facc.Ccusto = tbCcusto.tb1.Text;
        }
        private void gridUIFt1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode != Keys.Enter) return;
            //NewGridLine();
            //gridUIFt1.CurrentCell = gridUIFt1.Rows[gridUIFt1.Rows.Count - 1].Cells["Descricao"];
        }

        public void UpdateObjects(DataTable dt)
        {
            if (_facc==null)
            {
                _facc = new Facc(); 
            }
            var numdoc = dt.Rows[0]["Numdoc"].ToDecimal();
            TmpTdocf = SQL.GetRowToEnt<Tdocf>($"numdoc={numdoc}");
            label1.Text = TmpTdocf.Descricao;
            panel1.Visible = false;
            panel3.Visible = false;
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (!TmpTdocf.Ft) return;
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
            TmpTdocf = tdoc.DrToEntity<Tdocf>();
            SetValues1(TmpTdocf);

        }
        private void SetValues1(Tdocf tmpTdocf)
        {
            label1.Text = tmpTdocf.Descricao;
            // Helper.ClearControls(this);
            gridFormasP1.Refresh(this.TmpTdocf.Numdoc);
            gridFormasP1.Movtz = tmpTdocf.Movtz;
            panelAprovaPagamento.Visible = tmpTdocf.Usaprovacao;
        }

        private bool dmzGridButtons1_BeforeAddLineEvent()
        {
            if (!OrigReserva) return false;
            if (!string.IsNullOrEmpty(Cliente.Text2))
            {
                var f = new FrmGuiaList
                {
                    No = Cliente.Text2.ToDecimal(),
                    //SendData = ReceiveDataFromCopyLinhas,
                    Sumcampos = "Encomenda-Encomendaentrada",
                    Nome = Cliente.tb1.Text.Trim()
                };
                f.ShowForm(this);
            }
            else
            {
                MsBox.Show("Deve indicar o cliente!");
            }
            return true;
        }

        private void btnDocsfact_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (!EditMode)return;
            if (!string.IsNullOrEmpty(Cliente.tb1.Text))
            {
                if (DtArtigos != null)
                {
                    DtSt = DtArtigos;
                    var qry = $"select* from (select quant =" +
                              $" isnull((select top 1  pl.Quant " +
                              $" from faccl fl join facc fc on fl.Faccstamp = " +
                              $" fc.Faccstamp where fl.Ref = pl.Ref " +
                              $" and Pjstamp = '{Pjstamp}' " +
                              $"and pl.no='{Cliente.Text2}'" +
                              $"), pl.Quant),Descricao,pl.Ref," +
                              $"pl.Nome, pl.Preco,pl.Procurmlstamp,pl.Txiva," +
                              $"pl.Tabiva,pl.Perdesc,pl.Descontol,pl.Ivainc,pl.Factura,pl.No" +
                              $" from Procurml pl where Procurmstamp = '{Pjstamp}' " +
                              $"and pl.no='{Cliente.Text2}') " +
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
                        var _qrt = $"select top 1 isnull(iif(Familia='','Não definida',Familia),'Não definida') Familia from st where Referenc='{r["Ref"].ToString().Trim()}'";
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
    }
}
