using System;
using System.Data;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using DMZ.UI.Reports;

namespace DMZ.UI.UI
{
    public partial class FrmPosPrint : Basic.FrmClasse2
    {
        public FrmPosPrint()
        {
            InitializeComponent();
        }

        private void FrmPosPrint_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = Pbl.SqlDate;
            BindGrid();
        }

        public DataTable Factdt { get; set; }
        private void BindGrid()
        {
            var str = $"select numero,nome,total,Factstamp from fact where convert(date,data)='{dateTimePicker1.Value.ToSqlDate()}'";
            Factdt = SQL.GetGen2DT(str);
            gridProdutos.SetDataSource(Factdt);
        }

        private void gridProdutos_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (!gridProdutos.CurrentCell.OwningColumn.Name.Equals("print2")) return;
            if (gridProdutos.CurrentRow == null) return;
            var stamp = gridProdutos.CurrentRow.Cells["factstamp"].Value.ToString();
            if (string.IsNullOrEmpty(stamp)) return;
            var ft = SQL.GetRowToEnt<Fact>($"Factstamp ='{stamp}'"); //EF.GetEnt<Fact>(x => x.Factstamp.Trim().Equals(stamp));
            if (ft != null)
            {
                //var printDt = GenBl.PrintPos("", 0);
                var dt = SQL.GetGen2DT($"select * from factl where factstamp='{stamp.Trim()}'");
                if (dt?.Rows.Count > 0)
                {
                    //ReportHelper.PrintReport(ft.Factstamp,"",Pbl.Param.Printfile, "fact",0,true);
                }
                else
                {
                    MsBox.Show("Desculpe o documento não tem linhas!");
                }
            }
            else
            {
                MsBox.Show("Deve indicar o documento á imprimir!");
            }
        }

        private void panel15_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            var condicao = cbNumero.cb1.Checked ? $"numero = {textBox2.Text.ToDecimal()}" : $"nome like '%{textBox2.Text.Trim()}%'";
            try
            {
                var dtSearched = Factdt.Select(condicao).CopyToDataTable();
                gridProdutos.DataSource = null;
                gridProdutos.DataSource = dtSearched;
            }
            catch (Exception)
            {
                gridProdutos.DataSource = null;
                gridProdutos.DataSource = Factdt;
            }
        }
    }
}
