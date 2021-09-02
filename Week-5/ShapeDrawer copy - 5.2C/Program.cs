using System;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class Program
    {
        // Program uses ShapeKind to determine the type of shape user wants to add to Drawing
        private enum ShapeKind
        {
            Rectangle,
            Circle,
            Line
        }
        public static void Main()
        {
            new Window("Shape Drawer", 800, 600);

            // local variables
            Drawing myDrawing;
            myDrawing = new Drawing();
            ShapeKind kindToAdd;
            kindToAdd = ShapeKind.Circle;

            do // Event loop
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();

                if (SplashKit.KeyTyped(KeyCode.RKey))
                { kindToAdd = ShapeKind.Rectangle; }

                if (SplashKit.KeyTyped(KeyCode.CKey))
                { kindToAdd = ShapeKind.Circle; }

                if (SplashKit.KeyTyped(KeyCode.LKey))
                { kindToAdd = ShapeKind.Line; }

                if (SplashKit.MouseClicked(MouseButton.LeftButton) )
                {
                    Shape new_shape;
                    if (kindToAdd == ShapeKind.Circle)
                    {
                        MyCircle newCircle = new MyCircle();
                        new_shape = newCircle;
                    }
                    else if (kindToAdd == ShapeKind.Rectangle)
                    {
                        MyRectangle newRect = new MyRectangle();
                        new_shape = newRect;
                    }
                    else
                    {
                        MyLine newLine = new MyLine();
                        new_shape = newLine;
                    }

                    new_shape.X = SplashKit.MouseX();
                    new_shape.Y = SplashKit.MouseY();
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

                /*
                 * Pressing space bar should change the color of the
                 * shape underneath the cursor.
                 */
                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    myDrawing.ColorChange();
                }

                if (SplashKit.KeyTyped(KeyCode.BackspaceKey))
                {
                    // remove selected shapes (use SelectedShapes method)
                    foreach (Shape s in myDrawing.SelectedShapes)
                    {
                        myDrawing.DeleteShape(s);
                    }
                }


                myDrawing.Draw();
                SplashKit.RefreshScreen();
            } while (!SplashKit.WindowCloseRequested("Shape Drawer"));
        }
    }
}