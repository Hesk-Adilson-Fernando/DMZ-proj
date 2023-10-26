using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using DMZ.UI.Reports;
using Microsoft.VisualBasic;
using DataTable = System.Data.DataTable;
using Utilities = DMZ.BL.Classes.Utilities;

namespace DMZ.UI.UI
{
    public partial class FrmPagar : Basic.FrmClasse2
    {
        public FrmPagar()
        {
            InitializeComponent();
        }
        private DataTable _formasp;
        private DataTable _dt;
        private DataTable rcll;
        private DataTable tmpDivida;
        public string Origem { get; set; }
        public string Factstamp { get; set; }
        public int Clno { get; set; }
        public Mesas Mesa ;
        public Cl Cl;
        private RCL rcl;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDezmil_Click(object sender, EventArgs e)
        {
            Troco(10000);
        }

        private void Troco(decimal valor)
        {
            if (gridUi1.CurrentRow != null)
                gridUi1.CurrentRow.Cells["Valor"].Value = gridUi1.CurrentRow.Cells["Valor"].Value.ToDecimal() + valor;
            gridUi1.Update();
            Totais();
        }

        private void btnCincoMil_Click(object sender, EventArgs e)
        {
            Troco(5000);
        }

        private void btnMil_Click(object sender, EventArgs e)
        {
            Troco(1000);
        }

        private void btnQuinhentos_Click(object sender, EventArgs e)
        {
            Troco(500);
        }

        private void btnCem_Click(object sender, EventArgs e)
        {
            Troco(100);
        }

        private void FrmPagar_Load(object sender, EventArgs e)
        {
             //_dt = SQL.GetGenDT("select Descricao,valor =0,estado=0,ObgTitulo,Codigo from Fpagam where pos=1 order by codigo ");
            KeyUp += KeyEvent;
            KeyPreview = true;      
            gridUi1.DataSource = null;
            gridUi1.AutoGenerateColumns = false;
            gridUi1.DataSource = ContasDt;
            DefaultPrinter=ReportHelper.PrinterList(true).Rows[0].ToString();
        }

        public string DefaultPrinter { get; set; }


        private void KeyEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                //Pagar();
            }
            if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
            {
                AddValue("0");
            }
            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                AddValue("1");
            }
            if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                AddValue("2");
            }
            if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                AddValue("3");
            }

            if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {
                AddValue("4");
            }
            if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
            {
                AddValue("5");
            }
            if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
            {
                AddValue("6");
            }
            if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
            {
                AddValue("7");
            }
            if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
            {
                AddValue("8");
            }
            if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
            {
                AddValue("9");
            }

        }

        private void b1_Click(object sender, EventArgs e)
        {
            AddValue(b1.Text);
        }

        private void AddValue(string valor)
        {
            if (gridUi1.CurrentRow != null)
                gridUi1.CurrentRow.Cells["Valor"].Value = gridUi1.CurrentRow.Cells["Valor"].Value + valor;
            gridUi1.Update();
            Totais();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            AddValue(b2.Text);
        }

        private void b3_Click(object sender, EventArgs e)
        {
            AddValue(b3.Text);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            AddValue(b4.Text);
        }

        private void b5_Click(object sender, EventArgs e)
        {
            AddValue(b5.Text);
        }

        private void b6_Click(object sender, EventArgs e)
        {
            AddValue(b6.Text);
        }

        private void b7_Click(object sender, EventArgs e)
        {
            AddValue(b7.Text);
        }

        private void b8_Click(object sender, EventArgs e)
        {
            AddValue(b8.Text);
        }

        private void b9_Click(object sender, EventArgs e)
        {
            AddValue(b9.Text);
        }

        private void b0_Click(object sender, EventArgs e)
        {
            AddValue(b0.Text);
        }

        private void btC_Click(object sender, EventArgs e)
        {
            if (gridUi1.CurrentRow != null)
                gridUi1.CurrentRow.Cells["Valor"].Value = gridUi1.CurrentRow.Cells["Valor"].Value.ToString().RemoveLast();
            gridUi1.Update();
            Totais();
        }

        private void btD_Click(object sender, EventArgs e)
        {
            if (gridUi1.CurrentRow != null) 
                gridUi1.CurrentRow.Cells["Valor"].Value = 0;
            gridUi1.Update();
            Totais();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        public bool Loarded { get; set; }

        private void Totais()
        {           
            var total = ContasDt.Total("valor");
            tbPago.Text=total.ToString(CultureInfo.InvariantCulture).SetMask();
            tbTroco.Text = total==0 ? "0" : (total-tbDivida.Text.ToDecimal()).ToString();
        }

        private decimal _npago;
        public Moedas Moeda;
        private void btnAceitar_Click(object sender, EventArgs e)
        {
            _npago = tbPago.Text.ToDecimal();
            var ntotdivida = tbDivida.Text.ToDecimal();
            if (_npago < ntotdivida)
            {
                MsBox.Show("Desculpe mas não pode pagar valor inferior ao valor do documento!");
                return;
            }
            if (_npago > ntotdivida)
            {
                _npago= _npago-tbTroco.Text.ToDecimal();
                tbTroco.Text = (_npago - ntotdivida).ToString();
                tbPago.Text = _npago.ToString();
            }
            if (_npago==ntotdivida)
            {
                tmpDivida = GenBl.GetCc(Cl.Clstamp.Trim(),"clccf","cl");
                if (tmpDivida?.Rows.Count > 0)
                {
                    if (RclAdd())
                    {
                        if (PrintDt?.Rows.Count>0)
                        {
                            var nomefile = SQL.GetValue("Printfile2","param");
                            //ReportHelper.PrintReport(Factstamp,"",nomefile, "fact",0,true);  
                        }
                        else
                        {
                            MsBox.Show("Não tem nada por imprimir.\r\nA tabela PrintDt está vazia!");
                        }
                    
                    }
                    else
                    {
                        MsBox.Show("Erro ao processar o pagamento!..");     
                    }

                    Beginvoke?.Invoke();
                    Close();
                }
                else
                {
                    MsBox.Show($"Desculpe mas não foi encontrado movimento para a {Cl.Nome}!..");  
                }
            }
            else
            {
                MsBox.Show("Desculpe o valor a regularizar não é igaual ao valor pago!..");      
            }
        }

        public TRcl TmpTrcl;

        private bool RclAdd()
        {
            rcll=SQL.GetGenDT("Select * from rcll where 1=0");
            var maximo = SQL.Maximo("rcl","numero",$"Year(data) ={Pbl.SqlDate.Year} ");
           rcl  = Utilities.DoAddline<RCL>();
           rcl.Nome = Cl.Nome;
           rcl.Moeda = Moeda.Moeda;
           rcl.No = Cl.No;
           rcl.Numero = maximo;
           rcl.Data = Pbl.SqlDate;
           rcl.Numdoc = TmpTrcl.Numdoc;
           rcl.Sigla = TmpTrcl.Sigla;
           rcl.Nomedoc = TmpTrcl.Descricao;
           rcl.Codmovcc = TmpTrcl.Codmovcc; 
           rcl.Descmovcc = TmpTrcl.Descmovcc;
           rcl.Codmovtz = TmpTrcl.Codmovtz; 
           rcl.Descmovtz = TmpTrcl.Descmovtz;
           rcl.Ccusto = Pbl.Usr.Ccusto;
           rcl.Total = _npago;
           var res = EF.Save(rcl);
           if (res.ret==1)
           {
               foreach (var r in tmpDivida.AsEnumerable())
               {
                   Helper.FillRcl(rcll, r, rcl.Rclstamp,"rcl");
               }
               SQL.Save(rcll, "rcll", false, "", "");
               _formasp = SQL.GetGen2DT("select * from formasp where 1=0");
               foreach (var row in ContasDt.AsEnumerable())
               {
                   if (row == null) continue;
                   if (row["valor"].ToDecimal() <= 0) continue;
                   var r = _formasp.NewRow();
                   r["Rclstamp"] = rcl.Rclstamp;
                   r["Banco"] = row["sigla"].ToString();
                   r["Codtz"] = row["codigo"].ToDecimal();
                   r["Origem"] = "RCLPOS";
                   r["UsrLogin"] = Pbl.Usr.Usrstamp;
                   r["Codmovtz"] = TmpTrcl.Codmovtz;
                   r["Descmovtz"] = TmpTrcl.Descmovtz;
                   r["Contatesoura"] = row["contas"].ToString();
                   r["Titulo"] = row["Descricao"].ToString();
                   r["ObgTitulo"] = row["ObgTitulo"].ToBool();
                   r["Formaspstamp"] = Pbl.Stamp();
                   r["Dcheque"] = rcl.Data;
                   r["valor"] = row["valor"].ToDecimal();
                   _formasp.Rows.Add(r);
               }

               SQL.Save(_formasp, "formasp", false, "", "");
               return true;
           }
           else
           {
               MsBox.Show($"Desculpa nao podemos gravar recibo, erro ocorrido: {res}");
               return false;
           }
        }

        public decimal Codsec { get; set; }
        public DataTable PrintDt { get; set; }
        public DataTable ContasDt { get; set; }

        public event Action Beginvoke;

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void gridUi1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btD.PerformClick();
        }
    }
}
