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
using DMZ.UI.Properties;
using DMZ.UI.Reports;
using DMZ.UI.UC;


namespace DMZ.UI.UI
{
    public partial class FrmPosRest : Form, IMessageFilter
    {
        public DataTable DtProdutos;

        public DataTable DtSecFam;
        private Caixa _caixa;
        private Fact ft;
        public bool Familias { get; set; }
        public DataRow DataRow { get; set; }
        public DataTable Factl { get; set; }
        public DataTable FactlMemory { get; set; }
        public bool LRunStk { get; set; }
        public Tdoc TmpTdoc { get; set; }
        public bool NVerificar { get; set; }
        public string CLocalStamp { get; set; } = "";
        public string Ctabela { get; set; }
        public string Campo2 { get; set; }

        public string Campo1 { get; set; }
        public bool Editemode { get; set; }
        public decimal NumCaixa { get; set; }
        public DateTime DatCaixa { get; set; }

        public Category cat;

        public Sectores sect;
        private Timer mTimer;
        private int mDialogCount;
        private EventArgs eeve;

        public FrmPosRest()
        {
            InitializeComponent();
            mTimer = new Timer();
            mTimer.Interval = Pbl.Param.Intervalo.ToInt();
            mTimer.Tick += LogoutUser;
            mTimer.Enabled = true;
            Application.AddMessageFilter(this);
        }
        public bool PreFilterMessage(ref Message m)
        {
            // Monitor message for keyboard and mouse messages
            var active = m.Msg == 0x100 || m.Msg == 0x101;  // WM_KEYDOWN/UP
            active = active || m.Msg == 0xA0 || m.Msg == 0x200;  // WM_(NC)MOUSEMOVE
            active = active || m.Msg == 0x10;  // WM_CLOSE, in case dialog closes
            if (active)
            {
                //if (!mTimer.Enabled) label1.Text = "Wakeup";
                mTimer.Enabled = false;
                mTimer.Start();
            }
            return false;
        }

        private void LogoutUser(object sender, EventArgs e)
        {
            //// No activity, logout user
            //if (mDialogCount > 0) return;
            //mTimer.Enabled = false;
            //var form = Application.OpenForms["FrmLogOff"];
            //if (form != null) return;
            //var f = new FrmLogOff();
            //f.Enviar = RecebeActualiza;
            //f.ShowForm(this, true);
        }
        private void FrmPosRest_Load(object sender, EventArgs e)
        {
            TmpTdoc =SQL.GetRowToEnt<Tdoc>(" sigla ='FT'");
            SetValues(TmpTdoc);
            Ctabela = "fact";
            Campo1 = "Numero";
            Campo2 = "nome";
            btnTodasMesas.Visible = !Pbl.Param.EcranPosPequeno;
            btnTodosProdutos.Visible = !Pbl.Param.EcranPosPequeno;

            btnTodProduto.Visible = Pbl.Param.EcranPosPequeno;
            btnTmesas.Visible = Pbl.Param.EcranPosPequeno;

            BindGrid();
            KeyUp += KeyEvent;
            KeyPreview = true;
            FunMetodos();
            var dt = SQL.GetDT("Usracessos", $"usrstamp='{Pbl.Usr.Usrstamp.Trim()}'");
            if (dt.HasRows())
            {
                Pbl.Usracessos = dt.DtToList<Usracessos>();
            }
            WindowState = FormWindowState.Maximized;
        }

        private void FunMetodos()
        {
            BindCC();
            lblUser.label1.Text = Pbl.Usr.Nome;
            lblEmpresa.label1.Text = Pbl.Empresa.Nome;
            GetCaixa();
        }

        private void GetCaixa()
        {
            switch (Pbl.Usr.Tipousr)
            {
                case 1:
                    Panel_info_caixa.Visible = true;
                    _caixa = GenBl.GetCaixa(Pbl.SqlDate, Pbl.Usr.Usrstamp);
                    if (_caixa == null) return;
                    lblcaixa.label1.Text = _caixa.Contatesoura;
                    Panel_info_caixa.Visible = false;
                    break;
                case 2:
                    Panel_info_caixa.Visible = false;
                    lblcaixa.label1.Text = "";
                    btnPagamento.Visible = false;
                    break;
            }
        }

        internal void SetMesa(DataRow dr)
        {
            if (ft != null)
            {
                Mesa(dr);
            }
            else
            {
                btnIntroduzir.PerformClick();
                if (_caixa != null)
                {
                    Mesa(dr);
                }
            }
        }

        private void Mesa(DataRow dr)
        {
            if (dr == null) return;
            tbNome.Text = dr["nome"].ToString();
            if (ft != null)
            {
                ft.No = dr["no"].ToString();
                ft.Nome = dr["nome"].ToString();
                ft.Nuit = dr["nuit"].ToDecimal();
                ft.Morada = dr["morada"].ToString();
                ft.Mesa = dr["no"].ToString();
                ft.Clstamp = dr["Clstamp"].ToString();
                ft.Ccustamp = Pbl.Usr.Ccustamp;
                ft.Ccusto = Pbl.Usr.Ccusto;
                ft.Usrstamp = Pbl.Usr.Usrstamp;
            }
            if (!AddNewRecord || !Updating)
            {
                btnFamilias.PerformClick();
            }
        }

        private void KeyEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btnIntroduzir.PerformClick();
            }
            if (e.KeyCode == Keys.F2)
            {
                btnPagamento.PerformClick();
            }
        }
        void BindGrid()
        {
            Factl = SQL.GetGen2DT($" select * from factl where factstamp='{CLocalStamp.Trim()}'");
            gridUI1.TabelaSql="factl";
            gridUI1.Condicao=$"factstamp='{CLocalStamp.Trim()}'";
            gridUI1.GridFilha=false;
            gridUI1.BindGridView();
            //gridUI1.SetDataSource(Factl);
        }

        private void MultiplyBtnCategory()
        {
            DtSecFam = SQL.GetGenDT("select  descricao, Codigo, Familiastamp from Familia where pos=1");
            if (!DtSecFam.HasRows()) return;
            FillFamilias(DtSecFam);
        }

        private void FillFamilias(DataTable dt)
        {
            if (Origem == 1)
            {
                var campos = new[]
                {
                    "descricao", "Codigo", "Familiastamp"
                };
                if (dt.HasRows())
                {
                    dt = dt.DefaultView.ToTable(true, campos);
                }
            }

            foreach (var item in dt.AsEnumerable())
            {
                cat = new Category
                {
                    Codigo = item["Codigo"].ToString(),
                    CodFam = item["Familiastamp"].ToString(),
                };
                cat.Titulo = item["Descricao"].ToString().ToUpper();
                cat.Width = fLPButtons.Width - 5;
                fLPButtons.Controls.Add(cat);
            }
        }

        private void MultiplyBtnSector()
        {
            DtSecFam = SQL.GetGenDT(@"select Sector.Sectorstamp,Sector.Codigo,Sector.Descricao as DescricaoSector,Mesasstamp as Clstamp,Sectmesas.Descricao as Nome,
						Imagem=(select Imagem from cl where clstamp=SectMesas.Mesasstamp),
						no=(select no from cl where Clstamp=SectMesas.Mesasstamp),
						Nuit=(select Nuit from cl where Clstamp=SectMesas.Mesasstamp),
						Morada=(select Morada from cl where Clstamp=SectMesas.Mesasstamp)
                            from Sector join Sectmesas on Sector.Sectorstamp = Sectmesas.Sectorstamp");
            if (!DtSecFam.HasRows()) return;
            FillSectores(DtSecFam);
        }

        private void FillSectores(DataTable dt)
        {
            if (Origem == 1)
            {
                var campos = new[]
                {
                    "DescricaoSector", "Codigo", "Sectorstamp"
                };
                if (dt.HasRows())
                {
                    dt = dt.DefaultView.ToTable(true, campos);
                }
            }
            foreach (var item in dt.AsEnumerable())
            {
                sect = new Sectores
                {
                    Codigo = item["Codigo"].ToString(),
                    Sectorstamp = item["Sectorstamp"].ToString()
                };
                sect.Titulo = item["DescricaoSector"].ToString().ToUpper();
                sect.Width = fLPButtons.Width - 5;
                fLPButtons.Controls.Add(sect);
            }
        }

        private void fLPButtons_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void AddLine(string referenc, bool operacao, DataRow stQuant = null, bool origem = false)
        {
            if (ft!=null)
            {
                if (AddNewRecord || Updating)
                {
                    if (Pbl.Usr.Usrstamp.Equals(ft.Usrstamp) || !Pbl.Usr.Naoaltera)
                    {
                        if (ft == null)
                        {
                            btnIntroduzir.PerformClick();
                        }
                        var nMaxOrdem = Factl.Rows.Count;
                        nMaxOrdem = nMaxOrdem + 1;
                        var condicao = origem ? $"ltrim(rtrim(codigobarras)) ='{referenc.Trim()}'" : $"ltrim(rtrim(ststamp)) ='{referenc.Trim()}'";
                        var tmpFound = SQL.GetRowToEnt<St>(condicao);
                        if (tmpFound == null) return;
                        string cond = "";
                        if (tmpFound.Usaquant2)
                        {
                            cond = $"Titstamp ='{stQuant["StQuantstamp"].ToString().Trim()}'";
                        }
                        else
                        {
                            cond = $"Ststamp ='{tmpFound.Ststamp.Trim()}'";
                        }
                        var rows = Factl.Select(cond);
                        if (rows.Length > 0)
                        {
                            foreach (var r in rows)
                            {
                                if (operacao)
                                {
                                    r["quant"] = r["quant"].ToDecimal() + 1;
                                    if (r["Usaquant2"].ToBool())
                                    {
                                        r["Quant2"] = r["Quant2"].ToDecimal() + r["QttOrig"].ToDecimal();
                                    }
                                }
                                else
                                {
                                    if (r["quant"].ToDecimal() > 0)
                                    {
                                        r["quant"] = r["quant"].ToDecimal() - 1;
                                        if (r["Usaquant2"].ToBool())
                                        {
                                            r["Quant2"] = r["Quant2"].ToDecimal() - r["QttOrig"].ToDecimal();
                                        }
                                    }

                                }
                                Totaislinha(true);
                            }
                        }
                        else
                        {
                            if (ft == null) return;
                            DataRow = Factl.NewRow();
                            DataRow["factstamp"] = ft.Factstamp;
                            DataRow["factlstamp"] = Pbl.Stamp();
                            GenBl.SetLineValues(DataRow, tmpFound, ft, false, null, false, Pbl.MoedaBase, "", "");
                            if (stQuant != null)
                            {
                                DataRow["Quant2"] = stQuant["quant"];
                                DataRow["preco"] = stQuant["preco"];
                                DataRow["Titstamp"] = stQuant["StQuantstamp"];
                                DataRow["QttOrig"] = stQuant["quant"];
                                DataRow["Descricao"] = stQuant["descpos"];
                                DataRow["Ivainc"] = stQuant["Ivainc"];

                            }
                            DataRow["ordem"] = nMaxOrdem;
                            GenBl.TotaisLinhas(DataRow);
                            Factl.Rows.Add(DataRow);
                            if (tmpFound.Composto)
                            {
                                var tmpCp = SQL.GetGenDT(" stcp (nolock) inner join st on st.ststamp=stcp.ststamp ",
                                    $"where LTRIM(RTRIM(stcp.ststamp))= '{tmpFound.Ststamp.Trim()}'", "*");
                                if (tmpCp.Rows.Count == 0) return;
                                {
                                    foreach (var row in tmpCp.AsEnumerable())
                                    {
                                        var nMax = Factl.Rows.Count;
                                        nMax += 1;
                                        var dr2 = Factl.NewRow().Inicialize();
                                        dr2["ordem"] = nMax;
                                        dr2["Factstamp"] = ft.Factstamp;
                                        dr2["Titstamp"] = dr2["Factlstamp"];
                                        dr2["ref"] = row["refcp"].ToString().Trim();
                                        dr2["descricao"] = row["descricao"].ToString().Trim();
                                        dr2["quant"] = row["quantcp"].ToString().ToDecimal();
                                        dr2["Preco"] = 0;
                                        dr2["servico"] = row["servico"].ToBool();
                                        dr2["Numdoc"] = TmpTdoc.Numdoc;
                                        dr2["Sigla"] = TmpTdoc.Sigla;
                                        dr2["Oristamp"] = tmpFound.Ststamp;
                                        dr2["Ivainc"] = row["Ivainc"].ToBool(); ;
                                        dr2["Txiva"] = tmpFound.Txiva;
                                        dr2["Tabiva"] = tmpFound.Tabiva;
                                        dr2["codccu"] = Pbl.Usr.Codccu;
                                        dr2["ccusto"] = Pbl.Usr.Ccusto;
                                        dr2["ststamp"] = row["Oristamp"].ToString().Trim();
                                        dr2["Mvalival"] = 0;
                                        dr2["Mdescontol"] = 0;
                                        dr2["Msubtotall"] = 0;
                                        dr2["Mtotall"] = 0;
                                        dr2["obs"] = tmpFound.Descricao;
                                        dr2["cpoo"] = 1;
                                        if (!row["servico"].ToBool())
                                        {
                                            var armazem = SQL.GetRow($"select Codarm,Descricao,Armazemstamp from Ccu_Arm where (select cozinha from armazem where Armazemstamp=Ccu_Arm.Armazemstamp and Ccustamp='{Pbl.Usr.Ccustamp}')=1");
                                            if (armazem != null)
                                            {
                                                dr2["Armazem"] = armazem["Codarm"];
                                                dr2["descarm"] = armazem["Descricao"];
                                                dr2["Armazemstamp"] = armazem["Armazemstamp"];
                                            }
                                        }
                                        // TotaisLinhas(dr2);
                                        Factl.Rows.Add(dr2);
                                    }
                                    if (gridUI1.Rows.Count > 0)
                                    {
                                        foreach (DataGridViewRow item in gridUI1.Rows)
                                        {
                                            if (item != null)
                                            {
                                                if (item.Cells["cpoo"].Value.ToDecimal() == 1)
                                                {
                                                    item.Visible = false;
                                                }
                                            }
                                        }
                                    }
                                    tmpCp.Dispose();
                                }
                                //*----------------
                            }
                            gridUI1.Update();
                            HelperFact.TotaisFt(ft, Factl);
                            lblTotal.Text = ft.Total.ToString("N2");
                        }
                        if (!Updating) return;
                        btnIntroduzir.Image = Resources.Undo_251px;
                        // btnIntroduzir.Text = "Gravar";
                        btnIntroduzir.Text = "Cancelar";
                        // btnPagamento.Image = Resources.Undo_251px;
                        Podepagar = false;
                        AddNewRecord = false;
                    }
                    else
                    {
                        MsBox.Show("Não tem permissão para alterar factura emitida por outro utilizador");
                    }
                }
                else
                {
                    MsBox.Show("Deve estar em modo de edição para adicionar os produtos!");
                }
            }
            else
            {
                MsBox.Show("Deve iniciar a venda primeiro, clicando no botão venda");
            }
        }
        private void DefaultValues()
        {
            ft = Utilities.DoAddline<Fact>();
            CLocalStamp = ft.Factstamp;
            ft.Sigla = TmpTdoc.Sigla;
            ft.Data = Pbl.SqlDate;
            tbData.Text = ft.Data.ToShortDateString();
            ft.Datcaixa = Pbl.SqlDate;
            ft.Origem = "FT";
            ft.Pos =true;
            ft.Tdocstamp = TmpTdoc.Tdocstamp;
            HelperFact.SetDefaultValues(ft, TmpTdoc);
            var max = SQL.VMax("fact", TmpTdoc.Numdoc, ft.Data.Year);
            ft.Numero = max.ToString();
            tbNumero.Text = max.ToString();
            tbNUIT.Text = ""; ;
            ft.Codsec = Codsec;
            ft.Descsector = Descsector;
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


        public void Totaislinha(bool origem)
        {
            if (!origem) return;
            foreach (var dr in Enumerable.Where(Factl.AsEnumerable(), dr => dr != null))
            {
                GenBl.TotaisLinhas(dr);
                if (dr["Usaquant2"].ToBool())
                {
                    dr["Quant2"] = dr["Quant"].ToDecimal() * dr["QttOrig"].ToDecimal();
                }
            }
            HelperFact.TotaisFt(ft, Factl);
            lblTotal.Text = ft.Total.ToString("N2");
            gridUI1.Update();
            gridUI1.EndEdit();
            Refresh();
            NVerificar = false;
        }



        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridUI1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (!NVerificar) return;
            NVerificar = false;
            Totaislinha(true);
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

        private void Pagar()
        {
            if (Factl?.Rows.Count != 0)
            {

                var values = GenBl.CheckStock(ft, Factl, false);
                if (values.Item1)
                {
                    var f = new FrmPagar
                    {
                        tbTroco = { Text = lblTotal.Text },
                        tbCliente = { Text = ft.Nome },
                        TopLevel = true,
                        StartPosition = FormStartPosition.CenterScreen,
                        Origem = TmpTdoc.Sigla,
                        Factstamp = ft.Factstamp
                    };
                    f.ShowDialog();
                }
                else
                {
                    MsBox.Show(values.Item2);
                }
            }
            else
            {
                MsBox.Show("Desculpe mas tem que indicar artigo a facturar.");
            }
        }

        private void gridUI1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUI1.CurrentCell == null) return;
            var name = gridUI1.CurrentCell.OwningColumn.Name;

            if (name.ToLower().Equals("quant"))
            {
                if (!Pbl.Usr.Usrstamp.Equals(ft.Usrstamp) || !Pbl.Usr.Naoaltera)
                {
                    MsBox.Show("Esta documento não foi por te emitido não pode alterá-lo! Obrigado");
                    return;
                }
            }

            if (!name.ToLower().Equals("del")) return;
            if (gridUI1.CurrentRow == null) return;
            if (AddNewRecord)
            {
                gridUI1.Update();
                //var compostoStamp = gridUI1.CurrentRow.Cells["Ststamp"].Value.ToString().Trim();
                //var composto = gridUI1.CurrentRow.Cells["composto"].Value.ToBool();
                //if (composto)
                //{
                //    var dt = gridUI1.GetBindedTable();
                //    foreach (DataRow l in dt.AsEnumerable())
                //    {
                //        if (l["Oristamp"].ToString().ToLower().Equals(compostoStamp.ToLower().Trim()))
                //        {
                //            dt.Rows.Remove(l);
                //        }
                //    }
                //    gridUI1.SetDataSource(dt);
                //    gridUI1.Update();
                //}
                gridUI1.DellLine(gridUI1.CurrentRow.Cells["Descricao"].Value.ToString());
                // gridUI1.DellLine(gridUI1.CurrentRow.Cells["Descricao"].Value.ToString());
                Totaislinha(true);
            }
            else if (Updating)
            {
                if (Pbl.Usr.Supervisor)
                {
                    EliminarLinha();
                }
                else
                {
                    if (gridUI1.CurrentRow.ToDataRow().RowState == DataRowState.Added)
                    {
                        var linha = gridUI1.CurrentRow.DataBoundItem as DataRow;
                        gridUI1.DellLine(gridUI1.CurrentRow.Cells["Descricao"].Value.ToString());
                        //if (linha["composto"].ToBool())
                        //{
                        //    foreach (DataGridViewRow l in gridUI1.Rows)
                        //    {
                        //        if (l.Cells["Oristamp"].Value.ToString().ToLower().Equals(linha["Ststamp"].ToString().Trim()))
                        //        {
                        //            gridUI1.Rows.Remove(l);
                        //        }
                        //    }
                        //}
                        Totaislinha(true);
                    }
                    else
                    {
                        var b = new FrmCheckUsr();
                        b.SendData = ReceiveUsr2;
                        b.ShowForm(this, true);
                    }
                }

            }
        }

        private void ReceiveUsr2(string login, bool existe)
        {
            if (existe)
            {
                if (gridUI1.CurrentRow != null)
                {
                    EliminarLinha();
                }
            }
            else
            {
                MsBox.Show("Não foram encontrados informações com dados fornecidos", login);
            }
        }

        private void EliminarLinha()
        {
            gridUI1.DellLine(gridUI1.CurrentRow.Cells["Descricao"].Value.ToString());
            Totaislinha(true);
            EF.Save(ft);
            BindCC();
        }

        private void gridUI1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUI1.CurrentRow == null) return;
            var name = gridUI1.CurrentCell.OwningColumn.Name.ToLower().Trim();
            if (name.Equals("quant") || name.Equals("preco") || name.Equals("desconto"))
            {
                NVerificar = true;
            }
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            gridUI1.DellLine();
            DelLine = true;
            HelperFact.TotaisFt(ft, Factl);
            lblTotal.Text = ft.Total.ToString("N2");
            gridUI1.Update();
        }

        public bool DelLine { get; set; }

        private void btnMenuLateral_Click(object sender, EventArgs e)
        {
            MenuPrincipal.ShowMenuStrip(btnMenuLateral);
        }

        private void FrmPosRest_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void aberturaDoCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCaixaabertura.PerformClick();
        }
        private void Showform(Form f)
        {
            f.TopLevel = true;
            f.ShowDialog();
        }

        private void Showform2(Form f)
        {
            if (Pbl.Param.EcranPosPequeno)
            {
                f.ShowDialog();
            }
            else
            {
                f.TopLevel = false;
                f.Size = new Size(fLPSubProduct.Size.Width - 10, fLPSubProduct.Size.Height - 10);
                fLPSubProduct.Controls.Clear();
                fLPSubProduct.Controls.Add(f);
                f.FormClosing += F_FormClosing;
                f.Show();
            }
        }

        private void F_FormClosing(object sender, FormClosingEventArgs e)
        {
            fLPSubProduct.Controls.Add(lblInform);
        }

        private void fichaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnFichaCl.PerformClick();
        }

        private void fechoDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnFecharCaixa.PerformClick();
        }

        private void movimentosDeTesourariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_caixa == null) return;
            var f = new FrmPosDi();
            f.Caixa = lblcaixa.label1.Text;
            Showform(f);
        }

        private void folhaDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnFolhaCaixa.PerformClick();
        }

        private void inventárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FrmIv();
            Showform(f);
        }

        public decimal Codsec { get; set; }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
        public bool AddNewRecord { get; set; }
        public void BindCC()
        {
            DtCC = GenBl.PosCc();
            gridUi2.SetDataSource(DtCC);
        }

        public int Origem { get; set; } = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            TmpTdoc =SQL.GetRowToEnt<Tdoc>("vd=1");
            SetValues(TmpTdoc);
        }
        private void CallBrowdoc()
        {
            var bw = new Browdoc
            {
                Condicao = "",
                Descricao = @"descricao",
                Sigla = @"sigla",
                Tabela = @"tdoc",
                BindTdoc = BindTdoc
            };
            Showform(bw);
        }
        public void BindTdoc(DataRow tdoc, bool origem = false)
        {
            if (tdoc == null) return;

            TmpTdoc = tdoc.DrToEntity<Tdoc>();
            SetValues(TmpTdoc);
            CCondicao = $"numdoc={TmpTdoc.Numdoc} and year(data) = {Pbl.SqlDate.Year}";

        }
        private void SetValues(Tdoc tmpTdoc)
        {
            lblDocumento.Text = tmpTdoc.Descricao.ToUpper();
            //Helper.ClearControls(this);
        }
        public string CCondicao { get; set; }
        public string Descsector { get; set; }

        private void gridUi2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUi2.CurrentRow == null) return;
            var col = gridUi2.CurrentCell.OwningColumn.Name;
            if (!AddNewRecord)
            {
                if (col.Equals("btnEditar"))
                {
                    var Usrstamp = gridUi2.CurrentRow.Cells["Usrstamp"].Value.ToString().Trim();
                    if (Pbl.Usr.Usrstamp.Equals(Usrstamp) || !Pbl.Usr.Naoaltera)
                    {
                        Filldata();
                        FactlMemory = SQL.GetGen2DT($" select * from factl where factstamp='{CLocalStamp.Trim()}'");
                        //SetImagens();
                        btnSalvar.Visible=true;
                        Updating = true;
                    }
                    else
                    {
                        MsBox.Show("Não tem permissão para alterar factura emitida por outro utilizador");
                    }
                }
                else
                {
                    Filldata();
                    Updating = false;
                }
            }
            else
            {
                MsBox.Show("Deve terminar o processo de venda em curso primeiro!");
            }
        }

        private void Filldata()
        {
            var factstamp = gridUi2.CurrentRow.Cells["factstamp"].Value.ToString().Trim();
            ft = SQL.GetRowToEnt<Fact>($"factstamp='{factstamp}'");
            if (ft!=null)
            {
                tbData.Text = ft.Data.ToShortDateString();
                tbNome.Text = ft.Nome;
                tbMorada.Text = ft.Campo1;
                lblTotal.Text = ft.Total.ToString("N2");
                tbNumero.Text = ft.Numero.ToString();
                CLocalStamp = ft.Factstamp;
                BindGrid();
                AddNewRecord = false;
                if (Pbl.Usr.Tipousr == 1)
                {
                    btnPagamento.Visible = true;
                    Podepagar = true;
                }
                else
                {
                    btnPagamento.Visible = false;
                    Podepagar = false;

                }
                //if (ft.Tdocstamp==TmpTdoc.Tdocstamp)
                //{

                //}
                //else
                //{
                //    MsBox.Show("O Software notou que houve troca do tipo de documento de base. Verifique!");
                //}
            }
            else
            {
                MsBox.Show("O Software não encontrou o documento em causa!");
            }
        }

        public bool Updating { get; set; }

        public bool Podepagar { get; set; }

        private void btnNovo_Click(object sender, EventArgs e)
        {

        }

        private void btnFamilias_Click(object sender, EventArgs e)
        {
            fLPButtons.Controls.Clear();
            fLPSubProduct.Controls.Clear();
            MultiplyBtnCategory();
        }

        private void btnSector_Click_1(object sender, EventArgs e)
        {
            Limpar();
            MultiplyBtnSector();
        }

        private void Limpar()
        {
            fLPButtons.Controls.Clear();
            fLPSubProduct.Controls.Clear();
        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            //dmzPagar.ShowMenuStrip(btnPagamento);
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
                }
                //else
                //{
                //    var dr = MsBox.Show("Deseja cancelar a operação?", DResult.YesNo);
                //    if (dr.DialogResult != DialogResult.Yes) return;
                //    RefreshCtrl();
                //}
            }
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
        public void Padrao()
        {
            RefreshCtrl();
            EstadoDaTela(AccaoNaTela.Padrao);
            btnIntroduzir.Text = @"Novo+";
            CleanCtrl();
            btnSalvar.Visible = false;
            btnPagamento.Visible = false;
        }
        private void RefreshCtrl()
        {
            CLocalStamp = "";
            BindCC();
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

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private (bool Tudovalido, string Messagem) Validado()
        {
            if (string.IsNullOrEmpty(tbNome.Text))
            {
                return (false, "Cliente ou Mesa não selecionada");
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
        public bool BeforeSave()
        {
            #region Verificação de Stock dos produtos a serem facturados
            var dt = gridUI1.DataSource as DataTable;
            var values = GenBl.CheckStock(ft, dt, TmpTdoc.Usalote);
            if (!values.StkExiste)
            {
                MsBox.Show(values.Messagem);
                return false;
            }
            #endregion
            return true;
        }
        private void btnIntroduzir_Click(object sender, EventArgs e)
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

        private void Doprocess()
        {
            if (!AddNewRecord && !Updating)
            {
                LimpaTudo();
                DefaultValues();
                if (TmpTdoc.Vd)
                {
                    btnTodosProdutos.PerformClick();
                }
                if (TmpTdoc.Ft)
                {
                    btnSector.PerformClick();
                }
                SetImagens();
                AddNewRecord = true;
                Podepagar = false;
                Updating = false;
                btnPagamento.Visible = false;
                btnSalvar.Visible = true;
            }
            else
            {
                var dr = MsBox.Show("Deseja cancelar a operação?", DResult.YesNo);
                if (dr.DialogResult != DialogResult.Yes) return;
                RefreshCtrl();
                btnPagamento.Visible = false;
                btnSalvar.Visible = false;
            }
        }

        private void SetImagens()
        {
            btnIntroduzir.Text = @"Cancelar";
            btnIntroduzir.Image = Resources.Undo_251px;
        }

        private void LimpaTudo()
        {
            var dt = gridUI1.DataSource as DataTable;
            if (dt.HasRows())
            {
                dt.Rows.Clear();
            }
            gridUI1.SetDataSource(dt);
            CleanCtrl();
        }

        private void CleanCtrl()
        {
            tbData.Text = "";
            tbNumero.Text = "";
            tbMorada.Text = "";
            tbNome.Text = "";
            //tbCaixa.Text = "";
            lblTotal.Text = "";
            //lblTotal2.Text = "";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //progressBar1.Value -= 1;
            //if (progressBar1.Value == 0)
            //{
            //    panelMessageShow.Visible = false;
            //    timer2.Stop();
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //panelMessageShow.Visible = true;
            //progressBar1.Value += 1;
            //if (progressBar1.Value != 20) return;
            //timer1.Stop();
            //timer2.Start();
        }

        private void panelCaixaInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProcNumero_Click(object sender, EventArgs e)
        {
            var f = new PosProc { Tipodados = "decimal", Campo = "numero" };
            BindForm(f);
            Showform(f);
        }

        private void BindForm(PosProc f)
        {
            f.Multidocumento = true;
            f.Condicao1 = $"numdoc={TmpTdoc.Numdoc} and mesa<>0";
            f.cbProc.Visible = false;
            f.PControl = PControl;
            f.Tabela = "fact";
        }

        private void PControl(Fact ft, bool origem = false)
        {
            PreencheCampos(ft);
            Procurou = true;
        }

        private void PreencheCampos(Fact fact)
        {
            ft = fact;
            if (fact!=null)
            {
                tbNome.Text = fact.Nome;
                tbData.Text = fact.Data.ToShortDateString();
                tbNumero.Text = fact.Numero;
                lblTotal.Text = fact.Total.ToString("N2");
                tbMorada.Text = fact.Posto.ToString();
                var dt = SQL.GetGenDT($"select * from factl where factstamp='{fact.Factstamp.Trim()}'");
                gridUI1.SetDataSource(dt);
                gridUI1.Update();
            }
        }

        public bool Procurou { get; set; }
        public bool Produto { get; set; }
        public bool OpenFromModulo { get; set; }
        public bool Cancelando { get; private set; }
        public bool Inserindo { get; private set; }
        public bool EditMode { get; private set; }
        //public string Nomfile { get; private set; }
        public DataTable DtPrint { get; private set; }
        public DataTable DtCC { get; private set; }
        public DataTable DtMesas { get; set; }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            var f = new FrmReservaMesa();
            //Showform(f);
            Showform2(f);
        }

        private void btnTranferir_Click(object sender, EventArgs e)
        {
            var f = new CreateDB();
            Showform(f);
        }

        private void btnMesastatus_Click(object sender, EventArgs e)
        {

            GetTodasMesas();

        }

        private void GetTodasMesas()
        {
            var qry = @"SELECT NO,NOME,Clstamp,Morada,imagem,Morada,Nuit FROM CL where pos =1 order by convert(decimal,no) ";
            DtMesas = SQL.GetGenDT(qry);
            if (DtMesas.HasRows())
            {
                Limpar();
                Helper.FillMesa(DtMesas, this);
            }
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            GetTodosProdutos(sender);
        }

        private void GetTodosProdutos(object sender)
        {
            var dt = SQL.GetGenDT(Helper.GetProdutos());
            if (dt.HasRows())
            {
                Helper.ViewProdutos(dt, (Button)sender, this, Origem);
            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            var f = new PosProc { Tipodados = "varchar", Campo = "nome" };
            BindForm(f);
            Showform(f);
        }

        private void btndata_Click(object sender, EventArgs e)
        {
            var f = new PosProc { Tipodados = "datetime", Campo = "data" };
            BindForm(f);
            Showform(f);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MenuPrint.ShowMenuStrip(btnPrint);

            //if (ft !=null)
            //{
            //    var dt = gridUI1.DataSource as DataTable;
            //    if (dt?.Rows.Count>0)
            //    {
            //        var nomefile = SQL.GetValue("Printfile2","param");
            //        ReportHelper.PrintReport(ft.Factstamp,"",nomefile, "fact",0,true); 
            //    }
            //    else
            //    {
            //        MsBox.Show("Desculpe o documento não tem linhas!");     
            //    }

            //}
            //else
            //{
            //    MsBox.Show("Deve indicar o documento á imprimir!");
            //}
        }

        private void tbProdMesasProc_TextChanged(object sender, EventArgs e)
        {
            var control = fLPSubProduct.Controls;
            if (!string.IsNullOrEmpty(tbProdMesasProc.Text))
            {
                if (control.Count>0)
                {
                    if (control[0] is DMZProduto)
                    {
                        fLPSubProduct.Controls.Clear();
                        if (!DtProdutos.HasRows()) return;
                        var dt = DtProdutos.Select($"Descricao like ('%{tbProdMesasProc.Text.Trim()}%')");
                        if (!(dt.Length > 0)) return;
                        Helper.FillProduct(dt.CopyToDataTable(), this);
                    }
                    if (control[0] is DMZMesas)
                    {
                        fLPSubProduct.Controls.Clear();
                        var dt = DtMesas.Select($"NOME like ('%{tbProdMesasProc.Text.Trim()}%')");
                        if (!(dt.Length > 0)) return;
                        Helper.FillMesa(dt.CopyToDataTable(), this);
                    }
                }
            }
            else
            {
                if (control[0] is DMZProduto)
                {
                    if (!DtProdutos.HasRows()) return;
                    fLPSubProduct.Controls.Clear();
                    Helper.FillProduct(DtProdutos, this);
                }
                if (control[0] is DMZMesas)
                {
                    if (!DtMesas.HasRows()) return;
                    fLPSubProduct.Controls.Clear();
                    Helper.FillMesa(DtMesas, this);
                }
            }
        }

        private void tbSectFamilias_TextChanged(object sender, EventArgs e)
        {
            var control = fLPSubProduct.Controls;
            if (!string.IsNullOrEmpty(tbProdMesasProc.Text))
            {
                if (control.Count > 0)
                {
                    if (control[0] is DMZProduto)
                    {
                        fLPSubProduct.Controls.Clear();
                        if (!DtProdutos.HasRows()) return;
                        var dt = DtProdutos.Select($"Descricao like ('%{tbProdMesasProc.Text.Trim()}%')");
                        if (!(dt.Length > 0)) return;
                        Helper.FillProduct(dt.CopyToDataTable(), this);
                    }
                    if (control[0] is DMZMesas)
                    {
                        fLPSubProduct.Controls.Clear();
                        var dt = DtMesas.Select($"NOME like ('%{tbProdMesasProc.Text.Trim()}%')");
                        if (!(dt.Length > 0)) return;
                        Helper.FillMesa(dt.CopyToDataTable(), this);
                    }
                }
            }
            else
            {
                if (control[0] is DMZProduto)
                {
                    if (!DtProdutos.HasRows()) return;
                    fLPSubProduct.Controls.Clear();
                    Helper.FillProduct(DtProdutos, this);
                }
                if (control[0] is DMZMesas)
                {
                    if (!DtMesas.HasRows()) return;
                    fLPSubProduct.Controls.Clear();
                    Helper.FillMesa(DtMesas, this);
                }
            }
            //if (!string.IsNullOrEmpty(tbSectFamilias.Text))
            //{
            //    fLPButtons.Controls.Clear();
            //    var dt = DtSecFam.Select($"Descricaosector like ('%{tbSectFamilias.Text.Trim()}%')");
            //    if (!(dt.Length > 0)) return;
            //    if (Familias)
            //    {
            //        FillFamilias(dt.CopyToDataTable());
            //    }
            //    else
            //    {
            //        FillSectores(dt.CopyToDataTable());
            //    }
            //}
            //else
            //{
            //    fLPButtons.Controls.Clear();
            //    if (!(DtSecFam?.Rows.Count > 0)) return;
            //    if (Familias)
            //    {
            //        FillFamilias(DtSecFam);
            //    }
            //    else
            //    {
            //        FillSectores(DtSecFam);
            //    }
            //}
        }

        private void btnKb_Click(object sender, EventArgs e)
        {
            Helper.StartOSK();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            lblHora.label1.Text = DateTime.Now.ToString("HH:mm:ss");
            lblData.label1.Text = Pbl.SqlDate.ToShortDateString();
        }

        private void lblTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void passwordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FrmPw();
            Showform(f);
        }

        private void btnSelCl_Click(object sender, EventArgs e)
        {
            var tmpFound = SQL.GetGen2DT("SELECT NO,NOME,Clstamp,Morada,imagem='',Morada,Nuit FROM CL order by no  ");
            if (tmpFound.HasRows())
            {
                var qr = new Querry
                {
                    radGridView1 = { DataSource = null, AutoGenerateColumns = false },
                    Campo1 = "no",
                    Campo2 = "nome",
                    Campo3 = "",
                    PControl2 = SetMesa,
                    ShowStk = false,
                    Width1 = 90,
                    Origem = true,
                    Width2 = 270,
                    Caption1 = "Código",
                    Caption2 = "Descrição"
                };
                qr.Dt = tmpFound;
                qr.radGridView1.DataSource = tmpFound;
                qr.cbPorReferencia.Text = @"Número";
                qr.cbPorReferencia.Checked = true;
                qr.labelX1.Text = tmpFound.Rows.Count + @" registos encontados";
                qr.ShowForm(this, true);
            }
            else
            {
                MsBox.Show("Não exite nenhum cliente cadastrado!");
            }
        }

        private void MenuPrincipal_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void btnCaixaabertura_Click(object sender, EventArgs e)
        {
            if (Pbl.Usr.Abrecaixa || Pbl.Usr.Supervisor)
            {
                if (_caixa == null)
                {
                    var f = new FrmCaixa();
                    f.Enviar = AbrirFecharCaixa;
                    Showform2(f);
                }
                else
                {
                    MsBox.Show("O caixa já esta aberto!");
                }
            }
            else
            {
                MsBox.Show("Não tem permissão para abertura de caixa. \n\r Por favor contacte o administrador do sistema!");
            }
        }
        void AbrirFecharCaixa(Caixa caixa)
        {
            if (caixa != null)
            {
                _caixa = caixa;
                lblcaixa.label1.Text = caixa.Contatesoura;
                Panel_info_caixa.Visible = false;
                lblcaixaAberta.Visible = true;
            }
            else
            {
                _caixa = null;
                lblcaixa.label1.Text = "";
                Panel_info_caixa.Visible = true;
                lblcaixaAberta.Visible = false;
            }
        }

        private void btnFichaCl_Click(object sender, EventArgs e)
        {
            var f = new FrmCl();
            f.Controlacesso = false;
            Showform2(f);
        }

        private void btnFolhaCaixa_Click(object sender, EventArgs e)
        {
            if (Pbl.DtContas.HasRows())
            {
                var dr = Pbl.DtContas.AsEnumerable().Where(x => x.Field<bool>("cx").Equals(true)).FirstOrDefault();
                if (dr !=null)
                {
                    var c = dr.DrToEntity<Usrcontas>();
                    var f = new FrmConsultacx
                    {
                        Codlocal = c.Codtz,
                        label1 = { Text =c.Conta }
                    };
                    f.comboBox1.tb1.Text=c.Conta;
                    f.comboBox1.Text2 = c.Codtz.ToString();
                    f.comboBox1.Text3 = c.Contasstamp;
                    f.cbSupervisor.cb1.Checked = Pbl.Usr.Supervisor;
                    Showform2(f);
                }
            }
        }

        private void btnFecharCaixa_Click(object sender, EventArgs e)
        {
            if (gridUi2?.Rows.Count > 0)
            {
                MsBox.Show("Atenção que tens vendas em aberto, fecha todas as vendas");
            }
            else
            {
                if (_caixa == null)
                {
                    MsBox.Show("Realize abertura do caixa");
                }
                else
                {
                    var f = new Frmfecharcx
                    {
                        Origem = "RCLPOS",
                        Caixa = _caixa,

                    };
                    f.Enviar = AbrirFecharCaixa;
                    Showform2(f);
                }
            }
        }

        private void FrmPosRest_Activated(object sender, EventArgs e)
        {

        }

        private void FrmPosRest_Deactivate(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var f = new FrmLogOff();
            f.Enviar = RecebeActualiza;
            f.ShowForm(this, true);
        }
        void RecebeActualiza()
        {
            FunMetodos();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            var f = new FrmParam();
            f.RemoveTabs();
            Showform(f);
        }

        private void btnRelatVendas_Click(object sender, EventArgs e)
        {
            CallRelatorios();
        }

        private void fLPSubProduct_Paint(object sender, PaintEventArgs e)
        {

        }

        private void documentosInternosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmDi { TdiDefaultCondicao = "Sigla='EFM'", BrowdocCondicao = "VisivelPOS=1" };
            //Showform2(b);
            b.Modulo = "GES";
            b.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void tbBarcode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddLine(tbBarcode.Text.Replace("\r\n", ""), true, null, true);
                tbBarcode.Text = "";
            }
        }

        private void btnDocfact_Click(object sender, EventArgs e)
        {
            CallBrowdoc();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            CallPrintSet(TmpTdoc.Nomfile3, TmpTdoc.XmlStringPOS);
        }

        private void CallPrintSet(string Nomefile, string XmlString)
        {
            if (ft!=null)
            {
                //DS ds = new DS();
                //Utilities.AllTrim(ft);
                //var ret = Imprimir.FillData(ft.ToDataTable(), Factl, null, ds.Fact, ds.Formasp);
                //var Ps = new PrintSetup
                //{
                //    NrCopias = 1,
                //    ListaTipodoc = null,
                //    Origem = "fact",
                //    DtPrint = ret.dtPrint,
                //    Formasp = ret.fp,
                //    Ds = ds,
                //    LinguaNacional = "PT",
                //    Nomfile = TmpTdoc.Nomfile3,
                //    XmlString = TmpTdoc.XmlStringPOS
                //};
                //ReportHelper.PrintReport(Ps); 
                DS ds = new DS();
                var factl = gridUI1.GetBindedTable();
                //var formasp = gridFormasP1.Grelha.DataSource as DataTable;
                Utilities.AllTrim(ft);
                var ret = Imprimir.FillData(ft.ToDataTable(), factl, null, ds.Fact, ds.Formasp);
                Imprimir.CallForm(ret.dtPrint, ret.fp, CLocalStamp, Inserindo, label1.Text, ft.Clstamp, Nomefile, "FT", this, XmlString, true, ds, "", "");
            }
        }

        private void DadosInfo(string IMPRESSORA, decimal NUMERO, List<string> lista, string lingua, string tamanhoPapel)
        {
            for (int i = 0; i < NUMERO; i++)
            {
                //ReportHelper.PrintReport(ft.Factstamp, IMPRESSORA, Nomfile, "fact", NUMERO, true);
            }
        }
        private void DadosInfo2(string IMPRESSORA, decimal NUMERO, List<string> lista, string lingua, string tamanhoPapel)
        {
            for (int i = 0; i < NUMERO; i++)
            {
                //ReportHelper.PrintReport(DtPrint, IMPRESSORA, Nomfile, NUMERO);
            }
        }
        private void nToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CallPrintSet(TmpTdoc.Nomfile, TmpTdoc.XmlString);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindCC();
        }

        private void btnAgrupar_Click(object sender, EventArgs e)
        {
            var f = new FrmAgruparmesas();
            Showform2(f);
        }

        private void btnVirtual_Click(object sender, EventArgs e)
        {
            var qry = @"SELECT NO,CL.NOME,CL.Clstamp,Morada,imagem,Morada,Nuit FROM CL join Unimesa on cl.clstamp=Unimesa.Clstamp  order by convert(decimal,no) ";
            var dt = SQL.GetGenDT(qry);
            if (dt.HasRows())
            {
                Limpar();
                Helper.FillMesa(dt, this);
            }
        }

        private void relatóriosDiversosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CallRelatorios();
        }

        private void CallRelatorios()
        {
            var b = new FrmRelatorios { Modulo = "GES" };
            b.ShowForm(this);
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            var b = new FrmCheckUsr();
            b.SendData = ReceiveUsr;
            b.ShowForm(this, true);
        }

        private void ReceiveUsr(string login, bool existe)
        {
            if (existe)
            {
                if (ft != null)
                {
                    var dr = MsBox.Show($"Deseja eliminar a {ft.Nomedoc}?", login, DResult.YesNo);
                    if (dr.DialogResult == DialogResult.Yes)
                    {
                        if (SQL.SqlCmd($"delete from fact where factstamp ='{ft.Factstamp.Trim()}'") > 0)
                        {
                            BindCC();
                            MsBox.Show($"O DMZ Software fez o estorno do(s) produto(s) associado(s)", login);
                            //Helper.Alert($"{TmpTdoc.Nome.ToUpper()} Eliminada com sucesso", Form_Alert.EnmType.Success);
                        }
                    }
                }
                else
                {
                    MsBox.Show("deve indicar o documento a eliminar, na lista de mesas abaixo", login);
                }
            }
            else
            {
                MsBox.Show("Não foram encontrados informações com dados fornecidos", login);
            }
        }

        private void iMPRIMIRPEDIDOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Nomfile = TmpTdoc.Nomfile2;
            //DS ds = new DS();
            //var factl = gridUI1.GetBindedTable();
            //if (FactlMemory !=null)
            //{
            //    var factstamp = FactlMemory.Select().FirstOrDefault()["factstamp"].ToString().Trim();
            //    ft = SQL.GetRowToEnt<Fact>($"factstamp='{factstamp}'");
            //    if (factl.HasRows())
            //    {
            //        foreach (var r in factl.AsEnumerable())
            //        {
            //            if (r != null)
            //            {
            //                if (!FactlMemory.AsEnumerable().Any(x => x.Field<string>("factstamp").Trim().Equals(r["factstamp"].ToString().Trim())))
            //                {
            //                    var dr = ds.Fact.NewRow();
            //                    foreach (DataColumn col in ds.Fact.Columns)
            //                    {
            //                        if (col != null)
            //                        {
            //                            if (factl.Columns.Contains(col.ColumnName.Trim()))
            //                            {
            //                                dr[col.ColumnName.Trim()] = r[col.ColumnName.Trim()];
            //                            }
            //                        }
            //                    }
            //                    ds.Fact.AddRow(dr);
            //                }
            //                else if (FactlMemory.AsEnumerable().Any(x => x.Field<string>("factstamp").Trim().Equals(r["factstamp"].ToString().Trim())))
            //                {
            //                    DataRow row = FactlMemory.AsEnumerable().Where(x => x.Field<string>("factstamp").Trim().Equals(r["factstamp"].ToString().Trim())).FirstOrDefault();
            //                    if (row["quant"].ToDecimal() < r["quant"].ToDecimal())
            //                    {
            //                        var dr = ds.Fact.NewRow();
            //                        foreach (DataColumn col in ds.Fact.Columns)
            //                        {
            //                            if (col != null)
            //                            {
            //                                if (factl.Columns.Contains(col.ColumnName.Trim()))
            //                                {
            //                                    if (col.ColumnName == "quant")
            //                                    {
            //                                        dr[col.ColumnName.Trim()] = r["quant"].ToDecimal() - row["quant"].ToDecimal();
            //                                    }
            //                                    else
            //                                    {
            //                                        dr[col.ColumnName.Trim()] = r[col.ColumnName.Trim()];
            //                                    }
            //                                }
            //                            }
            //                        }
            //                        ds.Fact.AddRow(dr);
            //                    }
            //                }
            //            }
            //        }

            //        var props = ft.GetType().GetProperties();
            //        foreach (var dr in ds.Fact.AsEnumerable())
            //        {
            //            if (dr != null)
            //            {
            //                foreach (DataColumn col in ds.Fact.Columns)
            //                {
            //                    var prop = props.FirstOrDefault(x => x.Name.ToLower().Equals(col.ColumnName.ToLower()));
            //                    if (prop != null)
            //                    {
            //                        dr[prop.Name.Trim()] = prop.GetValue(ft, null).ToString();
            //                    }
            //                }
            //            }
            //        }
            //    }
            //    if (ds.Fact.HasRows())
            //    {
            //        DtPrint = ds.Fact;
            //        var frmset = new FrmPrintset();
            //        frmset.DadosEnviados += DadosInfo2;
            //        frmset.ShowForm(this, true);
            //    } 
            //}
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Helper.UpdateGrid(false, gridUi2, DtCC, textBox1.Text);
        }

        private void prosutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmCheckUsr();
            b.SendData = OpenProduto;
            b.ShowForm(this, true);
        }

        private void OpenProduto(string login, bool existe)
        {
            if (existe)
            {
                var b = new FrmProduto
                {
                    Servico = false,
                    Origem = "Pr",
                    Controlacesso = false
                };
                b.ShowForm(this, true);
                //Showform2(b);
            }
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmCheckUsr();
            b.SendData = OpenServico;
            b.ShowForm(this, true);

        }

        private void OpenServico(string login, bool existe)
        {
            if (existe)
            {
                var b = new FrmProduto { Servico = true, Origem = "Sr", Controlacesso = false };
                b.ShowForm(this, true);
            }
        }

        private void btnTmesas_Click(object sender, EventArgs e)
        {
            GetTodasMesas();
        }

        private void btnTodProduto_Click(object sender, EventArgs e)
        {
            GetTodosProdutos(sender);
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
                if (TmpTdoc.Ft)
                {
                    BindCC();
                    // ft = null;
                }
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
            btnSalvar.Visible=false;
        }

        private void btnMovimentos_Click(object sender, EventArgs e)
        {
            var query = $"select ccstamp Factlstamp,Nome descricao,cast (0 as bit) as ok,ccstamp Factstamp,valorpreg totall,cast (0 as bit) Fecho," +
                $"Clstamp ref,oristamp  from ClCCF() where ccstamp not in('{CLocalStamp}')";
            var dtPe = SQL.GetGenDT(query);
            var l = new FrmSelect
            {
                SelectCampos = $@"Factlstamp,descricao, cast (0 as bit) as ok,Factstamp,totall,Activo Fecho,ref,oristamp",
                HideFirstColumn = true,
                Tamanhos = new List<decimal> { 0, 150, 0, 0, 0, 0, 0, 0 },
                ColFillName = "descricao",
                Tabela = "factl",
                Condicao = "where 1=0",
                SendData = ReceiveInfo,
                _dt = dtPe
            };
            var qry = $@"select Factlstamp,descricao, cast (0 as bit) as ok,Factstamp,totall,Activo Fecho,ref,oristamp from Factl  where 1=0";
            l._dt2 = SQL.GetGenDT(qry);
            l.ShowDialog();
        }

        private void ReceiveInfo(DataTable dt)
        {
            string factstamp = "";
            if (dt.HasRows())
            {
                foreach (var row in dt.AsEnumerable())
                {
                    if (row != null)
                    {
                        if (!factstamp.IsNullOrEmpty())
                        {
                            factstamp+= $",'{row["factstamp"]}'";
                        }
                        else
                        {

                            factstamp= $"'{row["factstamp"]}'";
                        }
                        var fact = SQL.GetGenDT($"select * from factl where factstamp='{row["factstamp"].ToTrim()}'");

                         if (fact.HasRows())
                        {
                            foreach (DataRow item in fact.Rows)
                            {
                                gridUI1.AddLine();
                                gridUI1.DataRowr["Ststamp"] = item["Ststamp"];
                                gridUI1.DataRowr["descricao"] = item["descricao"];
                                gridUI1.DataRowr["Factstamp"] = CLocalStamp;
                                gridUI1.DataRowr["totall"] = item["totall"];
                                gridUI1.DataRowr["valival"] = item["valival"];
                                gridUI1.DataRowr["txiva"] = item["txiva"];
                            }
                        }
                    }
                }

                var sss = factstamp.Replace("'","").Split(',');
                foreach (DataGridViewRow row in gridUi2.Rows)
                {
                    var dts = gridUi2.GetBindedTable();
                    for (int j = 0; j < sss.Length; j++)
                    {
                        var fffstam = row.Cells["factstamp"].Value.ToString().ToLower();
                        var fffstamstasmp = sss[j].ToLower();
                        if (row.Cells["factstamp"].Value.ToString().ToLower().Equals(sss[j].ToLower()))
                        {
                            gridUi2.Rows.RemoveAt(row.Index);
                        }
                    }
                }
                    
                //SQL.SqlCmd($"delete fact where factstamp in ({factstamp})");

               // BindCC();
                gridUI1.Update();
            }
        }
    
    }
}
