using System;
using System.Drawing;

namespace MiniPaintWektorowo
{
    public class Linia : FiguraNiewypelniona
    {
        private Point p;

        public Linia(Color kolorLinii, Int32 gruboscLinii, Point p1, Point p2)
            : base(kolorLinii, gruboscLinii, p1)
        {
            this.p = p2;
        }
        public override void Rysuj(Graphics g)
        {
            g.DrawLine(new Pen(kolorLinii,gruboscLinii), polozenie, p);
        }
    }
}