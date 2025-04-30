using System.Drawing;

public class ArcShape : Shape
{
    public float StartAngle { get; set; } = 0f;
    public float SweepAngle { get; set; } = 180f;

    public ArcShape(Point position, Size size, Color color) : base(position, size, color) { }

    public override void Draw(Graphics g)
    {
        using (Pen pen = new Pen(Color, 2))
        {
            g.DrawArc(pen, new Rectangle(Position, Size), StartAngle, SweepAngle);
        }
    }
}
