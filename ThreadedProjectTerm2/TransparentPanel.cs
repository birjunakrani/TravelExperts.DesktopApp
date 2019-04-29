using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadedProjectTerm2
{
    class TransparentPanel : Panel
    {
        /**
        * Threaded project 2 - Team 1
        * Purpose: Transparent panel object used for scrolling image in in frmHome
        * Made by: Brent Ward
        * Date: Marth 30th 2019
        * **/
        public TransparentPanel()
        {
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x00000020;
                return cp;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(150, 50, 50, 50)), this.ClientRectangle);
        }
    }
}
