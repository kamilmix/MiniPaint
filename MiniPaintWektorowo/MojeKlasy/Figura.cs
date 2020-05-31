using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace MiniPaintWektorowo
{
        public abstract class Figura
        {
            protected Color kolorLinii;
            protected Int32 gruboscLinii;
            protected Point polozenie;
            public Figura(Color kolorLinii, Int32 gruboscLinii, Point polozenie)
            {
                this.kolorLinii = kolorLinii;
                this.gruboscLinii = gruboscLinii;
                this.polozenie = polozenie;
            }
            public abstract void Rysuj(Graphics g);
    }
}