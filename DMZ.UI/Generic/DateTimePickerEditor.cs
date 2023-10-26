using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace DMZ.UI.Generic
{
    public class DateTimePickerEditor : UITypeEditor
    {
           IWindowsFormsEditorService _editorService;
            MonthCalendar calendar = new MonthCalendar();
            public DateTimePickerEditor()
            {
                calendar.MaxSelectionCount = 1;
                calendar.DateChanged += calendar_DateChanged;
            }
            void calendar_DateChanged(object sender, DateRangeEventArgs e) => _editorService.CloseDropDown();

            public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
            {

                if (provider != null)
                {
                    _editorService = provider.GetService(typeof(IWindowsFormsEditorService)) as IWindowsFormsEditorService;
                }
                if (_editorService == null) return value;
                if (value != null)
                {
                    calendar.SetDate((DateTime) value);

                    _editorService.DropDownControl(calendar);
                }

                value = calendar.SelectionStart;

                return value;
            }
            public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context) => UITypeEditorEditStyle.DropDown;
    }
}
