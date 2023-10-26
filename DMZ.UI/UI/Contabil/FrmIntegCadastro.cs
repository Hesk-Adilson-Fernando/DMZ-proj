using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Generic;

namespace DMZ.UI.UI.Contabil
{
    public partial class FrmIntegCadastro : FrmClasse2
    {
        private decimal _ano=2000;
        private DataTable dtClct;
        private DataTable dtPgc;
        public FrmIntegCadastro()
        {
            InitializeComponent();
        }
        public string Origem  { get; set; }
        public string CtTabela  { get; set; }
        public string Tabela  { get; set; }
        public string Contacc  { get; set; }
        public string Campos { get; set; }
        private void frmIntegCl_Load(object sender, EventArgs e)
        {
            dtClct = SQL.Initialize(CtTabela);
            dtPgc = SQL.Initialize("pgc");
            tbgrupo.SqlComandText = $@"select conta, descricao from pgc where ano =(select ano from param) 
            and conta in ({Condicao}) order by convert(decimal,conta)";
            tbSubGrupo.Visible = MostraSubgrupo;
        }

        public bool MostraSubgrupo { get; set; }

        public string Condicao { get; set; }
        public string OrderBy { get; set; } = "no";
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var dt = dataGridView1.DataSource as DataTable;
            if (dt == null) return;
            if (dt.AsEnumerable().Any(x => x.Field<bool>("ok").Equals(true)))
            {
                var msg = MsBox.Show($"Estimado(a), Deseja criar contas selecionadas?\r\nO sistema vai criá-los no grupo: \r\n{tbgrupo.tb1.Text} ", DResult.YesNo);
                if (msg.DialogResult != DialogResult.Yes) return;
                var dt2 = dt.AsEnumerable().Where(x => x.Field<bool>("ok").Equals(true)).CopyToDataTable();
                foreach (var dr in dt2.AsEnumerable())
                {
                    if (!string.IsNullOrEmpty(tbgrupo.tb1.Text))
                    {
                        if (!string.IsNullOrEmpty(tbSubGrupo.tb1.Text))
                        {
                            Integracao.CriaConta(dr, tbSubGrupo.Text2, dtPgc, dtClct, tbSubGrupo.tb1.Text, Tabela, Contacc, CtTabela);
                        }
                        else
                        {
                            Integracao.CriaConta(dr, tbgrupo.Text2, dtPgc, dtClct, tbgrupo.tb1.Text, Tabela, Contacc, CtTabela);
                        }
                    }
                    else
                    {
                        MsBox.Show("O Grupo não pode ser vazio.");
                    }
                    //Integracao.CriaConta(dr,tbgrupo.Text2,dtPgc,dtClct,tbgrupo.tb1.Text, Tabela,Contacc,CtTabela);
                }
                Integracao.Gravar(dtPgc,dtClct,CtTabela);
                Integracao.BindGrid(dataGridView1,tbgrupo.Text2.Trim(),Tabela,Campos,OrderBy);
            }            
            else
            {
                MsBox.Show("Seleciona os nomes a Integrar");
            }
        }
        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbgrupo.tb1.Text))
            {
                //BindGrid();
                if (!string.IsNullOrEmpty(tbSubGrupo.tb1.Text))
                {
                    Integracao.BindGrid(dataGridView1, tbSubGrupo.Text2.Trim(), Tabela, Campos, OrderBy);
                }
                else
                {
                    Integracao.BindGrid(dataGridView1, tbgrupo.Text2.Trim(), Tabela, Campos, OrderBy);
                }
               
            }
            else
            {
                MsBox.Show("Estimado(a), deve indicar o grupo em que pretende verificar as contas a integrar");
            }
        }

        private void cbDefault1_Load(object sender, EventArgs e)
        {

        }

        private void cbSel_CheckedChangeds()
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                if (r!=null)
                {
                    r.Cells["Status"].Value = cbSel.cb1.Checked;
                }
            }
        }

        private void tbgrupo_RefreshControls()
        {
            tbSubGrupo.Condicao = $"  SUBSTRING(conta, 1,{tbgrupo.Text2.Length}) = '{tbgrupo.Text2.Trim()}' and len(conta)> {tbgrupo.Text2.Length} and ano =(select ano from param) and integracao =1";    
        }
    }
}
