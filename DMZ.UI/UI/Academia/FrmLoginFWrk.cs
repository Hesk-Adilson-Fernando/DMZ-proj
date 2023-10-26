using DMZ.UI.Basic;
using DMZ.UI.Generic;
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

namespace DMZ.UI.UI.Academia
{
    public partial class FrmLoginFWrk : FrmClasse2
    {
        public string Username { get; set; }
        public string Password { get; set; }
        //Double count = 0;
        DemoMdi _di;
        public FrmLoginFWrk(DemoMdi di)
        {
            InitializeComponent();
            _di = di;
        }

        //private object GetSession()
        //{
        //    return Session;
        //}

        private void FrmLoginFWrk_Load(object sender, EventArgs e)
        {
            //this.AcceptButton = btnLogin;
           
        }
        int count = 0;
        public bool Entrou = false;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user, pass;
            count++;
            user = "Sa";
            pass = "Server2012#";
            if ((tbUser.Text == user) && (txtPass.Text == pass))
            {
                _di.Entrou = true;
                //MessageBox.Show("Lodado com susseço");
                this.Dispose();
            }
            else
            {
                MsBox.Show("A password ou Login inserida está errada!..");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
        
}

