using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace StudyApp
{
     class RoundPictureBox: PictureBox
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(e);
        }
    }
}
