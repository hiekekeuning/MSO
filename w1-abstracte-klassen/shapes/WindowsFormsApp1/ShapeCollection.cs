using System;
using System.Collections.Generic;
using System.Drawing;

public class ShapeCollection
{
    private List<Shape> contents;
    private int curIndex; // index for current shape

    public ShapeCollection()
        // each new shape collection is initiated with a test collection
    {
        contents = new List<Shape>();
        InitTestCollection();
        curIndex = 0;
    }

    public Shape CurrentShape()
    { return contents[curIndex]; }

    public void Next()
    { if (curIndex < contents.Count - 1) curIndex++; }

    public void Previous()
    { if (curIndex > 0) curIndex--; }

    private void InitTestCollection()
    {
        // add some example shapes
        contents.Add(new Rectangle(200, 120, Color.Blue));
        contents.Add(new Triangle(60, 200, Color.Orange));
        contents.Add(new Circle(100, Color.Red));
        contents.Add(new Triangle(250, 100, Color.Green));
        contents.Add(new Rectangle(120, 200, Color.Black));
    }
}