using System;
using System.Data;
using System.Linq;
using DMZ.BL.Classes;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using DMZ.UI.Reports;

namespace DMZ.UI.UI
{
    public partial class FrmExtprod : Basic.FrmClasse2
    {
        public FrmExtprod()
        {
            InitializeComponent();
        }

        public string Ststamp { get; set; }
        public decimal Codarm { get; set; }
        private DataTable dt;
        private void FrmExtprod_Load(object sender, EventArgs e)
        {
           // gridTool1.BindCombox();
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            string chkArmazem;
            DateTime dData1, dData2;
            chkArmazem = Codarm.Equals(0) ? "" : $" and codarm= {Codarm}";
            dData1 = dtpData1.Value;
            dData2 = dtpData2.Value;
            if (chkArmazem.IsNullOrEmpty())
            {
                chkArmazem = " and ordem <> 4";
            }
            else
            {
                chkArmazem = $" {chkArmazem} and ordem <> 4";
            }
            if (cbSaldoanterior.cb1.Checked)
            {
                chkArmazem = $" {chkArmazem} and ordem <> 1";
            }

            dt = GenBl.ExtratoProduto(dData1.ToSqlDate(), dData2.ToSqlDate(), chkArmazem, Ststamp);
            if (dt.HasRows())
            {
                var dr = dt.NewRow();
                dr["data"] = "Total";
                var entrada = dt.Sum("entrada");
                var saida = dt.Sum("saida");
                var saldo = entrada - saida;
                dr["entrada"] = entrada;
                dr["saida"] = saida;
                dr["saldo"] = saldo;
                dt.Rows.InsertAt(dr, dt.Rows.Count);
                gridUi1.SetDataSource(dt);
            }
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var dData1 = dtpData1.Value.ToShortDateString();
            var dData2 = dtpData2.Value.ToShortDateString();
            dt=gridUi1.DataSource as DataTable;
            var xml = SQL.GetXmlReport("ExtProduto");
            DS ds = new DS();
            var ret = Imprimir.FillData(null, dt, null, ds.ExtProd, null);
            Imprimir.CallForm(ret.dtPrint, ret.fp, CLocalStamp, false, label1.Text, xml, "ExtProduto", "ExtProd", this, "", true, ds, $"De: {dData1} até: {dData2}", "");
        }

        private void btnArm_Click(object sender, EventArgs e)
        {
            var formparent = FindForm();
            var tmpFound = SQL.GetGen2DT("Select Descricao = 'Todos Armazens', 0 as codigo union all Select descricao, codigo from armazem");
            var qr = new Querry
            {
                radGridView1 = { DataSource = null, AutoGenerateColumns = false },
                Campo1 = "codigo",
                Campo2 = "descricao",
                Campo3 = "",
                PControl2 = PassData,
                ShowStk = false,
                Width1 = 90,
                Origem = true,
                Width2 = 270,
                Caption1 = "Código",
                Caption2 = "Descrição"
            };
            qr.radGridView1.DataSource = tmpFound;
            qr.labelX1.Text = tmpFound.Rows.Count + @" registos encontados";
            qr.ShowForm(formparent,true);
        }

        public void PassData(DataRow dr)
        {
            if (dr == null) return;
            Codarm = dr[1].ToDecimal();
            tbArmazem.Text = dr[0].ToString();
        }
    }
}
