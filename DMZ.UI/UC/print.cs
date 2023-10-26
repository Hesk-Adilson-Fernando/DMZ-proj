using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace DMZ.UI.UC
{
    public partial class Print : UserControl
    {
        public event EventHandler _RightClick;
        public event EventHandler _LeftClick;
        public string _cursor { get; set;} 
        public string _Janela { get; set; }
        public string _Sigla{ get; set; }
        public string _numdoc{ get; set; }
        public string _colunaNatabelaprincipal { get; set; }
        public string _colunaNatabelapk { get; set; }
        public string _tipochave { get; set; }
        [Description("0- se for a principal,1-se a tabela que pretende fazer select for estrageira na tabela principal, 2-se a tabela principal for estrageira na tabela que pretende fazer select")]
        public string id;
        public string multdocid;
        public bool UsaQweryPersonalida;
        public string QweryPersonalida;
        public string QweryPersonalidaNome;
        public bool UsaQweryAdionalA;
        public string QweryAdionalA;
        public string QweryAdionalANome;
        public bool UsaQweryAdionalb;
        public string QweryAdionalb;
        public string QweryAdionalbNome;
        public List<ReportDataSource> lstReport = new List<ReportDataSource>();
        //public List<ReportDataSource> lstReport = new List<ReportDataSource>();
        public Print()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button.ToString().Equals("Right"))
            {
                if (_RightClick != null)
                    _RightClick(this, e);
            }
            if (e.Button.ToString().Equals("Left"))
            {
                if (_LeftClick != null)
                    _LeftClick(this, e);
            }
        }

        private void print_Load(object sender, EventArgs e)
        {

        }
    }
}
