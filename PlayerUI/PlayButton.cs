using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI
{
    class PlayButton : Button
    {

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath grPath = new GraphicsPath();

            grPath.AddEllipse(0, 0, ClientSize.Width-1, ClientSize.Height-1);

            Region = new Region(grPath);

            base.OnPaint(e);
        }
    }
}
