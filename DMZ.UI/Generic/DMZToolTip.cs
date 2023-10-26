
using DMZ.BL.Classes;
using System.Drawing;
using System.Windows.Forms;

namespace DMZ.UI.Generic
{
    public class DMZToolTip: ToolTip
    {
        public DMZToolTip()
        {
            OwnerDraw = true;
            Draw += DMZToolTip_Draw;
            BackColor = Color.DarkCyan;
            ForeColor = Color.White;
            ToolTipTitle = Pbl.Info2;
            ToolTipIcon = ToolTipIcon.Info;
            //IsBalloon = true;

        }

        private void DMZToolTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();          
            e.Graphics.DrawLine(Pens.White,0,e.Bounds.Height-4,e.Bounds.Width, e.Bounds.Height - 4);
        }
    }
}
