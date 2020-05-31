using System;
using System.Collections.Generic;
using System.Drawing;

namespace MiniPaintWektorowo
{
    
    public abstract class FiguraWypelniona : Figura
    {
        protected Color kolorWypelnienia;
        public FiguraWypelniona(Color kolorLinii, Int32 gruboscLinii, Point polozenie, Color kolorWypelnienia)
            : base(kolorLinii, gruboscLinii, polozenie)
        {
            this.kolorWypelnienia = kolorWypelnienia;
        }
    }
}