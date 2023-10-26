using DMZ.BL.Classes;
using DMZ.UI.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMZ.UI.UI
{
    public partial class Frmcalendario : Form
    {
        public Frmcalendario()
        {
            InitializeComponent();
        }
        public static int static_month, static_year;
        int month, year;

        private void Frmcalendario_Load(object sender, EventArgs e)
        {
            displayday();
        }

         private void displayday()
         {
                DateTime Now = DateTime.Now;
                month = Now.Month;
                year = Now.Year;

                string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
                lbdates.Text= monthname  +  " "  + year;
                static_month= month;
                static_year= year;
                DateTime startofthemoth = new DateTime(year, month, 11);

                int days = DateTime.DaysInMonth(year, month);

                int dayoftheweek = Convert.ToInt32(startofthemoth.DayOfWeek.ToString("d"));

                for (int i = 1; i <dayoftheweek; i++)
                {
                    UserControlblank ucblank = new UserControlblank();
                    daycontainer.Controls.Add(ucblank);
                }

            for (int i = 1; i <days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.days(i);
                var query = $"select events from calendario where DATEPART(YEAR,date)='{year}' and DATEPART(MONTH,date)='{month}'" +
                    $" and DATEPART(DAY,date)='{i}'";
                var dt = SQL.GetGenDT(query);
                daycontainer.Controls.Add(ucDays);
                if (dt.HasRows())
                {
                    ucDays.lblevent.Text=dt.Rows[0]["events"].ToString();
                }
            }

        }

         private void button1_Click(object sender, EventArgs e)
         {
            try
            {
                daycontainer.Controls.Clear();
                month--;

                string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
                lbdates.Text=monthname  +  " "  + year;
                static_month= month;
                static_year= year;

                DateTime startofthemoth = new DateTime(year, month, 11);

                int days = DateTime.DaysInMonth(year, month);

                int dayoftheweek = Convert.ToInt32(startofthemoth.DayOfWeek.ToString("d"));

                for (int i = 1; i <dayoftheweek; i++)
                {
                    UserControlblank ucblank = new UserControlblank();
                    daycontainer.Controls.Add(ucblank);
                }

                for (int i = 1; i <days; i++)
                {
                    UserControlDays ucDays = new UserControlDays();
                    ucDays.days(i);
                    daycontainer.Controls.Add(ucDays);
                }
            }
            catch (Exception)
            {
                //
            }
         }

         private void button2_Click(object sender, EventArgs e)
         {
                daycontainer.Controls.Clear();
                month++;

                string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
                lbdates.Text=monthname +  " "  + year;

                static_month= month;
                static_year= year;

                DateTime startofthemoth = new DateTime(year, month, 11);

                int days = DateTime.DaysInMonth(year, month);

                int dayoftheweek = Convert.ToInt32(startofthemoth.DayOfWeek.ToString("d"));

                for (int i = 1; i <dayoftheweek; i++)
                {
                    UserControlblank ucblank = new UserControlblank();
                    daycontainer.Controls.Add(ucblank);
                }

                for (int i = 1; i <days; i++)
                {
                    UserControlDays ucDays = new UserControlDays();
                    ucDays.days(i);
                    daycontainer.Controls.Add(ucDays);
                }
         }
        
    }
}
