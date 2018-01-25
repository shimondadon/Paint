using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace mspaint.advance
{
    [Serializable]
    internal class line : shape
    {
        private Point _p1;
        private Point _p2;

        private int _upperX;
        private int _bottomX;
        private int _upperY;
        private int _bottomY;

        internal line(float width, Color color, Point p)
            : base(width, color, p)
        {
            _upperY = p.Y;
            _upperX = p.X;
            _bottomY = p.Y;
            _bottomX = p.X;
            _p1 = p;
        }

        internal override void Draw(Graphics g)
        {
            g.DrawLine(_pen, _p1, _p2);
        }

        internal override void Update(Graphics g, Point p)
        {
            _p2 = p;

            if (p.X < _bottomX)
            {
                _bottomX = p.X;
            }
            if (p.X > _upperX)
            {
                _upperX = p.X;
            }
            if (p.Y < _bottomY)
            {
                _bottomY = p.Y;
            }
            if (p.Y > _upperY)
            {
                _upperY = p.Y;
            }

            Draw(g);
        }

        internal override bool selector(Point p)
        {
            float m = (float)(_p2.Y - _p1.Y) / (_p2.X - _p1.X);
            float b = _p1.Y - m * _p1.X;

            if (p.Y < (m * p.X + b) - 4)
            {
                return false;
            }

            //if (p.Y > (m * p.X + b) + 4)
            //{
            //    return false;
            //}

            if (p.X < _bottomX - 4 || p.X > _upperX + 4)
            {
                return false;
            }
            if (p.Y < _bottomY - 4 || p.Y > _upperY + 4)
            {
                return false;
            }
            return true;
        }

        internal override void Move(Point delta)
        {
            _p1.X += delta.X;
            _p1.Y += delta.Y;
            _p2.X += delta.X;
            _p2.Y += delta.Y;
        }
    }
}

//internal line(float width, Brush brush, Point p)
//            : base(width, brush, p) 
//        {
//            this._p1 = p;
//        }