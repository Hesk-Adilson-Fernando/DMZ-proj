using DMZ.BL.Classes;
using DMZ.DAL.Migrations;
using DMZ.Model.Model;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Generic;
using DMZ.UI.Properties;
using Microsoft.Graph.Models;
using Microsoft.Graph.Models.ExternalConnectors;
using Microsoft.Kiota.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMZ.UI.UI
{
    public partial class FormEvento : FrmClasse
    {
        public FormEvento()
        {
            InitializeComponent();
        }

        //private string connectionString = "Server= DESKTOP-K5H2F4T ;Initial Catalog=CALENDARI;User ID=sa;Password =123;Integrated Security=false";
        calendario cal;
        private void FormEvento_Load(object sender, EventArgs e)
        {
            txtdates.Text = Frmcalendario.static_month + "/" + UserControlDays.static_day + "/" + Frmcalendario.static_year;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            // string save = txtEvent.Text;

            //var save = txtEvent.Text;

            //MessageBox.Show(save, "Test");


            var ss = Convert.ToDateTime(txtdates.Text);
           var f = DoAddline<calendario>();
            f.calendariostamp=Pbl.Stamp();
            //var ano = ss.Day;
            try
            {
                ss=Convert.ToDateTime($"{ss.Year}-{ss.Month}-{ss.Day}");
            }
            catch (Exception)
            {
                ss = Convert.ToDateTime(txtdates.Text);
            }
            f.date= ss;
            f.events=txtEvent.Text;
           var dd= EF.Save(f);



           // SQL.SqlCmd("insert into tabels value ;;;;");

            MessageBox.Show("saved");
            

        }
    }
}
