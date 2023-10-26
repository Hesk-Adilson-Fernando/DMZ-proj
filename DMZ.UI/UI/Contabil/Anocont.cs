using System;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.UI.Classes;
using DMZ.UI.Generic;

namespace DMZ.UI.UI.Contabil
{
    public partial class Anocont : Basic.FrmClasse2
    {
        public Anocont()
        {
            InitializeComponent();
        }
        public Action SAno { get;  set; }
        public object UpdateAno { get; set; }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            var dr = MsBox.Show(@"Deseja mudar de ano para: " + AnoDesejado.Value+@"?",DResult.YesNo);
            if (dr.DialogResult != DialogResult.Yes) return;
            var existe = SQL.CheckExist($"select top 1 ano from Pgc where ano ={AnoDesejado.Value}");
            if (existe)
            {
                MsBox.Show($"Desculpe mas não existe plano de contas para o ano {AnoDesejado.Value}!. \r\nO Software recomenda que copie contas para o ano desejado ");
            }
            var res= SQL.SqlCmd($"update param set ano ={AnoDesejado.Value} ");
            if (res != 1) return;
            MsBox.Show(@"Ano alterado com sucesso! ");
            SAno();
        }

        private void Anocont_Load(object sender, EventArgs e)
        {
            AnoDesejado.Value = Pbl.AnoContabil() + 1;
            AnoCorrente.Value= Pbl.AnoContabil();
        }
    }
}
