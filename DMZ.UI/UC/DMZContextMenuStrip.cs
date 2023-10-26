using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DMZ.UI.Generic;
using Point = System.Windows.Point;


namespace DMZ.UI.UC
{
    public  class DMZContextMenuStrip: ContextMenuStrip
    {
        public DMZContextMenuStrip()
        {
            BackColor = Color.WhiteSmoke;
            //BackColor = Color.FromArgb(39, 59, 80);
            ForeColor = Color.White;
            Font= new Font("Century Gothic",8,FontStyle.Regular );
        }
        [Description("Cor do fundo do Menu")]
        public Color ContextBackcolor
        {
            get => BackColor;
            set => BackColor = value;
        }

        public void ShowMenuStrip(Button button)
        {
            Show(button,0,button.Height);
            //Show();
            //Show()
            //Show( Cursor.Position);
        }

        public void ShowMenuStrip()
        {
            Show(Cursor.Position);
        }

    }
}
