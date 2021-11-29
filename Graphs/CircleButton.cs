using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphs
{
    public class CircleButton
    {
        public float x;
        public float y;
        public int code;
        public Pen pen;
        public TextBox num;
        public CircleButton(int _code, float _x, float _y, Pen _pen, int size) {
            x = _x;
            y = _y;
            code = _code;
            pen = _pen;
            num = new TextBox();
            num.Text = (_code).ToString();
            num.Width = 20;
            num.Location = new Point((int)_x + size / 3, (int)_y + size / 3);
        }
    }
}
