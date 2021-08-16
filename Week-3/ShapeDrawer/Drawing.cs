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

    }
}
