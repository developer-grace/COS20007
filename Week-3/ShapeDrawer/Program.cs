using System;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class Program
    {
        public static void Main()
        {
            new Window("Shape Drawer", 800, 600);

            
            Drawing myDrawing;
            myDrawing = new Drawing();

            do // Event loop
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();

                if (SplashKit.MouseClicked(MouseButton.LeftButton) )
                {
                    // TODO: Check if the user has added a new Shape to your Drawing Object based on the mouse's location.

                    // What happens when left mouse button is clicked?
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