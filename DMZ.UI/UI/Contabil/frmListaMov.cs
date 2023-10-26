using System;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.UI.Basic;

namespace DMZ.UI.UI.Contabil
{
    public partial class frmListaMov : FrmClasse2
    {
        public frmListaMov()
        {
            InitializeComponent();
        }

        private void frmListaMov_Load(object sender, EventArgs e)
        {
            PopulateCombo();
            processar();
        }

        public void processar()
        {
            string condicao = string.Empty;

            if (!tbConta.Text.Equals(string.Empty))
                condicao = $" and ltrim(rtrim(conta)) like '{tbConta.Text.Trim()}%'";

            if (cmbMeses.SelectedIndex > -1 && cmbMeses.Enabled)
                if (!cmbMeses.SelectedValue.ToString().Contains("System.Data.DataRowView"))
                    condicao = condicao + $" and lcont.mes={cmbMeses.SelectedValue}";


            var dtMov = SQL.GetGenDT($@"select *,sum(deb - cre) over(PARTITION BY conta  order by dia, mes, data rows unbounded preceding) as saldo
                        from(
                        select conta, diario = lcont.dino, lcont.docno, nrlanc = dilno, nrdoc = adoc, 
                        descr = ltrim(descricao), deb, cre, lcont.data, lcont.dia, lcont.mes, ordem, lcont.dino
                        from  lcont inner join ml on lcont.Lcontstamp = ml.Lcontstamp where lcont.ano = {Pbl.AnoContabil()} {condicao} 
                        )tmp1 order by mes, dia, data, dino, ordem");

            GridMov.DataSource = null;
            GridMov.AutoGenerateColumns = false;
            GridMov.DataSource = dtMov;
        }

        private void tbConta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString().Equals("Return")) //Enter key
                processar();
        }

        private void chbMese_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMeses.Checked)
            {
                cmbMeses.SelectedIndex = 0;
                cmbMeses.Enabled = true;
            }

            else
            {
                cmbMeses.SelectedIndex = -1;
                cmbMeses.Enabled = false;
            }

            processar();
        }

        private void cmbMeses_SelectedIndexChanged(object sender, EventArgs e)
        {
            processar();
        }

        private void PopulateCombo()
        {
            var dtMeses = SQL.GetGenDT("mescont", "order by convert(numeric,codigo)", "codigo,nomemes,mes");

            cmbMeses.DataSource = dtMeses;
            cmbMeses.ValueMember = "codigo";
            cmbMeses.DisplayMember = "mes";

            cmbMeses.SelectedIndex = -1;
            cmbMeses.Enabled = false;
        }

        private void tbConta_TextChanged(object sender, EventArgs e)
        {
            processar();
        }
    }
}
