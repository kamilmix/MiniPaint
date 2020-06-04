using System;
using System.Drawing;

namespace MiniPaint
{
    public class SelectTool : ShapeUnfilled
    {
        Point p;
        public SelectTool(Color lineColor, int lineThick, Point p1, Point p2) : base(lineColor, lineThick, p1)
        {
            this.p = p2;
        }

        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(lineColor, 1);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            g.DrawRectangle(pen, Math.Min(position.X, p.X),
                                  Math.Min(position.Y, p.Y),
                                  Math.Abs(position.X - p.X),
                                  Math.Abs(position.Y - p.Y));
        }
    }
}
