using System;
using System.Collections.Generic;
using System.Drawing;

namespace MiniPaint
{
    public class Curve : ShapeUnfilled
    {
        private List<Point> pp;

        public Curve(Color lineColor, Int32 lineThick, List<Point> pp)
            : base(lineColor, lineThick, pp[0])
        {
            this.pp = new List<Point>(pp);
            this.pp.RemoveAt(0);
        }
        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(lineColor, lineThick)
            {
                StartCap = System.Drawing.Drawing2D.LineCap.Round,
                EndCap = System.Drawing.Drawing2D.LineCap.Round
            };
            g.DrawLine(pen, position, pp[0]);
            for (int i=0; i<pp.Count-1; i++)
            {
                g.DrawLine(pen, pp[i], pp[i+1]);
            }
        }
    }
}