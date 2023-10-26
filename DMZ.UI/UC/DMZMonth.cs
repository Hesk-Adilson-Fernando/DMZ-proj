using DMZ.BL.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DMZ.UI.UC
{
    public partial class DMZMonth : UserControl
    {
        public DMZMonth()
        {
            InitializeComponent();
        }
        public List<string> Lista;
        public delegate void Refrescar();

        public event Refrescar RefreshControls;

        public virtual void OnRefreshControls()
        {
            var handler = RefreshControls;
            handler?.Invoke();
        }
        private void DMZMonth_Load(object sender, EventArgs e)
        {
            //var dt = SQL.GetGen2DT("select codigo,Descricao from Meses order by Codigo");
            //comboBox1.DataSource = null;
            //comboBox1.DataSource = dt;
            //comboBox1.DisplayMember = "Descricao";
            //comboBox1.ValueMember = "codigo";
            Lista = new List<string>();
        }
        public void SetMes()
        {
            var dr = SQL.GetRow($"select Codigo, Descricao from meses where Codigo = {Pbl.SqlDate.Month}");
            //dmzMes.tb1.Text = dr["Descricao"].ToString();
            //dmzMes.Text2 = dr["codigo"].ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //ActivaDesativa(button2);
        }

        private void ActivaDesativa(Button button2)
        {
            if (button2.BackColor==Color.DimGray)
            {
                button2.BackColor = Color.DarkGoldenrod;
                Lista.Add(button2.Text);
            }
            else
            {
                button2.BackColor = Color.DimGray;
                Lista.Remove(button2.Text);
            }
            OnRefreshControls();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActivaDesativa((Button)sender);
        }
    }
}
