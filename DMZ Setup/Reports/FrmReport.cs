using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.DAL.Classes;
using DMZ.UI.Classes;
using DMZ.UI.Reports.DSTableAdapters;
using Microsoft.Reporting.WinForms;
using System.Runtime.InteropServices;
using DMZ.UI.Basic;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;

namespace DMZ.UI.Reports
{
    public partial class FrmReport : FrmClasse2
    {
        [DllImport("Winspool.drv")]
        private static extern bool SetDefaultPrinter(string printerName);
        public FrmReport()
        {
            InitializeComponent();
            toolStrip = (ToolStrip)reportViewer1.Controls.Find("toolStrip1", true)[0];
        }
        private ToolStrip toolStrip;
        public List<ReportParameter> ListaParam;
        private ReportDataSource _dataSource;
        private ReportDataSource _dataSource2;
        private ReportDataSource _dataSource3;
        private string _reportPath;
        public DS Ds;
       // SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        public string Origem { get; set; }
        public decimal No { get;  set; }
        private string _querry;
        public DataTable Tabela { get; set; }
        public string TabelaName { get; set; }
        public string ReportName { get; set; }
        public string NomeProduto { get; set; }
        private void FrmReport_Load(object sender, EventArgs e)
        {
            Cancelado = false;
            ReportHelper.PrinterList(comboBox1);
            toolStrip.Visible = false;
            cbDefault1.OnlyCheckBox = true;
            cbDefault2.OnlyCheckBox = true;
            cbDefault3.OnlyCheckBox = true;
            reportViewer1.LocalReport.EnableExternalImages = true;
            if (Ds == null)
            {
                Ds = new DS {EnforceConstraints = false};

            }
            using (var con = new GCon())
            {
                Ds.EnforceConstraints = false;
                var adp = new EmpresaTableAdapter { Connection = con.NResult };
                adp.Fill(Ds.Empresa);
                var rd2 = new ReportDataSource("Entidade", Ds.Tables["Empresa"]);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rd2);
                GetSetListParameter();
                 
                switch (Origem)
                {
                    case "CP":
                        var faccadaptador = new FaccTableAdapter { Connection = con.NResult };
                        faccadaptador.Fill(Ds.Facc, Printstamp);
                        ListaParam.Add(new ReportParameter("Extenso",Ds.Tables["Facc"].Rows[0]["Total"].ToDecimal().ToExtenso()));
                        _dataSource = new ReportDataSource("Dataset1", Ds.Tables["Facc"]);
                        _reportPath = "../../Reports/RptFacc.rdlc";                   
                        break;
                    case "FT":
                        FormasP("Factstamp");
                        var contas = new ContasTableAdapter { Connection = con.NResult };
                        contas.Fill(Ds.Contas);
                        var factadaptador = new FactTableAdapter { Connection = con.NResult };
                        factadaptador.Fill(Ds.Fact, Printstamp);
                        if (Ds.Fact?.Rows.Count>0)
                        {
                            if (Ds.Tables["Fact"].Rows[0]["Total"].ToString().ToDecimal() != 0)
                            {
                                ListaParam.Add(new ReportParameter("Extenso", Ds.Tables["Fact"].Rows[0]["Total"].ToDecimal().ToExtenso()));
                                ListaParam.Add(new ReportParameter("Mostranib",Pbl.Mostranib.ToString().ToLower()));
                            }
                            SetDefault();
                            _dataSource = new ReportDataSource("Dataset1", Ds.Tables["Fact"]);
                            _dataSource2 = new ReportDataSource("Contas", Ds.Tables["Contas"]);
                            _dataSource3 = new ReportDataSource("Formasp", Ds.Tables["Formasp"]);
                            _reportPath = $"../../Reports/{ReportName}.rdlc";
                            //foreach (var param in reportViewer1.LocalReport.GetParameters())
                            //{
                            //    if (param.Name.Equals("Mostranib"))
                            //    {
                            //        ListaParam.Add(new ReportParameter("Mostranib",Pbl.Mostranib.ToString()));
                            //    }
                            //}
                        }
                        else
                        {
                            MsBox.Show("O sistema não consegue imprimir o documento \r\nErro encontrado!..");
                            Cancelado=true;
                        }
                        break;

                    case "PGF":
                        ReportHelper.KillPrimaryKey(Ds.Pgf);
                        var pgFadaptador = new PgfTableAdapter { Connection = con.NResult };
                        pgFadaptador.Fill(Ds.Pgf, Printstamp,No);
                        ListaParam.Add(new ReportParameter("Extenso",Ds.Tables["Pgf"].Rows[0]["total"].ToDecimal().ToExtenso()));
                        FormasP("pgfstamp");
                        ReportBindSource("RptPgf");
                        break;

                    case "RCL":
                        ReportHelper.KillPrimaryKey(Ds.Pgf);
                        var rcladaptador = new RclTableAdapter { Connection = con.NResult };
                        rcladaptador.Fill(Ds.Rcl, Printstamp, No);
                        ListaParam.Add(new ReportParameter("Extenso",Ds.Tables["Rcl"].Rows[0]["total"].ToDecimal().ToExtenso()));
                        SetDefault();
                        FormasP("rclstamp");
                        ReportBindSource(ReportName);
                        break;
                    case "ExtProd":
                        ReportHelper.FillDt(Ds,Tabela, "ExtProd");
                        ListaParam.Add(new ReportParameter("Intervalo", Intervalo));
                        ListaParam.Add(new ReportParameter("NomeProduto", NomeProduto));
                        _dataSource = new ReportDataSource("DataSet1", Ds.Tables["ExtProd"]);
                        _reportPath = "../../Reports/ExtProduto.rdlc";
                        break;
                    //CTituloRelatorio
                    case "RLT":
                        FillDt2(Dt, TabelaName);
                        ListaParam.Add(new ReportParameter("Filtro", Filtro));
                        ListaParam.Add(new ReportParameter("cTituloRelatorio", CTituloRelatorio));
                        _dataSource = new ReportDataSource("DataSet1", Ds.Tables[TabelaName]);
                        _reportPath = $"../../Reports/{ReportName}.rdlc";
                        break;
                    case "DI":
                        if (Dt?.Rows.Count>0)
                        {
                            FillDt2(Dt, "DMZ");
                            ListaParam.Add(new ReportParameter("Entidade", EntidadePrint));
                            ListaParam.Add(new ReportParameter("cTituloRelatorio", CTituloRelatorio));
                            _dataSource = new ReportDataSource("DataSet1", Ds.Tables["DMZ"]);
                            
                        }
                        else
                        {
                            var diadaptador = new DiTableAdapter { Connection = con.NResult };
                            diadaptador.Fill(Ds.Di, Printstamp);
                            if (Ds.Di?.Rows.Count>0)
                            {
                                if (Ds.Tables["Di"].Rows[0]["Total"].ToString().ToDecimal() != 0)
                                {
                                    ListaParam.Add(new ReportParameter("Extenso", Ds.Tables["Di"].Rows[0]["Total"].ToDecimal().ToExtenso()));
                                }
                                SetDefault();
                                _dataSource = new ReportDataSource("Dataset1", Ds.Tables["Di"]);
                                _reportPath = $"../../Reports/{ReportName}.rdlc";
                            }      
                        }
                        _reportPath = $"../../Reports/{ReportName}.rdlc";
                        break;
                    case "Balancete":
                        FillDt2(Dt, "Balancete");
                        ListaParam.Add(new ReportParameter("pDescricao", PDescricao));
                        ListaParam.Add(new ReportParameter("pUtilizador", Pbl.Login));
                        ListaParam.Add(new ReportParameter("pShowColAcum",PShowColAcum));
                        ListaParam.Add(new ReportParameter("pContasMov", PContasMov));
                        _dataSource = new ReportDataSource("Balancete", Ds.Tables["Balancete"]);
                        _reportPath = $"../../Reports/Cont/{ReportName}.rdlc";
                        break;//LCont
                    case "LCont":
                        var lcontdaptador = new LContTableAdapter { Connection = con.NResult };
                        lcontdaptador.Fill(Ds.LCont, Printstamp);
                        _dataSource = new ReportDataSource("Lcont", Ds.Tables["LCont"]);
                        _reportPath = $"../../Reports/Cont/{ReportName}.rdlc";
                        break;//

                    case "Caixa":
                        FillDt2(Dt, "DMZ");
                        ListaParam.Add(new ReportParameter("Filtro", Filtro));
                        ListaParam.Add(new ReportParameter("pUtilizador", Pbl.LoginName));
                        _dataSource = new ReportDataSource("DataSet1", Ds.Tables["DMZ"]);
                        _reportPath = $"../../Reports/{ReportName}.rdlc";
                        break;
                }

            }
            if (Cancelado) return;
            reportViewer1.LocalReport.ReportPath = _reportPath;
            reportViewer1.LocalReport.DataSources.Add(_dataSource);
            if (_dataSource2 !=null)
            {
                reportViewer1.LocalReport.DataSources.Add(_dataSource2);
            }
            if (_dataSource3 !=null)
            {
                reportViewer1.LocalReport.DataSources.Add(_dataSource3);
            }
            reportViewer1.LocalReport.SetParameters(ListaParam);
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.PageWidth;
            reportViewer1.RefreshReport();
        }

        private void SetDefault()
        {
            ListaParam.Add(new ReportParameter("Statusdocumento", "Original"));
            cbDefault1.btnCheck.PerformClick();
        }

        public bool Cancelado { get; set; }

        public string EntidadePrint { get; set; }

        private void ReportBindSource(string reportname)
        {
            _dataSource = new ReportDataSource("DataSet1", Ds.Tables["Rcl"]);
            _dataSource2 = new ReportDataSource("DataSet2", Ds.Tables["Formasp"]);
            _reportPath = $"../../Reports/{reportname.Trim()}.rdlc";
        }
        private void FormasP(string campo)
        {
            if (!string.IsNullOrEmpty(Printstamp))
            {
                _querry = $@"select Titulo,Numtitulo,Banco,Valor,Dcheque from Formasp
                                    where ltrim(rtrim({campo})) ='{Printstamp.Trim()}'";
                Tabela = SQL.GetGenDT(_querry);
                ReportHelper.FillDt(Ds,Tabela, "Formasp");
            }
            else
            {
                MsBox.Show("O sistema não consegue imprimir as formas de pagamento \r\nO clocalstamp está vazio!..");
            }
        }

        private void GetSetListParameter()
        {
            ListaParam = new List<ReportParameter>();
            foreach (var p in reportViewer1.LocalReport.GetParameters())
            {
                ReportParameter param;
                switch (p.Name)
                {
                    case "SoftwareVersion":
                        param = new ReportParameter("SoftwareVersion", Pbl.Info);
                        ListaParam.Add(param);
                        break;
                    case "Data":
                        param = new ReportParameter("Data", DateTime.Now.ToLongDateString());
                        ListaParam.Add(param);
                        break;
                }
            }
            reportViewer1.LocalReport.SetParameters(ListaParam);
        }
        private void FillDt2(DataTable dt2, string tbName)
        {

            if (dt2 !=null)
            {
                int colReais;
                if (Ds.Tables[$"{tbName}"].Columns.Count > dt2.Columns.Count)
                {
                    colReais = Ds.Tables[$"{tbName}"].Columns.Count-(Ds.Tables[$"{tbName}"].Columns.Count - dt2.Columns.Count);
                }
                else
                {
                    colReais = Ds.Tables[$"{tbName}"].Columns.Count;
                }

                for (var j = 0; j < colReais; j++)
                {
                    Ds.Tables[$"{tbName}"].Columns[j].DataType = dt2.Columns[j].DataType;  
                }
                for (var i = 0; i < dt2.Rows.Count; i++)
                {
                    if (dt2.Rows[i] == null) continue;
                    var r = Ds.Tables[$"{tbName}"].NewRow();                  
                    for (var j = 0; j < colReais; j++)
                    {
                        r[j] = dt2.Rows[i][j].ToString();
                    }
                    Ds.Tables[$"{tbName}"].Rows.Add(r);
                }
            }
            else
            {
                MsBox.Show("A pesquisa não encontrou nada para os parametros indicados");
                Cancelado = true;
            }
        }
        public string Filtro { get; set; } = string.Empty;
        public DataTable Dt { get; set; }
        public string Intervalo { get; set; }
        public string Printstamp { get;  set; }
        public string CTituloRelatorio { get; set; }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MsBox.Show("Deve selecionar a impressora!..");
                return;
            }
            var defaultPrinter = reportViewer1.PrinterSettings.PrinterName.Trim();
            var lista = new List<string>();
            if(cbDefault1.cb1.Checked)
                lista.Add(cbDefault1.CbText);
            if (cbDefault2.cb1.Checked)
                lista.Add(cbDefault2.CbText);
            if (cbDefault3.cb1.Checked)
                lista.Add(cbDefault3.CbText);
            ReportParameterInfo StatusdocumentoParam;
            StatusdocumentoParam = reportViewer1.LocalReport.GetParameters().FirstOrDefault(x => x.Name.Equals("Statusdocumento"));
            if (reportViewer1.PrinterSettings.PrinterName.Trim() !=comboBox1.Text.Trim())
            {
                //Set the default printer.
                SetDefaultPrinter(comboBox1.Text.Trim());  
            }
            
            if (StatusdocumentoParam != null)
            {
                foreach (var rp in lista.Select(tipodocumento => new ReportParameter("Statusdocumento", tipodocumento)))
                {
                    reportViewer1.LocalReport.SetParameters(new[] { rp });
                    reportViewer1.RefreshReport();
                    reportViewer1.LocalReport.Print();
                }
            }
            else
            {
                reportViewer1.RefreshReport();
                reportViewer1.LocalReport.Print();
            }
            SetDefaultPrinter(defaultPrinter);
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
           dmzCMexport.ShowMenuStrip(btnOptions);
        }

        private void exportarParaWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportToFile("Word");
        }

        private void exportarParaExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportToFile("Excel");
        }

        private void exportarParaPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportToFile("Pdf");
        }
        private void ExportToFile(string sender)
        {
            try
            {
                var x = reportViewer1.LocalReport.ListRenderingExtensions();
                RenderingExtension render = null;

                switch (sender)
                {
                    case "Word":
                        render = x[5];
                        break;
                    case "Excel":
                        render = x[1];
                        break;
                    case "Pdf":
                        render = x[3];
                        break;
                }

                if (render == null) return;
                var dr = reportViewer1.ExportDialog(render);
                if (dr == DialogResult.OK)
                    MsBox.Show("Executado com sucesso!");
            }
            catch (Exception x)
            {
                    MsBox.Show(x.Message);
            }
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // ExecutePercentClick(toolStripComboBox1.Text);
        }

        private void btnMaxMin_Click(object sender, EventArgs e)
        {
            if (!Maximizado)
            {
                Maximizar();
            }
            else
            {
                Minimizar();
            }
        }

        public bool Maximizado { get; set; }
        private void Maximizar()
        {
            NSize = Size;
            NLocation = Location;
            if (MdiParent != null)
            {
                var height = MdiParent.Size.Height;
                var width = MdiParent.Size.Width;
                Size = new Size(width - 190, height - 165);
                var x = MdiParent.Location.X;
                var y = MdiParent.Location.Y;
                Location = new Point(x + 175, y + 110);
                Maximizado = true;
                var lista = Application.OpenForms;
                foreach (Form frm in lista)
                {
                    if (frm == null) continue;
                    if (frm.IsMdiContainer)
                    {
                        if (frm is DemoMdi)
                        {
                            if (((DemoMdi) frm).Ocultado)
                            {
                                MoveUp();
                            }
                        }
                        else
                        {
                            MoveUp();
                        }
                    }
                }
            }
            else
            {
                var height = Screen.PrimaryScreen.WorkingArea.Size.Height;
                var width = Screen.PrimaryScreen.WorkingArea.Size.Width;
                Size = new Size(width - 190, height - 165);
                var x = Screen.PrimaryScreen.WorkingArea.Location.X;
                var y = Screen.PrimaryScreen.WorkingArea.Location.Y;
                Location = new Point(x + 175, y + 110);    
            }
        }
        public void MoveUp()
        {
            NSize = Size;
            NLocation = Location;
            var height = MdiParent.Size.Height;
            var width = MdiParent.Size.Width;
            Size = new Size(width - 70, height - 165);
            var x = MdiParent.Location.X;
            var y = MdiParent.Location.Y;
            Location = new Point(48, y + 110);
        }
        public void MoveDow()
        {
            Size = NSize;
            Location = NLocation;
        }
        public void Minimizar()
        {
            Size = NSize;
            Location = NLocation;
            Maximizado = false;
        }
        public Size NSize { get; set; }

        public Point NLocation { get; set; }
        public string PShowColAcum { get; set; }
        public string PDescricao { get; set; }
        public string PContasMov { get; set; }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }


}
