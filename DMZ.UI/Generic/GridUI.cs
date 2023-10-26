using DMZ.BL.Classes;
using DMZ.UI.Basic;
using System.Data;
using System.Windows.Forms;
using System;
using DMZ.UI.Classes;
using DMZ.UI.UC;
using DMZ.UI.UI;

namespace DMZ.UI.Generic
{
    public class GridUi: DataGridView 
    {
        readonly DataGridViewCellStyle _dataGridViewCellStyle10 = new DataGridViewCellStyle();
        readonly DataGridViewCellStyle _dataGridViewCellStyle11 = new DataGridViewCellStyle();
        readonly DataGridViewCellStyle _dataGridViewCellStyle12 = new DataGridViewCellStyle();
        public DataGridViewColumn CurrentColumn;
        public GridUi()
        {
            TabelaAlign = new DataTable();
            var col = new DataColumn("Campo") {DataType = Type.GetType("System.String")};
            TabelaAlign.Columns.Add(col);
            var col2 = new DataColumn("Alinhar");
            col.DataType = Type.GetType("System.String");
            TabelaAlign.Columns.Add(col2);
            ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            HeadersHeight = 30;
            #region Configuração da GridView
            BackgroundColor = System.Drawing.Color.White;
            AllowUserToAddRows = false;
            //RowHeadersVisible = HeadersVisible;
            RowHeadersWidth = 30;
            //BorderStyle = BorderStyle.None;
            ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            _dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            _dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(34, 39, 49);
            _dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            _dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            _dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            _dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            ColumnHeadersDefaultCellStyle = _dataGridViewCellStyle10;
            ColumnHeadersHeight = HeadersHeight;
            ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            _dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            _dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            _dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            _dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            _dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            _dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            DefaultCellStyle = _dataGridViewCellStyle11;
            EnableHeadersVisualStyles = false;
            GridColor = System.Drawing.Color.SteelBlue;
            Location = new System.Drawing.Point(18, 15);
            Name = "dataGridView1";
            _dataGridViewCellStyle12.BackColor = System.Drawing.Color.AliceBlue; ;//System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            _dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            _dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.LightBlue;
            _dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            RowsDefaultCellStyle = _dataGridViewCellStyle12;
            Size = new System.Drawing.Size(566, 238);
            TabIndex = 0;
            CellMouseLeave += CellMouseLeave2;

            #endregion

            //CurrentColumn = CurrentCell.OwningColumn;
            EditingControlShowing += GridUi_EditingControlShowing;
            DataError += GridUi_DataError;
            RowHeadersVisible = false;
            // CellClick += dataGridView1_CellClick;
        }

        private void GridUi_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (!e.Exception.Message.Contains("Input string")) return;
            MsBox.Show("Erro de conversão de dados!\r\nO campo não pode ser vazio,\r\nDigite um número!");
            e.ThrowException = false;
        }
        public delegate void AfterdeleteDelegate();

        public event AfterdeleteDelegate AfterDeleteLineEvent;
        public virtual void AfterDeleteLine()
        {
            var handler = AfterDeleteLineEvent;
            handler?.Invoke();
        }

        public delegate void BeforeDeleteDelegate();

        public event BeforeDeleteDelegate BeforeDeleteLineEvent;
        public virtual void BeforeDeleteLine()
        {
            var handler = BeforeDeleteLineEvent;
            handler?.Invoke();
        }
        private void GridUi_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            CurrentColumn = new DataGridViewColumn();
            CurrentColumn = CurrentCell.OwningColumn;
            CurrentColumnName = CurrentColumn.Name.ToLower();
        }

        public string CurrentColumnName { get; set; }

        private void CellMouseLeave2(object sender, DataGridViewCellEventArgs e)
        {
            Feito = false;
        }

        public string StampCabecalho { get; set; }
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
        public bool HeadersVisible { get; set; }
        public int HeadersHeight { get;  set; }
        public bool GridFilha { get; set; }
        public string CampoCodigo { get; set; }
        public string TbCodigo { get; set; }
        public bool CorPreto { get;  set; }
        public bool Feito { get; private set; }       
        public string Condicao { get; set; }
        public string Codigo { get; set; }
        public string DefacolumnName { get; set; }
        public bool AutoIncrimento { get; set; }
        public delegate void CallFormEdit();
        public event CallFormEdit CallFrmEdit;
        private DateTimePicker _oDateTimePicker;
        public DataTable DtDS { get; set; }
        public DataTable TabelaAlign;
        public DataRow DataRowr;
        public void BindGridView()
        {
            if (string.IsNullOrEmpty(TabelaSql)) return;
            string query;
            if (!GridFilha)
            {
                query = $"select * from {TabelaSql}";
                if (!string.IsNullOrEmpty(Condicao))
                {
                    query = $"select * from {TabelaSql} where {Condicao}";
                }
            }
            else
            {
                if (GridFilhaSecundaria)
                {
                    query = $"select * from {TabelaSql}";
                    if (!string.IsNullOrEmpty(Condicao))
                    {
                        var campos = "";
                        if (!string.IsNullOrEmpty(OrderbyCampos))
                        {
                            campos = "order by "+OrderbyCampos;
                        }
                        query = $"select * from {TabelaSql} where {Condicao} {campos}";
                    } 
                }
                else
                {
                    MyParent = Parent.FindForm();
                    var stampcab = ((FrmClasse)MyParent)?.CLocalStamp;
                    var campos = "";
                    if (!string.IsNullOrEmpty(OrderbyCampos))
                    {
                        campos = "order by "+OrderbyCampos;
                    }
                    query = $"select * from {TabelaSql} where {StampCabecalho.Trim()}='{stampcab.Trim()}' {campos}";      
                }
            }
            DtDS = SQL.GetGen2DT(query);
            EndEdit();
            DataSource = null;
            AutoGenerateColumns = GenerateColumns;
            DataSource = DtDS;
        }

        public string OrderbyCampos { get; set; }
        
        public bool GridFilhaSecundaria { get; set; }
       // public string OrderByCampos { get; set; }
        public (int numero,string messagem) SaveData(bool adding, string ctabela,string clocalstamp)
        {
            (int numero, string messagem) retorno = (0, null);
            if (string.IsNullOrEmpty(TabelaSql)) return (0,"Nome da tabela na grelha não foi definido!..");
            if (DtDS?.Rows.Count > 0)
            {
                retorno=  SQL.Save(DtDS, TabelaSql,adding,clocalstamp,ctabela);
            }
            return retorno;
        }


        public void AddLine()
        {
            if (AutoIncrimento)
            {
                var dtsave = DataSource as DataTable;
                if (dtsave !=null)
                {
                    SQL.Save(dtsave, TabelaSql,false,"","");
                }                
            }
            MyParent = Parent.FindForm();
            DataRowr = DtDS.NewRow().Inicialize();
            if (GridFilha)
            {
                var editeMode = MyParent != null && ((FrmClasse)MyParent).EditMode;
                if (!editeMode) return;
                var stampcab = ((FrmClasse)MyParent).CLocalStamp;
                DataRowr[StampCabecalho] = stampcab;
            }
            if (AutoIncrimento)
            {
                if (MyParent is FrmClasse classe)
                {
                    Condicao = $"{StampCabecalho}='{classe.CLocalStamp.Trim()}'";     
                }
                var num=SQL.Maximo(TabelaSql, Codigo, Condicao);
                DataRowr[Codigo] = num;
            }
            if (!string.IsNullOrEmpty(CampoCodigo))
            {
                var tb = MyParent?.Controls[TbCodigo] as TbDefault;
                if (tb != null)
                {
                    if (string.IsNullOrEmpty(tb.tb1.Text))
                    {
                        MsBox.Show($"O campo {tb.label1.Text} não pode ser vazio!");
                    }
                    DataRowr[CampoCodigo] = tb.tb1.Text;
                }
            }
            DtDS.Rows.Add(DataRowr);
            if (string.IsNullOrEmpty(DefacolumnName)) return;
            var index = Rows.Count - 1;
            CurrentCell = Rows[index].Cells[DefacolumnName.Trim()];
            BeginEdit(true);
        }
        public void Alert(string msg, Form_Alert.EnmType type)
        {
            var frm = new Form_Alert();
            frm.ShowAlert(msg,type);
        }
        public void DellLine(string nomeRegisto =null)
        {
            var str = nomeRegisto ?? "registo";
            var dr = (CurrentRow?.DataBoundItem as DataRowView)?.Row;
            var dt = DataSource as DataTable;
            if (dr == null) return;
            var dres = MsBox.Show($"Deseja eliminar o {str}?", DResult.YesNo);
            if (dres.DialogResult != DialogResult.Yes) return;
            if (dr.RowState != DataRowState.Added)
            {
                BeforeDeleteLine();
                var res = SQL.SqlCmd($"delete from {TabelaSql} where {StampLocal}='{dr[StampLocal].ToString().Trim()}'");
                if (res >0)
                {
                    Alert("Registo eliminado com sucesso",Form_Alert.EnmType.Success);
                    if (dt != null)
                    {
                        DellGridRow = CurrentRow;
                        dt.Rows.Remove(dr);
                        DataSource = null;
                        DataSource = dt;
                        Update();
                        AfterDeleteLine();
                    }
                }
                else
                {
                    Alert("Erro encontrado. Tente de novo",Form_Alert.EnmType.Error);
                }
            }
            else
            {
                Alert("Registo eliminado com sucesso",Form_Alert.EnmType.Success);
                DellGridRow = CurrentRow;
                Rows.Remove(CurrentRow);
                AfterDeleteLine();
            }
        }

        public DataGridViewRow DellGridRow { get; set; }
        public string Origem { get; set; }
        public Decimal Ordem { get; internal set; }

        protected virtual void OnCallFrmEdit()
        {
            var handler = CallFrmEdit;
            handler?.Invoke();
        }
        public void SetFocusColumn(string columnName)
        {
            if (Rows.Count <= 0) return;
            var index = Rows.Count - 1;
            CurrentCell = Rows[index].Cells[columnName.Trim()];
            BeginEdit(true);
        }


        public DataTable GetBindedTable()
        {
            return DataSource as DataTable;
        }

        public static implicit operator FrmReg.PassParam(GridUi v)
        {
            throw new NotImplementedException();
        }
    }


}
