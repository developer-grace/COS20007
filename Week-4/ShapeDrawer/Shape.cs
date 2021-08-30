using System;
using SplashKitSDK;
namespace ShapeDrawer
{
    public class Shape
    {
        private float _x, _y;
        private Color _color;
        private bool _selected;

        public Shape(Color color)
        {
            _x = 0; _y = 0;
            _color = color;
        }

        public Shape() : this(Color.Yellow)
        {
        }

        public Color Color
        {
            get
            { return _color; }
            set
            { _color = value; }

        }

        public float X
        {
            get
            { return _x; }
            set
            { _x = value; }
        }

        public float Y
        {
            get
            { return _y; }
            set
            { _y = value; }
        }

        public bool Selected
        {
            get
            { return _selected; }
            set
            { _selected = value; }
        }

        public virtual void Draw() // this method is made virtual so child classes can override it
        {
        }

        public virtual bool IsAt(Point2D pt)
        {
            return false;
        }

        public virtual void DrawOutline()
        {
        }
    }
}