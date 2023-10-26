using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;


namespace DMZ.UI.UI
{
    public partial class FrmCopylinhas : Basic.FrmClasse2
    {
        public FrmCopylinhas()
        {
            InitializeComponent();
        }
        CheckBox headerCheckBox = new CheckBox();
        public Action<DataTable,DataTable,string,bool> SendData;

        public string Tabela { get; private set; }

        private void BindGrid()
        {
            var headerCellLocation = gridUIFt2.GetCellDisplayRectangle(0, -1, true).Location;
            headerCheckBox.Location = new Point(headerCellLocation.X + 8, headerCellLocation.Y + 2);
            headerCheckBox.BackColor = Color.White;
            headerCheckBox.Size = new Size(18, 18);
            headerCheckBox.BackColor = Color.FromArgb(34, 39, 49);
            headerCheckBox.Click += HeaderCheckBox_Clicked;
            gridUIFt2.Controls.Add(headerCheckBox);
            gridUIFt2.CellContentClick += DataGridView_CellClick;
        }

        private void HeaderCheckBox_Clicked(object sender, EventArgs e)
        {
            gridUIFt2.EndEdit();
            foreach (DataGridViewRow row in gridUIFt2.Rows)
            {
                var checkBox = row.Cells["checkBoxColumn"] as DataGridViewCheckBoxCell;
                checkBox.Value = headerCheckBox.Checked;
            }
        }
        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ////Check to ensure that the row CheckBox is clicked.
            //if (e.RowIndex < 0 || e.ColumnIndex != 0) return;
            ////Loop to verify whether all row CheckBoxes are checked or not.
            //var isChecked = true;
            //foreach (DataGridViewRow row in gridUIFt2.Rows)
            //{
            //    if (row.Cells["checkBoxColumn"].EditedFormattedValue.ToBool()) continue;
            //    isChecked = false;
            //    break;
            //}
            //headerCheckBox.Checked = isChecked;

            if (gridUIFt1.CurrentCell.OwningColumn.Name.Equals("checkBoxColumn"))
            {
                Helper.UpdateChecked(gridUIFt1, "checkBoxColumn");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmDevolucao_Load(object sender, EventArgs e)
        {
            ano.Value = Pbl.SqlDate.Year;
            BindGrid();
        }

        private void btnProcura_Click(object sender, EventArgs e)
        {
            string filtro = null;
            if (!cliente.tb1.Text.IsNullOrEmpty())
            {
                filtro = $" no ={cliente.Text2.ToDecimal()}";
            }
            if (!documento.tb1.Text.IsNullOrEmpty())
            {
                if (filtro.IsNullOrEmpty())
                {
                    filtro = $" numdoc ={documento.Text2.ToDecimal()}"; 
                }
                else
                {
                    filtro += $" and numdoc ={documento.Text2.ToDecimal()}";
                }
            }
            if (ano.Value>0)
            {
                if (string.IsNullOrEmpty(filtro))
                {
                    filtro =  $" year(data) ={ano.Value}";
                }
                else
                {
                    filtro += $" and year(data) ={ano.Value}";    
                }
            }
            if (tbNumero.Value>0)
            {
                if (filtro.IsNullOrEmpty())
                {
                    filtro = $" numero ={tbNumero.Value}";
                }
                else
                {
                    filtro += $" and numero ={tbNumero.Value}";      
                }

            }
            if (dmzEntreDatas1.checkBox1.Checked)
            {
                if (filtro.IsNullOrEmpty())
                {
                    filtro = Helper.EntreDatas(dmzEntreDatas1.dt1.Value,dmzEntreDatas1.dt2.Value);
                }
                else
                {
                    filtro += $" and {Helper.EntreDatas(dmzEntreDatas1.dt1.Value,dmzEntreDatas1.dt2.Value)}";      
                }
            }
            if (!filtro.IsNullOrEmpty())
            {
                filtro = $"where {filtro}";
            }
            var campos = $"Nomedoc, numero,data, total, nome,no,{Tabela.Trim()}stamp as stamp,ok=cast(0 as bit)";
            var str = $"select {campos} from {Tabela} {filtro}";
            QryPrc=gridUIFt1.SetDataSource(str);
            gridUIFt2.DataSource = null;
        }

        public DataTable QryPrc { get; set; }
        public string Campos { get; set; }

        private void gridUIFt1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUIFt1.CurrentRow == null) return;
            if (gridUIFt1.CurrentCell.OwningColumn.Name.Equals("sel"))
            {
                Helper.UpdateChecked(gridUIFt1, "sel");
            }
            var stamp = gridUIFt1.CurrentRow.Cells["stamp"].Value.ToString();
            string querry;
            if (!Campos.IsNullOrEmpty())
            {
                //querry = Campos;
                querry = $" select {Campos},ok=cast(0 as bit) from {Tabela.Trim()}l where {Tabela.Trim()}stamp = '{stamp.Trim()}' and (Quant-quant2)>0";
            }
            else
            {
                querry = $"select *,ok=cast(0 as bit) from {Tabela.Trim()}l where {Tabela.Trim()}stamp = '{stamp.Trim()}'";
            }    
            
             gridUIFt2.SetDataSource(querry);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gridUIFt1.Update();
            gridUIFt2.Update();
            var dt = gridUIFt2.GetBindedTable();
            var dt2 =gridUIFt1.GetBindedTable();
                if (dt.HasRows())
                {
                    var dtCopy = dt.Where(typeof(bool),"ok","true");
                    if (dtCopy.HasRows())
                    {
                        dt2 = dt2.Where(typeof(bool), "ok", "true");
                        SendData.Invoke(dtCopy,dt2,Tabela,cbFactura.cb1.Checked);
                        Close();
                    }
                    else
                    {
                        MsBox.Show(Messagem.ParteInicial()+"Não indicou a linha a copiar, Software efectuará ligação com o primeiro documento acima apenas");
                        SendData.Invoke(null,dt2,Tabela,cbFactura.cb1.Checked);
                        Close();
                    }
                }
                else
                {
                    MsBox.Show(Messagem.ParteInicial()+"Na primeira tabela não tem nenhum documento selecionado ou o documento não tem linhas!..");     
                }
        }

        private void cbDefault20_CheckedChangeds()
        {
            if (cbVendas.cb1.Checked)
            {
                BindQuerryData("cl", "tdoc","fact") ; 
            }
           
        }

        void BindQuerryData(string entidade, string todcname,string tabela)
        {
            cliente.SqlComandText="";
            documento.SqlComandText="";
            cliente.SqlComandText=$"select no,nome from {entidade}";
            documento.SqlComandText=$"select numdoc,Descricao from {todcname} order by numdoc";
            Tabela=tabela;
            switch (tabela.ToLower())
            {
                case"fact":
                    cliente.label1.Text=@"CLIENTE";
                    gridUIFt1.Columns["nome"].HeaderText="Cliente";
                    break;
                case"di":
                    cliente.label1.Text=@"CLIENTE";
                    gridUIFt1.Columns["nome"].HeaderText="Cliente";
                    break;
                case"facc":
                    cliente.label1.Text=@"FORNECEDOR";
                    gridUIFt1.Columns["nome"].HeaderText=@"Fornecedor";
                    break;
            }
        }

        private void cbDefault8_CheckedChangeds()
        {
            if (cbCompras.cb1.Checked)
            {
                BindQuerryData("fnc", "tdocf","facc") ; 
            }
        }

        private void cbDefault19_CheckedChangeds()
        {
            if (cbDossierInterno.cb1.Checked)
            {
                BindQuerryData("cl", "tdi","di") ; 
            } 
        }

        private void cbDefault20_Click(object sender, EventArgs e)
        {
           
        }

        private void cbDefault19_Click(object sender, EventArgs e)
        {
            
        }

        private void cbDefault8_Load(object sender, EventArgs e)
        {
            
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbProcura_TextChanged(object sender, EventArgs e)
        {
            Helper.UpdateGrid(false, gridUIFt1, QryPrc, tbProcura.Text);
        }
    }
}
