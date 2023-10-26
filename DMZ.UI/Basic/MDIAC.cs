using System;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Classes;
using DMZ.UI.Generic;
using DMZ.UI.UI;
using DMZ.UI.UI.Academia;
using DMZ.UI.UI.RH;

namespace DMZ.UI.Basic
{
    public partial class Mdiac : Form
    {
        public Mdiac()
        {
            InitializeComponent();
        }

        public bool OpenFromModulo { get; set; }

        private void btnConfiguracao_DoClick()
        {
            ACConfiguracao.ShowMenuStrip(btnConfiguracao.btnCadastro);
        }

        private void btnReligiao_Click(object sender, EventArgs e)
        {
            var b = new FrmAlauxiliar
            {
                Tabela = 1,
                Desctabela = "Religião"
            };
            b.ShowForm(this);
        }

        private void btnNivelAcademico_Click(object sender, EventArgs e)
        {
            var b = new FrmPeAuxilar
            {
                Tabela = 11,
                Desctabela = "Nivel Académico"
            };
            b.ShowForm(this);
        }

        private void btnRegimeCasamento_Click(object sender, EventArgs e)
        {
            var b = new FrmPeAuxilar
            {
                Tabela = 10,
                Desctabela = "Regime do Casamento"
            };
            b.ShowForm(this);
        }

        private void btnEstadoCivil_Click(object sender, EventArgs e)
        {
            var b = new FrmPeAuxilar
            {
                Tabela = 9,
                Desctabela = "Estado Civil"
            };
            b.ShowForm(this);
        }

        private void btnTipoSexo_Click(object sender, EventArgs e)
        {
            var b = new FrmPeAuxilar
            {
                Tabela = 8,
                Desctabela = "Tipo de Sexo"
            };
            b.ShowForm(this);
        }

        private void btnGrauParentesco_Click(object sender, EventArgs e)
        {
            var b = new FrmPeAuxilar
            {
                Tabela = 7,
                Desctabela = "Grau Parentesco"
            };
            b.ShowForm(this);
        }

        private void tsmTipoDocumento_Click(object sender, EventArgs e)
        {
            var b = new FrmPeAuxilar
            {
                Tabela = 1,
                Desctabela = "Tipo de Documento"
            };
            b.ShowForm(this);
        }

        private void linguaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmPeAuxilar
            {
                Tabela = 2,
                Desctabela = "Lingua"
            };
            b.ShowForm(this);
        }

        private void classificaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmPeAuxilar
            {
                Tabela = 12,
                Desctabela = "Classificação"
            };
            b.ShowForm(this);
        }

        private void sindicatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmPeAuxilar
            {
                Tabela = 13,
                Desctabela = "Sindicatos"
            };
            b.ShowForm(this);
        }

        private void profissãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmPeAuxilar
            {
                Tabela = 14,
                Desctabela = "Profissões"
            };
            b.ShowForm(this);
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmPeAuxilar
            {
                Tabela = 15,
                Desctabela = "Categorias"
            };
            b.ShowForm(this);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var b = new FrmPeAuxilar
            {
                Tabela = 16,
                Desctabela = "Instituição de formação"
            };
            b.ShowForm(this);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var b = new FrmPeAuxilar
            {
                Tabela = 17,
                Desctabela = "Cursos"
            };
            b.ShowForm(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!OpenFromModulo)
            {
                Application.Exit(); 
            }
            else
            {
                Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnEscolas_Click(object sender, EventArgs e)
        {
            var b = new FrmAlauxiliar {Tabela = 2, Desctabela = "Escolas", Height2 = true};
            b.ShowForm(this);
        }

        private void btnInstbolsa_Click(object sender, EventArgs e)
        {
            var b = new FrmAlauxiliar {Tabela = 3, Desctabela = "Instituições de bolsa"};
            b.ShowForm(this);

        }

        private void btnTipobolsa_Click(object sender, EventArgs e)
        {
            var b = new FrmAlauxiliar {Tabela = 4, Desctabela = "Tipo de bolsa"};
            b.ShowForm(this);
        }

        private void btnEstudante_ClickEvent()
        {
            var w = new FrmAluno {label1 = {Text = @"Ficha do Estudante"}};
            w.ShowForm(this);
        }

        private void btnProfessor_ClickEvent()
        {
            var w = new FrmPes {label1 = {Text = @"Ficha do Docente"}, Modulo = "AC"};
            w.ShowForm(this);
        }

        private void Mdiac_Load(object sender, EventArgs e)
        {
           //if (Controls != null) 
              //  Controls.OfType<MdiClient>().FirstOrDefault().BackColor= Color.WhiteSmoke;
            //Controls.OfType<MdiClient>().FirstOrDefault().BackgroundImage=Properties.Resources._28_Free_Books_for_Learning_Software_Architecture;
            //lblData.label1.Text = Pbl.SqlDate.ToShortDateString();
            //lblEmpresa.label1.Text = Pbl.Empresa;
            timer1.Start();
        }

        private void btnPw_Click(object sender, EventArgs e)
        {
            var p = new FrmPw ();
            p.ShowForm(this, true);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.label1.Text = Helper.Horas(); //DateTime.Now.();
        }

        private void diáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAcademico_DoClick()
        {
            Academico.ShowMenuStrip(btnAcademico.btnCadastro);
        }

        private void btnFinanceiro_DoClick()
        {
            Financeiro.ShowMenuStrip(btnFinanceiro.btnCadastro);
        }

        private void disciplinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var w = new FrmDisc( );
            w.ShowForm(this);
        }

        private void feriadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var w = new FrmFeriado( );
            w.ShowForm(this);
        }

        private void unidadeeDeEnsinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var w = new FrmCCusto( );
            w.ShowForm(this);
        }

        private void dmzLateralButton1_Load(object sender, EventArgs e)
        {

        }

        private void dmzLateralButton2_Load(object sender, EventArgs e)
        {

        }

        private void btnAcademico_Load(object sender, EventArgs e)
        {

        }

        private void anoLectivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tipoDeEnsinosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salasDeAulasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void avaliaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
