using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using DMZ.BL.Classes;
using DMZ.UI.Basic;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using static System.String;

namespace DMZ.UI.UC
{
    [Designer(typeof(DmzProcuraControlDesigner))]
    public partial class DmzProcura : UserControl
    {
        public DmzProcura()
        {
            InitializeComponent();
        }

        #region Properties....

        [Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
        public string SqlComandText { get; set; }
        public bool HideFirstColumn { get; set; }
        public bool InvertColuna { get; set; }
        public string Condicao { get; set; }
        public bool IsLocaDs { get; set; }
        private Form _myParent;
        private Form __myParent;

        public Proc Pp { get; set; }
        public string Text2 { get; set; }
        public string Label1Text
        {
            get => label1.Text;
            set => label1.Text = value;
        }
        public Font Label1Font
        {
            get => label1.Font;
            set => label1.Font = value;
        }
        public AnchorStyles Label1Anchor
        {
            get => label1.Anchor;
            set => label1.Anchor = value;
        }
        public bool Tb1Multiline
        {
            get => tb1.Multiline;
            set => tb1.Multiline = value;
        }
        public AnchorStyles Button1Anchor
        {
            get => btnProc.Anchor;
            set => btnProc.Anchor = value;
        }
        public AnchorStyles Tb1Anchor
        {
            get => tb1.Anchor;
            set => tb1.Anchor = value;
        }

        public AnchorStyles BtnProcAnchor
        {
            get => btnProc.Anchor;
            set => btnProc.Anchor = value;
        }

        public bool BtnEnabled
        {
            get => btnProc.Enabled;
            set => btnProc.Enabled = value;
        }
        #endregion

        #region Delegates,Events and Methods  
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
        #endregion
        public delegate void ProcuraTBTextChangedDelegate();
        public event ProcuraTBTextChangedDelegate ProcuraTBTextChangedEvent;
        public virtual void ProcuraTBTextChanged()
        {
            var handler = ProcuraTBTextChangedEvent;
            handler?.Invoke();
        }
        public string MySQLQuerry { get; set; }
        public string Text3 { get;  set; }
        public bool IsSqlSelect { get; private set; }
        //public string Selecionado { get; private set; }
        //public string Tabela { get; private set; }
        //public bool Dependente { get; private set; }
        //public bool ShowThirdColumn { get; private set; }
        //public string Campo { get; private set; }
        //public string Campo1 { get; private set; }
        //public bool ReturnDt { get; private set; }
        public bool ExecMetodo { get; set; }

        private void btnProc_Click(object sender, EventArgs e)
        {
            _myParent = ParentForm;
            GetValue();
        }
        public DataTable SqlDt;
                //Cria um delegate
        public delegate void GetData();
        //Cria um evento
        public event GetData GetDataEvent;
        public virtual void OnGetData()
        {
            var handler = GetDataEvent;
            handler?.Invoke();
        }
        private void GetValue()
        {
            if (!IsNullOrEmpty(SqlComandText))
            {
                SqlDt = SQL.GetGenDT(SqlComandText); 
            }
            if (ExecMetodo)
            {
                OnGetData();
                if (SqlDt?.Rows.Count==0)
                {
                    MsBox.Show("Parametros não definidos!..");
                    return;
                }
            }

            if (SqlDt != null)
            {
                var dr = SqlDt.NewRow();
                SqlDt.Rows.InsertAt(dr, 0);
            }

            Pp = new Proc { Dt = SqlDt };
            if (SqlDt != null && SqlDt.Columns.Count==2)
            {
                Pp.dgvProcura.Columns[0].DataPropertyName = SqlDt.Columns[0].ColumnName.Trim();
                Pp.dgvProcura.Columns[1].DataPropertyName = SqlDt.Columns[1].ColumnName.Trim();
            }

            if (SqlDt != null)
            {
                switch (SqlDt.Columns.Count)
                {
                    case 1:
                        Pp.dgvProcura.Columns[1].DataPropertyName = SqlDt.Columns[0].ColumnName.Trim();
                        Pp.dgvProcura.Columns.RemoveAt(0);
                        break;
                    case 2:
                        Pp.dgvProcura.Columns[0].DataPropertyName = SqlDt.Columns[0].ColumnName.Trim();
                        Pp.dgvProcura.Columns[1].DataPropertyName = SqlDt.Columns[1].ColumnName.Trim();
                        break;
                    case 3:
                        Pp.dgvProcura.Columns[0].DataPropertyName = SqlDt.Columns[0].ColumnName.Trim();
                        Pp.dgvProcura.Columns[1].DataPropertyName = SqlDt.Columns[1].ColumnName.Trim();
                        var col = new DataGridViewTextBoxColumn
                        {
                            Name = SqlDt.Columns[2].ColumnName.Trim(),
                            DataPropertyName = SqlDt.Columns[2].ColumnName.Trim(),
                            Visible = false
                        };
                        Pp.dgvProcura.Columns.Add(col);
                        break;
                    case 4:
                        Pp.dgvProcura.Columns[0].DataPropertyName = SqlDt.Columns[0].ColumnName.Trim();
                        Pp.dgvProcura.Columns[1].DataPropertyName = SqlDt.Columns[1].ColumnName.Trim();
                        //Pp.dgvProcura.Columns[2].DataPropertyName = SqlDt.Columns[2].ColumnName.Trim();
                        var col2 = new DataGridViewTextBoxColumn
                        {
                            Name = SqlDt.Columns[2].ColumnName.Trim(),
                            DataPropertyName = SqlDt.Columns[2].ColumnName.Trim(),
                            Visible = false
                        };
                        Pp.dgvProcura.Columns.Add(col2);
                        var col3 = new DataGridViewTextBoxColumn
                        {
                            Name = SqlDt.Columns[3].ColumnName.Trim(),
                            DataPropertyName = SqlDt.Columns[3].ColumnName.Trim(),
                            Visible = false
                        };
                        Pp.dgvProcura.Columns.Add(col3);
                        break;
                        default:
                            Pp.dgvProcura.Columns[0].DataPropertyName = SqlDt.Columns[0].ColumnName.Trim();
                            Pp.dgvProcura.Columns[1].DataPropertyName = SqlDt.Columns[1].ColumnName.Trim();
                        break;
                }

                Pp.dgvProcura.DataSource = null;
                Pp.dgvProcura.AutoGenerateColumns = false;
                Pp.dgvProcura.DataSource = SqlDt;
            }

            if (ParentForm != null) Pp.MdiParent = ParentForm.MdiParent;
            Pp.HideFirstColumn = HideFirstColumn;
            Pp.StartPosition = FormStartPosition.Manual;
            Pp.Location = new Point(450, 120);
            Pp.PControl = PassData;
            Pp.IsSqlSelect = true;
            Pp.Show();
        }
        private void PassData(DataTable tab,DataTable dt)
        {
            if (InvertColuna)
            {
                Text2 = tab.RowZero("descricao").ToString();// ((TextBox)sender).Text;
                tb1.Text = tab.RowZero("codigo").ToString();// (string)((TextBox)sender).Tag;
                Text3 = tab.RowZero("campo3").ToString();//((TextBox)sender).Name;
                Text4 = tab.RowZero("campo4").ToString();//((TextBox)sender).Name;
            }
            else
            {
                tb1.Text = tab.RowZero("descricao").ToString();// (string)((TextBox)sender).Tag;
                Text2 = tab.RowZero("codigo").ToString();// ((TextBox)sender).Text;
                Text3 = tab.RowZero("campo3").ToString();//((TextBox)sender).Name;
                Text4 = tab.RowZero("campo4").ToString();//((TextBox)sender).Name;
            }



            //if (InvertColuna)
            //{
            //    Text2 = ((TextBox)sender).Text;
            //    tb1.Text = (string)((TextBox)sender).Tag;
            //    Text3 = ((TextBox)sender).Name;
            //}
            //else
            //{
            //    if (!IsNullOrEmpty(((TextBox)sender).Tag.ToString()))
            //    {
            //        Text2 = ((TextBox)sender).Tag.ToString();
            //    }
            //    tb1.Text = ((TextBox)sender).Text;
            //    Text3 = ((TextBox)sender).Name;
            //}
            OnRefreshControls();
        }

        public string Text4 { get; set; }
        public string Value { get; internal set; }
        public string Value2 { get; internal set; }

        private void tb1_TextChanged(object sender, EventArgs e)
        {
            ProcuraTBTextChanged();
            if (IsNullOrEmpty(tb1.Text))
            {
                Text2="";
            }
        }

        private void DmzProcura_Load(object sender, EventArgs e)
        {
           
        }

        internal class Refresh
        {
            private Action tbgrupo_RefreshControls;

            public Refresh(Action tbgrupo_RefreshControls)
            {
                this.tbgrupo_RefreshControls = tbgrupo_RefreshControls;
            }
        }
    }


    [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
    public class DmzProcuraControlDesigner : ControlDesigner
    {
        private DesignerActionListCollection _actionLists;

        // Use pull model to populate smart tag menu.
        public override DesignerActionListCollection ActionLists
        {
            get
            {
                if (null == _actionLists)
                {
                    _actionLists = new DesignerActionListCollection { new DmzProcuraControlActionList(Component) };
                }
                return _actionLists;
            }
        }
    }
    public class DmzProcuraControlActionList : DesignerActionList
    {
        private DmzProcura colUserControl;

        private DesignerActionUIService _designerActionUiSvc;

        //The constructor associates the control with the smart tag list.
        public DmzProcuraControlActionList(IComponent component) : base(component)
        {
            colUserControl = component as DmzProcura;
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
        public Color BackColor
        {
            get => colUserControl.BackColor;
            set => GetPropertyByName("TextBoxBackColor").SetValue(colUserControl, value);
        }

        public Color ForeColor
        {
            get => colUserControl.tb1.ForeColor;
            set => GetPropertyByName("TextBoxForeColor").SetValue(colUserControl, value);
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
        [EditorAttribute(typeof(MultilineStringEditor), typeof(UITypeEditor))]
        public string Label1Text
        {
            get => colUserControl.Label1Text;
            set => GetPropertyByName("Label1Text").SetValue(colUserControl, value);
        }
        public Color label1ForeColor
        {
            get => colUserControl.label1.ForeColor;
            set => GetPropertyByName("label1ForeColor").SetValue(colUserControl, value);
        }

        public bool IsSqlSelect
        {
            get => colUserControl.IsSqlSelect;
            set => GetPropertyByName("IsSqlSelect").SetValue(colUserControl, value);
        }
        [Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
        public string SqlComandText
        {
            get => colUserControl.SqlComandText;
            set => GetPropertyByName("SqlComandText").SetValue(colUserControl, value);
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
        // Implementation of this abstract method creates smart tag  items, associates their targets, and collects into list.
        public override DesignerActionItemCollection GetSortedActionItems()
        {
            var items = new DesignerActionItemCollection
            {
                new DesignerActionHeaderItem("Appearance"),
                new DesignerActionPropertyItem("BackColor", "Back Color", "Appearance",
                    "Selects the background color."),
                new DesignerActionPropertyItem("ForeColor", "Fore Color", "Appearance",
                    "Selects the foreground color."),
                new DesignerActionPropertyItem("Value", "Value", "Appearance",
                    "SQL Table Column - Table Link"),
                new DesignerActionPropertyItem("Value2", "Value2", "Appearance",
                "SQL Table Column - Table Link"),
                new DesignerActionPropertyItem("Label1Text", "Label Text", "Appearance",
                    "Label Text"),
                new DesignerActionPropertyItem("label1ForeColor", "label ForeColor", "Appearance",
                    "label ForeColor"),
                new DesignerActionPropertyItem("IsSqlSelect", "Is Sql Select", "Appearance",
                    "Sql select "),
                new DesignerActionPropertyItem("SqlComandText", "SqlComandText", "Appearance",
                    "SqlComandText"),
                new DesignerActionPropertyItem("Anchor", "Anchor", "Appearance",
                    "Anchor"),
                new DesignerActionPropertyItem("Font", "Font", "Appearance",
                    "Font")
            };
            return items;
        }
    }
}
