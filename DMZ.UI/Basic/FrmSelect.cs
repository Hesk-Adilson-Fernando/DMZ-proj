using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;

namespace DMZ.UI.Basic
{
    public partial class FrmSelect : FrmClasse2
    {
        public FrmSelect()
        {
            InitializeComponent();
        }
        public DataTable _dt { get; set; }
        public DataTable _dt2 { get; set; }
        public void BindGrid()
        {
            gridUi1.DataSource = null;
            if (!_dt.HasRows())
            {
                var qry = $"select {SelectCampos} from {Tabela} ";
                if (!string.IsNullOrEmpty(Condicao))
                {
                    qry = $" {qry} where {Condicao}";
                }
                _dt = SQL.GetGen2DT(qry);
                _dt2 = SQL.GetGen2DT($" select {SelectCampos} from {Tabela} where 1=0");
            }

            gridUi1.AutoGenerateColumns = false;
            for (var i = 0; i < _dt.Columns.Count; i++)
            {
                if (_dt.Columns[i] == null) continue;
                var col = new DataGridViewTextBoxColumn
                {
                    Name = _dt.Columns[i].ColumnName,
                    DataPropertyName = _dt.Columns[i].ColumnName,
                    Width = Tamanhos[i].ToInt()
                };
                if (col.Name == ColFillName)
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                else
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    col.Width = Tamanhos[i].ToInt();
                }
                gridUi1.Columns.Add(col);
            }
            gridUi1.HeadersVisible = false;
            gridUi1.ColumnHeadersVisible = false;
            gridUi1.EditMode = DataGridViewEditMode.EditOnF2;
            gridUi1.DataSource = _dt;
            gridUi2.DataSource = null;

            for (var i = 0; i < _dt2.Columns.Count; i++)
            {
                if (_dt2.Columns[i] == null) continue;
                var col = new DataGridViewTextBoxColumn
                {
                    Name = _dt2.Columns[i].ColumnName,
                    DataPropertyName = _dt2.Columns[i].ColumnName,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                };
                gridUi2.Columns.Add(col);
            }
            gridUi2.HeadersVisible = false;
            gridUi2.ColumnHeadersVisible = false;
            gridUi2.DataSource = _dt2;
            HideColumnsGrig();
        }

        private void FrmSelect_Load(object sender, EventArgs e)
        {
            BindGrid();
            HideColumnsGrig();
        }

        public string SelectCampos { get; set; }
        public string Tabela { get; set; }
        public string Condicao { get; set; }
        public bool HideFirstColumn { get; internal set; }
        public List<decimal> Tamanhos { get; set; }
        public string ColFillName { get; set; }
        public string Origem { get; set; }

        //public delegate void SendDt (DataTable dt);
        public Action<DataTable> SendData;

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                var dr = gridUi1.SelectedRows[0];
                var r = _dt2.NewRow();
                foreach (DataColumn c in r.Table.Columns)
                {

                    r[c.ToString()] = dr.Cells[c.ToString()].Value;

                }
                _dt2.Rows.Add(r);
                gridUi2.Update();
                gridUi1.Rows.Remove(dr);
                HideColumnsGrig();
            }
            catch
            {
                //
            }
        }

        private void HideColumnsGrig()
        {
            if (gridUi1.HasRows())
            {
                for (int i = 0; i < gridUi1.ColumnCount; i++)
                {
                    if (i < 2)
                    {
                        gridUi1.Columns[i].Visible = true;
                    }
                    else
                    {
                        gridUi1.Columns[i].Visible = false;
                    }
                }
            }
            if (gridUi2.HasRows())
            {
                for (int i = 0; i < gridUi2.ColumnCount; i++)
                {
                    if (i < 2)
                    {
                        gridUi2.Columns[i].Visible = true;
                    }
                    else
                    {
                        gridUi2.Columns[i].Visible = false;
                    }
                }
            }

        }
        private void btnPrev_Click(object sender, EventArgs e)
        {
            try
            {
                var dr = gridUi2.SelectedRows[0];
                var r = _dt.NewRow();
                foreach (var c in r.Table.Columns)
                {
                    r[c.ToString()] = dr.Cells[c.ToString()].Value;
                }
                _dt.Rows.Add(r);
                gridUi1.Update();
                gridUi2.Rows.Remove(dr);
                HideColumnsGrig();
            }
            catch
            {
                //
            }
        }
        private void BtnProcess_Click(object sender, EventArgs e)
        {
            if (_dt2.HasRows())
            {
                SendData.Invoke(_dt2);
            }
            Close();
        }
        private void btnMoveAllNext_Click(object sender, EventArgs e)
        {
            var dt = gridUi1.DataSource as DataTable;
            if (dt != null)
            {
                try
                {
                    foreach (var row in dt.AsEnumerable())
                    {
                        var r = _dt2.NewRow();
                        foreach (var c in r.Table.Columns)
                        {
                            r[c.ToString()] = row[c.ToString()];
                        }

                        _dt2.Rows.Add(r);
                    }
                }
                catch
                {
                    //
                }
            }
            gridUi2.Update();
            HideColumnsGrig();
            gridUi1.DataSource = null;
        }
        private void tbProcura_TextChanged(object sender, EventArgs e)
        {


            if (gridUi1.Columns[0].DataPropertyName.Trim().ToLower().Contains("stamp"))
            {
                Helper.UpdateGrid(false, gridUi1, _dt, tbProcura.Text, gridUi1.Columns[1].DataPropertyName.Trim());
            }
            else
            {
                Helper.UpdateGrid(false, gridUi1, _dt, tbProcura.Text, gridUi1.Columns[0].DataPropertyName.Trim());
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (gridUi2.Columns[0].DataPropertyName.Trim().ToLower().Contains("stamp"))
            {
                Helper.UpdateGrid(false, gridUi2, _dt2, textBox1.Text, gridUi2.Columns[1].DataPropertyName.Trim());
            }
            else
            {
                Helper.UpdateGrid(false, gridUi2, _dt2, textBox1.Text, gridUi2.Columns[0].DataPropertyName.Trim());
            }
        }
    }
}
