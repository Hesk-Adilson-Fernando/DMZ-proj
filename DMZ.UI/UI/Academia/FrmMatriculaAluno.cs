using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using DMZ.UI.Reports;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;

namespace DMZ.UI.UI.Academia
{
    public partial class FrmMatriculaAluno : FrmClasse
    {
        public FrmMatriculaAluno()
        {
            InitializeComponent();
        }
        MatriculaAluno _matriculaAluno;
        public Cl Cl { get; set; }
        public List<Usracessos> ListaUsracessos { get; set; }
        public bool BeforeClick { get; set; }
        private DataTable DtTurma { get; set; }
        public DataRow DataRow { get; set; }
        public DataTable DtMatC { get; set; }
        public Tdoc TmpTdoc { get; set; }
        public DataRowView DtEntidade { get; set; }
        public string Numinterno { get; set; }
        public DataRowView Dtv { get; set; }
        public TdocMat TmpTdocMat { get; set; }
        string Planostamp { get; set; }

        public bool ExameEpecial { get; set; } = false;
        private void FrmMatriculaAluno_Load(object sender, EventArgs e)
        {
            gridPanel21.btnGravar.Visible = gridPanel21.button2.Visible =
                panel7.Visible= gridPanel21.btnNovo.Visible = false;
            btnCancActivaMatri.Text = lblMsg.Text = string.Empty;
            Campo1 = "Numero";
            Campo2 = "nome";
            Ctabela = "MatriculaAluno";
            var dataTable = SQL.GetGenDT("select Contasstamp,Entidadebanc from Contas where Entidadebanc <>''");
            BindCombo(cbEntidade, dataTable);
            var dtPlano = DtPlano();
            panel7.Visible = false;
            if (tabControl1.TabPages.Count > 1)
            {
                tabControl1.TabPages.Remove(tabPage4);
            }
            groupBox5.Location = new System.Drawing.Point(525, 154);
            btnGerarTaxaExameEspecial.Visible=false;
            if (ExameEpecial)
            {
                TmpTdocMat = SQL.GetRowToEnt<TdocMat>("defa=1");
                btnTdi.Visible=false;
                panel8.Visible=false;
                //btnGerarTaxaExameEspecial.Location = new System.Drawing.Point(3, 18);
                btnGerarTaxaExameEspecial.Visible=true;
            }
            else
            {
                TmpTdocMat = SQL.GetRowToEnt<TdocMat>("matricula=1");
            }
            if (TmpTdocMat!=null)
            {
                label1.Text=TmpTdocMat.Descricao;
                CCondicao = $"numdoc={TmpTdocMat.Numdoc} and year(data) = {Pbl.SqlDate.Year}";
            }
            btnDelete.Visible=false;
        }

        private DataTable DtPlanoPagmento { get; set; }
        private DataTable DtPlano()
        {

            var dtPlano = SQL.GetGenDT($@"select Planopagstamp,Descricao,descanosem,Cursostamp,AnoSemstamp,DataFim,Datapartida  
from Planopag ");
            BindCombo(cbPlanopag, dtPlano);
            DtPlanoPagmento = dtPlano;
            RebindPlanoPlag();
            return dtPlano;
        }

        private void RebindPlanoPlag()
        {
            var dt = new DataTable();
            try
            {

                dt=DtPlanoPagmento.GetTable($"descanosem= '{Pbl.Param.AnoSem}'");

                if (dt.HasRows())
                {
                    if (cbPlanopag.Items.Count > 0)
                    {
                        for (int i = 0; i < cbPlanopag.Items.Count; i++)
                        {
                            var ssd = cbPlanopag.Items[i] as DataRowView;
                            foreach (DataRow item in dt.Rows)
                            {
                                if (ssd != null)
                                {
                                    var sss = ssd["Planopagstamp"].ToString().ToLower();
                                    if (item["Planopagstamp"].ToString().ToLower().Equals(sss))
                                    {
                                        cbPlanopag.SelectedIndex = i;
                                        // cbPlanopag.Enabled = false;
                                    }
                                }
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                //
            }
        }

        private void BindCombo(ComboBox cb, DataTable dt)
        {

            //Entra no 134 e faca Backpu primei
            //JA ESTA
            cb.DataSource = null;
            cb.DataSource = dt;
            cb.DisplayMember = dt.Columns[1].ToString();
            cb.ValueMember = dt.Columns[0].ToString();
        }
        public override void DefaultValues()
        {
            panel7.Visible  = false;
            if (tabControl1.TabPages.Count > 1)
            {
                tabControl1.TabPages.Remove(tabPage4);
            }
            _matriculaAluno = DoAddline<MatriculaAluno>();
            if (TmpTdocMat.Defa)
            {
                _matriculaAluno.Anolectivo = 1;
            }
            gridUiCC.DataSource=null;
            base.DefaultValues();
            var dt = SQL.GetGenDT("select top 1 Auxiliarstamp,Descricao,Codigo from Auxiliar where Tabela=79 order by Codigo");
            if (!dt.HasRows()) return;
            status.tb1.Text = dt.Rows[0]["Descricao"].ToString();
            status.Text2 = dt.Rows[0]["Codigo"].ToString();
        }
        public override void Save()
        {
           // AfterSave()
;            FillEntity(_matriculaAluno);
            if (TmpTdocMat.Inscricao)
            {
                _matriculaAluno.Inscricao=TmpTdocMat.Inscricao;
                _matriculaAluno.Matricula=false;
            }
            if (TmpTdocMat.Matricula)
            {
                _matriculaAluno.Matricula=TmpTdocMat.Matricula;
                _matriculaAluno.Inscricao=false;
            }
            _matriculaAluno.Nomedoc=TmpTdocMat.Descricao;
            _matriculaAluno.Numdoc=TmpTdocMat.Numdoc;
            if (TmpTdocMat.Defa)
            {
                _matriculaAluno.Anolectivo = 1;
            }
            EF.Save(_matriculaAluno);
        }

        //Me localiza o metodo preenchecampos
        private Fact _fact;

        public DataRowView DtPlanovView { get; set; }
        private DataTable _falctl { get; set; }
        public override void AfterSave()
        {//Cipia daqui
            DataTable dtpar;
            if (TmpTdocMat.Defa)
            {
                var quer = $@"select getdate() Data,sts.Preco ValorTotal,Parecela=1 ,Descricao,st.Ststamp Planopagstamp
from st inner join  stprecos sts on st.ststamp=sts.ststamp  
where TipoProduto=1 and Descricao like '%{TmpTdocMat.Descricao.Trim()}%'";
                dtpar = SQL.GetGenDT(quer);
            }
            else
            {
                if (TmpTdocMat.Matricula)
                {
                    DtPlanovView = cbPlanopag.SelectedItem as DataRowView;
                    var niv = 1;
                    var qyrmulta = "";
                    if (DtPlanovView != null)
                    {
                        var fim = DtPlanovView["DataFim"].ToDateTimeValue();
                        if (fim < DateTime.Now)
                        {
                            if (Cl.Curso.ToLower().Contains("licenciatura"))
                            {
                                niv = 1;
                            }
                            if (Cl.Curso.ToLower().Contains("mestrado"))
                            {
                                niv = 2;
                            }
                            qyrmulta = $@" union all select distinct Data=GETDATE(),stp.Preco ValorTotal,Parcela=10,
st.Descricao,st.Ststamp Planopagpstamp from st inner join StPrecos stp 
on st.Ststamp=stp.Ststamp where Servico=1 and TipoProduto=1 and Multa=1 and st.tara={niv}";
                        }
                    }
                    var qry = $@"select Data,ValorTotal,
                                       Parecela,descricao,
                                       Planopagpstamp from Planopagp where 
                                       Planopagstamp='{cbPlanopag.SelectedValue.ToTrim()}' 
                                            {qyrmulta}
                                       order by Parecela";
                    dtpar = SQL.GetGenDT(qry);
                }
                else
                {
                    dtpar = SQL.GetGenDT($@"select Data,ValorTotal,
                                       Parecela,descricao,
                                       Planopagpstamp from Planopagp where 
                                       Planopagstamp='{cbPlanopag.SelectedValue.ToTrim()}' 
                                       order by Parecela");
                }
            }
            if (dtpar.HasRows())
            {
                TmpTdoc = SQL.GetRowToEnt<Tdoc>("ft=1");
                if (_turmap != null)
                {
                    var dt = _turmap.ToDataTable();
                    var campos = new[]
                    {
                       "Turmastamp", "Codigo","Descanoaem", "Descurso", "Cursostamp","Etapa"
                   };
                    if (dt.HasRows())
                    {
                        dt = dt.DefaultView.
                            ToTable(true, campos);
                    }
                    BindCombo(cbTurma, dt);
                    cbTurma.SelectedIndex = 0;
                    Dtv = cbTurma.SelectedItem as DataRowView;
                }
                DtEntidade = cbEntidade.SelectedItem as DataRowView;
                if (!TmpTdocMat.Defa)
                {
                    Numinterno = cbPlanopag.SelectedValue.ToString();
                }
                else
                {
                    Numinterno = $@"Exameespecial_{DateTime.Now.ToShortDateString()}";
                }
                foreach (var item in dtpar.AsEnumerable())
                {
                    if (item != null)
                    {
                        var ckexist = SQL.CheckExist($@"
select fact.factstamp from fact inner join factl
on fact.Factstamp=factl.Factstamp
where
Turmastamp='{tbTurma.Text2.Trim()}'
and clstamp='{Cl.Clstamp}'
and Anosem='{tbAnoSem.tb1.Text}'
and factl.descricao='{item["descricao"]}'");
                        if (!ckexist)
                        {

                            var ft = Utilities.DoAddline<Fact>();
                            HelperFact.FillFactura(ft, Cl, item["Data"].ToDateTimeValue(), TmpTdoc,
                                DtEntidade, Dtv, Numinterno);
                            ft.Ft=true;
                            ft.Movcc=true;
                            var ftl = SQL.Initialize("factl");
                            var dr = ftl.NewRow().Inicialize();
                            HelperFact.FillFactl(item, dr, ft.Factstamp);
                            ftl.Rows.Add(dr);
                            HelperFact.TotaisFt(ft, ftl);
                            ft.MatriculaAluno=TmpTdocMat.Matricula;
                            ft.Inscricao=TmpTdocMat.Inscricao;
                            ft.Nomedoc=TmpTdoc.Descricao;
                            if (EF.Save(ft).ret > 0)
                            {
                                SQL.Save(ftl, "factl", true, ft.Factstamp, "fact");
                            }
                        }
                    }
                }
            }
            var dtturmas = gridUTurma.GetBindedTable();
            var camposs = new[]
            {
                "MatriculaTurmaAlunolstamp", "Turmastamp"
            };
            if (dtturmas.HasRows())
            {
                dtturmas = dtturmas.DefaultView.
                    ToTable(true, camposs);
                dtturmas.Columns.Add("Clstamp", typeof(string));
                dtturmas.Columns.Add("Nome", typeof(string));
                dtturmas.Columns.Add("No", typeof(string));
                dtturmas.Columns["MatriculaTurmaAlunolstamp"].ColumnName = "Turmalstamp";
                dtturmas.AcceptChanges();
                var dd = dtturmas.DtToList<Turmal>();
                foreach (var tml in dd)
                {
                    var ddss = SQL.GetGenDT($@"select Turmalstamp from Turmal where Turmalstamp='{tml.Turmalstamp.Trim()}'");
                    if (!ddss.HasRows())
                    {
                        tml.Clstamp = Cl.Clstamp;
                        tml.No = Cl.No;
                        tml.Nome = Cl.Nome;
                        EF.Save(tml);
                    }
                }

                var dtturmass = gridUTurma.GetBindedTable().
                    DtToList<MatriculaTurmaAlunol>();
                foreach (var tml in dtturmass)
                {
                    //Inserção na tabela de disciplinas da turma
                    dtturmas = gridUiTurmDisc.GetBindedTable();
                    try
                    {
                        dtturmas.Columns["DisciplinaTumrastamp"].ColumnName = "Turmadiscstamp";
                    }
                    catch (Exception)
                    {
                        //
                    }
                    dtturmas.AcceptChanges();

                    var ddsc = dtturmas.DtToList<Turmadisc>();
                    DtTurmanota = SQL.Initialize("Turmanota");
                    foreach (var tmsl in ddsc)
                    {
                        var dl = SQL.GetGenDT($@"select Turmadiscstamp 
from Turmadisc where Turmadiscstamp='{tmsl.Turmadiscstamp.Trim()}'");
                        if (!dl.HasRows())
                        {
                            EF.Save(tmsl);
                        }
                        //Adicionar Este aluno na tabela de lançamento de notas
                        var rw = DtTurmanota.NewRow().Inicialize();
                        rw["Turmastamp"] = tml.Turmastamp;
                        rw["Alunostamp"] = Cl.Clstamp;
                        rw["AlunoNome"] = Cl.Nome;
                        rw["No"] = Cl.No;
                        rw["Coddis"] = tmsl.Ststamp;
                        rw["Disciplina"] = tmsl.Disciplina;
                        rw["Anosem"] = tml.Descanoaem;
                        rw["Sem"] = tml.Etapa;
                        rw["Cursostamp"] = Cl.Codcurso;
                        var professor = SQL.GetGenDT($"select Pestamp,Nome from Turmadiscp " +
                                                    $"where Ststamp='{tmsl.Ststamp.Trim()}'");
                        if (professor.HasRows())
                        {
                            rw["Pestamp"] = professor.Rows[0]["Pestamp"];
                            rw["Profnome"] = professor.Rows[0]["Nome"];
                        }
                        if (professor.Rows.Count == 2)
                        {
                            rw["Pestamp2"] = professor.Rows[1]["Pestamp"];
                            rw["Profnome2"] = professor.Rows[1]["Nome"];
                        }
                        DtTurmanota.Rows.Add(rw);
                    }
                }
            }

            if (DtTurmanota.HasRows())
            {

                foreach (var item in DtTurmanota.DtToList<Turmanota>())
                {
                    var qry = $"select Turmanotastamp from Turmanota where " +
                        $" Cursostamp='{item.Cursostamp}' and Turmastamp ='{item.Turmastamp}' and " +
                        $"Anosem='{item.Anosem}' and Coddis='{item.Coddis}' and alunostamp='{item.Alunostamp}'";

                    var dl = SQL.GetGenDT(qry);
                    //var ss = SQL.ConvertToInsertIntoSql(item);
                    if (!dl.HasRows())
                    {
                        EF.Save(item);
                    }
                }
            }
            base.AfterSave();
            AgendaDivida();
            InicializaLinhasdeFactura();
        }
        public DataTable DtTurmanota { get; set; }
        private void AgendaDivida()
        {

            try
            {
                if (MsgBoxVerificaCl()) return;

                RebindPlanoPlag();
                var xx = $@"select descricao,valorreg,ccstamp,Fact.data,Fact.Dataven,tmp1.Referencia,fact.Numero,tmp1.Entidadebanc from (
                                select* from ClCCF() 
where Clstamp = '{Cl.Clstamp.Trim()}')tmp1 join 
fact on tmp1.ccstamp = fact.Factstamp order by Numero";


                var dtcc = SQL.GetGenDT(xx);
                gridUiCC.SetDataSource(dtcc);
                if (dtcc.HasRows())
                {
                    tbTotal.Text = dtcc.Sum("valorreg").ToString("N2");
                }
                else
                {
                    tbTotal.Text = "";
                }
            }
            catch (Exception)
            {
                //
            }
        }


        public override void PreencheCampos(DataTable dt, int i)
        {
            try
            {
                gridUiCC.DataSource=null;
                _matriculaAluno = FillControls(_matriculaAluno, dt, i);
                _turmap = SQL.GetRowToEnt<Turma>($"turmastamp='{tbTurma.Text2.Trim()}'");
                Cl = SQL.GetRowToEnt<Cl>($"clstamp='{tbCl.Text3.Trim()}'");
                if (Cl != null)
                {
                    tbNivelAcad.tb1.Text = Cl.Nivelac;
                }
                //  AgendaDivida();

                GetCC();
                if (tabControl1.TabPages.Count > 1)
                {
                    tabControl1.TabPages.Remove(tabPage4);
                    tabControl1.TabPages.Add(tabPage4);
                }
                InicializaLinhasdeFactura();
                panel7.Visible = true;
                btnCancActivaMatri.Text = lblMsg.Text = string.Empty;
                if (_matriculaAluno!=null)
                {
                    if (!_matriculaAluno.Activo)
                    {
                        lblMsg.Visible = false;
                        gridUiTurmDisc.Enabled = gridUTurma.Enabled = true;
                        btnCancActivaMatri.Text = $@"Cancelar Matrícula";
                    }
                    else
                    {
                        lblMsg.Visible = true;
                        lblMsg.Text = $@"Matrícula Cancelada";
                        gridUiTurmDisc.Enabled = gridUTurma.Enabled = false;
                        btnCancActivaMatri.Text = $@"Reactivar Matrícula";
                    }
                }

            }
            catch
            {
                //
            }
       
        }
        private void InicializaLinhasdeFactura()
        {
            if (Cl != null)
            {
                if (TmpTdoc == null)
                {
                    TmpTdoc = SQL.GetRowToEnt<Tdoc>("ft=1");
                }
                //o problema estava aqui
                _fact=null;
                var fact = SQL.GetGenDT($@"select f.* from ClCCF() c inner join factl f
on c.ccstamp=f.Factstamp
where Clstamp='{Cl.Clstamp}'
order by f.ref");
                if (fact.HasRows())
                {
                    _fact=
                    fact.DtToList<Fact>().FirstOrDefault();//SQL.GetRowToEnt<Fact>(
                }                               //$"clstamp='{Cl.Clstamp.Trim()}'");
                if (_fact != null)
                {
                    _fact.Obs = _fact.Referencia;


                    _falctl = SQL.GetGenDT($"select fl.* from factl fl inner join ClCCF() f " +
                                            $"on fl.Factstamp=f.ccstamp" +
                                            $" where clstamp='{Cl.Clstamp.Trim()}'" +
                                            $" order by fl.ref" +
                                            $" ");//ate aqui

                    if (_falctl.HasRows())
                    {
                        foreach (DataRow row in _falctl.Rows)
                        {
                            row["Armazemstamp"] = _fact.Entidadebanc;
                            row["Obs"] = _fact.Referencia;
                            //row["descricao"] = "Matrícula";
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CancelaGeral(sender, e);
        }

        private void CancelaGeral(object sender, EventArgs e)
        {
            Motivo = string.Empty;
            if (Procurou)
            {
                if (MsgBoxVerificaCl()) return;
                if (!_matriculaAluno.Activo)
                {
                    var dres = MsBox.Show($"Deseja cancelar a matrícula?", DResult.YesNo);
                    if (dres.DialogResult != DialogResult.Yes) return;
                    var f = new FrmEditRlt
                    {
                        SendInfo = Receive2,
                        tbQuerry =
                        {
                            Text = tbDefault1.tb1.Text
                        }
                    };
                    f.ShowForm(this, true);
                    tbDefault1.tb1.Text = Motivo;
                    if (tbDefault1.tb1.Text.IsNullOrEmpty())
                    {
                        MsBox.Show($"{Messagem.ParteInicial()}preenche o motivo de cancelamento da matrícula.");
                        tabControl1.SelectedIndex = 1;
                        tbDefault1.tb1.Focus();
                        return;
                    }

                    //SQL.SqlCmd(
                    //    $"update matriculaAluno set activo=1,motivo='{tbDefault1.tb1.Text}'," +
                    //    $"Sitcao='Inactivo'" +
                    //    $" where Clstamp='{Cl.Clstamp.Trim()}'");
                    //SQL.SqlCmd(
                    //    $"update Turmal set activo=1,motivo='{tbDefault1.tb1.Text}' " +
                    //    $"where Clstamp='{Cl.Clstamp.Trim()}'");
                    //SQL.SqlCmd($"update DisciplinaTumra set activo=1,motivo='{tbDefault1.tb1.Text}',Sitcao='Inactivo' " +
                    //           $"where Clstamp='{Cl.Clstamp.Trim()}'");
                    //SQL.SqlCmd($"update Turmanota set activo=1,motivo='{tbDefault1.tb1.Text}' " +
                    //           $"where Alunostamp='{Cl.Clstamp.Trim()}'");
                    //MsBox.Show($"{Messagem.ParteInicial()} matrícula cancelada com com sucesso.");
                    UpdateCancelament(1, tbDefault1.tb1.Text, "Inactivo", "cancelada");
                }
                else if (_matriculaAluno.Activo && !_matriculaAluno.Motivo.IsNullOrEmpty())
                {
                    var dres = MsBox.Show($"Deseja reativar a matrícula?", DResult.YesNo);
                    if (dres.DialogResult != DialogResult.Yes) return;
                    UpdateCancelament(0, "", "Activo", "reactivada");
                }

                btnRefresh_Click(sender, e);
            }
        }

        private void UpdateCancelament(int activo, string motivo, string sita, string msgbx)
        {
            SQL.SqlCmd(
                $"update matriculaAluno set activo={activo},motivo='{motivo}',Sitcao='{sita}' where Clstamp='{Cl.Clstamp.Trim()}'");
            SQL.SqlCmd(
                $"update Turmal set activo={activo},motivo='{motivo}' where Clstamp='{Cl.Clstamp.Trim()}'");

            SQL.SqlCmd($"update Turmanota set activo={activo},motivo='{motivo}' where Alunostamp='{Cl.Clstamp.Trim()}'");

            SQL.SqlCmd($"update DisciplinaTumra set activo={activo},motivo='{motivo}',Sitcao='{sita}' " +
                       $"where Clstamp='{Cl.Clstamp.Trim()}'");
            MsBox.Show($"{Messagem.ParteInicial()} matrícula {msgbx} com com sucesso.");
        }

        private void gridUi5_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DtTurma = null;
            var ddddddd = gridUTurma.DtDS;
            if (MsgBoxVerificaCl()) return;

            if (gridUTurma.CurrentRow == null) return;
            DataRow = ((DataRowView)gridUTurma.CurrentRow.DataBoundItem).Row;
            var name = gridUTurma.CurrentCell.OwningColumn.Name.ToLower();
            #region Bind Classificador
            //            if (name.Equals("descricao"))//Procura na base de referencia  do turma
            //            {
            //                var gddd = "";
            //                ddddddd = gridUTurma.GetBindedTable();

            //                if (gridUTurma.GetBindedTable().HasRows())
            //                {
            //                    string[] strSummCities = gridUTurma.GetBindedTable().AsEnumerable().
            //                        Select(s => s.Field<string>("Turmastamp")).ToArray();
            //                    for (int i = 0; i < strSummCities.Length; i++)
            //                    {
            //                        if (strSummCities[i].IsNullOrEmpty() || gddd.Contains(strSummCities[i]))
            //                        {
            //                            continue;
            //                        }
            //                        if (i == 0)
            //                        {
            //                            gddd = $"'{strSummCities[i]}'";
            //                        }
            //                        else
            //                        {
            //                            gddd += $",'{strSummCities[i]}'";
            //                        }
            //                    }
            //                }

            //                if (!gddd.IsNullOrEmpty())
            //                {
            //                    gddd = $" and Turmastamp not in ({gddd})";
            //                }

            //                DtTurma = Helper.SetBinds(e.Control, "descricao", $@"select Turmastamp,codigo,Descricao,Etapa,
            //AnoSemstamp,Descanoaem,cast (0 as bit) as padrao from Turma
            // where Gradestamp='{Cl.Gradestamp.Trim()}'  and Cursostamp='{Cl.Codcurso.Trim()}' {gddd}");
            //            }
            #endregion
        }
        private bool MsgBoxVerificaCl()
        {
            if (Cl == null)
            {
                MsBox.Show($"{Messagem.ParteInicial()} Tem que preencher o nome do estudante primeiro!");
                return true;
            }

            return false;
        }
        private void gridUi5_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (MsgBoxVerificaCl()) return;
            if (gridUTurma.CurrentRow == null) return;
            var name = gridUTurma.CurrentCell.OwningColumn.Name.ToLower();
            if (name.Equals("descricao"))
            {
                SetTurma("descricao");
            }
            else if (name.Equals("codigo"))
            {
                SetTurma("codigo");
            }
        }
        private void SetTurma(string v)
        {
            if (gridUTurma.CurrentCell == null) return;
            if (gridUTurma.CurrentCell.Value == null) return;
            var valor = gridUTurma.CurrentCell.Value.ToString().Trim();
            if (DtTurma.HasRows())
            {
                var dr = DtTurma.AsEnumerable().FirstOrDefault(s => s.Field<string>(v).Trim().Equals(valor));
                if (dr != null)
                {
                    if (gridUTurma.CurrentRow != null)
                    {
                        gridUTurma.CurrentRow.Cells["descricao"].Value = dr["descricao"].ToString();
                        gridUTurma.CurrentRow.Cells["codigo"].Value = dr["codigo"].ToString();
                        gridUTurma.CurrentRow.Cells["turmastamp"].Value = dr["turmastamp"].ToString();
                        gridUTurma.CurrentRow.Cells["Etapa"].Value = dr["Etapa"].ToString();
                        gridUTurma.CurrentRow.Cells["AnoSemstamp"].Value = dr["AnoSemstamp"].ToString();
                        gridUTurma.CurrentRow.Cells["Descanoaem"].Value = dr["Descanoaem"].ToString();
                        gridUTurma.CurrentRow.Cells["select"].Value = dr["padrao"].ToBool();
                    }
                }
            }
        }
        public void gridUTurma_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (gridUTurma.CurrentRow == null) return;
            var name = gridUTurma.CurrentCell.OwningColumn.Name.ToLower();
            var turmasp = gridUTurma.CurrentRow.Cells["Turmastamp"].Value.ToString();
            _turmap = SQL.GetRowToEnt<Turma>($"turmastamp='{turmasp.Trim()}'");
            if (name.Equals("disciplina"))
            {
                var gddd = "";
                if (gridUTurma.GetBindedTable().HasRows())
                {
                    string[] strSummCities = gridUiTurmDisc.GetBindedTable().AsEnumerable().
                        Select(s => s.Field<string>("Ststamp")).ToArray();
                    for (int i = 0; i < strSummCities.Length; i++)
                    {
                        if (strSummCities[i].IsNullOrEmpty() || gddd.Contains(strSummCities[i]))
                        {
                            continue;
                        }
                        if (i == 0)
                        {
                            gddd = $"'{strSummCities[i]}'";
                        }
                        else
                        {
                            gddd += $",'{strSummCities[i]}'";
                        }
                    }
                }
                if (!gddd.IsNullOrEmpty())
                {
                    gddd = $" and Ststamp not in ({gddd})";
                }
                var dt = SQL.GetGenDT($@"select distinct *,Sitcao=''from(
select Referenc,Disciplina, ok,Turmastamp,Ststamp,ISNULL(Mediafina,0)Mediafina,ISNULL(Fecho,0)Fecho,Prec
from(select Referenc,Disciplina, cast (0 as bit) as ok,Turmastamp,Ststamp,Mediafina=(
select top 1 ISNULL(tn.Mediafinal ,18)
from Turmanota tn where tn.Coddis=Turmadisc.Ststamp
and tn.Turmastamp=Turmadisc.Turmastamp
),Fecho=(
select top 1 ISNULL(tn.Fecho ,0) from Turmanota tn where 
tn.Coddis=Turmadisc.Ststamp
and tn.Turmastamp=Turmadisc.Turmastamp
) ,Prec=(select top 1 Prec from st  where st.Ststamp=Turmadisc.Ststamp)
from Turmadisc  where Turmastamp='{turmasp}'  {gddd}) temp)temp2 where Mediafina<9.5  and Fecho=0");

                var exceptostampPreceNegativas = "'nao1'";

                if (dt.HasRows())
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        if (item["Prec"].ToBool())
                        {
                            var todasPrece = SQL.GetGenDT($"select oristamp from stl where Ststamp='{item["Ststamp"]}'");
                            if (todasPrece.HasRows())
                            {
                                foreach (DataRow iteml in todasPrece.Rows)
                                {
                                    var dt2 = SQL.GetGenDT($"select top 1 Mediafinal from Turmanota where Coddis='{iteml["oristamp"]}' and alunostamp='{Cl.Clstamp}' order by Sem desc");
                                    if (dt2.HasRows())
                                    {
                                        var notfina = dt2.RowZero("Mediafinal").ToDecimal();
                                        if (notfina<9.5.ToDecimal())
                                        {
                                            exceptostampPreceNegativas+=$",'{item["Ststamp"]}'";
                                        }
                                    }
                                }
                            }
                        }
                    }
                    exceptostampPreceNegativas=exceptostampPreceNegativas.Replace("'nao1',", "");
                    dt =dt.GetTable($"Ststamp not in ({exceptostampPreceNegativas})");
                    var campos = new[]
                    {
                            "Ststamp", "Disciplina","ok","Turmastamp","Mediafina","Fecho","Referenc","Sitcao"
                    };
                    if (dt.HasRows())
                    {
                        dt = dt.DefaultView.
                        ToTable(true, campos);

                    }
                    var l = new FrmSelect
                    {
                        SelectCampos = $@"Ststamp,Disciplina, cast (0 as bit) as ok,Turmastamp,
                                       cast (0 as decimal) Mediafina,Activo Fecho,Referenc,Sitcao",
                        HideFirstColumn = true,
                        Tamanhos = new List<decimal> { 0, 150, 0, 0, 0, 0, 0, 0 },
                        ColFillName = "Disciplina",
                        Tabela = "DisciplinaTumra",
                        Condicao = "where 1=0",
                        SendData = Receivedata,
                        _dt = dt
                    };
                    var qry = $@"select Ststamp,Disciplina, cast (0 as bit) as ok,Turmastamp,
cast (0 as decimal) Mediafina,Activo Fecho,Referenc ,Sitcao  from  DisciplinaTumra where 1=0";
                    l._dt2 = SQL.GetGenDT(qry);
                    l.ShowDialog();
                }
                else
                {
                    MsBox.Show($"{Messagem.ParteInicial()} Não encontramos dados para visualizar!");
                }
            }
            else if (name.Equals("select"))
            {
                gridUTurma.Update();
                var tbl = gridUTurma.GetBindedTable();
                if (tbl.HasRows())
                {
                    var ff = gridUTurma.CurrentRow.Index;
                    var ffhhhh = gridUTurma.CurrentRow.Cells["select"].Value.ToBool();
                    NewMethod1(ff, ffhhhh);
                }
            }
            var trma = SQL.GetRowToEnt<Turma>($"Turmastamp='{turmasp.Trim()}'");
            if (trma != null)
            {
                tbTurma.tb1.Text = trma.Codigo;
                tbTurma.Text2 = trma.Turmastamp;
                tbTurma.Text3 = trma.Descricao;
                tbAnoSem.tb1.Text = trma.Descanoaem;
                tbAnoSem.Text2 = trma.AnoSemstamp;
                tbetapasem.tb1.Text = trma.Etapa;
                tbetapasem.Text2 = trma.Codetapa;
                tbTurno.tb1.Text = trma.Turno;
            }
        }
        private void NewMethod1(int ff, bool ffhhhh)
        {
            gridUTurma.EndEdit();
            foreach (DataGridViewRow row in gridUTurma.Rows)
            {
                var i = row.Index;
                if (ff == i)
                {
                    row.Cells["select"].Value = !ffhhhh;
                }
                else
                {
                    row.Cells["select"].Value = false;
                }

            }
            gridUTurma.Update();
        }
        private void Receivedata(DataTable dt)
        {
            if (dt.HasRows())
            {
                if (gridUTurma.CurrentRow != null)
                {
                    var gridturm = gridUTurma.CurrentRow.Cells["Turmastamp"].Value.ToString();
                    foreach (var row in dt.AsEnumerable())
                    {
                        if (row != null)
                        {
                            var qry = $@"select tds.Turmastamp  from Turmadisc tds

                        inner join MatriculaAluno ml on ml.Turmastamp = tds.Turmastamp

                        inner join DisciplinaTumra cl on cl.MatriculaAlunostamp = ml.MatriculaAlunostamp  
where cl.Ststamp='{row["Ststamp"].ToString().Trim()}' and 
cl.Turmastamp='{gridturm.Trim()}' and cl.Clstamp='{tbCl.Text3.Trim()}'";
                            if (!SQL.CheckExist(qry))
                            {
                                var tbl = gridUiTurmDisc.GetBindedTable();
                                if (tbl.HasRows())
                                {
                                    bool contains =
                                        tbl.AsEnumerable().Any(c =>
                                            gridturm.Trim() == c.Field<string>("Turmastamp")
                                            && row["Ststamp"].ToString().Trim() == c.Field<string>("Ststamp")

                                        );
                                    if (!contains)
                                    {
                                        NewMethod(row);
                                    }
                                }
                                else
                                {
                                    NewMethod(row);
                                }
                            }
                        }
                    }
                }
                gridUiTurmDisc.Update();
            }
        }
        private void NewMethod(DataRow row)
        {
            if (gridUTurma.CurrentRow != null)
            {
                var gridturm = gridUTurma.CurrentRow.Cells["Turmastamp"].Value.ToString();
                gridUiTurmDisc.AddLine();
                gridUiTurmDisc.DataRowr["Turmastamp"] = gridturm.Trim();
                gridUiTurmDisc.DataRowr["codigo"] =
                    gridUTurma.CurrentRow.Cells["codigo"].Value;
                gridUiTurmDisc.DataRowr["Disciplina"] = row["Disciplina"];
                gridUiTurmDisc.DataRowr["Referenc"] = row["Referenc"];
                gridUiTurmDisc.DataRowr["Ststamp"] = row["Ststamp"];
                gridUiTurmDisc.DataRowr["Clstamp"] = tbCl.Text3;
                gridUiTurmDisc.DataRowr["Sitcao"] = "Activo";
                gridUiTurmDisc.DataRowr["Activo"] = false;
                gridUiTurmDisc.DataRowr["Motivo"] = "";

            }
            var dd = row["Ststamp"].ToString();
            tabControl2.SelectedIndex = 1;
        }
        public override bool BeforeSave()
        {
            MsgBoxVerificaCl();
            if (Procurou)
            {
                MsBox.Show($"{Messagem.ParteInicial()}Não se altera uma matrícula!");
                tabControl1.SelectedIndex = 0;
                return false;
            }
            if (Inserindo)
            {
                var dres = MsBox.Show($"{Messagem.ParteInicial()}Deseja Salvar esta matricula?\r\n Atenção: Acção não reversível.!", DResult.YesNo);
                if (dres.DialogResult != DialogResult.Yes) return false;

            }
            if (tbcurso.tb1.Text.IsNullOrEmpty())
            {
                MsBox.Show($"{Messagem.ParteInicial()}O curso do aluno ainda não foi especificado!");
                tabControl1.SelectedIndex = 0;
                return false;
            }
            if (tbNivelAcad.tb1.Text.IsNullOrEmpty())
            {
                MsBox.Show($"{Messagem.ParteInicial()}O nível académico do aluno ainda não foi especificado!");
                tabControl1.SelectedIndex = 0;
                return false;
            }
            if (TmpTdocMat==null)
            {
                MsBox.Show($"{Messagem.ParteInicial()} Especifique o tipo de Documento!");
                return false;
            }
            if (tbPlano.tb1.Text.IsNullOrEmpty())
            {
                MsBox.Show($"{Messagem.ParteInicial()}O plano curso ainda não foi especificado!");
                tabControl1.SelectedIndex = 0;
                return false;
            }
            var dtcc = gridUiCC.GetBindedTable();
            var total = dtcc.Sum("valorreg");
            if (Pbl.Param.MatriculaComCCaberto)
            {
                if (total > 0)
                {
                    MsBox.Show($"Este estudante tem dívida, por favor regularize-as primeiro!");
                    return false;
                }
            }
            if (!gridUTurma.HasRows())
            {
                MsBox.Show($"{Messagem.ParteInicial()}tem que existir pelo menos uma turma pertencente a este aluno!");
                tabControl2.SelectedIndex = 0;
                return false;
            }
            if (tbTurma.tb1.Text.IsNullOrEmpty())
            {
                MsBox.Show($"{Messagem.ParteInicial()}tem que marcar uma turma como padrão!");
                tabControl2.SelectedIndex = 0;
                return false;
            }
            if (!gridUiTurmDisc.HasRows())
            {
                MsBox.Show($"{Messagem.ParteInicial()}tem que existir pelo menos uma disciplina a frequentar!");
                tabControl2.SelectedIndex = 2;
                return false;
            }
            if (Inserindo)
            {
                if (SQL.CheckExist($"select Turmastamp from MatriculaAluno where " +
                                   $" Turmastamp='{tbTurma.Text2.Trim()}'" +
                                   $" and Clstamp='{Cl.Clstamp.Trim()}' and Cursostamp='{tbcurso.Text2.Trim()}'"))
                {
                    MsBox.Show($"{Messagem.ParteInicial()} Estás para duplicar dados nas condições a seguir mencionadas!\r\n Nome do aluno,Turma e curso");
                    tabControl2.SelectedIndex = 2;
                    return false;
                }
            }
            return base.BeforeSave();
        }
        private void procura2_RefreshControls()
        {
            Cl = SQL.GetRowToEnt<Cl>($"clstamp='{tbCl.Text3.Trim()}'");
            foreach (DataRow row in gridUiTurmDisc.GetBindedTable().Rows)
            {
                row["Clstamp"] = tbCl.Text3;
            }
            if (MsgBoxVerificaCl()) return;
            var cur = SQL.GetGenDT($"select Codcurso from Curso" +
                                    $" where Cursostamp='{Cl.Codcurso.Trim()}'").DtToList<Curso>().FirstOrDefault();
            if (cur != null)
            {
                tbcurso.Text2 = cur.Codcurso;
            }
            tbcurso.Text3 = Cl.Codcurso;
            tbcurso.tb1.Text = Cl.Curso;
            tbPlano.tb1.Text = Cl.Descgrelha;
            tbPlano.Text2 = Cl.Gradestamp;
            tbNivelAcad.tb1.Text = Cl.Nivelac;
            tbDepartamento.tb1.Text = Cl.Coddep;
            tbDepartamento.Text2 = Cl.Departamento;
            tbFacul.tb1.Text = Cl.Faculdade;
            tbCcusto.tb1.Text = Cl.Ccusto;
            tbCcusto.Text2 = Cl.Ccustostamp;
            tbTipo.tb1.Text = Cl.Tipo;
            gridUiTurmDisc.Refresh();
            GetCC();
        }
        void GetCC()
        {
            gridUiCC.SetDataSource(null);
            var cond = "";
            if (!tbcurso.tb1.Text.IsNullOrEmpty())
            {
                if (tbcurso.tb1.Text.ToLower().Contains("licenc"))
                {
                    cond="licenc";
                }
                if (tbcurso.tb1.Text.ToLower().Contains("mestrad"))
                {

                    cond="mestrad";
                }
                if (tbcurso.tb1.Text.ToLower().Contains("bacharelato"))
                {

                    cond="bacharelato";
                }
            }

            var quer = $@"select Planopagstamp,Descricao,descanosem,Cursostamp,AnoSemstamp,DataFim,Datapartida  
from Planopag where Descdistrato like '%{cond.Trim()}%'";
            var dtPlano = SQL.GetGenDT(quer);
            BindCombo(cbPlanopag, dtPlano);
            DtPlanoPagmento = dtPlano;
            AgendaDivida();
        }
        private Turma _turmap { get; set; }
        private string Motivo { get; set; }

        private void CancelarDiscilinina(string ststamp, string trmsatmp, string msg, int estado)
        {
            if (Procurou)
            {
                if (gridUiTurmDisc.CurrentRow != null)
                {
                    var motiv = gridUiTurmDisc.CurrentRow.Cells["Motivoghhhh"].Value.ToString();
                    var dres = MsBox.Show(msg, DResult.YesNo);
                    if (dres.DialogResult != DialogResult.Yes) return;
                    var f = new FrmEditRlt
                    {
                        SendInfo = Receive2,
                        tbQuerry =
                        {
                            Text =motiv
                        }
                    };
                    f.ShowForm(this, true);
                    var sit = string.Empty;
                    if (Convert.ToBoolean(estado))
                    {
                        if (Motivo.IsNullOrEmpty())
                        {
                            MsBox.Show($"{Messagem.ParteInicial()}preenche o motivo de cancelamento da matrícula desta disciplina.");
                            return;
                        }

                        sit = "Inactivo";
                    }
                    else
                    {
                        Motivo = "";
                        sit = "Activo";
                    }
                    SQL.SqlCmd($"update Turmanota set activo={estado},motivo='{Motivo}'" +
                               $" where Alunostamp='{Cl.Clstamp.Trim()}'" +
                               $" and Turmastamp='{trmsatmp.Trim()}' and " +
                               $"Coddis='{ststamp.Trim()}'");

                    var gddd = gridUiTurmDisc.CurrentRow.Cells["DisciplinaTumrastamp"].Value.ToString();
                    gddd = $" DisciplinaTumrastamp = '{gddd}'";
                    SQL.SqlCmd($"update DisciplinaTumra set activo={estado}," +
                               $"Motivo='{Motivo}',Sitcao='{sit}' where {gddd}");
                    string mmss;
                    if (msg.ToLower().Contains("cancela"))
                    {
                        mmss = "cancelada";
                    }
                    else
                    {
                        mmss = "reactivada";
                    }
                    MsBox.Show($"{Messagem.ParteInicial()}matrícula {mmss} para esta disciplina.");
                    btnRefresh_Click(null, null);
                }

            }
        }
        void Receive2(string str)
        {
            Motivo = str;
        }
        private void Fmottttt((DataTable dtPrint, DataTable fp) ret, string xmlString,
            DS ds, DataTable dtDisciplinas, string origem, string nomfile)
        {
            Imprimir.CallForm(ret.dtPrint, ret.fp, CLocalStamp, false,
                 label1.Text, "", nomfile,
                 origem, this, xmlString, true, ds, "", "",
                 null
                 , dtDisciplinas);
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (Cl == null || _fact == null || _falctl == null)
            {
                MsBox.Show($"{Messagem.ParteInicial()}" +
    $" infelizmente não podemos satisfazer o seu pedido\r\n" +
           $" porque o nome ou plano estão vazios!");
                return;
            }
            var dt = gridUiTurmDisc.GetBindedTable();
            DS ds = new DS();
            if (!_falctl.HasRows())
            {
                //vai no aftersave
                MsBox.Show($"{Messagem.ParteInicial()}" +
                    $" infelizmente não podemos satisfazer o seu pedido\r\n" +
                           $" porque o plano de pagamento está vazio!");
                return;
            }
            if (!dt.HasRows())
            {
                MsBox.Show($"{Messagem.ParteInicial()} infelizmente não podemos satisfazer o seu pedido" +
                           $"\\r\n porque o plano de curricular está vazio!");
                return;
            }
            var factl = _falctl;
            Utilities.AllTrim(_fact);
            _fact.Total = factl.Sum("totall");
            var ff = _fact.MatriculaAluno;
            var f = _fact.MatriculaAluno;
            _fact.Nomedoc=TmpTdocMat.Descricao;
            _fact.Desccurso=tbcurso.tb1.Text;
            var ret = Imprimir.FillData(_fact.ToDataTable(),
             factl, null,
             ds.Fact, ds.Formasp);
            Imprimir.RepreencherCl(ret, Cl);
            var xml = SQL.GetXmlReport("RptFactMatricula");
            var campos = new[]
            {
                "Referenc", "Disciplina","Codigo","Turmastamp"
            };
            if (dt.HasRows())
            {
                dt = dt.DefaultView.
                    ToTable(true, campos);
                foreach (DataRow dtd in dt.Rows)
                {
                    dtd["Codigo"] = SQL.GetField($"select Etapa + '-' + Descanoaem from turma where " +
                                           $" turmastamp='{dtd["Turmastamp"]}'");
                }
            }
            Fmottttt(ret, xml, ds, dt, "Matricula",
                "RptFactMatricula");
        }
        private void ReceiveInfo(DataTable dt)
        {
            if (dt.HasRows())
            {
                foreach (var dr in dt.AsEnumerable())
                {
                    if (!dr.DataRowIsNull())
                    {
                        gridUTurma.AddLine();
                        var trrm = SQL.GetRowToEnt<Turma>($"turmastamp='{dr["turmastamp"].ToTrim()}'");
                        if (trrm != null)
                        {
                            gridUTurma.DataRowr["descricao"] = trrm.Descricao;
                            gridUTurma.DataRowr["codigo"] = trrm.Codigo;
                            gridUTurma.DataRowr["turmastamp"] = trrm.Turmastamp;
                            gridUTurma.DataRowr["Etapa"] = trrm.Etapa;
                            gridUTurma.DataRowr["AnoSemstamp"] = trrm.AnoSemstamp;
                            gridUTurma.DataRowr["Descanoaem"] = trrm.Descanoaem;
                        }
                    }
                }
                gridUTurma.Update();
            }
        }

        private DataTable dtProf;
        private bool gridPanel25_BeforeAddLineEvent()
        {
            var gddd = "";
            if (gridUTurma.GetBindedTable().HasRows())
            {
                string[] strSummCities = gridUTurma.GetBindedTable().AsEnumerable().
                    Select(s => s.Field<string>("Turmastamp")).ToArray();
                for (int i = 0; i < strSummCities.Length; i++)
                {
                    if (strSummCities[i].IsNullOrEmpty() || gddd.Contains(strSummCities[i]))
                    {
                        continue;
                    }
                    if (i == 0)
                    {
                        gddd = $"'{strSummCities[i]}'";
                    }
                    else
                    {
                        gddd += $",'{strSummCities[i]}'";
                    }
                }
            }

            if (!gddd.IsNullOrEmpty())
            {
                gddd = $" and Turmastamp not in ({gddd})";
            }
            var qry = $@"select Turmastamp,codigo from Turma
 where Gradestamp='{Cl.Gradestamp.Trim()}'  and Cursostamp='{Cl.Codcurso.Trim()}' {gddd}  
and Turmastamp not in  (select Turmastamp from Turmanota where Fecho=1)";

            if (TmpTdocMat.Defa)
            {
                qry += $@" and Horasaulas =1";
            }
            dtProf = SQL.GetGenDT(qry);
            if (dtProf.HasRows())
            {
                var f = new FrmSelect
                {
                    SelectCampos = "",
                    HideFirstColumn = true,
                    Tamanhos = new List<decimal> { 0, 150 },
                    ColFillName = "codigo",
                    Tabela = "",
                    Condicao = "",
                    SendData = ReceiveInfo,
                    _dt = dtProf
                };
                qry = $@"select codigo,Turmastamp from Turma
 where 1=0";
                f._dt2 = SQL.GetGenDT(qry);
                f.ShowDialog();
            }
            else
            {
                MsBox.Show("Não existe turmas para o curso especificado");
            }
            return true;
        }


        private void gridUTurma_AfterDeleteLineEvent()
        {

            if (!tttrstamp.IsNullOrEmpty())
            {
                try
                {
                    var myTable = gridUiTurmDisc.GetBindedTable();
                    myTable.Delete($"Turmastamp ='{tttrstamp}'", gridUiTurmDisc.TabelaSql);
                    gridUiTurmDisc.Update();
                }
                catch (Exception ex)
                {
                    //
                }
            }
            if (Procurou)
            {

                btnRefresh_Click(null, null);
            }

        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (!gridUiTurmDisc.HasRows())
            {
                checkBox2.Checked=false;
                return;
            }
            var activo = 0;
            var motivo = "";
            var msg = "Reactivar";
            if (checkBox2.Checked)
            {
                activo = 1;
                motivo = "";
                msg = "Cancelar";
            }
            var dres = MsBox.Show($"Deseja {msg} a matrícula destas disciplinas?",
                DResult.YesNo);
            if (dres.DialogResult != DialogResult.Yes) return;
            gridUiTurmDisc.CheckUncheckAll("activo", checkBox2.Checked);
            var f = new FrmEditRlt
            {
                SendInfo = Receive2,
                tbQuerry =
                {
                    Text =motivo
                }
            };
            f.ShowForm(this, true);
            motivo = f.tbQuerry.Text;
            if (checkBox2.Checked)
            {
                if (motivo.IsNullOrEmpty())
                {
                    MsBox.Show($"{Messagem.ParteInicial()}Não é possível salvar este cancelamento sem\r\nespecificar o motivo!");
                    return;
                }
            }
            var dt = gridUiTurmDisc.GetBindedTable();
            foreach (DataRow row in dt.Rows)
            {
                var trmsatmp = row["Turmastamp"].ToString();
                var ststamp = row["Ststamp"].ToString();
                string sit;
                if (checkBox2.Checked)
                {
                    if (motivo.IsNullOrEmpty())
                    {
                        continue;
                    }
                    sit = "Inactivo";
                }
                else
                {
                    sit = "Activo";
                }
                SQL.SqlCmd($"update Turmanota set activo={activo},motivo='{motivo}'" +
                           $" where Alunostamp='{Cl.Clstamp.Trim()}'" +
                           $" and Turmastamp='{trmsatmp.Trim()}' and " +
                           $"Coddis='{ststamp.Trim()}'");

                var gddd = row["DisciplinaTumrastamp"].ToString();
                gddd = $" DisciplinaTumrastamp = '{gddd}'";
                SQL.SqlCmd($"update DisciplinaTumra set activo={activo}," +
                           $"Motivo='{motivo}',Sitcao='{sit}' where {gddd}");

            }
            MsBox.Show($"{Messagem.ParteInicial()}matrícula {msg} para esta disciplina.");
            btnRefresh_Click(null, null);
        }
        private void gridUiTurmDisc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUiTurmDisc.CurrentRow == null) return;
            gridUiTurmDisc.Update();
            UpdateValues();
            btnRefresh_Click(sender, e);
        }
        private void UpdateValues()
        {
            var nome = gridUiTurmDisc.CurrentCell.OwningColumn.Name.ToLower();
            if (nome.Equals("activo"))
            {
                gridUiTurmDisc.EndEdit();
                Motivo = string.Empty;
                if (Procurou)
                {
                    if (!_matriculaAluno.Activo)
                    {
                        if (gridUiTurmDisc.CurrentRow != null)
                        {
                            var ststamp = gridUiTurmDisc.CurrentRow.Cells["Ststamp"].Value.ToString();
                            var trmsatmp = gridUiTurmDisc.CurrentRow.Cells["Turmastamps"].Value.ToString();
                            var tbl = SQL.GetGenDT($"select activo  from Turmanota where " +
                                                    $" Alunostamp='{Cl.Clstamp.Trim()}'" +
                                                    $" and Turmastamp='{trmsatmp.Trim()}' and " +
                                                    $"Coddis='{ststamp.Trim()}'");

                            var dd = gridUiTurmDisc.GetBindedTable();
                            if (tbl.HasRows())
                            {
                                var bol = gridUiTurmDisc.CurrentRow.Cells["activo"].Value.ToBool();
                                if (!bol)
                                {

                                    CancelarDiscilinina(ststamp, trmsatmp,
                                        $"Deseja reactivar a matrícula desta disciplina?", 0);
                                }
                                else
                                {
                                    CancelarDiscilinina(ststamp, trmsatmp,
                                        $"Deseja cancelar a matrícula desta disciplina?", 1);

                                }
                            }
                            else
                            {
                                CancelarDiscilinina(ststamp, trmsatmp,
                                    $"Deseja cancelar a matrícula desta disciplina?", 1);
                            }
                        }
                    }
                    else
                    {
                        MsBox.Show($"{Messagem.ParteInicial()}A matrícula geral está cancelada.\r\nPor favor reactive primeiro!");

                    }
                }
            }
        }

        private void btnTdi_Click(object sender, EventArgs e)
        {
            if (!Inserindo)
            {
                if (Procurou && Lista == null)
                {
                    CallBrowdoc();
                }
                else
                {
                    EditMode = false;
                    Procurou = false;
                    CallBrowdoc();
                }
            }
            else
            {
                MsBox.Show("O formulário está em modo de edição. Por favor Grave ou cancele a operação");
            }

        }
        public void CallBrowdoc(bool origem = false)
        {
            var cond = " where defa=0";
            if (ExameEpecial)
            {
                cond=" where defa=1";
            }
            var bw = new Browdoc
            {
                Condicao = cond,
                Descricao = @"descricao",
                Sigla = @"sigla",
                Tabela = @"TdocMat",
                Origem = origem,
                BindTdoc = BindTdoc
            };
            bw.ShowForm(this, true);
        }

        private void BindTdoc(DataRow tdoc, bool origem = false)
        {
            TmpTdocMat = tdoc.DrToEntity<TdocMat>();
            label1.Text = TmpTdocMat.Descricao;
            Helper.ClearControls(this);
            CCondicao = $"numdoc={TmpTdocMat.Numdoc} and year(data) = {Pbl.SqlDate.Year}";
            gridUiCC.DataSource=null;
            if (TmpTdocMat.Defa)
            {
                var quer = $"select  st.Ststamp Planopagstamp,Descricao,descanosem=''," +
                           $"Cursostamp={tbcurso},AnoSemstamp='' ,sts.Preco" +
                           $" from st inner join  stprecos sts on st.ststamp=sts.ststamp " +
                           $"where TipoProduto=1 and Descricao like '%TAXA DE EXAME ESPECIAL%'";
                var dtPlano = SQL.GetGenDT(quer);
                BindCombo(cbPlanopag, dtPlano);
                DtPlanoPagmento = dtPlano;
            }




        }
        string index = "";
        string tttrstamp = "";
        private bool gridPanel25_BeforeDellLineEvent()
        {
            tttrstamp=index="";
            if (gridUTurma.SelectedRows != null)
            {
                var selectedCellCount = gridUTurma.GetCellCount(DataGridViewElementStates.Selected);
                index = "";
                for (int i = 0; i < selectedCellCount; i++)
                {
                    index= gridUTurma.SelectedCells[i].RowIndex.ToString();
                    tttrstamp = gridUTurma.Rows[index.ToInt()].Cells["Turmastamp"].Value.ToString();
                }
            }
            return false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dmzButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {






        }
        //Peco me localizar o metodo after save
        private void tbDefault1_Load(object sender, EventArgs e)
        {

        }

        private void btnPlanopa_Click(object sender, EventArgs e)
        {
            if (!Procurou) return;
            var  dtpar = SQL.GetGenDT($@"select Data,ValorTotal,
                                       Parecela,descricao,
                                       Planopagpstamp from Planopagp where 
                                       Planopagstamp='{cbPlanopag.SelectedValue.ToTrim()}' 
                                       order by Parecela");




            //                if (TmpTdocMat.Matricula)
            //            {
            //                DtPlanovView = cbPlanopag.SelectedItem as DataRowView;
            //                var niv = 1;
            //                var qyrmulta = "";
            //                if (DtPlanovView != null)
            //                {
            //                    var fim = DtPlanovView["DataFim"].ToDateTimeValue();
            //                    if (fim < DateTime.Now)
            //                    {
            //                        if (Cl.Curso.ToLower().Contains("licenciatura"))
            //                        {
            //                            niv = 1;
            //                        }
            //                        if (Cl.Curso.ToLower().Contains("mestrado"))
            //                        {
            //                            niv = 2;
            //                        }
            //                        qyrmulta = $@" union all select distinct Data=GETDATE(),stp.Preco ValorTotal,Parcela=10,
            //st.Descricao,st.Ststamp Planopagpstamp from st inner join StPrecos stp 
            //on st.Ststamp=stp.Ststamp where Servico=1 and TipoProduto=1 and Multa=1 and st.tara={niv}";
            //                    }
            //                }
            //                var qry = $@"select Data,ValorTotal,
            //                                       Parecela,descricao,
            //                                       Planopagpstamp from Planopagp where 
            //                                       Planopagstamp='{cbPlanopag.SelectedValue.ToTrim()}' 
            //                                            {qyrmulta}
            //                                       order by Parecela";
            //                dtpar = SQL.GetGenDT(qry);
            //            }
            //            else
            //            {

            //            }
            bool conta =true;

            var dt1 = dtpar.TotalRows();
            var dtrocc = gridUiCC.RowCount;
            if (dt1!=dtrocc)
            {

                if (dtpar.HasRows())
                {
                    TmpTdoc = SQL.GetRowToEnt<Tdoc>("ft=1");
                    if (_turmap != null)
                    {
                        var dt = _turmap.ToDataTable();
                        var campos = new[]
                        {
                            "Turmastamp", "Codigo","Descanoaem", "Descurso", "Cursostamp","Etapa"
                        };
                        if (dt.HasRows())
                        {
                            dt = dt.DefaultView.
                                ToTable(true, campos);
                        }
                        BindCombo(cbTurma, dt);
                        cbTurma.SelectedIndex = 0;
                        Dtv = cbTurma.SelectedItem as DataRowView;
                    }
                    DtEntidade = cbEntidade.SelectedItem as DataRowView;
                    Numinterno = cbPlanopag.SelectedValue.ToString();
                    foreach (var item in dtpar.AsEnumerable())
                    {

                        //volta a fazer o plano
                        if (item != null)
                        {
                            var ckexist = SQL.CheckExist($@"
select fact.factstamp from fact inner join factl
on fact.Factstamp=factl.Factstamp
where
Turmastamp='{tbTurma.Text2.Trim()}'
and clstamp='{Cl.Clstamp}'
and Anosem='{tbAnoSem.tb1.Text}'
and factl.descricao='{item["descricao"].ToString()}'");
                            if (!ckexist)
                            {

                                var ft = Utilities.DoAddline<Fact>();
                                HelperFact.FillFactura(ft, Cl, item["Data"].ToDateTimeValue(), TmpTdoc, DtEntidade, Dtv, Numinterno);
                                ft.Ft=true;
                                ft.Movcc=true;
                                var ftl = SQL.Initialize("factl");
                                var dr = ftl.NewRow().Inicialize();
                                HelperFact.FillFactl(item, dr, ft.Factstamp);
                                ftl.Rows.Add(dr);
                                HelperFact.TotaisFt(ft, ftl);
                                ft.MatriculaAluno=TmpTdocMat.Matricula;
                                ft.Inscricao=TmpTdocMat.Inscricao;
                                ft.Nomedoc=TmpTdoc.Descricao;
                                try
                                {
                                    if (EF.Save(ft).ret > 0)
                                    {

                                        SQL.Save(ftl, "factl", true, ft.Factstamp, "fact");
                                    }
                                }
                                catch (Exception)
                                {
                                    conta=false;
                                }
                            }
                        }
                    }// pe
                }

            }
            if (conta)
            {
                MsBox.Show($@"{Messagem.ParteInicial()}Plano gerado com sucesso");

            }
            else
                MsBox.Show($@"{Messagem.ParteInicial()}Plano gerado com algumas falhas");

        }

        private void btnGerarTaxaExameEspecial_Click(object sender, EventArgs e)
        {
            if (!Procurou) return;
            bool conta=true;
            DataTable dtpar;
            var quer = $@"select getdate() Data,sts.Preco ValorTotal,Parecela=1 ,Descricao,st.Ststamp Planopagstamp
from st inner join  stprecos sts on st.ststamp=sts.ststamp  
where TipoProduto=1 and Descricao like '%{TmpTdocMat.Descricao.Trim()}%'";
            dtpar = SQL.GetGenDT(quer);
            if (dtpar.HasRows())
            {
                TmpTdoc = SQL.GetRowToEnt<Tdoc>("ft=1");
                if (_turmap != null)
                {
                    var dt = _turmap.ToDataTable();
                    var campos = new[]
                    {
                       "Turmastamp", "Codigo","Descanoaem", "Descurso", "Cursostamp","Etapa"
                   };
                    if (dt.HasRows())
                    {
                        dt = dt.DefaultView.
                            ToTable(true, campos);
                    }
                    BindCombo(cbTurma, dt);
                    cbTurma.SelectedIndex = 0;
                    Dtv = cbTurma.SelectedItem as DataRowView;
                }
                DtEntidade = cbEntidade.SelectedItem as DataRowView;
                if (!TmpTdocMat.Defa)
                {
                    Numinterno = cbPlanopag.SelectedValue.ToString();
                }
                else
                {
                    Numinterno = $@"Exameespecial_{DateTime.Now.ToShortDateString()}";
                }
                foreach (var item in dtpar.AsEnumerable())
                {
                    if (item != null)
                    {
                        var ckexist = SQL.CheckExist($@"
select fact.factstamp from fact inner join factl
on fact.Factstamp=factl.Factstamp
where
Turmastamp='{tbTurma.Text2.Trim()}'
and clstamp='{Cl.Clstamp}'
and Anosem='{tbAnoSem.tb1.Text}'
and factl.descricao='{item["descricao"]}'");
                        if (!ckexist)
                        {

                            var ft = Utilities.DoAddline<Fact>();
                            HelperFact.FillFactura(ft, Cl, item["Data"].ToDateTimeValue(), TmpTdoc,
                                DtEntidade, Dtv, Numinterno);
                            ft.Ft=true;
                            ft.Movcc=true;
                            var ftl = SQL.Initialize("factl");
                            var dr = ftl.NewRow().Inicialize();
                            HelperFact.FillFactl(item, dr, ft.Factstamp);
                            ftl.Rows.Add(dr);
                            HelperFact.TotaisFt(ft, ftl);
                            ft.MatriculaAluno=TmpTdocMat.Matricula;
                            ft.Inscricao=TmpTdocMat.Inscricao;
                            ft.Nomedoc=TmpTdoc.Descricao;
                            try
                            {
                                if (EF.Save(ft).ret > 0)
                                {
                                    SQL.Save(ftl, "factl", true, ft.Factstamp, "fact");
                                }
                            }
                            catch (Exception)
                            {
                                conta=false;
                            }
                        }
                    }
                }
            }
          
            AgendaDivida();
            if (conta)
            {
                MsBox.Show($@"{Messagem.ParteInicial()}Plano gerado com sucesso");

            }
            else
                MsBox.Show($@"{Messagem.ParteInicial()}Plano gerado com algumas falhas");

        }
    }
}
