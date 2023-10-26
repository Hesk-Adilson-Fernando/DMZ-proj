using System;
using System.Data;
using DMZ.BL.Classes;
using DMZ.Model.Model;

namespace DMZ.UI.UI
{
    public partial class FrmVt : Basic.FrmClasse
    {
        private St _st;

        public FrmVt()
        {
            InitializeComponent();
        }

        public bool Origem { get; set; }
        public override void DefaultValues()
        {
            _st = DoAddline<St>();
            
            if (Origem)
            {
                _st.Trailer = true;
            }
            else
            {
                _st.Viatura = true;
            }
            base.DefaultValues();
        }
        public override void Gravar()
        {
            FillEntity(_st);
            SQLExec.Save(_st);
        
        }


        public override void PreencheCampos(DataTable dt, int i)
        {
            _st = FillControls(_st, dt, i);
        }
        private void btnMenuLateral_Click(object sender, EventArgs e)
        {
            dmzContextMenuStrip1.ShowMenuStrip(btnMenuLateral);
        }

        private void FrmVtTrailer_Load(object sender, EventArgs e)
        {
            tbDescricao.ToUpperCase = true;
            tbReferenc.ToUpperCase = true;
            Campo1 = "Referenc";
            Campo2 = "descricao";
            Ctabela = "St";
            //tabControl1.Controls.Remove(tabPageInicio);
            tabControl1.Controls.Remove(tabPageArm);
            tabControl1.Controls.Remove(tabPageCont);
            //label1.Text = "Cadastro de Viaturas";
            CCondicao = Origem ? "Trailer=1" : "Viatura=1";
        }
    }
}
