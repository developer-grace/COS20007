using System;
using SplashKitSDK;
using System.IO;
using System.Collections.Generic;

namespace ShapeDrawer
{
    // Shape is now an abstract class
    public abstract class Shape
    {
        private static Dictionary<string, Type> _ShapeClassRegistry = new Dictionary<string, Type>();

        public static void RegisterShape(string name, Type t)
        {
            _ShapeClassRegistry[name] = t;
        }

        public static Shape CreateShape(string name)
        {
            return (Shape)Activator.CreateInstance(_ShapeClassRegistry[name]);
        }


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



        // Draw is an abstract method - only children classes of Shape know how to implement it
        public abstract void Draw();
        
        public abstract bool IsAt(Point2D pt);

        public abstract void DrawOutline();

        // SaveTo is a virtual method which uses the System.IO namespace
        public virtual void SaveTo(StreamWriter writer)
        {
            writer.WriteColor(Color);
            writer.WriteLine(X);
            writer.WriteLine(Y);
        }

        public virtual void LoadFrom(StreamReader reader)
        {
            Color = reader.ReadColor();
            X = reader.ReadInteger();
            Y = reader.ReadInteger();
        }
    }
}