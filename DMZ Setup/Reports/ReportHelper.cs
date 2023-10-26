using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Management;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.DAL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Classes;
using DMZ.UI.Generic;
using DMZ.UI.Reports.DSTableAdapters;
using Microsoft.Reporting.WinForms;

namespace DMZ.UI.Reports
{
    public static class ReportHelper
    {
        [DllImport("Winspool.drv")]
        private static extern bool SetDefaultPrinter(string printerName);
        private static LocalReport _reportViewer1;
        public static void KillPrimaryKey(DataTable locDataTable)
        {
            var locPriKeyCount = locDataTable.PrimaryKey.Length;
            var prevPriColumns = new string[locPriKeyCount];
            //1.Store ColumnNames in a string Array
            for (var ii = 0; ii < locPriKeyCount; ii++) prevPriColumns[ii] = locDataTable.PrimaryKey[ii].ColumnName;
            //2.Clear PrimaryKey
            locDataTable.PrimaryKey = null;
            //3.Clear Unique settings
            for (var ii = 0; ii < locPriKeyCount; ii++) locDataTable.Columns[prevPriColumns[ii]].Unique = false;
        }

        public static void PrinterList(ComboBox comboBox1)
        {
            // USING WMI. (WINDOWS MANAGEMENT INSTRUMENTATION)
            var objMS = new ManagementScope(ManagementPath.DefaultPath);
            objMS.Connect();

            var objQuery = new SelectQuery("SELECT * FROM Win32_Printer");
            var objMOS = new ManagementObjectSearcher(objMS, objQuery);
            var objMOC = objMOS.Get();

            foreach (var o in objMOC)
            {
                var Printers = (ManagementObject)o;
                if (Convert.ToBoolean(Printers["Local"]))       // LOCAL PRINTERS.
                {
                    comboBox1.Items.Add(Printers["Name"]);
                }
                if (Convert.ToBoolean(Printers["Network"]))     // ALL NETWORK PRINTERS.
                {
                    comboBox1.Items.Add(Printers["Name"]);
                }
            }
            var printerSettings = new PrinterSettings();
            string defaultPrinterName = printerSettings.PrinterName;
            comboBox1.Text = defaultPrinterName;
           
        }
        public static List<string> PrinterList( bool defaultPrinterName = false)
        {
            // USING WMI. (WINDOWS MANAGEMENT INSTRUMENTATION)
            var objMs = new ManagementScope(ManagementPath.DefaultPath);
            objMs.Connect();

            var objQuery = new SelectQuery("SELECT * FROM Win32_Printer");
            var objMOS = new ManagementObjectSearcher(objMs, objQuery);
            var objMOC = objMOS.Get();
            var lista = new  List<string>();
            if (defaultPrinterName)
            {
                var printerSettings = new PrinterSettings();
                var defaultPrintName = printerSettings.PrinterName;
                lista.Add(defaultPrintName);
            }
            else
            {
                foreach (var o in objMOC)
                {
                    var Printers = (ManagementObject)o;
                    if (Convert.ToBoolean(Printers["Local"]))       // LOCAL PRINTERS.
                    {
                        lista.Add(Printers["Name"].ToString());
                    }
                    if (Convert.ToBoolean(Printers["Network"]))     // ALL NETWORK PRINTERS.
                    {
                        lista.Add(Printers["Name"].ToString());
                    }
                }      
            }
            return lista;
        }
        public static void FillDt(DataSet Ds,DataTable dt2, string tbName)
        {
            if (!(dt2?.Rows.Count > 0)) return;
            foreach (var d in dt2.AsEnumerable())
            {
                if (d == null) continue;
                var r = Ds.Tables[$"{tbName}"].NewRow();
                foreach (DataColumn col in d.Table.Columns)
                {
                    if (string.IsNullOrEmpty(col.ColumnName)) continue;
                    var coll = col.ColumnName;
                    r[coll] = d[coll];
                }
                Ds.Tables[$"{tbName}"].Rows.Add(r);
            }
        }

        public static void PrintReport(DataTable tmpPrt)
        {
            var ds = new DS {EnforceConstraints = false};
            _reportViewer1 = new LocalReport {ReportPath = @"../../Reports/RptPos.rdlc"};
            ds.EnforceConstraints = false;
            if (_reportViewer1!=null)
            {
                //var tmpPrt = GenBl.PrintPos(factstamp,no);
                if (tmpPrt?.Rows.Count>0)
                {
                    FillDt(ds,tmpPrt, "Fact");
                    SetReportDataSource("Fact",ds);
                }
                else
                {
                    MsBox.Show("Os dados por imprimir estão vazios!..");
                }
            }
            else
            {
                MsBox.Show("Relatório não encontrado");
            }
        }

        public static string DefaultPrinter { get; set; }

        public static void PrintReport(List<ReportParameter> lista,bool impressoraNormal)
        {
            var tmpPrt = GenBl.PrintCaixa(Pbl.SqlDate, Pbl.Codtz.ToDecimal());
            var ds = new DS {EnforceConstraints = false};
            _reportViewer1 = new LocalReport {ReportPath = @"../../Reports/Caixapos.rdlc"};
            FillDt(ds,tmpPrt, "DMZ");
            _reportViewer1.SetParameters(lista);
            SetReportDataSource("DMZ",ds,impressoraNormal);
        }

        private static void SetReportDataSource(string tabela,DS ds,bool impressoraNormal=false)
        {
            using (var con = new GCon())
            {
                ds.EnforceConstraints = false;
                var adp = new EmpresaTableAdapter { Connection = con.NResult };
                adp.Fill(ds.Empresa);
                var rd1 = new ReportDataSource("Entidade", ds.Tables["Empresa"]);
                _reportViewer1.DataSources.Clear();
                _reportViewer1.DataSources.Add(rd1);
                var rd2 = new ReportDataSource("DataSet1", ds.Tables[$"{tabela}"]);
                _reportViewer1.DataSources.Add(rd2);
                _reportViewer1.Refresh();

                #region Definicao da impressora padrao e impressao ....
                //var imp = SQLExec.QEnt<ParamImp>($"select * from ParamImp where Codccu='{Pbl.Codccu}'");
                var imp = EF.GetEnt<ParamImp>(p=>p.Codccu.Equals(Pbl.Codccu));
                SetDefaultPrinter(impressoraNormal ? imp.Normal1.Trim() : imp.Pos.Trim());
                _reportViewer1.Print();
                SetDefaultPrinter(DefaultPrinter);

                #endregion 
            }
        }
    }
}
