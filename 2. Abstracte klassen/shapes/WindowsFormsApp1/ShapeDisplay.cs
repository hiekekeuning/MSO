using System;
using System.Drawing;
using System.Windows.Forms;

public class ShapeDisplay : Form
{
    // define size and offset for window
    public int Xsize { get { return 400; } }
    public int Ysize { get { return 400; } }
    public int Xoffset { get { return 20; } }
    public int Yoffset { get { return 20; } }

    private ShapeCollection shapes;

    public ShapeDisplay(ShapeCollection sc)
    {
        this.shapes = sc;

        // basic properties
        this.ClientSize = new Size(Xsize, Ysize);
        this.Text = "Shape Display";
        this.BackColor = Color.White;

        // button Next
        Button next = new Button();
        next.Size = new Size(60, 20);
        next.Location = new Point(Xsize - Xoffset - 60, Yoffset);
        next.Text = "Next";
        next.Click += this.clickNext; // smells like Observer pattern
        this.Controls.Add(next);

        // button Previous
        Button prev = new Button();
        prev.Size = new Size(60, 20);
        prev.Location = new Point(Xsize - Xoffset - 60, Yoffset + 40);
        prev.Text = "Previous";
        prev.Click += this.clickPrev; // smells like Observer pattern
        this.Controls.Add(prev);

        this.Paint += this.drawMyScreen; // smells like Observer pattern
    }

    private void clickPrev(object sender, EventArgs ea)
    {
        shapes.Previous();
        this.Invalidate(); // enforce redraw after click
    }

    private void clickNext(object sender, EventArgs ea)
    {
        shapes.Next();
        this.Invalidate(); // enforce redraw after click
    }

    private void drawMyScreen(object sender, PaintEventArgs pea)
    {
        Graphics gr = pea.Graphics;

        Shape shape = shapes.CurrentShape();
        shape.Draw(this, gr);  // reference 1 to abstract class Shape

        // also give the description and the area of this shape

        gr.DrawString(
            "Area = " + shape.Area().ToString(), // reference 2 to abstract class Shape
            MyConfig.MyFont, Brushes.Black, Xoffset, Ysize - Yoffset - 60
        );

        gr.DrawString(
            shape.Description, // reference 3 to abstract class Shape
            MyConfig.MyFont, Brushes.Black, Xoffset, Ysize - Yoffset - 20
        );


        // no references to any concrete subclass of Shape
    }
}
