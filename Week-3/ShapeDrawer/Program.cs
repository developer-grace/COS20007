using System;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class Program
    {
        public static void Main()
        {
            new Window("Shape Drawer", 800, 600);

            // local variables
            Drawing myDrawing;
            myDrawing = new Drawing();

            do // Event loop
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();

                if (SplashKit.MouseClicked(MouseButton.LeftButton) )
                {
                    // initialising local variable new_shape for Shape Object
                    Shape new_shape;
                    new_shape = new Shape();
                    new_shape.X = SplashKit.MouseX();
                    new_shape.Y = SplashKit.MouseY();

                    // add new Shape Object to the Drawing List Object
                    
                    myDrawing.AddShape(new_shape);
                    
                }

                if (SplashKit.MouseClicked(MouseButton.RightButton))
                {
                    // When the right mouse button is clicked on the position of a shape,
                    // the shape is selected
                    Point2D pt;
                    pt = SplashKit.MousePosition();
                    myDrawing.SelectShapesAt(pt);
                }

                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    Shape new_shape;
                    new_shape = new Shape();
                    new_shape.X = SplashKit.MouseX();
                    new_shape.Y = SplashKit.MouseY();

                    // initialising local variable mousePosition for a Point2D datatype
                    Point2D mousePosition = SplashKit.MousePosition();
                    if (new_shape.IsAt(mousePosition))
                    {
                        myDrawing.Background = SplashKit.RandomRGBColor(255);
                    }
                }

                //if (SplashKit.KeyTyped(KeyCode.BackspaceKey))
                //{
                //    // remove selected shapes (use SelectedShapes method)
                //    myDrawing.DeleteShape(myDrawing.SelectedShapes);
                //}


                myDrawing.Draw();

                SplashKit.RefreshScreen();
            } while (!SplashKit.WindowCloseRequested("Shape Drawer"));
        }
    }
}