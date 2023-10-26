using System;
using System.Data;
using System.Windows.Forms;
using DMZ.BL.Classes;

namespace DMZ.UI.UC
{
    public partial class PanelSearch : UserControl
    {
        public PanelSearch()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (cb1.Checked)
            {
                btnCheck.Image = Properties.Resources.Unchecked_Checkbox_23px;
                cb1.Checked = false;
            }
            else
            {
                btnCheck.Image = Properties.Resources.Checked_Checkbox_2_23px;
                cb1.Checked = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //TextBox auto = sender as TextBox; 
            //if (auto == null) return;
            textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            var data = new AutoCompleteStringCollection();
            FillItems2(data);
            textBox1.AutoCompleteCustomSource = data;
        }
        private void FillItems2(AutoCompleteStringCollection data)
        {
            var qry = "SELECT ltrim(rtrim(sigla))+'   '+ltrim(rtrim(cast(numero as Char(20))))+'  '+ltrim(rtrim(Moeda)) as Descconta, tipo,codigo,sigla,banco,saldo,codtipo from contas";
            var dtContas = SQLExec.GetGenDT(qry);
            if (dtContas?.Rows.Count > 0)
            {
                foreach (var row in dtContas.AsEnumerable())
                {

                    if (row == null) continue;
                    data.Add(row["Descconta"].ToString());
                }
            }
        }

    }
}
