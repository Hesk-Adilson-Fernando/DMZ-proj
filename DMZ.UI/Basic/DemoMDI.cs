using DMZ.BL.Classes;
using DMZ.UI.Generic;
using DMZ.UI.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DMZ.Model.Model;
using DMZ.UI.Classes;
using DMZ.UI.Reports;
using DMZ.UI.UI.Contabil;
using DMZ.UI.UI.FT;
using DMZ.UI.UI.PJ;
using DMZ.UI.UI.RH;
using DMZ.UI.Extensions;
using DMZ.UI.UI.PRC;
using System.IO;
using DMZ.UI.UI.Academia;
using DMZ.UI.TM;
using DMZ.UI.UI.TM;
using DMZ.UI.UC;

namespace DMZ.UI.Basic
{
    public partial class DemoMdi : Form
    {
        private Point _btnMovePanellocation;
        private Point _panelMenuToplocation;
        private Size _panelMenuTopSize;
        private Point _panelTaskBarLocation;
        private Size _panelTaskBarSize;
        private Size _panelDashBoardSize;
        private Point _panelDashBoardLocation;
        public DemoMdi() => InitializeComponent();

        public bool Maximizado { get;  set; }
        public bool Ocultado { get; set; }
        public bool TopCollapsed { get;  set; }
        public DataTable DtUsrModulos { get; set; }
        
        private void btnClose_Click_1(object sender, EventArgs e) => Application.Exit();

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (!Maximizado)
            {
                Maximizar();
            }
            else
            {
                Minimizar();
            }
        }
        private void btnMinimize_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void MouseDownEvent()
        {
            Dllimport.ReleaseCapture();
            Dllimport.SendMessage(Handle, 0x112, 0xf012, 0);
        }
        private void DemoMDI_Load(object sender, EventArgs e)
        {
            PanelCadastro.Visible=false;
            panelMASTER.Visible = false;
            btnMaster.Visible = false;
            Maximizar();
            timer1.Start();
            lblTitulo.Text = Pbl.Info2;// + $@" MASTER - {GetTipoLic()}";
            lblSistemaInfo.Text= Pbl.Info.ToUpper();
            btnAnoGest.button3.Text = Pbl.SqlDate.Year.ToString();
            lblData.label1.Text= Pbl.SqlDate.ToShortDateString();
            btnFacturaCl.ButtonToolTip = "Facturação de Clientes ";
            btnRecibo.ButtonToolTip = "Recibos de Clientes ";
            btnCompra.ButtonToolTip = "Facturação de fornecedores ";
            btnPagamento.ButtonToolTip ="Recibos de fornecedores";
            _listaMenuLateral = new List<string>
            {
                "btnCadastro",
                "btnConfig",
                "btnFacturacao",
                "btnGestao",
                "btnAnalises",
                "btnSupervisor",
                "btnProcurmentt"
            };
            btnLimpar.Visible = Pbl.Usr.MostraLimpar;
            lblEmpresa.label1.Text = Pbl.Empresa.Nome;
            Text = Pbl.Info2;
            btnSupervisor.Visible = Pbl.Usr.Usradmin;
            btnCadastro.Visible = !Pbl.Usr.NaoMostraCadastro;
            btnConfig.Visible = !Pbl.Usr.NaoMostraConfig;
            btnFacturacao.Visible = !Pbl.Usr.NaoMostrafacturacao;
            btnGestao.Visible = !Pbl.Usr.NaoMostraProcessos;
            btnAnalises.Visible = !Pbl.Usr.NaoMostraAnalises;
            panelMenuTop.Controls.Clear();
            Pbl.Academia = false;
            var mod = SQL.GetGen2DT($"select codigo from UsrModulo where Usrstamp='{Pbl.Usr.Usrstamp.Trim()}'");
            if (mod.HasRows())
            {
                foreach (var row in mod.AsEnumerable())
                {
                    if (row != null)
                    {
                        switch (row["codigo"].ToString())
                        {
                            case "GES":
                                panelMASTER.Visible = true;
                                btnFacturaCl.Visible = !Pbl.Usr.NaoMostravendas;
                                btnRecibo.Visible = !Pbl.Usr.NaoMostravendas;
                                btnPagamento.Visible = !Pbl.Usr.NaoMostracompras;
                                btnCompra.Visible = !Pbl.Usr.NaoMostracompras;
                                btnMaster.Visible = true;
                                //panelMenuTop.Controls.Clear();
                                //if (btnCadastro.Visible)
                                //{
                                //    panelMenuTop.Controls.Add(PanelCadastro);
                                //}
                                SetCadastro();
                                panelMASTER.Size = new Size(165, panelMASTER.GetHeight());
                                SetBackColor(btnCadastro);
                                var dt = SQL.GetDT("Usracessos", $"usrstamp='{Pbl.Usr.Usrstamp.Trim()}'");
                                if (dt.HasRows())
                                {
                                    Pbl.Usracessos = dt.DtToList<Usracessos>();
                                }
                                break;
                            case "PJ":
                                btnProjecto.Visible = true;
                                break;
                            case "FT":
                                btnFrota.Visible = true;
                                break;
                            case "RHS":
                                btnGesPessoal.Visible = true;
                                if (mod.Rows.Count == 1)
                                {
                                    CallPanelControl(btnGesPessoal, panelPessoal);
                                }
                                break;
                            case "IMB":
                                btnImobilizado.Visible = true;
                                break;
                            case "CT":
                                btnCONTABILIDADE.Visible = true;
                                btnCtEmpresa.Visible = Pbl.Usr.Usradmin;
                                btnCtUsr.Visible = Pbl.Usr.Usradmin;
                                btnAnoCT.button3.Text = Pbl.AnoContabil().ToString();
                                if (mod.Rows.Count==1)
                                {
                                    CallPanelControl(btnCONTABILIDADE, panelContabilidade);
                                }
                                break;
                            case "PRC":
                                btnProcurmentt.Visible = true;
                                break;
                                break;
                            case "AC":
                                Pbl.Academia = true;
                                btnAcademia.Visible = true;
                                break;
                        }
                    }
                }
            }
            LblCCusto.label1.Text="Centro de Custo: ".ToUpper()+Pbl.Usr.Ccusto.ToUpper();
            LblUser.label1.Text="Utilizador: ".ToUpper()+Pbl.Usr.Nome.ToUpper();

            if (Pbl.Usr.Usradmin)
            {
                parametrosGeraisToolStripMenuItem.Visible = true;
            }
            else
            {
                parametrosGeraisToolStripMenuItem.Visible = false;
            }
        }

        List<string> _listaMenuLateral;
        private void Maximizar()
        {
            Size = Screen.PrimaryScreen.WorkingArea.Size;
            Location = Screen.PrimaryScreen.WorkingArea.Location;
            Maximizado = true;
        }
        private void Minimizar()
        {
            var height = Screen.PrimaryScreen.WorkingArea.Size.Height;
            var width = Screen.PrimaryScreen.WorkingArea.Size.Width;
            Size = new Size(width - 100, height - 100);
            var x = Screen.PrimaryScreen.WorkingArea.Location.X;
            var y = Screen.PrimaryScreen.WorkingArea.Location.Y;
            Location = new Point(x + 170, y + 100);
            Maximizado = false;
            var lista = Application.OpenForms;
            foreach (Form frm in lista)
            {
                if (frm == null) continue;
                if (frm.IsMdiContainer) continue;
                if (frm.Name.Equals("Login")) continue;
                if (((FrmClasse)frm).Maximizado) 
                {
                    ((FrmClasse)frm).Minimizar();
                }
            }
        }
        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownEvent();
        }

        private void btnMovePanel_Click(object sender, EventArgs e)
        {

            if (PanelSideMenu.Width==173)
            {
                _panelMenuTopSize = panelMenuTop.Size;
                _panelMenuToplocation = panelMenuTop.Location;
                PanelSideMenu.Width = 40;
                lblHora.Visible = false;
                _btnMovePanellocation = btnMovePanel.Location;
                _panelTaskBarLocation = panelTaskBar.Location;
                _panelTaskBarSize = panelTaskBar.Size;
                lblSistemaInfo.Visible = false;
                btnMovePanel.Location = new Point(5, _btnMovePanellocation.Y);
                panelMenuTop.Location = new Point(45, _panelMenuToplocation.Y);
                panelTaskBar.Location = new Point(41, _panelTaskBarLocation.Y);
                panelTaskBar.Size = new Size(_panelMenuTopSize.Width + 130, _panelMenuTopSize.Height);
                panelMenuTop.Size = new Size(_panelMenuTopSize.Width+130, _panelMenuTopSize.Height);
                btnMovePanel.Image = Properties.Resources.Circled_Right_2_25px;               
                picHidden.Visible = true;
                Ocultado = true;
                if (panelDashBoard.Visible)
                {
                    _panelDashBoardSize = panelDashBoard.Size;
                    _panelDashBoardLocation = panelDashBoard.Location;
                    panelDashBoard.Size = new Size(panelDashBoard.Width+129, panelDashBoard.Height);
                    panelDashBoard.Location = new Point(45, panelDashBoard.Location.Y);
                }
                var lista = Application.OpenForms;
                foreach (Form frm in lista)
                {
                    if (!(frm is FrmClasse)) continue;
                    if (((FrmClasse)frm).Maximizado)
                    {
                        ((FrmClasse)frm).MoveUp();
                    }
                }
            }
            else
            {

                lblHora.Visible = true;
                if (panelDashBoard.Visible)
                {
                    VerificaPanelDashboard();
                }
                //
                panelMenuTop.Location = _panelMenuToplocation;
                btnMovePanel.Location= _btnMovePanellocation;
                panelTaskBar.Size = _panelTaskBarSize;
                panelTaskBar.Location= _panelTaskBarLocation;
                btnMovePanel.Image = Properties.Resources.Circled_Left_2_25px;
                PanelSideMenu.Width = 173;
                picHidden.Visible = false;
                lblSistemaInfo.Visible = true;
                Ocultado = false;
                var lista = Application.OpenForms;
                if (lista.Count == 0) return;
                foreach (Form frm in lista)
                {
                    if (!(frm is FrmClasse)) continue;
                    if (((FrmClasse)frm).Maximizado)
                    {
                        ((FrmClasse)frm).MoveDow();
                    }
                }
            }
        }

        public void VerificaPanelDashboard()
        {
            panelDashBoard.Size= _panelDashBoardSize;
            panelDashBoard.Location= _panelDashBoardLocation;
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            SetCadastro();
        }

        private void SetCadastro()
        {
            panelMenuTop.Controls.Clear();
            //panelMenuTop.Controls.Add(PanelCadastro);
            panelMenuTop.Controls.Add(PanelCadastro);
            PanelCadastro.Location = new Point(0, 1);
            PanelCadastro.Visible = true;
            SetBackColor(btnCadastro);
        }

        private void SetBackColor(Button button)
        {
            
            foreach (var nome in _listaMenuLateral)
            {
                if (button.Name.Trim().Equals(nome.Trim()))
                {
                    button.BackColor = Color.DarkGoldenrod;
                }
                else
                {
                    ((Button)Controls.Find(nome.Trim(),true).FirstOrDefault()).BackColor= Color.FromArgb(34, 39, 49);
                }  
            }

        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            panelMenuTop.Controls.Clear();
            panelMenuTop.Controls.Add(panelConfig);
            panelConfig.Location = new Point(0, 1);
            panelConfig.Visible = true;
            SetBackColor(btnConfig);
        }
        private void btnCollapseMenuTop_Click(object sender, EventArgs e)
        {

            if (!TopCollapsed)
            {
                panelMenuTop.Height = 0;
                btnCollapseMenuTop.Location = new Point(1250, 1);
                btnCollapseMenuTop.Image = Properties.Resources.Expand_Arrow_25px;
                TopCollapsed = true;

            }
            else
            {
                panelMenuTop.Height = 75;
                btnCollapseMenuTop.Location = new Point(1340, 82);
                btnCollapseMenuTop.Image = Properties.Resources.Collapse_Arrow_20px;
                TopCollapsed = false;
            }
        }
        private void PanelCadastro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFacturacao_Click(object sender, EventArgs e)
        {

            panelMenuTop.Controls.Clear();
            panelMenuTop.Controls.Add(PanelFacturacao);
            PanelFacturacao.Location = new Point(0, 1);
            PanelFacturacao.Visible = true;
            SetBackColor(btnFacturacao);
        }


        private void btnFacturaCl_DoClick()
        {
           CallFactura();
        }

        private void CallFactura()
        {
            var retorno = IsValido("tdoc","FrmFt");
            if (retorno.Valido)
            {
                var defa = SQL.GetField("sigla", "tdoc", "defa=1").ToString();
                var defaCond = retorno.lista.AsEnumerable().Where(x => x.Ecran.Equals(defa.Trim())).Any(x => x.Ver.Equals(true)) ? $"sigla ='{defa}'" : $"sigla ='{retorno.lista.AsEnumerable().First(x => x.Ver.Equals(true)).Ecran.Trim()}'";
                var b = new FrmFt { Tdoccondicao = defaCond, ListaUsracessos = retorno.lista, Usracessos = retorno.lista.FirstOrDefault() };
                b.ShowForm(this);
            }
        }

        private (List<Usracessos> lista,bool Valido) IsValido(string origem,string Ecran)
        {
            (List<Usracessos> lista, bool Valido) ret  = (null, false);
            var acesso = Pbl.Usracessos.Where(x => x.Ecran.Equals(Ecran.Trim()) && x.Usrstamp.Trim().Equals(Pbl.Usr.Usrstamp.Trim()) && x.Ver.Equals(true)).FirstOrDefault();
            if (acesso != null)
            {
                var lista = Pbl.Usracessos.Where(x => x.Origem.Trim().Equals(origem.Trim()) && x.Usrstamp.Trim().Equals(Pbl.Usr.Usrstamp.Trim()) && x.Ver.Equals(true)).ToList();
                if (lista.Count > 0)
                {
                    ret.lista = lista;
                    ret.Valido = true;
                }
                else
                {
                    ret.lista = null;
                    ret.Valido = false;
                    MsBox.Show(Messagem.NaoExisteDocumentos());
                }
            }
            else
            {
                ret.lista = null;
                ret.Valido = false;
                MsBox.Show(Messagem.NaoTemAcesso());
            }
            return ret;
        }
        private void btnRecibo_DoClick()
        {
            var retorno = IsValido("TRcl", "FrmRcl");
            if (retorno.Valido)
            {
                var defa = SQL.GetField("sigla", "TRcl", "defa=1").ToString();
                var defaCond = retorno.lista.AsEnumerable().Where(x => x.Ecran.Equals(defa.Trim())).Any(x => x.Ver.Equals(true)) ? $"sigla ='{defa}'" : $"sigla ='{retorno.lista.AsEnumerable().First(x => x.Ver.Equals(true)).Ecran.Trim()}'";
                var b = new FrmRcl { Trclcondicao = defaCond, ListaUsracessos = retorno.lista.ToList() };
                b.ShowForm(this);
            }

        }

        private void btnCadastro_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnCompra_DoClick()
        {
              CallFormComprar();
        }

        private void btnPagamento_DoClick()
        {
            var b = new FrmPgf2();
            b.brrtextCliente.Visible = b.gridFormasCliente.Visible = false;
            b.Origemsssss = 0;
            b.ShowForm(this);
        }

        private void btnGestao_Click(object sender, EventArgs e)
        {

            panelMenuTop.Controls.Clear();
            panelMenuTop.Controls.Add(PanelGestao);
            PanelGestao.Location = new Point(0, 1);
            PanelGestao.Visible = true;
            SetBackColor(btnGestao);
        }

        private void dropDownButton2_DoClick()
        {
            Configuracao.ShowMenuStrip(dropDownButton2.btnOpcoes);
        }

        private void btnProvincia_Click(object sender, EventArgs e)
        {
            var status = new FrmProv();
            status.ShowForm(this);
        }

        private void btnParametros_DoClick()
        {
            parametros.ShowMenuStrip(btnParametros.btnOpcoes);
        }

        public void btnAnalises_Click(object sender, EventArgs e)
        {
            panelMenuTop.Controls.Clear();
            panelMenuTop.Controls.Add(panelRelatorios);
            panelRelatorios.Location = new Point(0, 1);
            panelRelatorios.Visible = true;
            SetBackColor(btnAnalises);
        }

        private void btnSupervisor_Click(object sender, EventArgs e)
        {
            panelMenuTop.Controls.Clear();
            panelMenuTop.Controls.Add(panelSupervisao);
            panelSupervisao.Location = new Point(0, 1);
            panelSupervisao.Visible = true;
            SetBackColor(btnSupervisor);
        }

        private void paísesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var b = new FrmPaises();
            //b.ShowForm(this);
            Util.ShowForm(this, "FrmPaises");
        }


        private void btnFamilia_DoClick()
        {
            //var b = new FrmFamilia();
            //b.ShowForm(this);
            Util.ShowForm(this, "FrmFamilia");
        }

        private void btnArmazem_DoClick()
        {
            //var b = new FrmArmazem();
            //b.ShowForm(this);
            Util.ShowForm(this, "FrmArmazem");
        }

        private void câmbioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var b = new FrmCambio();
            //b.ShowForm(this);
            Util.ShowForm(this, "FrmCambio");
        }

        private void SatatusToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void btnProdutos_DoClick()
        {
            var b = new FrmProduto
            {
                Servico = false,
                Origem = "Pr"
            };
            b.ShowForm(this);
        }

        private void btnClientes_DoClick()
        {
            CallFormCliente();
        }

        private void CallFormCliente()
        {
            //var b = new FrmCl();
            //b.ShowForm(this);
            Util.ShowForm(this, "FrmCl");
        }

        private void btnServico_DoClick()
        {
            var b = new FrmProduto {Servico = true, Origem = "Sr"};
            b.ShowForm(this);
        }

        private void btnFornec_DoClick()
        {
            CallFormFornecedor();
        }

        private void CallFormFornecedor()
        {
            Util.ShowForm(this,"FrmFnc");
        }

        private void tipoDeContasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmAuxilar b =(FrmAuxilar)Util.ShowForm(this, "FrmAuxilar");
            //b.Tabela = 1;
            //b.Desctabela = "Tipo de Contas ";

            var b = new FrmAuxiliar { Tabela = 1, Desctabela = "Tipo de Contas " };
            b.ShowForm(this);
        }

        private void panelDashBoard_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.label1.Text = Helper.Horas();
        }

        private void buttonGroup42_DoClick1()
        {
            var b = new FrmAuxiliar { Tabela = 3, Desctabela = "Fabricantes" };
            b.ShowForm(this);
        }

        private void buttonGroup42_DoClick2()
        {
            var b = new FrmAuxiliar {Tabela = 4, Desctabela = "Marcas", Height2 = true, Caption = "Modelos"};
            b.ShowForm(this);
        }

        private void buttonGroup42_DoClick3()
        {
            var b = new FrmAuxiliar { Tabela = 5, Desctabela = "Tabela de IVA" };
            b.ShowForm(this);
        }

        private void buttonGroup42_DoClick4()
        {
            var b = new FrmAuxiliar { Tabela =6, Desctabela = "Unidade de Medida" };
            b.ShowForm(this);
        }

        private void facturaçãoClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var b = new FrmTdoc();
            //b.ShowForm(this);
            Util.ShowForm(this, "FrmTdoc");
        }

        private void btnMenuCodcc_Click(object sender, EventArgs e)
        {
            //var b = new FrmCodcc();
            //b.ShowForm(this);
            Util.ShowForm(this, "FrmCodcc");
        }

        private void btnCodigos_DoClick()
        {
            Codigos.ShowMenuStrip(btnCodigos.btnOpcoes);
        }

        private void btnMenuCodstk_Click(object sender, EventArgs e)
        {
            //var b = new FrmCodstk();
            //b.ShowForm(this);
            Util.ShowForm(this, "FrmCodstk");
        }

        private void buttonMenu7_DoClick()
        {
            Util.ShowForm(this, "FrmCCusto");
        }

        private void buttonMenu8_DoClick()
        {

        }

        private void btnMenuMoedas_Load(object sender, EventArgs e)
        {

        }

        private void btnMenuMoedas_DoClick()
        {
            Util.ShowForm(this, "FrmMoedas");
        }

        private void btnMenuEntradasTesoura_Click(object sender, EventArgs e)
        {
            var b = new FrmDi {btnTdi = {Visible = false}, TdiDefaultCondicao = "Sigla='EFM'", Modulo = "GES"};
            b.ShowForm(this);
        }

        private void btnMenuSaidasTesoura_Click(object sender, EventArgs e)
        {
            var b = new FrmDi {btnTdi = {Visible = false}, TdiDefaultCondicao = "Sigla='RF'", Modulo = "GES"};
            b.ShowForm(this);
        }

        private void btnTrf_Click(object sender, EventArgs e)
        {
            var b = new FrmDi {btnTdi = {Visible = false}, TdiDefaultCondicao = "Sigla='TRFC'", Modulo = "GES"};
            b.ShowForm(this);
        }

        private void btnVend_DoClick()
        {
            Util.ShowForm(this, "FrmVend");
        }

        private void facturaçãoDeFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Util.ShowForm(this, "FrmTdocf");
        }

        private void recibosDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Util.ShowForm(this, "FrmTRcl");
        }

        private void modulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Util.ShowForm(this, "FrmModulos");
        }

        private void recibosDeFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmTpgf();
            b.Rh = false;
            b.ShowForm(this);
        }

        private void buttonMenu2_DoClick()
        {
            CallEmpresaForm();
        }

        private void CallEmpresaForm()
        {
            var b = new FrmEmpresa();
            b.ShowForm(this);
        }

        private void DocInternos_DoClick()
        {
            var lista =Pbl.Usracessos.Where(x=>x.Origem.Equals("tdi"));
            if (lista.AsEnumerable().Any(x => x.Ver.Equals(true)))
            {
                var defa = SQL.GetField("sigla", "tdi", "defa=1").ToString();
                var defaCond = lista.AsEnumerable().Where(x=>x.Ecran.Equals(defa.Trim())).Any(x => x.Ver.Equals(true)) ? $"sigla ='{defa}'" : $"sigla ='{lista.AsEnumerable().First(x => x.Ver.Equals(true)).Ecran.Trim()}'";
                var b = new FrmDi {BrowdocCondicao = defaCond} ;
                b.Modulo = "GES";
                b.ShowForm(this);
            }
            else
            {
                MsBox.Show("Desculpa não tem acesso. contacte administrator!");
            }
        }

        private void documentosInternosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Util.ShowForm(this, "FrmTdi");
        }

        private void btnEntidade_DoClick()
        {
            Util.ShowForm(this, "FrmEnt");
        }

        private void parametrosGeraisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CallParam();
        }

        private void CallParam()
        {
            Util.ShowForm(this, "FrmParam");
        }

        private void btnUser_DoClick()
        {
            CallUserForm();
        }

        private void CallUserForm()
        {
            Util.ShowForm(this, "FrmUsr");
        }

        private void btnPassword_DoClick()
        {
            Util.ShowForm(this, "FrmPw");
        }

        private void btnRelatorio_DoClick()
        {
            var b = new FrmRelatorios {Modulo = "GES"};
            b.ShowForm(this);
        }

        private void tipoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmAuxiliar { Tabela = 7, Desctabela = "Tipo de Cliente" };
            b.ShowForm(this);
        }

        private void tipoFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmAuxiliar { Tabela = 8, Desctabela = "Tipo de Fornecedor" };
            b.ShowForm(this);
        }

        private void tipoVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmAuxiliar { Tabela = 9, Desctabela = "Tipo de Vendedor" };
            b.ShowForm(this);
        }

        private void btnPosMenu_DoClick()
        {
            pos.ShowMenuStrip(btnPosMenu.btnOpcoes);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Util.ShowForm(this, "FrmMesas");
        }

        private void sectoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Util.ShowForm(this, "FrmSector");
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Util.ShowForm(this, "FrmPv");
        }

        private void bancosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Util.ShowForm(this, "FrmBanco");
        }

        private void btnVendas_DoClick()
        {
            Util.ShowForm(this, "FrmConsultacx");
        }

        private void tabelaDeIVAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmAuxiliar {Tabela = 5, Desctabela = "Tabela de IVA"};
            b.ShowForm(this);
        }

        private void btnLimpar_DoClick()
        {
            Util.ShowForm(this, "FrmDelTable");
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard1_Click(object sender, EventArgs e)
        {
            //tabControl1.SelectTab(tabPageGeral);
            //DashboardCadastro();
            //tabControl1.Appearance = TabAppearance.FlatButtons;
            //tabControl1.ItemSize = new Size(0, 1);
            //tabControl1.SizeMode = TabSizeMode.Fixed;
            //tabPageGeral.BorderStyle = BorderStyle.None;

            ////panelDashBoard.Controls.Add(panelDash);
            ////panelDash.Location = new Point(0, 1);
            //panelDashBoard.Visible = true;
            //panelDash.Visible = true;
            ////panelDash.Dock = DockStyle.Fill;
            //SetBackColor(Dashboard);
        }

        private void btnFacturacao_BackColorChanged(object sender, EventArgs e)
        {
            btnFacturacao.Image = btnFacturacao.BackColor== Color.DarkGoldenrod ? Properties.Resources.FacturacaoT : Properties.Resources.Facturacao;
        }

        private void btnConfig_BackColorChanged(object sender, EventArgs e)
        {
            btnConfig.Image = btnConfig.BackColor == Color.DarkGoldenrod ? Properties.Resources.ConfiguracaoT : Properties.Resources.Configuracao;
        }

        private void btnCadastro_BackColorChanged(object sender, EventArgs e)
        {
            btnCadastro.Image = btnCadastro.BackColor == Color.DarkGoldenrod ? Properties.Resources.CadastroT : Properties.Resources.Cadastro;
        }

        private void btnGestao_BackColorChanged(object sender, EventArgs e)
        {
            btnGestao.Image = btnGestao.BackColor == Color.DarkGoldenrod ? Properties.Resources.GestaoT : Properties.Resources.Gestao;
        }

        private void btnAnalises_BackColorChanged(object sender, EventArgs e)
        {
            btnAnalises.Image = btnAnalises.BackColor == Color.DarkGoldenrod ? Properties.Resources.AnalisesT : Properties.Resources.Analises;
        }

        private void btnSupervisor_BackColorChanged(object sender, EventArgs e)
        {
            btnSupervisor.Image = btnSupervisor.BackColor == Color.DarkGoldenrod ? Properties.Resources.SuporteT : Properties.Resources.Suporte;
        }


        private void btnGraficos_DoClick()
        {
            Graficos.ShowMenuStrip(btnGraficos.btnOpcoes);
        }

        private void códigosDeMovimentoDeTesourariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Util.ShowForm(this, "FrmCodtz");
        }

        private void btnModulos_Click(object sender, EventArgs e)
        {
            //dmzContextMenuStripModulos.ShowMenuStrip(btnModulos);
        }

        private void btnSubMenuFact_DoClick()
        {
            Facturacao.ShowMenuStrip(btnSubMenuFact.btnOpcoes);
        }

        private void passwordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Util.ShowForm(this, "FrmPw");
        }

        private void DocInternos_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            Util.ShowForm(this, "DMZFramework");
        }

        private void btnDatabase_DoClick()
        {
            Util.ShowForm(this, "FrmDatabase");
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Util.ShowForm(this, "FrmDatabase");
        }

        private void reposiçãoDaCópiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Util.ShowForm(this, "FrmDatabase");
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            Util.ShowForm(this, "FrmAbout");
        }

        private void pagamentoDeFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Util.ShowForm(this, "FrmAssPgf");
        }

        private void motivoDeInsençãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmAuxiliar {Tabela = 12, Desctabela = "Movitos de Insenção"};
            b.ShowForm(this);
        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Util.ShowForm(this, "FrmStatus");
        }

        private void gruposDeUtilizadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmAuxiliar {Tabela = 13, Desctabela = "Grupo de utilizadores "};
            b.ShowForm(this);
        }

        private void Viaturas_Click(object sender, EventArgs e)
        {
            var b = new FrmVt {Origem = "Vt"};
            b.ShowForm(this);
        }

        private void Motorista_Click(object sender, EventArgs e)
        {
            Util.ShowForm(this, "FrmPes");
        }

        private void Documentos_Click(object sender, EventArgs e)
        {
            var b = new FrmPjdi {Origem = "FRT"};
            b.ShowForm(this);
        }

        private void trailersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmVt {Origem = "Tr"};
            b.ShowForm(this);
        }


        private void btnPessoal_DoClick()
        {
            Util.ShowForm(this, "FrmPes");
        }

        private void viaturasManutençãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Util.ShowForm(this, "FrmVtmanunt");
        }

        private void contasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmContas {CCondicao = "especial=0"};
            b.ShowForm(this);
        }

        private void dropDownTesoura_DoClick()
        {
            Tesouraria.ShowMenuStrip(dropDownTesoura.btnOpcoes);
        }

        private void depósitosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmDi {btnTdi = {Visible = false}, TdiDefaultCondicao = "Sigla='DB'", Modulo = "GES"};
            b.ShowForm(this);
        }

        private void extratoDeContasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Util.ShowForm(this, "FrmMvtcc");
        }

        private void btnEncFnc_Click(object sender, EventArgs e)
        {
            var b = new FrmDi {TdiDefaultCondicao = "Encomenda=1", btnTdi = {Visible = false}, Modulo = "GES"};
            b.ShowForm(this);
        }

        private void btnGuiaCl_Click(object sender, EventArgs e)
        {
            var b = new FrmDi {TdiDefaultCondicao = "Vendido=1", btnTdi = {Visible = false}, Modulo = "GES"};
            b.ShowForm(this);
        }

        private void btnGuiaFnc_Click(object sender, EventArgs e)
        {
            var b = new FrmDi {TdiDefaultCondicao = "Comprado=1", btnTdi = {Visible = false}, Modulo = "GES"};
            b.ShowForm(this);
        }

        private void btnEncCl_Click(object sender, EventArgs e)
        {
            var b = new FrmDi {TdiDefaultCondicao = "Reserva=1", btnTdi = {Visible = false}, Modulo = "GES"};
            b.ShowForm(this);
        }

        private void btnEstornoProd_Click(object sender, EventArgs e)
        {
            var b = new FrmDi {TdiDefaultCondicao = "Estorno=1", btnTdi = {Visible = false}, Modulo = "GES"};
            b.ShowForm(this);
        }

        private void btnProcessos_DoClick()
        {
            Processos.ShowMenuStrip(btnProcessos.btnOpcoes);
        }

        private void listagemDeProdutosComStockPorArmazemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var _armazeml = Helper.GetArmazenStock("");
            //var f = new FrmReport
            //{
            //    Origem = "RLT",
            //    Dt = _armazeml,
            //    TabelaName = "DMZ",
            //    ReportName = "Armazem",
            //    Filtro ="TODOS ARMAZENS",
            //    CTituloRelatorio = "LISTA DE PRODUTOS EXISTENTES"
            //};
            //f.ShowForm(this);
            DS ds = new DS();
            var ret = Imprimir.FillData(null, _armazeml, null, ds.DMZ, null);
            Imprimir.CallForm(ret.dtPrint, ret.fp, "", false, "", "", "Armazem", "RLT", this, "", true, ds, "LISTA DE PRODUTOS EXISTENTES", "TODOS ARMAZENS");
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
           // Util.ShowForm(this, "FrmProdVend");
            Helper.ShowForm<FrmProdVend>(this);
        }

        private void btnGesProduto_DoClick()
        {
            Produtoss.ShowMenuStrip(btnGesProduto.btnOpcoes);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Util.ShowForm(this, "FrmCurvaAbc");
        }

        private void reajusteDePreçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FrmAlterapreacos {Origem = false, label1 = {Text = "Alteração de preços de vendas"}};
            f.ShowForm(this);
        }

        private void modulesSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Util.ShowForm(this, "DMZLICPW");
        }

        private void facturarEncomendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmFt {OrigReserva = true};
            b.ShowForm(this);
            b.label1.Text = b.label1.Text;
        }

        private void facturaçãoDeEncomendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmCp {OrigReserva = true, Tdocfcondicao = "sigla='FTF'", btnTdi = {Visible = false}};
            b.ShowForm(this);
            b.label1.Text = b.label1.Text ;
        }

        private void btnHistoricocx_Click(object sender, EventArgs e)
        {
            Util.ShowForm(this, "FrmHistoricocx");
        }

        private void classificadorDeDescontosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmAuxiliar { Tabela = 19, Desctabela = "Calassificador de descontos" };
            b.ShowForm(this);
        }

        private void tipoDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmAuxiliar { Tabela =78, Desctabela = "Tipos de produtos" };
            b.ShowForm(this);
        }

        private void btnGesPessoal_Click(object sender, EventArgs e)
        {
            CallPanelControl(btnGesPessoal, panelPessoal);
        }

        private void btnPe_DoClick()
        {
            Util.ShowForm(this, "FrmPes");
        }

        private void toolStripMenuItem94_Click(object sender, EventArgs e)
        {
            var b = new FrmPeAuxilar
            {
                Tabela = 20,
                Desctabela = "Categorias Profissionais"
            };
            b.ShowForm(this);
        }

        private void btnNivelac_Click(object sender, EventArgs e)
        {
            CallFormNivelAcad();
        }

        private void CallFormNivelAcad()
        {
            var b = new FrmPeAuxilar
            {
                Tabela = 11,
                Desctabela = "Nivel Académico"
            };
            b.ShowForm(this);
        }

        private void btnRegime_Click(object sender, EventArgs e)
        {

        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            CallFormEstadoCivil();
        }

        private void CallFormEstadoCivil()
        {
            var b = new FrmPeAuxilar
            {
                Tabela = 9,
                Desctabela = "Estado Civil"
            };
            b.ShowForm(this);
        }

        private void btnSexo_Click(object sender, EventArgs e)
        {
            CallFormSexo();
        }

        private void btnGrauparantesco_Click(object sender, EventArgs e)
        {
            CallFormaGrauParant();
        }

        private void CallFormaGrauParant()
        {
            var b = new FrmPeAuxilar
            {
                Tabela = 7,
                Desctabela = "Grau Parentesco"
            };
            b.ShowForm(this);
        }

        private void btnDocumentos_Click(object sender, EventArgs e)
        {
            var b = new FrmPeAuxilar
            {
                Tabela = 1,
                Desctabela = "Tipo de Documento"
            };
            b.ShowForm(this);
        }

        private void btnLinguas_Click(object sender, EventArgs e)
        {
            CallFormLingua();
        }

        private void CallFormLingua()
        {
            var b = new FrmPeAuxilar
            {
                Tabela = 2,
                Desctabela = "Lingua"
            };
            b.ShowForm(this);
        }

        private void btnClassificacao_Click(object sender, EventArgs e)
        {
            CallFormClassific();
        }

        private void CallFormClassific()
        {
            var b = new FrmPeAuxilar
            {
                Tabela = 12,
                Desctabela = "Classificação"
            };
            b.ShowForm(this);
        }

        private void btnSindicatos_Click(object sender, EventArgs e)
        {
            var b = new FrmPeAuxilar
            {
                Tabela = 13,
                Desctabela = "Sindicatos"
            };
            b.ShowForm(this);
        }

        private void btnProfissao_Click(object sender, EventArgs e)
        {
            var b = new FrmPeAuxilar
            {
                Tabela = 14,
                Desctabela = "Profissões"
            };
            b.ShowForm(this);
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            var b = new FrmPeAuxilar
            {
                Tabela = 15,
                Desctabela = "Cargos"
            };
            b.ShowForm(this);
        }

        private void btnInstituicoes_Click(object sender, EventArgs e)
        {
            var b = new FrmPeAuxilar
            {
                Tabela = 16,
                Desctabela = "Instituição de formação"
            };
            b.ShowForm(this);
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            var b = new FrmPeAuxilar
            {
                Tabela = 17,
                Desctabela = "Cursos"
            };
            b.ShowForm(this);
        }

        private void btnRHConfig_DoClick()
        {
            RHConfiguracao.ShowMenuStrip(btnRHConfig.btnOpcoes);
        }

        private void mesesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Util.ShowForm(this, "FrmMeses");
        }

        private void listaDeProdutosAbaixoDeStockMínimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Util.ShowForm(this, "FrmStockminalert");
        }
        private void btnConfigAnalises_DoClick()
        {
            AnaliseConfig.ShowMenuStrip(btnConfigAnalises.btnOpcoes);
        }
        private void emissõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var lista =Pbl.Usracessos.Where(x=>x.Origem.Equals("TRcl")).ToList();
            if (lista.AsEnumerable().Any(x => x.Ver.Equals(true)))
            {
                var b = new FrmRcl {Trclcondicao = "especial=1", ListaUsracessos = lista.ToList()};
                b.ShowForm(this);
            }
            else
            {
                MsBox.Show("Desculpa não tem acesso. contacte administrator!");
            }
        }

        private void emissõesEspeciaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmContas {CCondicao = "especial=1"};
            b.ShowForm(this);
        }

        private void mapaDeVendasPorMesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FrmProdVend {Origem = "VENDA",Titulo = "Listagem de produtos vendidos"};
            f.cbDetalhado.Update(true);
            f.ShowForm(this);
        }

        private void últimasComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FrmProdVend {Origem = "COMPRA", Titulo = "Listagem de produtos comprados"};
            f.cbDetalhado.Update(true);
            f.ShowForm(this);
        }
        private void saldosIniciaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmDi {btnTdi = {Visible = false}, TdiDefaultCondicao = "Sigla='SIC'"};
            b.ShowForm(this);
        }

        private void tabelaDeIRPSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Util.ShowForm(this, "FrmTirps");
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Util.ShowForm(this, "FrmRelatorios");
        }
        private void lançarPreçosDeVendasNasLojasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmAlterapreacos {label1 = {Text = @"Definição de preços de vendas!"}, Origem = true};
            b.ShowForm(this);
        }

        private void tipoDeMesesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void projectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Util.ShowForm(this, "FrmTdocpj");
        }
        private void btnProj_DoClick()
        {
            Util.ShowForm(this, "FrmPj");
        }

        private void btnProjecto_Click(object sender, EventArgs e)
        {
            CallPanelControl(btnProjecto, panelProjecto);
        }

        private void btnProjConfig_DoClick()
        {
            Projecto.ShowMenuStrip(btnProjConfig.btnOpcoes);
        }

        private void btnProjDocs_DoClick()
        {
            var b = new FrmPjdi {Origem = "", Modulo = "PJ"};
            b.ShowForm(this);
        }

        private void btnPjPessoal_DoClick()
        {
            Util.ShowForm(this, "FrmPes");
        }

        private void btnPjProdutos_DoClick()
        {
            var b = new FrmProduto
            {
                Servico = false,
                Origem = "Pr"
            };
            b.ShowForm(this);
        }

        private void classificadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmAuxiliar {Tabela = 66, Desctabela = "Classificador"};
            b.ShowForm(this);
        }

        private void btnPjEmpresa_Click(object sender, EventArgs e)
        {
            var b = new FrmAuxiliar {Tabela = 67, Desctabela = @"Empresas de Fiscalização"};
            b.ShowForm(this);
        }

        private void btnFrota_Click(object sender, EventArgs e)
        {
            panelMenuTop.Controls.Clear();
            panelMenuTop.Controls.Add(panelFrota);
            panelFrota.Location = new Point(0, 1);
            panelFrota.Visible = true;
            SetBackColor(btnFrota);
        }

        private void btnFTvt_DoClick()
        {
            var b = new FrmVt {Origem = "Vt"};
            b.ShowForm(this);
            //((FrmVt)Util.ShowForm(this, "FrmVt")).Origem = "Vt";            
        }

        private void btnPjvt_DoClick()
        {
            var b = new FrmVt {Origem = "Vt"};
            b.ShowForm(this);
        }

        private void btnSubsidios_Click(object sender, EventArgs e)
        {
            Util.ShowForm(this, "FrmSub");
        }

        private void btnDescontos_Click_1(object sender, EventArgs e)
        {
            //var b = new FrmDesc();
            //b.ShowForm(this);
            Util.ShowForm(this, "FrmDesc");
        }

        private void tipoDeHorasExtrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var b = new FrmHoraExtra();
            //b.ShowForm(this);
            Util.ShowForm(this, "FrmHoraExtra");
        }

        private void faltasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var b = new FrmFalta();
            //b.ShowForm(this);
            Util.ShowForm(this, "FrmFalta");
        }

        private void btnRhRelat_DoClick()
        {
            var b = new FrmRelatorios {Modulo = "RHS"};
            b.ShowForm(this);
        }

        private void tiposDeAusênciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmPeAuxilar {Tabela = 18, Desctabela = "Tipos de ausências"};
            b.ShowForm(this);
        }

        private void btnRHControl_DoClick()
        {
            var b = new FrmRHDashboard();
            //b.ShowForm(this);
            Util.ShowForm(this, "FrmRHDashboard");
        }

        private void btnRHDesp_DoClick()
        {
            var b = new FrmDi {TdiDefaultCondicao = "sigla='DSP'", Controlacesso = false, Modulo = "RHS"};
            b.ShowForm(this);
        }

        private void btnMaster_Click(object sender, EventArgs e)
        {
            panelMASTER.Visible = !panelMASTER.Visible;
            var iCurrentPosition=flowLayoutPanel2.Controls.GetChildIndex(btnMaster);
            flowLayoutPanel2.Controls.SetChildIndex(panelMASTER,iCurrentPosition+1);
            panelMenuTop.Controls.Clear();
            panelMenuTop.Controls.Add(PanelCadastro);
            SetBackColor(btnCadastro);
        }

        private void btFTDocs_DoClick()
        {
            var b = new FrmPjdi {Origem = "", Modulo = "FT"};
            b.ShowForm(this);
        }

        private void btnPJRelatorios_DoClick()
        {
            var b = new FrmRelatorios {Modulo = "PJ"};
            b.ShowForm(this);
        }

        private void situaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmPeAuxilar
            {
                Tabela = 19,
                Desctabela = "SITUAÇÃO"
            };
            b.ShowForm(this);
        }

        private void codigosDeRendimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmPeAuxilar
            {
                Tabela = 21,
                Desctabela = "Codigos de Rendimentos"
            };
            b.ShowForm(this);
        }

        private void periodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmPeAuxilar
            {
                Tabela = 22,
                Desctabela = "Período"//Periodo Mensal
            };
            b.ShowForm(this);
        }

        private void tipoDeProcessamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmPeAuxilar
            {
                Tabela = 23,
                Desctabela = "Tipo de Processamento"//Dias Fixos(30), ou dias Variaveis ..
            };
            b.ShowForm(this);
        }

        private void tipoDeFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmPeAuxilar
            {
                Tabela = 24,
                Desctabela = "Tipo de Funcionário"//mecanico,motorista, ..
            };
            b.ShowForm(this);
        }

        private void btnProcessAutomatico_Click(object sender, EventArgs e)
        {

        }

        private void btnPrcAutomatico_DoClick()
        {
            Util.ShowForm(this, "FrmProcess");
            Pbl.DtTirps = SQL.GetGen2DT("select Tirpsl.* from Tirps join Tirpsl on Tirps.Tirpsstamp=Tirpsl.Tirps_Tirpsstamp where Padrao=1");
        }

        private void tipoDeFuncionárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var b = new FrmPeAuxilar
            {
                Tabela = 24,
                Desctabela = "Tipo de Funcionário"//mecanico,motorista, ..
            };
            b.ShowForm(this);
        }

        private void tiposNosEmailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmAuxiliar {Tabela = 68, Desctabela = @"Tipos nos emails"};
            b.ShowForm(this);
        }

        private void invetárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var b = new FrmIv();
            //b.ShowForm(this);
            Util.ShowForm(this, "FrmIv");
        }

        private void VtOptions_DoClick()
        {
            Frota.ShowMenuStrip(VtOptions.btnOpcoes);
        }

        private void toolStripMenuItem64_Click(object sender, EventArgs e)
        {
            var b = new FrmAuxiliar {Tabela = 14, Desctabela = "Cor"};
            b.ShowForm(this);
        }

        private void toolStripMenuItem65_Click(object sender, EventArgs e)
        {
            var b = new FrmAuxiliar { Tabela = 10, Desctabela = "Tipos de filtros" };
            b.ShowForm(this);
        }

        private void toolStripMenuItem67_Click(object sender, EventArgs e)
        {
            var b = new FrmAuxiliar {Tabela = 15, Desctabela = "Companhia de leasing"};
            b.ShowForm(this);
        }

        private void toolStripMenuItem69_Click(object sender, EventArgs e)
        {
            var b = new FrmAuxiliar {Tabela = 11, Desctabela = "Tipos de combustível"};
            b.ShowForm(this);
        }

        private void toolStripMenuItem68_Click(object sender, EventArgs e)
        {
            var b = new FrmAuxiliar {Tabela = 16, Desctabela = "Companhia de seguros"};
            b.ShowForm(this);
        }

        private void códigosDeIntegraçãoNaContabilidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var b = new FrmCpoc();
            //b.ShowForm(this);
            Util.ShowForm(this, "FrmCpoc");
        }

        private void btnTrailer_DoClick()
        {
            var b = new FrmVt {Origem = "Tr"};
            b.ShowForm(this);
        }

        private void estadoDoProjectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmAuxiliar {Tabela = 70, Desctabela = @"Estado do Projecto"};
            b.ShowForm(this);
        }

        private void facturasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Integracao.Integradoc(this,"fact");
        }

        private void recibosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
             Integracao.Integradoc(this,"Rcl");
        }

        private void facturasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
             Integracao.Integradoc(this,"facc");
        }

        private void pagamentosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Integracao.Integradoc(this,"pgf");
        }

        private void configuraçãoDeRecibosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var b = new FrmTpgp();
            //b.ShowForm(this);
            Util.ShowForm(this, "FrmTpgp");
        }

        private void toolStripMenuItem100_Click(object sender, EventArgs e)
        {
            //var b = new FrmPeRcl();
            //b.ShowForm(this);
            Util.ShowForm(this, "FrmPeRcl");
        }

        private void btnReciboMenu_DoClick()
        {
            RHRecibos.ShowMenuStrip(btnReciboMenu.btnOpcoes);
        }

        private void toolStripMenuItem101_Click(object sender, EventArgs e)
        {
            //var b = new FrmPerclAutomat();
            //b.ShowForm(this);
            Util.ShowForm(this, "FrmPerclAutomat");
        }

        private void btnObrigacoes_DoClick()
        {
            RHDeclaracoes.ShowMenuStrip(btnObrigacoes.btnOpcoes);
        }

        private void btnAlteracoes_DoClick()
        {

            Util.ShowForm(this, "FrmAltermensal");
        }

        private void seguradorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmAuxiliar
            {
                Tabela = 16,
                Desctabela = "Companhia de seguros"
            };
            b.ShowForm(this);
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            Integracao.CadastroContas(this,"pe");
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            Integracao.Integradoc(this,"peRcl");
        }

        private void btnRhCt_DoClick()
        {
            RHCT.ShowMenuStrip(btnRhCt.btnOpcoes);
        }

        private void toolStripMenuItem70_Click(object sender, EventArgs e)
        {
            //var b = new FrmFolhaInss();
            //b.ShowForm(this);
            Util.ShowForm(this, "FrmFolhaInss");
        }

        private void balçõesDeSegurançaSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmPeAuxilar
            {
                Tabela = 25,
                Desctabela = "Balcões de Segurança Social"//Maputo, Matola
            };
            b.ShowForm(this);
        }

        private void toolStripMenuItem11_Click_1(object sender, EventArgs e)
        {
            //var b = new FrmRlt();
            //b.ShowForm(this);
            Util.ShowForm(this, "FrmRlt");
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            //var b = new FrmRltsql();
            //b.ShowForm(this);
            Util.ShowForm(this, "FrmRltsql");
        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            //var b = new FrmRdlcxml();
            //b.ShowForm(this);
            Util.ShowForm(this, "FrmRdlcxml");
        }

        private void btnImobilizado_Click(object sender, EventArgs e)
        {
            CallPanelControl(btnImobilizado, panelImobilizado);
        }

        private void motoristaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var b = new FrmMotorista();
            //b.ShowForm(this);
            Util.ShowForm(this, "FrmMotorista");
        }

        private void tipoDeActivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmCtauxiliar
            {
                Tabela = 2,
                Desctabela = "Tipos de Activos" 
            };
            b.ShowForm(this);
        }

        private void toolStripMenuItem6_Click_1(object sender, EventArgs e)
        {
            Util.ShowForm(this, "FrmTabelaAmort");
        }

        private void parâmetrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CallParam();
        }

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            Util.ShowForm(this, "Frmdlei");
        }

        private void dropDownButton3_DoClick()
        {
            IMBConfiguracao.ShowMenuStrip(dropDownButton3.btnOpcoes);
        }

        private void localizaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmCtauxiliar
            {
                Tabela = 3,
                Desctabela = "Localização" 
            };
            b.ShowForm(this);
        }

        private void centroDeCustoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Util.ShowForm(this, "FrmCCusto");
        }

        private void naturezaDoActivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmCtauxiliar
            {
                Tabela = 4,
                Desctabela = "Natureza de activo" 
            };
            b.ShowForm(this);
        }

        private void dropDownButton4_DoClick()
        {
            IMBOperacoes.ShowMenuStrip(dropDownButton4.btnOpcoes);
        }

        private void buttonMenu3_DoClick()
        {
            CallFormComprar();
        }

        private void CallFormComprar()
        {
            var retorno = IsValido("tdocf", "FrmCp");
            if (retorno.Valido)
            {
                var defa = SQL.GetField("sigla", "tdocf", "defa=1").ToString();
                var defaCond = retorno.lista.AsEnumerable().Where(x => x.Ecran.Equals(defa.Trim())).Any(x => x.Ver.Equals(true)) ? $"sigla ='{defa}'" : $"sigla ='{retorno.lista.AsEnumerable().First(x => x.Ver.Equals(true)).Ecran.Trim()}'";
                var b = new FrmCp { Tdocfcondicao = defaCond, ListaUsracessos = retorno.lista, Usracessos = retorno.lista.FirstOrDefault() };
                b.ShowForm(this);
            }
        }

        private void buttonMenu1_DoClick_1()
        {
            Util.ShowForm(this, "FrmActivo");
        }

        private void tipoDeDepreciaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmCtauxiliar
            {
                Tabela = 5,
                Desctabela = "Tipos de Depreciações"
            };
            b.ShowForm(this);
        }

        private void btnRhTesoura_DoClick()
        {
            Util.ShowForm(this, "FrmContas");
        }

        private void btnCONTABILIDADE_Click(object sender, EventArgs e)
        {
            CallPanelControl(btnCONTABILIDADE,panelContabilidade);
        }

        private void CallPanelControl(Button btn, FlowLayoutPanel pnl)
        {
            panelMenuTop.Controls.Clear();
            panelMenuTop.Controls.Add(pnl);
            pnl.Location = new Point(0, 1);
            pnl.Visible = true;
            SetBackColor(btn);
        }


        private void btnProcurment_DoClick()
        {
            try
            {
                var path = Application.StartupPath;
                foreach (var fileName in Directory.GetFiles(path))
                {
                    if (fileName.Contains("dtExcel.xlsx"))
                    {
                        //fileName is the file name
                        File.Delete(fileName);
                    }
                    if (fileName.Contains("EmpresaSeleccionada"))
                    {
                        File.Delete(fileName);
                    }
                }
                var b = new FrmProcur();
                b.ShowForm(this);
            }
            catch
            {
                var b = new FrmProcur();
                b.ShowForm(this);
            }
        }

      

    

      

        private void regimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmAuxiliar { Tabela = 73, Desctabela = @"Regime" };
            b.ShowForm(this);
        }

        private void classeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmAuxiliar { Tabela = 74, Desctabela = @"Classe" };
            b.ShowForm(this);
        }

        private void modalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmAuxiliar
            {
                Tabela = 75,
                Desctabela = @"Modalidade"
            };
            b.ShowForm(this);
        }










        private void btnPgc_DoClick()
        {
            var w = new Pc();
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

        private void btnLcont_DoClick()
        {
            var w = new FrmLContab();
            w.ShowForm(this);
        }

        private void btnCTConfiguracao_DoClick()
        {
            CTConfiguracao.ShowMenuStrip(btnCTConfiguracao.btnOpcoes);
        }

        public void UpdateAnoCont()
        {
           btnAnoCT.button3.Text = Pbl.AnoContabil().ToString();
        }

        private void apuramentoIVAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new ParamIva();
            b.ShowForm(this);
        }

        private void apuramentoDeResulatadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new ParamRes();
            b.ShowForm(this);
        }

        private void mesesDaContabilidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new Mesescont();
            b.ShowForm(this);

        }

        private void toolStripMenuItem24_Click(object sender, EventArgs e)
        {
            var w = new FrmParam();
            w.ShowForm(this);
        }

        private void toolStripMenuItem25_Click(object sender, EventArgs e)
        {
            var b = new SI();
            b.ShowForm(this);
        }

        private void tabelaDeCâmbiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmCambio();
            b.ShowForm(this);
        }

        private void tabelasDeMoedasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmMoedas();
            b.ShowForm(this);
        }

        private void códigosDeIntegraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var w = new FrmCpoc();
            w.ShowForm(this);
        }

        private void tabelasDeIVAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmAuxiliar { Tabela = 5, Desctabela = "Tabela de IVA" };
            b.ShowForm(this);
        }

        private void toolStripMenuItem30_Click(object sender, EventArgs e)
        {
            var b = new FrmPw();
            b.ShowForm(this);
        }

        private void tipoDeGruposDeContasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CallFrmCtAuxiliar("Grupo de Clientes", 1, true);
        }

        private void CallFrmCtAuxiliar(string grupo, int tabela, bool height2 =false)
        {
            var b = new FrmCtauxiliar
            {
                Tabela = tabela,
                Desctabela = grupo,
                Height2 = height2
            };
            b.ShowForm(this);
        }

        private void btnApuraiva_DoClick()
        {
            var b = new Apiva();
            b.ShowForm(this);
        }

        private void btnApuraResultados_DoClick()
        {
            var b = new Aresult();
            b.ShowForm(this);
        }

        private void btnCtProcessos_DoClick()
        {
            CTProcessos.ShowMenuStrip(btnCtProcessos.btnOpcoes);
        }

        private void transferiaDeMovimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmTransfmov();
            b.ShowForm(this);
        }

        private void definirOAnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new Anocont { SAno = UpdateAnoCont };
                b.ShowForm(this);
        }
        private void saldosIniciaisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var b = new SI();
            b.ShowForm(this);
        }

        private void btnCtMapas_DoClick()
        {
            CTMapas.ShowMenuStrip(btnCtMapas.btnOpcoes);
        }

        private void toolStripMenuItem28_Click_1(object sender, EventArgs e)
        {
            var w = new FrmBalanco { Tipo = 2, label1 = { Text = @"Demostração de Resultados" } };
            w.ShowForm(this);
        }

        private void balancetesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new Balancete();
            b.ShowForm(this);
        }

        private void balançoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var w = new FrmBalanco { Tipo = 1, label1 = { Text = @"Balanço" } };
            w.ShowForm(this);
        }

        private void toolStripMenuItem31_Click(object sender, EventArgs e)
        {
            Integracao.Integradoc(this, "fact");
        }

        private void toolStripMenuItem32_Click(object sender, EventArgs e)
        {
            Integracao.Integradoc(this, "Rcl");
        }

        private void clientesToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Integracao.CadastroContas(this, "cl");
        }

        private void toolStripMenuItem33_Click(object sender, EventArgs e)
        {
            Integracao.Integradoc(this, "facc");
        }

        private void toolStripMenuItem34_Click(object sender, EventArgs e)
        {
            Integracao.Integradoc(this, "pgf");
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Integracao.CadastroContas(this, "pe",true);
        }

        private void toolStripMenuItem35_Click(object sender, EventArgs e)
        {
            Integracao.CadastroContas(this, "fnc");
        }

        private void tesourariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Integracao.CadastroContas(this, "Contas");
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

        private void btnCTRelat_DoClick()
        {
            var b = new FrmRelatorios { Modulo = "CT" };
            b.ShowForm(this);
        }

        private void fornecedoresToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            CallFrmCtAuxiliar("Grupo de Fornecedores", 6, true);
        }

        private void pessoalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CallFrmCtAuxiliar("Grupo de Pessoal", 7, true);
        }

        private void vendedoresToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CallFrmCtAuxiliar("Grupo de Vendedores", 8, true);
        }

        private void activosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CallFrmCtAuxiliar("Grupo de Activos", 9, true);
        }

        private void activosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Integracao.CadastroContas(this, "ST", true);
        }

        private void encontroDeContasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var w = new FrmEncontrocontas();
            //w.ShowForm(this);
          
        }

        private void btnProcurment_Click(object sender, EventArgs e)
        {
            
        }

        private void configuraçãoDeMapasEFolhasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmRltsql();
            b.ShowForm(this);
        }

        private void planoDeContasEDiáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var w = new FrmImport();
            w.ShowForm(this);
        }

        private void btnAnoGest_DoClick()
        {
            var b = new FrmParam();
            b.ShowForm(this);
        }

        private void btnPrcProcess_DoClick()
        {
            var b = new FrmProcur();
            b.ShowForm(this);
        }

        private void btnProcurmentt_Click(object sender, EventArgs e)
        {
            CallPanelControl(btnProcurmentt, panelProcurment);
        }

        private void btCliente_DoClick()
        {
            CallFormCliente();
        }

        private void btFornecedor_DoClick()
        {
            CallFormFornecedor();
        }

        private void btnPrcConfiguracoes_DoClick()
        {
            PrcConfiguracao.ShowMenuStrip(btnPrcConfiguracoes.btnOpcoes);
        }

        private void btnClassFornecedor_Click(object sender, EventArgs e)
        {
            Auxiliar(71, @"CRITÉRIOS DE CLASSIFICAÇÃO DO FORNECEDOR", string.Empty);
        }
        private void btnGrauImportacrt_Click(object sender, EventArgs e)
        {
            Auxiliar(69, @"GRAU DE IMPORTÂNCIA DO CRITÉRIO", "Procuremente", @"Peso (De 0 à 100)");
        }

        private void btnAvaliacaoFornecedor_Click(object sender, EventArgs e)
        {
            Auxiliar(72, @"AVALIAÇÃO DO FORNECEDOR",  "Procuremente", @"Valor (De 0 à 10)");
        }

        private void btnCriteriodeAvalicaoPrc_Click(object sender, EventArgs e)
        {
            Auxiliar(76, @"CRITÉRIO DE AVALIAÇÃO NO PROCUREMENT", string.Empty);
        }

        private void btnRegimePrc_Click(object sender, EventArgs e)
        {
            Auxiliar(73, @"Regime", string.Empty);
        }

        private void btnModalidadePrc_Click(object sender, EventArgs e)
        {
            Auxiliar(75, @"Modalidade", string.Empty);
        }

        private void btnClassePrc_Click(object sender, EventArgs e)
        {
            Auxiliar(74, @"Classe",string.Empty);
        }
        void Auxiliar(int numtabela,string descricao,string origem="",string descricaolabel="")
        {
            var b = new FrmAuxiliar
            {
                Tabela = numtabela,
                Desctabela = descricao
            };
            b.OrigemProc = origem;
            b.tbObs.Label1Text = descricaolabel;
            b.ShowForm(this);
        }
        private void btProdutos_DoClick()
        {
            var b = new FrmProduto
            {
                Servico = false,
                Origem = "Pr"
            };
            b.ShowForm(this);
        }

        private void buttonMenu18_DoClick()
        {
            var b = new FrmRelatorios { Modulo = "PRC" };
            b.ShowForm(this);
        }

        private void adjudicaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Auxiliar(79, @"Adjudicação".ToUpper(), string.Empty);
        }

        private void buttonMenu17_DoClick()
        {
            var b = new FrmDashboard( );
            b.ShowForm(this);
            
        }

        private void btncruzamentocontas_DoClick()
        {
            var b = new FrmPgfCrzcnt();
            b.ShowForm(this);
        }

        private void btnPessoal_Load(object sender, EventArgs e)
        {

        }

        private void btncruzamentocontas_Load(object sender, EventArgs e)
        {

        }

        private void buttonMenu16_DoClick()
        {
         

        }

        private void btnEncontrContas_DoClick()
        {
            var b = new FrmReg2();
           // b.label1.Text = $"Encontro de Contas Correntes";
           b.Origemsssss = 2;
            b.EditMode = true;
            b.ShowForm(this);
        }

        private void btnEncontrodeContasCorre_DoClick()
        {
            var b = new FrmPgf2();
            b.label1.Text = $"Encontro de Contas Correntes";
            b.brrtextCliente.Visible=b.gridFormasCliente.Visible=true;
            b.Origemsssss = 1;
            b.ShowForm(this);
        }

        private void formasDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmFpagam();
            b.ShowForm(this);
        }

        private void buttonMenu5_DoClick()
        {
            CallUserForm();
        }

        private void buttonMenu4_DoClick()
        {
            CallEmpresaForm();
        }

        private void partidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmPart();
            b.ShowForm(this);
        }

        private void classesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmClas();
            b.ShowForm(this);
        }

        private void btnArmazem_Load(object sender, EventArgs e)
        {

        }

        private void contaCorrenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helper.ChamaformImport("cc","","","Conta corrente");
        }



        private void stockDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helper.ChamaformImport("mstk", "", "", "Movimentos de Stock");
        }

        private void formasDePagamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Helper.ChamaformImport("formasp", "", "", "Formas de pagamento");
        }

        private void movimentosDeTesourariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helper.ChamaformImport("mvt", "", "", "Movimentos de Tesouraria");
        }

        private void contaCorrenteDoFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helper.ChamaformImport("fcc", "", "", "Conta corrente de fornecedor ");
        }

        private void centrosDeCustoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helper.ChamaformImport("ccu", "", "", "Centros de custo");
        }

        private void contasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Helper.ChamaformImport("contas", "", "", "Contas");
        }

        private void btnSupervsor_DoClick()
        {
            AnaliseConfig.ShowMenuStrip(btnSupervsor.btnOpcoes);
        }

        private void passwordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Util.ShowForm(this, "FrmPw");
        }

        private void tiposDeContratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Util.ShowForm(this, "FrmTContrato");
        }

        private void feriadosToolStripMenuItem_Click(object sender, EventArgs e)
        {    
            Util.ShowForm(this, "FrmFeriado");
        }

        private void buttonMenu4_DoClick_1()
        {
            Util.ShowForm(this, "FrmPw");
        }

        private void tipoDeProcessosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Util.ShowForm(this, "FrmTodcpe");
        }

        private void btnProcesso_DoClick()
        {           
            Util.ShowForm(this, "FrmProcesso");
        }

        private void mesesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmAuxiliar { Tabela = 21, Desctabela = "Tipo de meses de salário" };
            b.ShowForm(this);
        }

        private void btnPlanoFerias_DoClick()
        {            
            Util.ShowForm(this, "FrmPlanoFerias");
        }

        private void diasDeFériasSegundoALeiToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            Util.ShowForm(this, "FrmDiasFeria");
        }

        private void checkupDaContaCorrenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmCheckCC();
            b.Origem = "CL";
            b.dmzProcess.label1.Text = "Cliente";
            b.dmzProcess.SqlComandText = "Select clstamp,nome from cl";
            b.ShowForm(this);

            //Util.ShowForm(this, "FrmCheckCC");
        }

        private void checkupDaContaCorrenteDeFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmCheckCC();
            b.Origem = "FNC";
            b.dmzProcess.label1.Text = "Fornecedor";
            b.dmzProcess.SqlComandText = "Select fncstamp,nome from fnc";
            b.ShowForm(this);
            //Util.ShowForm(this, "FrmCheckCC");
        }

        private void panelContabilidade_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAcademia_Click(object sender, EventArgs e)
        {
            CallPanelControl(btnAcademia, PanelAcademia);
        }

        private void btnEstudante_DoClick()
        {
            ChamaAluno();
        }

        private void btnDocente_DoClick()
        {
            var w = new FrmPes { label1 = { Text = @"Ficha do Docente" }, Modulo = "AC" };
            w.ShowForm(this);
        }

        private void btnAcademico_DoClick()
        {
            Academico.ShowMenuStrip(btnAcademico.btnOpcoes);
        }

        private void btnFinanceiro_DoClick()
        {
            Secretaria.ShowMenuStrip(btnFinanceiro.btnOpcoes);
        }

        private void toolStripMenuItem93_Click(object sender, EventArgs e)
        {
            var w = new FrmFeriado();
            w.ShowForm(this);
        }

        private void anoLectivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var w = new FrmAnoLectivo();
            w.ShowForm(this);
        }

        private void disciplinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var w = new FrmDisc();
            w.ShowForm(this);
        }

        private void semestreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var w = new FrmSem();
            w.ShowForm(this);
        }
        private void gradeDoCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {                    
            var w = new FrmGrade();
            w.ShowForm(this);
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var w = new FrmCurso();
            w.ShowForm(this);
        }

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var w = new FrmPes();
            w.ShowForm(this);
        }

        private void documentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var w = new FrmDocac();
            w.ShowForm(this);
        }

        private void horáriosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Util.ShowForm(this, "FrmHorario");
        }

        private void disciplinasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Util.ShowForm(this, "FrmDisc");
        }

        private void salasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Util.ShowForm(this, "FrmSala");
        }

        private void unidadeeDeEnsinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var w = new FrmCCusto();
            w.Escola = true;
            w.label1.Text = @"Unidade de ensino";
            w.ShowForm(this);
        }

        private void turmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Util.ShowForm(this, "FrmTurma");
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChamaAluno();
        }

        private void ChamaAluno()
        {
            Util.ShowForm(this, "FrmAluno");
        }

        private void calendárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void disciplinaToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            Util.ShowForm(this, "FrmDisc");
        }

        private void faculdadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var w = new FrmAlauxiliar();
            w.Tabela = 10;
            w.Desctabela="Faculdades";
            w.ShowForm(this);

        }

        private void cursosToolStripMenuItem1_Click(object sender, EventArgs e)
        {            
            Util.ShowForm(this, "FrmCurso");
        }

        private void grupoCientíficoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var w = new FrmGrupo();
            w.ShowForm(this);
        }

        private void anoSemestreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var w = new FrmAnoSem();
            w.ShowForm(this);
        }

        private void btnACCadastro_DoClick()
        {
            ACConfiguracao.ShowMenuStrip(btnACCadastro.btnOpcoes);
        }

        private void btnEscolas_Click(object sender, EventArgs e)
        {

        }

        private void btnMatricula_DoClick()
        {
            //var w = new FrmMatricula();
            //w.ShowForm(this);

            Helper.ShowForm<FrmMatriculaAluno>(this);
        }

        private void btnFinac_DoClick()
        {
            Financeiro.ShowMenuStrip(btnFinac.btnOpcoes);
        }

        private void planoDePagamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void turnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var w = new FrmTurno();
            w.ShowForm(this);
        }

        private void toolStripMenuItem96_Click(object sender, EventArgs e)
        {            
            Util.ShowForm(this, "FrmSala");
        }

        private void tipoDeAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CallFormAuxiliar(21, "Tipo de aluno", true);
        }

        private void btnReligiao_Click(object sender, EventArgs e)
        {
            CallFormAuxiliar(1,"Religião", true);
        }

        private void btnInstbolsa_Click(object sender, EventArgs e)
        {
            CallFormAuxiliar(3, "Instituições de bolsa", true);
        }

        private void btnTipobolsa_Click(object sender, EventArgs e)
        {
            CallFormAuxiliar(4, "Tipo de bolsa",true);
        }

        private void CallFormAuxiliar(int tabela, string desctabela,bool origem=false)
        {
            if (origem)
            {
                var w = new FrmAlauxiliar();
                w.Tabela = tabela;
                w.Desctabela = desctabela;
                w.ShowForm(this);
            }
            else
            {
                var w = new FrmAuxiliar();
                w.Tabela = tabela;
                w.Desctabela = desctabela;
                w.ShowForm(this);
            }
        }

        private void toolStripMenuItem37_Click(object sender, EventArgs e)
        {
            
            var w = new FrmProv();
            w.ShowForm(this);
        }

        private void toolStripMenuItem27_Click(object sender, EventArgs e)
        {
            var w = new FrmPaises();
            w.ShowForm(this);
        }

        private void toolStripMenuItem39_Click(object sender, EventArgs e)
        {
            var w = new FrmBanco();
            w.ShowForm(this);

        }

        private void emissãoDeCartõesDeEstudanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helper.ShowForm<FrmCart>(this);
        }

        private void gerarCartõesParaImpressãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helper.ShowForm<FrmCartimp>(this);
        }

        private void toolStripMenuItem95_Click(object sender, EventArgs e)
        {
            Helper.ShowForm<FrmBarCodeQR>(this);   
        }

        private void lançamentoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lancarnotas("and Descricao not like '%exame%'");
        }

        private void toolStripMenuItem108_Click(object sender, EventArgs e)
        {
            Helper.ShowForm<FrmMensalidade>(this);
        }

        private void toolStripMenuItem111_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem106_Click(object sender, EventArgs e)
        {
            var b = new FrmRelatorios { Modulo = "GES" };
            b.ShowForm(this);
        }

        private void toolStripMenuItem107_Click(object sender, EventArgs e)
        {
            Helper.ShowForm<FrmPlanopag>(this);
        }

        private void btnTipoSexo_Click(object sender, EventArgs e)
        {
            CallFormSexo();
        }

        private void CallFormSexo()
        {
            var b = new FrmPeAuxilar
            {
                Tabela = 8,
                Desctabela = "Tipo de Sexo"
            };
            b.ShowForm(this);
        }

        private void btnEstadoCivil_Click(object sender, EventArgs e)
        {
            CallFormEstadoCivil();
        }

        private void btnNivelAcademico_Click(object sender, EventArgs e)
        {
            CallFormNivelAcad();
        }

        private void btnGrauParentesco_Click(object sender, EventArgs e)
        {
            CallFormaGrauParant();
        }

        private void linguaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CallFormLingua();
        }

        private void classificaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CallFormClassific();
        }

        private void diárioDeClasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helper.ShowForm<FrmDiarioc>(this);
        }

        private void enviarSMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helper.ShowForm<FrmSendSMS>(this);
        }

        private void aulinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var w = new FrmAulino();
            w.ShowForm(this);

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listaDeEstudantesSemFotoNoSietmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helper.ShowForm<FrmListaSemFoto>(this);
        }

        private void btnHorasProf_DoClick()
        {
            var b = new FrmAltermensal();
            b.LancHoras = true;
            b.ShowForm(this);
        }

        private void planoDeMultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helper.ShowForm<FrmPlanomulta>(this);
        }

        private void processamentoDeMultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helper.ShowForm<FrmProcmulta>(this);
        }

        private void tiposDeResultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helper.ShowForm<FrmTiporesult>(this);
        }

        private void parâmetrosDeAvaliaçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Helper.ShowForm<FrmPlanoaval>(this);
        }

        private void btnAnoCT_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnAnoCT_DoClick()
        {
            Helper.ShowForm<FrmParam>(this);
        }

        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem26_Click(object sender, EventArgs e)
        {

        }

        private void btnBilhete_DoClick()
        {
            Helper.ShowForm<FrmBilhete>(this);
        }

        private void btnMaquinas_DoClick()
        {
            Helper.ShowForm<FrmMaquina>(this);
        }

        private void btnCorredor_DoClick()
        {
            var f =new FrmCorredor();
            f.Tipofam = 1;
            f.ShowForm(this);
        }

        private void btnViatura_DoClick()
        {
            Frota.ShowMenuStrip(btnViatura.btnOpcoes);
        }

        private void btnPessoal_DoClick_1()
        {
            
        }

        private void cadastroDePessoalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helper.ShowForm<FrmPes>(this);
        }
        private void toolStripMenuItem38_Click(object sender, EventArgs e)
        {
            var f = new FrmAuxiliar();
            f.Tabela = 100;
            f.Desctabela = "Cadastro de sentidos";
            f.ShowForm(this);
        }

        private void btnTMConfig_DoClick()
        {
            TMConfig.ShowMenuStrip(btnTMConfig.btnOpcoes);
        }

        private void btnPessoal_DoClick_2()
        {
            RHConfiguracao.ShowMenuStrip(btnPessoal.btnOpcoes);
        }

        private void toolStripMenuItem37_Click_1(object sender, EventArgs e)
        {
            var f = new FrmAuxiliar();
            f.Tabela = 101;
            f.Desctabela = "Tipos de preço";
            f.ShowForm(this);
        }

        private void toolStripMenuItem39_Click_1(object sender, EventArgs e)
        {
           
            CallFormAuxiliar(105, "Descrição dos testes", true);
        }
        private void exameNormalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lancarnotas("and Descricao ='Exame normal'", true);
        }

        private void Lancarnotas(string strin, bool examenorma = false, bool examerecorr = false,
            bool examespe = false)
        {
            var f = Helper.ShowForm<FrmLancnotas>(this);
            var dtAnosem = SQL.GetGen2DT($"select Alauxiliarstamp,Descricao from " +
                                         $"Alauxiliar where Tabela=105 " +
                                         $"{strin} order by codigo");
            f.VisualisarExameNormal = examenorma;
            f.VisualisarExameRecorencia = examerecorr;
            f.VisualisarExameEpecial = examespe;
            f.SetReadonly();
            f.BindCombo(f.cbxDescrTestes, dtAnosem);
        }
        //
        private void exameDeRecorrênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lancarnotas("and Descricao ='Exame de Recorrência'", false, true);
        }
        private void exameEpecialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lancarnotas("and Descricao ='Exame Especial'", false, false,
                true);
        }

        private void formaDeIngressoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CallFormAuxiliar(81, "Forma De Ingresso", false);
        }

        private void toolStripMenuItem41_Click(object sender, EventArgs e)
        {

            CallFormAuxiliar(79, "Situação de matricula", false);
        }

        private void tipoDeDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Util.ShowForm(this, "FrmTdocMat");
        }

        private void parâmetrosDeAvaliaçãoToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Helper.ShowForm<FrmPlanoaval>(this);
        }

        private void removerFacturasDuplicadasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void removerFacturasDuplicadasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Helper.ShowForm<FrmRemoverFactura>(this);
        }

        private void removerDisciplinasDuplicadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helper.ShowForm<FrmRemoverDisc>(this);
        }

        private void alterarDiárioDeClasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rr=  Helper.ShowForm<FrmDiarioc>(this);
            rr.OrigemDc=true;
        }
       public bool Entrou=false;
        private void entrarNoDMZFrameworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Entrou = false;
            var f = new FrmLoginFWrk(this);
            f.ShowDialog();
            if (Entrou)
            {
                dmzFramework.ShowMenuStrip();
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem72_Click(object sender, EventArgs e)
        {

        }

        private void btnAnalise_Click_1(object sender, EventArgs e)
        {
            //panelMenuTop.Controls.Clear();
            //panelMenuTop.Controls.Add(panelRelatorios);
            //panelRelatorios.Location = new Point(0, 1);
            //panelRelatorios.Visible = true;
            //SetBackColor(btnAnalise);
        }

        private void SetBackColor(ButtonMenu btnAnalise)
        {
            //btnAnalise.Image = btnAnalise.BackColor == Color.DarkGoldenrod ? Properties.Resources.AnalisesT : Properties.Resources.Analises;

        }

        private void btnAnalise_BackColorChanged(object sender, EventArgs e)
        {
            btnAnalise.Image = btnAnalise.BackColor == Color.DarkGoldenrod ? Properties.Resources.AnalisesT : Properties.Resources.Analises;
        }

        private void btnAnalise_DoClick()
        {
            var b = new FrmRelatorios { Modulo = "AC" };
            b.ShowForm(this);
            //Helper.ShowForm<FrmRelatorios>(this);
            //panelRelatorios.ShowMenuStrip(VtOptions.btnAnalise);
        }

        private void btnServico_Load(object sender, EventArgs e)
        {

        }

        private void inscriçãoParaExameEspecialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new FrmMatriculaAluno { ExameEpecial = true };
            b.ShowForm(this);
        }

        private void lançamentoDeExameEspecialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lancarnotas("and Descricao ='Exame Especial'", false, false,
               true);
        }

        private void btnRecibo_Load(object sender, EventArgs e)
        {

        }

        private void remToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void removerMensalidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helper.ShowForm<FrmRemovMatFact>(this);
        }

        private void toolStripMenuItem71_Click(object sender, EventArgs e)
        {

        }

        private void calendarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Helper.ShowForm<UI.Frmcalendario>(this);
        }
    }
}
