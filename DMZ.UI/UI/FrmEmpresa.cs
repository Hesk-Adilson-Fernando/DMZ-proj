using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Classes;
using DMZ.UI.Generic;

namespace DMZ.UI.UI
{
    public partial class FrmEmpresa : Basic.FrmClasse
    {
        private Empresa _empresa;
        private string _xmlPath;

        public FrmEmpresa()
        {
            InitializeComponent();
        }

        private void FrmEmpresa_Load(object sender, EventArgs e)
        {
            Campo1 = "codigo";
            Campo2 = "nome";
            Ctabela = "empresa";
            CallEmpresa();
        }

        private void CallEmpresa()
        {
           // var emp = SQL.GetGen2DT("select * from empresa");
            PreencheCampos(Pbl.Empresa.ToDataTable(),0);
            Procurou=true;
        }

        public override void DefaultValues()
        {
            _empresa = DoAddline<Empresa>();
            base.DefaultValues();
        }

        public override void Save()
        {
            FillEntity(_empresa);
            EF.Save(_empresa);
        }

        public override void AfterSave()
        {
            SQL.SqlCmd("delete from UsrModulo where Codigo not in(select sigla from EmpresaMod)");
            Pbl.Empresa = _empresa;
            base.AfterSave();
        }

        public override void PreencheCampos(DataTable dt, int i)
        {
            _empresa = FillControls(_empresa, dt, i);
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            var dr = MsBox.Show("Deseja importar os modulos licenciados?..", DResult.YesNo);
            if (dr.DialogResult != DialogResult.Yes) return;
            SQL.SqlCmd("delete from empresamod ");
            if (gridModulos.Rows.Count > 0)
            {
                var dt = gridModulos.DataSource as DataTable;
                if (dt?.Rows.Count > 0)
                {
                    dt.Rows.Clear();
                    gridModulos.DataSource = null;
                    gridModulos.DataSource = dt;
                    gridModulos.Update();
                }
            }
            Helper.GetModulos(gridModulos);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
