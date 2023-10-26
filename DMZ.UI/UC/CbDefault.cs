using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using DMZ.UI.Basic;
using DMZ.UI.Properties;


namespace DMZ.UI.UC
{
    [Designer(typeof(CbDefaultControlDesigner))]
    public partial class CbDefault : UserControl
    {
        public CbDefault()
        {
            InitializeComponent();
        }
        public Font CbFont
        {
            get => cb1.Font;
            set => cb1.Font = value;
        }
        public AnchorStyles CbAnchorEditor
        {
            get => cb1.Anchor;
            set => cb1.Anchor = value;
        }
        public AnchorStyles BtnCheckAnchorEditor
        {
            get => btnCheck.Anchor;
            set => btnCheck.Anchor = value;
        }
        public delegate void CBCheckedChanged();

        public event CBCheckedChanged CheckedChangeds;

        protected virtual void OnCheckedChanged()
        {
            var handler = CheckedChangeds;
            handler?.Invoke();
        }
        public Color CbForeColor
        {
            get => cb1.ForeColor;
            set => cb1.ForeColor = value;
        }
        public string CbText
        {
            get => cb1.Text;
            set => cb1.Text = value;
        }
        public ContentAlignment CbTextAlign
        {
            get => cb1.TextAlign;
            set => cb1.TextAlign = value;
        }
        [Description("Imagem do Botão")]
        public Image Imagem
        {
            get => btnCheck.Image;
            set => btnCheck.Image = value;
        }

        [Description("É ControlSource. Digitar o nome do SqlServer")]      
        public string Value { get; set; }

        [Description("Valor a Fixo do Objecto")]
        public string Value2 { get; set; }

        [Description("Indica que o Control esta Dentro de OptionGroup")]
        public bool IsOptionGroup { get; set; }
        [Description("É Campo Obrigatório quando true")]
        public bool IsRequered { get; set; }
        [Description("É Somente Leitura quando true")]
        public bool IsReadOnly { get; set; }

        private void CbDefault_Load(object sender, EventArgs e)
        {

        }

        private void cb1_EnabledChanged(object sender, EventArgs e)
        {
            if (IsReadOnly)
            {
                cb1.Enabled = true;
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Update();
        }

        public void Update()
        {
            if (cb1.Checked)
            {
                cb1.Checked = false;
                if (!IsOptionGroup)
                {
                    btnCheck.Image = Resources.Unchecked_Checkbox_23px;
                }
                else
                {
                    btnCheck.Image = Resources.Circle_23px1;
                    ((DmzOptionGroup) Parent).SetUpdate(Name);
                }

                
            }
            else
            {
                cb1.Checked = true;
                if (!IsOptionGroup)
                {
                    btnCheck.Image = Resources.Checked_Checkbox_2_23px;
                }
                else
                {
                    btnCheck.Image = Resources.Circled_Dot_23px;
                    ((DmzOptionGroup)Parent).SetUpdate(Name);
                }

                
            }
        }

        public void Update(bool check)
        {
            cb1.Checked = check;
            if (!check)
            {
                if (!IsOptionGroup)
                {
                    btnCheck.Image = Resources.Unchecked_Checkbox_23px;
                }
                else
                {
                    btnCheck.Image = Resources.Circle_23px1;
                    ((DmzOptionGroup) Parent).SetUpdate(Name);
                }
            }
            else
            {
                if (!IsOptionGroup)
                {
                    btnCheck.Image = Resources.Checked_Checkbox_2_23px;
                }
                else
                {
                    btnCheck.Image = Resources.Circled_Dot_23px;
                    ((DmzOptionGroup)Parent).SetUpdate(Name);
                }
            }
        }

        public void RefreshContrls()
        {
            btnCheck.Image = Resources.Circle_23px1;
            cb1.Checked = false;
        }

        private void cb1_CheckedChanged(object sender, EventArgs e)
        {
            OnCheckedChanged();
            if (OnlyCheckBox) return;
            if (ParentForm is FrmClasse)
            {
                if (ParentForm != null && !((FrmClasse)ParentForm).Procurou) return;
                if (((FrmClasse)ParentForm).Lista==null) return;
                if (ParentForm != null && !((FrmClasse)ParentForm).Lista.Exists(x => x.Trim().Equals(cb1.Text.Trim())))
                {
                    ((FrmClasse)ParentForm).Lista.Add(cb1.Text);
                } 
            }
        }

        public bool OnlyCheckBox { get; set; }
        public Image BtnCheckNewImagem { get; internal set; }
        public object Imagem2 { get; internal set; }

        private void cb1_MouseClick(object sender, MouseEventArgs e)
        {
            var valor = cb1.Checked;
            cb1.Checked = !valor;
            Update();
        }
    }

   [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
    public class CbDefaultControlDesigner : ControlDesigner
    {
        private DesignerActionListCollection _actionLists;

        // Use pull model to populate smart tag menu.
        public override DesignerActionListCollection ActionLists
        {
            get
            {
                if (null == _actionLists)
                {
                    _actionLists = new DesignerActionListCollection {new CbDefaultControlActionList(Component)};
                }
                return _actionLists;
            }
        }
    }
    public class CbDefaultControlActionList : DesignerActionList
    {
        private CbDefault  colUserControl;

        private DesignerActionUIService _designerActionUiSvc;

        //The constructor associates the control with the smart tag list.
        public CbDefaultControlActionList(IComponent component): base(component)
        {
            colUserControl = component as CbDefault;
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
        [EditorAttribute(typeof(MultilineStringEditor),typeof(UITypeEditor))]
        public string Label1Text
        {
            get => colUserControl.CbText;
            set => GetPropertyByName("CbText").SetValue(colUserControl, value);
        }
        public bool OnlyCheckBox
        {
            get => colUserControl.OnlyCheckBox;
            set => GetPropertyByName("OnlyCheckBox").SetValue(colUserControl, value);
        }
        public bool IsRequered
        {
            get => colUserControl.IsRequered;
            set => GetPropertyByName("IsRequered").SetValue(colUserControl, value);
        }
        public ContentAlignment CbTextAlign
        {
            get => colUserControl.CbTextAlign;
            set => GetPropertyByName("CbTextAlign").SetValue(colUserControl, value);
        }
        public AnchorStyles Anchor
        {
            get => colUserControl.Anchor;
            set => GetPropertyByName("Anchor").SetValue(colUserControl, value);
        }
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
                new DesignerActionPropertyItem("Value", "Value", "Appearance",
                    "SQL Table Column - Table Link"),
                new DesignerActionPropertyItem("Value2", "Value2", "Appearance",
                "SQL Table Column - Table Link"),
                new DesignerActionPropertyItem("Label1Text", "Label Text", "Appearance",
                    "Label Text"),
                new DesignerActionPropertyItem("OnlyCheckBox", "OnlyCheckBox", "Appearance",
                    "OnlyCheckBox"),
                new DesignerActionPropertyItem("IsRequered", "IsRequered", "Appearance",
                    "IsRequered"),
                new DesignerActionPropertyItem("CbTextAlign", "CbTextAlign", "Appearance",
                    "CbTextAlign"),
                new DesignerActionPropertyItem("Anchor", "Anchor", "Appearance",
                    "Anchor"),
                new DesignerActionPropertyItem("Name", "Name", "Appearance",
                    "Name")

            };
            return items;
        }
    }
}
