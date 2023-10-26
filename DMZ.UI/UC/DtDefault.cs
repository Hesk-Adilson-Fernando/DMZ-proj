using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using DMZ.UI.Basic;
using DMZ.UI.Generic;

namespace DMZ.UI.UC
{
    [Designer(typeof(DtDefaultControlDesigner))]
    public partial class DtDefault : UserControl
    {
        public DtDefault()
        {
            InitializeComponent();
            dt1.MinDate = new DateTime(1900, 01, 01);
            dt1.MaxDate = new DateTime(3000, 01, 01);
            dt1.Value = DateTime.Now;
            dt1.Format = DateTimePickerFormat.Custom;
            dt1.CalendarMonthBackground = System.Drawing.Color.Aqua;
        }
        public delegate void DateChangValue();
        //Cria um evento
        public event DateChangValue DateChangValues;

        //public event 
        protected virtual void OnTextChangValue()
        {
            var handler = DateChangValues;
            handler?.Invoke();
        }
        public string Value { get; set; }
        public AnchorStyles TextBox1Anchor
        {
            get => dt1.Anchor;
            set => dt1.Anchor = value;
        }
        public DateTime Dt1Value
        {
            get => dt1.Value;
            set => dt1.Value = new DateTime(value.Year,value.Month,value.Day);
        }
        public AnchorStyles Label1Anchor
        {
            get => label1.Anchor;
            set => label1.Anchor = value;
        }
        public string Label1Text
        {
            get => label1.Text;
            set => label1.Text = value;
        }

        public DateTimePickerFormat DtFormat 
        {
            get => dt1.Format;
            set => dt1.Format = value;
        }
        public string DtCustomFormat 
        {
            get => dt1.CustomFormat;
            set => dt1.CustomFormat = value;
        }
        public bool DtShowUpDown 
        {
            get => dt1.ShowUpDown;
            set => dt1.ShowUpDown = value;
        }
        public Color label1ForeColor
        {
            get => label1.ForeColor;
            set => label1.ForeColor = value;
        }
        public Font Font
        {
            get => dt1.Font;
            set => dt1.Font = value;
        }
        public Size DtSize
        {
            get => dt1.Size;
            set => dt1.Size = value;
        }
        private void dtpDefault_Load(object sender, EventArgs e)
        {
           

        }

        private void dt1_ValueChanged(object sender, EventArgs e)
        {
            if (ParentForm is FrmClasse)
            {
                if (ParentForm != null && ((FrmClasse) ParentForm).Lista != null)
                {
                    if (((FrmClasse) ParentForm).Procurou)
                    {
                        if (((FrmClasse) ParentForm).Lista.Exists(x => x.Trim().Equals(label1.Text.Trim())))
                        {
                            ((FrmClasse) ParentForm).Lista.Add(label1.Text);
                        }
                    }

                }
            }

            OnTextChangValue();
        }
    }
    [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
    public class DtDefaultControlDesigner : ControlDesigner
    {
        private DesignerActionListCollection _actionLists;

        // Use pull model to populate smart tag menu.
        public override DesignerActionListCollection ActionLists
        {
            get
            {
                if (null == _actionLists)
                {
                    _actionLists = new DesignerActionListCollection {new DtDefaultControlActionList(Component)};
                }
                return _actionLists;
            }
        }
    }
    public class DtDefaultControlActionList : DesignerActionList
    {
        private DtDefault  colUserControl;

        private DesignerActionUIService _designerActionUiSvc;

        //The constructor associates the control with the smart tag list.
        public DtDefaultControlActionList(IComponent component): base(component)
        {
            colUserControl = component as DtDefault;
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
        public string Value
        {
            get => colUserControl.Value;
            set => GetPropertyByName("Value").SetValue(colUserControl, value);
        }
        [EditorAttribute(typeof(MultilineStringEditor),typeof(UITypeEditor))]
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
        public DateTimePickerFormat DtFormat
        {
            get => colUserControl.DtFormat;
            set => GetPropertyByName("DtFormat").SetValue(colUserControl, value);
        }
        [Editor(typeof(DateTimePickerEditor), typeof(UITypeEditor))]
        public DateTime Dt1Value
        {
            get => colUserControl.Dt1Value;
            set => GetPropertyByName("Dt1Value").SetValue(colUserControl, value.Date);
        }
        // Implementation of this abstract method creates smart tag  items, associates their targets, and collects into list.
        public override DesignerActionItemCollection GetSortedActionItems()
        {
            var items = new DesignerActionItemCollection
            {
                new DesignerActionHeaderItem("Appearance"),
                new DesignerActionPropertyItem("Value", "Value", "Appearance",
                    "SQL Table Column - Table Link"),
                new DesignerActionPropertyItem("Label1Text", "Label Text", "Appearance",
                    "Label Text"),
                new DesignerActionPropertyItem("label1ForeColor", "label ForeColor", "Appearance",
                    "label ForeColor"),
                new DesignerActionPropertyItem("Anchor", "Anchor", "Appearance",
                    "Anchor"),
                new DesignerActionPropertyItem("Font", "Font", "Appearance",
                    "Font"),
                new DesignerActionPropertyItem("DtFormat", "DateTime Format", "Appearance",
                    "DateTime Format"),
                new DesignerActionPropertyItem("Dt1Value", "DateTimePicker", "Appearance",
                    "DateTimePicker")
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
                var props= ((FrmClasse)colUserControl.ParentForm).GetListProps().ToArray();
                foreach (var c in props)
                {
                    lista.Add(c.Name);  
                }
                //lista.AddRange(props.Select(p => p.Name));
            }
            var f = new FrmCProperty {gridPreco = {DataSource = lista}};
            f.ShowDialog();
        }
    }

}
