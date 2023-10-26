using DMZ.BL.Classes;
using DMZ.UI.Basic;
using DMZ.UI.Generic;
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

namespace DMZ.UI.UC
{
    [Designer(typeof(DMZNumeroControlDesigner))]
    public partial class DMZNumero : UserControl
    {
        public DMZNumero()
        {
            InitializeComponent();
        }
        [Description("ControlSourse do TextBox")]
        public string Value { get; set; }

        [Description("ControlSourse do Campo2")]
        public string Value2 { get; set; }
        public Font label1Font
        {
            get => label1.Font;
            set => label1.Font = value;
        }
        public Color label1ForeColor
        {
            get => label1.ForeColor;
            set => label1.ForeColor = value;
        }

        public AnchorStyles TextBox1Anchor
        {
            get => nud1.Anchor;
            set => nud1.Anchor = value;
        }
        public AnchorStyles Label1Anchor
        {
            get => label1.Anchor;
            set => label1.Anchor = value;
        }
        public AnchorStyles ButtonAnchor
        {
            get => btnProcura2.Anchor;
            set => btnProcura2.Anchor = value;
        }
        [Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
        public string Label1Text
        {
            get => label1.Text;
            set => label1.Text = value;
        }
        [Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
        public string Label1Text2 { get; set; }
        public Form MyParent { get; private set; }
        public bool MultDocumento { get; private set; }
        public string Condicao { get; private set; }
        public Proc2 P2 { get; private set; }
        public string Titulo { get; private set; }
        public string Nome { get; internal set; }
        public string Text2 { get; internal set; }

        private void DMZNumero_Load(object sender, EventArgs e)
        {

        }

        private void btnProcura2_Click(object sender, EventArgs e)
        {
            if (ParentForm is FrmClasse2) return;
            Procurar();
        }
        private void Procurar()
        {
            if (!string.IsNullOrEmpty(Value))
            {
                MyParent = ParentForm;
                var editeMode = MyParent != null && ((FrmClasse)MyParent).EditMode;
                if (editeMode && !((FrmClasse)MyParent).Procurou) return;
                if (MyParent == null) return;
                var tabela = ((FrmClasse)MyParent).Ctabela;
                MultDocumento = ((FrmClasse)MyParent).MultiDoc;
                var dt = SQL.GetGenDT($"SELECT TABLE_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE COLUMN_NAME='{Value}' and TABLE_NAME ='{tabela}' ");
                if (dt.Rows.Count > 0)
                {
                    var campo1 = ((FrmClasse)MyParent).Campo1;
                    var campo2 = ((FrmClasse)MyParent).Campo2;
                    if (((FrmClasse)MyParent).CCondicao != null)
                    {
                        Condicao = ((FrmClasse)MyParent).CCondicao;
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
            else
            {
                MsBox.Show(@"Parâmetros não configurados!");
            }
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
        private void ProcedForm(string tabela, string campo1, string campo2)
        {
            P2 = new Proc2(tabela, campo1, campo2, Value, Condicao)
            {
                StartPosition = FormStartPosition.Manual,
                Location = new Point(450, 100),
                PControl = PassData,
                //numericUpDown1 =
                //            {
                //                Visible = MultDocumento,
                //                Value = tipoApp == 1 ? Pbl.SqlDate.Year : Pbl.AnoContabil()
                //            },
                //dateTimeInput1 = { Value = tipoApp == 1 ? Pbl.SqlDate : Pbl.DataContabil() },
                Text = Titulo,
                DataNome = ((FrmClasse)MyParent).MultDocDataNome,
                Multidocumento = MultDocumento,
                Campo1Capition = ((FrmClasse)MyParent).Campo1Capition,
                Campo2Capition = ((FrmClasse)MyParent).Campo2Capition,
            };
            P2.ShowDialog();
            P2.ShowInTaskbar = true;
            //if (MyParent.WindowState == FormWindowState.Maximized)
            //{
            //    P2.ShowDialog();
            //}
            //else
            //{
            //    P2.MdiParent = MyParent.MdiParent;
            //    P2.Show();
            //}
        }
    }

    [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
    public class DMZNumeroControlDesigner : ControlDesigner
    {
        private DesignerActionListCollection _actionLists;

        // Use pull model to populate smart tag menu.
        public override DesignerActionListCollection ActionLists
        {
            get
            {
                if (null == _actionLists)
                {
                    _actionLists = new DesignerActionListCollection { new DMZNumeroControlActionList(Component) };
                }
                return _actionLists;
            }
        }
    }
    public class DMZNumeroControlActionList : DesignerActionList
    {
        private DMZNumero colUserControl;

        private DesignerActionUIService _designerActionUiSvc;

        //The constructor associates the control with the smart tag list.
        public DMZNumeroControlActionList(IComponent component) : base(component)
        {
            colUserControl = component as DMZNumero;
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
        [Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
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
        public string Name
        {
            get => colUserControl.Nome;
            set => GetPropertyByName("Nome").SetValue(colUserControl, value);
        }
        // Implementation of this abstract method creates smart tag  items, associates their targets, and collects into list.
        public override DesignerActionItemCollection GetSortedActionItems()
        {
            var items = new DesignerActionItemCollection
            {
                new DesignerActionHeaderItem("Appearance"),
                //new DesignerActionPropertyItem("BackColor", "Back Color", "Appearance","Selects the background color."),
               // new DesignerActionPropertyItem("ForeColor", "Fore Color", "Appearance","Selects the foreground color."),
                new DesignerActionPropertyItem("Value", "Value", "Appearance","SQL Table Column - Table Link"),
                new DesignerActionPropertyItem("Value2", "Value2", "Appearance","SQL Table Column - Table Link"),
                new DesignerActionPropertyItem("Label1Text", "Label Text", "Appearance","Label Text"),
                new DesignerActionPropertyItem("label1ForeColor", "label ForeColor", "Appearance","label ForeColor"),
                new DesignerActionPropertyItem("Anchor", "Anchor", "Appearance","Anchor"),
                new DesignerActionPropertyItem("Name", "Nome", "Appearance","Nome")
            };
            return items;
        }

        public void Callform()
        {
            var lista = new List<string>();
            if (colUserControl.ParentForm != null)
            {
                var props = ((FrmClasse)colUserControl.ParentForm).GetListProps().ToArray();
                lista.AddRange(props.Select(c => c.Name));
            }
            var f = new FrmCProperty { gridPreco = { DataSource = lista } };
            f.ShowDialog();
        }
    }

}
