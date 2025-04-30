using System.Drawing;
using System.Drawing.Drawing2D;

public class RoundedRectangleShape : Shape
{
    public RoundedRectangleShape(Point position, Size size, Color color) : base(position, size, color) { }

    public override void Draw(Graphics g)
    {
        using (Pen pen = new Pen(Color))
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 20;
            Rectangle rect = new Rectangle(Position, Size);
            path.AddArc(rect.Left, rect.Top, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Top, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.Left, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();
            g.DrawPath(pen, path);
        }
    }
}
