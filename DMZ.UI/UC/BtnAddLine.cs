using System;
using System.Windows.Forms;
using DMZ.UI.Generic;
using DMZ.UI.Classes;
using System.Linq;

namespace DMZ.UI.UC
{
    public partial class BtnAddLine : UserControl
    {
        public BtnAddLine()
        {
            InitializeComponent();
        }
        public delegate void ClickButton();
        public event ClickButton CallForm;
        public virtual void ButtonClick()
        {
            var handler = CallForm;
            handler?.Invoke();
        }
        public string Gridnome { get; set; }
        public bool Doform { get;  set; }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (!Doform)
            {
                var listaGrids = Helper.GetAll(ParentForm, typeof(GridUi)).ToList();
                if (listaGrids.Count <= 0) return;
                foreach (var rg in listaGrids)
                {
                    var grd = ((GridUi)rg);
                    if (grd.Name.Trim().ToLower().Equals(Gridnome.ToLower().Trim()))
                    {
                        grd.AddLine();
                        break;
                    }
                }
                listaGrids.Clear();
            }
            else
            {
                ButtonClick();
            }
        }
    }
}
