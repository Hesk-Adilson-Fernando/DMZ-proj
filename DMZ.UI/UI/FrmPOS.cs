using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Generic;
using Util = DMZ.UI.Generic.Util;

namespace DMZ.UI.UI
{
    public partial class FrmPOS : Basic.FrmClasse2
    {
        public Tdoc TmpTdoc;
        public DataTable Factl { get; set; }
        public bool NVerificar { get; private set; }
        public DataTable DtSt { get; private set; }
        public DataRow DataRow { get; set; }
        public bool LRunStk { get; set; }
        public Fact ft;

        public string CLocalStamp { get; private set; }

        public Cl Cl;
        public string Ctabela { get; set; }

        public string Campo2 { get; set; }

        public string Campo1 { get; set; }
        public Usr Usr { get; set; }

        public FrmPOS()
        {
            InitializeComponent();
        }

        private void FrmPOS_Load(object sender, EventArgs e)
        {
            lblInfo.Text = Pbl.Info;
            btnAdd.Focus();
            Campo1 = "Numero";
            Campo2 = "nome";
            Ctabela = "fact";
            CLocalStamp = "";
            TmpTdoc = SQL.GetRowToEnt<Tdoc>( " Tipodoc=2 ");
            BindGrid();
            posButtomGroup1.txtCodigo.Focus();
            KeyUp += KeyEvent;
            KeyPreview = true;
        }
        private void KeyEvent(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    DefaultValues();
                    break;
                case Keys.F2:
                    Pagar();
                    break;
            }
        }
        void BindGrid()
        {
            Factl = SQL.GetGen2DT($"select * from factl where factstamp='{CLocalStamp}'");
            gridUI1.DataSource = null;
            gridUI1.AutoGenerateColumns = false;
            gridUI1.DataSource = Factl;
        }
        public  void PreencheCampos(DataTable dt, int i)
        {
            //ft = FillControls(ft, dt, i);
            //tbDesconto.tB1.Text.SetMask();
            //tbSubTotal.tB1.Text.SetMask();
            //tbTotal.tB1.Text.SetMask();
            //tbTotalIva.tB1.Text.SetMask();

            //BindGrid();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnClosePanelMenu_Click(object sender, EventArgs e)
        {
            //if (panelMenu.Width== 419)
            //{
            //    panelMenu.Width = 1;
            //}
            //else
            //{
            //    panelMenu.Width = 419;
            //    panelMenu.Location = new Point(859, 100);
            //    panelMenu.Visible = true;
            //}
        }
        private void posButtomGroup1_RefreshControls()
        {
            Addline(posButtomGroup1.txtCodigo.Text.Trim());
            posButtomGroup1.txtCodigo.Text = "";
        }
        public  void Addline(string referenc)
        {
            if (ft==null)
            {
                DefaultValues();
            }
            var nMaxOrdem = Factl.Rows.Count == 0 ? 0 : Factl.AsEnumerable().Max(x => x.Field<decimal?>("ordem")).ToString().ToDecimal();
            nMaxOrdem = nMaxOrdem + 100;
            var tmpFound = SQL.GetRowToEnt<St>($" ltrim(rtrim(Referenc)) ='{referenc.Trim()}' ");
            if (tmpFound == null) return;
            var   rows=Factl.Select($"ref ='{tmpFound.Referenc.Trim()}'");
            if (rows.Length >0)
            {
                foreach (var r in rows)
                {
                    r["quant"] = r["quant"].ToDecimal() + 1;
                    Totaislinha(true);
                }
            }
            else
            {
                DataRow = Factl.NewRow();
                GenBl.SetLineValues(DataRow, tmpFound,ft,false,null,false,Pbl.MoedaBase,"","");
                var image = Util.ByteToImage(tmpFound.Imagem);
                pictureBox2.Image = image;
                DataRow["ordem"] = nMaxOrdem;
                LRunStk = false;
                if (tmpFound.Nmovstk)
                {
                    var crTst1 = SQL.GetGenDT(" tabmovstk ", $"where LTRIM(RTRIM(ref))= '{tmpFound.Referenc.Trim()}' and nnumdoc = {TmpTdoc.Numdoc}", " nnumdoc ");
                    if (crTst1.Rows.Count > 0)
                    {
                        LRunStk = true;
                    }
                    crTst1.Dispose();
                    DataRow["nmovstk"] = LRunStk;
                }
                GenBl.TotaisLinhas(DataRow);
                txtDescricao.Text = DataRow["descricao"].ToString();
                txtPreco.Text = DataRow["Preco"].ToString();
                txtQuant.Text = DataRow["Quant"].ToString();
                txtSubTotal.Text = DataRow["Totall"].ToString();
                Factl.Rows.Add(DataRow);
                gridUI1.Update();
                TotaisFt();
                SetFocusColumn();
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
            gridUI1.EndEdit();
            Refresh();
            NVerificar = false;
        }
        private void SetFocusColumn()
        {
            if (gridUI1.Rows.Count <= 0) return;
            var index = gridUI1.Rows.Count - 1;
            gridUI1.CurrentCell = gridUI1.Rows[index].Cells["Quant"];
            gridUI1.BeginEdit(true);
        }
        private void TotaisFt()
        {
            var tbDesconto= Factl.AsEnumerable().Sum(x => x.Field<decimal>("Descontol")).ToString().SetMask();
            var tbSubTotal= Factl.AsEnumerable().Sum(x => x.Field<decimal>("Subtotall")).ToString().SetMask();
            lblTotal.Text = Math.Round(Factl.AsEnumerable().Sum(x => x.Field<decimal>("Totall")),0).ToString().SetMask();
            var tbTotalIva = Factl.AsEnumerable().Sum(x => x.Field<decimal>("valival")).ToString().SetMask();
            ft.Desconto = tbDesconto.ToDecimal();
            ft.Subtotal = tbSubTotal.ToDecimal();
            ft.Totaliva = tbTotalIva.ToDecimal();
            ft.Total = lblTotal.Text.ToDecimal();
            gridUI1.Update();
            posButtomGroup1.txtCodigo.Focus();
        }
        public  void DefaultValues()
        {
            ft = BL.Classes.Utilities.DoAddline<Fact>();
            CLocalStamp = ft.Factstamp;
            ft.Sigla = TmpTdoc.Sigla;
            ft.Data = Pbl.SqlDate;
            ft.Datcaixa = Pbl.SqlDate;
            ft.Numdoc = TmpTdoc.Numdoc;
            ft.Nomedoc = TmpTdoc.Descricao;
            ft.Movtz = TmpTdoc.Movtz;
            ft.Movstk = TmpTdoc.Movstk;
            ft.Descmovstk = TmpTdoc.Descmovstk;
            ft.Codmovstk = TmpTdoc.Codmovstk;
            ft.Movcc = TmpTdoc.Movcc;
            ft.Descmovcc = TmpTdoc.Descmovcc;
            ft.Codmovcc = TmpTdoc.Codmovcc;
            ft.Moeda=Pbl.MoedaBase;
            ft.Ccusto = Usr.Ccusto;
            Cl = SQL.GetRowToEnt<Cl>( " Pos=1 ");
            ft.No = Cl.No;
            ft.Nome = Cl.Nome;
            tbCliente.Text = Cl.Nome;
            var posto = SQL.GetRowToEnt<Pv>( $" codigo={Usr.Codposto} ");
            tbPosto.Text = posto.Descricao;
            tbCaixa.Text= posto.Cx;
            var max = SQL.VMax("fact",TmpTdoc.Numdoc,ft.Data.Year);
            ft.Numero = max.ToString();
            tbNumero.Text = max.ToString();
            tbTeste.Text = Pbl.SqlDate.ToShortDateString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DefaultValues();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            Pagar();
        }
        private void Pagar()
        {
            if (Factl?.Rows.Count!=0)
            {
                var values = GenBl.CheckStock(ft, Factl, TmpTdoc.Usalote);
                if (values.StkExiste)
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
                    MsBox.Show(values.Messagem);
                }
            }
            else
            {
                MsBox.Show("Desculpe mas tem que indicar artigo a facturar.");
            }
        }
        private void gridUI1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (!NVerificar) return;
            NVerificar = false;
            Totaislinha(true);
        }
        private void gridUI1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUI1.CurrentRow == null) return;
            var name = gridUI1.CurrentCell.OwningColumn.Name.ToLower().Trim();
            if (name.Equals("quant") || name.Equals("preco"))
            {
                NVerificar = true;
            }
        }


        //private bool ChkTesoura()
        //{
        //    if (!(gridFormasP1.Formaspdt?.Rows.Count > 0)) return false;
        //    foreach (var r in gridFormasP1.Formaspdt.AsEnumerable())
        //    {
        //        if (r == null) continue;
        //        var f = r.DrToEntity<Formasp>();
        //        if (string.IsNullOrEmpty(f.Contatesoura))
        //        {
        //            MsBox.Show("Por favor indica o local de Tesouraria, nas formas de pagamento");
        //            return false;
        //        }
        //        if (string.IsNullOrEmpty(f.Titulo))
        //        {
        //            MsBox.Show("Por favor indica a Forma de Pagamento, nas formas de pagamento");
        //            return false;
        //        }
        //        if (string.IsNullOrEmpty(f.Banco) && f.Numer)
        //        {
        //            MsBox.Show("Desculpe mas tem que indicar o Banco, nas formas de pagamento");
        //            return false;
        //        }
        //        if (string.IsNullOrEmpty(f.Numtitulo) && f.ObgTitulo)
        //        {
        //            MsBox.Show($"Desculpe mas Tem que indicar o Número de {f.Titulo}, nas formas de pagamento");
        //            return false;
        //        }
        //        var crCnt = SQLExec.QEnt<Contas>($"Select * from contas (nolock) where codigo={f.Codtz}");
        //        if (crCnt == null) return false;
        //        if (crCnt.Codtipo == 1 && !f.Numer && f.Tipo)
        //        {
        //            MsBox.Show("Desculpe na conta de Tesouraria seleccionada deve indicar o Título correspondente. Obrigado, nas formas de pagamento");
        //            return false;
        //        }
        //    }
        //    return true;
        //}
        public void SaveData()
        {
            SQL.Save(Factl, "factl",false,"","");
        }

        private void gridUI1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void gridUI1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUI1.CurrentCell != null)
            {
                var row = gridUI1.CurrentCell.OwningRow;
                if (row == null) return;
                txtDescricao.Text = row.Cells["descricao"].Value.ToString();
                txtPreco.Text = row.Cells["preco"].Value.ToString();
                txtQuant.Text = row.Cells["quant"].Value.ToString();
                txtSubTotal.Text = row.Cells["SubTotal"].Value.ToString();
            }
            if (gridUI1.CurrentCell != null)
            {
                var name = gridUI1.CurrentCell.OwningColumn.Name;
                if (name.ToLower().Equals("del"))
                {
                    gridUI1.DellLine();
                    Totaislinha(true);
                }
            }
        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            Pagar();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel8.ClientRectangle, Color.DarkGoldenrod, ButtonBorderStyle.Solid);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel2.ClientRectangle, Color.DarkGoldenrod, ButtonBorderStyle.Solid);
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel7.ClientRectangle, Color.DarkGoldenrod, ButtonBorderStyle.Solid);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
