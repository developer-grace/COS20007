using System;
using SplashKitSDK;
namespace ShapeDrawer
{
    public class MyLine : Shape // MyLine inherits attributes from Shape class
    {
        private float _endX, _endY;
        public MyLine(Color clr, float startX, float startY, float endX, float endY) : base (clr)
        {
            X = startX; Y = startY; EndX = endX; EndY = endY;
        }

        public MyLine() : this(Color.Black, 20, 20, 200, 200)
        {

        }

        public override void Draw()
        {
            if (Selected)
                DrawOutline();
            SplashKit.DrawLine(Color, X, Y, EndX, EndY);
        }

        public override void DrawOutline()
        {
            throw new NotImplementedException();
        }

        public override bool IsAt(Point2D pt)
        {
            SplashKit.PointOnLine(pt, );

        }

        public float EndX
        {
            get { return _endX; }
            set { _endX = value; }
        }

        public float EndY
        {
            get { return _endY; }
            set { _endY = value; }
        }
    }
}
