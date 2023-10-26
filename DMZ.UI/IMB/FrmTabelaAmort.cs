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

namespace DMZ.UI.IMB
{
    public partial class FrmTabelaAmort : FrmClasse
    {
        public FrmTabelaAmort()
        {
            InitializeComponent();
        }
        private TabelaAmort _cl;
        private void FrmCodamort_Load(object sender, EventArgs e)
        {
            Campo1 = "codigo";
            Campo2 = "descricao"; 
            Ctabela = "TabelaAmort";         
        }
        public override void DefaultValues()
        {
            _cl = DoAddline<TabelaAmort>();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(_cl);
            EF.Save(_cl);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            _cl = FillControls(_cl, dt, i);
        }
    }
}
