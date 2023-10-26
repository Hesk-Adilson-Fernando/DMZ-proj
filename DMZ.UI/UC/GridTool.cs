using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Generic;
using DMZ.UI.Reports;

namespace DMZ.UI.UC
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public partial class GridTool : UserControl
    {
        public DataGridView dataGridView1;

        public string Gridnome { get; set; } = "gridUi1";

        public GridTool()
        {
            InitializeComponent();

        }

        private DataTable dt;
        private void GridTool_Load(object sender, EventArgs e)
        {

        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string chkArmazem;
            DateTime dData1, dData2;
            chkArmazem = lblCodArmaz.Text.ToDecimal().Equals(0) ? "" : $" and codarm= {lblCodArmaz.Text.ToDecimal()}";            
            dData1 = dtpData1.Value;
            dData2 = dtpData2.Value;
            dt = GenBl.ExtratoProduto(dData1.ToSqlDate(),dData2.ToSqlDate(),chkArmazem,txtCodigo.Text);
            if (dt?.Rows.Count>0)
            {
                var dr = dt.NewRow();
                foreach (var r in dt.AsEnumerable())
                {
                    if (r==null) continue;
                    if (Convert.ToInt32(r["ordem"]) != 1) continue;
                    if (r["entrada"].ToDecimal() != 0 || r["saida"].ToDecimal() != 0) continue;
                    dr = r;   
                    break;
                }
                if (dr.RowState != DataRowState.Detached) dt.Rows.Remove(dr);
            }
            var frm = ParentForm;
            if (frm == null) return;
            var grid = Helper.GetAll(ParentForm, typeof(GridUi)).ToList().Find(x => x.Name.Trim().ToLower().Equals(Gridnome.ToLower().Trim()));
            if (grid == null) return;
            ((GridUi)grid).DataSource=null;
            ((GridUi)grid).AutoGenerateColumns=false;
            ((GridUi)grid).DataSource = dt;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            dmzContextMenuStrip1.ShowMenuStrip(button1);
        }

        public void PassData(DataRow dr)
        {
            if (dr == null) return;
            lblCodArmaz.Text = dr[1].ToString();
            tbArmazem.Text = dr[0].ToString();
        }
        private void btnArmaz_Click(object sender, EventArgs e)
        {
            var formparent = FindForm();
            var tmpFound = SQL.GetGen2DT("Select Descricao = 'Todos Armazens', 0 as codigo union all Select descricao, codigo from armazem");
            var qr = new Querry
            {
                radGridView1 = {DataSource = null, AutoGenerateColumns = false},
                Campo1 = "codigo",
                Campo2 = "descricao",
                Campo3 = "",
                PControl2 = PassData,
                ShowStk = false,
                Width1 = 90,
                Origem = true,
                Width2 = 270,
                Caption1 = "Código",
                Caption2 = "Descrição"
            };

            //qr.Location = new Point(100, 100);
            //qr.radGridView1.DataSource = tmpDt;
            qr.radGridView1.DataSource = tmpFound;
            qr.labelX1.Text = tmpFound.Rows.Count + @" registos encontados";
            qr.ShowForm(formparent);
        }

        private void exportarParaExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = ParentForm;
            if (frm == null) return;
            var grid = Helper.GetAll(ParentForm, typeof(GridUi)).ToList().Find(x => x.Name.Trim().ToLower().Equals(Gridnome.ToLower().Trim()));
            if (grid == null) return;
            ((GridUi)grid).DataSource = null;
            dataGridView1=(GridUi)grid;

            var sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "export.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //ToCsV(dataGridView1, @"c:\export.xls");
                ToCsV(dataGridView1, sfd.FileName); // Here dataGridview1 is your grid view name
            }

            //// creating Excel Application  
            //Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            //// creating new WorkBook within Excel application  
            //Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            //// creating new Excelsheet in workbook  
            //Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            //// see the excel sheet behind the program  
            //app.Visible = true;
            //// get the reference of first sheet. By default its name is Sheet1.  
            //// store its reference to worksheet  
            //worksheet = workbook.Sheets["Sheet1"];
            //worksheet = workbook.ActiveSheet;
            //// changing the name of active sheet  
            //worksheet.Name = "Exported from gridview";
            ////dataGridView1= ((FrmClasse2)ParentForm).GridUi
            //// storing header part in Excel  
            //for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            //{
            //    worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            //}
            //// storing Each row and column value to excel sheet  
            //for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            //{
            //    for (int j = 0; j < dataGridView1.Columns.Count; j++)
            //    {
            //        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
            //    }
            //}
            //// save the application  
            //workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            //// Exit from the application  
            //app.Quit();
        }
        private void ToCsV(DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //var dData1 = dtpData1.Value.ToShortDateString();
            //var dData2 = dtpData2.Value.ToShortDateString();
            //var f = new FrmReport {Origem = "ExtProd", Dt = dt};
            //f.Intervalo = $"De: {dData1} até: {dData2}";
            //f.NomeProduto = txtDescricao.Text;
            //f.ShowForm(ParentForm);

        }
    }
}
