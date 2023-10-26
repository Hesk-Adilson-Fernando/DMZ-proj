using System.Data;
using System.Windows.Forms;
using DMZ.BL.Classes;

namespace DMZ.UI.Generic
{
    public partial class FrmAddlines : Basic.FrmClasse2
    {
        public FrmAddlines()
        {
            InitializeComponent();
        }

        private string query;
        public FrmAddlines(string str,string query)
        {
            InitializeComponent();
            label1.Text = str;
            this.query = query;
        }

        private DataTable _dt;
        public delegate void PassControl(DataTable dt);

        public PassControl PControl;

        private void FrmAddlines_Load(object sender, System.EventArgs e)
        {

            _dt= SQL.GetGen2DT(query);
            if (_dt?.Rows.Count>0)
            {
                for (var i = 0; i < _dt.Columns.Count-1; i++)
                {
                    radGridView1.Columns[i].DataPropertyName = _dt.Columns[i].ColumnName;
                }
            }
            radGridView1.DataSource = null;
            radGridView1.AutoGenerateColumns = false;
            radGridView1.DataSource = _dt;
        }

        private void Selecionar()
        {
            radGridView1.Update();
            var newDt = _dt.Clone();
            if(radGridView1.Rows.Count==0) return;
            foreach (DataGridViewRow row in radGridView1.Rows)
            {
                if(row==null) continue;
                if (!row.Cells[2].Value.ToBool()) continue;
                var r = newDt.NewRow();
                r[0] = row.Cells[0].Value;
                r[1] = row.Cells[1].Value;
                r[2] = row.Cells[2].Value;
                newDt.Rows.Add(r);
            }

            if (newDt.Rows.Count == 0)
            {
                MsBox.Show("Por favor selecçiona linha(s) desejada(s)!");
            }
            else
            {
                PControl?.Invoke(newDt);
            }
        }

        private void btnAceitar_Click(object sender, System.EventArgs e)
        {
            Selecionar();
            Close();
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
