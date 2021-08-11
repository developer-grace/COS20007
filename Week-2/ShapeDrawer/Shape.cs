using System;
using SplashKitSDK;
namespace ShapeDrawer
{
    public class Shape
    {
        private float _x, _y;
        private int _width, _height;
        private Color _color;

        public Shape()
        {
            _color = Color.Green;
            _x = 0; _y = 0;
            _width = 100; _height = 100;
        }

        public Color Color
        {
            get
            {
                return _color;
            }
            set
            {
               _color = value;
            }

        }

        public float X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }

        public float Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }

        public int Width
        {
            get
            {
                return _width;
            }
            set {
                _width = value; /* value is an int datatype keyword, ask about the keyword here for a float; do we need a cast? */
            }
        }

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }

        public void Draw()
        {
            SplashKit.FillRectangle(_color, _x, _y, _width, _height);
        }
        public bool IsAt(Point2D pt)
        {
            if ((_x > 0) && (_y > 0))
            {
                return true;
            }
            //if ((_x < 100) && (_y < 100))
            //{
            //    return true;
            //}
            else
            {
                return false;
            }
        }

    }
}