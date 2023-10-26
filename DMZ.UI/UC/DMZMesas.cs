using System;
using System.Data;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.UI.Generic;
using DMZ.UI.UI;

namespace DMZ.UI.UC
{
    public partial class DMZMesas : UserControl
    {
        public DMZMesas()
        {
            InitializeComponent();
        }
        public DataRow Dr = null;
        private void Adicionar() {
            if (string.IsNullOrEmpty(lblValor.Text))
            {
                ((FrmPosRest)ParentForm)?.SetMesa(Dr);
                //var dt =CheckReserva("");
                //if (dt == null)
                //{
                //    ((FrmPosRest)ParentForm)?.SetMesa(Dr);
                //}
                //else
                //{
                //    MsBox.Show("Mesa está reservada ");
                //}
            }
            else
            {
                MsBox.Show("Mesa com conta corrente");
            }
            
        }

        private DataTable CheckReserva(string mesastamp)
        {
            return SQL.GetGen2DT($@"select * from Reserval where 
                                    din >='{Pbl.SqlDate.ToSqlDate()}' and 
                                    Dfim <='{Pbl.SqlDate.ToSqlDate()}'
                                    and cast(Hfim as time) <='{DateTime.Now.ToString("HH:mm:ss")}'
                                    and Mesastamp='{mesastamp}'");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Adicionar();
        }

        private void lblValor_Click(object sender, EventArgs e)
        {
            Adicionar();
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            Adicionar();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
