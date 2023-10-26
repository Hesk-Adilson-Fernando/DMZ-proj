using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Generic;

namespace DMZ.UI.UI
{
    public partial class FrmAddCc : FrmClasse2
    {
        public FrmAddCc()
        {
            InitializeComponent();
        }
        public void Alert(string msg, Form_Alert.EnmType type)
        {
            var frm = new Form_Alert();
            frm.ShowAlert(msg,type);
        }
        private void FrmAddCc_Load(object sender, EventArgs e)
        {
            gridDeb.Condicao = "1=0";
            gridDeb.BindGridView();
            dmzProcura2.tb1.Text = Pbl.Usr.Ccusto;
            dmzProcura2.Text2 = Pbl.Usr.Codccu;
        }
        private void btnMaxMin_Click(object sender, EventArgs e)
        {
            if (!Maximizado)
            {
                Maximizar();
            }
            else
            {
                Minimizar();
            }
        }
        public bool Maximizado { get; set; }
        private void Maximizar()
        {
            NSize = Size;
            NLocation = Location;
            if (MdiParent != null)
            {
                var height = MdiParent.Size.Height;
                var width = MdiParent.Size.Width;
                Size = new Size(width - 190, height - 165);
                var x = MdiParent.Location.X;
                var y = MdiParent.Location.Y;
                Location = new Point(x + 175, y + 110);
                Maximizado = true;
                var lista = Application.OpenForms;
                foreach (Form frm in lista)
                {
                    if (frm == null) continue;
                    if (!frm.IsMdiContainer) continue;
                    var mdi = frm as DemoMdi;
                    if (mdi != null)
                    {
                        if (mdi.Ocultado)
                        {
                            MoveUp();
                        }
                    }
                    else
                    {
                        MoveUp();
                    }
                }
            }
            else
            {
                var height = Screen.PrimaryScreen.WorkingArea.Size.Height;
                var width = Screen.PrimaryScreen.WorkingArea.Size.Width;
                Size = new Size(width - 190, height - 165);
                var x = Screen.PrimaryScreen.WorkingArea.Location.X;
                var y = Screen.PrimaryScreen.WorkingArea.Location.Y;
                Location = new Point(x + 175, y + 110);    
            }
        }
        public void MoveUp()
        {
            NSize = Size;
            NLocation = Location;
            var height = MdiParent.Size.Height;
            var width = MdiParent.Size.Width;
            Size = new Size(width - 70, height - 165);
            var y = MdiParent.Location.Y;
            Location = new Point(48, y + 110);
        }
        public void MoveDow()
        {
            Size = NSize;
            Location = NLocation;
        }
        public void Minimizar()
        {
            Size = NSize;
            Location = NLocation;
            Maximizado = false;
        }
        public Size NSize { get; set; }
        public Point NLocation { get; set; }
        private bool gridPanel21_BeforeAddLineEvent()
        {
            if (!string.IsNullOrEmpty(dmzProcura1.tb1.Text) && !string.IsNullOrEmpty(dmzProcura2.tb1.Text))
            {
                return false;
            }
            MsBox.Show("Porfavor indica o cliente  ou centro de custo acima!");
            return true;
        }
        private void gridPanel21_AfterAddLineEvent()
        {
            if (gridDeb.CurrentRow == null) return;
            gridDeb.CurrentRow.Cells["nome"].Value = dmzProcura1.tb1.Text;
            gridDeb.CurrentRow.Cells["no"].Value = dmzProcura1.Text2;
            gridDeb.CurrentRow.Cells["origem"].Value = "FT"; //documento
            gridDeb.CurrentRow.Cells["documento"].Value = "N/Factura"; //
            gridDeb.CurrentRow.Cells["ccusto"].Value = dmzProcura2.tb1.Text; //Moeda
            gridDeb.CurrentRow.Cells["Moeda"].Value = "MZN"; //
            gridDeb.CurrentRow.Cells["Factstamp"].Value = null; //
            gridDeb.CurrentRow.Cells["oristamp"].Value = "FTIMPORT"; //
        }
        private void btnProcura_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dmzProcura1.Text2))
            {
                gridDeb.Condicao = $"no={dmzProcura1.Text2.Trim()} and oristamp='FTIMPORT'";
                gridDeb.BindGridView();
            }
            else
            {
                MsBox.Show("Deve indicar o cliente e Centro de custo!");
            }
        }
        private void gridDeb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridDeb.CurrentRow==null) return;
            Helper.SetDateTimePicker(gridDeb);
        }
        private void gridDeb_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!gridDeb.CurrentCell.OwningColumn.DataPropertyName.Equals("data") && !gridDeb.CurrentCell.OwningColumn.DataPropertyName.Equals("vecin"))
            {
                Helper.CellEnter(sender,e);  
            }
        }
        private void gridDeb_AfterDeleteLineEvent()
        {
            var lista = new List<SqlParameter>();
            var p0 = new SqlParameter {SqlDbType = SqlDbType.Char, ParameterName = "@Nometabela", Value = "cl"};
            lista.Add(p0);
            var p1 = new SqlParameter {SqlDbType = SqlDbType.Decimal, ParameterName = "@no", Value = $"{dmzProcura1.Text2}"};
            lista.Add(p1);
            SQL.SqlSP("UpdSaldo",lista);
            Alert("Gravado com sucesso", Form_Alert.EnmType.Success);
        }
        private bool gridPanel21_SaveEvent()
        {
            var dt = gridDeb.DataSource as DataTable;
            if (dt == null) return true;
            if (SQL.Save(dt, "cc", false, "", "").numero != 1) return true;
            var lista = new List<SqlParameter>();
            var p0 = new SqlParameter {SqlDbType = SqlDbType.Char, ParameterName = "@Nometabela", Value = "cl"};
            lista.Add(p0);
            var p1 = new SqlParameter {SqlDbType = SqlDbType.Decimal, ParameterName = "@no", Value = $"{dmzProcura1.Text2}"};
            lista.Add(p1);
            SQL.SqlSP("UpdSaldo",lista);
            Alert("Gravado com sucesso", Form_Alert.EnmType.Success);
            return true;
        }
    }
}
