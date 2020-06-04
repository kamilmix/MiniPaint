using System;
using System.Drawing;

namespace MiniPaint
{
    public class Line : ShapeUnfilled
    {
        private Point p;

        public Line(Color lineColor, Int32 lineThick, Point p1, Point p2)
            : base(lineColor, lineThick, p1)
        {
            this.p = p2;
        }
        public override void Draw(Graphics g)
        {
            g.DrawLine(new Pen(lineColor,lineThick), position, p);
        }
    }
}