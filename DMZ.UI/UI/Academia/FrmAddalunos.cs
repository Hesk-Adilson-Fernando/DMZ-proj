using DMZ.BL.Classes;
using DMZ.Model.Model;
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
    public partial class FrmAddalunos : FrmClasse2
    {
        public FrmAddalunos()
        {
            InitializeComponent();
        }

        public Turma Turma { get; internal set; }
        public Turmadisc Disciplina { get; internal set; }
        public DataTable Professor { get; internal set; }
        public DataTable Alunos { get; internal set; }
        public DataTable DtTurmanota { get; internal set; }
        public DataTable dtAlunosInseridos { get; private set; }

        private void FrmAddalunos_Load(object sender, EventArgs e)
        {
            BindGrid();
            BindData();
            tbProfPrincipal.SqlComandText = $"select Pestamp,Nome from Turmadiscp where Ststamp ='{Disciplina.Ststamp.Trim()}'";
            tbProfauxiliar.SqlComandText = $"select Pestamp,Nome from Turmadiscp where Ststamp ='{Disciplina.Ststamp.Trim()}'";
            if (dtAlunosInseridos.HasRows())
            {
                tbProfPrincipal.tb1.Text = dtAlunosInseridos.RowZero("Profnome").ToString();
                tbProfPrincipal.Text2 = dtAlunosInseridos.RowZero("Pestamp").ToString();
                tbProfPrincipal.tb1.Text = dtAlunosInseridos.RowZero("Profnome2").ToString();
                tbProfPrincipal.Text2 = dtAlunosInseridos.RowZero("Pestamp2").ToString();
            }
            else if(Professor.HasRows())
            {
                tbProfPrincipal.tb1.Text = Professor.RowZero("nome").ToString();
                tbProfPrincipal.Text2 = Professor.RowZero("Pestamp").ToString();
                if (Professor.Rows.Count==2)
                {
                    tbProfPrincipal.tb1.Text = Professor.Rows[1]["nome"].ToString();
                    tbProfPrincipal.Text2 = Professor.Rows[1]["Pestamp"].ToString();
                }
            }
            tbCurso.Text = Turma.Descurso;
            tbDisciplina.Text = Disciplina.Disciplina;
            tbTurma.Text = Turma.Codigo;
            DtTurmanota = SQL.Initialize("Turmanota");

        }
        private void BindData()
        {
            if (dtAlunosInseridos.HasRows())
            {
                foreach (var dr in Alunos.AsEnumerable())
                {
                    if (dtAlunosInseridos.AsEnumerable().Any(x => x.Field<string>("Alunostamp").Equals(dr["Clstamp"].ToTrim())))
                    {
                        dr["Existe"] = true;
                    }
                    else
                    {
                        dr["Existe"] = false;
                    }
                }
                if (Alunos.CheckAny("Existe", false))
                {
                    Alunos = Alunos.GetCheckedRows("Existe", false);
                    gridUiAlunos.SetDataSource(Alunos);
                    tbTotalPorInserir.Text = gridUiAlunos.GetBindedTable().TotalRows() + " aluno(s)";
                }
                else
                {
                    gridUiAlunos = null;
                    tbTotalPorInserir.Text = @"0 aluno(s)";
                }
            }
            else
            {
                gridUiAlunos.SetDataSource(Alunos);
            }
        }

        private void BindGrid()
        {
            dtAlunosInseridos = SQL.GetGen2DT($"select no,AlunoNome,Turmanotastamp,Pestamp,Pestamp2,Alunostamp, cast(0 as bit) as ok,Profnome,Profnome2 from Turmanota  where turmastamp='{Turma.Turmastamp}' and Coddis='{Disciplina.Ststamp.Trim()}' and Pestamp='{Professor.RowZero("Pestamp")}'");
            gridUiAlInseridos.SetDataSource(dtAlunosInseridos);
            if (dtAlunosInseridos.HasRows())
            {
                tbTotal.Text = dtAlunosInseridos.TotalRows() + " aluno(s)";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            gridUiAlunos.Update();
            var tab = gridUiAlunos.GetBindedTable();
            if (tab.CheckAny("ok"))
            {
                var tabnova = tab.GetCheckedRows("ok");
                var dr = MsBox.Show("Deseja que o Software grave os alunos na tabela de lancamento de notas?", DResult.YesNo);
                if (dr.DialogResult != DialogResult.Yes) return;
                Helper.DoProgressProcess(tabnova, RecebeDados);
                BindGrid();
                UpdateAlunos();
            }
        }

        private void RecebeDados(DataRow r, bool fim)
        {
            var rw = DtTurmanota.NewRow().Inicialize();
            rw["Turmastamp"] = Turma.Turmastamp;
            rw["Alunostamp"] = r["Clstamp"];
            rw["AlunoNome"] = r["nome"];
            rw["No"] = r["no"];
            rw["Coddis"] = Disciplina.Ststamp;
            rw["Disciplina"] = Disciplina.Disciplina;
            rw["Anosem"] = Turma.Descanoaem;
            rw["Sem"] = Turma.Etapa;
            rw["Cursostamp"] = Turma.Cursostamp;
            rw["Pestamp"] = tbProfPrincipal.Text2;// Professor.Rows[0]["Pestamp"];
            rw["Profnome"] = tbProfPrincipal.tb1.Text;// Professor.Rows[0]["Nome"];
            rw["Pestamp2"] = tbProfauxiliar.Text2;// Professor.Rows[1]["Pestamp"];
            rw["Profnome2"] = tbProfauxiliar.tb1.Text;// Professor.Rows[1]["Nome"];
            DtTurmanota.Rows.Add(rw);
            //if (!SQL.CheckExist($"select Alunostamp from Turmanota where pestamp='{Professor.RowZero("Pestamp").ToTrim()}' and Turmastamp='{Turma.Turmastamp.Trim()}' and Coddis='{Disciplina.Ststamp.Trim()}'"))
            //{

            //}
            if (fim)
            {
                if (DtTurmanota.HasRows())
                {
                    SQL.Save(DtTurmanota, "Turmanota", true, "", "");
                }                
                MsBox.Show("Processo terminado com sucesso");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gridUiAlInseridos.Update();
            var tab = gridUiAlInseridos.GetBindedTable();
            if (tab.CheckAny("ok"))
            {
                var tabnova = tab.GetCheckedRows("ok");
                var dr = MsBox.Show("Deseja que o Software elimine o(s) aluno(s) seleçionado(s)?", DResult.YesNo);
                if (dr.DialogResult != DialogResult.Yes) return;
                Helper.DoProgressProcess(tabnova, RecebeDados2);
                BindGrid();
                UpdateAlunos();
            }
        }

        private void UpdateAlunos()
        {
            Alunos = SQL.GetGen2DT($"select * from turmal where turmastamp ='{Turma.Turmastamp}'");
            if (!Alunos.Columns.Contains("ok"))
            {
                Alunos.Columns.Add(new DataColumn("ok", typeof(bool)));
            }
            if (!Alunos.Columns.Contains("Existe"))
            {
                Alunos.Columns.Add(new DataColumn("Existe", typeof(bool)));
            }
            BindData();
        }

        private void RecebeDados2(DataRow r, bool fim)
        {
            if (r != null)
            {
                SQL.SqlCmd($"delete from Turmanota where Alunostamp ='{r["Alunostamp"].ToTrim()}' and Coddis = '{Disciplina.Ststamp}' and Anosem = '{Turma.Descanoaem.Trim()}' and pestamp='{r["Pestamp"].ToTrim()}'");
            }
            if (fim)
            {
                MsBox.Show("Dados eliminados com sucesso!");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            gridUiAlInseridos.CheckUncheckAll("Status", checkBox1.Checked);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            gridUiAlunos.CheckUncheckAll("ok", checkBox2.Checked);
        }

        private void btnUpdateProf_Click(object sender, EventArgs e)
        {
            gridUiAlInseridos.Update();
            var tab = gridUiAlInseridos.GetBindedTable();
            if (tab.CheckAny("ok"))
            {
                var tabnova = tab.GetCheckedRows("ok");
                var dr = MsBox.Show("Deseja que o Software actualize o(s) o Professor(s) aluno(s) Inseridos(s)?", DResult.YesNo);
                if (dr.DialogResult != DialogResult.Yes) return;
                Helper.DoProgressProcess(tabnova, RecebeDados3);
            }
        }
        private void RecebeDados3(DataRow r, bool fim)
        {
            if (r != null)
            {
                SQL.SqlCmd($@"update Turmanota set Pestamp='{tbProfPrincipal.Text2.Trim()}',
                       Profnome='{tbProfPrincipal.tb1.Text.Trim()}', 
                       Pestamp2='{tbProfauxiliar.Text2.Trim()}',
                       Profnome2='{tbProfauxiliar.tb1.Text.Trim()}',
                    where Alunostamp ='{r["Alunostamp"].ToTrim()}' and Coddis = '{Disciplina.Ststamp}' and Anosem = '{Turma.Descanoaem.Trim()}' and pestamp='{r["Pestamp"].ToTrim()}'");
            }
            if (fim)
            {
                MsBox.Show("Dados actualizados com sucesso!");
            }
        }
    }
}
