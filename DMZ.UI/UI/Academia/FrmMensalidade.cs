using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using System;
using System.Data;
using System.Windows.Forms;

namespace DMZ.UI.UI.Academia
{
    public partial class FrmMensalidade : Basic.FrmClasse2
    {
        private Fact _ft;

        public DataTable dt { get; private set; }
        public DataTable dtpar { get; private set; }
        public Tdoc TmpTdoc { get; private set; }
        public DataRowView drTurma { get; private set; }
        public DataRowView drEntRef { get; private set; }//Representa Entidade referencia 
        public string Planopagstamp { get; private set; }
        private void btnProcess_Click(object sender, EventArgs e)
        {
            //

            gridUiAlunos.Update();
            var dr = MsBox.Show("Deseja que o Software Crie automaticame as mensalidades de alunos segundo o plano indicado?", DResult.YesNo);
            if (dr.DialogResult != DialogResult.Yes) return;
                dtpar = SQL.GetGen2DT($"select Data,ValorTotal,Parecela,descricao,Planopagpstamp from Planopagp where Planopagstamp='{cbPlanopag.SelectedValue.ToTrim()}' order by Parecela");
            if (dtpar.HasRows())
            {
                drEntRef = cbEntidade.SelectedItem as DataRowView;
                Helper.DoProgressProcess(dt, RecebeDados);
            }
            else
            {
                MsBox.Show("O plano indicado não tem parcelas criadas, porfavor verifica!");
            }
        }
        public FrmMensalidade()
        {
            InitializeComponent();
        }

        private void FrmMensalidade_Load(object sender, EventArgs e)
        {
            var dtTurma = SQL.GetGen2DT("select Turmastamp,Descricao,Codigo,Descanoaem,Descurso,Cursostamp,Etapa from turma where Descanoaem=(select AnoSem from param ) order by Descanoaem");
            BindCombo(cbTurma, dtTurma);
            var dtEntidade = SQL.GetGen2DT("select Contasstamp,Entidadebanc from Contas where Entidadebanc <>''");
            BindCombo(cbEntidade, dtEntidade);
            var dtPlano = SQL.GetGen2DT("select Planopagstamp,Descricao from Planopag where Descanosem =(select AnoSem from param )");
            BindCombo(cbPlanopag, dtPlano);
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            var xxx = $@"select no,Nome,Clstamp,Turmastamp,cast(0 as bit) as processado from Turmal where Turmastamp ='{cbTurma.SelectedValue.ToTrim()}'";
             dt = SQL.GetGen2DT(xxx);
            if (dt.HasRows())
            {
                Planopagstamp = cbPlanopag.SelectedValue.ToString();
                drTurma = cbTurma.SelectedItem as DataRowView;
                foreach (var row in dt.AsEnumerable())
                {
                    if (SQL.CheckExist($"select no from fact where Numinterno='{Planopagstamp.Trim()}' and Clstamp='{row["Clstamp"].ToTrim()}' and Anosem='{drTurma["Descanoaem"].ToString().Trim()}'"))
                    {
                        row["processado"] = true;
                    }
                    else
                    {
                        row["processado"] = false;
                    }
                }
                if (dt.CheckAny("processado",false))
                {
                    dt = dt.GetCheckedRows("processado", false);
                    TmpTdoc = SQL.GetRowToEnt<Tdoc>("ft=1");
                    gridUiAlunos.SetDataSource(dt);
                    tbTotal.Text = $"{dt?.Rows.Count + " alunos"}";
                }
                else
                {
                    gridUiAlunos.DataSource = null;
                    MsBox.Show("Nenhum aluno(a) encontrado(a) nas condições indicaddas!");
                }
            }
        }
        private void BindCombo(ComboBox cb, DataTable dt)
        {
            cb.DataSource = dt;
            cb.DisplayMember = dt.Columns[1].ToString();
            cb.ValueMember = dt.Columns[0].ToString();
        }
        private void RecebeDados(DataRow r, bool fim)
        {
            var cl = SQL.GetRowToEnt<Cl>($"clstamp='{r["Clstamp"].ToString().ToTrim()}'");
            foreach (var item in dtpar.AsEnumerable())
            {
                if (item!=null)
                {
                    _ft = Utilities.DoAddline<Fact>();
                    HelperFact.FillFactura(_ft, cl, item["Data"].ToDateTimeValue(), TmpTdoc, drEntRef, drTurma, Planopagstamp);
                    var ftl = SQL.Initialize("factl");
                    var dr = ftl.NewRow().Inicialize();
                    HelperFact.FillFactl(item, dr, _ft.Factstamp);
                    ftl.Rows.Add(dr);
                    HelperFact.TotaisFt(_ft, ftl);
                    if (EF.Save(_ft).ret > 0)
                    {
                        SQL.Save(ftl, "factl", true, _ft.Factstamp, "fact");
                    }
                }
            }
            if (fim)
            {
                MsBox.Show("Processo terminado com sucesso");
            }
        }
    }
}
