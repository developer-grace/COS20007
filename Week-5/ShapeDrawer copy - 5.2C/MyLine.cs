using System;
using SplashKitSDK;
using System.IO;

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
            SplashKit.DrawCircle(Color.Black, X, Y, 2);
            SplashKit.DrawCircle(Color.Black, _endX, _endY, 2);
        }

        public override bool IsAt(Point2D pt)
        {
            return SplashKit.PointOnLine(pt, SplashKit.LineFrom(X, Y, _endX, _endY));
            // The LineFrom method returns a Circle type, which makes it a suitable parameter to be passed in to PointOnLine method - which wants a Point2D and Circle parameter
        }

        public override void SaveTo(StreamWriter writer)
        {
            writer.WriteLine("Line");
            base.SaveTo(writer);
            writer.WriteLine(X);
            writer.WriteLine(Y);
            writer.WriteLine(EndX);
            writer.WriteLine(EndY);
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
