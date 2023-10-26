using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.UI.Classes;
using DMZ.UI.Generic;
using DMZ.UI.Reports;

namespace DMZ.UI.UI
{
    public partial class FrmCc : Basic.FrmClasse2
    {
        public FrmCc()
        {
            InitializeComponent();
        }

        public string Tabela { get; set; }
        public bool Cl { get; set; }
        public string Tipo { get; set; }
        public DataTable dt { get; set; }
        public string Clstamp { get; set; }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            DateTime dData1, dData2;
            dData1 = dtpData1.Value;
            dData2 = dtpData2.Value;
            string condicao ="";
            if (!string.IsNullOrEmpty(Moeda.tb1.Text.Trim()))
            {
                condicao=$" moeda ='{Moeda.tb1.Text.Trim()}'";            
            }
            if (string.IsNullOrEmpty(condicao))
            {
                condicao=$" Clstamp ='{Clstamp}' ";  
            }
            else
            {
                condicao=$"{condicao} and Clstamp ='{Clstamp}' ";  
            }
            condicao=$"{condicao} and {Helper.EntreDatas(dData1,dData2)}";
            if (!string.IsNullOrEmpty(condicao))
            {
                condicao= $" where {condicao} ";
            }
            var str =$"select * from ClExtrato() {condicao} order by documento,nrdoc";
            dt = SQL.GetGen2DT(str);//EntBl.GetExtrato(txtNumero.Text.Trim(), dData1, dData2,,"cc","rcll");
            gridUi1.DataSource = null;
            gridUi1.AutoGenerateColumns = false;
            gridUi1.DataSource = dt;
            if (!(dt?.Rows.Count > 0)) return;
            var deb = dt.AsEnumerable().Sum(x => x.Field<decimal?>("debito")).ToString();
            tbDebito.Text = deb.SetMask();
            var cre = dt.AsEnumerable().Sum(x => x.Field<decimal?>("credito")).ToString();
            tbCredito.Text = cre.SetMask();
            tbSaldo.Text = (cre.ToDecimal() - deb.ToDecimal()).ToString().SetMask();
        }

        private void FrmCc_Load(object sender, EventArgs e)
        {
            panel1.Visible = Cl;
            EditMode=true;
            dtpData1.Value=Pbl.PrevMonthData();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //var f = new FrmReport
            //{
            //    Origem = "RLT",
            //    Dt = dt,
            //    TabelaName = "DMZ",
            //    ReportName = "ExtratoCL",
            //    Filtro =$"{Tipo}: {txtNome.Text} \r\n Período: {dtpData1.Value.Date.ToShortDateString()} -{dtpData2.Value.Date.ToShortDateString()}".ToUpper(),
            //    CTituloRelatorio = $"Extrato do {Tipo}".ToUpper()
            //};
            //f.ShowForm(this);

            DS ds = new DS();
            var ret = Imprimir.FillData(null, dt, null, ds.DMZ, null);
            Imprimir.CallForm(ret.dtPrint, ret.fp, CLocalStamp, false, label1.Text, "", "ExtratoCL", "RLT", this, "", false, ds, $"{Tipo}: {txtNome.Text} \r\n Período: {dtpData1.Value.Date.ToShortDateString()} -{dtpData2.Value.Date.ToShortDateString()}".ToUpper(), $"Extrato do {Tipo}".ToUpper());
        }

        private void gridUi1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUi1 == null || !gridUi1.CurrentCell.OwningColumn.Name.Equals("origem")) return;
            if (gridUi1.CurrentRow == null) return;
            var ccstamp = gridUi1.CurrentRow.Cells["ccstamp"].Value.ToString();
            if (string.IsNullOrEmpty(ccstamp)) return;
            if (gridUi1.CurrentRow.Cells["destino"].Value !=null)
            {
                if (gridUi1.CurrentRow.Cells["destino"].Value.ToString().Trim().Equals("FT"))
                {
                    CallFactura(ccstamp);
                }
                else
                {
                    var dt = SQL.GetGenDT("rcl", $" where rclstamp='{ccstamp}'", "*");
                    var rcl = new FrmRcl();
                    rcl.UpdateObjects(dt);
                    rcl.Procurou = true;
                    rcl.ShowForm(this);
                    rcl.PreencheCampos(dt,0);  
                }
            }
            else
            {
                CallFactura(ccstamp);
            }
        }

        private void CallFactura(string ccstamp)
        {
            var dt = SQL.GetGenDT("fact", $" where factstamp='{ccstamp}'", "*");
            var fact = new FrmFt();
            fact.UpdateObjects(dt);
            fact.Procurou = true;
            fact.ShowForm(this);
            fact.PreencheCampos(dt,0);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var dt = gridUi1.DataSource as DataTable;
            dt = dt.DefaultView.ToTable(false, "documento", "nrdoc","credito","debito","saldo");
            var bite = Helper.Exportpdf(dt,"ContaCorrente",label1.Text);
            var xx=Helper.ConvertByteToPdf(bite);
          //  Email.SendEmail(xx);
            MsBox.Show("Executado com suscesso");
           // Helper.Apaga();
        }
    }
}
