using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace mspaint.advance
{
    [Serializable]
    internal class figure : shape
    {
        internal enum types { Ellipse, Rectangle };

        private readonly types _type;
        private readonly bool _isFill;
        private int _x;
        private int _y;
        private int _width;
        private int _height;

        internal figure(types type, bool isFill, float width, Color color, Point point) :
            base(width, color, point)
        {
            _type = type;
            _x = point.X;
            _y = point.Y;
            _isFill = isFill;
        }

        internal override void Draw(Graphics g)
        {
            switch (_type)
            {
                case types.Rectangle:
                    if (_isFill == true)
                    {
                        g.FillRectangle(_pen.Brush, _x, _y, _width, _height);
                    }
                    else
                    {
                        g.DrawRectangle(_pen, _x, _y, _width, _height);
                    }
                    break;
                case types.Ellipse:
                    if (_isFill == true)
                    {
                        g.FillEllipse(_pen.Brush, _x, _y, _width, _height);
                    }
                    else
                    {
                        g.DrawEllipse(_pen, _x, _y, _width, _height);
                    }
                    break;
                default:
                    break;
            }
        }

        internal override void Update(Graphics g, Point p)
        {
            _width = p.X - _x;
            _height = p.Y - _y;

            if (_width < 0)
            {
                _width *= -1;
                _x = p.X;
            }
            if (p.Y < _y)
            {
                _height *= -1;
                _y = p.Y;
            }
            Draw(g);
        }

        internal override bool selector(Point p)
        {
            if (p.X < _x)
            {
                return false;
            }
            if (p.Y < _y)
            {
                return false;
            }

            if (p.X > _x + _width)
            {
                return false;
            }
            if (p.Y > _y + _height)
            {
                return false;
            }

            return true;
        }

        internal override void Move(Point delta)
        {
            _x += delta.X;
            _y += delta.Y;
        }
    }
}
