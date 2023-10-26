
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using DMZ.BL.Classes;
using DMZ.DAL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Basic;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using DMZ.UI.Reports;
using DMZ.UI.Reports.DSTableAdapters;
using DMZ.UI.UC;
using DMZ.UI.UI;
using DMZ.UI.UI.Contabil;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using Microsoft.Office.Interop.Excel;
using Microsoft.Reporting.WinForms;
using Application = System.Windows.Forms.Application;
using DataTable = System.Data.DataTable;
using Document = iTextSharp.text.Document;
using Font = iTextSharp.text.Font;
using Image = System.Drawing.Image;
using Paragraph = iTextSharp.text.Paragraph;
using Point = System.Drawing.Point;
using Range = Microsoft.Office.Interop.Excel.Range;
using Rectangle = System.Drawing.Rectangle;
using TextBox = System.Windows.Forms.TextBox;
using Util = DMZ.UI.Generic.Util;

namespace DMZ.UI.Classes
{
    public static class Helper
    {
        public static T DoAddline<T>() where T : class, new()
        {
            var t = new T();
            var nomeClasse = typeof(T).Name;
            //var lista = SQL.GetGenDT(" INFORMATION_SCHEMA.COLUMNS ",
            //    $" WHERE table_name = '{nomeClasse.Trim()}' and IS_NULLABLE='YES' ", " column_name ");
            var properties = typeof(T).GetProperties();
            foreach (var p in properties)
            {
                if (p.PropertyType == typeof(string))
                {
                    //p.SetValue(t, "");
                    if (p.Name.Trim().ToLower().Contains("stamp") && p.Name.Trim().ToLower().Contains(nomeClasse.ToLower().Trim()))
                    {
                        //CLocalStamp = Pbl.Stamp();
                        // PrimaryKeyName = p.Name.Trim();
                        p.SetValue(t, Pbl.Stamp());
                    }
                }
                if (p.PropertyType == typeof(DateTime))
                {
                    p.SetValue(t, new DateTime(1900, 1, 1));
                }
            }
            return t;
        }

        public static void SetColunas(bool b, GridUi dgvRcll,GridFormasP dgvFormasp2,Procura ucMoeda)
        {
            if (dgvRcll != null)
            {
                dgvRcll.Columns["valordoc"].Visible = b;
                dgvRcll.Columns["PorPagar"].Visible = b;
                dgvRcll.Columns["valorreg"].Visible = b;
                dgvRcll.Columns["Valorpend"].Visible = b;
                dgvRcll.Columns["mvalordoc"].Visible = !b;
                dgvRcll.Columns["mvalorreg"].Visible = !b;
                dgvRcll.Columns["mvalorpreg"].Visible = !b;
                dgvRcll.Columns["mvalorpend"].Visible = !b;
                dgvRcll.Columns["mvalordoc"].HeaderText = $"Valor Doc. {ucMoeda.tb1.Text}";
                // dgvRcll.Columns["mvalorpreg"].Visible = !b;
                dgvRcll.Columns["mvalorpreg"].HeaderText = $"Por Pagar {ucMoeda.tb1.Text}";
                // dgvRcll.Columns["mvalorreg"].Visible = !b;
                dgvRcll.Columns["mvalorreg"].HeaderText = $"Pago {ucMoeda.tb1.Text}";
                // dgvRcll.Columns["mvalorpend"].Visible = !b;
                dgvRcll.Columns["mvalorpend"].HeaderText = $"Pendente {ucMoeda.tb1.Text}";
                dgvRcll.Columns["mvalordoc"].ReadOnly = dgvRcll.Columns["mvalorpreg"].ReadOnly = dgvRcll.Columns["mvalorreg"].ReadOnly
                    = dgvRcll.Columns["mvalorpend"].ReadOnly = false;
            }

            if (dgvFormasp2 !=null)
            {
                dgvFormasp2.Grelha.Columns["mvalor"].Visible = !b;
                dgvFormasp2.Grelha.Columns["Valor"].Visible = b;
                dgvFormasp2.Grelha.Columns["mvalor"].HeaderText = $"Valor {ucMoeda.tb1.Text}";
            }
        }

        internal static System.Windows.Forms.CheckBox BindGridCheckBox(GridUi gridui1, System.Windows.Forms.CheckBox headerCheckBox,int indice=2)
        {
            var headerCellLocation = gridui1.GetCellDisplayRectangle(indice, -1, true).Location;
            headerCheckBox.Location = new Point(headerCellLocation.X, headerCellLocation.Y +5);
            headerCheckBox.BackColor = Color.Transparent;
            headerCheckBox.Size = new Size(18, 18);
            headerCheckBox.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            //headerCheckBox.BackColor = Color.FromArgb(39, 59, 80);
            headerCheckBox.Anchor = AnchorStyles.Right;// = Color.FromArgb(34, 39, 49);
            gridui1.Controls.Add(headerCheckBox);

            return headerCheckBox;
        }

        internal static void SetDisciplina(GridUi gridUI1,DataTable Dt,bool origem=false)
        {
            var nome = gridUI1.CurrentCell.OwningColumn.Name.ToLower();
            if (nome.Equals("descricao") || nome.Equals("referenc"))
            {
                if (gridUI1.CurrentCell?.Value == null) return;
                var valor = gridUI1.CurrentCell.Value.ToString().Trim();
                if (!(Dt?.Rows.Count > 0)) return;
                var dr = Dt.AsEnumerable().FirstOrDefault(s => s.Field<string>(nome).Trim().Equals(valor));
                if (dr == null) return;
                switch (nome)
                {
                    case "descricao":
                        if (gridUI1.CurrentRow != null)
                        {
                            gridUI1.CurrentRow.Cells["referenc"].Value = dr[0].ToString();
                            if (origem)
                            {
                                gridUI1.CurrentRow.Cells["discstamp"].Value = dr[2].ToString();
                            }
                            
                        }
                        break;
                    default:
                        if (gridUI1.CurrentRow != null)
                        {
                            gridUI1.CurrentRow.Cells["descricao"].Value = dr[1].ToString();
                            if (origem)
                            {
                                gridUI1.CurrentRow.Cells["discstamp"].Value = dr[2].ToString();
                            }
                        }
                        break;
                }
                gridUI1.Update();
            }
        }

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

        public static void ChamaformImport(string Tabela, string TabelaFilha, string condicao, string contexto,string Origem=null,DataTable tipodoc=null)
        {
            var ipor = new FrmImportCl
            {
                TopLevel = true,
                ShowInTaskbar = false,
                StartPosition = FormStartPosition.CenterScreen,
                Tabela = Tabela,
                TabelaFilha = TabelaFilha,
                Condicao = condicao,
                Origem=Origem
                
            };
            ipor.label1.Text = $"Importar {contexto}";
            ipor.tipodoc = tipodoc;
            ipor.ShowDialog();
        }
        private static List<Usracessos> lista2;
        public static DataTable BuildMonth(int month, int year)
        {
            var dias = GetDaysInMonth(month, year);
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Sunday", typeof(string)));
            dt.Columns.Add(new DataColumn("Monday", typeof(string)));
            dt.Columns.Add(new DataColumn("Tuesday", typeof(string)));
            dt.Columns.Add(new DataColumn("Wednesday", typeof(string)));
            dt.Columns.Add(new DataColumn("Thursday", typeof(string)));
            dt.Columns.Add(new DataColumn("Friday", typeof(string)));
            dt.Columns.Add(new DataColumn("Saturday", typeof(string)));
            dt.Rows.Add(dt.NewRow());
            dt.Rows.Add(dt.NewRow());
            dt.Rows.Add(dt.NewRow());
            dt.Rows.Add(dt.NewRow());
            dt.Rows.Add(dt.NewRow());
            dt.Rows.Add(dt.NewRow());
            dt.Rows.Add(dt.NewRow());
            //int totalCalendarDays = 42; // matrix 7 x 6



            // DateTime lastDayCalendar = lastDayMonth.Add(TimeSpan.FromDays(totalCalendarDays - tempDays - 1));

            // set the first month day
            DateTime firstDayMonth = new DateTime(year, month, 1);

            // set the lastmonth day
            DateTime lastDayMonth = new DateTime(year, month, DateTime.DaysInMonth(year, month));

            // now get the first day week of the first day month (0-6 Sun-Sat)
            var  firstDayWeek = firstDayMonth.DayOfWeek.ToString();

            //// now get the first day week of the last day month (0-6 Sun-Sat)
            //byte lastDayWeek = (byte)lastDayMonth.DayOfWeek;

            //// now the first day show in calendar is the first day month minus the days to 0 (sunday)
            //DateTime firstDayCalendar = firstDayMonth.Subtract(TimeSpan.FromDays(firstDayWeek));
            //int tempDays = (lastDayMonth - firstDayCalendar).Days;

            for (int i = 0; i < dias.Count; i++)
            {
                int dia = dias[i];
                var semenadia = DiaSemana(dia, month, year);
                switch (semenadia)
                {
                    case "Sunday":
                        SetDia(dt, dia, semenadia, firstDayWeek);
                        break;
                    case "Monday":
                        SetDia(dt, dia, semenadia, firstDayWeek);
                        break;
                    case "Tuesday":
                        SetDia(dt, dia, semenadia, firstDayWeek);
                        break;
                    case "Wednesday":
                        SetDia(dt, dia, semenadia, firstDayWeek);
                        break;
                    case "Thursday":
                        SetDia(dt, dia, semenadia, firstDayWeek);
                        break;
                    case "Friday":
                        SetDia(dt, dia, semenadia, firstDayWeek);
                        break;
                    case "Saturday":
                        SetDia(dt, dia, semenadia, firstDayWeek);
                        break;
                }
            }
            return dt;
        }

        internal static string BuildInCondicao(DataTable dt,string campo)
        {
            var condicao = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (i == 0)
                {
                    condicao = $"'{dt.Rows[i][campo].ToTrim()}'";
                }
                else
                {
                    condicao = $"{condicao},'{dt.Rows[i][campo].ToTrim()}'";
                }
            }
            return condicao;
        }

        public static void GetCC(GridUi gridCc,string CLocalStamp)
        {
            var dtcc = SQL.GetGen2DT($"select moeda,sum(valorreg) as saldo from ClCCF() where Clstamp='{CLocalStamp.Trim()}' group by Moeda order by moeda ");
            gridCc.SetDataSource(dtcc);
        }

        internal static void ViewProdutos(DataTable dt, System.Windows.Forms.Button btnCategory, Form f,decimal Origem)
        {
            if (f != null)
            {
                ((FrmPosRest)f).DtProdutos = dt;
                ((FrmPosRest)f).Produto = true;
                ((FrmPosRest)f).fLPSubProduct.Controls.Clear();
                FillProduct(dt,f);
            }
            if (f == null)
            {
                ((FrmPosRest)f).lblInform.Visible = true;
                ((FrmPosRest)f).lblInform.Text = "Nada adicionado ainda!";
            }
            SetBackColor(btnCategory);
        }
        private static void SetBackColor(System.Windows.Forms.Button button)
        {
            button.BackColor = Color.FromArgb(34, 39, 49);

            foreach (var sect in button.Parent.Parent.Controls)
            {
                if (!(sect is Category)) continue;
                if (((Category)sect).btnCategory.Text.Trim() != button.Text.Trim())
                {
                    ((Category)sect).btnCategory.BackColor = Color.SaddleBrown;
                }
            }

        }
        internal static string GetProdutos(string condicao = "")
        {

            var xx=  $@"select * from (
                        select Referenc,isnull(Preco,0) as Preco,st.Ststamp,Imagem,Descricao, 
                        Quant=isnull((select stock from STExtratoFicha(st.Ststamp) where Armazemstamp='{Pbl.Usr.Armazemstamp.Trim()}'),0),
                            composto,servico,Usaquant2
                            from St left join StPrecos on st.Ststamp=StPrecos.ststamp  
                            where pos=1 and Usaquant2=0 and StPrecos.Ccustamp='{Pbl.Usr.Ccustamp.Trim()}' {condicao})tmp1 where quant>0 and preco>0
							union all 
						select Referenc,isnull(Preco,0) as Preco,st.Ststamp,Imagem,Descricao, 
                        Quant=0,composto,servico,Usaquant2
                            from St left join StPrecos on st.Ststamp=StPrecos.ststamp  
                            where pos=1 and Usaquant2=0 and StPrecos.Ccustamp='{Pbl.Usr.Ccustamp.Trim()}'  and servico=1 {condicao}
                        union all
                        select* from(select Referenc, cast(0 as decimal) as Preco,st.Ststamp,Imagem,Descricao, 
                        Quant = isnull((select stock from STExtratoFicha(st.Ststamp) where Armazemstamp ='{Pbl.Usr.Armazemstamp.Trim()}'),0),
                            composto,servico,Usaquant2 from St where pos = 1 and Usaquant2 = 1 {condicao} )tmp1 where quant > 0";
            return xx;
        }

        internal static void ShowForm<T>(GridUi grid, Form frmMdi,string tabela,string colstamp,string clickcoluna) where T : FrmClasse, new()
        {
            var nome = grid.CurrentCell.OwningColumn.Name.ToLower().Trim();
            var stamp = grid.CurrentRow.Cells[colstamp.Trim()].Value.ToString();
            if (nome.Equals(clickcoluna.Trim()))
            {
                var frm = new T();
                frm.ShowForm(frmMdi.MdiParent);
                var tab = SQL.GetGen2DT($"select * from {tabela.Trim()} where {tabela.Trim()}stamp='{stamp}'");
                frm.PreencheCampos(tab, 0);
                frm.Procurou = true;
            }
        }

        internal static void SetCCustoMoeda(Procura tbCcusto, Procura ucMoeda)
        {
            tbCcusto.tb1.Text = Pbl.Usr.Ccusto;
            tbCcusto.Text2 = Pbl.Usr.Ccustamp;
            ucMoeda.tb1.Text = Pbl.MoedaBase;
        }

        private static void SetDia(DataTable dt, int dia, string dianome,string firstDayWeek)
        {
            int coluna = 0;
            switch (firstDayWeek)
            {
                case "Sunday":
                    coluna = GetColuna(dia);
                    break;
                case "Monday":
                    if (dia <= 6)
                    {
                        coluna = 0;
                    }
                    else if (dia >= 7 && dia <= 13)
                    {
                        coluna = 1;
                    }
                    else if (dia >= 14 && dia <= 20)
                    {
                        coluna = 2;
                    }
                    else if (dia >= 21 && dia <= 27)
                    {
                        coluna = 3;
                    }
                    else if (dia >= 28 && dia <= 31)
                    {
                        coluna = 4;
                    }
                    break;
                case "Tuesday":
                    if (dia <= 5)
                    {
                        coluna = 0;
                    }
                    else if (dia >= 6 && dia <= 12)
                    {
                        coluna = 1;
                    }
                    else if (dia >= 13 && dia <= 19)
                    {
                        coluna = 2;
                    }
                    else if (dia >= 20 && dia <= 26)
                    {
                        coluna = 3;
                    }
                    else if (dia >= 27 && dia <= 31)
                    {
                        coluna = 4;
                    }
                    break;
                case "Wednesday":
                    if (dia <= 4)
                    {
                        coluna = 0;
                    }
                    else if (dia >= 5 && dia <= 11)
                    {
                        coluna = 1;
                    }
                    else if (dia >= 12 && dia <= 18)
                    {
                        coluna = 2;
                    }
                    else if (dia >= 19 && dia <= 25)
                    {
                        coluna = 3;
                    }
                    else if (dia >= 26 && dia <= 31)
                    {
                        coluna = 4;
                    }
                    break;
                case "Thursday":
                    if (dia <= 3)
                    {
                        coluna = 0;
                    }
                    else if (dia >= 4 && dia <= 10)
                    {
                        coluna = 1;
                    }
                    else if (dia >= 11 && dia <= 17)
                    {
                        coluna = 2;
                    }
                    else if (dia >= 18 && dia <= 24)
                    {
                        coluna = 3;
                    }
                    else if (dia >= 25 && dia <= 31)
                    {
                        coluna = 4;
                    }
                    break;
                case "Friday":
                    if (dia <= 2)
                    {
                        coluna = 0;
                    }
                    else if (dia >= 3 && dia <= 9)
                    {
                        coluna = 1;
                    }
                    else if (dia >= 10 && dia <= 16)
                    {
                        coluna = 2;
                    }
                    else if (dia >= 17 && dia <= 23)
                    {
                        coluna = 3;
                    }
                    else if (dia >= 24 && dia <= 31)
                    {
                        coluna = 4;
                    }
                    break;
                case "Saturday":
                    if (dia <= 1)
                    {
                        coluna = 0;
                    }
                    else if (dia >= 2 && dia <= 8)
                    {
                        coluna = 1;
                    }
                    else if (dia >= 9 && dia <= 15)
                    {
                        coluna = 2;
                    }
                    else if (dia >= 16 && dia <= 22)
                    {
                        coluna = 3;
                    }
                    else if (dia >= 23 && dia <= 29)
                    {
                        coluna = 4;
                    }
                    else if (dia >= 30 && dia <= 31)
                    {
                        coluna = 5;
                    }
                    break;
            }

            if (dt.Rows[coluna][dianome].ToString().IsNullOrEmpty())
            {
                dt.Rows[coluna][dianome] = dia.ToString();
            }
            else if (dt.Rows[coluna][dianome].ToString().IsNullOrEmpty())
            {
                dt.Rows[coluna][dianome] = dia.ToString();
            }
            else if (dt.Rows[coluna][dianome].ToString().IsNullOrEmpty())
            {
                dt.Rows[coluna][dianome] = dia.ToString();
            }
            else if (dt.Rows[coluna][dianome].ToString().IsNullOrEmpty())
            {
                dt.Rows[coluna][dianome] = dia.ToString();
            }
            else if (dt.Rows[coluna][dianome].ToString().IsNullOrEmpty())
            {
                dt.Rows[coluna][dianome] = dia.ToString();
            }
            else if (dt.Rows[coluna][dianome].ToString().IsNullOrEmpty())
            {
                dt.Rows[coluna][dianome] = dia.ToString();
            }
            else if (dt.Rows[coluna][dianome].ToString().IsNullOrEmpty())
            {
                dt.Rows[coluna][dianome] = dia.ToString();
            }
        }

        private static int GetColuna(int dia)
        {
            var coluna = 0;
            if (dia <= 7)
            {
                coluna = 0;
            }
            else if (dia >= 8 && dia <= 14)
            {
                coluna = 1;
            }
            else if (dia >= 15 && dia <= 21)
            {
                coluna = 2;
            }
            else if (dia >= 22 && dia <= 28)
            {
                coluna = 3;
            }
            else if (dia >= 29 && dia <= 31)
            {
                coluna = 4;
            }
            return coluna;
        }

        private static string DiaSemana(int dia, int month, int year)
        {
            return new DateTime(year, month, dia).DayOfWeek.ToString();
        }

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
        public static void Export_DataGridView_To_Excel(DataGridView gridUiMapa, string filename)
        {

            string[] Alphabit = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M",
                "N", "O","P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

            var Range_Letter = Alphabit[gridUiMapa.Columns.Count];
            var Range_Row = (gridUiMapa.Rows.Count + 1).ToString();
            var app = new Microsoft.Office.Interop.Excel.Application();
            var workbook = app.Workbooks.Add(Type.Missing);
            app.Visible = false;
            var worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Columns.AutoFit();
            worksheet.Name = "Sheet1";
            for (var i = 1; i < gridUiMapa.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = gridUiMapa.Columns[i - 1].HeaderText;
             
            }
            for (var i = 0; i < gridUiMapa.Rows.Count - 1; i++)
            {
                for (var j = 0; j < gridUiMapa.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = gridUiMapa.Rows[i].Cells[j].Value.ToString();
                    //var rang = worksheet.get_Range($"{i + 2}", $"A{j + 1}");
                    //rang.ColumnWidth = gridUiMapa.Columns[i - 1].Width;
                    //worksheet.Range[worksheet.Cells[1, gridUiMapa.Rows.Count], worksheet.Cells[1, gridUiMapa.Rows.Count]].Interior.Color = ColorTranslator.ToOle(Color.FromArgb(255, 160, 97));
                    //worksheet.Range["A1", "B1"].Interior.Color = ColorTranslator.ToOle(Color.FromArgb(255, 160, 97));
                    //worksheet.Range["A1", "B1"].Interior.Color = ColorTranslator.ToOle(Color.FromArgb(255, 160, 97));
                }
            }

            //foreach (DataGridViewColumn co in gridUiMapa.Columns)
            //{
            //    worksheet.Columns[co.Index + 1].ColumnWidth = co.Width;
            //}
            if (!filename.IsNullOrEmpty())
            {
                workbook.SaveAs(filename.Trim(), Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                workbook.Close();
            }
            app.Quit();
            MsBox.Show("Ficheiro exportado com sucesso");
        }
        public static DataTable EnumToDataTable(Enum parEnumToConvert)
        {
            var dt = new DataTable();
            //dt.Columns.Add("ID");
            dt.Columns.Add("Name");
           // var i = 0;
            var nomes = Enum.GetNames(parEnumToConvert.GetType());
            foreach (string s in nomes)
            {
                var dr = dt.NewRow();
               // dr["ID"] = i;
                dr["Name"] = s;
                dt.Rows.Add(dr);
              //  i++;
            }
            return dt;
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
        public static void Alert(string msg, Form_Alert.EnmType type)
        {
            var frm = new Form_Alert();
            frm.Invokex(x => x.ShowAlert(msg, type));
        }

        internal static string EntreDatas(DateTime dData1, DateTime dData2)
        {
            return $"CONVERT(date, data)>='{dData1.ToSqlDate()}' AND CONVERT(date, data)<='{dData2.ToSqlDate()}'";
        }

        public static void UpDateCambioLinhas(decimal taxacambio,DataGridView gridUIFt1,TbDefault tbSuttotalMoeda,TbDefault tbIvaMoeda,TbDefault tbtotalMoeda, TbDefault tbDescontoMoeda)
        {
            if (gridUIFt1.Rows.Count > 0)
            {
                var dt = gridUIFt1.DataSource as DataTable;
                if (dt?.Rows.Count > 0)
                {
                    if (taxacambio>0)
                    {
                        foreach (var dr in dt.AsEnumerable())
                        {
                            dr["Cambiousd"]=taxacambio;
                        }
                    }
                    else
                    {
                        foreach (var dr in dt.AsEnumerable())
                        {
                            dr["Cambiousd"]=0;
                            dr["Mpreco"]=0;
                            dr["msubtotall"]=0;
                            dr["mvalival"]=0;
                            dr["mdescontol"]=0;
                            dr["mtotall"]=0;
                        }
                        tbSuttotalMoeda.tb1.Text="";
                        tbIvaMoeda.tb1.Text="";
                        tbtotalMoeda.tb1.Text="";
                        tbDescontoMoeda.tb1.Text="";
                    }
                }
            }
        }
        public static void ShowHideMoedaColumns(bool value,string Moeda,DataGridView gridUIFt1)
        {
            gridUIFt1.Columns["mpreco"].Visible=value;//Preco
            gridUIFt1.Columns["mpreco"].HeaderText="Preço "+Moeda.Trim();
            gridUIFt1.Columns["msubtotall"].Visible=value;
            gridUIFt1.Columns["msubtotall"].HeaderText="SubTotal "+Moeda.Trim();
            gridUIFt1.Columns["mvalival"].Visible=value;
            gridUIFt1.Columns["mvalival"].HeaderText="Valor Iva "+Moeda.Trim();
            gridUIFt1.Columns["mdescontol"].Visible=value;
            gridUIFt1.Columns["mdescontol"].HeaderText="Desconto "+Moeda.Trim();
            gridUIFt1.Columns["mtotall"].Visible=value;
            gridUIFt1.Columns["mtotall"].HeaderText="Total "+Moeda.Trim();
        }
        public static (bool valido, List<Usracessos> lista) GetUsrAcessosList(string tipodoc)
        {
            (bool valido, List<Usracessos> lista) ret = (false, null);
            lista2 = Pbl.Usracessos.Where(x => x.Origem.ToLower().Equals(tipodoc.ToLower())).ToList();
            if (lista2?.Count>0)
            {
                lista2 = lista2.Where(linha => linha.Ver).ToList();
                if (lista2.Count>0)
                {
                    ret = (true, lista2);
                }
                else
                {
                    MsBox.Show($"{Messagem.ParteInicial()}Não tem acesso ao documento . contacte administrator!");
                }
            }
            else
            {
                MsBox.Show($"{Messagem.ParteInicial()}Desculpa não tem acessos definidos para {Pbl.Usr.Nome}. contacte administrator!");     
            }
            return ret;
        }



        public static void UpdateFormasp(decimal total,decimal mtotal,decimal Codmovtz,string Descmovtz,string origem,GridFormasP dgvFormasp2)
        {
            if (dgvFormasp2.Grelha.CurrentRow == null) return;
            dgvFormasp2.Grelha.CurrentRow.Cells["valor"].Value = total;
            dgvFormasp2.Grelha.CurrentRow.Cells["mvalor"].Value = mtotal;
            dgvFormasp2.Grelha.CurrentRow.Cells["Origem2"].Value = origem;
            dgvFormasp2.Grelha.CurrentRow.Cells["Codmovtz"].Value = Codmovtz;
            dgvFormasp2.Grelha.CurrentRow.Cells["Descmovtz"].Value = Descmovtz;
            dgvFormasp2.Grelha.CurrentRow.Cells["Dcheque"].Value = Pbl.SqlDate;
            dgvFormasp2.Grelha.CurrentRow.Cells["contatesoura"].Value = Pbl.Usr.ContaTesoura;
            dgvFormasp2.Grelha.CurrentRow.Cells["Codtz"].Value = Pbl.Usr.Codtz;
            dgvFormasp2.Grelha.CurrentRow.Cells["Contasstamp"].Value = Pbl.Usr.Contasstamp;
            dgvFormasp2.Grelha.CurrentRow.Cells["UsrLogin"].Value = Pbl.Usr.Usrstamp;
        }
        public static void SetPdfFile(DataGridView gridUi1, string nomeColuna, string campoBind)
        {
            var nome = gridUi1.CurrentCell.OwningColumn.Name;
            if (nome.Equals(nomeColuna))
            {
                var opf = new OpenFileDialog
                {
                    Filter = @"Choose Image(*.pdf;)|*.pdf;"
                };
                if (opf.ShowDialog() != DialogResult.OK) return;
                var bytes = File.ReadAllBytes(opf.FileName);
                if (gridUi1.CurrentRow != null)
                    gridUi1.CurrentRow.Cells[campoBind.Trim()].Value = bytes;
            }
        }

        public static void ViewPdfFile(DataGridView gridUi1, string nomeColuna, string campoBind)
        {
            var nome = gridUi1.CurrentCell.OwningColumn.Name;
            if (nome.Equals(nomeColuna.Trim()))
            {
                if (gridUi1.CurrentRow == null) return;
                var value = gridUi1.CurrentRow.Cells[campoBind.Trim()].Value;
                if (value != null)
                {
                    var bite = (byte[])value;
                    var p = new FrmPdfViewer();
                    p.axAcroPDF1.LoadFile(ConvertByteToPdf(bite));
                    p.ShowDialog();
                }
            }
        }
        //public static void SetPdfFile(DataGridView gridUi1, string nomeColuna, string campoBind)
        //{
        //    var nome = gridUi1.CurrentCell.OwningColumn.Name;
        //    if (nome.Equals(nomeColuna))
        //    {
        //        var opf = new OpenFileDialog
        //        {
        //            Filter = @"Choose Image(*.pdf;)|*.pdf;"
        //        };
        //        if (opf.ShowDialog() != DialogResult.OK) return;
        //        var bytes = File.ReadAllBytes(opf.FileName);
        //        if (gridUi1.CurrentRow != null)
        //            gridUi1.CurrentRow.Cells[campoBind.Trim()].Value = bytes;
        //    }
        //}

        //public static void ViewPdfFile(DataGridView gridUi1, string nomeColuna, string campoBind)
        //{
        //    var nome = gridUi1.CurrentCell.OwningColumn.Name;
        //    if (nome.Equals(nomeColuna.Trim()))
        //    {
        //        if (gridUi1.CurrentRow == null) return;
        //        var bite = (byte[])gridUi1.CurrentRow.Cells[campoBind.Trim()].Value;
        //        var p = new FrmPdfViewer();

        //        var xxx = ConvertByteToPdf(bite);
        //        p.webBrowser1.Navigate(xxx);
        //        //p.axNitroPDF1.SetLayoutMode(1);
        //        //p.axAcroPDF1.LoadFile(ConvertByteToPdf(bite));
        //        p.ShowDialog();
        //        //if (gridUi1.CurrentRow != null)
        //        //{
        //        //    byte[] imgemArray = gridUi1.CurrentRow.Cells[campoBind.Trim()].Value as byte[];

        //        //    var im = Utilities.ByteToImage(imgemArray);
        //        //    var frmimageViewer = new FrmImageView();
        //        //    frmimageViewer.pictureBox2.Image = im;
        //        //    frmimageViewer.ShowDialog();
        //        //}
        //    }
        //}

        public static void CriaConta(DataRow r,GridUi gridContasCT,string no)
        {
            gridContasCT.AddLine();
            gridContasCT.DataRowr["Descgrupo"] = r["Descricao"];
            gridContasCT.DataRowr["Contacc"] = true;
            //var contmascara = SQL.GetField("Contmascara", "param");
            //var lista = new List<SqlParameter>
            //{
            //    new SqlParameter("@Radical", SqlDbType.Char, 30),
            //    new SqlParameter("@Ano", SqlDbType.Decimal),
            //    new SqlParameter("@Conta", SqlDbType.Char, 30),
            //    new SqlParameter("@LenConta", SqlDbType.Int),
            //    new SqlParameter("@Mascara", SqlDbType.Char, 10)
            //};
            //lista[0].Value = r["Grupo"].ToString().Trim();
            //lista[1].Value = Pbl.AnoContabil();
            //lista[2].Value = "";
            //var len = (r["Grupo"].ToString().Trim() + contmascara.ToString().Trim()).Trim().Length;
            //lista[3].Value = len;
            //lista[4].Value = r["Mascara"].ToString().Trim();
            var conta = r["Grupo"].ToString().Trim()+no.Trim();// SQL.SqlSP("GetContaMax", lista);
            gridContasCT.DataRowr["Conta"] = conta;
        }
        public static DataTable IvaSetting(string campo,Control e)
        {
            const string qry = "select Codigo,Descricao from Auxiliar where tabela = 5 order by Codigo";
            return SetBinds(e, $"{campo}", qry);
        }

        internal static void MostraCentroNaLinha(GridUIFt gridUIFt1)
        {
            var mostraccusto=SQL.GetValue("Mostraccusto","param").ToBool();
            //gridUIFt1.Columns["codccu"].Visible=mostraccusto;
            gridUIFt1.Columns["Ccu"].Visible=mostraccusto;
        }

        public static void CallForm(string tabela,string frmname, GridUi gridUi1,Form f,List<Usracessos> ListaUsracessos)
        {
            DataTable dt = null;
            if (gridUi1.CurrentRow == null) return;
            var localstamp = gridUi1.CurrentRow.Cells["localstamp"].Value.ToString();
            if (!string.IsNullOrEmpty(localstamp))
            {
                dt = SQL.GetGenDT(tabela, $" where {tabela}stamp='{localstamp}'", "*");
                if (dt.HasRows())
                {
                    var myAssembly = Assembly.GetExecutingAssembly();
                    var types = myAssembly.GetTypes();
                    var f2 = GetForms(types, frmname);
                    if (f2 == null) return;
                    {
                        var ss = ListaUsracessos.First();
                        f2.GetType().GetProperties().FirstOrDefault(x => x.Name.Equals("ListaUsracessos"))?.SetValue(f2, ListaUsracessos);
                        f2.GetType().GetProperties().FirstOrDefault(x => x.Name.Equals("Usracessos"))?.SetValue(f2, ss);
                        f2.GetType().GetProperties().FirstOrDefault(x => x.Name.Equals("Procurou"))?.SetValue(f2, true);
                        ((FrmClasse)f2).ShowForm(f);
                        ((FrmClasse)f2).Usracessos = ss;
                        f2.GetType().GetMethod("UpdateObjects")?.Invoke(f2, new object[] { dt });
                        f2.GetType().GetMethod("PreencheCampos")?.Invoke(f2, new object[] { dt, 0 });
                    }
                }
            }
            else
            {
                MsBox.Show(Messagem.ParteInicial() + "A chave do documento origem não foi encontrada!");
            }

        }
        private static object GetForms(IEnumerable<Type> types,string frmname)
        {
            object obj1 = null;
            foreach (var t in types)
            {
                if (t.BaseType == null) continue;
                if (t.BaseType.Name.Trim() != "FrmClasse") continue;
                if (!t.Name.ToLower().Equals(frmname.ToLower())) continue;
                obj1 = Activator.CreateInstance(t);
                break;
            }
            return obj1;
        }
        public static void UpdateGridModulos(DataGridView gridUi1,string stampaName,DataTable dt,string CLocalStamp)
        {
            if (!(dt?.Rows.Count > 0)) return;
            var tab = gridUi1.DataSource as DataTable;
            foreach (var r in dt.AsEnumerable())
            {
                if (r == null) continue;
                if (tab == null) continue;
                var dr = tab.NewRow().Inicialize();
                dr["codigo"]=r["descricao"].ToString();
                dr["descricao"]=r["obs"].ToString();
                dr[$"{stampaName.Trim()}"]=CLocalStamp;
                tab.Rows.Add(dr);
            }
            gridUi1.DataSource = null;
            gridUi1.DataSource = tab;
            gridUi1.Update();
        }

        internal static void UpdateGrid(bool @checked, DataGridView gridProcess,DataTable _dtSearch,string tbProcura, string campo=null,bool origem =false)
        {
            if (!_dtSearch.HasRows()) return;
            if (!tbProcura.IsNullOrEmpty())
            {
                string colName;
                if (campo.IsNullOrEmpty())
                {
                    colName = @checked ? "no" : "nome";
                }
                else
                {
                    colName = campo;
                }
                var condicao = $"{colName} like '%{tbProcura.Trim()}%'";
                try
                {
                    var dtSearched = _dtSearch.Select(condicao).CopyToDataTable();
                    if (dtSearched.HasRows())
                    {
                        if (origem)
                        {
                            dtSearched.AddEmptyRow();
                        }
                        gridProcess.DataSource = null;
                        gridProcess.DataSource = dtSearched;
                    }
                    else
                    {
                        gridProcess.DataSource = null;
                        gridProcess.DataSource = _dtSearch;
                    }
                }
                catch (Exception)
                {
                    gridProcess.DataSource = null;
                    gridProcess.DataSource = _dtSearch;
                }
            }
            else
            {
                gridProcess.DataSource = null;
                gridProcess.DataSource = _dtSearch;
            }
        }

        public static MemoryStream CreatePDF(DataTable database, string customerName, DateTime date, string code)
        {
            var Helvetica12B = FontFactory.GetFont(BaseFont.HELVETICA, 12, Font.BOLD);
            var Helvetica10 = FontFactory.GetFont(BaseFont.HELVETICA, 10, Font.NORMAL);
            var Courier12 = FontFactory.GetFont(BaseFont.COURIER, 12, Font.NORMAL);

            var PDFData = new MemoryStream();
            var document = new Document(PageSize.LETTER, 50, 50, 80, 60);
            var PDFWriter = PdfWriter.GetInstance(document, PDFData);
            PDFWriter.ViewerPreferences = PdfWriter.PageModeUseOutlines;

            // Our custom Header and Footer is done using Event Handler
           // var PageEventHandler = new HeaderFooter();
           // PDFWriter.PageEvent = PageEventHandler;

            // Define the page header
            //PageEventHandler.HeaderFont = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 8, Font.ITALIC);
            //PageEventHandler.HeaderLeft = "Ticketing system";
            //PageEventHandler.HeaderRight = date.ToString("MMMM dd, yyyy HH:mm:ss");

            document.Open();

            document.Add(new Paragraph("Ticketing system", Helvetica12B));
            document.Add(new Paragraph("Orderer name: " + customerName, Helvetica10));
            document.Add(new Paragraph("Orders code: " + code, Helvetica10));
            document.Add(new Paragraph("Date: " + date.ToString("MMMM dd, yyyy HH:mm:ss"), Helvetica10));
            document.Add(new Paragraph(" ", Helvetica10));

            PdfPTable Orders = new PdfPTable(5);
            Orders.TotalWidth = document.PageSize.Width - 100;
            Orders.LockedWidth = true;
            float[] widthsTAS = { 15f, 30f, 35f, 10f, 10f };
            Orders.SetWidthPercentage(widthsTAS, document.PageSize);

            Orders.AddCell(new Paragraph("Organizer", Helvetica10));
            Orders.AddCell(new Paragraph("Date", Helvetica10));
            Orders.AddCell(new Paragraph("Title", Helvetica10));
            Orders.AddCell(new Paragraph("Row", Helvetica10));
            Orders.AddCell(new Paragraph("Number", Helvetica10));

            for (int i = 0; i < database.Rows.Count; i++)
            {
                Orders.AddCell(new Paragraph(database.Rows[i][0].ToString(), Helvetica10));
                Orders.AddCell(new Paragraph(Convert.ToDateTime(database.Rows[i][1].ToString()).ToString("MMMM dd, yyyy HH:mm"), Helvetica10));
                Orders.AddCell(new Paragraph(database.Rows[i][2].ToString(), Helvetica10));
                Orders.AddCell(new Paragraph(database.Rows[i][3].ToString(), Helvetica10));
                Orders.AddCell(new Paragraph(database.Rows[i][4].ToString(), Helvetica10));
            }

            document.Add(Orders);

            document.Close();

            return PDFData;
        }

        internal static DataTable GetTableByIndex(DataTable dt,int posicao)
        {
            return dt.AsEnumerable().Where((row, index) => index == posicao).CopyToDataTable();
        }

        internal static void UpdateLinhas(GridUIFt gridUIFt1, string clstamp)
        {
            var linhas = gridUIFt1.DataSource as DataTable;
            if (linhas?.Rows.Count > 0)
            {
                foreach (var row in linhas.AsEnumerable())
                {
                    if (row == null) continue;
                    if (row.RowState == DataRowState.Deleted) continue;
                    if (row["servico"].ToBool()) continue;
                    if (row["Entidadestamp"].ToString().IsNullOrEmpty())
                    {
                        row["Entidadestamp"] = clstamp;
                    }
                    if (row["ststamp"].ToString().IsNullOrEmpty())
                    {
                        row["ststamp"] = clstamp;
                    }
                }
            }
        }
        internal static (bool ret,string ms) CheckStstamp(GridUIFt gridUIFt1)
        {
            var linhas = gridUIFt1.DataSource as DataTable;
            (bool ret, string ms) retorno = (true,"");
            if (linhas?.Rows.Count > 0)
            {
                foreach (var row in linhas.AsEnumerable())
                {
                    if (row == null) continue;
                    if (row.RowState == DataRowState.Deleted) continue;
                    if (row["servico"].ToBool()) continue;
                    if (row["Entidadestamp"].ToString().IsNullOrEmpty())
                    {
                        break;
                        retorno.Item1 = false;
                        retorno.Item2 = $"O artigo {row["descricao"]} não possui o ststamp na linha, O software não irá movimentar o stock";

                    }
                }
            }
           return retorno;
        }

        public static byte[] Exportpdf(DataTable  dtEmployee,string name,string titulo)  
        {  
        var rec = new iTextSharp.text.Rectangle(PageSize.A4) {BackgroundColor = new BaseColor(Color.Olive)};
        var doc = new Document(rec);  
        doc.SetPageSize(PageSize.A4);
        var pdfData = new MemoryStream();
       // var document = new Document(PageSize.LETTER, 50, 50, 80, 60);
        var pdfWriter = PdfWriter.GetInstance(doc, pdfData);
        pdfWriter.ViewerPreferences = PdfWriter.PageModeUseOutlines;

       // var writer = PdfWriter.GetInstance(doc, ms);  
       //var output = new FileStream(fileName, FileMode.Create);
       //var writer = PdfWriter.GetInstance(doc, output);
        doc.Open();
        pdfWriter.PageEvent = new Footer();
        var image = iTextSharp.text.Image.GetInstance(Pbl.Empresa.Logo);
        image.ScalePercent(25f);//5f
        doc.Add(image);
        //Paragrafo vazio 
        var bfntHead = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
        var fntHead = new Font(bfntHead, 14, 1, BaseColor.BLUE);
        var pv = new Paragraph {Alignment = Element.ALIGN_CENTER};
        pv.Add(new Chunk("\r\n", fntHead));  
        doc.Add(pv);  
        //Creating paragraph for header  

        var prgHeading = new Paragraph {Alignment = Element.ALIGN_CENTER};
        prgHeading.Add(new Chunk(titulo.ToUpper(), fntHead));  
        doc.Add(prgHeading);  
  
        //Adding paragraph for report generated by  
        //var prgGeneratedBy = new Paragraph();  
        //var btnAuthor = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);  
        //var fntAuthor = new iTextSharp.text.Font(btnAuthor, 8, 2, BaseColor.BLUE);  
        //prgGeneratedBy.Alignment = Element.ALIGN_RIGHT;  
        //prgGeneratedBy.Add(new Chunk($"Documento gerado por : {Pbl.Info}", fntAuthor));  
        //prgGeneratedBy.Add(new Chunk("\nData : " + DateTime.Now.ToShortDateString(), fntAuthor));  
        //doc.Add(prgGeneratedBy);  
  
        //Adding a line  
        var p = new Paragraph(new Chunk(new LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1)));  
        doc.Add(p);
        //Adding line break  
        doc.Add(new Chunk("\n", fntHead));
        //Adding  PdfPTable  
        //var widths = new float[dtEmployee.Columns.Count];
        var table = new PdfPTable(dtEmployee.Columns.Count) {WidthPercentage = 100f};
        
        //float[] widths = new float[] { 6f, 6f, 2f, 4f, 2f };

        //table.SetWidths(widths);

        //table.WidthPercentage = 100;
        //table.LockedWidth = true;
        for (var i = 0; i < dtEmployee.Columns.Count; i++)  
        {  
            var cellText = dtEmployee.Columns[i].ColumnName.ToUpper();
            var cell = new PdfPCell
            {
                Phrase = new Phrase(cellText,
                    new Font(Font.FontFamily.HELVETICA, 10, 1,
                        new BaseColor(ColorTranslator.FromHtml("#000000")))),
                BackgroundColor = new BaseColor(ColorTranslator.FromHtml("#C8C8C8")),
                HorizontalAlignment = Element.ALIGN_CENTER,
                PaddingBottom = 1
            };

            table.AddCell(cell);  
        }  
  
        //writing table Data  
        for (var i = 0; i < dtEmployee.Rows.Count; i++)  
        {  
            for (var j = 0; j < dtEmployee.Columns.Count; j++)  
            {
                var cellText = dtEmployee.Rows[i][j].ToString();
                if (dtEmployee.Columns[j].DataType == typeof(decimal))
                {
                    cellText = cellText.SetMask();
                }
                var cell = new PdfPCell
                {
                    Phrase = new Phrase(cellText,
                        new Font(Font.FontFamily.HELVETICA, 8, 0,
                            new BaseColor(ColorTranslator.FromHtml("#000000")))),
                    BackgroundColor = new BaseColor(Color.White),
                    HorizontalAlignment = Element.ALIGN_LEFT,
                    PaddingBottom = 1
                };
                if (dtEmployee.Columns[j].DataType == typeof(string))
                {
                    cell.HorizontalAlignment = Element.ALIGN_LEFT;
                }
                if (dtEmployee.Columns[j].DataType == typeof(decimal))
                {
                    cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                }
                table.AddCell(cell);
                //table.AddCell(new Phrase(dtEmployee.Rows[i][j].ToString(),new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 8, 1)));  
            }  
        }  
  
        doc.Add(table);  
        doc.Close();

            byte[] result = pdfData.ToArray();
            return result;
            //return fileName;

    }

        internal static string GetArmazemQry()
        {
            return $"select Codarm,Descricao,Armazemstamp from Ccu_Arm where Ccustamp ='{Pbl.Usr.Ccustamp}'";
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
        public static DataRow NewGridRowUi(Form f)
        {
            DataRow dr = null;
            var gridUi1 = (GridUi)GetAll(f, typeof(GridUi)).FirstOrDefault(x => x.Name.Equals("gridUIFt1"));
            if (gridUi1 == null) return dr;
            dr = gridUi1.DtDS.NewRow();
            if (!((FrmClasse)f).EditMode) return dr;
            string stampFilha;
            var stampPai = gridUi1.StampCabecalho;
            stampFilha = gridUi1.StampLocal;
            dr[stampPai] = ((FrmClasse)f).CLocalStamp;
            dr[stampFilha] = Pbl.Stamp();
            dr["servico"] = true;
            var nMaxOrdem = gridUi1.DtDS.Rows.Count;
            nMaxOrdem = nMaxOrdem + 1;
            dr["ordem"] = nMaxOrdem;
            gridUi1.DtDS.Rows.Add(dr);
            gridUi1.Update();
            if (gridUi1.Rows.Count <= 0) return dr;
            var index = gridUi1.Rows.Count - 1;
            gridUi1.CurrentCell = gridUi1.Rows[index].Cells["descricao"];
            gridUi1.BeginEdit(true);
            gridUi1.Refresh();
            return dr;
        }

        public static void Anexos(this DataGridView grid)
        {
            var nome = grid.CurrentCell.OwningColumn.Name.ToLower().Trim();
            if (nome.Equals("anexo"))
            {
                var opf = new OpenFileDialog
                {
                    Filter = $@"Pdf files(*.Pdf)|*.Pdf| All Files(*.*)|*.*"
                };
                if (opf.ShowDialog() != DialogResult.OK) return;
                var fn = opf.FileName;
                var bite = File.ReadAllBytes(fn);
                if (grid.CurrentRow != null)
                  grid.CurrentRow.Cells["Anexo"].Value = bite;
            }
            else if (nome.Equals("viewdoc")) 
            {
                if (grid.CurrentRow == null) return;
                var bite = (byte[])grid.CurrentRow.Cells["Anexo"].Value;
                var p= new FrmPdfViewer();
                //p.axNitroPDF1.SetLayoutMode(1);
              //  p.axAcroPDF1.LoadFile(ConvertByteToPdf(bite));

                p.ShowDialog();
            }
        }
        public static string ConvertByteToPdf(byte[] anexo)
        {
            var spathfile = Application.StartupPath+"\\PDFFiles";
            try    
            {
                if (!Directory.Exists(spathfile))
                {
                    Directory.CreateDirectory(spathfile);
                }
                spathfile =spathfile+ $"\\Ficheiro{DateTime.Now.Second.ToString()+DateTime.Now.Millisecond}.pdf";
                File.WriteAllBytes(spathfile, anexo);
            }
            catch (Exception ex)    
            {
                MessageBox.Show(ex.ToString());
            }
            return spathfile;

        }
        public static IEnumerable<Control> GetAll(Control control, Type type = null)
        {
            var controls = control.Controls.Cast<Control>();
            var enumerable = controls as Control[] ?? controls.ToArray();
            return type == null ? enumerable.SelectMany(ctrl => GetAll(ctrl, null)).Concat(enumerable) : controls.SelectMany(ctrl => GetAll(ctrl, type)).Concat(enumerable).Where(c => c.GetType() == type);
        }
        public static bool CheckEnterKey(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (decimal)Keys.Enter) return false;
            return true;//!string.IsNullOrEmpty(((TextBox)sender).Text);
        }

        static PaperSize _tamanho; //
        public static void Print(this LocalReport report,bool pos=false, bool email=false)
        {
            _tamanho=report.GetDefaultPageSettings().PaperSize;
            var pageSettings = new PageSettings
            {
                PaperSize = _tamanho,
                Landscape = report.GetDefaultPageSettings().IsLandscape,
                Margins = report.GetDefaultPageSettings().Margins
            };
            pageSettings.Margins.Top = 0;
            pageSettings.Margins.Bottom = 0;
            pageSettings.Margins.Left = 0;
            pageSettings.Margins.Right = 0;
            report.Refresh();
            Print(report, pageSettings,pos,email);
        }
        public static void Print(this LocalReport report, PageSettings pageSettings,bool pos, bool enviaemail=false )
        {   
            var deviceInfo = "";
            deviceInfo = $@"<DeviceInfo>
                <OutputFormat>EMF</OutputFormat>
                <PageWidth>{pageSettings.PaperSize.Width * 100}in</PageWidth>
                <PageHeight>{_tamanho.Height}in</PageHeight>
                <MarginTop>{pageSettings.Margins.Top * 100}in</MarginTop>
                <MarginLeft>{pageSettings.Margins.Left * 50}in</MarginLeft>
                <MarginRight>{pageSettings.Margins.Right * 100}in</MarginRight>
                <MarginBottom>{pageSettings.Margins.Bottom * 100}in</MarginBottom>
            </DeviceInfo>";
            Warning[] warnings;
            var streams = new List<Stream>();
            var currentPageIndex = 0;

            report.Render("Image", deviceInfo,
                (name, fileNameExtension, encoding, mimeType, willSeek) =>
                {
                    var stream = new MemoryStream();
                    streams.Add(stream);
                    return stream;
                }, out warnings);

            foreach (var stream in streams)
                stream.Position = 0;

            if (streams == null || streams.Count == 0)
                throw new Exception("Error: no stream to print.");

            var printDocument = new PrintDocument()
            {
              
            };
            printDocument.DefaultPageSettings = pageSettings;
            if (!printDocument.PrinterSettings.IsValid)

                throw new Exception("Error: cannot find the default printer.");
            printDocument.PrintPage += (sender, e) =>
            {
                var pageImage = new Metafile(streams[currentPageIndex]);
                var adjustedRect = new Rectangle(
                    e.PageBounds.Left - (int)e.PageSettings.HardMarginX,
                    e.PageBounds.Top - (int)e.PageSettings.HardMarginY,
                    e.PageBounds.Width,
                    e.PageBounds.Height);
                e.Graphics.FillRectangle(Brushes.White, adjustedRect);
                e.Graphics.DrawImage(pageImage, adjustedRect);
                currentPageIndex++;
                e.HasMorePages = currentPageIndex < streams.Count;
                e.Graphics.DrawRectangle(Pens.Red, adjustedRect);


            };
            printDocument.EndPrint += (Sender, e) =>
            {
                if (streams == null) return;
                foreach (var stream in streams)
                    stream.Close();
                streams = null;
            };
            try
            {
                Pbl.MyPathName=string.Empty;
                if (enviaemail)
                {

                    Thread.Sleep(10);
                    var pft = Application.StartupPath;
                    pft += $"\\PDFFiles";
                    var prs = printDocument.PrinterSettings;
                    var tp = printDocument.PrinterSettings.PrinterName ="Microsoft Print to PDF";                    
                   Pbl.MyPathName= printDocument.PrinterSettings.PrintFileName =Path.GetFullPath($@"" + pft + $"\\Documento{Pbl.Stamp()}.pdf");
                    // tell the object this document will print to file
                    printDocument.PrinterSettings.PrintToFile = true;
                    
                }
            }
            catch (Exception ex)
            {
                //
            }
           

            printDocument.Print();
        }

        internal static void CellValidated(GridUIFt gridUIFt1,FrmClasse f,string sigla)
        {
            if (gridUIFt1.CurrentRow == null) return;
            var name = gridUIFt1.CurrentCell.OwningColumn.Name.ToLower().Trim();
            var mpreco=0;
            switch (name)
            {
                case "mpreco":
                    mpreco=1;
                    break;
                case "preco":
                    mpreco=2;
                    break;
                case "percdesc":
                    mpreco=3;
                    break;
            }

            Totaislinha(true, gridUIFt1.DsDt, f,sigla,mpreco);
        }

        internal static List<string> GetList<T>(T ent) where T : class
        {
            var props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            return props.Select(p => p.Name.Trim()).ToList();
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

       public static DataRow NewGridRow(Form f, bool nc =false )
       {
           DataRow dr = null;
           if (!((FrmClasse)f).EditMode) return dr;
            var gridUiFt1 = (GridUIFt)GetAll(f, typeof(GridUIFt)).FirstOrDefault(x=>x.Name.Equals("gridUIFt1"));
            if (gridUiFt1 == null) return dr;
            dr = gridUiFt1.DsDt.NewRow().Inicialize();            
            var stampPai=gridUiFt1.StampCabecalho;
            var stampFilha = gridUiFt1.StampLocal;
            dr[stampPai] = ((FrmClasse) f).CLocalStamp;
            //dr[stampFilha] = Pbl.Stamp();
            dr["servico"] = true;
            var nMaxOrdem = gridUiFt1.DsDt.Rows.Count;
            nMaxOrdem = nMaxOrdem + 1;
            dr["ordem"] = nMaxOrdem;
            dr["quant"] =nc? -1:1;
            gridUiFt1.DsDt.Rows.Add(dr);
            gridUiFt1.Update();
            if (gridUiFt1.Rows.Count <= 0) return dr;
            var index = gridUiFt1.Rows.Count - 1;
            gridUiFt1.CurrentCell = gridUiFt1.Rows[index].Cells["descricao"];
            gridUiFt1.BeginEdit(true);
            gridUiFt1.Refresh();
            return dr;
        }

        internal static string GetValueByMascara(string sigla,string mascara,DataTable dt)
        {
            var refec = "";
            var numero = dt.Rows[0][0].ToDecimal();
            if (mascara.Length > numero.ToString().Length)
            {
                switch (numero.ToString().Length)
                {
                    case 1:
                        refec = sigla.Trim() + mascara.Substring(0, mascara.Length - 1) + numero;
                        break;

                    case 2:
                        refec = sigla.Trim() + mascara.Substring(0, mascara.Length - 2) + numero;
                        break;
                    case 3:
                        refec = sigla.Trim() + mascara.Substring(0, mascara.Length - 3) + numero;
                        break;
                    case 4:
                        refec = sigla.Trim() + mascara.Substring(0, mascara.Length - 4) + numero;
                        break;
                    case 5:
                        refec = sigla.Trim() + mascara.Substring(0, mascara.Length - 5) + numero;
                        break;
                    case 6:
                        refec = sigla.Trim() + mascara.Substring(0, mascara.Length - 6) + numero;
                        break;
                    case 7:
                        refec = sigla.Trim() + mascara.Substring(0, mascara.Length - 7) + numero;
                        break;
                    case 8:
                        refec = sigla.Trim() + mascara.Substring(0, mascara.Length - 8) + numero;
                        break;
                    case 9:
                        refec = sigla.Trim() + mascara.Substring(0, mascara.Length - 9) + numero;
                        break;
                    case 10:
                        refec = sigla.Trim() + mascara.Substring(0, mascara.Length - 10) + numero;
                        break;
                }
            }
            else
            {
                refec = sigla.Trim() + numero;
            }
            return refec;
        } 
        public static void Totaislinha(bool origem,DataTable tabela,FrmClasse f,string sigla,int codigo=0)
        {
           if (!origem) return;          
           foreach (var dr in Enumerable.Where(tabela.AsEnumerable(), dr => dr != null))
           {
                switch (codigo)
                {
                    case 1:
                        dr["preco"]=(dr["mpreco"].ToDecimal()*dr["Cambiousd"].ToDecimal()).ToRound();
                        break;
                    case 2:
                    {
                        if (dr["Cambiousd"].ToDecimal()>0)
                        {
                            dr["mpreco"]=(dr["preco"].ToDecimal()/dr["Cambiousd"].ToDecimal()).ToRound();
                        }

                        break;
                    }
                    case 3:
                        dr["Descontol"] =0;
                        dr["mDescontol"] =0;
                        break;
                }

                GenBl.TotaisLinhas(dr);
           }

           TotaisFt(tabela,f);
           var control = GetAll(f, typeof(GridUIFt)).FirstOrDefault(x=>x.Name.Equals("gridUIFt1"));
           if (control != null)
           {
               ((GridUIFt) control).NotExecuteEndEditEvent = true;
               ((GridUIFt) control).EndEdit();
               ((GridUIFt) control).Refresh();
               ((GridUIFt) control).NotExecuteEndEditEvent = false;
           }
            Procura ucMoeda = (Procura)GetAll(f, typeof(Procura)).FirstOrDefault(x => x.Name.Equals("ucMoeda"));
            var moeda = "";
            if (ucMoeda != null)
            {
                moeda= ucMoeda.tb1.Text;  
            }
            VendaDiheiro(tabela, f, sigla, moeda);
           f.NVerificar = false;
       }
        public static void TotaislinhaClasse2(bool origem, DataTable tabela, FrmClasse2 f, string sigla, int codigo = 0)
        {
            if (!origem) return;
            foreach (var dr in Enumerable.Where(tabela.AsEnumerable(), dr => dr != null))
            {
                switch (codigo)
                {
                    case 1:
                        dr["preco"] = (dr["mpreco"].ToDecimal() * dr["Cambiousd"].ToDecimal()).ToRound();
                        break;
                    case 2:
                    {
                        if (dr["Cambiousd"].ToDecimal() > 0)
                        {
                            dr["mpreco"] = (dr["preco"].ToDecimal() / dr["Cambiousd"].ToDecimal()).ToRound();
                        }

                        break;
                    }
                    case 3:
                        dr["Descontol"] = 0;
                        dr["mDescontol"] = 0;
                        break;
                }

                GenBl.TotaisLinhas(dr);
            }
            TotaisFt(tabela, f);
        }
        public static void TotaisFt(DataTable table,Form f)
       {
           var controls = GetAll(f, typeof(TbDefault)).ToList();
           if (table == null) return;
           var Totalinteiro= SQL.GetField("Totalinteiro","param").ToBool();
           foreach (var control in controls)
           {
               if (((TbDefault)control).Value==null) continue;
               if (((TbDefault)control).Value.Trim().ToLower().Equals("desconto"))
               {
                   ((TbDefault)control).tb1.Text = table.AsEnumerable().Where(k=>k.RowState != DataRowState.Deleted).Sum(x => x.Field<decimal?>("Descontol")).ToString().SetMask(); 
               }
               if (((TbDefault)control).Value.Trim().ToLower().Equals("subtotal"))
               {
                   ((TbDefault)control).tb1.Text = table.AsEnumerable().Where(k=>k.RowState != DataRowState.Deleted).Sum(x => x.Field<decimal?>("Subtotall")).ToString().SetMask();
               }
               if (((TbDefault)control).Value.Trim().ToLower().Equals("total"))
               {
                   var total = table.AsEnumerable().Where(k => k.RowState != DataRowState.Deleted)
                       .Sum(x => x.Field<decimal?>("Totall")).ToDecimal();
                    if (Totalinteiro)
                    {
                        total=total.ToRound(0);
                    }
                   ((TbDefault) control).tb1.Text = total.ToString("0.00").SetMask(); //Math.Round(total,3).ToString().SetMask();
               }
               if (((TbDefault)control).Value.Trim().ToLower().Equals("totaliva"))
               {
                   ((TbDefault)control).tb1.Text = table.AsEnumerable().Where(k=>k.RowState != DataRowState.Deleted).Sum(x => x.Field<decimal?>("valival")).ToString().SetMask();
               }
               if (((TbDefault)control).Value.Trim().ToLower().Equals("mdesconto"))
               {
                   ((TbDefault)control).tb1.Text = table.AsEnumerable().Where(k=>k.RowState != DataRowState.Deleted).Sum(x => x.Field<decimal?>("mDescontol")).ToString().SetMask(); 
               }
               if (((TbDefault)control).Value.Trim().ToLower().Equals("msubtotal"))
               {
                   ((TbDefault)control).tb1.Text = table.AsEnumerable().Where(k=>k.RowState != DataRowState.Deleted).Sum(x => x.Field<decimal?>("mSubtotall")).ToString().SetMask();
               }
               if (((TbDefault)control).Value.Trim().ToLower().Equals("mtotal"))
               {
                   var total = table.AsEnumerable().Where(k => k.RowState != DataRowState.Deleted).Sum(x => x.Field<decimal?>("mTotall")).ToDecimal();
                    if (Totalinteiro)
                    {
                        total=total.ToRound(0);
                    }
                   ((TbDefault) control).tb1.Text = total.ToString().SetMask();
               }
               if (((TbDefault)control).Value.Trim().ToLower().Equals("mtotaliva"))
               {
                   ((TbDefault)control).tb1.Text = table.AsEnumerable().Where(k=>k.RowState != DataRowState.Deleted).Sum(x => x.Field<decimal?>("mvalival")).ToString().SetMask();
               }
               ((TbDefault)control).tb1.Text.SetMask();
           }
       }
       public static void VendaDiheiro(DataTable table,Form f,string origem,string moeda)
       {
           if (f == null) return;
            var clocalstamp = ((FrmClasse) f).CLocalStamp;            
            var tabStamp=((FrmClasse) f).Ctabela.Trim()+"stamp";
            var gridFormasP1 = (GridFormasP)GetAll(f, typeof(GridFormasP)).FirstOrDefault(x => x.Name.Equals("gridFormasP1"));
            var val = table.AsEnumerable().Where(k=>k.RowState != DataRowState.Deleted).Sum(x => x.Field<decimal?>("Totall")).ToDecimal();
            var mval = table.AsEnumerable().Where(k => k.RowState != DataRowState.Deleted).Sum(x => x.Field<decimal?>("Totall")).ToDecimal();
            if ( gridFormasP1 != null && gridFormasP1.Formaspdt.Rows.Count == 0)
           {
               var r = gridFormasP1.Formaspdt.NewRow().Inicialize();
               r["Valor"] = val;
               r["Mvalor"] = val;
               r[tabStamp] = clocalstamp;
               r["Origem"] = origem;//"FT";
               r["Dcheque"] = Pbl.SqlDate;
               r["Codtz"] = Pbl.Usr.Codtz;
               r["banco"] = Pbl.Usr.Sigla;
               r["Contatesoura"] = Pbl.Usr.ContaTesoura;
               r["ObgTitulo"] = false;//
               r["Numer"] = false;//Tipo
               r["Tipo"] = false;//Status
               r["Status"] = false;//
               r["Contasstamp"] = Pbl.Usr.Contasstamp;//
               r["UsrLogin"] = Pbl.Usr.Usrstamp;//
               r["moeda"] = moeda;//
               gridFormasP1.Formaspdt.Rows.Add(r);
           }
            else
           {
               if (gridFormasP1 == null) return;
               if (gridFormasP1.Grelha.CurrentRow != null) 
                   gridFormasP1.Grelha.CurrentRow.Cells["Valor"].Value = val;
               gridFormasP1.Grelha.Update();

           }
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

       public static void ClearControls(Form frm)
       {
           ((FrmClasse)frm).LimparCampos2();
           ((FrmClasse)frm).ClearDataGridView();
           ((FrmClasse)frm).Lista=null;
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

       internal static void CellValueChanged(DataGridViewCell currentCell, FrmClasse frm)
        {

            var name = currentCell.OwningColumn.Name.ToLower().Trim();
            if (name.Equals("mdescontol") || name.Equals("mpreco") || name.Equals("percdesc") || name.Equals("quant") || name.Equals("preco") || name.Equals("ivainc") || name.Equals("desconto"))
            {
                frm.NVerificar = true;
            }
        }


        public static DataRow InicializeEnty(this DataRow dr)
        {
            var ctabela = dr.Table.TableName.ToLower();
             foreach (DataColumn col in dr.Table.Columns)
            {
                if (col.DataType== typeof(DateTime))
                {
                    dr[col.ColumnName.Trim()] = Pbl.SqlDate;
                }
                if (col.DataType == typeof(string))
                {

                    dr[col.ColumnName.Trim()] = "";
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

        public static List<Control> CamposObrigatorios(FrmClasse forClasse)
        {
            var c = GetAll(forClasse, typeof(TbDefault)).Where(x => ((TbDefault)x).Obrigatorio.Equals(true)).Where(x => string.IsNullOrEmpty(((TbDefault)x).tb1.Text)).ToList();
            var c2 = GetAll(forClasse, typeof(Procura)).Where(x => ((Procura)x).IsRequered.Equals(true)).Where(x => string.IsNullOrEmpty(((Procura)x).tb1.Text)).ToList();
            var c3 = GetAll(forClasse, typeof(DmzOptionGroup)).Where(x => ((DmzOptionGroup)x).CheckSelected().Equals(true)).ToList();
            c.AddRange(c2.Where(ctx => ctx != null));
            c.AddRange(c3.Where(ctx => ctx != null));
            return c;
        }
        public static void CheckRequered(IEnumerable<Control> lista)
        {
           // Cancelado = true;
            var str = string.Empty;
            foreach (var control in lista.Where(control => control != null))
            {
                
                switch (control)
                {
                    case TbDefault tbDefault:
                    {
                        var @default = tbDefault;
                        @default.ExecutaHighLigth();
                        if (string.IsNullOrEmpty(str))
                        {
                            str = "\r\n" + $"  {tbDefault.Label1Text},";
                        }
                        else
                        {
                            str = str + "\r\n" + $"  {tbDefault.Label1Text},";
                        }

                        break;
                    }
                    case Procura procura:
                    {
                        procura.ExecutaHighLigth();
                        if (string.IsNullOrEmpty(str))
                        {
                            str = "\r\n" + $"  {procura.Label1Text},";
                        }
                        else
                        {
                            str = str + "\r\n" + $"  {procura.Label1Text},";
                        }

                        break;
                    }
                    case DmzOptionGroup group:
                    {
                        var val =@group.CheckSelected();
                        if (!val)
                        {
                            if (string.IsNullOrEmpty(str))
                            {
                                str = "\r\n" + $"  {@group.label1.Text},";
                            }
                            else
                            {
                                str = str + "\r\n" + $"  {@group.label1.Text},";
                            }
                        }

                        break;
                    }
                }
            }
            var lenght = str.Split(',').Length-1;
            str = str.Replace(",", "");
            if (lenght == 1)
            {
                
                MsBox.Show($"O Campo {str} \r\né Obrigratório\r\nVeja em todas as páginas");
            }
            else if(lenght > 1)
            {
                MsBox.Show($"Os Campos {str} \r\nsão Obrigratórios\r\nVeja em todas as páginas",300);
            }
        }

        public static void FillProduct(DataTable dt,Form f)
        {
            if (f!=null)
            {
                if (dt.HasRows())
                {
                    ((FrmPosRest)f).fLPSubProduct.Controls.Clear();
                    foreach (var item in dt.AsEnumerable())
                    {
                        var sB = new DMZProduto
                        {
                            Nome = item["Descricao"].ToString(),
                            Refenrec = item["ststamp"].ToString(),
                            Usaquant2 = item["Usaquant2"].ToBool(),
                        };
                        if (item["Usaquant2"].ToBool())
                        {
                            sB.Preco ="0 MZN";
                        }
                        else
                        {
                            sB.Preco = item["preco"].ToString().SetMask() + " MZN";
                        }
                        var imagem = Util.ByteToImage((byte[])item["Imagem"]);
                        sB.picBoxProduct.Image = imagem;
                        sB.tbStock.Text = item["quant"].ToString();
                        ((FrmPosRest)f).fLPSubProduct.Controls.Add(sB);
                    } 
                }
            }
        }

        public static void FillMesa(DataTable dt, Form f)
        {
           
            foreach (var item in dt.AsEnumerable())
            {
                if (item==null) continue;
                var sB = new DMZMesas
                {
                    lblName = {Text = item["Nome"].ToString()}
                };
                sB.Dr = item;
                Image imagem = null;
                if (!item["Imagem"].ToString().IsNullOrEmpty())
                {
                    imagem = Util.ByteToImage((byte[])item["Imagem"]);
                }                        
                sB.picBoxProduct.Image = imagem;
                var valor = GenBl.MesaValor(item["no"].ToDecimal());
                sB.lblValor.Text = valor==0 ? "" : valor.ToString().SetMask();
                if (valor>0)
                {
                    sB.panelClassificador.BackColor= Color.Maroon; 
                }
                else
                {
                    sB.panelClassificador.BackColor= Color.DarkSeaGreen; 
                }
                ((FrmPosRest)f).fLPSubProduct.Controls.Add(sB);
            }
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



        public static void GridCellEndEdit(GridUi grid, DataTable dt,List<Parametros> paramets,string campoQuerry)
        {
            if (grid.CurrentRow == null) return;
            if (dt==null) return;
            var valor = grid.CurrentCell.Value.ToString().Trim();
            var dr = dt.AsEnumerable().FirstOrDefault(s => s.Field<string>(campoQuerry).Trim().Equals(valor));
            if (dr == null) return;
            foreach (var p in paramets)
            {
                if (p== null) continue;
                grid.CurrentRow.Cells[p.Param1].Value = dr[p.Param2]; 
            }
            
        }

        public static I CreateInstance<I>(string formName) where I : Form
        {
            var myAssembly = Assembly.GetExecutingAssembly();
            var type = myAssembly.GetTypes().FirstOrDefault(t => t.Name.ToLower().Equals(formName.ToLower()));
            if (type == null) return null;
            var  c = Activator.CreateInstance(type);
            return (I)c;
        }

        public static DataTable FillPrintDt(string factstamp)
        {
            if (Ds == null)
            {
                Ds = new DS {EnforceConstraints = false};
            }
            using (var con = new GCon())
            {
                Ds.EnforceConstraints = false;
                var factadaptador = new FactTableAdapter {Connection = con.NResult};
                factadaptador.Fill(Ds.Fact, factstamp);
                return Ds.Fact;
            }
        }

        public static DS Ds { get; set; }
         

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
                        var rw = dtformasp.NewRow().InicializeEnty();
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

        internal static T ShowForm<T>(DemoMdi demoMdi) where T : Form, new()
        {
            var w = new T();
            w.ShowForm(demoMdi);
            return w;
        }

        public static string GetFile()
        {

            //var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //var connectionString=config.ConnectionStrings.ConnectionStrings["DefaultConnection"].ConnectionString;
            //var builder = new SqlConnectionStringBuilder(connectionString);

            var builder = new SqlConnectionStringBuilder(SqlHelper.GetConString());


            var xmlPath = Application.StartupPath + "\\" + $"Licence{builder.InitialCatalog.Trim()}.xml";
            if (!File.Exists(xmlPath))
            {
                xmlPath = Application.StartupPath + "\\" + "Licence.xml"; 
            }

            return xmlPath;
        }

        public static DataTable GetModulos(GridUi gridModulos = null)
        {
                var xmlFile = XmlReader.Create(GetFile(), new XmlReaderSettings());
                var dataSet = new DataSet();
                dataSet.ReadXml(xmlFile);
                var licdt = dataSet.Tables[0];
                if (gridModulos !=null)
                {
                    var dtMod = SQL.GetGenDT("select Descricao,obs from Modulos");
                    foreach (var row in licdt.AsEnumerable())
                    {
                        if (row == null) continue;
                        if (Criptografia.Decrypt(row["Ges"].ToString()).ToBool())
                        {
                            var r = dtMod.Select("Descricao='GES'").CopyToDataTable().Rows[0];
                            CarregarGrid(r, Criptografia.Decrypt(row["Fulllicval"].ToString()),gridModulos);
                        }

                        if (Criptografia.Decrypt(row["POSR"].ToString()).ToBool())
                        {
                            var r = dtMod.Select("Descricao='POSR'").CopyToDataTable().Rows[0];
                            CarregarGrid(r, Criptografia.Decrypt(row["Fulllicval"].ToString()), gridModulos);
                        }

                        if (Criptografia.Decrypt(row["CT"].ToString()).ToBool())
                        {
                            var r = dtMod.Select("Descricao='CT'").CopyToDataTable().Rows[0];
                            CarregarGrid(r, Criptografia.Decrypt(row["Ctval"].ToString()), gridModulos);
                        }

                        if (Criptografia.Decrypt(row["AC"].ToString()).ToBool())
                        {
                            var r = dtMod.Select("Descricao='AC'").CopyToDataTable().Rows[0];
                            CarregarGrid(r, Criptografia.Decrypt(row["Fulllicval"].ToString()), gridModulos);
                        }

                        if (Criptografia.Decrypt(row["RHS"].ToString()).ToBool())
                        {
                            var r = dtMod.Select("Descricao='RHS'").CopyToDataTable().Rows[0];
                            CarregarGrid(r, Criptografia.Decrypt(row["Rhval"].ToString()), gridModulos);
                        }

                        if (Criptografia.Decrypt(row["POSM"].ToString()).ToBool())
                        {
                            var r = dtMod.Select("Descricao='POSM'").CopyToDataTable().Rows[0];
                            CarregarGrid(r, Criptografia.Decrypt(row["Fulllicval"].ToString()), gridModulos);
                        }

                        if (Criptografia.Decrypt(row["PJ"].ToString()).ToBool())
                        {
                            var r = dtMod.Select("Descricao='PJ'").CopyToDataTable().Rows[0];
                            CarregarGrid(r, Criptografia.Decrypt(row["Fulllicval"].ToString()), gridModulos);
                        }

                        if (Criptografia.Decrypt(row["FT"].ToString()).ToBool())
                        {
                            var r = dtMod.Select("Descricao='FT'").CopyToDataTable().Rows[0];
                            CarregarGrid(r, Criptografia.Decrypt(row["Fulllicval"].ToString()), gridModulos);
                        }
                        if (Criptografia.Decrypt(row["PRC"].ToString()).ToBool())
                        {
                            var r = dtMod.Select("Descricao='PRC'").CopyToDataTable().Rows[0];
                            CarregarGrid(r, Criptografia.Decrypt(row["Fulllicval"].ToString()), gridModulos);
                        }
                        if (Criptografia.Decrypt(row["IMB"].ToString()).ToBool())
                        {
                            var r = dtMod.Select("Descricao='IMB'").CopyToDataTable().Rows[0];
                            CarregarGrid(r, Criptografia.Decrypt(row["Ctval"].ToString()), gridModulos);
                        }
                    }
                }   

                xmlFile.Close();
                return licdt;
        }

        static void CarregarGrid(DataRow r, string data,GridUi gridModulos)
        {
            gridModulos.AddLine();
            gridModulos.DataRowr["Sigla"] = r["Descricao"];
            gridModulos.DataRowr["Descricao"] = r["obs"];
            gridModulos.DataRowr["Validade"] =data.ToDateTimeValue();
            gridModulos.DataRowr["Trial"] = false;
        }

        public static void TotaisFtItem(DataTable table, Form f)
        {
            var controls = GetAll(f, typeof(TbDefault)).ToList();
            if (table == null) return;
            foreach (var control in controls)
            {
                if (control is TbDefault && control.Name.Equals("tbDescontoItem"))
                {
                    ((TbDefault)control).tb1.Text = table.AsEnumerable().Where(k => k.RowState != DataRowState.Deleted).Sum(x => x.Field<decimal?>("Descontol")).ToString().SetMask();
                }
                if (control is TbDefault && control.Name.Equals("tbSubTotalItem"))
                {
                    var xx = table.AsEnumerable().Where(k => k.RowState != DataRowState.Deleted).Sum(x => x.Field<decimal?>("Subtotall")).ToString().SetMask();
                    ((TbDefault)control).tb1.Text = xx;
                }

                if (control is TbDefault && control.Name.Equals("tbTotalItem"))
                {
                    ((TbDefault)control).tb1.Text = table.AsEnumerable().Where(k => k.RowState != DataRowState.Deleted).Sum(x => x.Field<decimal?>("Totall")).ToString().SetMask();
                }
                if (control is TbDefault && control.Name.Equals("tbTotalIvaItem"))
                {
                    ((TbDefault)control).tb1.Text = table.AsEnumerable().Where(k => k.RowState != DataRowState.Deleted).Sum(x => x.Field<decimal?>("valival")).ToString().SetMask();
                }
            }
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
                    if (campos.IsNullOrEmpty())
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

        internal static void CellValueChangedItem(DataGridViewCell currentCell, FrmClasse frm)
        {
            var name = currentCell.OwningColumn.Name.ToLower().Trim();
            if (name.Equals("percdesc2") || name.Equals("quant2") || name.Equals("preco2") || name.Equals("ivainc2"))
            {
                frm.NVerificar = true;
            }
        }

        public static void TotaislinhaItem(bool origem, DataTable tabela, FrmClasse f, string sigla)
        {
            if (!origem) return;
            foreach (var dr in Enumerable.Where(tabela.AsEnumerable(), dr => dr != null))
            {
                GenBl.TotaisLinhasItem(dr);
            }

            TotaisFtItem(tabela, f);
            var control = GetAll(f, typeof(GridUi)).FirstOrDefault(x => x.Name.Equals("gridUiItem"));
            if (control != null)
            {
                ((GridUi)control).EndEdit();
                ((GridUi)control).Refresh();
            }
            VendaDiheiro(tabela, f, sigla,"");
            f.NVerificar = false;
        }

        public static void VendaDiheiro1(DataTable table, Form f, decimal tipodoc)
        {
            if (f == null) return;
            if (tipodoc != 2) return;
            string origem = "", tabStamp = "";
            var clocalstamp = ((FrmClasse)f).CLocalStamp;
            switch (f.Name)
            {
                case "FrmDi":
                    origem = "DI";
                    tabStamp = "distamp";
                    break;
                case "FrmPosDi":
                    origem = "DI";
                    tabStamp = "distamp";
                    break;
                case "FrmFt":
                    origem = "Ft";
                    tabStamp = "factstamp";
                    break;
                case "FrmCp":
                    origem = "CP";
                    tabStamp = "faccstamp";
                    break;
                case "FrmPjdi":
                    origem = "DI";
                    tabStamp = "distamp";
                    break;
            }
            var gridFormasP1 = (GridFormasP)GetAll(f, typeof(GridFormasP)).FirstOrDefault(x => x.Name.Equals("gridFormasP1"));
            var val = table.AsEnumerable().Where(k => k.RowState != DataRowState.Deleted).Sum(x => x.Field<decimal?>("Totall")).ToDecimal();
            if (gridFormasP1 != null && gridFormasP1.Formaspdt.Rows.Count == 0)
            {
                var r = gridFormasP1.Formaspdt.NewRow().Inicialize();
                r["Valor"] = val;
                r["Formaspstamp"] = Pbl.Stamp();
                r[tabStamp] = clocalstamp;
                r["Origem"] = origem;//"FT";
                r["Dcheque"] = Pbl.SqlDate;
                r["Titulo"] = "NUMERARIO";
                r["Numtitulo"] = "";
                r["Codtz"] = Pbl.Usr.Codtz;
                r["banco"] = Pbl.Usr.Sigla;
                r["Contatesoura"] = Pbl.Usr.ContaTesoura;
                r["ObgTitulo"] = false;//
                r["Numer"] = false;//Tipo
                r["Tipo"] = false;//Status
                r["Status"] = false;//
                gridFormasP1.Formaspdt.Rows.Add(r);
            }
            else
            {
                if (gridFormasP1 == null) return;
                if (gridFormasP1.Grelha.CurrentRow != null)
                    gridFormasP1.Grelha.CurrentRow.Cells["Valor"].Value = val;
                gridFormasP1.Grelha.Update();

            }
        }

        internal static void UpdateLinhas(string cLocalStamp, GridUIFt gridUIFt1, DataGridView grelha, string tabela,string TabFilha)
        {
            var dt =gridUIFt1.GetBindedTable();
            if (dt.HasRows())
            {
                var ftdt = SQL.Initialize(TabFilha);
                foreach (var dr in dt.AsEnumerable())
                {
                    var r = ftdt.NewRow();
                    FillRowData(r, dr);
                    r[$"{tabela.Trim()}lstamp"] = Pbl.Stamp();
                    r[$"{tabela.Trim()}stamp"] = cLocalStamp;
                    ftdt.Rows.Add(r);
                }
                gridUIFt1.SetDataSource(ftdt);
                gridUIFt1.DsDt = ftdt;
            }
            var dt2 =grelha.DataSource as DataTable;
            if (dt2.HasRows())
            {
                if (dt2 != null)
                {
                    var ftdtfp = SQL.Initialize(dt2.TableName.Trim());
                    foreach (var dr in dt2.AsEnumerable())
                    {
                        var r = ftdtfp.NewRow();
                        FillRowData(r, dr);
                        dr["formaspstamp"] = Pbl.Stamp();
                        dr[$"{tabela.Trim()}stamp"] = cLocalStamp;
                        ftdtfp.Rows.Add(r);
                    }
                    grelha.SetDataSource(ftdtfp);
                }
            }
        }
        internal static void UpdateLinhasRlt(string cLocalStamp,string tabela,FrmClasse rlt)
        {
            var c3 = GetAll(rlt, typeof(GridUi)).ToList();
            if (c3.Count > 0)
            {
                foreach (var rg in c3)
                {
                    var grif = (GridUi)rg;
                    if (grif.GridFilha)
                    {
                        var dt = grif.GetBindedTable();
                        if (dt.HasRows())
                        {
                            var tblinhaname = dt.TableName;
                            var ftdt = SQL.Initialize(tblinhaname);
                            foreach (var dr in dt.AsEnumerable())
                            {
                                var r = ftdt.NewRow();
                                FillRowData(r, dr);
                                r[$"{tblinhaname.Trim()}stamp"] = Pbl.Stamp();
                                r[$"{tabela.Trim()}stamp"] = cLocalStamp;
                                ftdt.Rows.Add(r);
                            }
                            grif.SetDataSource(ftdt);
                            grif.DtDS = ftdt;
                        }
                    }
                }
            }
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

        private static void ActualizaProvas(string localchave)
        {
            if (!string.IsNullOrEmpty(localchave))
            {
                var connectionString = ConfigurationManager.ConnectionStrings["Dbconnection"].ConnectionString;
                var con = new SqlConnection(connectionString);
                con.Open();
                var cmd = new SqlCommand();
                cmd.CommandText = $"select * from Prova where picschave=@picschave";
                cmd.Parameters.Add("@picschave", SqlDbType.VarChar).Value = localchave;
                cmd.Connection = con;
                var adapter = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                adapter.Fill(dt);
                if (dt != null)
                {
                    Download(dt);
                }
                con.Close();
            }
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

        public static void Totaislinhas(bool origem, DataTable tabela, FrmClasse f)
        {
            if (!origem) return;
            foreach (var dr in Enumerable.Where(tabela.AsEnumerable(), dr => dr != null))
            {
                GenBl.TotaisLinhas(dr);
            }

            TotaisFt(tabela, f);
            var control = GetAll(f, typeof(GridUIFt)).FirstOrDefault(x => x.Name.Equals("gridUIFt1"));
            if (control != null)
            {
                ((GridUIFt)control).NotExecuteEndEditEvent = true;
                ((GridUIFt)control).EndEdit();
                ((GridUIFt)control).Refresh();
                ((GridUIFt)control).NotExecuteEndEditEvent = false;
            }

            f.NVerificar = false;
        }

        public static decimal GetNumero(string stamp)
        {
            return SQL.GetValue("numero", "numdocs",
                $"oristamp='{stamp.Trim()}' and ccusto ='{Pbl.Usr.Ccusto.Trim()}'").ToDecimal();
        }

        public static void SetMaxNumero(TbDefault tbNumero,string tabela)
        {
            if (SQL.GetField("Modeloja", "Param").ToBool())
            {
                var camp1 = $"Controlanum{tabela}";
                var camp2 = $"Minimo{tabela}";
                var camp3 = $"Maximo{tabela}";
                var ccusto = SQL.GetRow($"select {camp1},{camp2},{camp3} from CCu where Descricao='{Pbl.Usr.Ccusto.Trim()}'");
                if (!ccusto[$"{camp1}"].ToBool()) return;
                var x = SQL.Maximo($"{tabela}", "no", $"Ccusto ='{Pbl.Usr.Ccusto.Trim()}'");
                if (ccusto[$"{camp2}"].ToDecimal()<ccusto[$"{camp3}"].ToDecimal())
                {
                    if (x <ccusto[$"{camp2}"].ToDecimal())
                    {
                        tbNumero.tb1.Text = ccusto[$"{camp2}"].ToString();
                    }
                }
                else
                {
                    MsBox.Show(Messagem.ParteInicial()+"Já atengiu o número máximo configurado para esta loja!");
                    tbNumero.tb1.Text = "";
                }
            }
        }

        internal static void Integradoc(Form f)
        {
            var b = new FrmIntegradoc();
            b.barraText1.label1.Text = "Facturação de clientes!";
            b.TipoDoc.SqlComandText = "select Numdoc,Descricao from tdoc where ft=1 or Vd=1 or Nc=1 or nd=1 order by numdoc";
            b.Tabela = "fact";
            b.Ocampos = "Totaliva,Subtotal,desconto,";
            b.ShowForm(f);
        }

        public static void DoProgressProcess(DataTable tabela, Action<DataRow, bool> recebeDados,string campo="", string processo = "")
        {
            var dpb = new DataProgressbar();
            dpb.DadosEnviados += recebeDados;
            dpb.Lista = tabela;
            dpb.TopLevel = true;
            dpb.Campo = campo;
            dpb.Processo= processo;
            dpb.ShowInTaskbar = false;
            dpb.StartPosition = FormStartPosition.CenterScreen;
            dpb.ShowDialog();
        }
        public static void ExportToExcel(DataTable dataTable, string excelFilePath)
        {
            try
            {
                int columnsCount;
                if (dataTable == null || (columnsCount = dataTable.Columns.Count) == 0)
                    throw new Exception("Não existem dados por exportar!\n");
                // load excel, and create a new workbook
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Workbooks.Add();
                // single worksheet
                _Worksheet worksheet = excel.ActiveSheet;

                object[] header = new object[columnsCount];
                // column headings               
                for (int i = 0; i < columnsCount; i++)
                    header[i] = dataTable.Columns[i].ColumnName;

                Range headerRange = worksheet.get_Range((Range)(worksheet.Cells[1, 1]), (Range)(worksheet.Cells[1, columnsCount]));
                headerRange.Value = header;
                headerRange.Interior.Color = ColorTranslator.ToOle(Color.LightGray);
                headerRange.Font.Bold = true;
                // DataCells
                int rowsCount = dataTable.Rows.Count;
                object[,] cells = new object[rowsCount, columnsCount];

                for (int j = 0; j < rowsCount; j++)
                    for (int i = 0; i < columnsCount; i++)
                        cells[j, i] = dataTable.Rows[j][i];
                worksheet.get_Range((Range)(worksheet.Cells[2, 1]), (Range)(worksheet.Cells[rowsCount + 1, columnsCount])).Value = cells;

                // check fielpath
                if (excelFilePath != null && excelFilePath != "")
                {
                    try
                    {
                        worksheet.SaveAs(excelFilePath);
                        excel.Workbooks.Close();
                        excel.Quit();
                        // MessageBox.Show("Excel file saved!");
                    }
                    catch (Exception ex)
                    {
                        //throw new Exception("ExportToExcel: Excel file could not be saved! Check filepath.\n"
                        //    + ex.Message);
                    }
                }
                Process[] process = Process.GetProcessesByName("Excel");
                foreach (Process p in process)
                {
                    if (!string.IsNullOrEmpty(p.ProcessName))
                    {
                        try
                        {
                            p.Kill();
                        }
                        catch
                        {
                            //
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // throw new Exception("ExportToExcel: \n" + ex.Message);
            }
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

        internal static void UpdateFormaspMoeda(GridFormasP dFormasP,string Moeda)
        {
            if (dFormasP.Grelha.RowCount>0)
            {
                foreach (DataGridViewRow r in dFormasP.Grelha.Rows)
                {
                    r.Cells["Moeda"].Value = Moeda;
                }
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
