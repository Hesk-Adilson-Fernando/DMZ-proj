using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using System;
using System.Data;
using System.Windows.Forms;

namespace DMZ.UI.Basic
{
    public partial class FrmGetData : FrmClasse2
    {
        public FrmGetData()
        {
            InitializeComponent();
        }
        CheckBox headerCheckBox = new CheckBox();
        public Action<DataTable> SendData;
        public DataTable Dt { get; set; }
        public bool InvertColunas { get; internal set; }

        private void HeaderCheckBox_Clicked(object sender, EventArgs e)
        {
            Gridui1.EndEdit();
            foreach (DataGridViewRow row in Gridui1.Rows)
            {
                var checkBox = row.Cells["Ok"] as DataGridViewCheckBoxCell;
                checkBox.Value = headerCheckBox.Checked;
            }
            Gridui1.Update();
        }

        private void FrmGetData_Load(object sender, EventArgs e)
        {
            Helper.BindGridCheckBox(Gridui1, headerCheckBox).Click += HeaderCheckBox_Clicked;
            if (Dt.HasRows())
            {
                Gridui1.SetDataSource(Dt);
                if (!InvertColunas)
                {
                    Gridui1.Columns[0].DataPropertyName = Dt.Columns[0].ColumnName;
                    Gridui1.Columns[1].DataPropertyName = Dt.Columns[1].ColumnName;
                }
                else
                {
                    Gridui1.Columns[0].DataPropertyName = Dt.Columns[1].ColumnName;
                    Gridui1.Columns[1].DataPropertyName = Dt.Columns[0].ColumnName;
                }
                Gridui1.Columns[2].DataPropertyName = Dt.Columns[2].ColumnName;
                tbTotal.Text = Dt.Rows.Count+" Registos";
            }
        }

        private void btnSeach2_Click(object sender, EventArgs e)
        {
            Gridui1.Update();
            if (Dt.CheckAny("ok"))
            {
                Dt = Dt.GetCheckedRows("ok");
                SendData.Invoke(Dt);
            }
            Close();
        }

        private void tbProcura_TextChanged(object sender, EventArgs e)
        {
            Helper.UpdateGrid(false, Gridui1, Dt, tbProcura.Text);
        }
    }
}
