using DMZ.BL.Classes;
using DMZ.Model.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DMZ.UI.IMB
{
    public partial class FrmImbauxiliar : DMZ.UI.Basic.FrmClasse
    {
        public FrmImbauxiliar()
        {
            InitializeComponent();
        }
        private Imbauxiliar _auxiliar;

        public string Desctabela { get;  set; }
        public decimal Tabela { get;  set; }
        public bool Height2 { get; set; }
        private void FrmImbauxiliar_Load(object sender, EventArgs e)
        {
            Campo1 = "codigo";
            Campo2 = "descricao";
            Ctabela = "Auxiliar";
            CCondicao = $"tabela={Tabela}";
            label1.Text = Desctabela;
            if (Tabela==2)
            {
                tbObs.label1.Text = "Sigla";
            }
            barraText1.Label1Text = $"Dados de {Desctabela}";
            if (!Height2)
            {
                Height = 290;
            }
            else
            {
                Height = 462;
            }
            gridPanel21.label1.Text = Caption;
        }

        public string Caption { get; set; }

        public override void DefaultValues()
        {
            _auxiliar = DoAddline<Imbauxiliar>();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(_auxiliar);
            _auxiliar.Desctabela = Desctabela;
            _auxiliar.Tabela = Tabela;
            EF.Save(_auxiliar);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            _auxiliar = FillControls(_auxiliar, dt, i);
        }
    }
}
