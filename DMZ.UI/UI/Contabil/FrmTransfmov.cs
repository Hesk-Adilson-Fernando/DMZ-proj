using System;
using System.Data;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Generic;

namespace DMZ.UI.UI.Contabil
{
    public partial class FrmTransfmov : FrmClasse2
    {
        public FrmTransfmov()
        {
            InitializeComponent();
        }

        private void FrmTransfmov_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = Pbl.AnoContabil();
            EditMode = true;
        }

        private void procura1_Load(object sender, EventArgs e)
        {

        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            var dr = MsBox.Show(Messagem.ParteInicial() + $"Deseja transferir movimentos da conta {tbOrigem.Text2},\r\nPara conta {tbdestino.Text2}", DResult.YesNo);
            if (dr.DialogResult != DialogResult.Yes) return;
            var condicaoAdicional = "";
            if (cbAno.cb1.Checked)
            {
                condicaoAdicional = $"and year(data)={numericUpDown1.Value}";
            }
            if (SQL.CheckExist($"select conta from ml where  conta ='{tbOrigem.Text2}' {condicaoAdicional}"))
            {
                var xx=SQL.SqlCmd($"update ml set conta ='{tbdestino.Text2}',descricao ='{tbdestino.tb1.Text}' where conta ='{tbOrigem.Text2.Trim()}' {condicaoAdicional}");
                if (xx <= 0) return;
                var movpgcsa = SQL.GetGen2DT($"select * from Pgcsa where conta ='{tbOrigem.Text2}' {condicaoAdicional}");
                if (movpgcsa?.Rows.Count>0)
                {
                    Helper.DoProgressProcess(movpgcsa,RecebeDados,"conta");
                }
            }
            else
            {
                MsBox.Show(Messagem.ParteInicial() + $"A conta {tbOrigem.Text2} não tem movimentos nas condições fornecidas!");
            }
        }

        private void RecebeDados(DataRow r, bool fim)
        {
            if (r != null)
            {
                SQL.SqlCmd($"INSERT INTO [dbo].[pgcsa]([pgcsastamp],[conta],[ano],[mes],[deb],[cre]) VALUES('{Pbl.Stamp()}',{tbdestino.Text2.Trim()},{r["ano"]},{r["mes"]},{r["deb"]},{r["cre"]})");
            }
            if (fim)
            {
                Helper.Alert("Processo executado com sucesso", Form_Alert.EnmType.Success);
            }
        }
    }
}
