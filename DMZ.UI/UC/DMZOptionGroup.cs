using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;
using DMZ.UI.Properties;

namespace DMZ.UI.UC
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public partial class DmzOptionGroup : UserControl
    {
        public DmzOptionGroup()
        {
            InitializeComponent();

        }
        public Color PanelBackColor
        {
            get => panelText.BackColor;
            set => panelText.BackColor = value;
        }
        public bool IsRequered { get; set; }

        [Description("Define a Imagem na barra de titulo ")]
        public Image Imagem
        {
            get => pictureBox1.Image;
            set => pictureBox1.Image = value;
        }
        public string Label1Text
        {
            get => label1.Text;
            set => label1.Text = value;
        }
        public int ButtonCount { get; set; }//Tipodoc
        public string Value { get; set; }//
        public void RefreshControl()
        {
            foreach (var c in Controls)
            {
                if (c is CbDefault)
                {
                    ((CbDefault)c).RefreshContrls();
                }
                
            }
        }

        public string Bind()
        {
            var dec = "";
            foreach (var c in Controls)
            {
                if (c is CbDefault)
                {
                    if (!((CbDefault) c).cb1.Checked) continue;
                    dec = ((CbDefault)c).Value2;
                    break;
                }

            }

            return dec;
        }
        private void DMZOptionGroup_Load(object sender, EventArgs e)
        {

        }


        public void SetUpdate(string name)
        {
            foreach (var c in Controls)
            {
                if (!(c is CbDefault)) continue;
                if (((CbDefault) c).Name.Trim().Equals(name.Trim())) continue;
                ((CbDefault) c).cb1.Checked = false;
                ((CbDefault)c).btnCheck.Image = Resources.Circle_23px1;

            }
        }

        public bool CheckSelected()
        {
            var selected = false;
            if (!IsRequered) return selected;
            foreach (var c in Controls)
            {
                if (c is CbDefault)
                {
                    selected= ((CbDefault) c).cb1.Checked;
                }

                if (selected)
                {
                    break; 
                }

            }
            selected = !selected;
            return selected;
        }

        public void BindValue(string getValue)
        {
            foreach (var c in Controls)
            {
                if (!(c is CbDefault)) continue;
                if (((CbDefault)c).Value2.Equals(getValue.Trim()))
                {
                    ((CbDefault) c).cb1.Checked = true;
                    ((CbDefault)c).btnCheck.Image = Resources.Circled_Dot_23px;
                    break;
                }
            }
        }

        public void ClearAllValue()
        {
            foreach (var c in Controls)
            {
                if (!(c is CbDefault)) continue;
                ((CbDefault)c).cb1.Checked = false;
                ((CbDefault) c).btnCheck.Image = Resources.Circle_23px;
            }
        }
    }
}
