using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using System;
using System.Data;
using System.Windows.Forms;

namespace DMZ.UI.UI.TM
{
    public partial class FrmMaquina : Basic.FrmClasse
    {
        private Maquina maquina;

        public FrmMaquina()
        {
            InitializeComponent();
        }

        private void FrmMaquina_Load(object sender, EventArgs e)
        {
            Campo1 = "Codigo";
            Campo2 = "descricao";
            Ctabela = "Maquina";
        }
        public override void DefaultValues()
        {
            maquina = DoAddline<Maquina>();
            status.SetStatusValue();
            base.DefaultValues();
        }
        public override void Save()
        {

            FillEntity(maquina);
            var xx = EF.Save(maquina);
            if (xx.ret < 0)
            {
                MsBox.Show(xx.msg, ScrollBars.Both);
            }
        }

        public override void PreencheCampos(DataTable dt, int i)
        {
            maquina = FillControls(maquina, dt, i);
        }
    }
}
