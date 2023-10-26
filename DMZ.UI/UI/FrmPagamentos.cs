using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using System.Xml;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using DMZ.UI.Reports;
using ESCPOS_NET;
using ESCPOS_NET.Emitters;
using ESCPOS_NET.Utilities;
using Microsoft.Graph.Models;
using Microsoft.Office.Interop.Excel;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using static System.Windows.Forms.AxHost;
using DataTable = System.Data.DataTable;
using Utilities = DMZ.BL.Classes.Utilities;
using ESC_POS_USB_NET.Printer;
using Printer = ESC_POS_USB_NET.Printer.Printer;
using ESC_POS_USB_NET.Enums;
using ESCPOS_NET.Emitters.BaseCommandValues;

namespace DMZ.UI.UI
{
    public partial class FrmPagamentos : Basic.FrmClasse2
    {
        private DataTable _formasp;
        private DataTable _rcll;
        private decimal _npago;
        public Fact ft;
        public Factl ftl;
        public Tdoc TmpTdoc;
        private RCL _rcl;
        public DataTable TmpDivida;
        //public Action ReceberDados;
        public System.Action Beginvoke;
        public FrmPagamentos()
        {
            InitializeComponent();
        }
        private void FrmPagamentos_Load(object sender, EventArgs e)
        {
            KeyUp += KeyEvent;
            KeyPreview = true;

            ContasDt = Pbl.DtContas;
            var dr = ContasDt.AsEnumerable().Where(x => x.Field<bool>("cx").Equals(true)).FirstOrDefault();
            if (dr != null)
            {
                dr["valor"] = ft.Total;
            }
            if (TmpTdoc.Ft)
            {
                var dt = SQL.GetGen2DT("select * from TRcl where Defa=1");
                if (dt.HasRows())
                {
                    TmpTrcl = dt.DtToList<TRcl>().FirstOrDefault();
                }
                //TmpTrcl = SQL.GetGen2DT("select * from TRcl where Defa=1"); EF.GetEnt<TRcl>(x=>x.Defa==true);
            }
            gridUi1.SetDataSource(ContasDt);

            //Melhorar essa linha guardar as impressoras no PBL
            if (!Pbl.Impressoras.HasRows())
            {
                Pbl.Impressoras = ReportHelper.PrinterList();
            }
            comboBox1.DataSource = Pbl.Impressoras;
            //comboBox2.DataSource = Pbl.Impressoras;
            comboBox1.DisplayMember = "Descricao";
           // comboBox2.DisplayMember = "Descricao";
            comboBox1.Text = Pbl.Impressoras.Select("Defa=1")[0]["Descricao"].ToString();
            //comboBox2.Text = Pbl.Impressoras.Select("Defa=1")[0]["Descricao"].ToString();

            EditMode = true;
            NrCopias.Value = Pbl.Param.NumImpressao;
        }
        private void gridUi1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btD.PerformClick();
        }

        private void Troco(decimal valor)
        {
            if (gridUi1.CurrentRow != null)
                gridUi1.CurrentRow.Cells["Valor"].Value = gridUi1.CurrentRow.Cells["Valor"].Value.ToDecimal() + valor;
            gridUi1.Update();
            Totais();
        }

        private void btnDezmil_Click(object sender, EventArgs e)
        {
            var st = ContasDt;
            Troco(10000);
        }

        private void Totais()
        {
            var total = ContasDt.Total("valor");
            tbPago.Text = total.ToString(CultureInfo.InvariantCulture).SetMask();
            tbTroco.Text = total == 0 ? "0" : (total - tbDivida.Text.ToDecimal()).ToString();
        }

        private void btnCincoMil_Click(object sender, EventArgs e)
        {
            Troco(5000);
        }
        public static decimal Total(DataTable dt, string campo)
        {
            var tipo = dt.Columns[$"{campo}"].DataType;
            return tipo.Name == "Int32" ? dt.AsEnumerable().Sum(x => x.Field<int?>($"{campo}")).ToString().ToDecimal() : dt.AsEnumerable().Sum(x => x.Field<decimal?>($"{campo}")).ToString().ToDecimal();
        }

        private void btnMil_Click(object sender, EventArgs e)
        {
            Troco(1000);
        }

        private void btnQuinhentos_Click(object sender, EventArgs e)
        {
            Troco(500);
        }

        private void btnCem_Click(object sender, EventArgs e)
        {
            Troco(100);
        }

        private void KeyEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
            {
                Pagar();
            }
            if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
            {
                AddValue("0");
            }
            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                AddValue("1");
            }
            if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                AddValue("2");
            }
            if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                AddValue("3");
            }

            if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {
                AddValue("4");
            }
            if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
            {
                AddValue("5");
            }
            if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
            {
                AddValue("6");
            }
            if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
            {
                AddValue("7");
            }
            if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
            {
                AddValue("8");
            }
            if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
            {
                AddValue("9");
            }

        }
        
        private async void Pagar()
        {
            //OK
            try
            {
                _npago = tbPago.Text.ToDecimal();
                var ntotdivida = tbDivida.Text.ToDecimal();
                if (_npago < ntotdivida)
                {
                    MsBox.Show("Desculpe mas não pode pagar valor inferior ao valor do documento!");
                    return;
                }
                if (_npago > ntotdivida)
                {
                    _npago = _npago - tbTroco.Text.ToDecimal();
                    tbTroco.Text = (_npago - ntotdivida).ToString();
                    tbPago.Text = _npago.ToString();
                }
                if (_npago == ntotdivida)
                {
                    if (TmpTdoc.Ft)
                    {
                        if (RclAdd())
                        {
                            Imprime();
                            //ImprimeS();
                        }
                        else
                        {
                            MsBox.Show("Erro ao processar o pagamento!..");
                        }
                    }
                    if (TmpTdoc.Vd)
                    {
                        if (Pagamento())
                        {
                            Imprime();
                            //ImprimeS();
                        }
                        else
                        {
                            MsBox.Show("Erro ao processar o pagamento!..");
                        }
                    }
                    Beginvoke?.Invoke();
                    Close();
                }
                else
                {
                    MsBox.Show("Desculpe o valor a regularizar não é igaual ao valor pago!..");
                }
            }
            catch (Exception ex)
            {
                MsBox.Show(ex.Message);

            }
        }

        private void ImprimeS()
        {
            //var doc = new System.Drawing.Printing.PrintDocument();
            //doc.PrintPage += new PrintPageEventHandler(ProvideContent);
            //doc.Print();
        }

        void BuilLine(Graphics graphics,string informacao, int tamanho)
        {
            int startX = 0;
            int startY = 0;
            var font = new System.Drawing.Font("Courier New", tamanho);
            graphics.DrawString(informacao,font, new SolidBrush(System.Drawing.Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
        }
        int Offset;
        public void ProvideContent(object sender, PrintPageEventArgs e)
        {
            #region print
            Graphics graphics = e.Graphics;
            System.Drawing.Font font = new System.Drawing.Font("Courier New", 10);
            float fontHeight = font.GetHeight(graphics);
            int startX = 0;
            int startY = 0;
            Offset = 20;
            // e.PageSettings.PaperSize.Width = 50;           
            BuilLine(graphics, $"MALINOS", 12);

            BuilLine(graphics, ($"{Pbl.Empresa.ImagemFundo}"), 12);
            BuilLine(graphics, ($"{ft.Nomedoc}: {ft.Numero}/{ft.Data.Year}"), 12);
            BuilLine(graphics, ($"Nº:{ft.Numdoc}"), 12);
            String underLine = "------------------------------------------";
            BuilLine(graphics, ($"Data: {ft.Data.ToShortDateString()} Hora: {ft.Data.ToShortTimeString()}"), 8);
            String underLine1 = "------------------------------------------";
            graphics.DrawString(underLine1, new System.Drawing.Font("Courier New", 14),
                     new SolidBrush(System.Drawing.Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            foreach (var item in Factl.AsEnumerable())
            {
                BuilLine(graphics, $"{item["Descricao"]}:{item["Quant"]}------{item["Preco"]}   {item["Totall"]} ", 7);
                #region eu

                //using (var ms = new MemoryStream())
                //using (var bw = new BinaryWriter(ms))
                //{
                //    // Reset the printer bws (NV images are not cleared)


                //    // BuilLine(graphics,  $"Descricao           Quant         Preco       Total");
                //    bw.Write("------------------------------------------------");
                //    BuilLine(graphics, $"{item["Descricao"]}: {item["Quant"]} {item["Preco"]},mt  {item["Totall"]},mt ", 10);

                //    bw.Write('V');
                //    bw.Write((byte)66);
                //    bw.Write((byte)3);
                //    bw.Flush();

                //}
                #endregion
            }

            //BuilLine(underLine, $"Courier New", 14);

            String Grosstotal = ($"TOTAL:            {ft.Total}");

            graphics.DrawString(Grosstotal, new System.Drawing.Font("Courier New", 10),
                new SolidBrush(System.Drawing.Color.Black), startX, startY + Offset);


            underLine = "------------------------------------------";
            #region eu
            //BuilLine(underLine, $"Courier New", 14);

            //  graphics.DrawString(underLine, new System.Drawing.Font("Courier New", 14),
            //new SolidBrush(System.Drawing.Color.Black), startX, startY + Offset);



            //graphics.DrawString(underLine, new System.Drawing.Font("Courier New", 14),
            //            new SolidBrush(System.Drawing.Color.Black), startX, startY + Offset);



            //BuilLine(graphics, (PrintStyle.Bold | PrintStyle.FontB), 14); 
            #endregion
            Offset = Offset + 20;

            BuilLine(graphics, ("DMZ SOFTWARE"), 8);
            graphics.DrawString(underLine, new System.Drawing.Font("DMZ SOFTWARE", 18),
            new SolidBrush(System.Drawing.Color.Black), startX, startY + Offset);

            BuilLine(graphics, ($"{Info}"), 14);
            BuilLine(graphics, (""), 14);
            BuilLine(graphics, ("Obrigado pela preferencia."), 12); 
            #endregion
        }
            
        private void Imprime()
        {

            //var doc = new System.Drawing.Printing.PrintDocument();
            //doc.PrintPage += new PrintPageEventHandler(ProvideContent);
            //doc.Print();

            #region TIPO DE IMPRESSÃO
            //USB
            //Printer graphics = new Printer($"{comboBox1.Text.Trim()}");//("(Impressora = comboBox1.Text.Trim(),", "");

            //// Ethernet or WiFi (This uses an Immediate Printer, no live paper status events, but is easier to use)
            //var hostnameOrIp = "192.168.1.50";
            //var port = 9100;
            //var printer = new ImmediateNetworkPrinter(new ImmediateNetworkPrinterSettings() { ConnectionString = $"{hostnameOrIp}:{port}", PrinterName = "TestPrinter" });

            //// USB, Bluetooth, or Serial
            //var printer = new SerialPrinter(portName: "COM5", baudRate: 115200);

            //// Linux output to USB / Serial file
            //var printer = new FilePrinter(filePath: "/dev/usb/lp0"); 
            #endregion


            var printer = new Printer($"{comboBox1.Text.Trim()}");//{comboBox2.Text.Trim()}");//comboBox2

            #region imagem
            //Bitmap image = new Bitmap(Bitmap.FromFile("Icon.bmp"));
            //graphics.Image(image);
            //graphics.Append($"Nº:{ft.Numdoc}"); 
            #endregion
            printer.Code128("123456789");
            //printer.Separator();
            #region separador
            //printer.Separator(); // Deafult
            //printer.Separator('.'); // .
            //printer.Separator('|'); // |
            //printer.Separator('='); // =
            //printer.Separator('+'); // +
            //printer.Separator('*'); // *
            //printer.Separator('^'); // ^
            //printer.Separator('~'); // ~
            //printer.Separator(':'); // :
            //printer.Separator('#'); // # 
            #endregion
            #region Qrcode
            //printer.Append("Code39");
            //printer.Code39("123456789");
            //printer.Separator();
            //printer.Append("Ean13");
            //printer.Ean13("1234567891231");
            ////printer.FullPaperCut();
            //printer.PrintDocument();

            #endregion
            printer.BoldMode($"{Pbl.Empresa.Nome}");
            printer.Append($"Data: {ft.Data.ToShortDateString()} Hora: {ft.Data.ToShortTimeString()}");
            printer.Append($"{Pbl.Empresa.Morada}");
            printer.Append($"Nuit:{Pbl.Empresa.Nuit}   Tell:{Pbl.Empresa.Telefone}");
            printer.Separator();
            printer.BoldMode($"{ft.Nomedoc}: {ft.Numero}/{ft.Data.Year}");
            printer.Append($"Cliente:{ft.Nome}");
            #region MyRegion
            //graphics.UnderlineMode("Underlined text");
            //graphics.Separator();
            //graphics.ExpandedMode(PrinterModeState.On);
            //graphics.Append("Expanded - 23 COLUMNS");
            //graphics.Append("1...5...10...15...20..23");
            //graphics.ExpandedMode(PrinterModeState.Off);
            //graphics.Separator();
            //graphics.CondensedMode(PrinterModeState.On);
            //graphics.Append("Condensed - 64 COLUMNS");
            //graphics.Append("1...5...10...15...20...25...30...35...40...45...50...55...60..64");
            //graphics.CondensedMode(PrinterModeState.Off);
            //graphics.Separator();
            //graphics.DoubleWidth2();
            //graphics.Append("Font Width 2");
            //graphics.DoubleWidth3();
            //graphics.Append("Font Width 3");
            //graphics.NormalWidth();
            ///graphics.Append("Normal width");
            //graphics.Separator();
            //graphics.AlignRight();
            //graphics.Append("Right aligned text");
            //graphics.AlignCenter();
            //graphics.Append("Center-aligned text");
            //graphics.AlignLeft();
            //printer.Append($"{Pbl.Empresa.ImagemFundo}"); 
            #endregion
            printer.Separator();
            printer.AlignRight();
            printer.Append("Service    Qty  Price  Total");
            foreach (var item in Factl.AsEnumerable())
            {
                // graphics.CondensedMode(PrinterModeState.On);

                printer.AlignRight();
                //printer.Font($"{item["Descricao"]}"); printer.Append($"{item["Quant"]}");               
             printer.Append($"{item["Descricao"]}    {item["Quant"]}   {item["Preco"]}  {item["Totall"]}");//, Fonts.FontA);
            }
            #region fra 
            //printer.Font("Font A", Fonts.FontA);
            //printer.Font("Font B", Fonts.FontB);
            //printer.Font("Font C", Fonts.FontC);
            //printer.Font("Font D", Fonts.FontD);
            //printer.Font("Font E", Fonts.FontE);
            //printer.Font("Font Special A", Fonts.SpecialFontA);
            //printer.Font("Font Special B", Fonts.SpecialFontB); 
            #endregion
            printer.Separator();
            //printer.Append($"TOTAL:                    {ft.Total}");
            printer.BoldMode($"TOTAL:                    {ft.Total}");
            printer.NewLines(2);
            //printer.Separator();
            printer.InitializePrint();
            //printer.CondensedMode(PrinterModeState.On);        
            #region height
            //printer.SetLineHeight(24);
            //printer.Append("Obrigado pela preferencia.");
            //printer.Append("This is third line with line height of 40 dots"); 
            #endregion
            printer.NewLines(2);
            //printer.Separator();
            printer.SetLineHeight(30);
            printer.AlignCenter();
            printer.UnderlineMode("DMZ SOFTWARE v.2023");
            printer.Append("Obrigado pela preferencia.");
            printer.Append("Volte Sempre...");
            printer.FullPaperCut();
            printer.PrintDocument();
            #region imprir
            //if (cbImprimir.cb1.Checked)
            //{
            //    DS ds = new DS();
            //    Utilities.AllTrim(ft);
            //    var ret = Imprimir.FillData(ft.ToDataTable(), Factl, _formasp, ds.Fact, ds.Formasp);
            //    var Ps = new PrintSetup
            //    {
            //        NrCopias = NrCopias.Value,
            //        ListaTipodoc = null,
            //        Origem = "fact",
            //        Impressora = comboBox1.Text.Trim(),
            //        DtPrint = ret.dtPrint,
            //        Formasp = ret.fp,
            //        Ds = ds,
            //        LinguaNacional = "PT"
            //    };
            //    if (cbPOS.cb1.Checked)
            //    {
            //        Ps.Nomfile = TmpTdoc.Nomfile3;
            //        Ps.XmlString = TmpTdoc.XmlStringPOS;
            //        Ps.POS = true;
            //    }
            //    if (cbA4.cb1.Checked)
            //    {
            //        Ps.UseFormasp = true;
            //        Ps.Nomfile = TmpTdoc.Nomfile;
            //        Ps.XmlString = TmpTdoc.XmlString;
            //    }
            //    if (cbA5.cb1.Checked)
            //    {
            //        Ps.Nomfile = TmpTdoc.Nomfile2;
            //        Ps.XmlString = TmpTdoc.XmlStringA5;
            //    }
            //    ReportHelper.PrintReport(Ps);
            //} 
            #endregion
        }

        private bool Pagamento()
        {
            _formasp = SQL.Initialize("formasp");
            foreach (var row in ContasDt.AsEnumerable())
            {
                if (row == null) continue;
                if (row["valor"].ToDecimal() == 0) continue;
                SetFormasP("Factstamp", ft.Factstamp, row, TmpTdoc.Sigla, TmpTdoc.Codmovtz, TmpTdoc.Descmovtz);
            }
            SQL.Save(_formasp, "formasp", false, "", "");
            return true;
        }

        private void SetFormasP(string Tabstamp, string stamp, DataRow row, string Sigla, decimal Codmovtz, string Descmovtz)
        {
            var r = _formasp.NewRow().Inicialize();
            r[Tabstamp] = stamp;
            r["Banco"] = row["Descricao"].ToString();
            r["Codtz"] = row["Codtz"].ToDecimal();
            r["Origem"] = Sigla;
            r["UsrLogin"] = Pbl.Usr.Usrstamp;
            r["Codmovtz"] = Codmovtz;
            r["Descmovtz"] = Descmovtz;
            r["Contatesoura"] = row["contas"].ToString();
            r["Titulo"] = row["Titulo"].ToString();
            r["Formaspstamp"] = Pbl.Stamp();

            r["Dcheque"] = Pbl.SqlDate;
            r["valor"] = row["valor"].ToDecimal();
            r["Contasstamp"] = row["Contasstamp"];
            r["Ccusto"] = Pbl.Usr.Ccusto;
            r["Ccustamp"] = Pbl.Usr.Ccustamp;
            r["Oristamp"] = stamp;
            r["No"] = ft.No;
            r["Origem"] = "POSRCL";
            r["Nome"] = ft.Nome;
            r["Moeda"] = Pbl.MoedaBase;
            r["Banco"] = "CAIXA";
            _formasp.Rows.Add(r);
        }
        public string Tipodoc { get; set; }
        private void AddValue(string valor)
        {
            if (gridUi1.CurrentRow != null)
                gridUi1.CurrentRow.Cells["Valor"].Value = gridUi1.CurrentRow.Cells["Valor"].Value + valor;
            gridUi1.Update();
            Totais();
        }
        private void b1_Click(object sender, EventArgs e)
        {
            AddValue(b1.Text);
        }

        private void b2_Click(object sender, EventArgs e)
        {
            AddValue(b2.Text);
        }

        private void b3_Click(object sender, EventArgs e)
        {
            AddValue(b3.Text);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            AddValue(b4.Text);
        }

        private void b5_Click(object sender, EventArgs e)
        {
            AddValue(b5.Text);
        }

        private void b6_Click(object sender, EventArgs e)
        {
            AddValue(b6.Text);
        }

        private void b7_Click(object sender, EventArgs e)
        {
            AddValue(b7.Text);
        }

        private void b8_Click(object sender, EventArgs e)
        {
            AddValue(b8.Text);
        }

        private void b9_Click(object sender, EventArgs e)
        {
            AddValue(b9.Text);
        }

        private void b0_Click(object sender, EventArgs e)
        {
            AddValue(b0.Text);
        }

        private void btC_Click(object sender, EventArgs e)
        {
            if (gridUi1.CurrentRow != null)
                gridUi1.CurrentRow.Cells["Valor"].Value = gridUi1.CurrentRow.Cells["Valor"].Value.ToString().RemoveLast();
            gridUi1.Update();
            Totais();
        }

        private void btD_Click(object sender, EventArgs e)
        {
            if (gridUi1.CurrentRow != null)
                gridUi1.CurrentRow.Cells["Valor"].Value = 0;
            gridUi1.Update();
            Totais();
        }

        public void btnAceitar_Click(object sender, EventArgs e)
        {
            Pagar();
            ContasDt.Dispose();
        }
        public TRcl TmpTrcl;
        private PrinterStatusEventArgs ps;
        private FontStyle tamanho;
        private object informacao;

        private bool RclAdd()
        {
            TmpDivida = SQL.GetGen2DT($"select * from ClCCF() where oristamp='{ft.Factstamp.Trim()}'"); ;
            if (TmpDivida.HasRows())
            {
                _rcll = SQL.Initialize("rcll");
                var maximo = SQL.Maximo("rcl", "numero", $"Year(data) ={Pbl.SqlDate.Year} and sigla='{TmpTrcl.Sigla.Trim()}'");
                _rcl = Utilities.DoAddline<RCL>();
                _rcl.Rclstamp = Pbl.Stamp("POSSUP");
                _rcl.Pos = true;
                _rcl.Nome = ft.Nome;
                _rcl.Moeda = ft.Moeda;
                _rcl.No =ft.No;
                _rcl.Numero = maximo;
                _rcl.Data = Pbl.SqlDate;
                _rcl.Numdoc = TmpTrcl.Numdoc;
                _rcl.Sigla = TmpTrcl.Sigla;
                _rcl.Nomedoc = TmpTrcl.Descricao;
                _rcl.Codmovcc = TmpTrcl.Codmovcc;
                _rcl.Descmovcc = TmpTrcl.Descmovcc;
                _rcl.Codmovtz = TmpTrcl.Codmovtz;
                _rcl.Descmovtz = TmpTrcl.Descmovtz;
                _rcl.Ccusto = Pbl.Usr.Ccusto;
                _rcl.Ccustamp = Pbl.Usr.Ccustamp;
                _rcl.Clstamp= ft.Clstamp;
                _rcl.Usrstamp = Pbl.Usr.Usrstamp;
                _rcl.Total = _npago;
                var res = EF.Save(_rcl);
                if (res.ret >0)
                {
                    foreach (var r in TmpDivida.AsEnumerable())
                    {
                        Helper.FillRcl(_rcll, r, _rcl.Rclstamp, "rcl");
                    }
                    SQL.Save(_rcll, "rcll", false, "", "");
                    _formasp = SQL.Initialize<Formasp>();
                    foreach (var row in ContasDt.AsEnumerable())
                    {
                        if (row == null) continue;
                        if (row["valor"].ToDecimal() == 0) continue;
                        SetFormasP("Rclstamp", _rcl.Rclstamp, row, TmpTrcl.Sigla, TmpTrcl.Codmovtz, TmpTrcl.Descmovtz);
                    }
                    SQL.Save(_formasp, "formasp", false, "", "");
                    return true;
                }
            }
            MsBox.Show("Desculpa mas o documento não tem movimentos!");
            return false;
        }
        public DataTable Factl { get; set; }
        public DataTable ContasDt { get; private set; }
        public object AsciiControlChars { get; private set; }
        public object Info { get; private set; }
        //public IEnumerable<object> listFtl { get; private set; }
        private void btnCinquenta_Click(object sender, EventArgs e)
        {
            Troco(50);
        }

        private void cbPOS_CheckedChangeds()
        {
            //cbA4.Update(!cbPOS.cb1.Checked);
            //cbA5.Update(!cbPOS.cb1.Checked);
        }

        private void cbA5_CheckedChangeds()
        {
            //cbA4.Update(!cbA5.cb1.Checked);
            //cbPOS.Update(!cbA5.cb1.Checked);
        }

        private void cbA4_CheckedChangeds()
        {
            //cbA5.Update(!cbA4.cb1.Checked);
            //cbPOS.Update(!cbA4.cb1.Checked);
        }
    }
}
