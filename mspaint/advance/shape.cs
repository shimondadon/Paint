using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace mspaint.advance
{
    [Serializable]
    internal abstract class shape
    {
        internal shape(float width, Color color, Point point)
        {
            _color = color;
            _width = width;
            //_pen = new Pen(color, _width);
        }

        internal float Width
        {
            get
            {
                return _pen.Width;
            }
            set
            {
                _pen.Width = value;
            }
        }

        internal Color _Color
        {
            get
            {
                return _pen.Color;
            }
            set
            {
                _color = value;
                _pen.Brush = new SolidBrush(value);
            }
        }

        protected Brush _brush { get { return new SolidBrush(_color); } }
        protected Pen _pen { get { return new Pen(_color, _width); } }

        private Color _color;
        private float _width;

        internal abstract void Draw(Graphics g);
        internal abstract void Update(Graphics g, Point p);
        internal abstract bool selector(Point p);
        internal abstract void Move(Point delta);
    }
}

//internal shape (float width, Brush brush, Point p)
//{
//    _width = width;
//    _brush = brush;
//}
