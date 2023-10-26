using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using DMZ.UI.Reports;


namespace DMZ.UI.UI
{
    public partial class FrmAlterapreacos : Basic.FrmClasse2
    {
        public FrmAlterapreacos()
        {
            InitializeComponent();
        }

        private DataTable Dt { get; set; }
        public bool Origem { get; set; }
        private void FrmAlterapreacos_Load(object sender, EventArgs e)
        {
            //cbFamilia.SetDataSource("familia");
            //cbSubFamilia.SetDataSource("SubFam");
            //cbCCusto.SetCCustoDS();
            rbPerc.Checked = true;
            rbNormal.Checked = true;
            rbPv.Checked = true;
            dmzProcura1.Visible = Origem;
        }

        private void btnProcura_Click(object sender, EventArgs e)
        {
            var cond = "";
            if (string.IsNullOrEmpty(cbCCusto.tb1.Text))
            {
                MsBox.Show("Deve indicar o Centro de Custo!");
                return;
            }
            cond = $" and StPrecos.CCusto='{cbCCusto.tb1.Text.Trim()}'";
            if (!string.IsNullOrEmpty(cbFamília.tb1.Text))
            {
                cond =cond+ $" and Familia='{cbFamília.tb1.Text.Trim()}'";  
            }
            if (!string.IsNullOrEmpty(Subfamília.tb1.Text))
            {
                cond =cond+ $" and Subfamilia='{Subfamília.tb1.Text.Trim()}'";  
            }
            if (!string.IsNullOrEmpty(tbArtigo.Text))
            {
                if (cbRef.cb1.Checked)
                {
                    cond =cond+ $" and st.referenc like '%{tbArtigo.Text.Trim()}%'";   
                }
                else
                {
                    cond =cond+ $" and st.descricao like '%{tbArtigo.Text.Trim()}%'";      
                }
                 
            }

            var qry = $@"select Referenc,Descricao,Unidade,StPrecos.Preco,cast(0 as decimal) novopreco,st.Ststamp,StPrecos.CCusto,StPrecos.CodCCu,StPrecos.PrecoCompra from st 
            left join StPrecos on st.Ststamp=StPrecos.Ststamp where Servico=0 {cond}";
            Dt = SQL.GetGen2DT(qry);
            if (!cbIndividual.cb1.Checked)
            {
                gridUi1.SetDataSource(Dt);
            }
            else
            {
                var dt = gridUi1.DataSource as DataTable;
                if (dt?.Rows.Count>0)
                {
                    foreach (DataRow dr in Dt.Rows) {
                        if (dr!=null)
                            dt.Rows.Add(dr.ItemArray);
                    }
                }
                else
                {
                    gridUi1.SetDataSource(Dt);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (rbPerc.Checked)
            {

                foreach (DataGridViewRow r in gridUi1.Rows)
                {
                    if (r == null) continue;
                    var preco = r.Cells["Preco"].Value.ToDecimal();
                    r.Cells["novopreco"].Value = tbSinal.Text.Trim() == "+"
                        ? preco + preco * tbPerc.Text.ToDecimal() / 100
                        : preco - preco * tbPerc.Text.ToDecimal() / 100;
                }
            }
            if (rbVal.Checked)
            {
                foreach (DataGridViewRow r in gridUi1.Rows)
                {
                    if (r == null) continue;
                    var preco = r.Cells["Preco"].Value.ToDecimal();
                    r.Cells["novopreco"].Value = tbSinal2.Text.Trim() == "+"
                        ? preco + tbValor.Text.ToDecimal()
                        : preco - tbValor.Text.ToDecimal();
                }
            }
            if (rbValUnico.Checked)
            {
                foreach (DataGridViewRow r in gridUi1.Rows)
                {
                    if (r!=null)
                    {
                        r.Cells["novopreco"].Value = tbValorUnico.Text.ToDecimal();
                    }
                }
            }
        }

        private void gridUi1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUi1.CurrentCell.OwningColumn.Name=="del")
            {
                
                gridUi1.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void rbVal_Click(object sender, EventArgs e)
        {
            tbPerc.Text = "0";
            tbValorUnico.Text="0";
            cbConta.Text = "";
            comboBox1.Text = "PVA";
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            if (!Origem)
            {
                Iniciar();
            }
            else
            {
                if (string.IsNullOrEmpty(dmzProcura1.tb1.Text))
                {
                    MsBox.Show("Deve indicar o Centro de custo destino!");  
                }
                else
                {
                    Iniciar();  
                }
            }
        }

        private void Iniciar()
        {
            var dt = gridUi1.DataSource as DataTable;
            Helper.DoProgressProcess(dt, RecebeDados);
        }

        private void RecebeDados(DataRow dr,bool fim)
        {
            if (dr == null) return;
            if (dr.RowState== DataRowState.Deleted) return;
            if (!Origem)
            {
                var scrpt = $@"update stprecos set preco ={dr["novopreco"].ToDecimal()} 
                            where ststamp = '{dr["ststamp"].ToString().Trim()}' and CCusto='{dr["CCusto"].ToString().Trim()}'";
                SQL.SqlCmd(scrpt);
            }
            else
            {
                var str = $@"INSERT INTO [dbo].[StPrecos]
                                   ([StPrecostamp],[Ststamp],[CCusto],[CodCCu],[Ivainc],[padrao],[Preco],[PrecoCompra],[Perc])
                             VALUES
                                   ('{Pbl.Stamp()}','{dr["ststamp"].ToString().Trim()}','{dmzProcura1.tb1.Text}','{dmzProcura1.Text2}',1,0,{dr["novopreco"].ToDecimal()},{dr["PrecoCompra"].ToDecimal()},0)";
             
                SQL.SqlCmd(str);
            }
        }

        private void dmzProcura1_ProcuraTBTextChangedEvent()
        {
            gridUi1.Columns["novopreco"].HeaderText = "P.V. de "+dmzProcura1.tb1.Text;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var _dt= gridUi1.DataSource as DataTable;
            if (!(_dt?.Rows.Count > 0)) return;
            var f = new FrmGenreport {Gendt = _dt, Titulo = label1.Text, Filtro = ""};
            f.ShowForm(this);
        }
    }
}
