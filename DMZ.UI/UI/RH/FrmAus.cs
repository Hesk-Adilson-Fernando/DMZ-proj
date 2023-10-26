using System.Data;
using System.Linq;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.UI.Classes;

namespace DMZ.UI.UI.RH
{
    public partial class FrmAus : Basic.FrmClasse2
    {
        public FrmAus()
        {
            InitializeComponent();
        }
        public DataTable DtPe { get; set; }
        private void grident_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (grident.CurrentRow == null) return;
            var name = grident.CurrentCell.OwningColumn.Name;
            if (name.Equals("nome"))
            {
                DtPe=Helper.SetBinds(e.Control, "nome", "select no,nome,Pestamp from pe ");
            }
            if (name.Equals("no"))
            {
                DtPe=Helper.SetBinds(e.Control, "no", "select no,nome,Pestamp from pe ");
            }
            if (name.Equals("Tipo"))
            {
                Helper.SetBinds(e.Control, "Descricao", "select Descricao from PeAuxiliar where Tabela=18");
            }
        }

        private void grident_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (grident.CurrentRow == null) return;
            var name = grident.CurrentCell.OwningColumn.Name;
            var valor = grident.CurrentCell.Value; 
            if (name.Equals("no"))
            {
                var dr = DtPe.AsEnumerable().FirstOrDefault(x=>x.Field<decimal>("no").Equals(valor.ToDecimal()));
                if (dr == null) return;
                grident.CurrentRow.Cells["nome"].Value = dr["nome"].ToString();
                grident.CurrentRow.Cells["pestamp"].Value = dr["pestamp"].ToString();
            }
            else if(name.Equals("nome"))
            {
                var dr = DtPe.AsEnumerable().FirstOrDefault(x=>x.Field<string>("nome").Equals(valor));
                if (dr == null) return;
                grident.CurrentRow.Cells["no"].Value = dr["no"].ToString();
                grident.CurrentRow.Cells["pestamp"].Value = dr["pestamp"].ToString(); 
            }
        }

        private void grident_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var nome = grident.CurrentCell.OwningColumn.Name.Trim();
            if (nome.Equals("Datain") || nome.Equals("Datater"))
            {
                Helper.AddDateTimePicker(grident,e); 
            }
        }

        private void FrmAus_Load(object sender, System.EventArgs e)
        {
            grident.BindGridView();

        }
    }
}
