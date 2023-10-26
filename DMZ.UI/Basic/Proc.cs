using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.UI.Generic;
using System.Drawing;
using DMZ.UI.Classes;

namespace DMZ.UI.Basic
{
    public partial class Proc : Form
    {
        public Proc()
        {
            InitializeComponent();
        }

        public delegate void PassControl(DataTable sender, DataTable dt);

        public PassControl PControl;
        public bool HideFirstColumn { get; set; }
        public bool ShowThirdColumn { get; set; }
        public DataTable Dt;
        public bool IsLocaDs { get; set; }
        public bool ReturnDt { get; set; }
        public bool IsSqlSelect { get;  set; }

        private DataTable dt;

        private string _select;
        private string _ctabela;
        private string _campo;
        private readonly string _campo1;
        private readonly string _condicao1 = string.Empty;


        public Proc(string select, string ctabela, string campo, string campo1, string condicao1)
        {
            _select = select;
            _ctabela = ctabela;
            _campo = campo;
            _campo1 = campo1;
            _condicao1 = condicao1;
            InitializeComponent();
            Width = 414;
            Height = 380;
        }

        #region Grupo Arastar 

        protected override void WndProc(ref Message msj)
        {
            const int CoordenadaWFP = 0X84;
            const int DesIsquierda = 16;
            const int DesDerecha = 17;
            if (msj.Msg == CoordenadaWFP)
            {
                var x = (int) (msj.LParam.ToInt64() & 0xFFFF);
                var y = (int) ((msj.LParam.ToInt64() & 0xFFFF0000) >> 16);
                var CoordenaArea = PointToClient(new Point(x, y));
                var TamanhoForm = ClientSize;
                if (CoordenaArea.X >= TamanhoForm.Width - 16 && CoordenaArea.Y >= TamanhoForm.Height)
                {
                    msj.Result = (IntPtr) (IsMirrored ? DesIsquierda : DesDerecha);
                    return;
                }
            }
            base.WndProc(ref msj);
        }
        private void MouseDownEvent()
        {
            Dllimport.ReleaseCapture();
            Dllimport.SendMessage(Handle, 0x112, 0xf012, 0);
        }
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownEvent();
        }
        #endregion

        private void Proc_Load(object sender, EventArgs e)
        {
            if (!IsLocaDs)
            {
                if (!IsSqlSelect)
                {
                    var rtn = SQL.BindGrid(_select, _ctabela, _condicao1, string.Empty, _campo, dgvProcura, label2,
                        false);
                    if (!string.IsNullOrEmpty(rtn))
                    {
                        MsBox.Show(rtn.Contains("converting") ? "Não consegue converter os dados " : rtn);
                    }
                    SQL.BindGrid(_select, _ctabela, _condicao1, string.Empty, _campo, dgvProcura, label2, false);
                    if (HideFirstColumn)
                    {
                        dgvProcura.Columns[0].Visible = false;
                    }
                    var numer = (from str in _select where char.IsPunctuation(str) select str.ToString()).ToList();
                    var index = numer.Count;
                    cbPorReferencia.Visible = _campo1 != string.Empty;
                }
            }
            else if (!IsSqlSelect)
            {
                dgvProcura.DataSource = null;
                dgvProcura.AutoGenerateColumns = false;
                if (Dt?.Rows.Count >= 0)
                {
                    for (var i = 0; i < Dt.Columns.Count; i++)
                    {
                        dgvProcura.Columns[i].DataPropertyName = Dt.Columns[i].ColumnName;
                    }
                }
                dgvProcura.DataSource = Dt;
                if (Dt != null)
                    label2.Text = Dt.Rows.Count.ToString();
            }
            WindowState = FormWindowState.Normal;
            dt = new DataTable();
            dt.Columns.Add(new DataColumn("codigo", typeof(string)));
            dt.Columns.Add(new DataColumn("descricao", typeof(string)));
            dt.Columns.Add(new DataColumn("campo3", typeof(string)));
            dt.Columns.Add(new DataColumn("campo4", typeof(string)));
            dt.Columns.Add(new DataColumn("campo5", typeof(string)));
            dt.Columns.Add(new DataColumn("campo6", typeof(string)));

        }

        private DataTable _dtSearch;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_dtSearch == null)
            {
                _dtSearch = dgvProcura.DataSource as DataTable;
            }

            if (_dtSearch != null)
            {
                var colunas = _dtSearch.Columns.Count;
                var colName = "";
                switch (colunas)
                {
                    case 1:
                        colName = _dtSearch.Columns[0].ColumnName.Trim();
                        break;
                    case 2:
                        colName = !cbPorReferencia.Checked ? _dtSearch.Columns[1].ColumnName.Trim() : _dtSearch.Columns[0].ColumnName.Trim();
                        break;
                    case 3:
                        colName = !cbPorReferencia.Checked ? _dtSearch.Columns[1].ColumnName.Trim() : _dtSearch.Columns[0].ColumnName.Trim();
                        break;
                    case 4:
                        colName = !cbPorReferencia.Checked ? _dtSearch.Columns[1].ColumnName.Trim() : _dtSearch.Columns[0].ColumnName.Trim();
                        break;
                    case 5:
                        colName = !cbPorReferencia.Checked ? _dtSearch.Columns[1].ColumnName.Trim() : _dtSearch.Columns[0].ColumnName.Trim();
                        break;
                    case 6:
                        colName = !cbPorReferencia.Checked ? _dtSearch.Columns[1].ColumnName.Trim() : _dtSearch.Columns[0].ColumnName.Trim();
                        break;
                }
                var condicao = $"{colName} like '%{tbProcura.Text.Trim()}%'";
                try
                {
                    var dtSearched = _dtSearch.Select(condicao).CopyToDataTable();
                    dgvProcura.DataSource = null;
                    dgvProcura.DataSource = dtSearched;
                }
                catch (Exception)
                {
                    dgvProcura.DataSource = null;
                    dgvProcura.DataSource = _dtSearch;
                }
            }
            if (HideFirstColumn)
            {
                dgvProcura.Columns[0].Visible = false;
            }
        }


        private void Selecionar()
        {
            if (dgvProcura.SelectedRows.Count == 0) return;
            var selectedItem = dgvProcura.SelectedRows[0];
            if (PControl == null) return;
            if (selectedItem == null) return;
            var tb = dt.NewRow().Inicialize();
             var quant=dgvProcura.Columns.Count;
             switch (quant)
             {
                 case 1:
                     tb["descricao"] = selectedItem.Cells[0].Value.ToString();
                     break;
                 case 2:
                     tb["codigo"] = selectedItem.Cells[0].Value.ToString();
                     tb["descricao"] = selectedItem.Cells[1].Value.ToString();
                     break;
                 case 3:
                     tb["codigo"] = selectedItem.Cells[0].Value.ToString();
                     tb["descricao"] = selectedItem.Cells[1].Value.ToString();
                     tb["campo3"] = selectedItem.Cells[2].Value.ToString();
                     break;
                 case 4:
                     tb["codigo"] = selectedItem.Cells[0].Value.ToString();
                     tb["descricao"] = selectedItem.Cells[1].Value.ToString();
                     tb["campo3"] = selectedItem.Cells[2].Value.ToString();
                     tb["campo4"] = selectedItem.Cells[3].Value.ToString();
                     break;
                case 5:
                    tb["codigo"] = selectedItem.Cells[0].Value.ToString();
                    tb["descricao"] = selectedItem.Cells[1].Value.ToString();
                    tb["campo3"] = selectedItem.Cells[2].Value.ToString();
                    tb["campo4"] = selectedItem.Cells[3].Value.ToString();
                    tb["campo5"] = selectedItem.Cells[4].Value.ToString();
                    break;
                case 6:
                    tb["codigo"] = selectedItem.Cells[0].Value.ToString();
                    tb["descricao"] = selectedItem.Cells[1].Value.ToString();
                    tb["campo3"] = selectedItem.Cells[2].Value.ToString();
                    tb["campo4"] = selectedItem.Cells[3].Value.ToString();
                    tb["campo5"] = selectedItem.Cells[4].Value.ToString();
                    tb["campo6"] = selectedItem.Cells[5].Value.ToString();
                    break;
            }

             dt.Rows.Add(tb);
            if (ReturnDt)
            {
                var dt2 = SQL.GetGen2DT($"select {_select} from {_ctabela} where 1=0");
                    var dr = dt2.NewRow();
                    for (var i = 0; i < dr.Table.Columns.Count; i++)
                    {
                        dr[i] = selectedItem.Cells[i].Value;
                    }
                    dt2.Rows.Add(dr);
                    PControl(dt, dt2);               
            }
            else
            {
                PControl(dt, null);
            }
            LimpaVariaveis();
            Close();
        }

        private void LimpaVariaveis()
            {
                 _select = string.Empty;
                 _ctabela = string.Empty;
                 _campo = string.Empty;
            }
        private void btnAceitar_Click(object sender, EventArgs e) => Selecionar();

        private void btnFechar_Click(object sender, EventArgs e) => Close();

        private void dgvProcura_DoubleClick(object sender, EventArgs e) => Selecionar();

        private void dgvProcura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
    }

}

