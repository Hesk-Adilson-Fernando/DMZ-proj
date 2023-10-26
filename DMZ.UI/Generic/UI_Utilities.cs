

using DMZ.BL.Classes;
using DMZ.UI.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml.Schema;

namespace DMZ.UI.Generic
{
    public static class UI_Utilities
    {
       

        public static bool Existe(this List<string> lista,string descricao)
        {
            bool retorno=false;
            foreach (var item in lista)
            {
                if (item.ToLower().Trim().Equals(descricao.Trim().ToLower()))
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        public static void ShowForm<T>(this Form w, Form mdiParentForm) where T : Form, new()
        {
            T form;
            form=new T();
            
            if (!CheckOpened(w.Name))
            {
                var x = 0;
                var y = 0;
                if (mdiParentForm.IsMdiContainer)
                {
                    w.MdiParent = mdiParentForm;
                    x = mdiParentForm.Location.X;
                    y = mdiParentForm.Location.Y;
                    mdiParentForm.Text = Pbl.Info + " - " + w.Text;
                    var p = mdiParentForm.Controls.Find("panelDashBoard", true);
                    if (p != null)
                    {
                        foreach (var item in p)
                        {
                            if (item == null) continue;
                            ((Panel)item).Visible = false;
                        }
                    }
                }
                else
                {
                    w.MdiParent = mdiParentForm.MdiParent;
                    x = mdiParentForm.MdiParent.Location.X;
                    y = mdiParentForm.MdiParent.Location.Y;
                }

                w.StartPosition = FormStartPosition.Manual;
                w.Location = new Point(x + 230, y + 110);
                w.Show();
            }
            else
            {
                MsBox.Show($"O Formulário {w.Text} já está aberto");
                w.Dispose();
            }


        }
        public static void ShowForm(this Form w, Form mdiParentForm,bool showDialog=false)
        {

            if (!CheckOpened(w.Name))
            {
                int x;
                int y;
                if (mdiParentForm.IsMdiContainer)
                {
                    w.MdiParent = mdiParentForm;
                    x = mdiParentForm.Location.X;
                    y = mdiParentForm.Location.Y;
                    mdiParentForm.Text = Pbl.Info + " - " + w.Text;
                    var p = mdiParentForm.Controls.Find("panelDashBoard", true);
                    if (p != null)
                    {
                        foreach (var item in p)
                        {
                            if (item == null) continue;
                            ((Panel)item).Visible = false;
                        }
                    }
                }
                else
                {
                    w.MdiParent = mdiParentForm.MdiParent;
                    x = mdiParentForm.MdiParent.Location.X;
                    y = mdiParentForm.MdiParent.Location.Y;
                }
                
                w.StartPosition = FormStartPosition.Manual;
                w.Location = new Point(x + 230, y + 110);
                if (showDialog)
                {
                    w.MdiParent = null;
                    w.TopLevel = true;
                    w.ShowDialog();
                }
                else
                {
                    w.Show();
                }
            }
            else
            {
                MsBox.Show($"O Formulário {w.Text} já está aberto");
                w.Dispose();
            }


        }
        public static void ShowForm(this Form w, Form mdiParentForm, Point point )
        {

            if (!CheckOpened(w.Name))
            {
                var x = 0;
                var y = 0;
                if (mdiParentForm.IsMdiContainer)
                {
                    w.MdiParent = mdiParentForm;
                    x = mdiParentForm.Location.X;
                    y = mdiParentForm.Location.Y;
                    mdiParentForm.Text = Pbl.Info + " - " + w.Text;
                    var p = mdiParentForm.Controls.Find("panelDashBoard", true);
                    if (p != null)
                    {
                        foreach (var item in p)
                        {
                            if (item == null) continue;
                            ((Panel)item).Visible = false;
                        }
                    }
                }
                else
                {
                    w.MdiParent = mdiParentForm.MdiParent;
                    x = mdiParentForm.MdiParent.Location.X;
                    y = mdiParentForm.MdiParent.Location.Y;
                }

                w.StartPosition = FormStartPosition.Manual;
                //w.Location = new Point(x + 230, y + 110);
                w.Location = point;
                w.Show();
            }
            else
            {
                MsBox.Show($"O Formulário {w.Text} já está aberto");
                w.Dispose();
            }


        }
        private static bool CheckOpened(string name)
        {
            var fc = Application.OpenForms;
            return fc.Cast<Form>().Any(frm => frm.Name == name);
        }

        public static byte[] GetImagem(Image image)
        {
            MemoryStream ms = null;
            if (image!=null)
            {
                using (ms = new MemoryStream())
                {
                    image.Save(ms, ImageFormat.Png);                    
                }
            }
            else
            {
                image = Properties.Resources.Picture_64px;
                using (ms = new MemoryStream())
                {
                    image.Save(ms, ImageFormat.Png);
                }
            }
            return ms.ToArray();
        }
        public static Image ByteToImage(byte[] blob)
        {
            try
            {
                var mStream = new MemoryStream();
                var pData = blob;
                switch (pData.Length)
                {
                    case 0:
                    case 1:
                        return null;
                }

                mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                var bm = Image.FromStream(mStream,true);
                mStream.Dispose();
                return bm;
            }
            catch (Exception e)
            {
                //Console.WriteLine(e);
                //throw;
                return Properties.Resources.Picture_64px;
            }
        }

        public static bool IsString( this string xx)
        {
            var retorno = false;
               decimal xxx =0;
               retorno = decimal.TryParse(xx, out xxx);
               return retorno;
        }

    }
}
