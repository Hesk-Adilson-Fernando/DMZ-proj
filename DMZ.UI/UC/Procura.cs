using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using DMZ.BL.Classes;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using DMZ.UI.Properties;
using static System.String;

namespace DMZ.UI.UC
{
    [Designer(typeof(ProcuraControlDesigner))]
    public partial class Procura : UserControl
    {
        public Procura()
        {
            InitializeComponent();
        }
        public Font Font
        {
            get => tb1.Font;
            set => tb1.Font = value;
        }
        public DataTable SqlDt;

        //Cria um delegate
        public delegate void GetData();
        //Cria um evento
        public event GetData GetDataEvent;

        public delegate void Refrescar();

        public event Refrescar RefreshControls;
        //Cria um delegate
        public delegate void ExecCondicao();
        //Cria um evento
        public event ExecCondicao CondicaProcura;

        //public event 
        protected virtual void OnCondicaProcura()
        {
            var handler = CondicaProcura;
            handler?.Invoke();
        }
        public virtual void OnRefreshControls()
        {
            Pp.Dispose();
            var handler = RefreshControls;
            handler?.Invoke();
        }
        public string Selecionado { get; set; }
        public string Tabela { get; set; }
        public string Value { get; set; }
        public string Value2 { get; set; }
        public string Value3 { get; set; }
        public string Value4{ get; set; }
        public string Value5 { get; set; }
        public string Value6 { get; set; }
        public string[] Values
        {
            get
            {
                return Text.Split(new string[] { Environment.NewLine },
                    StringSplitOptions.None);
            }
            set
            {
                if (value != null)
                    Text = Join(Environment.NewLine, value);
            }
        }
        //public List<string> Values { get; set; }
        public bool ShowThirdColumn { get; set; }
        public string Text2 { get; set; }
        public string Text3 { get; set; }
        public string Text6 { get; set; }
        public string Campo { get; set; }
        public string Campo1 { get; set; }
        public string Condicao { get; set; } =Empty;
        public Proc Pp { get; set; }
        private Proc2 P2 { get; set; }
        public string Titulo { get; set; }
        public bool IsLocaDs { get; set; }
        public string ParentFormName { get; set; }
        public string UpdateTextBox { get; set; }
        public bool TbCkUpdate { get; set; }
        public bool Dependente { get; set; }
        public string DependenteNome { get; set; }
        public string ColunaCodigo { get; set; }
        public string TbUpDate { get; set; }
        public string ColunaDescricao { get; set; }

        public string DependDescricao { get; set; }
        public bool AutoComplete { get; set; }
        public bool IsRequered { get; set; }
        public bool CampoStatus { get; set; }
        public bool TbClear { get; set; }
        private Form MyParent { get; set; }
        public AnchorStyles Label1Anchor
        {
            get => label1.Anchor;
            set => label1.Anchor = value;
        }
        [Editor(typeof(MultilineStringEditor),typeof(UITypeEditor))]
        public string Label1Text
        {
            get => label1.Text;
            set => label1.Text = value;
        }
        public bool EnableTb1Field { get; set; }
        public void EnableTb1()
        {
            if (!EnableTb1Field) return;
            tb1.Enabled = true;
            tb1.ReadOnly = false;
        }
        [Description("Muda a cor do fundo do textbox")]
        public Color TextBoxBackColor
        {
            get => tb1.BackColor;
            set => tb1.BackColor = value;
        }

        [Description("Muda a cor do texto do textbox")]
        public Color TextBoxForeColor
        {
            get => tb1.ForeColor;
            set => tb1.ForeColor = value;
        }
        public Color label1ForeColor
        {
            get => label1.ForeColor;
            set => label1.ForeColor = value;
        }
        public Font label1Font
        {
            get => label1.Font;
            set => label1.Font = value;
        }
        private Form __myParent;
        public bool IsUnique { get; set; }
        private void Procura_Load(object sender, EventArgs e)
        {
            Titulo = "Procurar";
            ColunaCodigo = "Código";
            ColunaDescricao = "Descrição";
            var p = ParentForm;
            if (p?.MdiParent == null) return;
            if (p.MdiParent.Name != "MdiCont") return;
            btnProcura2.Image = Resources.Procura_19px;
            button1.Image = Resources.Menu_Vertical_251px;
        }
        public void ExecutaHighLigth(bool origem = false)
        {

            tb1.BackColor = IsNullOrEmpty(tb1.Text) ? Color.Red : Color.White;
            if (origem)
            {
                tb1.BackColor =  Color.White; 
            }
        }
        public IEnumerable<Control> GetAll(Control control, Type type = null)
        {
            var controls = control.Controls.Cast<Control>();
            var enumerable = controls as IList<Control> ?? controls.ToList();
            return enumerable.SelectMany(ctrl => GetAll(ctrl, type)).Concat(enumerable).Where(c => c.GetType() == type);
        }
        public void SetStatus()
        {
            var dt = SQL.GetDT("status","codigo,descricao",null,null);
            if (dt.Rows.Count <= 0) return;
            tb1.Text = dt.Rows[0]["descricao"].ToString();
            Text2 = dt.Rows[0]["codigo"].ToString();
        }
        private void PassData(DataTable tab,DataTable dt)
        {
            if (InvertColuna)
            {
                Text2 = tab.RowZero("descricao").ToString();
                tb1.Text = tab.RowZero("codigo").ToString();
                Text3 = tab.RowZero("campo3").ToString();
                Text4 = tab.RowZero("campo4").ToString();
                Text5 = tab.RowZero("campo5").ToString();
                Text6 = tab.RowZero("campo6").ToString();
            }
            else
            {
                tb1.Text = tab.RowZero("descricao").ToString();
                Text2 = tab.RowZero("codigo").ToString();
                Text3 = tab.RowZero("campo3").ToString();
                Text4 = tab.RowZero("campo4").ToString();
                Text5 = tab.RowZero("campo5").ToString();
                Text6 = tab.RowZero("campo6").ToString();
            }
            if (TbCkUpdate)
            {
                if (TbUpDate!=null)
                {
                    var tbx = __myParent.Controls.Find(TbUpDate, true).FirstOrDefault() as TextBox;
                    if (tbx != null)
                    {
                        tbx.Text = InvertColuna ? tab.RowZero("descricao").ToString() : tab.RowZero("codigo").ToString();
                    }
                    var tbx2 = __myParent.Controls.Find(TbUpDate, true).FirstOrDefault() as TbDefault;
                    if (tbx2 != null)
                    {
                        tbx2.tb1.Text = InvertColuna ? tab.RowZero("descricao").ToString() : tab.RowZero("codigo").ToString();
                    }
                }
            }
            TmpFound = dt;
            OnRefreshControls();
        }

        public string Text4 { get; set; }
        public string Text5 { get;  set; }
        public bool ExecMetodo { get; set; }
        public bool Istatus  { get; set; }
        public bool HideFirstColumn { get; set; }
        public bool InvertColuna { get; set; }
        public List<string> Items { get; set; }
        public bool IsSqlSelect { get; set; }
        [Editor(typeof(MultilineStringEditor),typeof(UITypeEditor))]
        public string SqlComandText { get; set; }

        private void radLabel1_Click(object sender, EventArgs e)
        {            
            if (IsSqlSelect)
            {
                if (IsNullOrEmpty(SqlComandText))
                {
                    MsBox.Show("Parametros não definidos!..");
                }
            }
            //else if (Selecionado == "digitaSelect" || IsNullOrEmpty(Selecionado))
            //{
            //    MsBox.Show("Parametros não definidos!...");
            //    return;
            //}
            var index = 0;
            if (IsLocaDs)
            {
                if (IsNullOrEmpty(Selecionado) || IsNullOrEmpty(Tabela)) return;
                var numer =(from str in Selecionado where char.IsPunctuation(str) select str.ToString()).Where(
                        x => x.Equals(",")).ToList();
                index = numer.Count;
            }
            __myParent = ParentForm;
            bool editeMode;
            try
            {
                editeMode = __myParent != null && ((FrmClasse)__myParent).EditMode;
            }
            catch (Exception)
            {

                editeMode = __myParent != null && ((FrmClasse2)__myParent).EditMode;
            }

            if (!editeMode) return;

            if (Dependente)
            {
                var c = GetAll(__myParent, typeof(Procura)).FirstOrDefault(x => x.Name.Equals(DependenteNome));
                var procura = (Procura)c;
                if (procura == null) return;
                if (IsNullOrEmpty(procura.tb1.Text))
                {
                    MsBox.Show($"Por favor preenche o campo {procura.Label1Text} primeiro ");
                }
                else
                {
                    Condicao = !procura.Text2.IsString() ? $"{Campo}='{procura.Text2}'" : $"{Campo}={procura.Text2}";                   
                    GetValue();
                }
            }
            else
            {
                GetValue();
            }
        }


        private void GetValue()
        {
            OnCondicaProcura();
            string querry;
            querry = SqlComandText;
            if (IsSqlSelect || ExecMetodo)
            {
                if (!IsNullOrEmpty(Condicao))
                {
                    if (!SqlComandText.Contains("where"))
                    {
                        querry = $"{SqlComandText} where {Condicao}";  
                    }
                }
                if (IsSqlSelect)
                {
                    SqlDt = SQL.GetGenDT(querry);
                }
                else if(ExecMetodo)
                {
                    OnGetData();
                    IsSqlSelect=ExecMetodo;
                    if (SqlDt.HasRows())
                    {
                        MsBox.Show("Parametros não definidos!..");
                        return;
                    }
                }
                if (SqlDt.HasRows())
                {
                    var dr = SqlDt.NewRow();
                    SqlDt.Rows.InsertAt(dr, 0);
                    Pp = new Proc { Dt = SqlDt, label1 = { Text = "Procura por: " + label1.Text } };
                    var nCol = Pp.dgvProcura.Columns.Count;
                    for (var i = 1; i <= SqlDt.Columns.Count; i++)
                    {

                        if (nCol < i)
                        {
                            var col = new DataGridViewTextBoxColumn
                            {
                                Name = SqlDt.Columns[i - 1].ColumnName.Trim(),
                                DataPropertyName = SqlDt.Columns[i - 1].ColumnName.Trim(),
                                Visible = false
                            };
                            Pp.dgvProcura.Columns.Add(col);
                        }
                        else
                        {
                            //if (nCol == sqlDt.Columns.Count) continue;
                            if (i == 2)
                            {
                                Pp.dgvProcura.Columns[i - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                Pp.dgvProcura.Columns[i - 1].HeaderText = @"Descrição";
                            }
                            if (SqlDt.Columns.Count == 1)
                            {
                                Pp.dgvProcura.Columns.RemoveAt(1);
                            }

                        }
                        Pp.dgvProcura.Columns[i - 1].DataPropertyName = SqlDt.Columns[i - 1].ColumnName.Trim();
                    }
                    Pp.dgvProcura.DataSource = null;
                    Pp.dgvProcura.AutoGenerateColumns = false;
                    Pp.dgvProcura.DataSource = SqlDt;
                }
            }
            else if (IsLocaDs)
            {
                Pp = new Proc{
                    label1 = {Text = "Procura por: " + label1.Text.ToLower()}
                };
                var dt = new DataTable();
                var dc = new DataColumn("descricao", typeof(string));
                var dc2 = new DataColumn("codigo", typeof(decimal));
                dt.Columns.Add(dc2);
                dt.Columns.Add(dc);
                Pp.Dt = dt;
                Pp.IsLocaDs = IsLocaDs;
               
            }
            else
            {
                Pp = new Proc(Selecionado, Tabela, Campo, Campo1, Condicao)
                {
                    label1 = {Text = "Procura por: " + label1.Text.ToLower()}
                };
            }
            if (Pp !=null)
            {
                Pp.HideFirstColumn = HideFirstColumn;
                Pp.ShowThirdColumn = ShowThirdColumn;
                Pp.ReturnDt = ReturnDt;
                Pp.MdiParent = __myParent.MdiParent;
                Pp.StartPosition = FormStartPosition.Manual;
                Pp.Location = new Point(450, 120);
                Pp.PControl = PassData;
                Pp.IsSqlSelect = IsSqlSelect;
                Pp.ShowForm(ParentForm, true);
            }
            else
            {
                MsBox.Show(Messagem.ParteInicial() + "Nenhum registo encontrado!..");
            }
        }

        public virtual void OnGetData()
        {
            var handler = GetDataEvent;
            handler?.Invoke();
        }

        private void btnProcura2_Click(object sender, EventArgs e)
        {
            Procurar();
        }
        private void PassData(object sender, int posicao)
        {
            if (MyParent.GetType().GetMethod("PassData2") != null)
            {
                MyParent.GetType().InvokeMember("PassData2", BindingFlags.InvokeMethod, null, MyParent, new[] { sender, posicao });
            }
            else
            {
                ((FrmClasse)MyParent).GenTable = (DataTable)sender;
                ((FrmClasse)MyParent).Indice = posicao;
                ((FrmClasse)MyParent).PreencheCampos(((FrmClasse)MyParent).GenTable, ((FrmClasse)MyParent).Indice);
                ((FrmClasse)MyParent).OnActualizFilhas(((FrmClasse)MyParent).CLocalStamp);
            }
            ((FrmClasse)MyParent).Procurou = true;
        }
        private void Procurar()
        {
            if (!IsNullOrEmpty(Value))
            {
                MyParent = ParentForm;
                var editeMode = MyParent != null && ((FrmClasse)MyParent).EditMode;
                if (!editeMode || ((FrmClasse)MyParent).Procurou)
                {
                    if (MyParent == null) return;
                    var tabela = ((FrmClasse) MyParent).Ctabela;
                    var tipoApp = ((FrmClasse) MyParent).TipoApp;
                    MultDocumento = ((FrmClasse) MyParent).MultiDoc;
                    var dt = SQL.GetGenDT(
                        $"SELECT TABLE_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE COLUMN_NAME='{Value}' and TABLE_NAME ='{tabela}' ");
                    if (dt.Rows.Count > 0)
                    {
                        var campo1 = ((FrmClasse) MyParent).Campo1;
                        var campo2 = ((FrmClasse) MyParent).Campo2;
                        if (((FrmClasse) MyParent).CCondicao != null)
                        {
                            Condicao2 = ((FrmClasse) MyParent).CCondicao;
                        }

                        var form = Application.OpenForms["Proc2"];
                        if (form != null)
                        {
                            form.Dispose();
                            ProcedForm(tabela, campo1, campo2);
                        }
                        else
                        {
                            ProcedForm(tabela, campo1, campo2);
                        }
                    }
                    else
                    {
                        MsBox.Show(@"Parâmetros não configurados!");
                    }
                }
            }
            else
            {
                MsBox.Show(@"Parâmetros não configurados!");
            }
        }
        private void ProcedForm(string tabela, string campo1, string campo2)
        {
            P2 = new Proc2(tabela, campo1, campo2, Value, Condicao2)
            {
                StartPosition = FormStartPosition.Manual,
                Location = new Point(450, 100),
                PControl = PassData,
                Text = Titulo,
                DataNome = ((FrmClasse)MyParent).MultDocDataNome,
                Multidocumento = MultDocumento
            };
            P2.OrderByCampos =((FrmClasse)MyParent).OrderByCampos;
            if (MyParent.WindowState == FormWindowState.Maximized)
            {
                P2.ShowDialog();
                P2.ShowInTaskbar = false;
            }
            else
            {
                P2.MdiParent = MyParent.MdiParent;
                P2.Show();
            }
        }

        public bool MultDocumento { get; set; }
        public bool ReturnDt { get;  set; }
        public DataTable TmpFound { get; set; }
        public string Condicao2 { get; private set; }
        public bool InserirNovo { get;  set; }

        private void tb1_TextChanged(object sender, EventArgs e)
        {
            if (ParentForm != null && ParentForm.Text.Equals("FrmClasse2")) return;
            if (IsRequered)
            {
                try
                {
                    if (((FrmClasse)ParentForm).EditMode)
                    {
                        //if (((FrmClasse)ParentForm).Inserindo);
                        ExecutaHighLigth();
                    }
                }
                catch (Exception ex)
                {

                    //throw;
                }
            }
            if (ParentForm is FrmClasse)
            {
                if (ParentForm != null && !((FrmClasse)ParentForm).Procurou) return;
                if (((FrmClasse)ParentForm)?.Lista !=null)
                {
                    if (ParentForm != null && !((FrmClasse)ParentForm).Lista.Exists(x => x.Trim().Equals(label1.Text.Trim())))
                    {
                        ((FrmClasse)ParentForm).Lista.Add(label1.Text);
                    }
                }
                else
                {
                    if (((FrmClasse)ParentForm)?.Lista !=null)
                    {
                        ((FrmClasse)ParentForm)?.Lista.Add(label1.Text);      
                    }
                
                }
            }

        }

        private void inserirLinhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsNullOrEmpty(FormName))
            {
                MsBox.Show(Messagem.ParteInicial()+"Parametros não configurados!");
            }
            else
            {
                if (ParentForm != null && ((FrmClasse)ParentForm).EditMode)
                {
                    CallForm();   
                }
                else
                {
                    MsBox.Show(Messagem.ParteInicial()+"Deve ser em modo de edição!");
                }
                     
            }
            
        }

        public string FormName { get; set; }

        [Description("Nome da coluna procura na tabela origem, relaciona se carregar forms com dados ..")]
        public string Descname { get; set; }
        public bool OpenInfo { get;  set; }

        private void CallForm()
        {
            var form = Helper.CreateInstance<Form>(FormName);
            if (form == null) return;
            form.ShowForm(ParentForm);
            if (IsNullOrEmpty(Descname)) return;
            if (IsNullOrEmpty(tb1.Text)) return;
            var tb = ((FrmClasse) form).Ctabela;
            var dt = SQL.GetDT(tb, $"{Descname} ='{tb1.Text.Trim()}'");
            ((FrmClasse)form).PreencheCampos(dt,0);

        }



        private void btnOpneInfo_Click(object sender, EventArgs e)
        {
            tb1.ReadOnly = false;
            OpenInfo=true;
        }

        private void tb1_MouseLeave(object sender, EventArgs e)
        {
            tb1.ReadOnly = true;
        }
    }

    [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
    public class ProcuraControlDesigner : ControlDesigner
    {
        private DesignerActionListCollection _actionLists;

        // Use pull model to populate smart tag menu.
        public override DesignerActionListCollection ActionLists
        {
            get
            {
                if (null == _actionLists)
                {
                    _actionLists = new DesignerActionListCollection {new ProcuraControlActionList(Component)};
                }
                return _actionLists;
            }
        }
    }
    public class ProcuraControlActionList : DesignerActionList
    {
        private Procura  colUserControl;

        private DesignerActionUIService _designerActionUiSvc;

        //The constructor associates the control with the smart tag list.
        public ProcuraControlActionList(IComponent component): base(component)
        {
            colUserControl = component as Procura;
            // Cache a reference to DesignerActionUIService, so the DesigneractionList can be refreshed.
            _designerActionUiSvc = GetService(typeof(DesignerActionUIService)) as DesignerActionUIService;
        }




        public void EditTextLines()
        {
            var linesPropertyDescriptor = TypeDescriptor.GetProperties(colUserControl)["Values"];
            var context = new TypeDescriptionContext(colUserControl, linesPropertyDescriptor);
            var editor = (UITypeEditor)linesPropertyDescriptor.GetEditor(typeof(UITypeEditor));
            var lines = colUserControl.Values;
            var result = (string[])editor.EditValue(context, context, lines);
            if (!result.Length.Equals(lines))
                linesPropertyDescriptor.SetValue(colUserControl, result);
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
        public Color BackColor
        {
            get => colUserControl.TextBoxBackColor;
            set => GetPropertyByName("TextBoxBackColor").SetValue(colUserControl, value);
        }

        public Color ForeColor
        {
            get => colUserControl.TextBoxForeColor;
            set => GetPropertyByName("TextBoxForeColor").SetValue(colUserControl, value);
        }

        public string[] Values
        {
            get => colUserControl.Values;
            set => EditTextLines();//GetPropertyByName("Values").SetValue(colUserControl, value);
        }
        public string Value
        {
            get => colUserControl.Value;
            set => GetPropertyByName("Value").SetValue(colUserControl, value);
        }
        public string Value2
        {
            get => colUserControl.Value2;
            set => GetPropertyByName("Value2").SetValue(colUserControl, value);
        }
        [Editor(typeof(MultilineStringEditor),typeof(UITypeEditor))]
        public string Label1Text
        {
            get => colUserControl.Label1Text;
            set => GetPropertyByName("Label1Text").SetValue(colUserControl, value);
        }
        public Color label1ForeColor
        {
            get => colUserControl.label1ForeColor;
            set => GetPropertyByName("label1ForeColor").SetValue(colUserControl, value);
        }

        public bool IsSqlSelect
        {
            get => colUserControl.IsSqlSelect;
            set => GetPropertyByName("IsSqlSelect").SetValue(colUserControl, value);
        }
        [Editor(typeof(MultilineStringEditor),typeof(UITypeEditor))]
        public string SqlComandText
        {
            get => colUserControl.SqlComandText;
            set => GetPropertyByName("SqlComandText").SetValue(colUserControl, value);
        }
        [Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
        public string Value3
        {
            get => colUserControl.Value3;
            set => GetPropertyByName("Value3").SetValue(colUserControl, value);
        }
        [EditorAttribute(typeof(MultilineStringEditor), typeof(UITypeEditor))]
        public string Value4
        {
            get => colUserControl.Value4;
            set => GetPropertyByName("Value4").SetValue(colUserControl, value);
        }
        [EditorAttribute(typeof(MultilineStringEditor), typeof(UITypeEditor))]
        public string Value5
        {
            get => colUserControl.Value5;
            set => GetPropertyByName("Value5").SetValue(colUserControl, value);
        }
        [EditorAttribute(typeof(MultilineStringEditor), typeof(UITypeEditor))]
        public string Value6
        {
            get => colUserControl.Value6;
            set => GetPropertyByName("Value6").SetValue(colUserControl, value);
        }

        //[EditorAttribute(typeof(MultilineStringEditor), typeof(UITypeEditor))]
        //public string Values
        //{
        //    get => colUserControl.Value6;
        //    set => GetPropertyByName("Values").SetValue(colUserControl, value);
        //}
        public AnchorStyles Anchor
        {
            get => colUserControl.Anchor;
            set => GetPropertyByName("Anchor").SetValue(colUserControl, value);
        }
        public Font Font
        {
            get => colUserControl.Font;
            set => GetPropertyByName("Font").SetValue(colUserControl, value);
        }
        // Implementation of this abstract method creates smart tag  items, associates their targets, and collects into list.
        public override DesignerActionItemCollection GetSortedActionItems()
        {
            var items = new DesignerActionItemCollection
            {
                new DesignerActionHeaderItem("Appearance"),
                new DesignerActionPropertyItem("BackColor", "Back Color", "Appearance","Selects the background color."),
                new DesignerActionPropertyItem("ForeColor", "Fore Color", "Appearance","Selects the foreground color."),
                new DesignerActionPropertyItem("Value", "Value", "Appearance","SQL Table Column - Table Link"),
                new DesignerActionPropertyItem("Value2", "Value2", "Appearance","SQL Table Column - Table Link"),
                new DesignerActionPropertyItem("Value3", "Value3", "Appearance","SQL Table Column - Table Link"),
                new DesignerActionPropertyItem("Value4", "Value4", "Appearance","SQL Table Column - Table Link"),
                new DesignerActionPropertyItem("Value5", "Value5", "Appearance","SQL Table Column - Table Link"),
                new DesignerActionPropertyItem("Value6", "Value6", "Appearance","SQL Table Column - Table Link"),
                new DesignerActionPropertyItem("Label1Text", "Label Text", "Appearance","Label Text"),
                new DesignerActionPropertyItem("label1ForeColor", "label ForeColor", "Appearance","label ForeColor"),
                new DesignerActionPropertyItem("IsSqlSelect", "Is Sql Select", "Appearance","Sql select "),
                new DesignerActionPropertyItem("SqlComandText", "SqlComandText", "Appearance","SqlComandText"),
                new DesignerActionPropertyItem("Anchor", "Anchor", "Appearance","Anchor"),
                new DesignerActionPropertyItem("Font", "Font", "Appearance", "Font")
            };
            items.Add(new DesignerActionMethodItem(this, "EditTextLines",
               "Define SQL Link Columns", "Behavior", "Opens the Lines collection editor", false));
            return items;
        }
    }

    public class TypeDescriptionContext : ITypeDescriptorContext, IServiceProvider,
    IWindowsFormsEditorService
    {
        private Control component;
        private PropertyDescriptor editingProperty;
        public TypeDescriptionContext(Control component, PropertyDescriptor property)
        {
            this.component = component;
            editingProperty = property;
        }
        public IContainer Container { get { return component.Container; } }
        public object Instance { get { return component; } }
        public void OnComponentChanged()
        {
            var svc = (IComponentChangeService)this.GetService(
                typeof(IComponentChangeService));
            svc.OnComponentChanged(component, editingProperty, null, null);
        }
        public bool OnComponentChanging() { return true; }
        public PropertyDescriptor PropertyDescriptor { get { return editingProperty; } }
        public object GetService(Type serviceType)
        {
            if ((serviceType == typeof(ITypeDescriptorContext)) ||
                (serviceType == typeof(IWindowsFormsEditorService)))
                return this;
            return component.Site.GetService(serviceType);
        }
        public void CloseDropDown() { }
        public void DropDownControl(Control control) { }
        DialogResult IWindowsFormsEditorService.ShowDialog(Form dialog)
        {
            IUIService service = (IUIService)(this.GetService(typeof(IUIService)));
            return service.ShowDialog(dialog);
        }
    }
}
