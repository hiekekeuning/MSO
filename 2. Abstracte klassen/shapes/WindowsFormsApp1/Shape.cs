using System;
using System.Drawing;
// although C# provides you with a Rectangle class, 
// we define our own and use method DrawLine only

public abstract class Shape
{
    public String Description { get; set; }
    protected Color edgeColor;
    protected Pen pen;

    public abstract double Area();

    public virtual void Draw(ShapeDisplay sd, Graphics gr)
    {
        // we define a uniform pen for all shapes
        pen = new Pen(this.edgeColor, 3);
    }
}

class Rectangle : Shape
{
    protected int Width { get; }
    protected int Height { get; }

    public Rectangle(int w, int h, Color c)
    {
        this.Width = w;
        this.Height = h;
        this.edgeColor = c;
        this.Description = "Rectangle";
    }

    public override double Area()
    {
        return this.Width * this.Height;
    }

    public override void Draw(ShapeDisplay sd, Graphics gr)
    {
        base.Draw(sd, gr);

        // determine position for drawing
        int xStart = sd.Xoffset;
        int yStart = sd.Yoffset + Height;

        gr.DrawLine(pen, xStart, yStart, xStart, yStart - Height);
        gr.DrawLine(pen, xStart, yStart, xStart + Width, yStart);
        gr.DrawLine(pen, xStart, yStart - Height, xStart + Width, yStart - Height);
        gr.DrawLine(pen, xStart + Width, yStart, xStart + Width, yStart - Height);
    }
}

class Triangle : Shape
// we limit ourselves to equal sided triangles
{
    protected int Basis { get; }
    protected int Height { get; }

    public Triangle(int b, int h, Color c)
    {
        this.Basis = b;
        this.Height = h;
        this.edgeColor = c;
        this.Description = "Triangle";
    }

    public override double Area()
    {
        return 0.5d * this.Basis * this.Height;
    }

    public override void Draw(ShapeDisplay sd, Graphics gr)
    {
        base.Draw(sd, gr);

        int xStart = sd.Xoffset;
        int yStart = sd.Yoffset + Height;

        gr.DrawLine(pen, xStart, yStart, xStart + Basis, yStart);
        gr.DrawLine(pen, xStart, yStart, xStart + Basis / 2, yStart - Height);
        gr.DrawLine(pen, xStart + Basis, yStart, xStart + Basis / 2, yStart - Height);
    }
}

class Circle : Shape
{
    protected int Radius { get; }

    public Circle(int r, Color c)
    {
        this.Radius = r;
        this.edgeColor = c;
        this.Description = "Circle";
    }

    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }

    public override void Draw(ShapeDisplay sd, Graphics gr)
    {
        base.Draw(sd, gr);

        int xStart = sd.Xoffset;
        int yStart = sd.Yoffset;

        gr.DrawEllipse(pen, xStart, yStart, 2 * this.Radius, 2 * this.Radius);
        // uses bounding box 
    }
}