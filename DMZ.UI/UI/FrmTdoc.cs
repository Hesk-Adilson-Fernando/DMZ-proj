using System;
using System.Data;
using DMZ.BL.Classes;
using DMZ.Model.Model;

namespace DMZ.UI.UI
{
    public partial class FrmTdoc : Basic.FrmClasse
    {
        public FrmTdoc()
        {
            InitializeComponent();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
        private Tdoc _tdoc;
        private void FrmTdoc_Load(object sender, EventArgs e)
        {
            Campo1 = "Numdoc";
            Campo2 = "descricao";
            Ctabela = "tdoc";
        }

        public override void AfterSave()
        {
            if (cbPadrao.cb1.Checked)
            {
                SQL.SqlCmd($"update Tdoc set Defa=0 where Tdocstamp<>'{CLocalStamp.Trim()}'");
            }
            base.AfterSave();
        }

        public override void DefaultValues()
        {
            _tdoc = DoAddline<Tdoc>();
            base.DefaultValues();
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
        public void ReceiveData(DataTable dt)
        {
            //Helper.UpdateGridModulos(gridUi1,"tdistamp",dt,CLocalStamp);
            //foreach (var r in dt.AsEnumerable())
            //{
            //    if (r == null) continue;
            //    gridUi1.AddLine();
            //    var index = gridUi1.Rows.Count - 1;
            //    gridUi1.Rows[index].Cells[0].Value = r[0];
            //    gridUi1.Rows[index].Cells[1].Value = r[1];
            //}
            //gridUi1.Update();
        }
        public DataTable DtCcu { get; set; }

    }
}
