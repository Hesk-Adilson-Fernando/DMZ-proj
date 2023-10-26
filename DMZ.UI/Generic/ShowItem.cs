using System;
using System.Windows.Forms;
using DMZ.BL.Classes;

namespace DMZ.UI.Generic
{
    public partial class ShowItem : Form
    {
        public string Selected { get;  set; }
        public string Tabela { get;  set; }
        public string Condicao { get;  set; }
        //public object Sender { get; set; }
        public delegate void PassControl(DataGridViewRow dr);

        // public delegate void PassControl(object sender,DataTable dt);
        public PassControl Sender;
        public ShowItem()
        {
            InitializeComponent();
        }
        private void MouseDownEvent()
        {
            Dllimport.ReleaseCapture();
            Dllimport.SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void ShowItem_Load(object sender, EventArgs e)
        {
            var q = $"select {Selected} from {Tabela} {Condicao}";
            var dt = SQL.GetGenDT(q);
            dataGridView1.DataSource = null;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dt;
            if (dataGridView1.RowCount <= 0) return;
            if (dataGridView1.Columns.Count==1)
            {
                var c = dataGridView1.Columns[0];
                c.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                c.MinimumWidth = 50;
                
            }
            else
            {
                for (var index = 0; index < dataGridView1.Columns.Count; index++)
                {
                    switch (index)
                    {
                        case 0:
                        {
                            var c = dataGridView1.Columns[index];
                            c.Width = 20;
                            break;
                        }
                        case 1:
                        {
                            var c = dataGridView1.Columns[index];
                            c.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            c.MinimumWidth = 50;
                            break;
                        }

                    }
                }
            }
        }

        private void ShowItem_MouseDown(object sender, MouseEventArgs e) => MouseDownEvent();

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Sender?.Invoke(dataGridView1.CurrentRow);
            }
            Dispose();           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
