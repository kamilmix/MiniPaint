﻿using System;
using System.Drawing;

namespace MiniPaint
{
    public class Elipse : ShapeFilled
    {
        private Point p;

        public Elipse(Color lineColor, Int32 lineThick, Color fillColor, Point p1, Point p2)
            : base(lineColor, lineThick, p1, fillColor)
        {
            this.p = p2;
        }
        public override void Draw(Graphics g)
        {
            g.FillEllipse(new SolidBrush(fillColor), Math.Min(position.X, p.X),
                                                            Math.Min(position.Y, p.Y),
                                                            Math.Abs(position.X - p.X),
                                                            Math.Abs(position.Y - p.Y));
            g.DrawEllipse(new Pen(lineColor,lineThick), Math.Min(position.X, p.X),
                                                            Math.Min(position.Y, p.Y),
                                                            Math.Abs(position.X-p.X),
                                                            Math.Abs(position.Y-p.Y));
        }
    }
}