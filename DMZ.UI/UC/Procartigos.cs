using System;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Controls;

namespace DMZ.UI.UC
{
    public partial class Procartigos : UserControl
    {
        public Procartigos()
        {
            InitializeComponent();
        }
        public delegate void ExecMetodo();

        public event ExecMetodo ExecMetod;
        protected virtual void OnExecMetodo()
        {
            var handler = ExecMetod;
            handler?.Invoke();
        }
        private Form _myParent;

        public string ColunasSelect { get;  set; }

        private void tbProcArtigos_KeyPress(object sender, KeyPressEventArgs e)
        {
            _myParent = ParentForm;
            var frmClasse = (FrmClasse)_myParent;
            if (frmClasse != null && !frmClasse.EditMode) return;
            if (string.IsNullOrEmpty(((TextBox)sender).Text)) return;
            if (!Helper.CheckEnterKey(sender, e)) return;
            var cProcCampo = cbDefaultproc.SelectedIndex == 0
                ? "REF": cbDefaultproc.SelectedIndex == 1 ? "Descricao" : "reforiginal";
            

            string select;
            var cond = $"where LTRIM(RTRIM(st.{cProcCampo.Trim()})) Like '{((TextBox)sender).Text.Trim()}%'";
            if (frmClasse != null && frmClasse.Noneg)
            {
                select = $@"select referenc,descricao,stk=(entrada-saida),RefOriginal,produtostamp,servico from(
                        select  LTRIM(RTRIM(referenc)) as referenc,LTRIM(RTRIM(descricao)) as descricao,
                        entrada=isnull((select sum(entrada) as ent from mstk where ref=st.ref),0),
                        saida=isnull((select sum(saida) as ent from mstk where ref=st.ref),0)
                        ,servico,ststamp  
                        from st {cond})tmp1   order by descricao ";

            }
            else
            {

                const string colunas = " LTRIM(RTRIM(referenc)) as referenc,LTRIM(RTRIM(descricao)) as descricao,servico,ststamp ";

                select = $"select {colunas} from st {cond} order by descricao ";
            }

            var tmpFound = SQLExec.GetGenDT(select);
            tbProcArtigos.Text = "";
            var linhas = tmpFound.Rows.Count;
            switch (linhas)
            {
                case 0:
                    Domsg(1);
                    break;
                case 1:
                    if (_myParent != null)
                    {
                        if (frmClasse != null) frmClasse.Addline(tmpFound.Rows[0]["produtostamp"].ToString());
                        tmpFound.Dispose();
                    }
                    break;
                default:
                    if (linhas > 1)
                    {

                        if (_myParent != null)
                        {
                            var campo1 = ColunasSelect.Split(',')[0];
                            var campo2 = ColunasSelect.Split(',')[1];
                            var campo3 = ColunasSelect.Split(',')[2];
                            //var tmpDt = frmClasse.Noneg ? tmpFound.Select().CopyToDataTable().DefaultView.ToTable(false, campo1, campo2, campo3, "servico") : tmpFound.Select().CopyToDataTable().DefaultView.ToTable(false, campo1, campo2, campo3);
                            var qr = new Querry { MdiParent = _myParent.MdiParent, StartPosition = FormStartPosition.Manual };
                            var x = (_myParent.Width - qr.Width) / 1;
                            var y = (_myParent.Height - qr.Height) / 1;
                            qr.Location = new Point(x+100, y);
                            qr.radGridView1.DataSource = null;
                            qr.radGridView1.AutoGenerateColumns = false;
                            qr.Campo1 = campo1;
                            qr.Campo2 = campo2;
                            qr.Campo3 = campo3;
                            qr.PControl = PassData;
                            if (frmClasse != null) qr.ShowStk = frmClasse.Noneg;
                            qr.Width1 = 90; 
                            qr.Width2 = 270;
                            qr.Caption1 = "Código";
                            qr.Caption2 = "Descrição";
                            //qr.radGridView1.DataSource = tmpDt;
                            qr.radGridView1.DataSource = tmpFound;
                            qr.labelX1.Text = tmpFound.Rows.Count + @" registos encontados";
                            qr.Show();
                        }
                    }
                    break;
            }
            
        }
        private static void Domsg(int nMsgbox)
        {
            if (nMsgbox == 1)
            {
                MsBox.Show(@"A sua procura não encontrou resultado!!");
            }
        }

        private void PassData(string sender)
        {
            ((FrmClasse) _myParent)?.Addline(sender);
        }

        private void Procartigos_Load(object sender, EventArgs e)
        {
            cbDefaultproc.Items.Add("Referência");
            cbDefaultproc.Items.Add("Descrição");
            cbDefaultproc.SelectedIndex = 1;
        }
    }
}
