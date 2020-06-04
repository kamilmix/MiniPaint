using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace MiniPaint
{
    public class Drawing
    {
        private int height;
        private int width;
        private List<Shape> shapes;
        private List<Shape> shapesDeleted;
        private Color backgroundColor;
        private Image imageFile = null;

        public Drawing(int width, int height, Color backgroundColor)
        {
            this.width = width;
            this.height = height;
            this.backgroundColor = backgroundColor;
            
            shapes = new List<Shape>();
            shapesDeleted = new List<Shape>();
        }
        public Drawing(Image imageFile)
        {
            this.width = imageFile.Width;
            this.height = imageFile.Height;
            this.imageFile = imageFile;
            
            shapes = new List<Shape>();
            shapesDeleted = new List<Shape>();
        }

        public void Draw(Graphics g)
        {
            if (g != null)
            {
                g.Clear(backgroundColor);

                if (imageFile != null)
                {
                    g.DrawImage(imageFile, new Point(0, 0));
                }

                foreach (Shape f in shapes)
                {
                    f.Draw(g);
                }
            }
        }

        public void Add(Shape f)
        {
            shapes.Add(f);
        }

        public void Undo(Graphics g)
        {
            if (shapes.Any())
            {
                shapesDeleted.Add(shapes.Last());
                shapes.RemoveAt(shapes.Count - 1);
            }
            Draw(g);
        }

        public void Redo(Graphics g)
        {
            if (shapesDeleted.Any())
            {
                shapes.Add(shapesDeleted.Last());
                shapesDeleted.RemoveAt(shapesDeleted.Count - 1);
            }
            Draw(g);
        }
    }
}
