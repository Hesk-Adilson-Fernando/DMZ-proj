using System;
using System.Data;
using System.Windows.Forms;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;

namespace DMZ.UI.Basic
{
    public partial class Querry : FrmClasse2
    {
        public Querry()
        {
            InitializeComponent();
        }
        public delegate void PassControl(string sender);

        public PassControl PControl;

        public delegate void PassControl2(DataRow dr);

        public PassControl2 PControl2;
        public bool ShowStk { get; set; }

        public Action<DataRow> Sender;
        private void Querry_Load(object sender, EventArgs e)
        {
            radGridView1.AutoGenerateColumns = false;
            radGridView1.Columns.Add(Campo1, Campo1);
            radGridView1.Columns.Add(Campo2, Campo2);
            radGridView1.Columns.Add(Campo3, Campo3);
            if (ShowStk)
            {

                radGridView1.Columns.Add("Stk", "Stock");
                radGridView1.Columns[3].DataPropertyName = "stk";
            }
            radGridView1.Columns[0].Width = Width1;
            radGridView1.Columns[0].HeaderText = Caption1;
            radGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            radGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //radGridView1.Columns[0].C.Font = new Font("Verdana", 25F, FontStyle.Bold);
            radGridView1.Columns[1].Width = Width2;
            radGridView1.Columns[1].HeaderText = Caption2;
            radGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //radGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // radGridView1.Columns[1].HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            radGridView1.Columns[0].DataPropertyName = Campo1;
            radGridView1.Columns[1].DataPropertyName = Campo2;
            radGridView1.Columns[2].DataPropertyName = Campo3;
            radGridView1.Columns[2].Visible = false;



        }
        public bool Origem { get; set; }
        public string Campo1 { get; set; }
        public string Campo2 { get; set; }
        public string Campo3 { get; set; }
        public string Caption1 { get; set; }
        public string Caption2 { get; set; }
        public int Width1 { get; set; }
        public int Width2 { get; set; }
        public DataTable Dt { get; internal set; }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Selecionar();
        }
        private void Selecionar()
        {
            if (radGridView1.CurrentRow == null) return;
            if (Origem)
            {
                var dt = radGridView1.DataSource as DataTable;
                if (dt != null)
                    PControl2?.Invoke(dt.Rows[radGridView1.CurrentRow.Index]);
            }
            else
            {
                if (radGridView1.CurrentRow != null)
                {
                    if (ShowStk)
                    {
                        var xtk = radGridView1.CurrentRow.Cells["Stk"].Value;
                        var dt = radGridView1.DataSource as DataTable;
                        var srv = dt != null && (bool)dt.Rows[radGridView1.CurrentRow.Index]["servico"];
                        if (BL.Classes.Extensions.CToD(xtk.ToString()) == 0 && !srv)
                        {
                            MsBox.Show("Este documento não admite stock negativo ou zerro! \n Para Produtos");
                        }
                        else
                        {
                            if (PControl !=null)
                            {
                                PControl?.Invoke(radGridView1.CurrentRow.Cells[Campo3].Value.ToString().Trim());
                            }
                            else
                            {
                                Sender?.Invoke(radGridView1.CurrentRow.ToDataRow());
                            }
                            
                        }
                    }
                    else
                    {
                        if (PControl !=null)
                        {
                            PControl?.Invoke(radGridView1.CurrentRow.Cells[Campo3].Value.ToString().Trim());
                        }
                        else
                        {
                            Sender?.Invoke(radGridView1.CurrentRow.ToDataRow());
                        }
                        //PControl?.Invoke(radGridView1.CurrentRow.Cells[Campo3].Value.ToString().Trim());
                    }
                }
            }

            Close();
        }

        private void Querry_FormClosed(object sender, FormClosedEventArgs e)
        {
            Origem = false;
        }

        private void radGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Selecionar();
        }

        private void Querry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSeach2.PerformClick();
            }
        }
        private DataTable _dtSearch;
        private void tbProcura_TextChanged(object sender, EventArgs e)
        {
            Helper.UpdateGrid(false, radGridView1, Dt, tbProcura.Text);
            //if (_dtSearch == null)
            //{
            //    _dtSearch = radGridView1.DataSource as DataTable; 
            //}

            //if (_dtSearch != null)
            //{
            //    var contador = _dtSearch.Columns.Count;
            //    var colName = "";
            //    Type tipodados = null;
            //    switch (contador)
            //    {
            //        case 1:
            //            colName = _dtSearch.Columns[0].ColumnName.Trim();
            //            tipodados = _dtSearch.Columns[0].DataType;
            //            break;
            //        case 2:
            //            if (cbPorReferencia.Checked)
            //            {
            //                colName = _dtSearch.Columns[0].ColumnName.Trim();
            //                tipodados = _dtSearch.Columns[0].DataType;
            //            }
            //            else
            //            {
            //                colName = _dtSearch.Columns[1].ColumnName.Trim();
            //                tipodados = _dtSearch.Columns[1].DataType;
            //            }

            //            break;
            //    }

            //    string condicao = null;
            //    if (tipodados == typeof(string))
            //    {
            //        condicao = $"{colName} like '%{tbProcura.Text.Trim()}%'";
            //    }
            //    else if (tipodados == typeof(decimal))
            //    {
            //        condicao = $"{colName} ={tbProcura.Text.Trim()}";
            //    }

            //    try
            //    {
            //        var dtSearched = _dtSearch.Select(condicao).CopyToDataTable();
            //        radGridView1.DataSource = null;
            //        radGridView1.DataSource = dtSearched;
            //    }
            //    catch (Exception)
            //    {
            //        radGridView1.DataSource = null;
            //        radGridView1.DataSource = _dtSearch;
            //    }
            //}
        }
    }
}
