using System.Drawing;

namespace MiniPaint
{
    public class Text : ShapeUnfilled
    {
        private string text;
        private Font font;
        public Text(Color lineColor, int lineThick, Point position, string text, Font font) : base(lineColor, lineThick, position)
        {
            this.text = text;
            this.font = font;
        }

        public override void Draw(Graphics g)
        {
            SolidBrush drawBrush = new SolidBrush(lineColor);
            StringFormat drawFormat = new StringFormat();
            g.DrawString(text, font, drawBrush, position.X, position.Y, drawFormat);
            drawBrush.Dispose();
        }
    }
}
