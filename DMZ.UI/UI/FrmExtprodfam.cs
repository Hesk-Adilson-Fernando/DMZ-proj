using System;
using System.Data;
using DMZ.BL.Classes;
using DMZ.UI.Basic;
using DMZ.UI.Generic;

namespace DMZ.UI.UI
{
    public partial class FrmExtprodfam : FrmClasse2
    {
        public FrmExtprodfam()
        {
            InitializeComponent();
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            string fam;
            DateTime dData1, dData2;
            dData1 = dtpData1.Value;
            dData2 = dtpData2.Value;
            var dt = GenBl.ExtratoProdutoFam(dData1, dData2, tbFam.Text.Trim());
            //if (dt?.Rows.Count > 0)
            //{
            //    var dr = dt.NewRow();
            //    foreach (var r in dt.AsEnumerable())
            //    {
            //        if (r == null) continue;
            //        if (Convert.ToInt32(r["ordem"]) != 1) continue;
            //        if (r["entrada"].ToDecimal() != 0 || r["saida"].ToDecimal() != 0) continue;
            //        dr = r;
            //        break;
            //    }
            //    if (dr.RowState != DataRowState.Detached) dt.Rows.Remove(dr);
            //}
            gridUi1.DataSource = null;
            gridUi1.AutoGenerateColumns = false;
            gridUi1.DataSource = dt;
        }

        public string Codarm { get; set; }

        private void btnArm_Click(object sender, EventArgs e)
        {
            var formparent = FindForm();
            var tmpFound = SQL.GetGen2DT("Select Descricao = 'Todas Famílias', 0 as codigo union all Select descricao, codigo from Familia");
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

        private void PassData(DataRow dr)
        {
            if (dr == null) return;
           // Codarm = dr[1].ToDecimal();
            tbFam.Text = dr[0].ToString();
        }
    }
}
