﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPaintWektorowo
{
    public class Wiadro : FiguraWypelniona
    {
        private Point p;
        public Wiadro(Color kolorLinii, Int32 gruboscLinii, Color kolorWypelnienia, Point p1, Point p2)
           : base(kolorLinii, gruboscLinii, p1, kolorWypelnienia)
        {
            this.p = p2;
        }
        public override void Rysuj(Graphics g)
        {
            throw new NotImplementedException();
        }
    }
}
