using System;
using System.Data;
using System.Linq;
using DMZ.BL.Classes;
using DMZ.UI.Generic;
using DMZ.UI.Reports;

namespace DMZ.UI.UI
{
    public partial class FrmProdVend : Basic.FrmClasse2
    {
        public FrmProdVend()
        {
            InitializeComponent();
        }

        public string Origem { get; set; }
        public string Titulo { get; set; }

        private void FrmProdVend_Load(object sender, EventArgs e)
        {
            //cbArmazem.SetDataSource("Armazem");
            //cbFamilia.SetDataSource("Familia");
            label1.Text = Titulo;
        }

        private DataTable _dt;
        private string filtro;

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            DateTime dData1, dData2;
            dData1 = dtpData1.Value;
            dData2 = dtpData2.Value;
            var cond = "";
            filtro = "";
            filtro = filtro + $"Período entre: {dData1.ToShortDateString()} - {dData2.ToShortDateString()}";
            if (!string.IsNullOrEmpty(cbArmazem.tb1.Text))
            {
                cond = $"and armazem={cbArmazem.Text2}";
                filtro = filtro + $"\r\nArmazem: {cbArmazem.tb1.Text}";
            }
            if(!string.IsNullOrEmpty(cbCCusto.tb1.Text))
            {
                cond =cond+ $"and ccusto={cbCCusto.tb1.Text.Trim()}"; 
                filtro = filtro + $"\r\n Centro de custo: {cbCCusto.tb1.Text}";
            }

           _dt = EntBl.GetProdVend( dData1.ToSqlDate(), dData2.ToSqlDate(),cond,Origem);
           if (_dt?.Rows.Count>0)
           {
               tbTotal.Text = _dt.AsEnumerable().Sum(x => x.Field<decimal>("Total")).ToString().SetMask();
           }
            gridUi1.DataSource = null;
            gridUi1.AutoGenerateColumns = false;
            gridUi1.DataSource = _dt;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //var f = new FrmReport
            //{
            //    Origem = "RLT",
            //    Dt = _dt,
            //    TabelaName = "DMZ",
            //    ReportName = "Armazem",
            //    CTituloRelatorio = "LISTA DE PRODUTOS VENDIDOS",
            //    Filtro = string.IsNullOrEmpty(cbArmazem.tb1.Text)? "TODOS ARMAZENS" : $"ARMAZEM: {cbArmazem.tb1.Text}"
            //};
            //f.ShowForm(this);

            if (!(_dt?.Rows.Count > 0)) return;
            var f = new FrmGenreport {Gendt = _dt, Titulo = label1.Text, Filtro = filtro};
            f.ShowForm(this);
        }

        private void cbDetalhado_CheckedChangeds()
        {
            Origem = "VENDA";
            cbSimplificado.Update(false);
            cbSimplificadoarm.Update(false);
            gridUi1.Columns["Preco"].Visible = true;
            gridUi1.Columns["Cliente"].Visible = true;
            gridUi1.Columns["Armazem"].Visible = true;
            gridUi1.Columns["Total"].Visible = true;
        }

        private void cbSimplificado_CheckedChangeds()
        {
            Origem = "VENDASIMP";
            cbDetalhado.Update(false);
            cbSimplificadoarm.Update(false);
            SetFalse();
            gridUi1.Columns["Armazem"].Visible = false;
        }

        private void cbSimplificadoarm_CheckedChangeds()
        {
            Origem = "VENDASIMPARM";
            cbDetalhado.Update(false);
            cbSimplificado.Update(false);
            gridUi1.Columns["Armazem"].Visible = true;
            SetFalse();
        }

        private void SetFalse()
        {
            gridUi1.Columns["Preco"].Visible = false;
            gridUi1.Columns["Cliente"].Visible = false;
            gridUi1.Columns["Total"].Visible = false;
            gridUi1.Columns["Data"].Visible = false;
            gridUi1.Columns["Documento"].Visible = false;
        }
    }
}
