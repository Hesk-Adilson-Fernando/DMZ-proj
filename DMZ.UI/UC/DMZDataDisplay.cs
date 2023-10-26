using DMZ.BL.Classes;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Windows.Forms;

namespace DMZ.UI.UC
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public partial class DMZDataDisplay : UserControl
    {
        public DMZDataDisplay()
        {
            InitializeComponent();
        }

        public delegate void Imprimir();
        //Cria um evento
        public event Imprimir BtnImprimir;
        //public event 
        protected virtual void OnBtnImprimir()
        {
            if (BtnImprimir !=null)
            {
                BtnImprimir.Invoke();
            }            
        }

        public delegate void Refrescar();
        //Cria um evento
        public event Refrescar BtnRefrescar;
        //public event 
        protected virtual void OnBtnRefrescar()
        {
            if (BtnRefrescar!=null)
            {
                BtnRefrescar.Invoke();
            }
        }
        public string SQLQuery { get; set; }
        public void BindGrid(string qry,string descricao) 
        {
            SQLQuery= qry;
            var dt = SQL.GetGenDT(SQLQuery);
            if (dt.HasRows())
            {
                label1.Text = descricao;
                var Grelha = (GridUi)Helper.GetAll(this, typeof(GridUi)).FirstOrDefault();
                if (Grelha != null)
                {
                    Grelha.SetDataSource(dt);
                } 
            }
        }
        public string Origem { get; set; }
        public AnchorStyles Label1Anchor
        {
            get => label1.Anchor;
            set => label1.Anchor = value;
        }
        public Font label1Font
        {
            get => label1.Font;
            set => label1.Font = value;
        }
        public Image BtnCloseImage
        {
            get => btnClose.Image;
            set => btnClose.Image = value;
        }
        public Image BtnPrintImage
        {
            get => btnPrint.Image;
            set => btnPrint.Image = value;
        }
        public Image BtnRefreshImage
        {
            get => btnRefresh.Image;
            set => btnRefresh.Image = value;
        }
        public Color label1ForeColor
        {
            get => label1.ForeColor;
            set => label1.ForeColor = value;
        }
        [Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
        public string Label1Text
        {
            get => label1.Text;
            set => label1.Text = value;
        }

        public Color PanelHeaderBackColor
        {
            get => panelHeader.BackColor;
            set => panelHeader.BackColor = value;
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DMZDataDisplay_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e) => Hide();

        private void btnPrint_Click(object sender, EventArgs e)
        {
            OnBtnImprimir();
        }
    }
}
