using System.Drawing;

namespace MiniPaint
{
    public class ImageUnscaled : Shape
    {
        Image image;
        public ImageUnscaled(Color lineColor, int lineThick, Point position, Image image) : base(lineColor, lineThick, position)
        {
            this.image = image;
        }

        public override void Draw(Graphics g)
        {
            g.DrawImageUnscaled(image, position);
        }
    }
}
