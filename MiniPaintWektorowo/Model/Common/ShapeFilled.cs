using System;
using System.Drawing;

namespace MiniPaint
{
    public abstract class ShapeFilled : Shape
    {
        protected Color fillColor;
        public ShapeFilled(Color lineColor, Int32 lineThick, Point position, Color fillColor)
            : base(lineColor, lineThick, position)
        {
            this.fillColor = fillColor;
        }
    }
}