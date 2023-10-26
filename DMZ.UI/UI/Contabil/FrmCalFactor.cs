using System;
using System.Data;
using System.Linq;
using DMZ.BL.Classes;
using DMZ.UI.Generic;


namespace DMZ.UI.UI.Contabil
{
    public partial class FrmCalFactor : Basic.FrmClasse2
    {
        public FrmCalFactor()
        {
            InitializeComponent();
            Dt = new DataTable();
            var dc1 = new DataColumn("conta", typeof(string));
            Dt.Columns.Add(dc1);
            var dc2 = new DataColumn("perc", typeof(decimal));
            Dt.Columns.Add(dc2);
            var dc3 = new DataColumn("factor", typeof(decimal));
            Dt.Columns.Add(dc3);
            var dc4 = new DataColumn("integ", typeof(bool));
            Dt.Columns.Add(dc4);
        }
        public delegate void PassControl(DataTable dt);

        public PassControl PControl;
        public DataTable Dt;
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            var dr = Dt.AsEnumerable().FirstOrDefault(x => x.Field<bool>("integ").Equals(true));
            if (dr == null)
            {
                MsBox.Show("Deve indicar a conta de maior percentagem ou valor");
            }
            else
            {
                dr["factor"] = 1;
                foreach (var r in Dt.AsEnumerable())
                {
                    if (Convert.ToBoolean(r["integ"])) continue;
                    if (r["perc"].ToDecimal() != 0)
                        r["factor"] = Math.Round(r["perc"].ToDecimal() / dr["perc"].ToDecimal(),4); 
                }
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            PControl?.Invoke(Dt);
            Close();
        }

        private void FrmCalFactor_Load(object sender, EventArgs e)
        {
            gridUi1.AutoGenerateColumns = false;
            gridUi1.DataSource = null;
            gridUi1.DataSource = Dt;
        }
    }
}
