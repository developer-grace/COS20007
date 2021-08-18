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
            // If Shape Objects were put in a list, how to access the Objects in the list and therefore the X and Y properties?

            // Using SplashKit.MouseX() and SplashKit.MouseY() to change the location of thisShape, then this function in main

            // How to access Shapes.cs from here?

            // TODO:
            

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
