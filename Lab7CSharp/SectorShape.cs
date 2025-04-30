using System.Drawing;
using System.Drawing.Drawing2D;

public class SectorShape : Shape
{
    public float StartAngle { get; set; } = 0f;
    public float SweepAngle { get; set; } = 90f;

    public SectorShape(Point position, Size size, Color color) : base(position, size, color) { }

    public override void Draw(Graphics g)
    {
        using (SolidBrush brush = new SolidBrush(Color))
        using (GraphicsPath path = new GraphicsPath())
        {
            Rectangle rect = new Rectangle(Position, Size);
            path.AddPie(rect, StartAngle, SweepAngle);
            g.FillPath(brush, path);
        }
    }
}
