using DMZ.BL.Classes;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DMZ.UI.UI.Academia
{
    public partial class FrmCart : Basic.FrmClasse2
    {
        private DataTable dt;
        private DataTable dtClcart;

        public FrmCart()
        {
            InitializeComponent();
        }

        private void dtEmissao_ValueChanged(object sender, EventArgs e)
        {
            if (!tbAnos.Text.IsNullOrEmpty())
            {
                var anos = tbAnos.Text.ToDecimal().ToInt();
                var data = new DateTime(dtEmissao.Value.Year + anos, dtEmissao.Value.Month, dtEmissao.Value.Day);
                dtValidade.Value = data;
            }
            else
            {
                MsBox.Show("Deve indicar anos de duração");
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmCart_Load(object sender, EventArgs e)
        {
            tbAnos.Text = "5";
            dt = SQL.GetGen2DT(@"select * from (
                                    select No, nome, cl.Clstamp, isnull(Datavenc, '1900-01-01') Datavenc, cast(0 as bit) ok from
                                    cl left join ClCart on cl.Clstamp = ClCart.Clstamp where Aluno = 1 )tmp1 where tmp1.Datavenc <= GETDATE()");
            gridUiAlunos.SetDataSource(dt);
            dtClcart = SQL.Initialize("ClCart");
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            gridUiAlunos.Update();
            var dr = MsBox.Show("Deseja que o Software emite Cartões de alunos seleçionados?", DResult.YesNo);
            if (dr.DialogResult != DialogResult.Yes) return;
            if (dt.AsEnumerable().Any(x => x.Field<bool>("ok").Equals(true)))
            {
                dt = dt.AsEnumerable().Where(x => x.Field<bool>("ok").Equals(true)).CopyToDataTable();
                Helper.DoProgressProcess(dt, RecebeDados);
            }
            else
            {
                MsBox.Show("Porfavor deve selecionar a(s) linha(s) que pretende processar!");
            }
        }


        private void RecebeDados(DataRow r, bool fim)
        {
            var rw = dtClcart.NewRow().Inicialize();
            rw["Clstamp"] = r["Clstamp"];
            rw["Codigo"] = r["no"].ToString().Trim()+dtEmissao.Value.Year.ToString().GetLast(2)+dtValidade.Value.Year.ToString().GetLast(2);
            rw["Data"] = dtEmissao.Value;
            rw["Datavenc"] = dtValidade.Value;
            dtClcart.Rows.Add(rw);
            if (fim)
            {
                if (dtClcart.HasRows())
                {
                    SQL.Save(dtClcart, "ClCart", true, "", "");
                }
                MsBox.Show("Processo terminado com sucesso");
            }
        }
        private void tbProcura_TextChanged(object sender, EventArgs e)
        {
            Helper.UpdateGrid(false, gridUiAlunos, dt, tbProcura.Text);
        }

        private void cbDefault1_CheckedChangeds()
        {
            gridUiAlunos.CheckUncheckAll("sel", cbDefault1.cb1.Checked);
        }
    }
}
