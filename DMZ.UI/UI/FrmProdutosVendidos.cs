using System;
using System.Data;
using System.Linq;
using DMZ.BL.Classes;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Generic;
using DMZ.UI.Reports;

namespace DMZ.UI.UI
{
    public partial class FrmProdutosVendidos : FrmClasse2
    {
        public FrmProdutosVendidos()
        {
            InitializeComponent();
        }

        public DataTable dt { get; set; }
        private void FrmProdutosVendidos_Load(object sender, EventArgs e)
        {

        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            DateTime dData1, dData2;
            dData1 = dtpData1.Value;
            dData2 = dtpData2.Value;
            dt = EntBl.GetProdutosVendidos(txtNumero.Text.ToDecimal(), dData1, dData2);
            gridUi1.DataSource = null;
            gridUi1.AutoGenerateColumns = false;
            gridUi1.DataSource = dt;
            if (!(dt?.Rows.Count > 0)) return;
            var deb= dt.AsEnumerable().Sum(x => x.Field<decimal?>("Subtotal")).ToString();
            tbDebito.Text = deb.SetMask();
            var cre= dt.AsEnumerable().Sum(x => x.Field<decimal?>("Total")).ToString();
            tbCredito.Text = cre.SetMask();
            var desconto= dt.AsEnumerable().Sum(x => x.Field<decimal?>("desconto")).ToString();
            tbSaldo.Text = desconto.SetMask();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //var f = new FrmReport
            //{
            //    Origem = "RLT",
            //    Dt = dt,
            //    TabelaName = "DMZ",
            //    ReportName = "ExtratoProdVendido",
            //    Filtro =$"Cliente: {txtNome.Text} \r\n Período: {dtpData1.Value.Date.ToShortDateString()} -{dtpData2.Value.Date.ToShortDateString()}",
            //    CTituloRelatorio = "Extrato de produtos vendidos ao Cliente"
            //};
            //f.ShowForm(this);

            DS ds = new DS();
            var ret = Imprimir.FillData(null, dt, null, ds.DMZ, null);
            Imprimir.CallForm(ret.dtPrint, ret.fp, CLocalStamp, false, label1.Text, "", "ExtratoProdVendido", "RLT", this,"", false, ds, $"Cliente: {txtNome.Text} \r\n Período: {dtpData1.Value.Date.ToShortDateString()} -{dtpData2.Value.Date.ToShortDateString()}", "Extrato de produtos vendidos ao Cliente");
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpData1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpData2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void gridUi1_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }
    }
}
