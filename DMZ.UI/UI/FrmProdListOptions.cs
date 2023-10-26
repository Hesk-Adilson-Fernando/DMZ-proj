using System;
using System.Data;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.UI.Basic;
using DMZ.UI.Generic;
using DMZ.UI.Reports;

namespace DMZ.UI.UI
{
    public partial class FrmProdListOptions : FrmClasse2
    {
        public FrmProdListOptions()
        {
            InitializeComponent();
        }
        
        private void FrmProdListOptions_Load(object sender, EventArgs e)
        {
            var dt = new DataTable();
            var dc = new DataColumn("nome", typeof(string));
            var dc1 = new DataColumn("sel", typeof(bool));
            dt.Columns.Add(dc);
            dt.Columns.Add(dc1);
            var stdt=SQL.GetGen2DT("select * from st where 1=1");
            foreach (DataColumn col in stdt.Columns)
            {
                if (col == null) continue;
                var r = dt.NewRow();
                r["nome"] = col.ColumnName;
                dt.Rows.Add(r);
            }
            gridPreco.DataSource = null;
            gridPreco.AutoGenerateColumns = false;
            gridPreco.DataSource = dt;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var filtro = string.Empty;
            if (!string.IsNullOrEmpty(Familia.tb1.Text))
            {
                filtro = $" Familia ='{Familia.tb1.Text.Trim()}' ";
            }
            if (!string.IsNullOrEmpty(Subfamilia.tb1.Text))
            {
                if (string.IsNullOrEmpty(filtro))
                {
                    filtro = $" Subfamilia ='{Subfamilia.tb1.Text.Trim()}' ";  
                }
                else
                {
                    filtro += $" and Subfamilia ='{Subfamilia.tb1.Text.Trim()}' ";
                }
            }
            if (!string.IsNullOrEmpty(Fabricante.tb1.Text))
            {
                if (string.IsNullOrEmpty(filtro))
                {
                    filtro = $" Fabricante ='{Fabricante.tb1.Text.Trim()}' ";  
                }
                else
                {
                    filtro += $" and Fabricante ='{Fabricante.tb1.Text.Trim()}' ";
                }
            }
            if (!string.IsNullOrEmpty(Marca.tb1.Text))
            {
                if (string.IsNullOrEmpty(filtro))
                {
                    filtro = $" Marca ='{Marca.tb1.Text.Trim()}' ";  
                }
                else
                {
                    filtro += $"and Marca ='{Marca.tb1.Text.Trim()}' ";
                }
            }

            if (!string.IsNullOrEmpty(filtro))
            {
                filtro = $" where {filtro} and servico =0";
            }
            var qry = string.Empty;
            if (cbTodas.cb1.Checked)
            {
                qry = $"Select * from st {filtro}";
            }
            else
            {
                var colunas = string.Empty;
                foreach (DataGridViewRow row in gridPreco.Rows)
                {
                    if (row == null) continue;
                    if (!row.Cells["sel"].Value.Equals(true)) continue;
                    if (string.IsNullOrEmpty(colunas))
                    {
                        colunas += $"{row.Cells["nome"].Value.ToString().Trim()}";
                    }
                    else
                    {
                        colunas += $",{row.Cells["nome"].Value.ToString().Trim()}"; 
                    }
                }
                qry = string.IsNullOrEmpty(colunas) ? $"Select * from st {filtro}" : $"Select {colunas} from st {filtro}";
                    
            }
            var dt = SQL.GetGen2DT(qry);
            var f = new FrmGenreport {Gendt = dt, Filtro = filtro.Replace("and","e").Replace("where","").Replace("and servico =0",""), Titulo = "Listagem de Produtos "};
            f.ShowForm(this);
        }
    }
}
