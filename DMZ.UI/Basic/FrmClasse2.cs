using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DMZ.UI.Classes;
using DMZ.UI.Generic;
using DMZ.UI.UC;
using Util = DMZ.UI.Generic.Util;
namespace DMZ.UI.Basic
{
    public partial class FrmClasse2 : Form 
    {
        private Size formSize;

        public FrmClasse2()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message m)
        {
           // const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112; 
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;
            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right

            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>

            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          

                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion
            //Remove border and keep snap window
            //if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            //{
            //    return;
            //}
            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);               

                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }  
        public void MouseDownEvent()
        {
            Dllimport.ReleaseCapture();
            Dllimport.SendMessage(Handle, 0x112, 0xf012, 0);
        }
        public string CLocalStamp { get; set; }
        public bool EditMode { get; set; }
        private void FrmClasse2_Load(object sender, EventArgs e)
        {

        }
        public bool Maximizado { get; set; }
        public void Maximizar()
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
                    if (!frm.IsMdiContainer) continue;
                    if (frm is DemoMdi)
                    {
                        if (((DemoMdi)frm).Ocultado)
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
        public T AutomaticEntityFill<T>(T entity) where T : class
        {
            using (var dt = new DataTable())
            {
                var dc1 = new DataColumn("Campo");
                dt.Columns.Add(dc1);
                var dc2 = new DataColumn("Valor");
                dt.Columns.Add(dc2);
                var ctl = Helper.GetAll(this, typeof(TbDefault)).ToList();
                var dtp = Helper.GetAll(this, typeof(DtDefault)).ToList();
                ctl.AddRange(dtp);
                var pr = Helper.GetAll(this, typeof(Procura)).ToList();
                ctl.AddRange(pr);
                var cb = Helper.GetAll(this, typeof(CbDefault)).ToList();
                ctl.AddRange(cb);
                var imgGroup = Helper.GetAll(this, typeof(ImgGroup)).ToList();
                ctl.AddRange(imgGroup);
                foreach (var x in ctl)
                {
                    var dr = dt.NewRow();
                    var @default = x as TbDefault;
                    if (@default?.Value != null)
                    {
                        dr["Campo"] = @default.Value.ToLower();
                        dr["Valor"] = @default.tb1.Text;
                        if (!string.IsNullOrEmpty(@default.Value2))
                        {
                            var dr2 = dt.NewRow();
                            dr2["Campo"] = @default.Value2.ToLower();
                            dr2["Valor"] = @default.Text2;
                            dt.Rows.Add(dr2);
                        }
                    }
                    var dtpDefault = x as DtDefault;
                    if (dtpDefault?.Value != null)
                    {
                        dr["Campo"] = dtpDefault.Value.ToLower();
                        dr["Valor"] = dtpDefault.dt1.Value;
                    }
                    var prx = x as Procura;
                    if (prx != null)
                    {
                        if (prx.Value != null)
                        {
                            dr["Campo"] = prx.Value.ToLower();
                            dr["Valor"] = prx.tb1.Text;
                        }
                        if (!string.IsNullOrEmpty(prx.Value2))
                        {
                            var dr2 = dt.NewRow();
                            dr2["Campo"] = prx.Value2.ToLower();
                            dr2["Valor"] = prx.Text2;
                            dt.Rows.Add(dr2);
                        }
                    }
                    var cbx = x as CbDefault;
                    if (cbx?.Value != null)
                    {
                        dr["Campo"] = cbx.Value.ToLower();
                        dr["Valor"] = cbx.cb1.Checked;
                    }
                    var dtx = x as DtDefault;
                    if (dtx?.Value != null)
                    {
                        dr["Campo"] = dtx.Value.ToLower();
                        dr["Valor"] = dtx.dt1.Value;
                    }
                    dt.Rows.Add(dr);
                }
                var t = entity.GetType();
                var propertiesList = t.GetProperties();
                foreach (var p in propertiesList)
                {
                    try
                    {
                        var dataRow = dt.NewRow();
                        var prop = p.Name.ToLower();
                        if (prop.Contains("stamp")) continue;
                        foreach (var r in dt.AsEnumerable())
                        {
                            if (r == null) continue;
                            var campo = r["Campo"].ToString().Trim().ToLower();
                            if (campo != prop) continue;
                            dataRow = r;
                            break;
                        }
                        var valor = dataRow["Valor"];
                        var type = p.PropertyType.ToString();
                        var ckNull = type.Contains("System.Nullable");
                        if (ckNull)
                        {
                            var xx = type.Substring(18, 14);
                            if (xx == "System.Decimal")
                            {
                                p.SetValue(entity, BL.Classes.Extensions.CToD(valor.ToString()));
                            }
                            xx = type.Substring(18, 13);
                            if (xx == "System.String")
                            {
                                p.SetValue(entity, valor.ToString());
                            }
                            xx = type.Substring(18, 14);
                            if (xx == "System.Boolean")
                            {
                                p.SetValue(entity, valor);
                            }
                        }
                        else
                        {
                            if (p.PropertyType == typeof(DateTime))
                            {
                                try
                                {
                                    var date = Convert.ToDateTime(valor);
                                    p.SetValue(entity, date.Year < 1900 ? new DateTime(1900, 1, 1) : date);
                                }
                                catch
                                {
                                    p.SetValue(entity, new DateTime(1900, 1, 1));
                                }
                            }
                            else if (p.PropertyType == typeof(decimal))
                            {
                                p.SetValue(entity, BL.Classes.Extensions.CToD(valor.ToString()));
                            }
                            else if (p.PropertyType == typeof(int))
                            {
                                p.SetValue(entity, BL.Classes.Extensions.CToI(valor.ToString()));
                            }
                            else if (p.PropertyType == typeof(bool))
                            {
                                p.SetValue(entity, BL.Classes.Extensions.ToBool(valor.ToString()));
                            }
                            else if (p.PropertyType == typeof(string))
                            {
                                p.SetValue(entity, valor.ToString());
                            }
                            else if (p.PropertyType == typeof(byte))
                            {
                                foreach (var item in imgGroup)
                                {
                                    var cbx = item as ImgGroup;
                                    if (cbx?.Value == null) continue;
                                    if (cbx?.Value.ToLower() != p.Name.ToLower()) continue;
                                    byte[] img = Util.GetImagem(cbx.pictureBox1.Image,cbx.SetWhitePicture);
                                    p.SetValue(entity, img);
                                    break;
                                }

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.ToString());
                    }
                }
                return entity;
            }
        }
        public void AutomaticControlsFill(DataRow Row)
        {
            if (Row == null) return;
            var row = Row;
            var tb = Helper.GetAll(this, typeof(TbDefault)).ToList();
            var dtp = Helper.GetAll(this, typeof(DtDefault)).ToList();
            var pr = Helper.GetAll(this, typeof(Procura)).ToList();
            var cb = Helper.GetAll(this, typeof(CbDefault)).ToList();
            var imgGroup = Helper.GetAll(this, typeof(ImgGroup)).ToList();

            foreach (DataColumn p in Row.Table.Columns)
            {
                var pName = p.ColumnName.ToLower().Trim();
                var valor = row[pName];
                
                try
                {
                    foreach (var c in tb)
                    {
                        if (((TbDefault)c)?.Value == null) continue;
                        var x = ((TbDefault)c).Value.ToLower();
                        if (x.ToLower() == pName)
                        {
                            ((TbDefault)c).tb1.Text = valor.ToString().Trim();
                        }
                    }

                    if (p.DataType == typeof(byte))
                    {
                        foreach (var item in imgGroup)
                        {
                            var cbx = item as ImgGroup;
                            if (cbx?.Value == null) continue;
                            if (cbx.Value.ToLower() != pName) continue;
                            byte[] img = Util.GetImagem(cbx.pictureBox1.Image,cbx.SetWhitePicture);
                            //p.SetValue(entity, img);
                            break;
                        }

                    }
                    if (p.DataType == typeof(bool))
                    {
                        foreach (var c in cb)
                        {
                            if (((CbDefault)c)?.Value == null) continue;
                            var x = ((CbDefault)c).Value.ToLower();
                            if (x.ToLower() != pName) continue;
                            ((CbDefault)c).cb1.Checked = (bool)valor;
                            if ((bool)valor)
                            {
                                ((CbDefault)c).btnCheck.Image = Properties.Resources.Checked_Checkbox_2_23px;
                            }
                            else
                            {
                                ((CbDefault)c).btnCheck.Image = Properties.Resources.Unchecked_Checkbox_23px;
                            }
                        }
                    }
                    if (p.DataType == typeof(DateTime))
                    {
                        foreach (var c in dtp)
                        {
                            var x = ((DtDefault)c).Value;
                            if (x.ToLower() == pName)
                            {
                                ((DtDefault)c).dt1.Value = Convert.ToDateTime(valor);
                            }
                        }
                    }
                    foreach (var c in pr)
                    {
                        if (((Procura)c)?.Value != null)
                        {
                            var x = ((Procura)c).Value.ToLower();
                            if (x.ToLower() == pName)
                            {
                                ((Procura)c).tb1.Text = valor.ToString().Trim();
                            }
                        }
                        if (((Procura)c)?.Value2 == null) continue;
                        var xx = ((Procura)c).Value2.ToLower();
                        if (xx.ToLower() == pName)
                        {
                            ((Procura)c).Text2 = valor.ToString().Trim();
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownEvent();
        }

        private void FrmClasse2_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownEvent();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownEvent();
        }
    }
}
