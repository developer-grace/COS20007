using System;
using SplashKitSDK;
namespace ShapeDrawer
{
    public class MyCircle : Shape // MyCircle inherits attributes from Shape class
    {
        private int _radius;
        public MyCircle(Color clr, int radius) : base (clr)
        {
            _radius = 50;
        }
        public MyCircle() : this(Color.Blue, 50)
        {

        }

        public override void Draw()
        {
            if (Selected)
                DrawOutline();
            SplashKit.FillCircle(Color, X, Y, _radius);
        }

        public override void DrawOutline()
        {
            SplashKit.DrawCircle(Color.Black, X, Y, _radius + 2);
        }

        public override bool IsAt(Point2D pt)
        {
            return SplashKit.PointInCircle(pt, SplashKit.CircleAt(X, Y, _radius));
        }

        public int Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }
    }
}
