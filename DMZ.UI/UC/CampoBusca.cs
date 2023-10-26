using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.UI;

namespace DMZ.UI.UC
{
    public partial class CampoBusca : UserControl
    {

        public delegate void Refrescar();

        public event Refrescar RefreshControls;
        //Cria um delegate
        public delegate void ExecCondicao();
        //Cria um evento
        public event ExecCondicao CondicaCampoBusca;
        #region Variaveis e Propriedades
        [Description(@"Tabela de busca de dado(s) para este campo")]
        public string Tabela { get; set; }
        [Description(@"O control source do campo..")]
        public string Value { get; set; }
        [Description(@"O primeriro campo/coluna a ser selecionada. Nota: Este propriedade é que vai conter o valor para a texBox deste campo.(Obrigatório)")]
        public string Campo1 { get; set; }
        [Description(@"O Segundo campo/coluna a ser selecionada (Opcional)")]
        public string Campo2 { get; set; }
        [Description(@"A Terceira campo/coluna a ser selecionada (Opcional)")]
        public string Campo3 { get; set; }
        [Description(@"O Quarto campo/coluna a ser selecionada (Opcional).")]
        public string Campo4 { get; set; }
        [Description(@"A descricao/Caption para a primeira coluna (Opcional).")]
        public string Campo1Desc { get; set; } = string.Empty;
        [Description(@"A descricao/Caption para a segunda coluna (Opcional).")]
        public string Campo2Desc { get; set; } = string.Empty;
        [Description(@"A descricao/Caption para a terceira coluna (Opcional).")]
        public string Campo3Desc { get; set; } = string.Empty;
        [Description(@"A descricao/Caption para a Quarta coluna (Opcional).")]
        public string Campo4Desc { get; set; } = string.Empty;
        [Description(@"Indica se a segunda coluna será visivel ou não.")]
        public bool Campo2Visible { get; set; } = false;
        [Description(@"Indica se a terceira coluna será visivel ou não.")]
        public bool Campo3Visible { get; set; } = false;
        [Description(@"Indica se a Quarta coluna será visivel ou não.")]
        public bool Campo4Visible { get; set; } = false;
        [Description(@"Indica qual campo da tabela principal irá receber irá receber o valor do campo2 (Opcional).")]
        public string Campo2Update { get; set; } = string.Empty;
        [Description(@"Indica qual campo da tabela principal irá receber irá receber o valor do campo3 (Opcional).")]
        public string Campo3Update { get; set; } = string.Empty;
        [Description(@"Indica qual campo da tabela principal irá receber irá receber o valor do campo4 (Opcional).")]
        public string Campo4Update { get; set; } = string.Empty;
        [Description(@"O tamanho da primeira coluna na Grid de Pesquisa.")]
        public int Campo1Width { get; set; } = 0;
        [Description(@"O tamanho da segunda coluna na Grid de Pesquisa.")]
        public int Campo2Width { get; set; } = 60;
        [Description(@"O tamanho da Terceira coluna na Grid de Pesquisa.")]
        public int Campo3Width { get; set; } = 60;
        [Description(@"O tamanho da Quarta coluna na Grid de Pesquisa.")]
        public int Campo4Width { get; set; } = 0;
        [Description(@"Forma como campo1 Irá crescer ('Nenhuma' significa que vai obedecer o Campo1Width).")]
        public CampoAutoSizeMode Campo1AutoSizeMode { get; set; } = CampoAutoSizeMode.Completar;
        [Description(@"Forma como campo2 Irá crescer ('Nenhuma' significa que vai obedecer o Campo2Width).")]
        public CampoAutoSizeMode Campo2AutoSizeMode { get; set; } = CampoAutoSizeMode.CabeçalhoDaColuna;
        [Description(@"Forma como campo3 Irá crescer ('Nenhuma' significa que vai obedecer o Campo3Width).")]
        public CampoAutoSizeMode Campo3AutoSizeMode { get; set; } = CampoAutoSizeMode.Nenhuma;
        [Description(@"Forma como campo4 Irá crescer ('Nenhuma' significa que vai obedecer o Campo4Width).")]
        public CampoAutoSizeMode Campo4AutoSizeMode { get; set; } = CampoAutoSizeMode.Nenhuma;
        [Description(@"Campos de ordenacao. Se forem mais de um(1) separe por virgula.")]
        public string CamposOrderby { get; set; }
        [Description(@"A condicao de Pesquisa.")]
        public string Condicao { get; set; } = string.Empty;
        [Description(@"Parametro para Guardar valor da Coluna1 da Busca.")]
        public string xParam1 { get; set; } = string.Empty;
        [Description(@"Parametro para Guardar valor da Coluna2 da Busca.")]
        public string xParam2 { get; set; } = string.Empty;
        [Description(@"Parametro para Guardar valor da Coluna3 da Busca.")]
        public string xParam3 { get; set; } = string.Empty;
        [Description(@"Parametro para Guardar valor da Coluna4 da Busca.")]
        public string xParam4 { get; set; } = string.Empty;
        [Description(@"Se controla EditeMode. (Se está sobre o fromulário Classe)")]
        public bool _ControlaEditMode { get; set; } = true;
        public enum CampoAutoSizeMode
        {
            Nenhuma,
            Completar,
            CélulasExibidas,
            CabeçalhoDaColuna
        }

        [Description(@"O nome do Formúlário que será chamado para adicionar mais Itens.")]
        public string FormToCall { get; set; } = string.Empty;
        public frmFind Pp { get; set; }
        public string Titulo { get; set; }
        public bool IsLocaDs { get; set; }
        public string ParentFormName { get; set; }
        public string UpdateTextBox { get; set; }
        public bool TbCkUpdate { get; set; }
        [Description(@"Se depende de valor de um outro objecto..")]
        public bool Dependente { get; set; }
        [Description(@"Nome do objecto de qual depende..")]
        public string DependenteNome { get; set; }
        public string TbUpDate { get; set; }
        public string DependDescricao { get; set; }
        public bool AutoComplete { get; set; }
        [Description(@"Se é do tipo obrigatório..")]
        public bool IsRequered { get; set; }
        private Color corFundoPadrao { get; set; }

        public bool TbClear { get; set; }
        private readonly List<string> _items = new List<string>();
        private Form _myParent;

        [Browsable(true), DisplayName(@"LocalDs")]
        [Description("Lista de Dados locais")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Editor("System.Windows.Forms.Design.StringArrayEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public string[] ItemsArray
        {
            get
            {
                return _items.ToArray();
            }
            set
            {
                _items.Clear();
                if (value != null)
                {
                    _items.AddRange(value);
                }
                // TODO: other stuff
            }
        }
        [Description(@"Campo que filtra a busca no caso de ser dependente.")]
        public string CondCampo { get; set; }
        public bool ExecMetodo { get; set; }

        #endregion Declaraco de Variaveis e Propriedades
        public CampoBusca()
        {
            InitializeComponent();
        }

        protected virtual void OnCondicaCampoBusca()
        {
            var handler = CondicaCampoBusca;
            handler?.Invoke();
        }
        protected virtual void OnRefreshControls()
        {
            var handler = RefreshControls;
            handler?.Invoke();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (!IsLocaDs)
            {
                if (string.IsNullOrEmpty(Campo1))
                {
                    MessageBox.Show("Parametros de busca não definidos!", Pbl.Info, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }
            var index = 0;

            _myParent = ParentForm;

            if (_ControlaEditMode)
            { //Se Controla o EditeMode no formulário..

                bool editeMode;
                try
                {
                    editeMode = _myParent != null && ((FrmClasse)_myParent).EditMode;
                }
                catch (Exception)
                {

                    editeMode = _myParent != null && ((FrmClasse)_myParent).EditMode;
                }

                if (!editeMode) return;
            }



            if (Dependente)
            {
                var c = Helper.GetAll(_myParent, typeof(CampoBusca)).FirstOrDefault(x => x.Name.Equals(DependenteNome));
                var procura = (CampoBusca)c;
                var textBoxX = procura?.tb1;
                if (textBoxX == null) return;
                TextBox tb = textBoxX;
                if (string.IsNullOrEmpty(tb.Text))
                {
                    MessageBox.Show($"Por favor preencha o campo {DependDescricao} primeiro! ", Pbl.Info, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    Condicao = string.IsNullOrEmpty(procura.tb1.Text) ? $"{CondCampo}={0}" : $"{CondCampo}='{procura.tb1.Text}'";

                    GetValue(index);
                }
            }
            else
            {
                GetValue(index);
            }
        }

        private void GetValue(int index)
        {
            OnCondicaCampoBusca();

            Pp = new frmFind();
            Pp.Tabela = Tabela;
            Pp.condicao = Condicao;
            Pp.campo1 = Campo1;
            Pp.campo2 = Campo2;
            Pp.campo3 = Campo3;
            Pp.campo4 = Campo4;
            Pp.campo1Desc = Campo1Desc;
            Pp.campo2Desc = Campo2Desc;
            Pp.campo3Desc = Campo3Desc;
            Pp.campo4Desc = Campo4Desc;
            Pp.campo2Visible = Campo2Visible;
            Pp.campo3Visible = Campo3Visible;
            Pp.campo4Visible = Campo4Visible;
            Pp.campo2Update = Campo2Update;
            Pp.campo3Update = Campo3Update;
            Pp.campo4Update = Campo4Update;
            Pp.campo1Width = Campo1Width;
            Pp.campo2Width = Campo2Width;
            Pp.campo3Width = Campo3Width;
            Pp.campo4Width = Campo4Width;
            Pp.campo1AutoSizeMode = Campo1AutoSizeMode;
            Pp.campo2AutoSizeMode = Campo2AutoSizeMode;
            Pp.campo3AutoSizeMode = Campo3AutoSizeMode;
            Pp.campo4AutoSizeMode = Campo4AutoSizeMode;
            Pp.camposOrderby = CamposOrderby;

            //Pp.MdiParent = _myParent.MdiParent;
            // Pp.StartPosition = FormStartPosition.Manual;
            // Pp.Location = new Point(450, 120);
            Pp.formToCall = FormToCall;
            Pp.PControl = PassData;
            Pp.ShowDialog();
        }

        private void PassData(object sender)
        {
            var rowSelected = ((DataRow)sender);


            if (_ControlaEditMode)
            { //Para formulários que controlam Edimote

                var frmCurRow =((FrmClasse)_myParent).curRow;

                if (!string.IsNullOrWhiteSpace(Campo1))
                {
                    if (frmCurRow[Value] != null)
                        frmCurRow[Value] = rowSelected[0];

                    tb1.Text = rowSelected[0].ToString();
                }

                if (!string.IsNullOrWhiteSpace(Campo2) && !string.IsNullOrWhiteSpace(Campo2Update))
                {

                    if (frmCurRow[Campo2Update] != null)
                        frmCurRow[Campo2Update] = rowSelected[1];

                    var lista = Helper.GetAll(_myParent, typeof(TbDefault)).ToList();
                    if (lista.Count > 0)
                    {
                        foreach (var l in lista)
                        {
                            if (l == null) return;
                            if (((TbDefault)l).Value == null) return;
                            if (((TbDefault)l).Value.Equals(Campo2Update))
                                ((TbDefault)l).tb1.Text = rowSelected[1].ToString();
                        }
                        lista.Clear();
                    }
                }

                if (!string.IsNullOrWhiteSpace(Campo3) && !string.IsNullOrWhiteSpace(Campo3Update))
                {

                    if (frmCurRow[Campo3Update] != null)
                        frmCurRow[Campo3Update] = rowSelected[2];

                    var lista = Helper.GetAll(_myParent, typeof(TbDefault)).ToList();
                    if (lista.Count > 0)
                    {
                        foreach (var l in lista)
                        {
                            if (l == null) return;
                            if (((TbDefault)l).Value == null) return;
                            if (((TbDefault)l).Value.Equals(Campo3Update))
                                ((TbDefault)l).tb1.Text = rowSelected[2].ToString();
                        }
                        lista.Clear();
                    }
                }

                if (!string.IsNullOrWhiteSpace(Campo4) && !string.IsNullOrWhiteSpace(Campo4Update))
                {

                    if (frmCurRow[Campo4Update] != null)
                        frmCurRow[Campo4Update] = rowSelected[3];

                    var lista = Helper.GetAll(_myParent, typeof(TbDefault)).ToList();
                    if (lista.Count > 0)
                    {
                        foreach (var l in lista)
                        {
                            if (l == null) return;
                            if (((TbDefault)l).Value == null) return;
                            if (((TbDefault)l).Value.Equals(Campo4Update))
                                ((TbDefault)l).tb1.Text = rowSelected[3].ToString();
                        }
                        lista.Clear();
                    }
                }
            }
            else
            {// Para formulários que nao controlam edtimode (formularios que nao Herdaram do FrmCalsse)

                tb1.Text = rowSelected[0].ToString();
                xParam1 = rowSelected[0].ToString();

                if (!string.IsNullOrWhiteSpace(Campo2))
                    xParam2 = rowSelected[1].ToString();
            }


            if (ExecMetodo)
            {
                _myParent.GetType().InvokeMember("MaisMetodo", BindingFlags.InvokeMethod, null, _myParent, null);
            }
            OnRefreshControls();
        }

        public void ExecutaHighLigth()
        {
            if (string.IsNullOrEmpty(tb1.Text))
            {
                BackColor = Color.Red;
            }
            else
            {
                BackColor = corFundoPadrao;
            }
        }

        internal void RemoveHighLigth()
        {
            BackColor = corFundoPadrao;
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb1.Text))
                BackColor = corFundoPadrao;
        }
       
        private static bool CheckOpened(string name)
        {
            var fc = Application.OpenForms;
            return fc.Cast<Form>().Any(frm => frm.Name == name);
        }
        public Form ItsOpen(string frmname)
        {
            Form open = null;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name.Equals(frmname))
                {
                    MessageBox.Show("Ja esta aberto");
                    open = frm;
                    break;
                }
            }
            return open;
        }
        private void CampoBusca_Load(object sender, EventArgs e)
        {
            corFundoPadrao = BackColor;
        }
    }
}
