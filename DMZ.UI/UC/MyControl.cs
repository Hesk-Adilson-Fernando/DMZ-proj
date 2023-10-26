using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing.Design;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace DMZ.UI.UC
{
    [Designer(typeof(MyControlDesigner))]
    public class MyControl: Control
    {
        public string[] Lines
        {
            get =>
                Text.Split(new string[] { Environment.NewLine },
                    StringSplitOptions.None);
            set
            {
                if (value != null)
                    Text = string.Join(Environment.NewLine, value);
            }
        }
    }
    public class MyControlDesigner : ControlDesigner
    {
        public override DesignerActionListCollection ActionLists
        {
            get
            {
                var list = new DesignerActionListCollection();
                list.Add(new MyControlActionList(this));
                return list;
            }
        }

    }

    public class MyControlActionList : DesignerActionList
    {
        MyControlDesigner designer;
        MyControl Control => (MyControl)designer.Control;

        public MyControlActionList(MyControlDesigner designer) : base(designer.Component)
        {
            this.designer = designer;
        }
        public override DesignerActionItemCollection GetSortedActionItems()
        {
            var items = new DesignerActionItemCollection();
            items.Add(new DesignerActionMethodItem(this, "EditTextLines",
                "Edit Text Lines...", "Behavior", "Opens the Lines collection editor", false));
            items.Add(new DesignerActionMethodItem(this, "Add",
                "Add", "Behavior", "Opens the Lines collection editor", false));
            return items;
        }
        public void EditTextLines()
        {
            var linesPropertyDescriptor = TypeDescriptor.GetProperties(this.Control)["Lines"];
            var context = new TypeDescriptionContext(this.Control, linesPropertyDescriptor);
            var editor = (UITypeEditor)linesPropertyDescriptor.GetEditor(typeof(UITypeEditor));
            var lines = (this.Control).Lines;
            var result = (string[])editor.EditValue(context, context, lines);
            if (!result.SequenceEqual(lines))
                linesPropertyDescriptor.SetValue(this.Control, result);
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
        public PropertyDescriptor PropertyDescriptor => editingProperty;

        public object GetService(Type serviceType)
        {
            if (serviceType == typeof(ITypeDescriptorContext) ||
                (serviceType == typeof(IWindowsFormsEditorService)))
                return this;
            return component.Site.GetService(serviceType);
        }
        public void CloseDropDown() { }
        public void DropDownControl(Control control) { }
        DialogResult IWindowsFormsEditorService.ShowDialog(Form dialog)
        {
            IUIService service = (IUIService)GetService(typeof(IUIService));
            return service.ShowDialog(dialog);
        }
    }

}
