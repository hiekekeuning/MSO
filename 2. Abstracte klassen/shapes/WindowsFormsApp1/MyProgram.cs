using System.Windows.Forms;
using System.Drawing;

static class MyProgram
{
    static void Main()
    {
        // we create a collection of shapes ...
        // .. and are going to scroll through it using a window

        ShapeCollection shapes = new ShapeCollection();
        // each new shape collection is initiated using a test collection

        ShapeDisplay shapeDisplay = new ShapeDisplay(shapes);
        Application.Run(shapeDisplay);
    }
}

static class MyConfig
{     
    // use a uniform font throughout the program
    public static readonly Font MyFont = new Font("Tahoma", 12);
}

