using System.Drawing;

public class EllipseShape : Shape
{
    public EllipseShape(Point position, Size size, Color color) : base(position, size, color) { }

    public override void Draw(Graphics g)
    {
        using (Pen pen = new Pen(Color))
        {
            g.DrawEllipse(pen, new Rectangle(Position, Size));
        }
    }
}
