using System;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.UI.Basic;
using DMZ.UI.Controls;

namespace DMZ.UI.UC
{
    public partial class Procura2 : UserControl
    {
        public Procura2()
        {
            InitializeComponent();
        }
        private void btnProcura2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Campo)) return;

            MyParent = ParentForm;
            var editeMode = MyParent != null && ((FrmClasse) MyParent).EditMode;
            if (editeMode) return;
            if (MyParent == null) return;
            var tabela = ((FrmClasse)MyParent).Ctabela;
            int tipoApp = ((FrmClasse)MyParent).TipoApp;
            MultDocumento = ((FrmClasse)MyParent).MultiDoc;
            var dt = SQLExec.GetGenDT($"SELECT TABLE_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE COLUMN_NAME='{Campo}' and TABLE_NAME ='{tabela}' ");
            if (dt.Rows.Count>0)
            {
                var campo1 = ((FrmClasse)MyParent).Campo1;
                var campo2 = ((FrmClasse) MyParent).Campo2;
                if (((FrmClasse)MyParent).CCondicao !=null)
                {
                    Condicao = ((FrmClasse) MyParent).CCondicao;
                }
                var form = Application.OpenForms["Proc2"];
                if (form != null)
                {
                    form.Dispose();
                    ProcedForm(tabela, tipoApp, campo1, campo2);
                    //MsgBox.Show("O form ja está aberto");
                }
                else
                {
                    ProcedForm(tabela, tipoApp, campo1, campo2);
                }
            }
            else
            {
                MsBox.Show(@"Parâmetros não configurados!");
            }
        }

        private void ProcedForm(string tabela, int tipoApp, string campo1, string campo2)
        {
            P2 = new Proc2(tabela, campo1, campo2, Campo, Condicao)
            {
                StartPosition = FormStartPosition.Manual,
                Location = new Point(450, 100),
                PControl = PassData,
                numericUpDown1 =
                        {
                            Visible = MultDocumento,
                            Value = tipoApp == 1 ? Pbl.SqlDate.Year : Pbl.AnoContabil()
                        },
                //dateTimeInput1 = { Value = tipoApp == 1 ? Pbl.SqlDate : Pbl.DataContabil() },
                Text = Titulo,
                DataNome = ((FrmClasse)MyParent).MultDocDataNome,
                Multidocumento = MultDocumento
            };
            if (MyParent.WindowState == FormWindowState.Maximized)
            {
                //P2.WindowState = FormWindowState.Normal;
                //P2.MdiParent = MyParent.MdiParent;
                //P2.Show();
                //P2.Activate(); 
                //MyParent.WindowState = FormWindowState.Maximized;
                P2.ShowDialog();
            }
            else
            {
                P2.MdiParent = MyParent.MdiParent;
                P2.Show();
            }
        }

        private void PassData(object sender, int posicao)
        {
            if (MyParent.GetType().GetMethod("PassData2") != null)
            {
                MyParent.GetType().InvokeMember("PassData2", BindingFlags.InvokeMethod, null, MyParent, new[] {sender, posicao});
            }
            else
            {
                ((FrmClasse) MyParent).GenTable = (DataTable) sender;
                ((FrmClasse) MyParent).Indice = posicao;
                ((FrmClasse)MyParent).PreencheCampos(((FrmClasse)MyParent).GenTable, ((FrmClasse)MyParent).Indice);
            }
            ((FrmClasse)MyParent).Procurou = true;
        }

        private void procura2_Load(object sender, EventArgs e)
        {       
            //Titulo = "Procurar Registos";
        }

        private Proc2 P2 { get; set; }

        public string Titulo { get; set; }

        private Form MyParent { get; set; }

        public string Campo { get; set; }

        public string Condicao { get; set; } = string.Empty;

        public bool MultDocumento { get; set; }

    }
}
