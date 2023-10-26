using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.UI.Generic;

namespace DMZ.UI.UI
{
    public partial class FrmViewDocs : Basic.FrmClasse2
    {
        public FrmViewDocs()
        {
            InitializeComponent();
        }

        private void FrmViewDocs_Load(object sender, System.EventArgs e)
        {
            BindGrid();

        }

        public bool Encomenda { get; set; }
        private void BindGrid()
        {
            var str = $@"select numero,nome,ref,quant,di.Distamp from di join dil on 
            di.Distamp=dil.Distamp where {Condicao} and fechado=0 order by numero";
            var dt = SQL.GetGen2DT(str);
            Grid.DataSource = null;
            Grid.AutoGenerateColumns = false;
            Grid.DataSource = dt;
        }

        public string Condicao { get; set; }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Grid == null || !Grid.CurrentCell.OwningColumn.Name.Equals("Origem")) return;
            if (Grid.CurrentRow == null) return;
            var distamp = Grid.CurrentRow.Cells["distamp"].Value.ToString();
            if (string.IsNullOrEmpty(distamp)) return;
            var dt = SQL.GetGenDT("di", $" where distamp='{distamp}'", "*");
            var fact = new FrmRe();
            fact.Encomenda = Encomenda;
            fact.UpdateObjects(dt);
            fact.Procurou = true;
            fact.ShowForm(this);
            fact.PreencheCampos(dt,0);
        }
    }
}
