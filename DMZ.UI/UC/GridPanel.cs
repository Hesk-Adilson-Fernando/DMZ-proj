using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.UI.Basic;
using DMZ.UI.Classes;

using DMZ.UI.Generic;
using DataTable = System.Data.DataTable;
using Utilities = DMZ.BL.Classes.Utilities;
using Syncfusion.XlsIO;


namespace DMZ.UI.UC
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public partial class GridPanel2 : UserControl
    {
        public delegate void CellClicar(object sender, DataGridViewCellEventArgs e);

        public event CellClicar GridCellClick;
        public bool AddControls { get; set; }

        private Rectangle _rectangle;
        private DateTimePicker _dtp;
        private Panel _panel;
        public bool NotAddLine { get; set; }

        public GridPanel2()
        {
            InitializeComponent();

        }
        private Form _myParent;
        public GridUi Grelha;

        public Color PanelBackColor
        {
            get => panelText.BackColor;
            set => panelText.BackColor = value;
        }

        public Color Label1Color
        {
            get => label1.ForeColor;
            set => label1.ForeColor = value;
        }
        public Image PictureBox1Image
        {
            get => btnNovo.Image;
            set => btnNovo.Image = value;
        }
        public Color GridpanelBackColor
        {
            get =>panelText.BackColor;
            set
            {
                panelText.BackColor = value;
                btnNovo.BackColor = value;
                btnGravar.BackColor = value;
                button1.BackColor = value;
                button2.BackColor = value;
                btnDell.BackColor = value;
            } 
        }
        public string Label1Text
        {
            get => label1.Text;
            set => label1.Text = value;
        }
        public Font Label1Font
        {
            get => label1.Font;
            set => label1.Font = value;
        }
        public string Gridnome { get; set; } = "gridUi1";
        public bool Callform { get;  set; }
        public virtual void OnGridCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridCellClick == null) return;
            var handler = GridCellClick;
            handler?.Invoke(sender, e);
        }
        private void GridPanel_Load(object sender, EventArgs e)
        {
            btnGravar.Visible = MostraGravar;
        }
        public bool MostraGravar { get; set; }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            AddLine();
        }
        private void AddLine()
        {
            var frm = ParentForm;
            if (frm == null) return;
            if (!(frm is FrmClasse) && !(frm is FrmClasse2)) return;
            if (frm is FrmClasse classe)
            {
                if (!classe.EditMode) return;
            }
            if (!Callform)
            {

                if (UsaNomeGrid)
                {
                    Grelha = (GridUi)Helper.GetAll(frm, typeof(GridUi)).FirstOrDefault(x=>x.Name.ToLower().Trim().Equals(Gridnome.ToLower().Trim()));
                    if (Grelha == null) return;
                    Grelha.AddLine(); 
                }
                else
                {
                    Grelha = (GridUi)Helper.GetAll(this, typeof(GridUi)).FirstOrDefault();
                    if (Grelha == null) return;
                    Grelha.AddLine();      
                }

            }
            else
            {
                CallformEvent();
            }
        }

        public bool UsaNomeGrid { get; set; }
        public delegate void ClickButton();
        public event ClickButton CallForm;
        public virtual void CallformEvent()
        {
            var handler = CallForm;
            handler?.Invoke();
        }
        public delegate void RefreshDelegate();
        public event RefreshDelegate RefreshEvent;
        public virtual void RefreshMethod()
        {
            var handler = RefreshEvent;
            handler?.Invoke();
        }
        public delegate void AfterSave();
        public event AfterSave AfterSaveEvent;
        public virtual void AfterSaveMethod()
        {
            var handler = AfterSaveEvent;
            handler?.Invoke();
        }
        public delegate bool BeforeAddLineDelegate();
        public event BeforeAddLineDelegate BeforeAddLineEvent;

        public delegate void AfterAddLineDelegate();
        public event AfterAddLineDelegate AfterAddLineEvent;
        public virtual void AfterAddLine()
        {
            AfterAddLineEvent?.Invoke();
        }
        public delegate bool BeforeDellLineDelegate();
        public event BeforeDellLineDelegate BeforeDellLineEvent;
        public virtual bool BeforeDellLine()
        {
            var handler = BeforeDellLineEvent;
            return handler != null && handler.Invoke();
        }
        public delegate void AfterDellLineDelegate();
        public event BeforeDellLineDelegate AfterDellLineEvent;
        public virtual void AfterDellLine()
        {
            AfterDellLineEvent?.Invoke();
        }
        public bool BeforeAddLine()
        {
            var handler = BeforeAddLineEvent;
            return handler != null && handler.Invoke();

        }
        public void Alert(string msg, Form_Alert.EnmType type)
        {
            var frm = new Form_Alert();
            frm.ShowAlert(msg,type);
        }
        private void  DellLine()
        {
            var frm = ParentForm;
            if (frm == null) return;
            if (!(frm is FrmClasse) && !(frm is FrmClasse2)) return;
            if (frm is FrmClasse classe)
            {
                if (!classe.EditMode) return;
            }

            if (UsaNomeGrid)
            {
                Grelha = (GridUi)Helper.GetAll(frm, typeof(GridUi)).FirstOrDefault(x=>x.Name.ToLower().Trim().Equals(Gridnome.ToLower().Trim()));
                if (Grelha == null) return;
                Grelha.DellLine();
            }
            else
            {
                Grelha = (GridUi)Helper.GetAll(this, typeof(GridUi)).FirstOrDefault();
                if (Grelha == null) return;
                Grelha.DellLine();      
            }
        }

        public string DefaultColumn { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TipoMenu)
            {
                dmzContextMenuStrip2.ShowMenuStrip(button1);
            }
            else
            {
                dmzContextMenuStrip1.ShowMenuStrip(button1);
            }
            
        }

        public bool TipoMenu { get; set; }

        private void button2_Click(object sender, EventArgs e)
        {
            var xx = BeforeAddLine();
            if (xx) return;
            AddLine();
            AfterAddLine();
        }
        private void btnDell_Click(object sender, EventArgs e)
        {
            var xx = BeforeDellLine();
            if (xx) return;
            DellLine();
            AfterDellLine();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            var xx = Save();
            if (!xx)
            {
                var gd = Helper.GetAll(this, typeof(GridUi)).FirstOrDefault();
                if (gd == null) return;
                ((GridUi)gd).Update();
                var dt = ((GridUi) gd).DataSource as DataTable;
                if (!(dt?.Rows.Count > 0)) return;
                var frm = ParentForm;
                if (frm == null) return;
                if (!(frm is FrmClasse) && !(frm is FrmClasse2)) return;
                if (frm is FrmClasse)
                {
                    var procurou = ((FrmClasse)frm).Procurou;
                    var ctabela=((FrmClasse)frm).Ctabela;
                    var cLocalStamp=((FrmClasse)frm).CLocalStamp;
                    Executar(dt, ((GridUi)gd).TabelaSql,!procurou, cLocalStamp, ctabela);
                }
                else
                {
                    Executar(dt, ((GridUi)gd).TabelaSql, false, "", "");
                }
            }
        }

        private void Executar(DataTable dt,string TabelaSql, bool procurou, string cLocalStamp, string ctabela)
        {
            var xxx = SQL.Save(dt, TabelaSql, !procurou, cLocalStamp, ctabela);
            if (xxx.numero >0)
            {
                AfterSaveMethod();
                Alert("Gravado com sucesso", Form_Alert.EnmType.Success);
            }
            else
            {
                MsBox.Show(xxx.messagem);
            }
        }

        public delegate bool SaveDelegate();

        public event SaveDelegate SaveEvent;
        public bool Save()
        {
            var handler = SaveEvent;
            return handler != null && handler.Invoke();

        }
        private void excelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                var openFileDialog1 = new OpenFileDialog
                {
                    Filter = @"XML Files (*.xml; *.xls; *.xlsx; *.xlsm; *.xlsb) |*.xml; *.xls; *.xlsx; *.xlsm; *.xlsb",
                    FilterIndex = 3,
                    Multiselect = false,
                    Title = @"Open File",
                    InitialDirectory = @"Desktop"
                };
                var frm = ParentForm;
                if (frm != null && frm.Text.Equals("FrmClasse2"))
                {
                }
                else
                {
                    var nomFrnm = ((FrmClasse)frm)?.Name;
                    if (nomFrnm is "FrmProcur")
                    {
                        //openFileDialog1.Filter = @"Excel Documents (*.xlsx)|*.xlsx";
                        openFileDialog1.Filter = @"XML Files (*.xml; *.xls; *.xlsx; *.xlsm; *.xlsb) |*.xml; *.xls; *.xlsx; *.xlsm; *.xlsb";
                    }
                }
                if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
                var pathName = openFileDialog1.FileName;
                var fileName = Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
                var file = new FileInfo(pathName);
                if (!file.Exists)
                {
                    throw new Exception("Error, file doesn't exists!");
                }
                DataTable dt;
                var grid = (GridUi)Helper.GetAll(this, typeof(GridUi)).FirstOrDefault();
                if (grid == null) return;
                if (frm != null && frm.Text.Equals("FrmClasse2"))
                {
                    dt = Utilities.GetDs(file, pathName, fileName);
                    grid.DataSource = null;
                    grid.DataSource = dt;
                    if (dt?.Rows.Count >= 0)
                    {
                        label1.Text = $@"{dt.Rows.Count} registos encontrados.";
                    }
                }
                else
                {
                    var nomFrnm = ((FrmClasse)frm)?.Name;
                    if (nomFrnm is "FrmProcur")
                    {
                        if (grid.Name.Equals("gridUiAnalises") || grid.Name.Equals("gridUIFt1"))
                        {
                            using (ExcelEngine excelEngine = new ExcelEngine())
                            {
                                IApplication application = excelEngine.Excel;
                                application.DefaultVersion = ExcelVersion.Xlsx;
                                FileStream inputStream = new FileStream(pathName, FileMode.Open, FileAccess.Read);
                                IWorkbook workbook = application.Workbooks.Open(inputStream);
                                IWorksheet worksheet = workbook.Worksheets[0];

                                //Read data from the worksheet and export to the DataTable.
                                dt = worksheet.ExportDataTable(worksheet.UsedRange,
                                    ExcelExportDataTableOptions.ColumnNames);
                            }
                            if (grid.Rows.Count >= 0)
                            {
                                grid.DataSource = null;
                                if (dt != null)
                                    for (int i = 0; i < dt.Rows.Count; i++)
                                    {
                                        grid.AddLine();
                                        for (int j = 0; j < dt.Columns.Count; j++)
                                        {
                                            var nome = dt.Columns[j].ColumnName;
                                            grid.DtDS.Rows[grid.DtDS.Rows.Count - 1][nome] =
                                                dt.Rows[i][nome].ToString();
                                        }
                                    }
                                grid.AutoGenerateColumns = false;
                                grid.DataSource = grid.DtDS;
                            }
                        }
                        MsBox.Show("Importado com sucesso");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog
            {
                Filter = @"Excel Documents (*.xls)|*.xls",
                Title = @"Open Text File-R13",
                InitialDirectory = @"Desktop",
                FileName = "export.xls"
            };
            //var frm = ParentForm;
            //if (frm != null && frm.Text.Equals("FrmClasse2"))
            //{
            //    sfd.Filter = @"Excel Documents (*.xls)|*.xls";
            //    sfd.FileName = "export.xls";
            //}
            //else
            //{
            //    var nomFrnm = ((FrmClasse)frm)?.Name;
            //    if (nomFrnm is "FrmProcur")
            //    {
            //        //sfd.Filter = @"Excel Documents (*.xlsx)|*.xlsx";

            //        sfd.Filter = @"Excel Documents (*.xls)|*.xls";
            //        sfd.FileName = "export.xls";
            //    }
            //}
            if (sfd.ShowDialog() != DialogResult.OK) return;
            var grid = (GridUi)Helper.GetAll(this, typeof(GridUi)).FirstOrDefault();
            if (grid == null) return;
            Helper.ToCsV(grid, sfd.FileName,true);
            MsBox.Show("Exportado com sucesso");
        }

        private void pDFToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog
            {
                //Filter = @"Excel Documents (*.xlsx)|*.xlsx",
                Filter = @"Word 97-2003 Documents (*.doc)|*.doc|Word 2007 Documents (*.docx)|*.docx",
            Title = @"Open Text File-R13",
                InitialDirectory = @"Desktop",
                FileName = "export.doc"
            };
            if (sfd.ShowDialog() != DialogResult.OK) return;
            var grid = (GridUi)Helper.GetAll(this, typeof(GridUi)).FirstOrDefault();
            if (grid == null) return;
            Helper.ToCsV(grid, sfd.FileName, ShowColNames);
            MsBox.Show("Exportado com sucesso");
        }
        public bool ShowColNames { get; set; }
    }
}
