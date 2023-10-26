using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
namespace DMZ.UI.UI
{
    public partial class FrmReg : Basic.FrmClasse2
    {
        public FrmReg()
        {
            InitializeComponent();
        }

        public DataTable Tabela { get;  set; }
        public delegate void PassParam(DataTable tabela);
        public bool OrigemDoc { get; set; }
        public int Origemsssss { get; set; }

        public  PassParam SendData;
        private void FrmReg_Load(object sender, EventArgs e)
        {
            gridUi1.SetDataSource(Tabela);
            foreach (DataGridViewColumn col in gridUi1.Columns)
            {
                var ca = col.Name.ToLower();
                var regusss = "ValRegularizado".ToLower();
                if (!ca.Equals(regusss) && !col.Name.ToLower().Equals("ok"))
                {
                    col.ReadOnly = true;
                }
            }
            tbTotalDocums.Text=Tabela.AsEnumerable().Sum(x => x.Field<decimal>("valorpreg")).ToString().SetMask();
            if (tbTotalDocums.Text.IsNullOrEmpty())
            {
                tbTotalDocums.Text = "0.00";
            }
            tbValorIntrod.Text = Tabela.Rows.Count.ToString();
            SetVisivel();
            if (Origemsssss == 1)
            {
                deb.Visible = cre.Visible = tipo.Visible = true;
                Moeda.Visible=tipo.Visible = false;
            }
            if (Origemsssss != 1)
            {
                tipo.Visible = deb.Visible = cre.Visible = tipo.Visible = false;
                Moeda.Visible =  false;
            }
           
        }

        private void SetVisivel()
        {
            tbContador.Visible = OrigemDoc;
            tbTotalDocums.Visible = OrigemDoc;
            tbValorReg.Visible = OrigemDoc;
            btnAceitar.Visible = OrigemDoc;
            tbValorIntrod.Visible = OrigemDoc;
            if (gridUi1 == null) return;
            gridUi1.Columns["ValRegularizado"].Visible = OrigemDoc;
            gridUi1.Columns["OK"].Visible = OrigemDoc;
        }

        private void btnIntrodValor_Click(object sender, EventArgs e)
        {
            Processar();
        }

        private void Processar()
        {
            if (string.IsNullOrEmpty(tbValorIntrod.Text)) return;
            if (gridUi1.Rows.Count<0) return;
            var valor = tbValorIntrod.Text.ToDecimal();
            decimal sum = 0;
            var contagem = 0;
            for (var i = 0; i < gridUi1.Rows.Count; ++i)
            {
                sum += gridUi1.Rows[i].Cells["ValorporReg"].Value.ToDecimal();
            }
            if (sum<valor)
            {
                MsBox.Show("O Valor é maior que somatório, por favor verifique!");
                return;
            }
            foreach (DataGridViewRow row in gridUi1.Rows)
            {
                if (row == null) continue;
                if (valor>0)
                {
                    var val = row.Cells["ValorporReg"].Value.ToDecimal();
                    if (val >= valor)
                    {
                        row.Cells["ValRegularizado"].Value = valor;
                    }
                    else
                    {
                        row.Cells["ValRegularizado"].Value = val;      
                    }
                    valor = valor - val;
                    row.Cells["OK"].Value = true;
                    gridUi1.Update();
                }
                else
                {
                    break;
                }               
            }
            gridUi1.BeginEdit(false);
            tbContador.Text =GetTotal();
            tbValorReg.Text = tbValorIntrod.Text;
            tbValorIntrod.Text="";
        }

        private string GetTotal()
        {
            decimal contador = 0;
            foreach (DataGridViewRow r in gridUi1.Rows)
            {
                if (r == null) continue;
                if (r.Cells["OK"].Value.ToDecimal()==1)
                {
                    contador++;
                }
            }
            return contador.ToString();
        }

        private void UpdateValues()
        {
            var nome = gridUi1.CurrentCell.OwningColumn.Name;
            if (nome.Equals("OK"))
            {
                gridUi1.EndEdit();
                Somatorio();
            }
            else if (nome.Equals("ValRegularizado"))
            {
                gridUi1.CurrentRow.Cells["OK"].Value = true;
                gridUi1.Update();
                Somatorio();
            }
        }

        private void Somatorio()
        {
            if (Tabela.HasRows())
            {
                gridUi1.Update();
                if (Tabela.AsEnumerable().Any(x=>x.Field<bool?>("ok2").Equals(true)))
                {
                    tbContador.Text = Tabela.AsEnumerable().Where(x => x.Field<bool?>("ok2").Equals(true)).CopyToDataTable().Rows.Count.ToString();
                    var valor = Tabela.AsEnumerable().Where(x => x.Field<bool?>("ok2").Equals(true)).Sum(x => x.Field<decimal>("valorreg"));
                    tbValorReg.Text = valor.ToString().SetMask();
                    if (tbValorReg.Text.IsNullOrEmpty())
                    {
                        tbValorReg.Text = "0.00";
                    }
                }
                else
                {
                    tbContador.Text = "0";
                    tbValorReg.Text = "0";
                }
            }
            else
            {
                tbContador.Text = "0";
                tbValorReg.Text = "0";     
            }
        }

        private void btnAceitar_Click(object sender, EventArgs e)
        {
            if (Tabela == null) return;
            var dt = Tabela.GetTable("ok2= 1");
            if (!dt.HasRows()) return;
            SendData(dt);
            Close();
            //var moedae = dt.AsEnumerable().Any(x => !x.Field<string>("moeda").Trim().Equals(Pbl.MoedaBase.Trim()));
            //if (moedae)
            //{
            //    MsBox.Show(Messagem.ParteInicial() + "Não pode emitir recibo de facturas de moedas diferentes!");
            //}
            //else
            //{
            //    SendData(dt);
            //    Close();
            //}
        }

        private void gridUi1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            if (gridUi1.CurrentRow == null) return;
            var nome = gridUi1.CurrentCell.OwningColumn.Name;
            if (nome.Equals("ValRegularizado"))
            {
                if (gridUi1.CurrentRow.Cells["Origem"].Value.ToString().Trim().ToUpper() == "NC" ||
                    gridUi1.CurrentRow.Cells["Origem"].Value.ToString().Trim().ToUpper() == "NCF" ||
                    gridUi1.CurrentRow.Cells["Rcladiant"].Value.ToBool())
                {
                    if (gridUi1.CurrentCell.Value.ToDecimal() > 0)
                    {
                        gridUi1.CurrentCell.Value = gridUi1.CurrentCell.Value.ToDecimal() * -1;
                    }
                }
                gridUi1.Update();
                UpdateValues();
            }
        }

        private void tbValorIntrod_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Processar(); 
            }
        }

        private void tbProcura_TextChanged(object sender, EventArgs e)
        {
            Helper.UpdateGrid(false, gridUi1, Tabela, tbProcura.Text, "descricao");
        }

        private void cbDefault1_CheckedChangeds()
        {
            //OK
            gridUi1.CheckUncheckAll("OK", cbDefault1.cb1.Checked);
            gridUi1.Update();
            Somatorio();
        }

        private void gridUi1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridUi1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUi1.CurrentRow == null) return;
            gridUi1.Update();
            UpdateValues();
        }
    }
}
