using System.Data;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.UI.Basic;
using DMZ.UI.Classes;

namespace DMZ.UI.Generic
{

    public class GridUIFt : DataGridView
    {
        DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
        public DataGridViewColumn CurrentColumn;
        public GridUIFt()
        {
            //AutoGenerateColumns = false;
            //CriaColunas();
            ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            #region Configuração da GridView
            BackgroundColor = System.Drawing.Color.White;
            AllowUserToAddRows = false;
            //RowHeadersVisible = HeadersVisible;
            RowHeadersWidth = 30;
            //BorderStyle = BorderStyle.None;
            ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(39, 59, 80);
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            ColumnHeadersHeight = 30;
            ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            DefaultCellStyle = dataGridViewCellStyle11;
            EnableHeadersVisualStyles = false;
            GridColor = System.Drawing.Color.SteelBlue;
            Location = new System.Drawing.Point(18, 15);
            SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CellBorderStyle = DataGridViewCellBorderStyle.None;

            Name = "dataGridView1";
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.DarkGoldenrod;
            // dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            RowsDefaultCellStyle = dataGridViewCellStyle12;
            Size = new System.Drawing.Size(566, 238);
            TabIndex = 0;

            #endregion
            EditingControlShowing += GridUIFt_EditingControlShowing;
        }

        private void GridUIFt_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            CurrentColumn = new DataGridViewColumn();
            CurrentColumn = CurrentCell.OwningColumn;
        }

        public string StampCabecalho { get; set; }
        public bool NotExecuteEndEditEvent { get; set; }
        public BorderStyle GridUIBorderStyle
        {
            get => BorderStyle;
            set => BorderStyle = value;
        }
        public string TabelaSql { get; set; }
        private Form MyParent { get; set; }
        public string StampLocal { get; set; }
        public bool AddButtons { get; set; }
        public bool GenerateColumns { get; set; }
        public bool GridFilha { get; set; }
        public string CampoCodigo { get; set; }
        public string TbCodigo { get; set; }
        public bool ColunasCriadas { get;  set; }
        //public DataTable tmpFound { get; set; }

        public delegate void CallFormEdit();

        public event CallFormEdit CallFrmEdit;
        public DataTable DsDt { get; set; }

        public DataTable TabelaAlign;
        public DataRow DataRowr;
        public DataRow SelectedRow()
        {
            var row = ((DataRowView)SelectedRows[0].DataBoundItem).Row;
            return row;
        }
        public DataTable SelectedRowTable()
        {
            var dt = new DataTable();
            if (SelectedRows.Count>0)
            {
                var row = ((DataRowView)SelectedRows[0].DataBoundItem).Row;
                dt.CopyColumnsFrom(row.Table);
                var r= dt.NewRow();
                foreach (DataColumn col in dt.Columns)
                {
                    r[col.ColumnName]=row[col.ColumnName];
                }
                dt.Rows.Add(r);
            }
            return dt;
        }

        public DataTable GetBindedTable()
        {
            return DataSource as DataTable;
        }
        public void  BindGridView()
        {
            DsDt = new DataTable();
            if (string.IsNullOrEmpty(TabelaSql)) return;
            string query;
            if (!GridFilha)
            {
                query = $"select * from {TabelaSql}";
            }
            else
            {
                MyParent = Parent.FindForm();
                var stampcab = ((FrmClasse)MyParent)?.CLocalStamp;
                query = $"select * from {TabelaSql} where {StampCabecalho.Trim()}='{stampcab.Trim()}' order by ordem";
            }

            DsDt = SQL.GetGen2DT(query);
            EndEdit();
            DataSource = null;
            AutoGenerateColumns = GenerateColumns;
            DataSource = DsDt;
            StampLocal = SQL.GetGen2DT($"select COLUMN_NAME from INFORMATION_SCHEMA.COLUMNS WHERE table_name = '{TabelaSql.Trim()}' and COLUMN_NAME like '%stamp'").Rows[0][0].ToString();
        }

        public (int numero,string messagem) SaveData(bool adding, string ctabela,string clocalstamp)
        {
            (int numero, string messagem) retorno = (20, null);
            if (string.IsNullOrEmpty(TabelaSql)) return (0,"Nome da tabela na grelha não foi definido!..");
            if (DsDt?.Rows.Count > 0)
            {
                retorno=  SQL.Save(DsDt, TabelaSql,adding,clocalstamp,ctabela);
            }
            return retorno;
        }
        public void DellLine()
        {
            var dr = (CurrentRow?.DataBoundItem as DataRowView)?.Row;
            if (dr == null) return;
            var dres = MsBox.Show($"Deseja eliminar:\r\n {dr["descricao"].ToString().Trim()}?", DResult.YesNo);
            if (dres.DialogResult != DialogResult.Yes) return;               
            if (dr.RowState != DataRowState.Added)
            {
                 var res = SQL.SqlCmd($"delete from {TabelaSql} where {StampLocal}='{dr[StampLocal].ToString().Trim()}'");
                if (res == 1)
                {
                    Rows.Remove(CurrentRow);
                    Update();
                    var dt = DataSource as DataTable;
                    if (dt.Rows.Count>1)
                    {
                        dt= dt.AsEnumerable().Where(x=>x.RowState != DataRowState.Deleted).CopyToDataTable();
                    }
                    MyParent = Parent.FindForm();

                    Helper.Totaislinha(true, dt, (FrmClasse)MyParent, "VD");
                    Helper.Alert("Registo eliminado com sucesso",Form_Alert.EnmType.Success);
                }
                else
                {
                    MsBox.Show("Erro encontrado. Tente de novo");
                }
            }
            else
            {

                Rows.Remove(CurrentRow);
                Update();
                var dt = DataSource as DataTable;
                if (dt?.Rows.Count>0)
                {
                    dt = dt.AsEnumerable().Where(x => x.RowState != DataRowState.Deleted).CopyToDataTable();
                     
                }               
                MyParent = Parent.FindForm();
                Helper.Totaislinha(true, dt, (FrmClasse)MyParent, "VD");
                Helper.Alert("Registo eliminado com sucesso",Form_Alert.EnmType.Success);
            }
        }

        internal void UpdateDS(DataTable dt)
        {
            DataSource=null;
            AutoGenerateColumns =false;
            DataSource = dt;
        }
    }
}
