﻿using System;
using System.Drawing;

namespace MiniPaintWektorowo
{
    public class Prostokat : FiguraWypelniona
    {
        private Point p;

        public Prostokat(Color kolorLinii, Int32 gruboscLinii, Color kolorWypelnienia, Point p1, Point p2)
            : base(kolorLinii, gruboscLinii, p1, kolorWypelnienia)
        {
            this.p = p2;
        }
        public override void Rysuj(Graphics g)
        {
            g.FillRectangle(new SolidBrush(kolorWypelnienia), Math.Min(polozenie.X, p.X),
                                                              Math.Min(polozenie.Y, p.Y),
                                                              Math.Abs(polozenie.X - p.X),
                                                              Math.Abs(polozenie.Y - p.Y));
            g.DrawRectangle(new Pen(kolorLinii,gruboscLinii), Math.Min(polozenie.X, p.X),
                                                              Math.Min(polozenie.Y, p.Y),
                                                              Math.Abs(polozenie.X-p.X),
                                                              Math.Abs(polozenie.Y-p.Y));
        }
    }
}