using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DMZ.BL.Classes;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Generic;

namespace DMZ.UI.UI
{
    public partial class FrmAddfc : FrmClasse2
    {
        public FrmAddfc()
        {
            InitializeComponent();
        }
        public void Alert(string msg, Form_Alert.EnmType type)
        {
            var frm = new Form_Alert();
            frm.ShowAlert(msg,type);
        }
        private void FrmAddfc_Load(object sender, EventArgs e)
        {
            gridDeb.Condicao = "1=0";
            gridDeb.BindGridView();
            dmzProcura2.tb1.Text = Pbl.Usr.Ccusto;
            dmzProcura2.Text2 = Pbl.Usr.Codccu;
        }

        private void btnProcura_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dmzProcura1.Text2))
            {
                gridDeb.Condicao = $"no={dmzProcura1.Text2.Trim()} and oristamp='FTIMPORT'";
                gridDeb.BindGridView();
            }
            else
            {
                MsBox.Show("Deve indicar o fornecedor e Centro de custo!");
            }
        }

        private void gridPanel21_AfterAddLineEvent()
        {
            if (gridDeb.CurrentRow == null) return;
            gridDeb.CurrentRow.Cells["nome"].Value = dmzProcura1.tb1.Text;
            gridDeb.CurrentRow.Cells["no"].Value = dmzProcura1.Text2;
            gridDeb.CurrentRow.Cells["origem"].Value = "CP"; //documento
            gridDeb.CurrentRow.Cells["documento"].Value = "V/Factura"; //
            gridDeb.CurrentRow.Cells["ccusto"].Value = dmzProcura2.tb1.Text; //Moeda
            gridDeb.CurrentRow.Cells["Moeda"].Value = "MZN"; //
            gridDeb.CurrentRow.Cells["Faccstamp"].Value = null; //
            gridDeb.CurrentRow.Cells["oristamp"].Value = "CPIMPORT"; //
        }

        private bool gridPanel21_BeforeAddLineEvent()
        {
            if (!string.IsNullOrEmpty(dmzProcura1.tb1.Text) && !string.IsNullOrEmpty(dmzProcura2.tb1.Text))
            {
                return false;
            }
            MsBox.Show("Porfavor indica o fornecedor  ou centro de custo acima!");
            return true;
        }

        private bool gridPanel21_SaveEvent()
        {
            var dt = gridDeb.DataSource as DataTable;
            if (dt == null) return true;
            if (SQL.Save(dt, "fcc", false, "", "").numero != 1) return true;
            var lista = new List<SqlParameter>();
            var p0 = new SqlParameter {SqlDbType = SqlDbType.Char, ParameterName = "@Nometabela", Value = "fnc"};
            lista.Add(p0);
            var p1 = new SqlParameter {SqlDbType = SqlDbType.Decimal, ParameterName = "@no", Value = $"{dmzProcura1.Text2}"};
            lista.Add(p1);
            SQL.SqlSP("UpdSaldo",lista);
            Alert("Gravado com sucesso", Form_Alert.EnmType.Success);
            return true;
        }

        private void gridDeb_AfterDeleteLineEvent()
        {
            var lista = new List<SqlParameter>();
            var p0 = new SqlParameter {SqlDbType = SqlDbType.Char, ParameterName = "@Nometabela", Value = "fnc"};
            lista.Add(p0);
            var p1 = new SqlParameter {SqlDbType = SqlDbType.Decimal, ParameterName = "@no", Value = $"{dmzProcura1.Text2}"};
            lista.Add(p1);
            SQL.SqlSP("UpdSaldo",lista);
            Alert("Gravado com sucesso", Form_Alert.EnmType.Success);
        }

        private void gridDeb_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (gridDeb.CurrentRow==null) return;
            Helper.SetDateTimePicker(gridDeb);
        }

        private void gridDeb_CellEnter(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (!gridDeb.CurrentCell.OwningColumn.DataPropertyName.Equals("data") && !gridDeb.CurrentCell.OwningColumn.DataPropertyName.Equals("vecin"))
            {
                Helper.CellEnter(sender,e);  
            }
        }
    }
}
