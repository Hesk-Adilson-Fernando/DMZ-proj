using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using DMZ.UI.Reports;
using iTextSharp.text;
using Syncfusion.XlsIO.Implementation.XmlSerialization;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DMZ.UI.Classes;
using ComboBox = System.Windows.Forms.ComboBox;

namespace DMZ.UI.UI.Academia
{
    public partial class FrmLancnotas : Basic.FrmClasse2
    {
        private DataTable dtt;
        public FrmLancnotas()
        {
            InitializeComponent();
        }
        private DataTable NiveisCursos { get; set; }

        private void FrmLancnotas_Load(object sender, EventArgs e)
        {
            cbAnulado.Enabled = cbAnulado.Enabled = true;
            if (cbxDescrTestes.Items.Count > 0)
            {
                cbxDescrTestes.SelectedIndex = 0;
                comboBox1_SelectedIndexChanged(sender, e);
            }

            lbDiario.Visible = false;
            var dtCurso = SQL.GetGen2DT("select Cursostamp,Desccurso,Nivel from Curso");
            NiveisCursos=dtCurso;
            BindCombo(cbCurso, dtCurso);
            var dtAnosem = SQL.GetGen2DT("select AnoSemstamp,codigo from AnoSem order by codigo");
            BindCombo(cbAnosem, dtAnosem);
            PintarCelulaMediaCelulas();
            EditMode=true;
            tbetapasem.btnProcura2.Visible=false;
        }

        public void BindCombo(ComboBox cb, DataTable dt)
        {
            cb.DataSource = dt;
            cb.DisplayMember = dt.Columns[1].ToString();
            cb.ValueMember = dt.Columns[0].ToString();
        }
        //Vamos falar deposi, deixa eu estar a mexer o seu pc
        private void cbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursostamp=string.Empty;
            var xx = cbCurso.SelectedItem as DataRowView;
            if (xx != null)
            {
                Cursostamp = xx["Cursostamp"].ToString().Trim();
                var gen2Dt = SQL.GetGen2DT($"select Turmastamp,Codigo from Turma where " +
                                        $"Cursostamp='{xx["Cursostamp"].ToString().Trim()}'");
                BindCombo(cbTurma, gen2Dt);
            }
        }

        private string Pestamp { get; set; } = string.Empty;
        private void btnProcurar_Click(object sender, EventArgs e)
        {
            Pestamp = string.Empty;
            if (cbDisplina.SelectedValue == null || cbTurma.SelectedValue == null ||
                cbCurso.SelectedValue == null)
            {
                return;
            }
            var xxx = $@" 
select * from(select  *,res30=ResultadoFinal,valor=isnull((select sum(valorpreg)valorpreg from ClCCF() c where c.Clstamp=Alunostamp and c.Turmastamp=Turmastamp and c.descricao like '%TAXA DE EXAME ESPECIAL%'),0)
 from(
select Turmanota.*,sexo3=(select iif(t.Sexo='Femenino','F','M') from cl  t
where t.Clstamp=Turmanota.Alunostamp), 
Sala21=(select t.Codigo from Turma  t where t.Turmastamp=Turmanota.Turmastamp)
,Curso23=(select t.Descurso from Turma  t where t.Turmastamp=Turmanota.Turmastamp),
Periodo24=(select t.Turno from Turma  t where t.Turmastamp=Turmanota.Turmastamp),
Departamento25=(select c.Departamento from Turma t inner join Curso c on t.Cursostamp=c.Cursostamp  where t.Turmastamp=Turmanota.Turmastamp),
Director26=(select isnull('Não definido',c.Director) Director from Turma t inner join Curso c on t.Cursostamp=c.Cursostamp  where t.Turmastamp=Turmanota.Turmastamp),

Patente27=(select iif(c.Director='',c.Director,'(Coronel)') from Turma t inner join Curso c on t.Cursostamp=c.Cursostamp  where t.Turmastamp=Turmanota.Turmastamp)
,Prof28=isnull((select top 1 isnull(Categ,'') from pe where Pedagogico=1)+' '+(select top 1 isnull(Nome,'') from 
pe where Pedagogico=1)+'|'+(select top 1 Locali from pe where Pedagogico=1),''),

Dire29=(select iif(t.Responsavel='','','Não Definido') from Turma t inner join Curso c on 
t.Cursostamp=c.Cursostamp  where t.Turmastamp=Turmanota.Turmastamp),
Nivel=(select c.Nivel from Turma t inner join Curso c on 
t.Cursostamp=c.Cursostamp  where t.Turmastamp=Turmanota.Turmastamp)


  from Turmanota)tmp1)tmp2 where" +
                      $" Cursostamp='{cbCurso.SelectedValue.ToTrim()}'" +
                      $" and Turmastamp ='{cbTurma.SelectedValue.ToTrim()}'" +
                      $" and Anosem='{cbAnosem.Text.Trim()}' and " +
                      $"Coddis='{cbDisplina.SelectedValue.ToString().Trim()}' and activo=0";
            dtt = SQL.GetGen2DT(xxx);

            if (VisualisarExameEpecial)
            {
                //Somente aquele que já pagou
                dtt = dtt.GetTable("valor=0");
            }
            try
            {
                if (dtt.HasRows())
                {
                    if (VisualisarExameNormal)
                    {
                        if (Pbl.Param.Dispensa)
                        {
                            dtt=dtt.GetTable($@"media>9.4 and media<13.5");
                        }
                    }
                    else if (VisualisarExameRecorencia)
                    {
                        if (Pbl.Param.Dispensa)
                        {
                            dtt=dtt.GetTable($@"media>9.4 and media<13.5 and E1<9.4");
                        }
                        else
                        {

                            dtt=dtt.GetTable($@"E1<9.4");
                        }
                    }
                    if (dtt.HasRows())
                    {
                        var exclusao = Pbl.PlanoAvaliacao.GetTable("Notain=0 and Notafin=9.4")
         .DtToList<Planoavall>().FirstOrDefault();

                        var admito = Pbl.PlanoAvaliacao.GetTable("Notain=9.5 and Notafin=13.4")
                            .DtToList<Planoavall>().FirstOrDefault();

                        var dispensa = Pbl.PlanoAvaliacao.GetTable("Notain=13.5 and Notafin=20")
                            .DtToList<Planoavall>().FirstOrDefault();

                        int no = 0;
                        dtt.Columns.Add("Nossss", typeof(int));
                        foreach (DataRow row in dtt.Rows)
                        {
                            no +=1;
                            row["Nossss"] = no;
                            var somatno = Math.Round((row["n1"].ToDecimal() +
                                            row["n2"].ToDecimal() + row["n3"].ToDecimal()) / 3).
                              ToDecimal();
                            if (somatno < 9.5.ToDecimal())
                            {
                                if (exclusao != null)
                                {
                                    row["resultado"] = exclusao.Estado;
                                    row["resultadofinal"] = exclusao.DescexamRecor;
                                }

                                row["mediafinal"] = somatno;
                            }
                            if (somatno >= 9.5.ToDecimal() && somatno <= 13.4.ToDecimal())
                            {
                                if (admito != null) row["resultado"] = admito.Estado;
                                if (dispensa != null) row["resultadofinal"] = dispensa.DescexamRecor;
                            }
                            if (somatno >= 13.5.ToDecimal())
                            {
                                if (dispensa != null)
                                {
                                    row["resultado"] = dispensa.Estado;
                                    row["resultadofinal"] = dispensa.DescexamRecor;
                                }
                                row["mediafinal"] = somatno;
                            }
                            row["media"] = somatno;
                        }
                        btnProcess.Visible = true;
                        lbDiario.Visible = false;
                        gridUiAlunos.SetDataSource(dtt);
                        PintarCelulaMediaCelulas();
                        cbAnulado.Enabled = cbAnulado.Enabled = true;

                        cbAnulado.Checked = false;
                        panel1.Visible = true;
                        cbAnulado.Enabled = true;
                        bool contains = dtt.AsEnumerable().Any(row =>
                            row.Field<bool>("fecho"));
                        if (contains)
                        {
                            panel1.Visible = false;
                            cbAnulado.Checked=true;
                            cbAnulado.Enabled  = false;
                            lbDiario.Visible = true;
                        }
                        tbTotal.Text = $@"{dtt.Rows.Count + " alunos"}";
                        tbProfessor1.Text = dtt.Rows[0]["Profnome"].ToString();
                        tbProfessor2.Text = dtt.Rows[0]["Profnome2"].ToString();
                        Pestamp= dtt.Rows[0]["Pestamp"].ToString();
                    }
                    else
                    {
                        tbTotal.Text ="";
                        tbProfessor1.Text = "";
                        tbProfessor2.Text = "";
                    }
                    DtFiltroImpressao = dtt;

                }
                else
                {
                    MsBox.Show($@"{Messagem.ParteInicial()}Não existem estudantes nas condições indicadas!");
                }
            }
            catch (Exception ex)
            {

                //
            }
        }

        private string Turmastamp { get; set; } = string.Empty;
        private string Ststamp { get; set; } = string.Empty;
        private void cbTurma_SelectedIndexChanged(object sender, EventArgs e)
        {
            Turmastamp = string.Empty;
            var xx = cbTurma.SelectedItem as DataRowView;
            if (xx != null)
            {
                Turmastamp = xx["Turmastamp"].ToString().Trim();
                var qry =
                    $"select distinct Ststamp,Disciplina from Turmadisc where Turmastamp='{xx["Turmastamp"].ToString().Trim()}'";
                var dtt = SQL.GetGen2DT(qry);
                BindCombo(cbDisplina, dtt);
            }
        }

        private void gridUiAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (gridUiAlunos.CurrentCell.OwningColumn.Name.Equals("foto"))
            //{
            //    if (gridUiAlunos.CurrentRow != null)
            //    {
            //        var alunostamp = gridUiAlunos.CurrentRow.Cells["Alunostamp"].Value.ToTrim();
            //        var image = (byte[])SQL.GetField($"select imagem from cl where clstamp='{alunostamp}'");
            //        if (image != null)
            //        {
            //            var imagem = Util.ByteToImage(image);
            //            var m = new ImageBoxTiffViewer();
            //            m.OpenImage(imagem);
            //            m.ShowForm(ParentForm);
            //        }
            //    }
            //}
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            foreach (DataRow dr in dtt.Rows)
            {
                dr["fecho"] = cbAnulado.Checked;
            }
            if (SQL.Save(dtt, "turmanota", false, "", "").numero>0)
            {
                MsBox.Show($"{Messagem.ParteInicial()}Processo gravado com sucesso!");
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridUiAlunos_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUiAlunos.CurrentRow != null)
            {

                var nome = gridUiAlunos.CurrentCell.OwningColumn.Name.ToLower();
                if (nome == "n1" || nome == "n2"|| nome == "n3"|| nome == "e1"||nome == "e2" || nome == "es")
                {
                    var valor = gridUiAlunos.CurrentCell.Value.ToDecimal();
                    if (valor < 0 || valor > 20)
                    {
                        MsBox.Show(" As notas não podem ser menores que zero e nem maiores que 20 ");
                        gridUiAlunos.CurrentCell.Value="0";
                    }
                }

            }
        }
        public string Cursostamp { get; set; }

        public string Anosem { get; set; }
        public bool VisualisarExameNormal { get; set; } = false;
        public bool VisualisarExameRecorencia { get; set; } = false;
        public bool VisualisarExameEpecial { get; set; } = false;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var text = cbxDescrTestes.Text;
            switch (text)
            {
                case "Teste1":
                    SetReadonly(true);
                    break;
                case
                    "Teste2":
                    SetReadonly(false, true);
                    break;
                case "Teste3":
                    SetReadonly(false, false, true);
                    break;
                case "Teste4":
                    SetReadonly(false, false, false, true);
                    break;
                case "Exame normal":
                    SetReadonly(false, false, false, false, true);
                    break;
                case "Exame de Recorrência":
                    SetReadonly(false, false, false, false, false, true);
                    break;
                case "Exame Especial":
                    SetReadonly(false, false, false, false, false, false, true);
                    break;
            }
        }

        public void SetReadonly(bool ns1 = false, bool ns2 = false,
            bool ts1 = false,
            bool ts2 = false,
            bool es1 = false,
            bool es2 = false,
            bool ess = false)
        {
            n1.ReadOnly = !ns1;
            n2.ReadOnly = !ns2;
            n3.ReadOnly = !ts1;
            n4.ReadOnly = !ts2;
            E1.ReadOnly = !VisualisarExameNormal;
            E2.ReadOnly = !VisualisarExameRecorencia;
            Es.ReadOnly = !VisualisarExameEpecial;
            E1.Visible = VisualisarExameNormal;
            E2.Visible = VisualisarExameRecorencia;
            if (VisualisarExameRecorencia)
            {
                E1.ReadOnly = true;
            }
            if (VisualisarExameRecorencia || VisualisarExameNormal || VisualisarExameEpecial)
            {
                n2.Visible = n3.Visible = n4.Visible = n1.Visible=Resultado.Visible = false;
            }
            if (!VisualisarExameRecorencia && !VisualisarExameNormal && !VisualisarExameEpecial)
            {
                ResultadoFinal.Visible  = false;
            }
            Es.Visible = VisualisarExameEpecial;
        }
        //Leva  o form que te passei
        private void gridUiAlunos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var cur = gridUiAlunos.CurrentRow;

            if (!VisualisarExameRecorencia && !VisualisarExameEpecial && !VisualisarExameNormal)
            {
                if (cur != null)
                {
                    var nota1 = cur.Cells["n1"].Value.ToString().ToDecimal();
                    var nota2 = cur.Cells["n2"].Value.ToDecimal();
                    var nota3 = cur.Cells["n3"].Value.ToDecimal();
                    var med = Math.Round((nota1 + nota2 + nota3) / 3).ToRound(0);
                    cur.Cells["MdTra"].Value = med.ToString(CultureInfo.InvariantCulture);
                    if (med < 9.5.ToDecimal())
                    {
                        cur.Cells["resultado"].Value = "Excluído";
                        cur.DefaultCellStyle.BackColor = Color.Red;
                    }
                    if (med >= 9.5.ToDecimal() && med < 13.5.ToDecimal())
                    {
                        cur.DefaultCellStyle.BackColor = Color.DarkGray;
                        cur.DefaultCellStyle.SelectionForeColor = Color.Black;
                        cur.Cells["resultado"].Value = "Admitido";
                    }
                    if (med >= 13.5.ToDecimal())
                    {
                        cur.Cells["resultado"].Value = "Dispensado";
                        cur.DefaultCellStyle.BackColor = Color.Green;
                    }
                }
            }
            if (VisualisarExameNormal || VisualisarExameRecorencia|| VisualisarExameEpecial)
            {
                var r = cur;
                if (cur != null)
                {
                    var med = cur.Cells["MdTra"].Value.ToDecimal().ToRound(0); //Math.Round ((nota1 + nota2 + nota3) / 3).ToRound(0);
                    if (VisualisarExameNormal)
                    {

                        if (med < 9.5.ToDecimal())
                        {
                            r.Cells["ResultadoFinal"].Value = "Reprovado";
                            r.DefaultCellStyle.BackColor = Color.Red;
                        }
                        else if (med >= 9.5.ToDecimal() && med < 13.5.ToDecimal() && cur.Cells["E1"].Value.ToDecimal() <
                                 9.5.ToDecimal())
                        {
                            r.Cells["ResultadoFinal"].Value = "Reprovado";
                            r.DefaultCellStyle.BackColor = Color.Red;
                        }
                        else if (med >= 9.5.ToDecimal() && med < 13.5.ToDecimal() && cur.Cells["E1"].Value.ToDecimal() >=
                                 9.5.ToDecimal())
                        {
                            r.Cells["ResultadoFinal"].Value = "Aprovado";
                            r.DefaultCellStyle.BackColor = Color.Green;
                        }
                        else if (med >= 13.5.ToDecimal())
                        {
                            r.Cells["ResultadoFinal"].Value = "Aprovado";
                            r.DefaultCellStyle.BackColor = Color.Green;
                        }
                    }
                    if (VisualisarExameRecorencia)
                    {
                        if (med < 9.5.ToDecimal())
                        {
                            r.Cells["ResultadoFinal"].Value = "Reprovado";
                            r.DefaultCellStyle.BackColor = Color.Red;
                        }
                        else if (med >= 9.5.ToDecimal() && med < 13.5.ToDecimal() && cur.Cells["E2"].Value.ToDecimal() <
                                 9.5.ToDecimal())
                        {
                            r.Cells["ResultadoFinal"].Value = "Reprovado";
                            r.DefaultCellStyle.BackColor = Color.Red;
                        }
                        else if (med >= 9.5.ToDecimal() && med < 13.5.ToDecimal() && cur.Cells["E2"].Value.ToDecimal() >=
                                 9.5.ToDecimal())
                        {
                            r.Cells["ResultadoFinal"].Value = "Aprovado";
                            r.DefaultCellStyle.BackColor = Color.Green;
                        }
                        else if (med >= 13.5.ToDecimal())
                        {
                            r.Cells["ResultadoFinal"].Value = "Aprovado";
                            r.DefaultCellStyle.BackColor = Color.Green;
                        }
                    }
                    if (VisualisarExameEpecial)
                    {
                        if (cur.Cells["Es"].Value.ToDecimal() <
                             9.5.ToDecimal())
                        {
                            r.Cells["ResultadoFinal"].Value = "Reprovado";
                            r.DefaultCellStyle.BackColor = Color.Red;
                        }
                        else if (cur.Cells["Es"].Value.ToDecimal() >=
                                 9.5.ToDecimal())
                        {
                            cur.Cells["MdTra"].Value = cur.Cells["Media"].Value = cur.Cells["E1"].Value = cur.Cells["E2"].Value = cur.Cells["n2"].Value= cur.Cells["n3"].Value=cur.Cells["n1"].Value= cur.Cells["Es"].Value.ToDecimal();
                            r.Cells["ResultadoFinal"].Value = "Aprovado";
                            r.DefaultCellStyle.BackColor = Color.Green;

                        }
                    }
                }
            }

        }



        private void PintarCelulaMediaCelulas()
        {
            foreach (DataGridViewRow r in gridUiAlunos.Rows)
            {
                var cur = r;
                var nota1 = cur.Cells["n1"].Value.ToDecimal();
                var nota2 = cur.Cells["n2"].Value.ToDecimal();
                var nota3 = cur.Cells["n3"].Value.ToDecimal();
                var med = ((nota1 + nota2 + nota3) / 3).ToRound(0);
                if (!VisualisarExameRecorencia && !VisualisarExameEpecial && !VisualisarExameNormal)
                {
                    cur.Cells["MdTra"].Value = med.ToString(CultureInfo.InvariantCulture);
                    if (med < 9.5.ToDecimal())
                    {
                        cur.Cells["Resultado"].Value = "Excluído";
                        r.DefaultCellStyle.BackColor= Color.Red;
                    }
                    if (med >= 9.5.ToDecimal() && med < 13.5.ToDecimal())
                    {
                        cur.Cells["Resultado"].Value = "Admitido";
                    }
                    if (med >= 13.5.ToDecimal())
                    {
                        cur.Cells["Resultado"].Value = "Dispensado";
                        r.DefaultCellStyle.BackColor = Color.Green;
                    }
                }
                if (VisualisarExameNormal)
                {
                    if (med < 9.5.ToDecimal())
                    {
                        cur.Cells["ResultadoFinal"].Value = "Reprovado";
                        r.DefaultCellStyle.BackColor = Color.Red;
                    }
                    else if (med >= 9.5.ToDecimal() && med < 13.5.ToDecimal() && cur.Cells["E1"].Value.ToDecimal()<
                             9.5.ToDecimal())
                    {
                        cur.Cells["ResultadoFinal"].Value = "Reprovado";
                        r.DefaultCellStyle.BackColor = Color.Red;
                    }
                    else if (med >= 9.5.ToDecimal() && med < 13.5.ToDecimal() && cur.Cells["E1"].Value.ToDecimal() >=
                             9.5.ToDecimal())
                    {
                        cur.Cells["ResultadoFinal"].Value = "Aprovado";
                        r.DefaultCellStyle.BackColor = Color.Green;
                    }
                    else if (med >= 13.5.ToDecimal())
                    {
                        cur.Cells["ResultadoFinal"].Value = "Aprovado";
                        r.DefaultCellStyle.BackColor = Color.Green;
                    }
                }

                if (VisualisarExameRecorencia)
                {
                    if (med < 9.5.ToDecimal())
                    {
                        cur.Cells["ResultadoFinal"].Value = "Reprovado";
                        r.DefaultCellStyle.BackColor = Color.Red;
                    }
                    else if (med >= 9.5.ToDecimal() && med < 13.5.ToDecimal() && cur.Cells["E2"].Value.ToDecimal() <
                             9.5.ToDecimal())
                    {
                        cur.Cells["ResultadoFinal"].Value = "Reprovado";
                        r.DefaultCellStyle.BackColor = Color.Red;
                    }
                    else if (med >= 9.5.ToDecimal() && med < 13.5.ToDecimal() && cur.Cells["E2"].Value.ToDecimal() >=
                             9.5.ToDecimal())
                    {
                        cur.Cells["ResultadoFinal"].Value = "Aprovado";
                        r.DefaultCellStyle.BackColor = Color.Green;
                    }
                    else if (med >= 13.5.ToDecimal())
                    {
                        cur.Cells["ResultadoFinal"].Value = "Aprovado";
                        r.DefaultCellStyle.BackColor = Color.Green;
                    }
                }
            }


        }



        private void cbDisplina_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ststamp = string.Empty;
            Ststamp = ExtrairDadosDoCombobox(cbDisplina, "Ststamp");
        }

        private void cbAnosem_SelectedIndexChanged(object sender, EventArgs e)
        {
            Anosem = string.Empty;
            Anosem= ExtrairDadosDoCombobox(cbAnosem, "codigo");
        }

        private string ExtrairDadosDoCombobox(ComboBox xxx, string campo)
        {
            var ss = string.Empty;
            var xx = xxx.SelectedItem as DataRowView;
            if (xx != null)
            {
                ss = xx[campo].ToString().Trim();
            }
            return ss;
        }

        private void Imprimir(string orig)
        {
            DS ds = new DS();
            if (cbxDescrTestes.Text.IsNullOrEmpty() || Anosem.IsNullOrEmpty() || Ststamp.IsNullOrEmpty() ||
                Pestamp.IsNullOrEmpty()
                || Turmastamp.IsNullOrEmpty() || Cursostamp.IsNullOrEmpty())
            {
                MsBox.Show("Parâmetros de impressão não preenchidos, por favor, preencha-os!");
                return;
            }

            DataColumnCollection columns = NiveisCursos.Columns;

            #region Query Licenciatura
            //var qyer= $@"
            //select  *,res30=iif(Mdfre13<9.5,'Reprovado',
            //iif(Mdfre13>=13.5,'Aprovado',iif(E15<9.5,iif(E16<9.5,'Reprovado','Aprovado'),'Aprovado'))) from(
            //select UPPER(Disciplina) Disciplina1,Alunonome 'Alunonome2',sexo3=(select iif(t.Sexo='Femenino','F','M') from cl  t
            //where t.Clstamp=Turmanota.Alunostamp),Profnome 'Profnome4',No no5,N1 n6,N2 n7,N3 n8,MD9=(n1+n2)/2,N3 n10,N4 n11,MDT12=(n3+n4)/2,
            //Mdfre13=Media,
            //ResFrequ14=
            //iif(((Media))<9.5,'Excluido',
            //iif(((Media))>9.5 and ((Media))<13.5,'Admitido','Dispensado'))
            //,
            //E1 E15,E2 E16,E17= iif(((Media))/1>=13.5,((Media))/1,iif(E1<9.5,E2,E1)), Es E18,

            //Resultado19=
            //iif(Media>13.5,'Aprovado',iif(MediaFinal<9.5,'Reprovado','Aprovado'))

            //,Anosem Anosem20,Sala21=(select Sala from Turma  t where t.Turmastamp=Turmanota.Turmastamp),Turmanota.Sem sem22
            //,Curso23=(select t.Descurso from Turma  t where t.Turmastamp=Turmanota.Turmastamp),
            //Periodo24=(select t.Turno from Turma  t where t.Turmastamp=Turmanota.Turmastamp),
            //Departamento25=(select c.Departamento from Turma t inner join Curso c on t.Cursostamp=c.Cursostamp  where t.Turmastamp=Turmanota.Turmastamp),
            //Director26=(select isnull('Não definido',c.Director) Director from Turma t inner join Curso c on t.Cursostamp=c.Cursostamp  where t.Turmastamp=Turmanota.Turmastamp),

            //Patente27=(select iif(c.Director='Aniva',c.Director,'(Coronel)') from Turma t inner join Curso c on t.Cursostamp=c.Cursostamp  where t.Turmastamp=Turmanota.Turmastamp)
            //,Prof28='Prof. Doutor Elias Achimo Aly'+'|'+(select iif(c.Director='Aniva',c.Director,'(Coronel)') from Turma t inner join Curso c on t.Cursostamp=c.Cursostamp  where t.Turmastamp=Turmanota.Turmastamp),

            //Dire29=(select iif(t.Responsavel='Aniva','','Não Definido') from Turma t inner join Curso c on 
            //t.Cursostamp=c.Cursostamp  where t.Turmastamp=Turmanota.Turmastamp),
            //Nivel=(select c.Nivel from Turma t inner join Curso c on 
            //t.Cursostamp=c.Cursostamp  where t.Turmastamp=Turmanota.Turmastamp)


            //  from Turmanota


            // where Coddis='{Ststamp.Trim()}' and  Turmastamp='{Turmastamp.ToTrim()}' and Pestamp='{Pestamp}' and Cursostamp='{Cursostamp.ToTrim()}' 
            //and Anosem='{Anosem?.Trim()}')tmp1 where nivel='mestrado'
            //";
            #endregion


            var xmlString = "";
            if (columns.Contains("Nivel"))
            {
                var ss = NiveisCursos.GetTable($"Cursostamp='{Cursostamp}'");
                if (ss.HasRows())
                {
                    var niv = ss.Rows[0]["Nivel"].ToString().ToLower();
                    switch (niv)
                    {
                        case "licenciatura":
                            #region Pauta Licenciatura

                            var campos = new[]
                   {
                                "Disciplina","AlunoNome",
                                "sexo3","Profnome","no","n1","n2","profnome2","codetapa","n3","n4",
                                "obs","media","Resultado","e1","e2","es","motivo",
                                "Resultadofinal","anosem","sala21","sem","curso23",
                                "periodo24","Departamento25", "director26","patente27",
                                "prof28","dire29","nivel","res30"
                   };//profnome2,codetapa,fecho,motivo
                            var dt = gridUiAlunos.GetBindedTable();
                            if (dt.HasRows())
                            {
                                dt = dt.DefaultView.
                                     ToTable(true, campos);
                            }
                            var dtsAlunos = dt;

                            #region Segunda Query
                            var qry2 = $@"
select 
SUM(CASE WHEN sexo3 ='M' THEN 1 ELSE 0 END) AS totalMasculinoAvaliados,

SUM(CASE WHEN sexo3 ='F' THEN 1 ELSE 0 END) AS totalFemininoAvaliados,
SUM(CASE WHEN sexo3 ='F' THEN 1 ELSE 0 END)+SUM(CASE WHEN sexo3 ='M' THEN 1 ELSE 0 END) AS totalAvaliados,

SUM(CASE WHEN sexo3 ='M' and ResFrequ14='Excluido'  THEN 1 ELSE 0 END) AS totalMasculinoExcluido,

SUM(CASE WHEN sexo3 ='F' and ResFrequ14='Excluido' THEN 1 ELSE 0 END) AS totalFemininoExcluido,
SUM(CASE WHEN ResFrequ14='Excluido' THEN 1 ELSE 0 END) AS totalExcluido,

SUM(CASE WHEN sexo3 ='M' and ResFrequ14='Admitido'  THEN 1 ELSE 0 END) AS totalMasculinoAdmitido,

SUM(CASE WHEN sexo3 ='F' and ResFrequ14='Admitido' THEN 1 ELSE 0 END) AS totalFemininoAdmitido,
SUM(CASE WHEN ResFrequ14='Admitido' THEN 1 ELSE 0 END) AS totalAdmitidoo,

SUM(CASE WHEN sexo3 ='M' and ResFrequ14='Dispensado'  THEN 1 ELSE 0 END) AS totalMasculinoDispensado,

SUM(CASE WHEN sexo3 ='F' and ResFrequ14='Dispensado' THEN 1 ELSE 0 END) AS totalFemininoDispensado,
SUM(CASE WHEN  ResFrequ14='Dispensado' THEN 1 ELSE 0 END) AS totalDispensado,Professor='{tbProfessor1.Text}',Anosems='{Anosem?.Trim()}'

from(select UPPER(Disciplina) Disciplina1,Alunonome 'Alunonome2',sexo3=(select iif(t.Sexo='Femenino','F','M') from cl  t
where t.Clstamp=Turmanota.Alunostamp),Profnome 'Profnome4',No no5,N1 n6,N2 n7,N3 n8,MD9=(n1+n2)/2,N3 n10,N4 n11,MDT12=(n3+n4)/2,
Mdfre13=(((n1+n2)/2)+(n3+n4)/2)/2,
ResFrequ14=

iif((((n1+n2)/2)+(n3+n4)/2)/2<9.5,'Excluido',
iif((((n1+n2)/2)+(n3+n4)/2)/2>9.5 and (((n1+n2)/2)+(n3+n4)/2)/2<13.5,'Admitido','Dispensado'))
,

E1 E15,E2 E16,E17= iif((((n1+n2)/2)+(n3+n4)/2)/2>=13.5,(((n1+n2)/2)+(n3+n4)/2)/2,iif(E1<9.5,E2,E1)), Es E18,

Resultado19=iif((((n1+n2)/2+(n3+n4)/2+
iif(E1<9.5,iif(E2<9.5,iif(Es<9.5,0,Es),E2),E1)
)/2)<9.5,'Reprovado','Aprovado' )

,Anosem Anosem20,Sala21=(select Sala from Turma  t where t.Turmastamp=Turmanota.Turmastamp),Turmanota.Sem sem22
,Curso23=(select t.Descurso from Turma  t where t.Turmastamp=Turmanota.Turmastamp),
Periodo24=(select t.Turno from Turma  t where t.Turmastamp=Turmanota.Turmastamp),
Departamento25=(select c.Departamento from Turma t inner join Curso c on t.Cursostamp=c.Cursostamp  where t.Turmastamp=Turmanota.Turmastamp),
Director26=(select isnull('Não definido',c.Director) Director from Turma t 
inner join Curso c on t.Cursostamp=c.Cursostamp  where t.Turmastamp=Turmanota.Turmastamp),

Patente27=(select iif(c.Director='Aniva',c.Director,'(Coronel)') from Turma t 
inner join Curso c on t.Cursostamp=c.Cursostamp  where t.Turmastamp=Turmanota.Turmastamp)

  from Turmanota 
  where Coddis='{Ststamp.Trim()}' and  Turmastamp='{Turmastamp.ToTrim()}' 
 and Pestamp='{Pestamp}' and Cursostamp='{Cursostamp.ToTrim()}' 
and Anosem='{Anosem?.Trim()}')tmp1
";




                            var dtsProfessores = SQL.GetGen2DT(qry2);

                            #endregion
                            var ret = Classes.Imprimir.FillData(ds.DMZ, dtsAlunos, null,
                                ds.DMZ, ds.Formasp);
                            switch (orig.ToLower())
                            {
                                case "frequencia":
                                    xmlString = SQL.GetXmlReport("RptPautaLicenciaturaFrequencia");
                                    Fmottttt(ret, xmlString, ds, dtsProfessores,
                                        "PautaFreq",
                                        "RptPautaLicenciaturaFrequencia");
                                    break;
                                case "exmnormal":
                                    xmlString = SQL.GetXmlReport("RptPautaLicenciaturaExamNormal");
                                    Fmottttt(ret, xmlString, ds, dtsProfessores,
                                        "PautaExamNrmal",
                                        "RptPautaLicenciaturaExamNormal");
                                    break;
                                case "exmrecorrencia":
                                    xmlString = SQL.GetXmlReport("RptPautaLicenciaturaExamRecorr");
                                    Fmottttt(ret, xmlString, ds, dtsProfessores,
                                        "PautaExamRecorre",
                                        "RptPautaLicenciaturaExamRecorr");

                                    break;
                                case "exmespecial":
                                    xmlString = SQL.GetXmlReport("RptPautaLicenciaturaExamEspecial");
                                    Fmottttt(ret, xmlString, ds, dtsProfessores,
                                        "PautaEspecial",
                                        "RptPautaLicenciaturaExamEspecial");

                                    break;
                                default:
                                    Fmottttt(ret, xmlString, ds, dtsProfessores,
                                        "PautaLice",
                                        "RptPautaLicenciatura");
                                    break;
                            }

                            #endregion

                            break;


                        case "mestrado":

                            #region Pauta Mestraddo

                            var qyerlll = $@"
select  *,res30=iif(Mdfre13<9.5,'Reprovado',
iif(Mdfre13>=13.5,'Aprovado',iif(E15<9.5,iif(E16<9.5,'Reprovado','Aprovado'),'Aprovado'))) from(
select UPPER(Disciplina) Disciplina1,Alunonome 'Alunonome2',sexo3=(select iif(t.Sexo='Femenino','F','M') from cl  t
where t.Clstamp=Turmanota.Alunostamp),Profnome 'Profnome4',No no5,N1 n6,N2 n7,N3 n8,MD9=(n1+n2)/2,N3 n10,N4 n11,MDT12=(n3+n4)/2,
Mdfre13=Media,
ResFrequ14=
iif(((Media))<9.5,'Excluido',
iif(((Media))>9.5 and ((Media))<13.5,'Admitido','Dispensado'))
,
E1 E15,E2 E16,E17= iif(((Media))/1>=13.5,((Media))/1,iif(E1<9.5,E2,E1)), Es E18,

Resultado19=
iif(Media>13.5,'Aprovado',iif(MediaFinal<9.5,'Reprovado','Aprovado'))

,Anosem Anosem20,Sala21=(select Sala from Turma  t where t.Turmastamp=Turmanota.Turmastamp),Turmanota.Sem sem22
,Curso23=(select t.Descurso from Turma  t where t.Turmastamp=Turmanota.Turmastamp),
Periodo24=(select t.Turno from Turma  t where t.Turmastamp=Turmanota.Turmastamp),
Departamento25=(select c.Departamento from Turma t inner join Curso c on t.Cursostamp=c.Cursostamp  where t.Turmastamp=Turmanota.Turmastamp),
Director26=(select isnull('Não definido',c.Director) Director from Turma t inner join Curso c on t.Cursostamp=c.Cursostamp  where t.Turmastamp=Turmanota.Turmastamp),

Patente27=(select iif(c.Director='Aniva',c.Director,'(Coronel)') from Turma t inner join Curso c on t.Cursostamp=c.Cursostamp  where t.Turmastamp=Turmanota.Turmastamp)
,Prof28='Prof. Doutor Elias Achimo Aly'+'|'+(select iif(c.Director='Aniva',c.Director,'(Coronel)') from Turma t inner join Curso c on t.Cursostamp=c.Cursostamp  where t.Turmastamp=Turmanota.Turmastamp),

Dire29=(select iif(t.Responsavel='Aniva','','Não Definido') from Turma t inner join Curso c on 
t.Cursostamp=c.Cursostamp  where t.Turmastamp=Turmanota.Turmastamp),
Nivel=(select c.Nivel from Turma t inner join Curso c on 
t.Cursostamp=c.Cursostamp  where t.Turmastamp=Turmanota.Turmastamp)


  from Turmanota
  
  
 where Coddis='{Ststamp.Trim()}' and  Turmastamp='{Turmastamp.ToTrim()}' and Pestamp='{Pestamp}' and Cursostamp='{Cursostamp.ToTrim()}' 
and Anosem='{Anosem?.Trim()}')tmp1 where nivel='mestrado'
";

                            var dtsAlunogggggs = SQL.GetGen2DT(qyerlll);


                            var refft = Classes.Imprimir.FillData(ds.DMZ,
                                dtsAlunogggggs, null,
                                ds.DMZ, ds.Formasp);

                            #region xml


                            xmlString = SQL.GetXmlReport("RptPautaMestrado");

                            #endregion

                            Classes.Imprimir.CallForm(refft.dtPrint, refft.fp, CLocalStamp, false,
                                label1.Text, "", "RptPautaMestrado",
                                "PautaMestrado", this, xmlString, true,
                                ds, "", "",
                                null
                            );

                            #endregion

                            break;
                    }
                }
            }
        }

        private void Fmottttt((DataTable dtPrint, DataTable fp) ret, string xmlString,
            DS ds, DataTable dtsProfessores, string origem, string nomfile)
        {
            Classes.Imprimir.CallForm(ret.dtPrint, ret.fp, CLocalStamp, false,
                label1.Text, "", nomfile,
                origem, this, xmlString, true, ds, "", "",
                null
                , dtsProfessores);
        }

        private void btnPrint2_Click(object sender, EventArgs e)
        {
            Frota.ShowMenuStrip(btnPrint2);
        }

        private void PtFreq_Click(object sender, EventArgs e)
        {
            Imprimir("Frequencia");
        }

        private void ExamNrm_Click(object sender, EventArgs e)
        {
            Imprimir("ExmNormal");
        }


        private void ExamRecorr_Click(object sender, EventArgs e)
        {
            Imprimir("ExmRecorrencia");
        }

        private void ExmEspecial_Click(object sender, EventArgs e)
        {
            Imprimir("ExmEspecial");
        }

        private void cbAnulado_CheckedChangeds()
        {

            if (dtt.HasRows())
            {
                foreach (DataRow row in dtt.Rows)
                {
                    row["fecho"] = cbAnulado.Checked;
                }
            }
            gridUiAlunos.Update();
        }

        private void cbAnulado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private DataTable DtFiltroImpressao
        {
            get;
            set;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbetapasem_TextChangValues()
        {
            //Leve o nome tbeta

            if (DtFiltroImpressao.HasRows())
            {
                DataView dv = new DataView(DtFiltroImpressao);
                dv.RowFilter = "((CONVERT(no, 'System.String') like '%" + tbetapasem.tb1.Text.Replace("'", "") + "%') " +
                               " OR (AlunoNome like '%" + tbetapasem.tb1.Text.Replace("'", "") + "%')) ";

                gridUiAlunos.SetDataSource(dv.ToTable());
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
