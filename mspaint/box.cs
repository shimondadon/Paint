using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace mspaint
{
    internal class box : shape
    {
        private string name = "box";
        private Point _p1;
        private Point _p2;
        private Point _p3;
        private Point _p4;

        internal box(float width, Brush brush, Point p)
            : base (width, brush, p) 
        {
            _p1 = p;
        }

        internal override void Draw(Graphics g)
        {
            //Pen pen = new Pen(_brush, _width);
            //Pen p = getPen();
            //int width = _p2.X - _p1.X;
            //int hieght = _p2.Y - _p1.Y;
            //Size s = new Size(width, hieght);
            //Rectangle rec = new Rectangle(_p1, s);
            //g.DrawRectangle(pen, rec);
            g.DrawLine(_pen, _p1, _p2);
            g.DrawLine(_pen, _p2, _p3);
            g.DrawLine(_pen, _p3, _p4);
            g.DrawLine(_pen, _p4, _p1);
        }

        internal override void Update(Point endP)
        {
            _p2 = new Point(endP.X,endP.Y);
            _p2 = new Point(endP.X, _p1.Y);
            _p3 = new Point(endP.X, endP.Y);
            _p4 = new Point(_p1.X, endP.Y);
        }
    }
}

//internal box(float width, Brush brush, Point p)
//    : base (width, brush, p) 
//{
//    _p1 = p;
//}