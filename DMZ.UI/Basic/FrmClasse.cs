using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using DMZ.UI.UC;
using DMZ.UI.Classes;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Generic;
using DMZ.UI.UI;
using Util = DMZ.UI.Generic.Util;
using DMZ.UI.UI.RH;
using DMZ.UI.UI.Contabil;
using DMZ.UI.Extensions;

namespace DMZ.UI.Basic
{
    [Designer(typeof(FrmControlDesigner))]
    public partial class FrmClasse : Form
    {
        //Overridden methods
        protected override void WndProc(ref Message m)
        {
            //const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;

            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right

            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>

            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          

                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion

            //Remove border and keep snap window
            //if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            //{
            //    return;
            //}

            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);

                if (wParam == SC_MINIMIZE)  //Before
                    formSize = ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    Size = formSize;
            }
            base.WndProc(ref m);
        }
        public Usracessos Usracessos { get; set; }
        public virtual List<PropertyInfo> GetListProps()
        {
            return new List<PropertyInfo>();
        }
        public int OrigemPgf { get; set; } = 0;
        private void MouseDownEvent()
        {
            Dllimport.ReleaseCapture();
            Dllimport.SendMessage(Handle, 0x112, 0xf012, 0);
        }
        #region Região de Definição de Propridades ..........................
        [Description("Verifica se pretende verificar a numeracao automatica")]
        public bool Checkautonumber { get; set; }
        [Description("Condição do numerador automatico")]
        public bool GravarNovo { get; set; }
        public bool Gravando { get; set; }
        public bool Cancelando { get; set; }
        public bool Inserindo { get; set; }
        public bool Controlacesso { get; set; }
        [Description("Nome do campo data das tabelas multidoc: Ex. fact é data")]
        public string MultDocDataNome { get; set; } = "data";
        [Description("Serve para saber q data a usar nas procuras..se for 1 é geral, 2 é contabilidade")]
        public int TipoApp { get; set; } = 1;
        public bool Actualizando { get; set; }
        public bool EditMode { get; set; }
        [Description("Stamp do cabeçalho")]
        public string CLocalStamp { get; set; } = string.Empty;

        public bool Procurou { get; set; }
        public bool Cancelado { get; set; }
        public delegate void ActualizarFilh(string p);
        public event ActualizarFilh ActualizaFilhas;
        public virtual void OnActualizFilhas(string p)
        {
            var handler = ActualizaFilhas;
            handler?.Invoke(p);
        }
        public virtual void UpdGridFormasp()
        {

        }
        public delegate void Delete();

        public event Delete AfterDelete;
        protected virtual void OnAfterDelete()
        {
            var handler = AfterDelete;
            handler?.Invoke();
        }
        public delegate void GravarFilha();

        public event GravarFilha GravaFilhas;
        protected virtual void OnGravaFilhas()
        {
            if (Cancelado) return;
            var gridUiList = Helper.GetAll(this, typeof(GridUi)).Where(x => ((GridUi)x).GridFilha).ToList();
            if (gridUiList.Count > 0)
            {
                foreach (var grid in gridUiList.Cast<GridUi>())
                {
                    var retorno = grid?.SaveData(!Procurou, Ctabela, CLocalStamp);
                    if (retorno.Value.numero == 0 && retorno.Value.messagem == null) continue;
                    if (retorno.Value.numero != 0) continue;
                    if (retorno.Value.messagem.Contains("Dados Gravados com sucesso!..")) continue;
                    MsBox.Show(retorno.Value.messagem);
                    Cancelado = true;
                    break;
                }
                gridUiList.Clear();
            }
            var gridUiFtList = Helper.GetAll(this, typeof(GridUIFt)).ToList();
            if (gridUiFtList.Count > 0)
            {
                foreach (var grid in gridUiFtList.Cast<GridUIFt>())
                {
                    var retorno = grid?.SaveData(!Procurou, Ctabela, CLocalStamp);
                    if (retorno.Value.numero == 0 && retorno.Value.messagem == null) continue;
                    if (retorno.Value.numero != 0) continue;
                    MsBox.Show(retorno.Value.messagem);
                    Cancelado = true;
                    break;
                }
                gridUiFtList.Clear();
            }
            var gridFormasPList = Helper.GetAll(this, typeof(GridFormasP)).ToList();
            if (gridFormasPList.Count <= 0) return;
            {
                foreach (var grid in gridFormasPList.Cast<GridFormasP>())
                {
                    if (!grid.Movtz) continue;
                    var retorno = grid?.SaveData(!Procurou, Ctabela, CLocalStamp);
                    if (retorno.Value.numero != 0) continue;
                    MsBox.Show(retorno.Value.messagem);
                    Cancelado = true;
                    break;
                }
                gridFormasPList.Clear();
            }
        }
        public int Indice { get; set; }
        private bool _flag = false;
        public string Ctabela { get; set; }
        public string CSequenc { get; set; }
        public string Campo1 { get; set; }
        public string Campo2 { get; set; }
        public string CCondicao { get; set; } = string.Empty;
        public bool NVerificar { get; set; }
        public DataTable GenTable { get; set; }
        public bool MultiDoc { get; set; }
        public bool Maximizado { get; private set; }
        public Size NSize { get; private set; }
        public Point NLocation { get; private set; }
        public bool Noneg { get; set; }

        public List<string> Lista;
        private Size formSize;
        #endregion

        #region Região do Método Construtor do Formulário......................
        public FrmClasse()
        {

            InitializeComponent();
        }
        #endregion
        public void LimparCampos2()
        {
            var lista = Helper.GetAll(this, typeof(TbDefault)).ToList();
            if (lista.Count > 0)
            {
                foreach (var l in lista)
                {
                    ((TbDefault)l).tb1.Text = string.Empty;
                }
                lista.Clear();
            }
            lista = Helper.GetAll(this, typeof(Procura)).ToList();
            if (lista.Count > 0)
            {
                foreach (var l in lista)
                {
                    ((Procura)l).tb1.Text = string.Empty;
                }
                lista.Clear();
            }
            lista = Helper.GetAll(this, typeof(CbDefault)).ToList();
            if (lista.Count > 0)
            {
                foreach (var l in lista)
                {
                    ((CbDefault)l).cb1.Checked = false;
                    ((CbDefault)l).btnCheck.Image = Properties.Resources.Unchecked_Checkbox_23px;
                }
                lista.Clear();
            }
            lista = Helper.GetAll(this, typeof(DtDefault)).ToList();
            if (lista.Count > 0)
            {
                foreach (var l in lista)
                {
                    ((DtDefault)l).dt1.Value = Pbl.SqlDate;
                }
                lista.Clear();
            }

            lista = Helper.GetAll(this, typeof(ImgGroup)).ToList();
            if (lista.Count > 0)
            {
                foreach (var l in lista)
                {
                    ((ImgGroup)l).pictureBox1.Image = null;
                }
                lista.Clear();
            }

            lista = Helper.GetAll(this, typeof(DMZNumero)).ToList();
            if (lista.Count > 0)
            {
                foreach (var l in lista)
                {
                    ((DMZNumero)l).nud1.Value = 0;
                }
                lista.Clear();
            }
        }

        #region Região do Método Load do Formulário...........................
        private void FrmClasse_Load(object sender, EventArgs e)
        {
            DesabilitaCampo();
            EditMode = false;
            OnActualizFilhas(CLocalStamp);
            Text = label1.Text;
            BindGrids();

        }

        private void BindGrids()
        {
            var listagrid = Helper.GetAll(this, typeof(GridUi)).Where(x => ((GridUi)x).GridFilha).ToList();
            if (listagrid.Count > 0)
            {
                foreach (var l in listagrid)
                {
                    if (l == null) return;
                    ((GridUi)l).BindGridView();
                }
                listagrid.Clear();
            }
            var listagrid2 = Helper.GetAll(this, typeof(GridUIFt)).ToList();
            if (listagrid2.Count > 0)
            {
                foreach (var l in listagrid2)
                {
                    if (l == null) return;
                    ((GridUIFt)l).BindGridView();
                }

                listagrid2.Clear();
            }
        }
        #endregion

        #region Região de Botões de Navegação ...............................
        public virtual void btnPrev_Click(object sender, EventArgs e)
        {
            if (!Procurou) return;

            if (GenTable.HasRows())
            {
                if (Indice == 0)
                {
                    btnPrev.Enabled = false;
                    btnNext.Enabled = true;
                    return;
                }
                Indice--;
                PreencheCampos(GenTable, Indice);
                btnPrev.Enabled = true;
                btnNext.Enabled = true;
            }
            Refresh();
        }
        public virtual void btnNext_Click(object sender, EventArgs e)
        {
            if (!Procurou) return;
            if (GenTable.HasRows())
            {
                if (Indice >= GenTable.Rows.Count - 1)
                {
                    btnPrev.Enabled = true;
                    btnNext.Enabled = false;
                    return;
                }
                Indice++;
                PreencheCampos(GenTable, Indice);
                btnPrev.Enabled = true;
                btnNext.Enabled = true;
            }
            Refresh();
        }

        #endregion 

        #region Região de Botoes de Inserir, Gravar. Editar,Cancel e Imprimir......
        public virtual void btnNovo_Click(object sender, EventArgs e)
        {
            Procurou = false;
            try
            {
                if (!Inserindo)
                {
                    //InserirNovoRegisto();
                    if (Controlacesso)
                    {
                        if (Usracessos != null)
                        {
                            if (Usracessos.Intro)
                            {
                                InserirNovoRegisto();
                            }
                            else
                            {
                                MsBox.Show(Messagem.ParteInicial() + "Desculpa não tem permissão a inserir dados. Contacte o Administrador");
                            }
                        }
                        else
                        {
                            MsBox.Show(Messagem.ParteInicial() + "Desculpa não tem permissão a inserir dados. Contacte o Administrador");
                        }
                    }
                    else
                    {
                        InserirNovoRegisto();
                    }
                }
                else
                {
                    if (!Cancelando) return;
                    var res = MsBox.Show("Deseja Cancelar a Operação ?", DResult.YesNo);
                    if (res.DialogResult == DialogResult.Yes)
                    {
                        if (Inserindo)
                        {
                            LimparCampos2();
                            ClearDataGridView();
                        }
                        EstadoDaTela(AccaoNaTela.Padrao);
                        errorProvider1.Clear();
                        Cancelar();
                    }
                    else
                    {
                        HabilitaCampo();
                    }

                }
                //if (CheckLic())
                //{

                //}
            }
            catch (Exception ex)
            {
                MsBox.Show(Messagem.ParteInicial() + ex);
            }
        }

        private bool CheckLic()
        {
            bool ret = true;
            //if (this is FrmFt || this is FrmDi || this is FrmCp)
            //{
            //    ret = false;
            //    MsBox.Show(Messagem.ParteInicial() + $"A VERSÃO {Pbl.VersaoActivo} EXPRIROU \r\nPorfavor contacte a DMZ SISTEMAS, Tel(s): 840515627/847028510 ou seu REVENDIDOR LOCAL, para renovação da LICENÇA");
            //}
            //if (this is FrmPes)
            //{
            //    ret = false;
            //    MsBox.Show(Messagem.ParteInicial() + $"A VERSÃO {Pbl.VersaoActivo} EXPRIROU \r\nPorfavor contacte a DMZ SISTEMAS, Tel(s): 840515627/847028510 ou seu REVENDIDOR LOCAL, para renovação da LICENÇA");
            //}
            //if (this is Pc || this is FrmDpd || this is FrmDiario || this is FrmLContab)
            //{
            //    ret = false;
            //    MsBox.Show(Messagem.ParteInicial() + $"A VERSÃO {Pbl.VersaoActivo} EXPRIROU \r\nPorfavor contacte a DMZ SISTEMAS, Tel(s): 840515627/847028510 ou seu REVENDIDOR LOCAL, para renovação da LICENÇA");
            //}

            //if (Pbl.GesExpirado)
            //{
            //    if (this is FrmFt || this is FrmDi || this is FrmCp)
            //    {
            //        ret = false;
            //        MsBox.Show(Messagem.ParteInicial() + $"A VERSÃO {Pbl.VersaoActivo} EXPRIROU \r\nPorfavor contacte a DMZ SISTEMAS, Tel(s): 840515627/847028510 ou seu REVENDIDOR LOCAL, para renovação da LICENÇA");
            //    }
            //}
            //if (Pbl.RhsExpirado)
            //{
            //    if (this is FrmPes)
            //    {
            //        ret = false;
            //        MsBox.Show(Messagem.ParteInicial() + $"A VERSÃO {Pbl.VersaoActivo} EXPRIROU \r\nPorfavor contacte a DMZ SISTEMAS, Tel(s): 840515627/847028510 ou seu REVENDIDOR LOCAL, para renovação da LICENÇA");
            //    }
            //}
            //if (Pbl.CtExpirado)
            //{
            //    if (this is Pc || this is FrmDpd || this is FrmDiario || this is FrmLContab)
            //    {
            //        ret = false;
            //        MsBox.Show(Messagem.ParteInicial() + $"A VERSÃO {Pbl.VersaoActivo} EXPRIROU \r\nPorfavor contacte a DMZ SISTEMAS, Tel(s): 840515627/847028510 ou seu REVENDIDOR LOCAL, para renovação da LICENÇA");
            //    }
            //}
            return ret;
        }

        private void InserirNovoRegisto()
        {
            if (Procurou)
            {
                VerificarLista();
            }
            ClearDataGridView();
            EstadoDaTela(AccaoNaTela.Inserir);
        }

        private void VerificarLista()
        {
            if (!Procurou) return;
            if (Lista == null) return;
            if (Lista.Count <= 0) return;
            var str = "";
            foreach (var el in Lista)
            {

                if (string.IsNullOrEmpty(str))
                {
                    str = "\r\n" + $"  {el},";
                }
                else
                {
                    str = str + "\r\n" + $"{el},";
                }
            }


            if (Lista.Count == 1)
            {
                str = $"O Campo '{str.Replace(",", "")}' foi alterado: " +
                      "\r\nDeseja Gravar e Continuar?";
            }
            else
            {
                str = "Os seguintes Campos foram alterados: " +
                      $"{str} " +
                      "\r\nDeseja Gravar e Continuar?";
            }
            var res = MsBox.Show(str, DResult.YesNo, 300);
            if (res.DialogResult != DialogResult.Yes) return;
            Save();
            AfterSave();
        }
        public virtual bool BeforeSave()
        {
            if (Procurou) return true;
            var cSequenc = (TbDefault)Helper.GetAll(this, typeof(TbDefault)).FirstOrDefault(x => ((TbDefault)x).AutoIncrimento.Equals(true));
            var campo = cSequenc?.Value;
            if (!string.IsNullOrEmpty(campo))
            {
                CSequenc = campo;
            }
            if (string.IsNullOrEmpty(CSequenc)) return true;
            var max = SQL.Maximo(Ctabela, CSequenc, CCondicao).ToString(CultureInfo.InvariantCulture);
            var c = (TbDefault)Helper.GetAll(this, typeof(TbDefault)).FirstOrDefault(x => ((TbDefault)x).AutoIncrimento.Equals(true));
            var tbNumero = c?.tb1.Text.ToDecimal();
            if (tbNumero < max.ToDecimal())
            {
                if (!Pbl.Usr.AlteraNumero)
                {
                    MsBox.Show($"Desculpa mas o número sequencial será alterado para: {max}");
                    c.tb1.Text = max;
                    return true;
                }
            }
            return true;
        }


        public virtual void btnGravar_Click(object sender, EventArgs e)
        {
            var lista = Helper.CamposObrigatorios(this);
            Cancelado = false;
            if (GravarNovo)
            {

                if (lista.Count == 0)
                {
                    if (BeforeSave())
                    {
                        Save();

                        OnGravaFilhas();
                        if (Cancelado)
                        {
                            if (OrigemPgf == 0)
                            {
                                Helper.Alert("Operação cancelada", Form_Alert.EnmType.Warning);
                            }
                        }
                        else
                        {
                            AfterSave();
                            Procurou = true;
                            if (OrigemPgf == 0)
                            {
                                Helper.Alert("Gravado com sucesso", Form_Alert.EnmType.Success);
                            }
                        }
                    }
                    else
                    {
                        Cancelado = true;
                    }
                }
                else
                {
                    Cancelado = true;
                    Helper.CheckRequered(lista);
                }
            }
            if (Actualizando)
            {
                if (Controlacesso)
                {
                    if (Usracessos != null)
                    {
                        if (Usracessos.Altera)
                        {
                            SaveData(lista);
                        }
                        else
                        {
                            MsBox.Show("Não tem permissão para alterar. Contacte o administrador!");
                        }
                    }
                    else
                    {
                        MsBox.Show("Não tem permissão para alterar. Contacte o administrador!");
                    }
                }
                else
                {
                    SaveData(lista);
                }
            }

            if (!Cancelado)
            {
                EstadoDaTela(AccaoNaTela.Padrao);
                HabilitaCampo();
            }
            Cancelado = false;

        }

        void SaveData(List<Control> lista)
        {
            if (lista.Count == 0)
            {
                if (BeforeSave())
                {
                    Save();
                    OnGravaFilhas();
                    if (!Cancelado)
                    {
                        AfterSave();
                        Lista = new List<string>();
                        Helper.Alert("Actualizado com sucesso", Form_Alert.EnmType.Success);
                    }
                    else
                    {
                        Helper.Alert("Operação cancelada", Form_Alert.EnmType.Error);
                    }
                }
                else
                {
                    Cancelado = true;
                    Helper.Alert("Operação cancelada", Form_Alert.EnmType.Error);
                }
            }
            else
            {
                Cancelado = true;
                Helper.CheckRequered(lista);
            }
        }
        public virtual void AfterSave()
        {

        }
        public virtual void ClearDataGridView()
        {
            var c3 = Helper.GetAll(this, typeof(GridUi)).ToList();
            if (c3.Count > 0)
            {
                foreach (var rg in c3)
                {
                    if (((GridUi)rg).GridFilha)
                    {
                        var dt = ((GridUi)rg).DataSource as DataTable;
                        if (dt != null && dt.Rows.Count > 0)
                        {
                            dt.Rows.Clear();
                        }
                        ((GridUi)rg).DataSource = null;
                        ((GridUi)rg).DataSource = dt;
                    }
                }
                c3.Clear();
            }

            var c4 = Helper.GetAll(this, typeof(GridUIFt)).ToList();
            if (c4.Count > 0)
            {
                foreach (var rg in c4)
                {
                    var dt = ((GridUIFt)rg).DataSource as DataTable;
                    if (dt?.Rows.Count > 0)
                    {
                        dt.Rows.Clear();
                    }

                    ((GridUIFt)rg).DataSource = null;
                    ((GridUIFt)rg).DataSource = dt;
                }

                c4.Clear();
            }
            var c5 = Helper.GetAll(this, typeof(GridFormasP)).ToList();
            if (c5.Count <= 0) return;
            foreach (var rg in c5)
            {
                var dt = ((GridFormasP)rg).Grelha.DataSource as DataTable;
                if (dt?.Rows.Count > 0)
                {
                    dt.Rows.Clear();
                }

                ((GridFormasP)rg).Grelha.DataSource = null;
                ((GridFormasP)rg).Grelha.DataSource = dt;
            }
            c5.Clear();
        }

        public virtual void btnDelete_Click(object sender, EventArgs e)
        {
            if (Ctabela == string.Empty) return;
            if (!GravarNovo)
            {
                if (Controlacesso)
                {
                    if (Usracessos.Apaga)
                    {
                        Del();
                    }
                    else
                    {
                        MsBox.Show("Não tem permissão. Contacte o administrador!");
                    }
                }
                else
                {
                    Del();
                }
            }
            else
            {
                Helper.Alert("Não é possivel eliminar o registo ainda não foi gravado", Form_Alert.EnmType.Error);
            }
        }

        private void Del()
        {
            var res = MsBox.Show("Deseja Eliminar o Registo ?", DResult.YesNo);
            if (res.DialogResult != DialogResult.Yes) return;
            if (!CheckDelete()) return;
            Apagar();
            OnAfterDelete();
            CLocalStamp = string.Empty;
            EstadoDaTela(AccaoNaTela.Padrao);
        }

        public virtual bool CheckDelete()
        {
            return true;
        }



        #endregion

        #region Reseta as Propriedades quando estiver a fechar os formularios ...............
        public virtual void FrmClasse_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (EditMode)
            {

                if (Lista?.Count > 0)
                {
                    VerificarLista();
                }
                if (!Inserindo) return;
                MsBox.Show(Messagem.ParteInicial() + @"Está em modo de edição. Guarde ou Cancela.");
                e.Cancel = true;

            }
            else
            {
                Procurou = false;
                GravarNovo = false;
                Gravando = false;
                Cancelando = false;
                Inserindo = false;
                Actualizando = false;
                EditMode = false;
                var form = Application.OpenForms["Proc2"];
                form?.Dispose();
            }

            //Procurou = false;
            //    GravarNovo = false;
            //    Gravando = false;
            //    Cancelando = false;
            //    Inserindo = false;
            //    Actualizando = false;
            //    EditMode = false;

            //    var form = Application.OpenForms["Proc2"];
            //    form?.Dispose();
        }

        #endregion

        #region Método que controla Accão do Formúlario
        public virtual void EstadoDaTela(AccaoNaTela acaoNaTela)
        {
            switch (acaoNaTela)
            {
                case AccaoNaTela.Inserir:

                    btnPrev.Enabled = false;
                    btnNext.Enabled = false;
                    btnDelete.Enabled = true;
                    btnGravar.Enabled = true;
                    btnGravar.BackColor = Color.DarkCyan;
                    btnGravar.Image = Properties.Resources.Save_25_Lightpx;
                    btnNovo.Image = Properties.Resources.Undo_25px;
                    GravarNovo = true;
                    Gravando = true;
                    Cancelando = true;
                    Inserindo = true;
                    Actualizando = false;
                    EditMode = true;
                    Procurou = false;
                    LimparCampos2();
                    DefaultValues();
                    HabilitaCampo();
                    RemoveHighlight();
                    Refresh();
                    break;
                case AccaoNaTela.Alterar:
                    HabilitaCampo();
                    btnPrev.Enabled = true;
                    btnNext.Enabled = true;
                    btnDelete.Enabled = true;
                    btnGravar.Enabled = true;
                    btnGravar.BackColor = Color.DarkCyan;
                    btnGravar.Image = Properties.Resources.Save_25_Lightpx;
                    GravarNovo = false;
                    // btnNovo.Image = Properties.Resources.Undo_25px;
                    Gravando = false;
                    Cancelando = true;
                    Inserindo = false;
                    Actualizando = true;
                    EditMode = true;
                    break;
                case AccaoNaTela.Consultar:
                    EstadoDaTela(AccaoNaTela.Padrao);
                    break;
                case AccaoNaTela.Padrao:
                    RemoveHighlight();
                    //DesabilitaCampo();

                    btnPrev.Enabled = true;
                    btnNext.Enabled = true;
                    btnNovo.Enabled = true;
                    btnNovo.Image = Properties.Resources.Create_New_25px_1;
                    btnGravar.Image = Properties.Resources.Save_as_25px_2;
                    btnDelete.Enabled = true;
                    btnGravar.Enabled = true;
                    btnGravar.BackColor = Color.FromArgb(34, 39, 49);
                    GravarNovo = false;
                    Gravando = false;
                    Cancelando = false;
                    Inserindo = false;
                    Actualizando = false;
                    EditMode = false;
                    Refresh();
                    break;
            }
        }
        private void RemoveHighlight()
        {
            var lista = Helper.CamposObrigatorios(this);
            if (lista.Count <= 0) return;
            foreach (var it in lista)
            {
                switch (it)
                {
                    case TbDefault @default:
                        @default.ExecutaHighLigth(true);
                        break;
                    case Procura procura:
                        procura.ExecutaHighLigth(true);
                        break;
                }
            }
        }

        #endregion       
        #region Regiao de inicializacao de Métodos ou Virtuais ...........

        public virtual void Save()
        {

        }

        public decimal Numdoc { get; set; }

        public virtual void Cancelar()
        {

        }

        public virtual void Addline(string referenc)
        {

        }
        public virtual void AddLinha(string referenc)
        {

        }
        public virtual void AddLinhap(string referenc)
        {

        }
        public virtual void PreencheCampos(DataTable dt, int indice)
        {
            AfterPreencheCampos();
        }

        public virtual void AfterPreencheCampos()
        {

        }
        public virtual void DefaultValues()
        {
            var c = (TbDefault)Helper.GetAll(this, typeof(TbDefault)).FirstOrDefault(x => ((TbDefault)x).AutoIncrimento.Equals(true));
            var campo = c?.Value;
            if (!string.IsNullOrEmpty(campo))
            {
                CSequenc = campo;
            }
            if (string.IsNullOrEmpty(CSequenc)) return;
            var desc = SQL.Maximo(Ctabela, CSequenc, CCondicao).ToString(CultureInfo.InvariantCulture);
            c?.SetIncrimento(desc);
            var c2 = (Procura)Helper.GetAll(this, typeof(Procura)).FirstOrDefault(x => ((Procura)x).CampoStatus.Equals(true));
            c2?.SetStatus();

            var dtp = Helper.GetAll(this, typeof(DtDefault));
            foreach (var cc in dtp.AsEnumerable())
            {
                if (cc == null) continue;
                ((DtDefault)cc).dt1.Value = Pbl.SqlDate;
            }

        }

        public virtual bool BeforeDelete()
        {


            return true;
        }

        public virtual void Apagar()
        {
            if (!BeforeDelete()) return;
            var retorno = SQL.Apagar(Ctabela, CLocalStamp);
            LimparCampos2();
            ClearDataGridView();
            if (retorno > 0)
            {
                OnAfterDelete();
            }
            if (retorno > 0)
            {
                Helper.Alert("Registo eliminado definitivamente", Form_Alert.EnmType.Success);
            }
            else
            {
                Helper.Alert("Registo não eliminado!", Form_Alert.EnmType.Error);
            }
        }
        public void DesabilitaCampo()
        {
            var lista = Helper.GetAll(this, typeof(TbDefault)).ToList();
            if (lista.Count > 0)
            {
                foreach (var l in lista)
                {
                    if (l == null) return;
                    ((TbDefault)l).tb1.ReadOnly = true;
                }
                lista.Clear();
            }
            var lista2 = Helper.GetAll(this, typeof(CbDefault)).ToList();
            if (lista2.Count > 0)
            {
                foreach (var l in lista2)
                {
                    if (l == null) return;
                    ((CbDefault)l).Enabled = false;
                }
                lista2.Clear();
            }
            lista = Helper.GetAll(this, typeof(Procura)).ToList();
            if (lista.Count > 0)
            {
                foreach (var l in lista)
                {
                    if (l == null) return;
                    ((Procura)l).tb1.ReadOnly = true;
                }
                lista.Clear();
            }
        }

        public void HabilitaCampo()
        {

            var lista = Helper.GetAll(this, typeof(TbDefault)).ToList();
            if (lista.Count > 0)
            {
                foreach (var l in lista)
                {
                    if (l == null) return;
                    ((TbDefault)l).tb1.ReadOnly = ((TbDefault)l).IsReadOnly;
                }
                lista.Clear();
            }
            var lista3 = Helper.GetAll(this, typeof(Procura)).ToList();
            if (lista3.Count > 0)
            {
                foreach (var l in lista3)
                {
                    if (l == null) return;
                    if (((Procura)l).EnableTb1Field)
                    {
                        ((Procura)l).EnableTb1();
                    }
                }
                lista.Clear();
            }
            var lista2 = Helper.GetAll(this, typeof(CbDefault)).ToList();
            if (lista2.Count > 0)
            {
                foreach (var l in lista2)
                {
                    if (l == null) return;
                    ((CbDefault)l).Enabled = true;
                }
                lista2.Clear();
            }

        }
        #endregion
        public T DoAddline<T>() where T : class, new()
        {
            var t = new T();
            var nomeClasse = typeof(T).Name;
            var lista = SQL.GetGenDT(" INFORMATION_SCHEMA.COLUMNS ",
                $" WHERE table_name = '{nomeClasse.Trim()}' and IS_NULLABLE='YES' ", " column_name ");
            var properties = typeof(T).GetProperties();
            foreach (var p in properties)
            {
                if (p.PropertyType == typeof(string))
                {
                    if (!Ctabela.IsNullOrEmpty())
                    {
                        if (p.Name.Trim().ToLower().Contains("stamp") && p.Name.Trim().ToLower().Contains(Ctabela.ToLower().Trim()))
                        {
                            CLocalStamp = Pbl.Stamp();
                            PrimaryKeyName = p.Name.Trim();
                            p.SetValue(t, CLocalStamp);
                        }
                    }
                    if (p.Name == "qmc")
                    {
                        p.SetValue(t, Pbl.Usr.Usrstamp);
                    }
                    if (lista.Rows.Count > 0)
                    {
                        var r = lista.AsEnumerable().FirstOrDefault(x => x.Field<string>("column_name").Equals(p.Name));
                        if (r != null)
                        {
                            if (p.Name != "qmc")
                            {
                                p.SetValue(t, null);
                            }
                        }
                    }
                }
                if (p.PropertyType == typeof(DateTime))
                {
                    p.SetValue(t, new DateTime(1900, 1, 1));
                }
                if (p.Name == "qmadathora")
                {
                    p.SetValue(t, new DateTime(1900, 1, 1));
                }
                if (p.Name == "qmcdathora")
                {
                    p.SetValue(t, Pbl.SqlDate);
                }
            }
            return t;
        }
        public string PrimaryKeyName { get; set; }
        public DataRow curRow { get; set; }
        public string Campo1Capition { get; set; } = "Código";
        public string Campo2Capition { get; set; } = "Descrição";
        public string OrderByCampos { get; set; } = "";

        public T FillEntity<T>(T entity) where T : class
        {
            var controls = Helper.GetAll(this, typeof(TbDefault)).ToList();
            var dtp = Helper.GetAll(this, typeof(DtDefault)).ToList();
            controls.AddRange(dtp);
            var pr = Helper.GetAll(this, typeof(Procura)).ToList();
            controls.AddRange(pr);
            var cb = Helper.GetAll(this, typeof(CbDefault)).ToList();
            controls.AddRange(cb);
            var num = Helper.GetAll(this, typeof(DMZNumero)).ToList();
            controls.AddRange(num);
            var imgGroup = Helper.GetAll(this, typeof(ImgGroup)).ToList();
            controls.AddRange(imgGroup);
            var optgroup = Helper.GetAll(this, typeof(DmzOptionGroup)).ToList();
            controls.AddRange(optgroup);
            foreach (var ctrl in controls)
            {
                switch (ctrl)
                {
                    case DmzOptionGroup opt:
                        {
                            if (opt.Value != null)
                            {
                                var vl = opt.Bind();
                                var p = Utilities.GetProperty(opt.Value, entity);
                                Utilities.BindValue(entity, p, vl);
                            }

                            break;
                        }
                    case TbDefault tb:
                        {
                            if (!tb.Value.IsNullOrEmpty())
                            {
                                var p = Utilities.GetProperty(tb.Value, entity);
                                if (p != null)
                                {
                                    Utilities.BindValue(entity, p, tb.tb1.Text);
                                    if (!string.IsNullOrEmpty(tb.Value2))
                                    {
                                        var p2 = Utilities.GetProperty(tb.Value2, entity);
                                        if (p2 != null)
                                        {
                                            Utilities.BindValue(entity, p2, tb.Text2);
                                        }
                                    }
                                    if (!string.IsNullOrEmpty(tb.Value3))
                                    {
                                        var p3 = Utilities.GetProperty(tb.Value3, entity);
                                        if (p3 != null)
                                        {
                                            Utilities.BindValue(entity, p3, tb.Text3);
                                        }
                                    }
                                    if (!string.IsNullOrEmpty(tb.Value4))
                                    {
                                        var p4 = Utilities.GetProperty(tb.Value4, entity);
                                        if (p4 != null)
                                        {
                                            Utilities.BindValue(entity, p4, tb.Text4);
                                        }
                                    }
                                }
                            }
                            break;
                        }

                    case DMZNumero nud:
                        {
                            if (!nud.Value.IsNullOrEmpty())
                            {
                                var p = Utilities.GetProperty(nud.Value, entity);
                                if (p != null)
                                {
                                    Utilities.BindValue(entity, p, nud.nud1.Value);
                                    if (!string.IsNullOrEmpty(nud.Value2))
                                    {
                                        var p2 = Utilities.GetProperty(nud.Value2, entity);
                                        if (p2 != null)
                                        {
                                            Utilities.BindValue(entity, p2, nud.Text2);
                                        }
                                    }
                                }
                            }
                            break;
                        }

                    case DtDefault dp:
                        {
                            if (!dp.Value.IsNullOrEmpty())
                            {
                                var p2 = Utilities.GetProperty(dp.Value, entity);
                                if (p2 != null)
                                {
                                    Utilities.BindValue(entity, p2, dp.dt1.Value);
                                }
                            }
                            break;
                        }
                    case Procura prx:
                        {

                            if (!prx.Value.IsNullOrEmpty())
                            {
                                var p = Utilities.GetProperty(prx.Value, entity);
                                Utilities.BindValue(entity, p, prx.tb1.Text);
                                if (!prx.Value2.IsNullOrEmpty())
                                {
                                    var p2 = Utilities.GetProperty(prx.Value2, entity);
                                    Utilities.BindValue(entity, p2, prx.Text2);
                                }
                                if (!prx.Value3.IsNullOrEmpty())
                                {
                                    var p3 = Utilities.GetProperty(prx.Value3, entity);
                                    Utilities.BindValue(entity, p3, prx.Text3);
                                }
                                if (!prx.Value4.IsNullOrEmpty())
                                {
                                    var p4 = Utilities.GetProperty(prx.Value4, entity);
                                    Utilities.BindValue(entity, p4, prx.Text4);
                                }
                                if (!prx.Value5.IsNullOrEmpty())
                                {
                                    var p5 = Utilities.GetProperty(prx.Value5, entity);
                                    Utilities.BindValue(entity, p5, prx.Text5);
                                }
                                if (!prx.Value6.IsNullOrEmpty())
                                {
                                    var p6 = Utilities.GetProperty(prx.Value6, entity);
                                    Utilities.BindValue(entity, p6, prx.Text6);
                                }
                            }
                            break;
                        }
                    case CbDefault default3:
                        {
                            if (!(default3.Parent is DmzOptionGroup))
                            {
                                var cbx = default3;
                                if (!cbx.Value.IsNullOrEmpty())
                                {
                                    var p = Utilities.GetProperty(cbx.Value, entity);
                                    if (p != null)
                                    {
                                        Utilities.BindValue(entity, p, cbx.cb1.Checked);
                                    }
                                }
                            }
                            break;
                        }

                    case ImgGroup img:
                        {
                            if (img.Value != null)
                            {
                                var p = Utilities.GetProperty(img.Value, entity);
                                var imgemArray = Util.GetImagem(img.pictureBox1.Image, img.SetWhitePicture);
                                Utilities.BindValue(entity, p, imgemArray);
                            }
                            break;
                        }
                }
            }
            return entity;
        }

        public T FillControls<T>(T entity, DataTable dt, int i, bool filled = false) where T : class, new()
        {
            if (dt?.Rows.Count == 0)
            {
                return null;
            }
            if (!filled)
            {
                var lista = dt.DtToList<T>();
                entity = lista[i];
            }
            if (entity == null)
            {
                return entity;
            }
            var controls = Helper.GetAll(this, typeof(TbDefault)).ToList();
            var dtp = Helper.GetAll(this, typeof(DtDefault)).ToList();
            controls.AddRange(dtp);
            var pr = Helper.GetAll(this, typeof(Procura)).ToList();
            controls.AddRange(pr);
            var cb = Helper.GetAll(this, typeof(CbDefault)).ToList();
            controls.AddRange(cb);
            var nud = Helper.GetAll(this, typeof(DMZNumero)).ToList();
            controls.AddRange(nud);
            var imgGroup = Helper.GetAll(this, typeof(ImgGroup)).ToList();
            controls.AddRange(imgGroup);
            var dmzOptionGroup = Helper.GetAll(this, typeof(DmzOptionGroup)).ToList();
            controls.AddRange(dmzOptionGroup);
            foreach (var ctrl in controls)
            {
                switch (ctrl)
                {
                    case DmzOptionGroup opt:
                        {
                            opt.ClearAllValue();
                            if (opt.Value != null)
                            {
                                var p = Utilities.GetProperty(opt.Value, entity);
                                if (p != null)
                                {
                                    opt.BindValue(p.GetValue(entity, null).ToString());
                                }
                            }
                            break;
                        }
                    case TbDefault tb:
                        {
                            if (!tb.Value.IsNullOrEmpty())
                            {
                                var p = Utilities.GetProperty(tb.Value, entity);
                                if (p != null)
                                {
                                    var valor = p.GetValue(entity, null);
                                    tb.tb1.Text = valor == null ? "" : valor.ToString();
                                    if (tb.IsNumeric)
                                    {
                                        tb.tb1.Text = tb.tb1.Text.SetMask();
                                    }
                                    if (!string.IsNullOrEmpty(tb.Value2))
                                    {
                                        var p2 = Utilities.GetProperty(tb.Value2, entity);
                                        var valor2 = p2.GetValue(entity, null);
                                        tb.Text2 = valor2 == null ? "" : valor2.ToString();
                                    }
                                }
                            }
                            break;
                        }

                    case DMZNumero num:
                        {
                            if (!num.Value.IsNullOrEmpty())
                            {
                                var p = Utilities.GetProperty(num.Value, entity);
                                if (p != null)
                                {
                                    var valor = p.GetValue(entity, null);
                                    num.nud1.Value = valor == null ? 0 : valor.ToDecimal();
                                    if (!string.IsNullOrEmpty(num.Value2))
                                    {
                                        var p2 = Utilities.GetProperty(num.Value2, entity);
                                        var valor2 = p2.GetValue(entity, null);
                                        num.Text2 = valor2 == null ? "" : valor2.ToString();
                                    }
                                }
                            }
                            break;
                        }
                    case DtDefault dp:
                        {
                            if (!dp.Value.IsNullOrEmpty())
                            {
                                var p2 = Utilities.GetProperty(dp.Value, entity);
                                if (p2 != null)
                                {
                                    var xx = p2.GetValue(entity, null).ToDateTimeValue();
                                    if (xx.Year > 1900)
                                    {
                                        dp.dt1.Value = p2.GetValue(entity, null).ToDateTimeValue();
                                    }

                                }

                            }
                            break;
                        }
                    case Procura prx:
                        {

                            if (prx.Value != null)
                            {
                                var p = Utilities.GetProperty(prx.Value, entity);
                                if (p != null)
                                {
                                    var valor = p.GetValue(entity, null);
                                    prx.tb1.Text = valor == null ? "" : valor.ToString();
                                }
                            }
                            if (!string.IsNullOrEmpty(prx.Value2))
                            {
                                var p2 = Utilities.GetProperty(prx.Value2, entity);
                                if (p2 != null)
                                {
                                    var valor = p2.GetValue(entity, null);
                                    prx.Text2 = valor == null ? "" : valor.ToString();
                                }
                            }
                            if (!string.IsNullOrEmpty(prx.Value3))
                            {
                                var p3 = Utilities.GetProperty(prx.Value3, entity);
                                if (p3 != null)
                                {
                                    var valor = p3.GetValue(entity, null);
                                    prx.Text3 = valor == null ? "" : valor.ToString();
                                }
                            }
                            if (!string.IsNullOrEmpty(prx.Value4))
                            {
                                var p4 = Utilities.GetProperty(prx.Value4, entity);
                                if (p4 != null)
                                {
                                    var valor = p4.GetValue(entity, null);
                                    prx.Text4 = valor == null ? "" : valor.ToString();
                                }
                            }
                            if (!string.IsNullOrEmpty(prx.Value5))
                            {
                                var p5 = Utilities.GetProperty(prx.Value5, entity);
                                if (p5 != null)
                                {
                                    var valor = p5.GetValue(entity, null);
                                    prx.Text5 = valor == null ? "" : valor.ToString();
                                }
                            }
                            if (!string.IsNullOrEmpty(prx.Value6))
                            {
                                var p6 = Utilities.GetProperty(prx.Value6, entity);
                                if (p6 != null)
                                {
                                    var valor = p6.GetValue(entity, null);
                                    prx.Text6 = valor == null ? "" : valor.ToString();
                                }
                            }
                            break;
                        }
                    case CbDefault default3:
                        {
                            if (!(default3.Parent is DmzOptionGroup))
                            {
                                var cbx = default3;
                                if (cbx.Value != null)
                                {
                                    var p = Utilities.GetProperty(cbx.Value, entity);
                                    if (p != null)
                                    {
                                        cbx.cb1.Checked = p.GetValue(entity, null).ToBool();
                                        cbx.btnCheck.Image = cbx.cb1.Checked ? Properties.Resources.Checked_Checkbox_2_23px : Properties.Resources.Unchecked_Checkbox_23px;
                                    }
                                }
                            }
                            break;
                        }

                    case ImgGroup img:
                        {
                            if (img.Value != null)
                            {
                                var p = Utilities.GetProperty(img.Value, entity);

                                if (p != null)
                                {
                                    if (p.GetValue(entity, null) != null)
                                    {
                                        //var array = Encoding.ASCII.GetBytes(valor.ToString());
                                        var imagem = Util.ByteToImage((byte[])p.GetValue(entity, null));
                                        img.pictureBox1.Image = imagem;
                                    }
                                    else
                                    {
                                        img.pictureBox1.Image = null;
                                    }
                                }
                            }
                            break;
                        }
                }
            }
            var prop = entity.GetType().GetProperties().FirstOrDefault(xx =>
                xx.Name.ToLower().Contains("stamp"));
            if (prop != null)
            {
                CLocalStamp = prop.GetValue(entity, null).ToString();
            }
            BindGrids();
            EstadoDaTela(AccaoNaTela.Alterar);
            Lista = new List<string>();
            return entity;
        }


        public static T GetInstance<T>(T f) where T : class, new() => f ?? new T();


        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownEvent();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }

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
        public void Maximizar()
        {
            NSize = Size;
            NLocation = Location;
            var height = MdiParent.Size.Height;
            var width = MdiParent.Size.Width;
            int widthMenupanel = 0;
            if (MdiParent is DemoMdi)
            {
                widthMenupanel = ((DemoMdi)MdiParent).PanelSideMenu.Size.Width;
            }
            if (widthMenupanel == 40)
            {
                Size = new Size(width - 50, height - 165);
                Location = new Point(MdiParent.Location.X + 45, Location.Y);
            }
            else
            {
                Size = new Size(width - 175, height - 165);
                Location = new Point(MdiParent.Location.X + 175, Location.Y);
            }
            Maximizado = true;
        }

        public void MoveUp()
        {
            NSize = Size;
            NLocation = Location;
            var height = MdiParent.Size.Height;
            var width = MdiParent.Size.Width;
            Size = new Size(width - 70, height - 165);
            var y = MdiParent.Location.Y;
            Location = new Point(48, y + 110);
        }
        public void MoveDow()
        {
            Size = NSize;
            Location = NLocation;
        }
        public void Minimizar()
        {
            Size = NSize;
            Location = NLocation;
            Maximizado = false;
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            Maximizado = false;
            if (MdiParent.Name == "DemoMdi")
            {
                ((DemoMdi)MdiParent).flowLayoutPanel1.Controls.Add(new DmzMinimize { FormName = Name, FormText = label1.Text, Name = Name });
            }
        }

        private void FrmClasse_FormClosed(object sender, FormClosedEventArgs e)
        {
            var lista = Application.OpenForms;
            if (lista.Count < 3)
            {
                if (MdiParent is DemoMdi)
                {
                    ((DemoMdi)MdiParent).panelDashBoard.Visible = true;
                }
            }


        }

        private void FrmClasse_MouseDown(object sender, MouseEventArgs e)
        {
            // flag = true;
            MouseDownEvent();
        }

        private void FrmClasse_MouseMove(object sender, MouseEventArgs e)
        {

            // if (flag) Location = Cursor.Position;
        }

        private void FrmClasse_MouseUp(object sender, MouseEventArgs e)
        {
            //flag = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            panelMessageShow.Visible = true;
            progressBar1.Value += 1;
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar1.Value -= 1;
            if (progressBar1.Value == 0)
            {
                panelMessageShow.Visible = false;
                timer2.Stop();
            }
        }

        private void panelMessageShow_Paint(object sender, PaintEventArgs e)
        {
            //var btnPath = new GraphicsPath();
            //var rect = panelMessageShow.ClientRectangle;
            //rect.Inflate(0, 15);
            //btnPath.AddEllipse(rect);
            //panelMessageShow.Region = new Region(btnPath);
        }

        public virtual List<string> GetList()
        {
            return null;
        }

        public virtual void UpdateGrid(DataRow dr)
        {

        }

        public void btnRefresh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CLocalStamp)) return;
            if (string.IsNullOrEmpty(PrimaryKeyName))
            {
                PrimaryKeyName = Ctabela.Trim() + "stamp";
            }
            var dt = SQL.GetDT(Ctabela, "*", $"{PrimaryKeyName}='{CLocalStamp.Trim()}'", null);
            PreencheCampos(dt, 0);
            //OnActualizFilhas(CLocalStamp);
            //Text = label1.Text;
            BindGrids();
            AfterPreencheCampos();
        }
    }


    [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
    public class FrmControlDesigner : ControlDesigner
    {
        private DesignerActionListCollection _actionLists;

        // Use pull model to populate smart tag menu.
        public override DesignerActionListCollection ActionLists
        {
            get
            {
                if (null == _actionLists)
                {
                    _actionLists = new DesignerActionListCollection { new FrmControlActionList(Component) };
                }
                return _actionLists;
            }
        }
    }
    public class FrmControlActionList : DesignerActionList
    {
        private FrmClasse colUserControl;

        private DesignerActionUIService _designerActionUiSvc;

        //The constructor associates the control with the smart tag list.
        public FrmControlActionList(IComponent component) : base(component)
        {
            colUserControl = component as FrmClasse;
            // Cache a reference to DesignerActionUIService, so the DesigneractionList can be refreshed.
            _designerActionUiSvc = GetService(typeof(DesignerActionUIService)) as DesignerActionUIService;
        }

        // Helper method to retrieve control properties. Use of GetProperties enables undo and menu updates to work properly.
        private PropertyDescriptor GetPropertyByName(string propName)
        {
            PropertyDescriptor prop;
            prop = TypeDescriptor.GetProperties(colUserControl)[propName];
            if (null == prop)
                throw new ArgumentException("Matching ColorLabel property not found!", propName);
            else
                return prop;
        }

        // Properties that are targets of DesignerActionPropertyItem entries.
        //public Color BackColor
        //{
        //    get => colUserControl;
        //    set => GetPropertyByName("TextBoxBackColor").SetValue(colUserControl, value);
        //}

        //public Color ForeColor
        //{
        //    get => colUserControl.TextBoxForeColor;
        //    set => GetPropertyByName("TextBoxForeColor").SetValue(colUserControl, value);
        //}
        public bool Controlacesso
        {
            get => colUserControl.Controlacesso;
            set => GetPropertyByName("Controlacesso").SetValue(colUserControl, value);
        }
        //public string Value2
        //{
        //    get => colUserControl.Value2;
        //    set => GetPropertyByName("Value2").SetValue(colUserControl, value);
        //}
        [EditorAttribute(typeof(MultilineStringEditor), typeof(UITypeEditor))]
        public string Label1Text
        {
            get => colUserControl.label1.Text;
            set => GetPropertyByName("Label1Text").SetValue(colUserControl, value);
        }
        //public Color label1ForeColor
        //{
        //    get => colUserControl.label1ForeColor;
        //    set => GetPropertyByName("label1ForeColor").SetValue(colUserControl, value);
        //}
        //public AnchorStyles Anchor
        //{
        //    get => colUserControl.Anchor;
        //    set => GetPropertyByName("Anchor").SetValue(colUserControl, value);
        //}
        public string Name
        {
            get => colUserControl.Name;
            set => GetPropertyByName("Name").SetValue(colUserControl, value);
        }
        // Implementation of this abstract method creates smart tag  items, associates their targets, and collects into list.
        public override DesignerActionItemCollection GetSortedActionItems()
        {
            var items = new DesignerActionItemCollection
            {
                new DesignerActionHeaderItem("Appearance"),
                //new DesignerActionPropertyItem("BackColor", "Back Color", "Appearance",
                //    "Selects the background color."),
                //new DesignerActionPropertyItem("ForeColor", "Fore Color", "Appearance",
                //    "Selects the foreground color."),
                //new DesignerActionPropertyItem("Value", "Value", "Appearance",
                //    "SQL Table Column - Table Link"),
                //new DesignerActionPropertyItem("Value2", "Value2", "Appearance",
                //"SQL Table Column - Table Link"),
                new DesignerActionPropertyItem("Label1Text", "Label Text", "Appearance",
                    "Label Text"),
                new DesignerActionPropertyItem("Controlacesso", "Controla Accessos", "Appearance",
                    "Controla Accessos"),
                //new DesignerActionPropertyItem("Anchor", "Anchor", "Appearance",
                //    "Anchor"),
                new DesignerActionPropertyItem("Name", "Nome", "Appearance",
                    "Nome")
            };
            //items.Add(new DesignerActionMethodItem(this,
            //    "Callform", "Set Value",
            //    "Appearance",
            //    "Set Property Value ",
            //    true));
            //items.Add(new DesignerActionMethodItem(this,
            //    "Callform", "Set Value2",
            //    "Appearance",
            //    "Set Property Value ",
            //    true));
            //Define static section header entries.

            return items;
        }

        public void Callform()
        {
            var lista = new List<string>();
            if (colUserControl.ParentForm != null)
            {
                var props = ((FrmClasse)colUserControl.ParentForm).GetListProps().ToArray();
                foreach (var c in props)
                {
                    lista.Add(c.Name);
                }
                //lista.AddRange(props.Select(p => p.Name));
            }
            var f = new FrmCProperty { gridPreco = { DataSource = lista } };
            f.ShowDialog();
        }
    }
}
