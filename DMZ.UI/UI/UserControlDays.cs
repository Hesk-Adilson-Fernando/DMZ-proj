using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMZ.UI.UI
{
    public partial class UserControlDays : UserControl
    {
        public UserControlDays()
        {
            InitializeComponent();
        }
        public static string static_day;
        private object connectionString;

        public void days(int numday)
        {
            lbdays.Text= numday+"";

        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = lbdays.Text;
            var b = new FormEvento();
            b.Show(this);
        }

        private void displayEvent()
        {
            SqlConnection conn = SqlConnection(connectionString);
            conn.Open();
            string sql = "Select * from tbl_calendar where date = ?";
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText =sql;
            cmd.Parameters.AddWithValue("date", Frmcalendario.static_year + '-' + Frmcalendario.static_month + '-');
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lblevent.Text= reader["event"].ToString();
            }
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
        }

        private SqlConnection SqlConnection(object connectionString)
        {
            throw new NotImplementedException();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }

        private void lblevent_Click(object sender, EventArgs e)
        {

        }
    }
}
