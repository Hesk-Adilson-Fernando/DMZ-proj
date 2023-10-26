using System;
using System.Data;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.Model.Model;

namespace DMZ.UI.UI.Academia
{
    public partial class FrmFeriado : Basic.FrmClasse
    {
        private Feriado _disc;

        public FrmFeriado()
        {
            InitializeComponent();
        }

        private void FrmFeriado_Load(object sender, EventArgs e)
        {
            Campo1 = "Codigo";
            Campo2 = "Descricao"; 
            Ctabela = "Feriado";
            CCondicao = "";
            GetFeriados();
            dtDefault1.dt1.Format = DateTimePickerFormat.Custom;
            // Display the date as "Mon 27 Feb 2012".  
            dtDefault1.dt1.CustomFormat = "dd/MM";
        }

        private void GetFeriados()
        {
            //var dt = SQL.GetGen2DT("select data,descricao from feriados");
            //gridUi2.DataSource = null;
            //gridUi2.AutoGenerateColumns = false;
            //gridUi2.DataSource = dt;
        }

        public override void DefaultValues()
        {
            _disc = DoAddline<Feriado>();
            base.DefaultValues();
            
        }
        public override void Save()
        {
            FillEntity(_disc);
            EF.Save(_disc);
            GetFeriados();
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            _disc = FillControls(_disc, dt, i);
        }

    }
}
