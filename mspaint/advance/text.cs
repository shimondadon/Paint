using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace mspaint.advance
{
    [Serializable]
    internal class text : shape
    {
        private readonly Font _font;
        private readonly string _str;
        internal Point _point;
        private readonly int _len;
        private readonly int _y;

        internal override bool selector(Point p)
        {
            if (p.X < _point.X - 3)
            {
                return false;
            }
            if (p.Y < _point.Y - 3)
            {
                return false;
            }

            if (p.X > _len)
            {
                return false;
            }
            if (p.Y > _y)
            {
                return false;
            }

            return true;
        }

        internal text(Font f,string str , float width, Color color, Point point)
            : base(width, color, point)
        {
            _point = point;
            _font = f;
            _str = str;
            _len = point.X + str.Length * (int)_font.Size - 3;
            _y = _point.Y + _font.Height;
        }

        internal override void Draw(Graphics g)
        {
            g.DrawString(_str,_font,_pen.Brush,_point);
        }

        internal override void Update(Graphics g, Point p)
        {
            Draw(g);
        }

        internal override void Move(Point delta)
        {
            _point.X += delta.X;
            _point.Y += delta.Y;
        }
    }
}
