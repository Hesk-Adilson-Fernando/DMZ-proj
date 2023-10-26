using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using DMZ.Batch.Extensions;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DataTable = System.Data.DataTable;
using Point = System.Drawing.Point;
using TextBox = System.Windows.Forms.TextBox;

namespace DMZ.Batch.Classes
{
    public static class Helper
    {

        internal static string GetReferencia(string v)
        {
            var xx = "";
            var cumprimento = v.Length;
            switch (cumprimento)
            {
                case 1:
                    xx = $"000{v}";
                    break;
                case 2:
                    xx = $"00{v}";
                    break;
                case 3:
                    xx = $"0{v}";
                    break;
                case 4:
                    xx = $"{v}";
                    break;
            }
            return xx;
        }

          private static List<Usracessos> lista2;
     
      

    

        

        public static List<DateTime> GetDates(int month, int year)
        {
            return Enumerable.Range(1, DateTime.DaysInMonth(year, month))
                             .Select(day => new DateTime(year, month, day))
                             .Where(dt => dt.DayOfWeek != DayOfWeek.Sunday &&
                                          dt.DayOfWeek != DayOfWeek.Saturday)
                             .ToList();
        }
        public static List<int> GetDaysInMonth(int Month, int Year)
        {
            return Enumerable.Range(1, DateTime.DaysInMonth(Year, Month))
                             // Days: 1, 2 ... 31 etc.
                             .Select(day => new DateTime(Year, Month, day).Day)
                             // Map each day to a date
                             .ToList(); // Load dates into a list
        }

        //public static DataTable GetDaysInMonth(int Month, int Year)
        //{
        //    DataTable dt = new DataTable();
        //    dt.Columns.Add(new DataColumn("dia", typeof(string)));
        //    dt.Columns.Add(new DataColumn("dianome", typeof(string)));
        //    var lista = Enumerable.Range(1, DateTime.DaysInMonth(Year, Month))
        //                     // Days: 1, 2 ... 31 etc.
        //                     .Select(day => new DateTime(Year, Month, day).Day)
        //                     // Map each day to a date
        //                     .ToList(); // Load dates into a list
        //    foreach (var dia in lista)
        //    {
        //        var dr = dt.NewRow();
        //        dr[0] = dia;
        //        dr[1] = new DateTime(Year, Month, dia).DayOfWeek.ToString();
        //        dt.Rows.Add(dr);
        //    }
        //    return dt;
        //}
        public static void DoProgressProcess(DataTable tabela, Action<DataRow, bool> recebeDados, string campo = "", string processo = "")
        {
            var dpb = new DataProgressbar();
            dpb.DadosEnviados += recebeDados;
            dpb.Lista = tabela;
            dpb.TopLevel = true;
            dpb.Campo = campo;
            dpb.Processo = processo;
            dpb.ShowInTaskbar = false;
            dpb.StartPosition = FormStartPosition.CenterScreen;
            dpb.ShowDialog();
        }
        public static DataTable TiposColuna()
        {
            var dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Rows.Add("DataGridViewTextBoxColumn");
            dt.Rows.Add("DataGridViewCheckBoxColumn");
            dt.Rows.Add("DataGridViewImageColumn");
            dt.Rows.Add("DataGridViewButtonColumn");
            dt.Rows.Add("DataGridViewComboBoxColumn");
            dt.Rows.Add("DataGridViewLinkColumn");
            return dt;

        }
        
      



        public static void Updatepj(bool lancacustopj,string pjstamp,string campo,string tabela,string totftiva,bool ft,bool rcl=false)
        {
            if (!lancacustopj) return;
            if (rcl)
            {
                SQL.SqlCmd($@"update pj set {campo.Trim()} =(select sum(total) total from {tabela.Trim()} where Pjstamp='{pjstamp}') where Pjstamp='{pjstamp}'");
            }
            else
            {
                if (ft)
                {
                    SQL.SqlCmd($@"update pj set {campo.Trim()} =(select sum(total) total from {tabela.Trim()} where Pjstamp='{pjstamp}'),{totftiva} =(select sum(Totaliva) Totaliva from {tabela} where Pjstamp='{pjstamp}') where Pjstamp='{pjstamp}'");
                }
                else
                {
                    SQL.SqlCmd($@"update pj set {campo.Trim()} =(select sum(total) total from {tabela.Trim()} where Pjstamp='{pjstamp}') where Pjstamp='{pjstamp}'"); 
                }
                SQL.SqlCmd($"update pj set Lucro=(Totft-TotComp-TotGI) where Pjstamp='{pjstamp.Trim()}'");
            }
        }
        public static string GetMaxConta(string grupo)
        {
            var lista = new List<SqlParameter>
            {
                new SqlParameter("@Radical", SqlDbType.Char, 30),
                new SqlParameter("@Ano", SqlDbType.Decimal),
                new SqlParameter("@Conta", SqlDbType.Char, 30),
                new SqlParameter("@LenConta", SqlDbType.Int),
                new SqlParameter("@Mascara", SqlDbType.Char, 10)
            };
            lista[0].Value = grupo.Trim();
            lista[1].Value = Pbl.AnoContabil();
            lista[2].Value = "";
            var mascara = SQL.GetValue($"select Mascara from Paramgct where grupo='{grupo}'");
            //if (!(dt?.Rows.Count > 0)) return;
            var len = (grupo.Trim() + mascara.Trim()).Trim().Length;
            lista[3].Value = len;
            lista[4].Value = mascara.Trim();
            var conta = SQL.SqlSP("GetContaMax", lista);
            return conta?.Rows[0][0].ToString();
        }
       
        public static DataTable SetBinds(Control e, string campo,string qry)
        {
            var autoText = e as TextBox;
            DataTable dt = null;
            if (autoText == null) return dt;
            autoText.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            autoText.AutoCompleteSource = AutoCompleteSource.CustomSource;
            var sc = new AutoCompleteStringCollection();
            autoText.AutoCompleteCustomSource = null;
            dt = SQL.GetGenDT(qry);
            if (!(dt?.Rows.Count > 0)) return dt;
            foreach (var row in dt.AsEnumerable())
            {
                if (row == null) continue;
                sc.Add(row[campo].ToString());
            }
            autoText.AutoCompleteCustomSource = sc;
            return dt;
        }
        public static DataTable SetBinds(Control e,DataTable dt)
        {
            var autoText = e as TextBox;
            if (autoText == null) return dt;
            autoText.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            autoText.AutoCompleteSource = AutoCompleteSource.CustomSource;
            var sc = new AutoCompleteStringCollection();
            if (!(dt?.Rows.Count > 0)) return dt;
            foreach (var row in dt.AsEnumerable())
            {
                if (row == null) continue;
                sc.Add(row[0].ToString());
            }
            autoText.AutoCompleteCustomSource = sc;
            return dt;
        }
        

          public static void BindGrids(DataGridView grid, string str)
       {
           var dt = SQL.GetGen2DT(str);
           grid.DataSource = null;
           grid.AutoGenerateColumns = false;
           grid.DataSource = dt;
       }
       public static void CellEnter(object sender, DataGridViewCellEventArgs e)
       {
           var validClick = e.RowIndex != -1 && e.ColumnIndex != -1; //Make sure the clicked row/column is valid.
           var datagridview = sender as DataGridView;
           if (!(datagridview?.Columns[e.ColumnIndex] is DataGridViewTextBoxColumn) || !validClick) return;
           datagridview.BeginEdit(true);
        }
       public static void Codmovtz(bool movtz, decimal codmovtz, string descmovtz, DataGridView grelha,string origem = "")
       {
           if (!movtz) return;
           if (grelha.CurrentRow == null) return;
           grelha.CurrentRow.Cells["Codmovtz"].Value = codmovtz;
           grelha.CurrentRow.Cells["Descmovtz"].Value = descmovtz;//Origem2
           grelha.CurrentRow.Cells["Origem2"].Value = origem;//
        }
        
       internal static void ToCsV(DataGridView dGv, string filename,bool colName)
       {
           var stOutput = "";
           // Export titles:
           var sHeaders = "";

           for (var j = 0; j < dGv.Columns.Count; j++)
           {
               if (colName)
               {
                    //
                    sHeaders = sHeaders + Convert.ToString(dGv.Columns[j].DataPropertyName.Trim()) + "\t";
                    if (j==dGv.Columns.Count-1)
                    {
                        stOutput += sHeaders + "\r\n";
                    }
                    
                }
               else
               {
                   sHeaders = sHeaders + Convert.ToString(dGv.Columns[j].HeaderText) + "\t";
                   if (j == dGv.Columns.Count - 1)
                   {
                       stOutput += sHeaders + "\r\n";
                   }
                }

           }
           // Export data.
           for (var i = 0; i < dGv.RowCount - 1; i++)
           {
               var stLine = "";
               for (var j = 0; j < dGv.Rows[i].Cells.Count; j++)
                   stLine = stLine + Convert.ToString(dGv.Rows[i].Cells[j].Value) + "\t";
               stOutput += stLine + "\r\n";
           }
           var utf16 = Encoding.GetEncoding(1254);
           var output = utf16.GetBytes(stOutput);
           var fs = new FileStream(filename, FileMode.Create);
           var bw = new BinaryWriter(fs);
           bw.Write(output, 0, output.Length); //write the encoded file
           bw.Flush();
           bw.Close();
           fs.Close();
       }

      
       public static DataRow Inicialize(this DataRow dr)
       {
           var ctabela = dr.Table.TableName.ToLower();
           var lista = SQL.GetGenDT(" INFORMATION_SCHEMA.COLUMNS ",
               $" WHERE table_name = '{ctabela.Trim()}' and IS_NULLABLE='YES' ", " column_name ");
           foreach (DataColumn col in dr.Table.Columns)
           {
               if (col.DataType== typeof(DateTime))
               {
                   dr[col.ColumnName.Trim()] = Pbl.SqlDate;
               }
               if (col.DataType == typeof(string))
               {
                   var r = lista?.AsEnumerable().FirstOrDefault(x => x.Field<string>("column_name").Equals(col.ColumnName.Trim()));
                   if (r!=null)
                   {
                       dr[col.ColumnName.Trim()] = null;
                   }
                   else
                   {
                       dr[col.ColumnName.Trim()] = "";  
                   }
               }
               if (col.DataType == typeof(decimal))
               {
                   dr[col.ColumnName.Trim()] = 0;
               }
               if (col.DataType == typeof(int))
               {
                   dr[col.ColumnName.Trim()] = 0;
               }
               if (col.DataType == typeof(bool))
               {
                   dr[col.ColumnName.Trim()] = false;
               }
               if (col.DataType == typeof(byte[]))
               {
                   dr[col.ColumnName.Trim()] = 0;
               }
               if (col.ColumnName.Trim().ToLower().Contains("stamp") && col.ColumnName.Trim().ToLower().Contains(ctabela.ToLower().Trim()))
               {
                   dr[col.ColumnName.Trim()] = Pbl.Stamp();
               }
           }
           return dr;
       }
       internal static DataTable EditingControlShowing(DataGridViewEditingControlShowingEventArgs e, string name)
        {
            DataTable  dt =null;
            string qry;
            if (name.Equals("descricao"))
            {
                qry = "select Ststamp,Referenc,Descricao,Refornec from st ";
                dt = SetBinds(e.Control, "Descricao", qry);
            }
            if (name.Equals("ref1"))
            {
                qry = "select Ststamp,Referenc,Descricao,Refornec from st ";
                dt = SetBinds(e.Control, "Referenc", qry);
            }
            if (name.Equals("refornec"))
            {
                qry = "select Ststamp,Referenc,Descricao,Refornec from st ";
                dt = SetBinds(e.Control, "Refornec", qry);
            }
            if (name.Equals("armazem"))
            {
                qry = "select Codigo,Descricao from Armazem";
                dt = SetBinds(e.Control, "Descricao", qry);
            }
            if (name.Equals("arm")) 
            { 
                qry = "select Codigo,Descricao from Armazem";
                dt = SetBinds(e.Control, "Descricao", qry);
            }
            return dt;
        }
        public static void FillRcl(DataTable rcll, DataRow r,string rclstamp,string tabela)
        {
            var r2 = rcll.NewRow();
            var cambiousd=r["Cambiousd"].ToDecimal();
            if (r["moeda"].ToString().ToLower().Trim().Equals(Pbl.MoedaBase.ToLower().Trim()))
            {
                NewMethod(r, r2,1);
            }
            else
            {
                try
                {
                    r2["mvalorpreg"] = r["mvalorpreg"];
                    r2["mvalorreg"] = r["mvalorreg"];
                    r2["mValorPend"] = r["mvalorpreg"].ToDecimal() - r["mvalorreg"].ToDecimal();
                    r2["mValordoc"] = r["mValordoc"];
                    NewMethod(r, r2, 1);
                }
                catch (Exception)
                {
                    NewMethod(r, r2, cambiousd);
                    r2["mvalorpreg"] = r["valorpreg"];
                    r2["mvalorreg"] = r["valorreg"];
                    r2["mValorPend"] = r["valorpreg"].ToDecimal() - r["valorreg"].ToDecimal();
                    r2["mValordoc"] = r["Valordoc"];
                }
            }
            r2["descricao"] = r["descricao"];
            r2["data"] = r["data"];
            if (tabela.ToLower().Equals("rcl"))
            {
                r2["Ccstamp"] = r["Ccstamp"];
            }
            else
            {
                r2["fccstamp"] = r["fccstamp"];
            }           
            r2[$"{tabela.Trim()}lstamp"] = Pbl.Stamp();
            r2[$"{tabela.Trim()}stamp"] = rclstamp;
            r2["Rcladiant"] = r["Rcladiant"];
            r2["nrdoc"] = r["nrdoc"];
            rcll.Rows.Add(r2);
        }

        private static void NewMethod(DataRow r, DataRow r2,decimal cambiousd)
        {
            r2["Valordoc"] = r["Valordoc"].ToDecimal() * cambiousd;
            r2["valorpreg"] = r["valorpreg"].ToDecimal() * cambiousd;
            r2["valorreg"] = r["valorreg"].ToDecimal() * cambiousd;
            r2["ValorPend"] = (r["valorpreg"].ToDecimal() - r["valorreg"].ToDecimal()).ToDecimal() * cambiousd;
        }

       
        public static void StartOSK()
        {

            var windir = Environment.GetEnvironmentVariable("WINDIR");
            string osk = null;

            if (osk == null)
            {
                osk = Path.Combine(Path.Combine(windir, "sysnative"), "osk.exe");
                if (!File.Exists(osk))
                    osk = null;
            }

            if (osk == null)
            {
                osk = Path.Combine(Path.Combine(windir, "system32"), "osk.exe");
                if (!File.Exists(osk))
                {
                    osk = null;
                }
            }

            if (osk == null)
                osk = "osk.exe";

            Process.Start(osk);
        }



      
        public static I CreateInstance<I>(string formName) where I : Form
        {
            var myAssembly = Assembly.GetExecutingAssembly();
            var type = myAssembly.GetTypes().FirstOrDefault(t => t.Name.ToLower().Equals(formName.ToLower()));
            if (type == null) return null;
            var  c = Activator.CreateInstance(type);
            return (I)c;
        }

      

        public static void GravaConta(DataTable dtDs,string stamp,string nome, string cttabel)
        {
            foreach (var row in dtDs.AsEnumerable())
            {
                if (SQL.CheckExist($"select conta from Pgc where ltrim(rtrim(conta)) ='{row["Conta"].ToString().Trim()}' and ano =(select ano from param)")) continue;
                var pgc =BL.Classes.Utilities.DoAddline<Pgc>();
                pgc.Pgcstamp = Pbl.Stamp();
                pgc.Oristamp = stamp;
                pgc.Conta = row["Conta"].ToString();
                pgc.Descricao = nome;
                pgc.Ppconta = cttabel;
                pgc.Ano = Pbl.AnoContabil();
                EF.Save(pgc);
            }
        }

        public static DataTable FillFormasP(DataTable formasp, DataTable dtformasp)
        {
            if (formasp.HasRows())
            {
                if (dtformasp.HasRows())
                {
                    dtformasp.Rows.Clear();
                }
                foreach (var r in formasp.AsEnumerable())
                {
                    if (r != null)
                    {
                        var rw = dtformasp.NewRow().Inicialize();
                        foreach (DataColumn col in dtformasp.Columns)
                        {
                            if (formasp.Columns.Contains(col.ColumnName))
                            {
                                rw[col.ColumnName] = r[col.ColumnName];
                            }
                        }
                        dtformasp.Rows.Add(rw);
                    }

                }
            }
            return dtformasp;   
        }

        public static void GravaConta(string stamp,string nome,string conta,string oldconta)
        {
            Pgc pgc;
            if (!string.IsNullOrEmpty(oldconta))
            {
                var str =$"select * from Pgc where ltrim(rtrim(conta)) ='{oldconta}' and ano =(select ano from param)";
                pgc = SQL.GetGen2DT(str)?.DtToList<Pgc>().FirstOrDefault();
            
            }
            else
            {
                pgc = BL.Classes.Utilities.DoAddline<Pgc>();

            }

            if (pgc == null) return;
            pgc.Oristamp = stamp;
            pgc.Conta = conta;
            pgc.Descricao = nome;
            pgc.Ano = Pbl.AnoContabil();
            EF.Save(pgc);
        }

       
        
        
        
        
        public static bool? IsVirtual(this PropertyInfo self)
        {
            if (self == null)
                throw new ArgumentNullException("self");

            bool? found = null;

            foreach (MethodInfo method in self.GetAccessors())
            {
                if (found.HasValue)
                {
                    if (found.Value != method.IsVirtual)
                        return null;
                }
                else
                {
                    found = method.IsVirtual;
                }
            }

            return found;
        }
        internal static string GetCampos<T>() where T : class, new()
        {
            var entity = new T();
            var campos = "";
            var props = entity.GetType().GetProperties();
            foreach (var p in props)
            {
                if ((bool)!p.IsVirtual())
                {
                    if (string.IsNullOrEmpty(campos))
                    {
                        campos = p.Name.Trim();
                    }
                    else
                    {
                        campos = $"{campos},{p.Name.Trim()}";
                    }
                }
            }
            return campos;
        }
        
        internal static void FillRowData(DataRow r, DataRow dr)
        {
            foreach (DataColumn col in dr.Table.Columns)
            {
                if (col!=null)
                {
                    r[col.ColumnName.ToLower().Trim()]=dr[col.ColumnName.ToLower().Trim()];
                }
            }
        }

        private static DateTimePicker _dtp;
        public static void AddDateTimePicker(DataGridView gridUi2,DataGridViewCellEventArgs e)
        {
            if (gridUi2 == null) return;
            var dtpNome = gridUi2.CurrentCell.OwningColumn.Name;
            //if (gridUi2.Controls.Find("dtpNome", true).Length != 0) return;

            var data = gridUi2.CurrentCell.Value.ToDateTimeValue();
            if (data.Year==1900)
            {
                data = Pbl.SqlDate;
            }
            _dtp = new DateTimePicker
            {
                Format = DateTimePickerFormat.Short, Visible = true, Value = data, Name = dtpNome
            };
            var rect = gridUi2.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
            _dtp.Size = new Size(rect.Width, rect.Height);
            _dtp.Location = new Point(rect.X, rect.Y);

            // attach events
            _dtp.CloseUp += dtp_CloseUp;
            _dtp.ValueChanged += dtp_OnTextChange;
            gridUi2.Controls.Add(_dtp);
        }
        public static void SetDateTimePicker(DataGridView gridUi2)
        {
            var cell = gridUi2.CurrentCell;
            if (!cell.OwningColumn.GetType().Name.Trim().Equals("DateTimePickerColumn")) return;
            var dtpNome ="dtp" + cell.OwningColumn.Name.Trim();
            //if (gridUi2.Controls.Find("dtpNome", true).Length != 0) return;
            _dtp = new DateTimePicker
            {
                Format = DateTimePickerFormat.Short,
                Visible = true,
                Value = Pbl.SqlDate,
                Name = dtpNome
            };

        var rect = gridUi2.GetCellDisplayRectangle(cell.ColumnIndex, cell.RowIndex, true);
            _dtp.Size = new Size(rect.Width, rect.Height);
            _dtp.Location = new Point(rect.X, rect.Y);

            // attach events
            _dtp.CloseUp += dtp_CloseUp;
            _dtp.TextChanged += dtp_OnTextChange;
            gridUi2.Controls.Add(_dtp);
        }
        // on text change of dtp, assign back to cell
        private static void dtp_OnTextChange(object sender, EventArgs e)
        {
            _dtp.Value = _dtp.Text.ToDateTimeValue();
            ((DataGridView) _dtp.Parent).CurrentCell.Value = _dtp.Text;
        }

// on close of cell, hide dtp
        private static void dtp_CloseUp(object sender, EventArgs e)
        {
            _dtp.Visible = false;
        }

        public static string Horas()
        {
            var min = DateTime.Now.Minute.ToString().Length == 1 ? "0" + DateTime.Now.Minute : DateTime.Now.Minute.ToString();
            var sec = DateTime.Now.Second.ToString().Length == 1 ? "0" + DateTime.Now.Second : DateTime.Now.Second.ToString();
            return $"{DateTime.Now.Hour}:{min}:{sec}";
        }

        public static DataTable GetArmazenStock(string condicao)
        {
            var qry = $@"select Ref,descricao,Armazem,stock,Preco,Total=(stock*Preco) from (select Ref,descricao,stock=(sum(Entrada)-sum(saida)) ,Codarm, 
            Armazem = (select descricao from Armazem where Armazemstamp = mstk.Armazemstamp ),Ststamp,
			Preco = isnull((select max(Preco) from StPrecos where Ststamp = Mstk.Ststamp),0) 
			from mstk {condicao} group by codarm,Ref,descricao,Armazemstamp,Ststamp,Preco)tmp1
            where tmp1.stock > 0 order by tmp1.Codarm,tmp1.descricao";
                
                
            //    $@"select * from (select Ref,descricao,stock=(sum(Entrada)-sum(saida)) ,Codarm, 
            //Armazem=(select descricao from Armazem where Armazemstamp=mstk.Armazemstamp )  from mstk {condicao} group by codarm,Ref,descricao,Armazemstamp)tmp1 where tmp1.stock>0 order by tmp1.Codarm,tmp1.descricao";
            
            return SQL.GetGen2DT(qry);
        }

      
        private static void Download(DataTable dt)
        {
            if (dt.Rows.Count == 0) return;
            var bytes = (byte[])dt.Rows[0]["documento"];
            var docnome = dt.Rows[0]["caminho"].ToString();
            var stream = new MemoryStream(bytes);
            //pdfViewerPsicotecnico.DetachStreamAfterLoadComplete = true;
            //pdfViewerPsicotecnico.LoadDocument(stream);
        }
       
        public static void UpdateChecked(DataGridView gridUiFt1, string nomeCol)
        {
            var nome = gridUiFt1.CurrentCell.OwningColumn.Name.ToLower().Trim();
            if (nome.Equals(nomeCol.ToLower().Trim()))
            {
                gridUiFt1.CurrentCell.Value = !(gridUiFt1.CurrentCell.Value is DBNull) && !gridUiFt1.CurrentCell.Value.ToBool(); //aqui seta o true ou false quando clica manualmente 
                gridUiFt1.Update();
            }
        }

        public static void UpdateGridColumns(DataGridView gridProdutos)
        {
            //ESCONDE
            if (!Pbl.Param.Escondecolprecos)
            {
                if (gridProdutos != null)
                {
                    gridProdutos.Columns["preco1"].HeaderText = Pbl.Param.Preco1;
                    gridProdutos.Columns["preco2"].HeaderText = Pbl.Param.Preco2;
                    gridProdutos.Columns["preco3"].HeaderText = Pbl.Param.Preco3;
                    gridProdutos.Columns["preco4"].HeaderText = Pbl.Param.Preco4;
                    gridProdutos.Columns["preco5"].HeaderText = Pbl.Param.Preco5;
                    //gridProdutos.Columns["preco6"].HeaderText = Pbl.Param.Preco6;
                    gridProdutos.Columns["preco1"].Visible = true;
                    gridProdutos.Columns["preco2"].Visible = true;
                    gridProdutos.Columns["preco3"].Visible = true;
                    gridProdutos.Columns["preco4"].Visible = true;
                    gridProdutos.Columns["preco5"].Visible = true;
                }

                // gridProdutos.Columns["preco6"].Visible = true;
            }
        }

    
        internal static DataTable ShowDisciplina(DataGridViewCell currentCell, DataGridViewEditingControlShowingEventArgs e,string querry ="")
        {
            DataTable dt = null;
            if (currentCell != null)
            {
                var name = currentCell.OwningColumn.Name.ToLower();

                string qry;
                if (querry=="")
                {
                    qry = "select referenc,Descricao,Ststamp from ST where disciplina=1";
                }
                else
                {
                    qry = querry;
                }
                
                if (name.Equals("descricao"))
                {
                    dt = SetBinds(e.Control, "descricao", qry);
                }
                else if (name.Equals("referenc"))
                {
                    dt = SetBinds(e.Control, "referenc", qry);
                }
                else
                {
                    dt = null;
                    var autoText = e.Control as TextBox;
                    autoText.AutoCompleteCustomSource = null;
                }
            }
            return dt;
        }
    }
}
