using System;
using System.Collections.Generic;
using System.Drawing;

namespace MiniPaintWektorowo
{
    
    public abstract class FiguraNiewypelniona : Figura
    {
        public FiguraNiewypelniona(Color kolorLinii, Int32 gruboscLinii, Point polozenie)
            : base(kolorLinii, gruboscLinii, polozenie)
        {
        }
    }
}