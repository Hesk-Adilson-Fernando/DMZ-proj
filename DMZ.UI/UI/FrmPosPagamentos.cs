using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Classes;
using DMZ.UI.Generic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DMZ.UI.UI
{
    public partial class FrmPosPagamentos : Basic.FrmClasse2
    {
        public FrmPosPagamentos()
        {
            InitializeComponent();
        }
        public Tdoc TmpTdoc { get; set; }
        public TRcl TmpTrcl;
        public Moedas Moeda;
        public DataTable PrintDt { get; set; }
        public DataTable ContasDt { get; set; }
        public DataTable Cc { get; set; }
        public Cl Cl;
        public Fact ft;
        public string CLocalStamp { get; set; } = "";

        private void FrmPosPagamentos_Load(object sender, EventArgs e)
        {
            lblData.label1.Text = Pbl.SqlDate.ToShortDateString();
            TmpTdoc = SQL.GetRowToEnt<Tdoc>("sigla ='VD'");
            Moeda = SQL.GetRowToEnt<Moedas>(" princip = 1 ");
            TmpTrcl = SQL.GetRowToEnt<TRcl>(" numdoc =1 "); 
            var lista = new List<SqlParameter>
            {
                new SqlParameter("@codlocal",SqlDbType.Int)
            };
            lista[0].Value = Pbl.Usr.Codtz;
            ContasDt = SQL.SqlSP("ContasPOS",lista);
            PrintDt = GenBl.PrintPos("", 0);
            SetValues(TmpTdoc);
            KeyPreview = true;
            dmzImgLabel1.label1.Text = Pbl.Usr.Nome;
            lblCcusto.label1.Text = Pbl.Usr.Ccusto;
            Empresa.label1.Text = Pbl.Empresa.Nome;
            WindowState = FormWindowState.Maximized;
            lblTotal.Text = "";
            BindGrid();
            GetCaixa();
            timer1_Tick(sender, e);
        }
        private void GetCaixa()
        {
            Panel_info_caixa.Visible = true;
            var caixa = GenBl.GetCaixa(Pbl.SqlDate,Pbl.Usr.Usrstamp);
            if (!(caixa==null)) return;
            lblcaixa.label1.Text = caixa.Contatesoura;
            Pbl.Usr.ContaTesoura = caixa.Contatesoura;
            Pbl.Usr.Codtz = caixa.Codtz;
            Panel_info_caixa.Visible = false;
            CaixaAberta = true;
        }
        public void CheckAberturaCaixa()
        {
            var abertura = SQL.GetGen2DT(@"select Codtz,convert(VARCHAR,Data,103) data from Caixa where convert(VARCHAR, Data, 103) = convert(VARCHAR, GETDATE(), 103)");
            if (abertura.Rows.Count > 0)
            {
                CaixaAberta = true;

            }
            else
            {
                CaixaAberta = false;
                MsBox.Show("Deve abrir o caixa!..");
            }
        }
        private void SetValues(Tdoc tmpTdoc)
        {
            lblDoc.Text = tmpTdoc.Descricao;
        }


        public DataTable Factl { get; set; }
        private void FillFactl() => Factl = SQL.GetGen2DT($" select * from factl where factstamp='{CLocalStamp.Trim()}'");

        public void RefreshCtrl()
        {
            CLocalStamp = "";
            ft = null;
            BindGrid();
            gridUI1.Update();
            lblTotal.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        public bool Pay { get; set; }

        private void gridUI1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUI1.CurrentRow == null) return;
            var nome = gridUI1.CurrentCell.OwningColumn.Name;
            if (!nome.Equals("Pagar")) return;
            var factstamp = gridUI1.CurrentRow.Cells["factstamp"].Value.ToString().Trim();
            ft =SQL.GetDT("fact",$"factstamp='{factstamp.Trim()}'").DtToList<Fact>().FirstOrDefault();
            lblTotal.Text = !ft.Sigla.Equals("NC") ? ft.Total.ToString().SetMask() : (-1 * ft.Total).ToString().SetMask();

            CLocalStamp = ft.Factstamp;
            Cl = SQL.GetDT("cl",$"no={ft.No}").DtToList<Cl>().FirstOrDefault();
            FillFactl();
            Pay = true;
            if (!CaixaAberta)
            {
                MsBox.Show("Realize abertura do caixa");
            }
            else
            {
                if (!Pay) return;
                if (string.IsNullOrEmpty(lblTotal.Text)) return;
                if (Factl?.Rows.Count > 0)
                {
                    if (ft != null)
                    {
                        PrintDt=Helper.FillPrintDt(ft.Factstamp);
                        foreach (DataRow r in ContasDt.Rows)
                        {
                            if (r != null)
                            {
                                r["valor"] = 0;
                            }
                        }
                        var dr = ContasDt.AsEnumerable().Where(x => x.Field<bool>("numer").Equals(true)).FirstOrDefault();
                        if (dr != null)
                            dr["valor"] = lblTotal.Text;//gridUI1.CurrentRow.Cells["debito"].Value.ToDecimal();
                        if (gridUI1.CurrentRow == null) return;
                        var f = new FrmPagamentos
                        {
                            tbDivida = { Text = gridUI1.CurrentRow.Cells["debito"].Value.ToString() },
                            tbCliente = { Text = gridUI1.CurrentRow.Cells["nome"].Value.ToString() },
                            tbPago = { Text = gridUI1.CurrentRow.Cells["debito"].Value.ToString() },
                            StartPosition = FormStartPosition.CenterScreen,
                            TmpTdoc = TmpTdoc,
                            ft = ft,
                            TmpTrcl = TmpTrcl,
                            Tipodoc = "FT",
                        };
                        f.cbImprimir.Update(true);
                        f.cbPOS.Update(true);
                        f.Beginvoke += RefreshCtrl;
                        Showform(f);
                    }
                    else
                    {
                        MsBox.Show("Desculpe a Factura esta vazia!");
                    }
                }
                else
                {
                    MsBox.Show("Desculpe o documento não tem linhas!");
                }
                //}
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.label1.Text = Horas();
            //lblData.label1.Text = Pbl.SqlDate.ToShortDateString();
        }

        private string Horas()
        {
            return $"{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}";
        }

        public void BindGrid()
        {
            var qry = @"select nome,debito,cc.ccstamp,Factstamp,no from  cc left join rcll on cc.ccstamp = rcll.ccstamp
                where oristamp like ('%POSSUP%') and cc.origem in ('FT','NC') and debito-debitof<>0";
            Cc = SQL.GetGen2DT(qry);
            gridUI1.DataSource = null;
            gridUI1.AutoGenerateColumns = false;
            gridUI1.DataSource = Cc;
        }

        //Menu Lateral --- Abertura de caixa
        public bool CaixaAberta { get; set; }
        public void Checkcaixa()
        {
            CaixaAberta = true;
            Panel_info_caixa.Visible = false;
            lblcaixa.Text = Pbl.Usr.ContaTesoura;
        }
        private void F_FormClosing(object sender, FormClosingEventArgs e)
        {
            panel15.BackgroundImage = Properties.Resources.pexels_oleg_magni_1005638;
        }
        void Receber(Caixa caixa)
        {
            lblcaixa.label1.Text = caixa.Contatesoura;
        }
        private void Showform2(Form f)
        {
            f.TopLevel = false;
            f.Size = new Size(panel15.Size.Width - 10, panel15.Size.Height - 10);
            panel15.Controls.Clear();
            panel15.Controls.Add(f);
            f.FormClosing += F_FormClosing; 
            f.Show();
            panel15.BackgroundImage = null;
        }
        private void aberturaDoCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void folhaDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fechoDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void fichaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FrmCl();
            Showform2(f);
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            if (!CaixaAberta)
            {
                MsBox.Show("Realize abertura do caixa");
            }
            else
            {
                BindGrid();
            }
        }
        private void Showform(Form f)
        {
            f.TopLevel = false;
            f.Size = new Size(panel15.Size.Width - 10, panel15.Size.Height - 10);
            panel15.Controls.Clear();
            panel15.Controls.Add(f);
            f.FormClosing += F_FormClosing;
            f.Show();
            panel15.BackgroundImage = null; 
        }
        private void btnPw_Click(object sender, EventArgs e)
        {
            var p = new FrmPw();
            p.ShowForm(this, true);
        }

        private void tbnAbertura_Click(object sender, EventArgs e)
        {
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

        private void btnDocs_Click(object sender, EventArgs e)
        {
            var b = new FrmDi {TdiDefaultCondicao = "Sigla='EFM'", BrowdocCondicao = "VisivelPOS=1"};
            Showform2(b);
        }

        private void btnFechocaixa_Click(object sender, EventArgs e)
        {
            if (gridUI1?.Rows.Count > 0)
            {
                MsBox.Show("Atenção que tens vendas em aberto, fecha todas as vendas");
            }
            else
            {
                if (Pbl.Usr.Fechacaixa || Pbl.Usr.Supervisor)
                {
                    if (!CaixaAberta)
                    {
                        if (Pbl.Usr.Usradmin)
                        {
                            Callformfechar();
                        }
                        else
                        {
                            MsBox.Show("Realize abertura do caixa");    
                        }
                    }
                    else
                    {
                        Callformfechar();
                    }
                }
                else
                {
                    MsBox.Show("Desculpa mais não tem permissão para fechar caixa. \n\r Contacte o administrador do sistema!");
                }
            }
        }

        private void Callformfechar()
        {
            var f = new Frmfecharcx {Origem = "RCLPOS"};
            Showform2(f);
        }

        private void btnFolhaCaixa_Click(object sender, EventArgs e)
        {
            //if (!CaixaAberta) return;
            var f = new FrmConsultacx
            {
                Codlocal = Pbl.Usr.Codtz.ToDecimal(),
                //caixa = { Visible = false },
                label1 = { Text = @"Conta Principal: " + Pbl.Usr.ContaTesoura }
            };
            Showform2(f);
        }

        private void btnCaixaPrint_Click(object sender, EventArgs e)
        {
            //if (!CaixaAberta) return;
            var f = new FrmPosPrint();
            Showform2(f);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in gridUI1.Rows)
            {
                var factstamp = r.Cells["factstamp"].Value.ToString().Trim();
                MsBox.Show(factstamp);
            }
        }
    }
}
