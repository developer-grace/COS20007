using System;
using SplashKitSDK;
using System.Collections.Generic;

namespace ShapeDrawer
{
    public class Drawing
    {
        private readonly List<Shape> _shapes;
        private Color color;
        private Color _background;

        public Drawing(Color background)
        {
            _shapes = new List<Shape>();
        }

        public Drawing() : this(Color.White)
        {
            // Accessing first Shape Object in generic List
            _shapes[0].X = SplashKit.MouseX();
            _shapes[0].Y = SplashKit.MouseY();
        }

        public void Draw()
        {
            SplashKit.ClearScreen();
            foreach(Shape shape in _shapes)
            {
                shape.Draw();
            }

        }

        public Color Background
        {
            get
            {
                return _background;
            }
            set
            {
                _background = value;
            }
        }

        public int ShapeCount
        {
            get { return _shapes.Count; }
        }

        public void AddShape(Shape shape)
        {
            _shapes.Add(shape);
        }

    }
}
