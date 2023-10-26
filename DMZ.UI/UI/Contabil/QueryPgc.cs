using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.UI.Basic;

namespace DMZ.UI.UI.Contabil
{
    public partial class QueryPgc : FrmClasse2
    {
        internal DataTable dtPgc;
        private int indice = -1;
        private decimal anoc;

        public QueryPgc()
        {
            InitializeComponent();
        }

        public QueryPgc(int indice)
        {
            this.indice = indice;
            InitializeComponent();
        }

        public Action<object> Pcontrol { get; internal set; }
        public Action<object,int> Pcontrol2 { get; internal set; }

        private void QueryPgc_Load(object sender, EventArgs e)
        {
            if (dtPgc != null)
            {
                dgvContas.AutoGenerateColumns = false;
                dgvContas.DataSource = null;
                dgvContas.DataSource = dtPgc;
            }
           anoc= Pbl.AnoContabil();

            txtFindByRef.Focus();
        }

        private void dgvContas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(indice>-1)
                PassData2(e.RowIndex,indice);
            else
            PassData(e.RowIndex);
        }
        private void PassData(int index)
        {
            Pcontrol?.Invoke(dtPgc.Rows[index]);
            Close();
        }

        private void PassData2(int rindex, int destRindex)
        {
            Pcontrol2?.Invoke(dtPgc.Rows[rindex],destRindex);
            Close();
        }

        private void dgvContas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if(dgvContas.CurrentCell.RowIndex==dgvContas.Rows.Count)               
                PassData(dgvContas.CurrentCell.RowIndex);
                else
                    PassData(dgvContas.CurrentCell.RowIndex-1);
            }
        }

        private void txtFindByRef_TextChanged(object sender, EventArgs e)
        {
            Requery(txtFindByRef.Text.Trim(), "conta");
        }

        private void Requery(string txt, string campo)
        {
            dtPgc = SQL.GetGen2DT($"select * from pgc where ano={anoc} and {campo} like '{txt}%' order by conta");
            dgvContas.AutoGenerateColumns = false;
            dgvContas.DataSource = null;
            dgvContas.DataSource = dtPgc;        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Requery(textBox1.Text.Trim(), "descricao");
        }

        private void txtFindByRef_Enter(object sender, EventArgs e)
        {
            txtFindByRef.BackColor = Color.AliceBlue;
        }

        private void txtFindByRef_Leave(object sender, EventArgs e)
        {
            txtFindByRef.BackColor = Color.Empty;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {           

            if (keyData == Keys.F2) // Compara a tecla pressionada
                txtFindByRef.Focus();

            if (keyData == Keys.F3) // Compara a tecla pressionada
            {
                ActiveControl = null;
                textBox1.Focus();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            txtFindByRef.BackColor = Color.AliceBlue;
        }

        private void textBox1_Move(object sender, EventArgs e)
        {
            txtFindByRef.BackColor = Color.Empty;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                dgvContas.Focus();
            }   

        }

        private void txtFindByRef_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                dgvContas.Focus();
            }
        }
    }
}
