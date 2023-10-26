using DMZ.BL.Classes;
using DMZ.Model.Model;
using System;
using System.Data;
using DMZ.UI.Classes;
using DMZ.UI.Generic;
using DMZ.UI.Reports;

namespace DMZ.UI.UI
{
    public partial class FrmArmazem : Basic.FrmClasse
    {
        public FrmArmazem()
        {
            InitializeComponent();
        }
        private Armazem _arm;
        private DataTable _armazeml;
        private void FrmArmazem_Load(object sender, EventArgs e)
        {
            Campo1 = "codigo";
            Campo2 = "descricao";
            Ctabela = "Armazem";
            _armazeml = new DataTable();
            var referenc = new DataColumn("Ref") {DataType = typeof(string)};
            _armazeml.Columns.Add(referenc);

            var descricao = new DataColumn("Descricao") {DataType = typeof(string)};
            _armazeml.Columns.Add(descricao);
            var stock = new DataColumn("Stock") {DataType = typeof(string)};
            _armazeml.Columns.Add(stock);
        }
        public override void DefaultValues()
        {
            _arm = DoAddline<Armazem>();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(_arm);
            EF.Save(_arm);
        }

        public override bool BeforeSave()
        {
            if (!Procurou)
            {
                var num = SQL.CheckExist($"select Codigo from Armazem where codigo ={tbNumero.tb1.Text.ToDecimal()}");
                if (num)
                {
                    MsBox.Show("Já existe outro Armazem, com mesmo número! ");
                    return false;
                }
            }
            return base.BeforeSave();
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            _arm = FillControls(_arm, dt, i);
            _armazeml = Helper.GetArmazenStock($"where Armazemstamp='{_arm.Armazemstamp}'");
            gridPreco.DataSource = null;
            gridPreco.DataSource = _armazeml;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            SetPrint(_armazeml, $"ARMAZEM: {tbDefault2.tb1.Text} ");
        }

        private void SetPrint(DataTable dt, string filtro)
        {
            var x = SQL.GetField("select Xmlstring from Rdlcxml where Rdlcname='Armazem'").ToString();
            if (!x.IsNullOrEmpty())
            {
                //var f = new FrmReport
                //{
                //    Origem = "RLT",
                //    Dt = dt,
                //    TabelaName = "DMZ",
                //    ReportName = "",
                //    Filtro =filtro,
                //    CTituloRelatorio = "LISTA DE PRODUTOS COM STOCK"
                //};
                //f.RDLCXML = x;
                //f.ShowForm(this);
                DS ds = new DS();
                var ret = Imprimir.FillData(null, dt, null, ds.DMZ, null);
                Imprimir.CallForm(ret.dtPrint, ret.fp, CLocalStamp, false, label1.Text, "", "ExtractoPgc", "RLT", this, x, false, ds, filtro, "LISTA DE PRODUTOS COM STOCK");
            }
            else
            {
                MsBox.Show("Não foi encontrado o XML do relatório para impressão, contacte o administrador do sistema");
            }
        }

        private void btnMenuLateral_Click(object sender, EventArgs e)
        {
            dmzContextMenuStrip1.ShowMenuStrip(btnMenuLateral);
        }

        private void listagemDeProdutosComStockPorArmazemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var _armazeml = Helper.GetArmazenStock("");
            if (_armazeml == null) return;
            SetPrint(_armazeml, "TODOS ARMAZENS");
            DS ds = new DS();
            var ret = Imprimir.FillData(null, _armazeml, null, ds.DMZ, null);
            Imprimir.CallForm(ret.dtPrint, ret.fp, CLocalStamp, false, label1.Text, "", "Armazem", "RLT", this, "", false, ds, "TODOS ARMAZENS", "LISTA DE PRODUTOS");
        }
    }
}
