using System;
using System.Data;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Basic;

namespace DMZ.UI.UI
{
    public partial class FrmTdocpj : FrmClasse
    {
        private TdocPj _tdoc;
        public FrmTdocpj()
        {
            InitializeComponent();
        }

        private void FrmTdocpj_Load(object sender, EventArgs e)
        {

            Campo1 = "Numdoc";
            Campo2 = "descricao";
            Ctabela = "TdocPj";
        }
        public override void DefaultValues()
        {
            _tdoc = DoAddline<TdocPj>();
            base.DefaultValues();
        }
        public override void AfterSave()
        {
            if (cbPadrao.cb1.Checked)
            {
                SQL.SqlCmd($"update TdocPj set Defa=0 where TdocPjstamp<>'{CLocalStamp.Trim()}'");
            }
            base.AfterSave();
        }
        public override void Save()
        {
            FillEntity(_tdoc);
            EF.Save(_tdoc);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            _tdoc = FillControls(_tdoc, dt, i);
        }
    }
}
