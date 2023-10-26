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
    public partial class FrmCcCl : FrmClasse2
    {
        public FrmCcCl()
        {
            InitializeComponent();
        }

        public DataTable Tabela { get; set; }

        private void FrmCcCl_Load(object sender, EventArgs e)
        {
            EditMode=true;
            Processar();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //var f = new FrmReport
            //{
            //    Origem = "RLT",
            //    Dt = Tabela,
            //    TabelaName = "DMZ",
            //    ReportName = "CcCL",
            //    Filtro =Filtro,
            //    CTituloRelatorio = label1.Text.ToUpper()
            //};
            //f.ShowForm(this);
            DS ds = new DS();
            var ret = Imprimir.FillData(null, Tabela, null, ds.DMZ, null);
            Imprimir.CallForm(ret.dtPrint, ret.fp, CLocalStamp, false, label1.Text, "", "CcCL", "RLT", this, "", false, ds, Filtro, label1.Text.ToUpper());
        }

        public string Filtro { get; set; }
        public string Siglas { get; set; }
        public string Clstamp { get; internal set; }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            Processar();
        }

        private void Processar()
        {
            if (!string.IsNullOrEmpty(tbNome.Text))
            {
                var condicao="";
                if (!Moeda.tb1.Text.Trim().Equals(Pbl.MoedaBase.Trim()))
                {
                    condicao=$"and moeda='{Moeda.tb1.Text.Trim()}'";
                }
                Tabela = SQL.GetGen2DT($"select * from clccf ");
                   // EntBl.GetExtrato(tbNumero.Text,Moeda.tb1.Text.Trim(),condicao,true,Siglas);
                if (Tabela?.Rows.Count>0)
                {
                    var deb = Tabela.AsEnumerable().Sum(x => x.Field<decimal?>("debito")).ToString();
                    var cre = Tabela.AsEnumerable().Sum(x => x.Field<decimal?>("credito")).ToString();
                    var pend = Tabela.AsEnumerable().Sum(x => x.Field<decimal?>("pendente")).ToString();
                    tbTOTDOCS.Text = deb.SetMask();
                    tbTOTPAGO.Text = cre.SetMask();
                    tbPENDENTE.Text = pend.SetMask();
                    gridUi1.DataSource=null;
                    gridUi1.AutoGenerateColumns = false;
                    gridUi1.DataSource =Tabela;
                }
                else
                {
                    MsBox.Show("O Cliente não tem movimentos");
                }
            }
            else
            {
                MsBox.Show("Deve indicar o cliente!..");
            }
        }
    }
}
