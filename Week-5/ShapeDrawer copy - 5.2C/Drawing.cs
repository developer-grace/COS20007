using System;
using SplashKitSDK;
using System.Collections.Generic;
using System.IO;

namespace ShapeDrawer
{
    public class Drawing
    {
        private readonly List<Shape> _shapes;
        private Color _background;
        private StreamWriter _writer;
        private Shape _s;
        private StreamReader _reader;
        private int _count;
        private string _kind;

        public Drawing(Color background)
        {
            _shapes = new List<Shape>();
            _background = background;
        }

        public Drawing() : this(Color.White)
        {
        }

        public void Draw() 
        {
            SplashKit.ClearScreen();
            foreach(Shape shape in _shapes)
            {
                // Create a Shape Object, assign it to local variable shape
                shape.Draw();
            }

        }

        public void AddShape(Shape shape)
        {
            // Adding a Shape Object to generic List, which is Drawing
            _shapes.Add(shape);
        }

        public void DeleteShape(Shape s)
        {
            // Removing a Shape Object from the List, this should
            // delete the shape off of the display
            _shapes.Remove(s);
        }

        public void SelectShapesAt(Point2D select_pt)
        {
            foreach (Shape s in _shapes)
            {
                if (s.IsAt(select_pt))
                {
                    s.Selected = true;
                } else
                {
                    s.Selected = false;
                }
            }
        }

        public void ColorChange()
        {
            Point2D mousePosition = SplashKit.MousePosition();

            foreach ( Shape shape in _shapes )
            {
                if (shape.IsAt(mousePosition))
                {
                    shape.Color = SplashKit.RandomRGBColor(255);
                }
            }
        }

        public void Save(string filename)
        {
            _writer = new StreamWriter(filename);
            _writer.WriteColor(Background);
            _writer.WriteLine(ShapeCount);

            foreach (Shape s in _shapes)
            {
                s.SaveTo(_writer);
            }
            _writer.Close();
        }

        public void Load(string filename)
        {
            _reader = new StreamReader(filename);
            Background = _reader.ReadColor();
            _count = _reader.ReadInteger();
            _shapes.Clear();

            for (int i = 0; i < _count; i++)
            {
                _kind = _reader.ReadLine();

                Console.WriteLine(_kind);

                if (_kind == "Rectangle")
                {
                    _s = new MyRectangle();
                }
                else if (_kind == "Circle")
                {
                    _s = new MyCircle();
                }
                else continue;

                _s.LoadFrom(_reader);
                AddShape(_s);
            }
            _reader.Close();
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

        public List<Shape> SelectedShapes
        {
            get
            {
                List<Shape> result;
                result = new List<Shape>();
                foreach (Shape s in _shapes)
                {
                    if (s.Selected == true)
                    {
                        result.Add(s);
                    }
                }
                return result;
            }
        }

        
    }
}
