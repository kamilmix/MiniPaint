using System;
using System.Drawing;

namespace MiniPaint
{
    public class FillTool : ShapeFilled
    {
        private Point p;
        public FillTool(Color lineColor, Int32 lineThick, Color fillColor, Point p1, Point p2)
           : base(lineColor, lineThick, p1, fillColor)
        {
            this.p = p2;
        }
        public override void Draw(Graphics g)
        {
            throw new NotImplementedException();
        }
    }
}
