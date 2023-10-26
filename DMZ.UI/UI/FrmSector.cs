using System;
using System.Data;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Basic;
using DMZ.UI.Generic;

namespace DMZ.UI.UI
{
    public partial class FrmSector : FrmClasse
    {
        private Sector _sector;

        public FrmSector()
        {
            InitializeComponent();
        }

        private void FrmSector_Load(object sender, EventArgs e)
        {
            Campo1 = "codigo";
            Campo2 = "descricao";
            Ctabela = "sector";
        }
        public override void DefaultValues()
        {
            _sector = DoAddline<Sector>();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(_sector);
            EF.Save(_sector);
        }

        public override void PreencheCampos(DataTable dt, int i)
        {
            _sector = FillControls(_sector, dt, i);
        }

        private void gridPanel21_CallForm()
        {
            var f = new FrmSelect
            {
                SelectCampos = " nome,clstamp ", SendData = ReceiveData, Tabela = "cl", Condicao = @" pos=1 and Clstamp not in (select Mesasstamp from  SectMesas) order by nome "
            };
            f.ShowForm(this);
        }

        private void ReceiveData(DataTable dt)
        {
            var dtMesas = gridUi1.DataSource as DataTable;
            foreach (var r in dt.AsEnumerable())
            {
                if (dtMesas == null) continue;
                var row = dtMesas.NewRow();
                row["Mesasstamp"] = r["clstamp"];
                row["descricao"] = r["nome"];
                row["Sectmesasstamp"] = Pbl.Stamp();
                row["Sectorstamp"] = CLocalStamp;
                dtMesas.Rows.Add(row);
            }
        }
    }
}
