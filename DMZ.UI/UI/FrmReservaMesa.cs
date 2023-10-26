using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Classes;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DMZ.UI.UI
{
    public partial class FrmReservaMesa : Basic.FrmClasse
    {
        public FrmReservaMesa()
        {
            InitializeComponent();
        }
        public Reserva _reserva;

        public DataTable DtCl { get; private set; }

        private void FrmReservaMesa_Load(object sender, EventArgs e)
        {
            Campo1 = "no";
            Campo2 = "nome";
            Ctabela = "Reserva";
        }
        public override void DefaultValues()
        {
            _reserva = DoAddline<Reserva>();
            tbCcusto.tb1.Text = Pbl.Usr.Ccusto;
            tbCcusto.Text2 = Pbl.Usr.Ccustamp;
            base.DefaultValues();
            Hin.dt1.Value = DateTime.Now;
            Hfim.dt1.Value = DateTime.Now;
        }
        public override void Save()
        {
            FillEntity(_reserva);
            EF.Save(_reserva);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            _reserva = FillControls(_reserva, dt, i);
        }

        private void gridDeb_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (gridDeb.CurrentRow == null) return;
            const string qry = "select nome,clstamp from cl where pos=1 ";
            var name = gridDeb.CurrentCell.OwningColumn.Name.ToLower();
            if (gridDeb.CurrentColumn.Name.ToLower().Equals("nome"))
            {
                DtCl = Helper.SetBinds(e.Control, "nome", qry);
            }
            else
            {
                DtCl = null;
                var autoText = e.Control as TextBox;
                if (autoText != null)
                    autoText.AutoCompleteCustomSource = null;
            }
        }

        private void gridDeb_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var nome = gridDeb.CurrentCell.OwningColumn.Name.ToLower();
            if (nome.Equals("nome"))
            {
                SetFactl("nome");
            }
        }

        private void SetFactl(string campo)
        {
            if (gridDeb.CurrentCell == null) return;
            var valor = gridDeb.CurrentCell.Value.ToString().Trim();
            var dr = DtCl.AsEnumerable().FirstOrDefault(s => s.Field<string>(campo).Trim().Equals(valor));
            if (dr == null) return;
            if (gridDeb.CurrentRow == null) return;
            if (campo.Equals("nome"))
            {
                gridDeb.CurrentRow.Cells["clstamp"].Value = dr["clstamp"].ToString();
            }
        }

        private void gridDeb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var nome = gridDeb.CurrentCell.OwningColumn.Name.Trim();
            if (nome.Equals("din") || nome.Equals("dfim"))
            {
                Helper.AddDateTimePicker(gridDeb, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gridDeb.Rows.Count>0)
            {
                foreach (DataGridViewRow item in gridDeb.Rows)
                {
                    if (item != null)
                    {
                        item.Cells["HoraIn"].Value = Hin.dt1.Value;
                        item.Cells["Horafim"].Value = Hfim.dt1.Value;
                    }
                }
            }
        }
    }
}
