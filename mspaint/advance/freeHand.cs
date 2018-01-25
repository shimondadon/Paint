using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Collections;

namespace mspaint.advance
{
    [Serializable]
    internal class freeHand : shape
    {
        private readonly ArrayList _points = new ArrayList();
        private Point _delta = new Point();

        internal freeHand(float width, Color color, Point p)
            : base(width, color, p) 
        {
            _points.Add(p);
        }

        internal override bool selector(Point CurrentP)
        {
            bool b = false;
            foreach (Point p in _points)
            {
                if (CurrentP.X > p.X + 4 + _delta.X || CurrentP.X < p.X - 4 + _delta.X)
                {
                    continue;
                }
                else if (CurrentP.Y > p.Y + 4 + _delta.Y || CurrentP.Y < p.Y - 4 + _delta.Y)
                {
                    continue;
                }
                b = true;
            }
            return b;
        }

        internal override void Draw(Graphics g)
        {
            for (int i = 0; i < _points.Count - 1; i++)
            {
                Point p1 = (Point)_points[i];
                Point p2 = (Point)_points[i + 1];

                p1.X += _delta.X;
                p1.Y += _delta.Y;
                p2.X += _delta.X;
                p2.Y += _delta.Y;

                g.DrawLine(_pen, p1, p2);
            }
        }

        internal override void Update(Graphics g, Point p)
        {
            _points.Add(p);
            Draw(g);
        }

        internal override void Move(Point delta)
        {
            _delta.X += delta.X;
            _delta.Y += delta.Y;
        }
    }
}

        //internal freeHand(float width, Brush brush, Point p)
        //    : base(width, brush, p) 
        //{
        //    this._points.Add(p);
        //}
