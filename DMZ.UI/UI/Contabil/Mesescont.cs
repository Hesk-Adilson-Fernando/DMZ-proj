using System;
using System.Data;
using DMZ.BL.Classes;
using DMZ.Model.Model;

namespace DMZ.UI.UI.Contabil
{
    public partial class Mesescont : Basic.FrmClasse
    {
        private Mescont _Mescont;

        public Mesescont()
        {
            InitializeComponent();
        }

        private void Mescont_Load(object sender, EventArgs e)
        {
            Ctabela = "mescont";
            Campo1 = "codigo";
            Campo2 = "nomemes";
            PopulateGrid();
        }
        private void PopulateGrid()
        {
            MescontDtTable = new DataTable();
            MescontDtTable = SQL.GetGenDT("mescont", "order by convert(numeric,codigo)", "*");
            //PassData2(MescontDtTable, 0);
            dgvMeses.DataSource = null;
            dgvMeses.AutoGenerateColumns = false;
            dgvMeses.DataSource = MescontDtTable;
            Procurou = true;
        }

        public DataTable MescontDtTable { get; set; }

        public override void DefaultValues()
        {
            _Mescont = DoAddline<Mescont>();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(_Mescont);
            EF.Save(_Mescont);
            PopulateGrid();
        }

        public override void PreencheCampos(DataTable dt, int i)
        {
            _Mescont = FillControls(_Mescont, dt, i);
        }

    }
}
