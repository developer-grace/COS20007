using System;
using SplashKitSDK;
namespace ShapeDrawer
{
    public class MyRectangle : Shape // MyRectangle inherits attributes from Shape class
    {
        private int _width, _height;
        public MyRectangle(Color clr, float x, float y, int width, int height) : base (clr)
        {
            X = x; Y = y;
            _width = 100; _height = 100;
        }

        public MyRectangle() : this(Color.Green, 0, 0, 100, 100)
        {

        }

        public override void Draw()
        {
            if (Selected)
                DrawOutline();
            SplashKit.FillRectangle(Color, X, Y, _width, _height);
        }

        public override void DrawOutline()
        {
            SplashKit.DrawRectangle(Color.Black, X - 2, Y - 2, 4 + _width, 4 + _height);
        }

        public override bool IsAt(Point2D pt)
        {
            if (pt.X > X && pt.X < X + _width) // using X property instead of _x private field
            {
                if (pt.Y > Y && pt.Y < Y + _height)
                {
                    return true;
                }
            }
            return false;
        }

        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
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
    }

}