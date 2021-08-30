using System;
using SplashKitSDK;
namespace ShapeDrawer
{
    public class MyLine : Shape 
    {
        private int _length;
        public MyLine(Color clr) : base (clr)
        {
            _length = 150;
        }

        public MyLine() : this(Color.Black)
        {

        }

        public override void Draw()
        {
            if (Selected)
                DrawOutline();
            
        }

        public override void DrawOutline()
        {
            throw new NotImplementedException();
        }

        public override bool IsAt(Point2D pt)
        {
            throw new NotImplementedException();
        }

        public int Length
        {
            get { return _length; }
            set { _length = value; }
        }
    }
}
