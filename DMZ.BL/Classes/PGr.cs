using DMZ.DAL.Classes;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;


namespace DMZ.BL.Classes
{
    public  class PGr
    {
        private  GCon _gc ;
        private string _sql;
        private string _qry;
        private string _type;
        private string _cond2 = string.Empty;
        private SqlCommand _cmdSql;
        private SqlDataReader _dr;


        #region Carregamento de ListView.....
        public string BindGrid(string qry, string tb, string cond1, string cond2, string campo, DataGridView grid, Label label,bool contido)
        {
            var rtn = string.Empty;
            var numer = (from str in qry where char.IsPunctuation(str) select str.ToString()).Where(x => x.Equals(",")).ToList();
            var index = numer.Count;
            if (!string.IsNullOrEmpty(cond2))
            {
                if (string.IsNullOrEmpty(campo))
                {
                    campo = qry.Split(',')[1];
                }  
            }
            var orderBy = qry.Contains("as") ? "" : $"order by {qry.Split(',')[0]}";
            _cond2 = string.Format(!contido ? " {0} like '{1}%' " : " {0} like '%{1}%' ", campo, cond2);

            _sql = cond2 == string.Empty
                ? cond1 == string.Empty
                    ? $"select {qry} from {tb} {orderBy}"
                    : $"select {qry} from {tb} where {cond1} {orderBy}"
                : cond1 == string.Empty ? $"select {qry} from {tb} where {_cond2} {orderBy} "
                    : $"select {qry} from {tb} where {cond1} and {_cond2} {orderBy} ";

            var qrry = string.Empty;
            var words = new List<string>(qry.Split(','));
            var selwords = string.Empty;
            for (var i = 0; i < words.Count; i++)
            {
                var w = words[i];
                selwords = i == 0 ? "'" + w + "'" : selwords + "," + "'" + w + "'";
            }
            string sql;
            if (!qry.Contains("as"))
            {
               var dt = SQLExec.GetGenDT($"select DATA_TYPE,COLUMN_NAME from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME ='{tb}' and  rtrim(ltrim(COLUMN_NAME)) in ({selwords})");
                for (var i = 0; i < words.Count; i++)
                {
                    var w = words[i];
                    var type = GetType(dt, w.ToLower());
                    qrry = i == 0 ? w + $"= {type}" : qrry + "," + w + $"= {type}";
                }
                dt.Dispose();
                words.Clear();
                sql = $"select top 1  {qrry} from {tb} " + "  union all " + _sql;
            }
            else
            {
                sql =  _sql;
            }

            var dt2 = SQLExec.GetGenDT(sql);
            if (dt2?.Rows.Count>=0)
            {
                for (var i = 0; i < dt2.Columns.Count; i++)
                {                    
                    if (i>=2)
                    {
                        var dc = new DataGridViewTextBoxColumn {Visible = false, DataPropertyName = dt2.Columns[i].ColumnName};
                        grid.Columns.Add(dc);
                    }
                    else
                    {
                        grid.Columns[i].DataPropertyName = dt2.Columns[i].ColumnName;
                    }
                }
            }
            grid.DataSource = null;
            grid.AutoGenerateColumns = false;
            grid.DataSource = dt2;
            if (dt2 != null) label.Text = dt2.Rows.Count-1 +" Registos";
            return rtn;
        }


        private static string GetType(DataTable dt,string campo)
        {
            string tipo = null;
            var dr = dt.AsEnumerable().FirstOrDefault(x => x.Field<string>("COLUMN_NAME").ToLower().Trim().Equals(campo.Trim()));
            if (dr == null) return null;
            var type = dr["DATA_TYPE"].ToString();
            switch (type)
            {
                case "char":
                case "nvarchar":
                case "varchar":
                case "text":
                    tipo = "''";
                    break;
                case "datetime":
                case "decimal":
                case "numeric":
                case "bit":
                    tipo = "0";
                    break;
            }
            return tipo;
        }

        #endregion

        public string GetTipo(string tabela,string campo)
        {
            using (_gc = new GCon())
            {
                _qry =$"select DATA_TYPE from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME ='{tabela.Trim()}' and COLUMN_NAME='{campo}' " +
                    "order by ORDINAL_POSITION ";
                _cmdSql = new SqlCommand(_qry, _gc.NResult);
                _dr = _cmdSql.ExecuteReader();
                while (_dr.Read())
                {
                    _type = _dr[0].ToString();
                }
                return _type;
            }
        }
    

    }
}
