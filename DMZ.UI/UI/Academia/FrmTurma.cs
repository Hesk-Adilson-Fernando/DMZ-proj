using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using DMZ.UI.Reports;
using DMZ.UI.UI.RH;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace DMZ.UI.UI.Academia
{
    public partial class FrmTurma : FrmClasse
    {
        public FrmTurma()
        {
            InitializeComponent();
        }

        private void FrmTurma_Load(object sender, EventArgs e)
        {
            Campo1 = "Codigo";
            Campo2 = "Descricao";
            Ctabela = "Turma";
        }
        private Turma turma;
        public override void DefaultValues()
        {
            turma = DoAddline<Turma>();
            status.SetStatusValue();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(turma);
            EF.Save(turma);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            turma = FillControls(turma, dt, i);
            BindProfessores();
            BindTurmas();
            tbTotal.Text = gridUiAlunos.GetBindedTable().TotalRows() + " aluno(s)";
        }

        private void BindTurmas()
        {
            if (!CLocalStamp.IsNullOrEmpty())
            {
                var str = $@"select Codigo,Descricao,Horariostamp from Horario  where Turmastamp = '{CLocalStamp.Trim()}' order by Descricao ";
                var dt = SQL.GetGen2DT(str);
                if (dt.HasRows())
                {
                    gridUiHorarios.SetDataSource(dt);
                }
            }
        }

        private void BindProfessores()
        {
            if (!CLocalStamp.IsNullOrEmpty())
            {
                var str = $@"select Nome,disciplina=(select descricao from st where st.Ststamp=Turmadiscp.Ststamp),pestamp,
                                        Turmastamp from Turmadiscp join Turmadisc
                                        on Turmadisc.Turmadiscstamp = Turmadiscp.Turmadiscstamp where Turmastamp = '{CLocalStamp.Trim()}' order by nome ";
                var dt = SQL.GetGen2DT(str);
                if (dt.HasRows())
                {
                    gridUiProfessores.SetDataSource(dt);
                }
                tbTotalProf.Text = $"{dt.TotalRows() + " professor(es)"}";
            }
        }

        private void tbCurso_RefreshControls()
        {
            tbPlano.Condicao = $"Cursostamp='{tbCurso.Text2.Trim()}'";
        }

        private void tbPlano_RefreshControls()
        {
            //tbEtapas.Condicao = $"Gradestamp='{tbPlano.Text2.Trim()}'";
            //BindDisciplinas();
        }

        private void tbEtapas_RefreshControls()
        {
           // BindDisciplinas();
        }


        private void gridUiDisciplinas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var nome = gridUiDisciplinas.CurrentCell.OwningColumn.Name.ToLower().Trim();
            var discstamp = gridUiDisciplinas.CurrentRow.Cells["ststamp"].Value.ToString();
            if (nome.Equals("disc"))
            {
                var w = new FrmDisc();
                w.ShowForm(this);
                var tab = SQL.GetGen2DT($"select * from st where ststamp='{discstamp.ToTrim()}'");
                w.PreencheCampos(tab, 0);
                w.Procurou = true;
            }
            if (nome.Equals("addprof"))
            {
                if (Procurou)
                {
                    var Turmadiscstamp = gridUiDisciplinas.CurrentRow.Cells["Turmadiscstamp1"].Value.ToString();
                    var w = new FrmAddProf
                    {
                        Turmadiscstamp1 = Turmadiscstamp,//
                        Ststamp1 = discstamp,
                        Turmastamp = CLocalStamp
                    };
                    w.ShowForm(this);
                    w.gridPanel21.label1.Text = gridUiDisciplinas.CurrentRow.Cells["clndisc"].Value.ToString();
                }
                else
                {
                    MsBox.Show("Deve gravar os dados da turma primeiro!");
                }
            }

            if (nome.Equals("addalunos"))
            {
                if (Procurou)
                {
                    var alunos = gridUiAlunos.GetBindedTable();
                    if (!alunos.Columns.Contains("ok"))
                    {
                        alunos.Columns.Add(new DataColumn("ok", typeof(bool)));
                    }
                    if (!alunos.Columns.Contains("Existe"))
                    {
                        alunos.Columns.Add(new DataColumn("Existe", typeof(bool)));
                    }
                    var disc = gridUiDisciplinas.CurrentRow.ToDataRow().DrToEntity<Turmadisc>();
                    var prof = SQL.GetGen2DT($"select * from Turmadiscp where Ststamp ='{disc.Ststamp.Trim()}'");
                    if (alunos.HasRows())
                    {
                        if (prof.HasRows())
                        {
                            if (alunos.HasRows())
                            {
                                var w = new FrmAddalunos
                                {
                                    Turma = turma,
                                    Disciplina = disc,
                                    Professor = prof,
                                    Alunos = alunos
                                };
                                w.ShowForm(this);
                            }
                            else
                            {
                                MsBox.Show("Não tem alunos associados a essa turma, Porfavor associe alunos na outra página");
                            }
                        }
                        else
                        {
                            MsBox.Show($"Deve indicar o(s) prfessor(es) {disc.Disciplina} primeiro!");
                        }
                    }
                }
                else
                {
                    MsBox.Show("Deve gravar os dados da turma primeiro!");
                }
            }
        }

        private bool gridPanel22_BeforeAddLineEvent()
        {
            if (!checkBox1.cb1.Checked)
            {
                if (!tbPlano.Text2.IsNullOrEmpty() && !tbEtapas.tb1.Text.IsNullOrEmpty())
                {



                    var f = new FrmSelect
                    {
                        SelectCampos = "Ststamp,Coddisc,Displina",
                        HideFirstColumn = true,
                        Tamanhos = new List<decimal>() { 0, 105, 150 },
                        ColFillName = "Displina",
                        Tabela = "Gradel",
                        Condicao = $"Gradestamp='{tbPlano.Text2.Trim()}' and Etapa='{tbEtapas.tb1.Text.Trim()}'",
                        SendData = ReceiveInfo
                    };
                    f.ShowDialog();
                }
            }
            else if (checkBox1.cb1.Checked)
            {
                var f = new FrmSelect
                {
                    SelectCampos = "Ststamp,Coddisc,Displina",
                    HideFirstColumn = true,
                    Tamanhos = new List<decimal>() { 0, 105, 150 },
                    ColFillName = "Displina",
                    Tabela = "Gradel",
                    Condicao = $"Gradestamp='{tbPlano.Text2.Trim()}'",
                    SendData = ReceiveInfo
                };
                f.ShowDialog();
            }
            return true;
        }
        private void ReceiveInfo(DataTable dt)
        {
            if (dt.HasRows())
            {
                foreach (var row in dt.AsEnumerable())
                {
                    if (!row.DataRowIsNull())
                    {
                        gridUiDisciplinas.AddLine();
                        gridUiDisciplinas.DataRowr["Turmastamp"] =CLocalStamp;
                        gridUiDisciplinas.DataRowr["Ststamp"] = row["Ststamp"];
                        gridUiDisciplinas.DataRowr["Referenc"] = row["Coddisc"];
                        gridUiDisciplinas.DataRowr["Disciplina"] = row["Displina"];
                    }
                }
                gridUiDisciplinas.Update();
            }
        }

        private bool gridPanel21_BeforeAddLineEvent()
        {
            if (!tbCurso.Text2.IsNullOrEmpty())
            {
                var dt = SQL.GetGen2DT($"SELECT DISTINCT Nome,No, cast(0 as bit) as ok,Clstamp from Fact where Inscricao=1 and Anosem=(select AnoSem from Param) and Cursostamp='{tbCurso.Text2.Trim()}' order by nome");
                var f = new FrmGetData
                {
                    Dt = dt,
                    SendData = Receivedata
                };
                f.label1.Text = "Lista de alunos";
                f.InvertColunas = true;
                f.ShowForm(this);

            }
            return true;
        }

        private void Receivedata(DataTable dt)
        {
            if (dt.HasRows())
            {
                var ms = "";
                foreach (var row in dt.AsEnumerable())
                {
                    if (row != null)
                    {
                        if (!SQL.CheckExist($"select clstamp from turmal where Turmastamp='{CLocalStamp.Trim()}' and Clstamp='{row["Clstamp"].ToString().Trim()}'"))
                        {
                            gridUiAlunos.AddLine();
                            gridUiAlunos.DataRowr["Turmastamp"] = CLocalStamp;
                            gridUiAlunos.DataRowr["Clstamp"] = row["Clstamp"];
                            gridUiAlunos.DataRowr["No"] = row["No"];
                            gridUiAlunos.DataRowr["Nome"] = row["Nome"];
                        }
                        else
                        {
                            if (ms.IsNullOrEmpty())
                            {
                                ms = $"\r\nO(s) seguinte(s) aluno(s) já existia(m) na turma:\r\n{row["Nome"]}";
                            }
                            else
                            {
                                ms= $"{ms} \r\n{row["Nome"]}";
                            }
                        }
                    }
                }
                gridUiAlunos.Update();
                if (!ms.IsNullOrEmpty())
                {
                    ms = $"{ms} \r\nNão foram inseridos";
                    MsBox.Show(ms,ScrollBars.Both);
                }
            }
        }

        private void gridUiHorarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Helper.ShowForm<FrmHorario>(gridUiHorarios, this, "horario", "hstamp", "origem3");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MenuPrint.ShowMenuStrip(btnPrint);
        }

        private void ImprimirListagem(string reportname, string origem)
        {
            if (Inserindo)
            {
                FillEntity(turma);
            }
            DS ds = new DS();
            var alunos = gridUiAlunos.GetBindedTable();
            var XmlString = SQL.GetXmlReport(reportname.Trim());
            Utilities.AllTrim(turma);
            var ret = Imprimir.FillData(turma.ToDataTable(), alunos, null, ds.Turma, null);
            ret.dtPrint = ret.dtPrint.DefaultView.ToTable();
            Imprimir.CallForm(ret.dtPrint, ret.fp, CLocalStamp, Inserindo, label1.Text, "",reportname, origem, this, XmlString, true, ds, "", "");
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            ImprimirListagem("RptTurma", "");//"Turma"
        }

        private void nToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImprimirListagem("RptTurmah", "Turma");
        }

        private void gridUiAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Helper.ShowForm<FrmAluno>(gridUiAlunos, this, "cl", "cstamp", "ori");
        }

        private void gridUiProfessores_CellClick(object sender,DataGridViewCellEventArgs e)
        {
            Helper.ShowForm<FrmPes>(gridUiProfessores, this,"pe", "profstamp", "origemm");
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_Load(object sender, EventArgs e)
        {

        }
    }
}
