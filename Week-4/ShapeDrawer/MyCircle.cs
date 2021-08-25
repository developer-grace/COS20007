using System;
using SplashKitSDK;
namespace ShapeDrawer
{
    public class MyCircle : Shape // MyCircle inherits attributes from Shape class
    {
        private int _radius;

        public MyCircle()
        {
            _radius = 50;
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

        public int Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }
    }
}
