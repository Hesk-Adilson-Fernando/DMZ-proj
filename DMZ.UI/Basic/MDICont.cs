using System;
using System.Drawing;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Classes;
using DMZ.UI.Generic;
using DMZ.UI.UI;
using DMZ.UI.UI.Contabil;
using DMZ.UI.UI.RH;

namespace DMZ.UI.Basic
{
    public partial class MdiCont : Form
    {
        public MdiCont()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
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

        public bool OpenFromModulo { get; set; }

        private void Maximizar()
        {
            Size = Screen.PrimaryScreen.WorkingArea.Size;
            Location = Screen.PrimaryScreen.WorkingArea.Location;
        }
        
        private void MdiCont_Load(object sender, EventArgs e)
        {
            Maximizar();
            LBLiNFO.Text = Pbl.Info;
            Text = Pbl.Info;
            lblEmpresa.label1.Text = Pbl.Empresa.Nome.ToUpper();
            timer1.Start();
            dmzUsr.label1.Text = Pbl.Usr.Nome;
            UpdateAnoCont();
            dmzMenuSuporte.Visible = Pbl.Usr.Usradmin;
            //BackgroundImage = Properties.Resources.pexels_rodolfo_clix_1036936;
        }

        public void UpdateAnoCont()
        {
            lblAno.Text = @"Ano: "+Pbl.AnoContabil();
        }

        private void dmzMenuButton1_Load(object sender, EventArgs e)
        {
            //Codigos.ShowMenuStrip(btnCodigos.btnOpcoes);
        }

        private void btnApuramento_DoClick()
        {
            Funcionalid.ShowMenuStrip(btnApuramento.btnCadastro);
        }

        private void btnConfiguracao_DoClick()
        {
            CTConfiguracao.ShowMenuStrip(btnConfiguracao.btnCadastro);
        }

        private void btnRelat_DoClick()
        {
            Relatorios.ShowMenuStrip(btnRelat.btnCadastro);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPGC_Load(object sender, EventArgs e)
        {

        }

        private void btnPGC_DoClick()
        {
            var w = new Pc();
            w.ShowForm(this);
        }

        private void btnParametros_Click(object sender, EventArgs e)
        {
            var w = new FrmParam();
            w.ShowForm(this);
        }

        private void btnDiarios_DoClick()
        {
            var w = new FrmDiario();
            w.ShowForm(this);
        }

        private void btnDossiers_DoClick()
        {
            var w = new FrmDpd();
            w.ShowForm(this);
        }

        private void btnProcessos_DoClick()
        {
            var w = new FrmLContab();
            w.ShowForm(this);
        }

        private void dmzMenuSuporte_DoClick()
        {
          Suporte.ShowMenuStrip(dmzMenuSuporte.btnCadastro);
        }

        private void MenuEmpresa_Click(object sender, EventArgs e)
        {
            var b = new FrmEmpresa();
            b.ShowForm(this);
        }

        private void passwordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmPw();
            b.ShowForm(this);
        }

        private void MenuUsuario_Click(object sender, EventArgs e)
        {
            var b = new FrmUsr();
            b.ShowForm(this);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.label1.Text = DateTime.Now.ToString("HH:mm:ss");
            lblData.label1.Text= Pbl.SqlDate.ToShortDateString();
        }

        private void mesesDaContabilidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new Mesescont();
            b.ShowForm(this);
        }

        private void AnoContabilistico_Click(object sender, EventArgs e)
        {
            var b = new Anocont {SAno = UpdateAnoCont};
            b.ShowForm(this);
        }

        private void lblAno_DoubleClick(object sender, EventArgs e)
        {
            var b = new Anocont {SAno = UpdateAnoCont};
            b.ShowForm(this);
        }

        private void IniciarPlanosDisarios_Click(object sender, EventArgs e)
        {
            var b = new Pcdiario();
            b.ShowForm(this);
        }

        private void saldosIniciaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new SI();
            b.ShowForm(this);
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            var b = new DMZLICPW();
            b.ShowForm(this);
        }

        private void tabelaDeCâmbiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmCambio();
            b.ShowForm(this);
        }

        private void balancetesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new Balancete();
            b.ShowForm(this);
        }

        private void apuramentoDeIVAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void apuramentoDeResulatadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new ParamRes();
            b.ShowForm(this);
        }

        private void apuramentoIVAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new ParamIva();
            b.ShowForm(this);
        }

        private void tabelasDeMoedasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmMoedas();
            b.ShowForm(this);
        }

        private void tabelasDeIVAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmAuxiliar {Tabela = 5, Desctabela = "Tabela de IVA"};
            b.ShowForm(this);
        }

        private void diáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var w = new FrmDiario();
            w.ShowForm(this);
        }

        private void iVAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new Apiva();
            b.ShowForm(this);
        }

        private void resultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new Aresult();
            b.ShowForm(this);
        }

        private void dossiersPredefinidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var w = new FrmDpd();
            w.ShowForm(this);
        }

        private void planoGeralDeContasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var w = new Pc();
            w.ShowForm(this);
        }

        private void lançamentosContabilísticosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var w = new FrmLContab();
            w.ShowForm(this);
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var w = new FrmFnc();
            w.ShowForm(this);
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var w = new FrmCl();
            w.ShowForm(this);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var b = new FrmPw();
            b.ShowForm(this);
        }

        private void baseDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmDatabase();
            b.ShowForm(this);
        }

        private void lblAno_Click(object sender, EventArgs e)
        {

        }
        private void importaçãoDePGCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var w = new FrmImport();
            w.ShowForm(this);
        }

        private void códigosDeIntegraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var w = new FrmCpoc();
            w.ShowForm(this);
        }

        private void balançoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var w = new FrmBalanco {Tipo = 1, label1 = {Text = @"Balanço"}};
            w.ShowForm(this);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            var w = new FrmBalanco {Tipo = 2, label1 = {Text = @"Demostração de Resultados"}};
            w.ShowForm(this);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void tipoDeGruposDeContasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmCtauxiliar
            {
                Tabela = 1,
                Desctabela = "Tipos de grupos de contas"//Define se é grupo de clientes,fornecedores, Pessoal ou contas 
            };
            b.ShowForm(this);
        }

        private void tesourariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Integracao.CadastroContas(this,"Contas");
        }

        private void vendedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void foenecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pessoalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmPes();
            b.Controlacesso = false;
            b.ShowForm(this);
        }

        private void clientesToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var b = new FrmCl();
            b.Controlacesso = false;
            b.ShowForm(this);
        }

        private void fornecedoresToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var b = new FrmFnc();
            b.Controlacesso = false;
            b.ShowForm(this);
        }

        private void pessoalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var b = new FrmPes();
            b.Controlacesso = false;
            b.ShowForm(this);
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Integracao.CadastroContas(this,"pe");
        }
        private void recibosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Integracao.Integradoc(this,"Rcl");
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           Integracao.Integradoc(this,"fact");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
           Integracao.CadastroContas(this,"fnc");
        }

        private void clientesToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Integracao.CadastroContas(this,"cl");
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void fornecedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Integracao.Integradoc(this,"facc");
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Integracao.Integradoc(this,"pgf");
        }

        private void processamentoDeSaláriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void movimentosDeStockToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
