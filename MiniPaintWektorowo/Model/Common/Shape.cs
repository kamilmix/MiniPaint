using System;
using System.Drawing;

namespace MiniPaint
{
    public abstract class Shape
        {
            protected Color lineColor;
            protected Int32 lineThick;
            protected Point position;
            public Shape(Color lineColor, Int32 lineThick, Point position)
            {
                this.lineColor = lineColor;
                this.lineThick = lineThick;
                this.position = position;
            }
            public abstract void Draw(Graphics g);
    }
}