using System;
using DMZ.BL.Classes;
using DMZ.Model.Model;

namespace DMZ.UI.UI
{
    public partial class FrmMoradas : Basic.FrmClasse2
    {
        public FrmMoradas()
        {
            InitializeComponent();
        }

        public Action<ClMorada> Enviar { get; set; }
        public string Clstamp { get;  set; }

        private void FrmMoradas_Load(object sender, EventArgs e)
        {
            var lista = SQL.GetGen2DT($"select * from ClMorada where Clstamp='{Clstamp}'").DtToList<ClMorada>();
            gridUi3.DataSource = null;
            gridUi3.AutoGenerateColumns = false;
            gridUi3.DataSource = lista;
        }

        private void gridUi3_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (!gridUi3.CurrentCell.OwningColumn.Name.Equals("sel")) return;
            if (gridUi3.CurrentRow == null) return;
            var mor = gridUi3.CurrentRow.DataBoundItem as ClMorada;
            Enviar.Invoke(mor);
            Close();
        }
    }
}
