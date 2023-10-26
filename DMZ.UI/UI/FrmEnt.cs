using System;
using System.Data;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Generic;
using DMZ.UI.Reports;

namespace DMZ.UI.UI
{
    public partial class FrmEnt : Basic.FrmClasse
    {
        private Ent _ent;

        public FrmEnt()
        {
            InitializeComponent();
        }

        private void FrmEnt_Load(object sender, EventArgs e)
        {
            Campo1 = "no";
            Campo2 = "nome";
            Ctabela = "ent";
        }
        public override void DefaultValues()
        {
            _ent = DoAddline<Ent>();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(_ent);
            EF.Save(_ent);
        }

        public override void PreencheCampos(DataTable dt, int i)
        {
            _ent = FillControls(_ent, dt, i);
        }

        private void btnTdi_Click(object sender, EventArgs e)
        {
            dmzContextMenuStrip1.ShowMenuStrip(btnTdi);
        }

        private void listagemDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FrmGenreport
            {
                Gendt = SQL.GetGen2DT("Select * from Ent"), Titulo = "Listagem de Fornecedores"
            };
            f.ShowForm(this);
        }
    }
}
