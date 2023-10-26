using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Basic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMZ.UI.UI.Academia
{
    public partial class FrmTdocMat : FrmClasse
    {
        public FrmTdocMat()
        {
            InitializeComponent();
        }
        private TdocMat _TdocMat;
        private void FrmTdocMat_Load(object sender, EventArgs e)
        {
            Campo1 = "Numdoc";
            Campo2 = "descricao";
            Ctabela = "TdocMat";
        }

        public override void AfterSave()
        {
            if (cbPadrao.cb1.Checked)
            {
                SQL.SqlCmd($"update TdocMat set Defa=0 where TdocMatstamp<>'{CLocalStamp.Trim()}'");
            }
            base.AfterSave();
        }

        public override void DefaultValues()
        {
            _TdocMat = DoAddline<TdocMat>();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(_TdocMat);
            var dd = _TdocMat.Matricula;

            var ckd = cbDefault1.cb1.Checked;
            EF.Save(_TdocMat);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            _TdocMat = FillControls(_TdocMat, dt, i);
        }
        public DataTable DtCcu { get; set; }
    }
}
