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

                    // add new Shape Object to the Drawing List Object
                    myDrawing.Draw();
                    myDrawing.AddShape(new_shape);
                }

                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    Point2D mousePosition = SplashKit.MousePosition();
                    if (myShape.IsAt(mousePosition))
                    {
                        myDrawing.Background = SplashKit.RandomRGBColor(255);
                    }
                }

                myShape.Draw();

                SplashKit.RefreshScreen();
            } while (!SplashKit.WindowCloseRequested("Shape Drawer"));
        }
    }
}