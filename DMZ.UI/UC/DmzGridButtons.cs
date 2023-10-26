using System;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Generic;

namespace DMZ.UI.UC
{
    public partial class DmzGridButtons : UserControl
    {
        public DmzGridButtons()
        {
            InitializeComponent();
        }
        public Image BtnNovoImage
        {
            get => btnNovo.Image;
            set => btnNovo.Image = value;
        }
        public Image BtnDellImage
        {
            get => btnDell.Image;
            set => btnDell.Image = value;
        }
        public string Gridnome { get; set; }
        private Form MyParent;
        public GridUIFt Grelha;
        public Color PanelBackColor
        {
            get => panelText.BackColor;
            set => panelText.BackColor = value;
        }
        public Color BtnNovoBackColor
        {
            get => btnNovo.BackColor;
            set => btnNovo.BackColor = value;
        }
        public Color BtnDellBackColor
        {
            get => btnDell.BackColor;
            set => btnDell.BackColor = value;
        }
        private void DmzGridButtons_Load(object sender, EventArgs e)
        {

        }

        void NovalinhaGrid(Form frm)
        {
            Grelha = (GridUIFt)Helper.GetAll(ParentForm, typeof(GridUIFt)).ToList().Find(x => x.Name.Trim().ToLower().Equals(Gridnome.ToLower().Trim()));
            if (Grelha == null) return;
            if (frm.GetType().GetMethod("NewGridLine") != null)
            {
                frm.GetType().InvokeMember("NewGridLine", BindingFlags.InvokeMethod, null,frm, null);
            }  
        }
        private void AddLine()
        {
            var frm = ParentForm;
            if (frm == null) return;
            if (!((FrmClasse)frm).EditMode) return;

            NovalinhaGrid(frm);
            //var usracessos = ((FrmClasse) frm).Usracessos;
            //if (usracessos == null) return;
            //if (!((FrmClasse)frm).Procurou)
            //{
            //    if (usracessos.Intro)
            //    {
            //        NovalinhaGrid(frm);
            //    }
            //    else
            //    {
            //        MsBox.Show("Desculpa não tem permissão a introduzir linhas! \r\n Contacte o administrador do sistema!");
            //    }
            //}
            //else
            //{
            //    if (usracessos.Altera)
            //    {
            //        NovalinhaGrid(frm);
            //    }
            //    else
            //    {
            //        MsBox.Show("Desculpa não tem permissão a introduzir linhas! \r\n Contacte o administrador do sistema!");
            //    }     
            //}


        }
        public delegate bool BeforeAddLineDelegate();

        public event BeforeAddLineDelegate BeforeAddLineEvent;
        public bool BeforeAddLine()
        {
            var handler = BeforeAddLineEvent;
            return handler != null && handler.Invoke();

        }

        public delegate void AfterAddLineDelegate();

        public event AfterAddLineDelegate AfterAddLineEvent;
        public virtual void AfterAddLine()
        {
            var handler = AfterAddLineEvent;
            handler?.Invoke();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            var xx = BeforeAddLine();

            if (!xx)
            {
                AddLine();
                AfterAddLine();
            }
        }

        private void btnDell_Click(object sender, EventArgs e)
        {
            var frm = ParentForm;
            if (frm == null) return;
            if (!((FrmClasse)frm).EditMode) return;
            var grid = Helper.GetAll(frm, typeof(GridUIFt)).ToList().Find(x => x.Name.Trim().ToLower().Equals(Gridnome.ToLower().Trim()));
            if (grid == null) return;
            ((GridUIFt)grid).DellLine();
        }
    }


}
