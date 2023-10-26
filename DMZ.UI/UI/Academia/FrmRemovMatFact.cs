using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMZ.UI.UI.Academia
{
    public partial class FrmRemovMatFact : FrmClasse2
    {
        public FrmRemovMatFact()
        {
            InitializeComponent();
        }

        private void FrmRemovMat_Load(object sender, EventArgs e)
        {
            EditMode=true;
        }
        private DataTable _dt;
        public TRcl _tmpTRcl;

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbCl.tb1.Text))
            {
                MsBox.Show("Por favor indica o aluno!..");
                return;
            }

            _dt = GenBl.GetCc(tbCl.Text3.Trim(), "ClCCF", "cl");
            var dc2 = new DataColumn { DataType = typeof(bool), ColumnName = "Ok2" ,
                ReadOnly=false,DefaultValue=false};
            _dt.Columns.Add(dc2);
            
            gridUiAlunos.SetDataSource(_dt);
            tbTotal.Text="0";
            if (_dt.HasRows())
            {
                tbTotal.Text=gridUiAlunos.DtDS.Sum("valorpreg").ToDecimal().ToString();
            }
            else
            {
                MsBox.Show("O Aluno não tem movimentos");
            }
        }

        private void GetValue(DataRow r)
        {
           // Helper.TotaisFt(_rcll, r, _rcl.Rclstamp, "rcl");
        }
        decimal Total;
        DataTable _rcll;
        public void ReceiveData(DataTable dataRows)
        {
            _rcll = gridUiAlunos.DataSource as DataTable;
            if (dataRows != null)
                Total = 0;
            foreach (var r in dataRows.AsEnumerable().Where(r => r != null))
            {
                GetValue(r);
            }
            if (_rcll != null)
            {
                foreach (var r in _rcll.AsEnumerable().Where(r => r != null))
                {
                    Total += r["valorreg"].ToDecimal();
                }

                if (Total<0)
                {
                    tbTotal.Text = (-1*Total).ToString();
                }
                else
                {
                    tbTotal.Text = Total.ToString();
                }
            }
            
            gridUiAlunos.SetDataSource(_dt);
        }
        private void UpdateValues()
        {
            var nome = gridUiAlunos.CurrentCell.OwningColumn.Name;
            if (nome.Equals("NurmeroRepeticoes"))
            {
                gridUiAlunos.CurrentRow.Cells["NurmeroRepeticoes"].Value = true;
                gridUiAlunos.Update();
                gridUiAlunos.EndEdit();
                Somatorio();
            }
        }
        private void Somatorio()
        {
            var Tabela = gridUiAlunos.GetBindedTable();
            if (Tabela.HasRows())
            {
                gridUiAlunos.Update();
                if (Tabela.AsEnumerable().Any(x => x.Field<bool?>("ok2").Equals(true)))
                {
                    tbTotal.Text = Tabela.AsEnumerable().Where(x => x.Field<bool?>("ok2").Equals(true)).CopyToDataTable().Rows.Count.ToString();
                    var valor = Tabela.AsEnumerable().Where(x => x.Field<bool?>("ok2").Equals(true)).Sum(x => x.Field<decimal>("valorreg"));
                    tbTotal.Text = valor.ToString().SetMask();
                    if (tbTotal.Text.IsNullOrEmpty())
                    {
                        tbTotal.Text = "0.00";
                    }
                }
                else
                {
                    //tbTotal.Text = "0";
                    tbTotal.Text = "0";
                }
            }
            else
            {
                //tbContador.Text = "0";
                tbTotal.Text = "0";
            }
        }
        private void btnRemoveFact_Click(object sender, EventArgs e)
        {
            var dt = gridUiAlunos.GetBindedTable();
            dt=dt.GetTable("Ok=1");
            if (dt.HasRows())
            {
                var quer = "";
                try
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        try
                        {
                            if (string.IsNullOrEmpty(quer))
                            {
                                quer = $"\r\ndelete from fact where factstamp='{item["ccstamp"]}'";
                            }
                            else
                            {
                                quer += $"\r\ndelete from fact where factstamp='{item["ccstamp"]}'";
                            }                          
                        }
                        catch (Exception ex)
                        {
                            continue;
                        }

                    }
                    if (!string.IsNullOrEmpty(quer))
                    {
                        SQL.SqlCmd(quer);
                    }
                    MsBox.Show($"{Messagem.ParteInicial()} As Propinas foram removidas do sistema.");
                    btnProcurar_Click(sender, e);
                }
                catch (Exception ex)
                {

                    //throw;
                }
            }
            else
            {

                MsBox.Show($"{Messagem.ParteInicial()}Todas facturas duplicadas ja foram removidas do sistema.");
            }
        }

        private void gridUiAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUiAlunos.CurrentRow == null) return;
            gridUiAlunos.Update();
            UpdateValues();
        }
    }
}
