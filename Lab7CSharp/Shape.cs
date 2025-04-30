using System;
using System.Drawing;

public abstract class Shape
{
    public Point Position { get; set; }
    public Size Size { get; set; }
    public Color Color { get; set; }

    protected Shape(Point position, Size size, Color color)
    {
        Position = position;
        Size = size;
        Color = color;
    }

    public abstract void Draw(Graphics g); 

    public virtual void Move(Point newPosition)
    {
        Position = newPosition;
    }
}
