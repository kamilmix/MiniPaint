using System;
using System.Drawing;

namespace MiniPaint
{
    public abstract class ShapeUnfilled : Shape
    {
        public ShapeUnfilled(Color lineColor, Int32 lineThick, Point position)
            : base(lineColor, lineThick, position)
        {
        }
    }
}