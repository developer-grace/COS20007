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

            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();

                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    myShape.X = SplashKit.MouseX();
                    myShape.Y = SplashKit.MouseY();
                }

                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    Point2D mousePosition = SplashKit.MousePosition();
                    if (myShape.IsAt(mousePosition))
                    {
                        myShape.Color = SplashKit.RandomRGBColor(255);
                    }
                }

                myShape.Draw();

                SplashKit.RefreshScreen();
            } while (!SplashKit.WindowCloseRequested("Shape Drawer"));
        }
    }
}