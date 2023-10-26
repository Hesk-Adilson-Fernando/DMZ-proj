﻿using System;
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
using DMZ.UI.Generic;

namespace DMZ.UI.UC
{
    [Designer(typeof(TextBoxControlDesigner))]
    public partial class DMZTexBoxX : UserControl
    {
        public DMZTexBoxX()
        {
            InitializeComponent();
        }
        public delegate void TextChangValue();
        //Cria um evento
        public event TextChangValue TextChangValues;
        //public event 
        protected virtual void OnTextChangValue()
        {
            var handler = TextChangValues;
            handler?.Invoke();
        }
        [Description("Indica se ouve mudança no textbox")]
        public bool ValueChange { get; set; }

        [Description("ControlSourse do TextBox")]
        public string Value { get; set; }

        [Description("ControlSourse do Campo2")]
        public string Value2 { get; set; }
        [Description("É o Campo2")]
        public string Text2 { get; set; } = string.Empty;
        [Description("É o Campo3")]
        public string Text3 { get; set; } = string.Empty;
        public bool InPutMask { get; set; }
        public bool IsNumeric { get; set; }
        public bool IsMatricula { get; set; }
        public bool IsTelephone { get; set; }
        public bool IsEmail { get; set; }
        [Description("Quando 'true' é campo obrigatório")]
        public bool Obrigatorio { get; set; }
        public bool AutoComplete { get; set; }
        [Description("Quando 'true' é Campo de Numeração automática")]
        public bool AutoIncrimento { get; set; }
        [Description("Tabela de busca do campo")]
        public string Tabela { get; set; }
        [Description("Campos do 'sql' máximo 3 separados por ','")]
        public string Selected { get; set; }
        [Description("Quando 'true' campo de leitura apenas")]
        public bool IsReadOnly { get; set; }
        public int MaxLength { get; set; }
        public bool IsMaxLength { get; set; }
        private Form MyParent { get; set; }
        public string Condicao { get; set; } = string.Empty;
        private Proc2 P2 { get; set; }

        public string Titulo { get; set; }
        public bool MultDocumento { get; set; }
        public bool MultiLinhas
        {
            get => tB1.Multiline;
            set => tB1.Multiline = value;
        }
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
        [Description("Muda a cor do fundo do textbox")]
        public Color TextBoxBackColor
        {
            get => tB1.BackColor;
            set => tB1.BackColor = value;
        }

        [Description("Muda a cor do texto do textbox")]
        public Color TextBoxForeColor
        {
            get => tB1.ForeColor;
            set => tB1.ForeColor = value;
        }
        [Description("Muda a cor do texto do textbox")]
        public ScrollBars TextBoxScrollBars
        {
            get => tB1.ScrollBars;
            set => tB1.ScrollBars = value;
        }
        public AnchorStyles TextBox1Anchor
        {
            get => tB1.Anchor;
            set => tB1.Anchor = value;
        }
        public AnchorStyles Label1Anchor
        {
            get => label1.Anchor;
            set => label1.Anchor = value;
        }
        [EditorAttribute(typeof(MultilineStringEditor), typeof(UITypeEditor))]
        public string Label1Text
        {
            get => label1.Text;
            set => label1.Text = value;
        }
        [EditorAttribute(typeof(MultilineStringEditor), typeof(UITypeEditor))]
        public string Label1Text2 { get; set; }
        public bool IsUnique { get; set; } //Inicia que esse campo nao pode repetir

        public bool Tb1IsPassword
        {
            get => tB1.UseSystemPasswordChar;
            set => tB1.UseSystemPasswordChar = value;
        }
        public HorizontalAlignment Tb1TextAlign
        {
            get => tB1.TextAlign;
            set => tB1.TextAlign = value;
        }
        public Font Tb1Font
        {
            get => tB1.Font;
            set => tB1.Font = value;
        }

        public string Nome
        {
            get => Name;
            set => Name = value;
        }

        public bool ToUpperCase { get; set; }

        private void DMZTexBoxX_Load(object sender, EventArgs e)
        {

        }


        public void ExecutaHighLigth(bool origem = false)
        {
            if (!origem)
            {
                tB1.BackColor = string.IsNullOrEmpty(tB1.Text) ? Color.Red : Color.White;
            }
            else
            {
                tB1.BackColor = Color.White;
            }

        }

        public void SetIncrimento(string valor) => tB1.Text = valor;

        public void CheckEmail(TextBox txt)
        {
            if (string.IsNullOrEmpty(txt.Text)) return;
            var numer = (from str in txt.Text where char.IsPunctuation(str) select str.ToString()).Where(x => x.Equals("@")).ToList();
            tB1.BackColor = numer.Count == 0 ? Color.Red : Color.White;
        }

        private void tB1_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tB1.Text))
            {
                tB1.BackColor = Color.White;
            }
            if (IsNumeric)
            {
                tB1.Text = tB1.Text.SetMask();
            }
            if (IsNuit)
            {
                if (tB1.Text.Length > 0)
                {
                    if (tB1.Text.ToDecimal() == 0)
                    {
                        MsBox.Show("O NUIT deve ter números apenas!");
                        tB1.Text = "";
                    }
                }

            }
            if (IsMatricula)
            {
                var matricula = tB1.Text;
                var inicio = matricula.Substring(0, 3).ToUpper();
                var medio = matricula.Substring(3, 3).ToUpper();
                var fim = matricula.Substring(6, 2).ToUpper();
                tB1.Text = $@"{inicio}-{medio}-{fim}";
            }
            if (IsEmail)
            {
                CheckEmail(tB1);
            }
            if (IsTelephone)
            {
                CheckTelephone(tB1);
            }
            if (!IsMaxLength) return;
            if (tB1.Text.Length > MaxLength)
            {
                CheckMaxLength(tB1);
            }
            else
            {
                tB1.BackColor = Color.White;
            }
        }

        public bool IsNuit { get; set; }

        private void CheckMaxLength(Control txt)
        {
            MsBox.Show($@" O número máximo de caracteres é: {MaxLength}");
            txt.Text = "";
            tB1.BackColor = Color.Red;
        }

        private void CheckTelephone(Control txt)
        {
            if (string.IsNullOrEmpty(txt.Text)) return;
            if (txt.Text.Length < 9)
            {
                tB1.BackColor = Color.Orange;
            }
            else
            {
                var numer = BL.Classes.Extensions.CToD(txt.Text.Substring(0, 2));
                if (numer == 82 || numer == 84 || numer == 86 || numer == 87 || numer == 25)
                {
                    tB1.BackColor = Color.Red;
                }
                else
                {
                    tB1.BackColor = Color.Orange;
                }
            }
        }

        private void tB1_TextChanged(object sender, EventArgs e)
        {
            if (ToUpperCase)
            {
                tB1.Text = tB1.Text.ToUpper();
                tB1.Select(tB1.Text.Length, 0);
            }
            if (InPutMask)
            {
                tB1.Text = BL.Classes.Extensions.SetMask(tB1.Text);
            }

            OnTextChangValue();
            if (!(ParentForm is FrmClasse)) return;
            if (!((FrmClasse)ParentForm).Procurou) return;
            //if (!((FrmClasse)ParentForm).Procurou) return;
            if (((FrmClasse)ParentForm).Lista == null)
            {
                ((FrmClasse)ParentForm).Lista = new List<string> { label1.Text };
            }
            else if (!((FrmClasse)ParentForm).Lista.Exists(x => x.Trim().Equals(label1.Text.Trim())))
            {
                ((FrmClasse)ParentForm).Lista.Add(label1.Text);
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
    }

    [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
    public class TextBoxControlDesigner : ControlDesigner
    {
        private DesignerActionListCollection _actionLists;

        // Use pull model to populate smart tag menu.
        public override DesignerActionListCollection ActionLists
        {
            get
            {
                if (null == _actionLists)
                {
                    _actionLists = new DesignerActionListCollection { new TbControlActionList(Component) };
                }
                return _actionLists;
            }
        }
    }
    public class TextBoxControlActionList : DesignerActionList
    {
        private TbDefault colUserControl;

        private DesignerActionUIService _designerActionUiSvc;

        //The constructor associates the control with the smart tag list.
        public TextBoxControlActionList(IComponent component) : base(component)
        {
            colUserControl = component as TbDefault;
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
            get => colUserControl.TextBoxBackColor;
            set => GetPropertyByName("TextBoxBackColor").SetValue(colUserControl, value);
        }

        public Color ForeColor
        {
            get => colUserControl.TextBoxForeColor;
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
                new DesignerActionPropertyItem("Anchor", "Anchor", "Appearance",
                    "Anchor"),
                new DesignerActionPropertyItem("Name", "Nome", "Appearance",
                    "Nome")
            };
            return items;
        }

        //public void Callform()
        //{
        //    var lista = new List<string>();
        //    if (colUserControl.ParentForm != null)
        //    {
        //        var props = ((FrmClasse)colUserControl.ParentForm).GetListProps().ToArray();
        //        lista.AddRange(props.Select(c => c.Name));
        //        //lista.AddRange(props.Select(p => p.Name));
        //    }
        //    var f = new FrmCProperty { gridPreco = { DataSource = lista } };
        //    f.ShowDialog();
        //}
    }
}
