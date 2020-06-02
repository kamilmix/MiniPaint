using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPaintWektorowo
{
    public class Obraz : Figura
    {
        Image image;
        public Obraz(Color kolorLinii, int gruboscLinii, Point polozenie, Image image) : base(kolorLinii, gruboscLinii, polozenie)
        {
            this.image = image;
        }

        public override void Rysuj(Graphics g)
        {
            g.DrawImageUnscaled(image, polozenie);
        }
    }
}
