using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Classes;

namespace DMZ.UI.UI.Contabil
{
    public partial class ParamIva : Basic.FrmClasse
    {
        private Apparam _apparam;
        private DataTable _dtconta;

        public ParamIva()
        {
            InitializeComponent();
        }

        private void ParamIva_Load(object sender, EventArgs e)
        {
            Campo1 = "conta";
            Campo2 = "descricao";
            Ctabela ="apparam";
            CCondicao = "origem ='IVA'";
        }
        public override void DefaultValues()
        {
            _apparam = DoAddline<Apparam>();

            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(_apparam);
            _apparam.Origem = "IVA";
            if (cbMensal.cb1.Checked)
            {
                _apparam.Tiposaldo = 1;
            }
            if (cbTrimestral.cb1.Checked)
            {
                _apparam.Tiposaldo = 2;
            }
            EF.Save(_apparam);
        }

        public override void PreencheCampos(DataTable dt, int i)
        {
            _apparam = FillControls(_apparam, dt, i);
        }

        private void cbMensal_CheckedChangeds()
        {
            cbTrimestral.Update(false);
        }

        private void cbTrimestral_CheckedChangeds()
        {
            cbMensal.Update(false);
        }
        private void gridProveitos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (gridlIQUIDADO.CurrentRow == null) return;
          var lista = new List<Ec>{new Ec{Conta=true,Nome="ClnConta2"},new Ec{Conta=false,Nome="descricao2"}};
           _dtconta = Ct.EditControl(gridlIQUIDADO.CurrentCell, e,lista);
        }

        private void gridProveitos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Ct.CellEndEdit(gridlIQUIDADO, _dtconta,new List<string>{"descricao2","clnconta2"});
        }
        private void gridCustos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (gridDEDUTIVEL.CurrentRow == null) return;
               var lista = new List<Ec>{new Ec{Conta=true,Nome="ClnConta"},new Ec{Conta=false,Nome="descricao"}};
               _dtconta = Ct.EditControl(gridDEDUTIVEL.CurrentCell, e,lista);
        }
        private void gridCustos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Ct.CellEndEdit(gridDEDUTIVEL, _dtconta,new List<string>{"descricao","clnconta"});
        }
    }
}
