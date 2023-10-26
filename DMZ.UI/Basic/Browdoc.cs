using System;
using System.Data;
using System.Windows.Forms;
using DMZ.BL.Classes;

namespace DMZ.UI.Basic
{
    public partial class Browdoc : FrmClasse2
    {
        public string Tabela { get;  set; }
        public string Condicao { get;  set; }
        public string Sigla { get; set; }
        public string Descricao { get; set; }
        private DataTable Dt { get; set; }
        public Action<DataRow,bool> BindTdoc;

        public Browdoc()
        {
            InitializeComponent();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Browdoc_Load(object sender, EventArgs e)
        {

            var qry = $"select * from {Tabela} {InnerJoin} {Condicao} order by numdoc";
            Dt = SQL.GetGen2DT(qry);

            gridUI21.DataSource = null;
            gridUI21.DataSource = Dt;
            foreach (DataGridViewColumn col in gridUI21.Columns)
            {
                if (col==null) continue;
                if (col.Name.ToLower().Trim().Equals(Sigla.Trim()) || col.Name.ToLower().Trim().Equals(Descricao.Trim()))
                {
                    col.Visible = true;
                    if (!col.Name.ToLower().Trim().Equals(Descricao.Trim())) continue;
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    col.Width = 200;
                }
                else
                {
                    col.Visible = false;
                }
            }
        }

        public string InnerJoin { get; set; }

        private void btnSeach2_Click(object sender, System.EventArgs e)
        {
            Selecct();
        }
        public bool Origem { get; set; }
        private void Selecct()
        {
            if (gridUI21.DataSource == null) return;
            if (gridUI21.SelectedRows.Count <= 0) return;
            var row = gridUI21.SelectedRow();
            BindTdoc?.Invoke(row, Origem);
            Close();
        }

        private void gridUI21_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Selecct();
        }
    }
}
