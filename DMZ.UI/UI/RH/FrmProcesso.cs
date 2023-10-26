using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Generic;
using System;
using System.Data;

namespace DMZ.UI.UI.RH
{
    public partial class FrmProcesso : FrmClasse
    {
        public FrmProcesso()
        {
            InitializeComponent();
        }
        private Processo processo;

        public Tdocpe TmpTdi { get; private set; }

        private void FrmProcesso_Load(object sender, EventArgs e)
        {
            try
            {
                Campo1 = "Numero";
                Campo2 = "nome";
                Ctabela = "PROCESSO";
                TmpTdi = SQL.GetRowToEnt<Tdocpe>(" defa=1 ");
                MultiDoc = true;
                SetValues(TmpTdi);
            }
            catch 
            {
                //
            }
        }
        public override void DefaultValues()
        {
            processo = DoAddline<Processo>();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(processo);
            EF.Save(processo);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            processo = FillControls(processo, dt, i);
        }

        private void btnTdi_Click(object sender, EventArgs e)
        {
            if (Procurou && Lista == null)
            {
                CallBrowdoc();
            }
            else
            {
                if (!Inserindo)
                {
                    EditMode = false;
                    Procurou = false;
                    CallBrowdoc();
                }
                else
                {
                    MsBox.Show("O formulário está em modo de edição. Porfavor Grave");
                }
            }
        }
        private void CallBrowdoc()
        {
            var bw = new Browdoc
            {
                Descricao = @"descricao",
                Sigla = @"sigla",
                Tabela = @"tdocpe",
                InnerJoin = "",
                BindTdoc = BindTdoc,
                Condicao = ""
            };
            bw.ShowForm(this, true);
        }

        public void BindTdoc(DataRow tdoc, bool origem = false)
        {
            if (tdoc == null) return;
            TmpTdi = tdoc.DrToEntity<Tdocpe>();
            SetValues(TmpTdi);
            Helper.ClearControls(this);
        }
        private void SetValues(Tdocpe tmpTdi)
        {
                                                                                                                                        label1.Text = tmpTdi.Descricao;
            try
            {
                CCondicao = $"numdoc={TmpTdi.Numdoc} and year(data) = {Pbl.SqlDate.Year}";
            }
            catch 
            {
                //
            }
        }
    }
}
