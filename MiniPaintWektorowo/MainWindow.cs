using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MiniPaint
{
    public partial class MainWindow : Form
    {
        private string imageFileDirectory = null;
        private Graphics g;
        private Graphics gp;
        private List<Point> temporaryPoints = new List<Point>();
        private Drawing drawing;
        private Size baseSize;
        private Font font;
        public MainWindow()
        {
            InitializeComponent();
            pictureBoxFrame.Image = new Bitmap(pictureBoxFrame.Width, pictureBoxFrame.Height);
            pictureBoxPreview.Image = new Bitmap(pictureBoxPreview.Width, pictureBoxPreview.Height);
            baseSize = pictureBoxFrame.Size;
            pictureBoxPreview.BackColor = Color.White;
            g = Graphics.FromImage(pictureBoxFrame.Image);
            font = new Font("Arial", 16);

            drawing = new Drawing(pictureBoxFrame.Width, pictureBoxFrame.Height, Color.White);
            drawing.Draw(g);
            pictureBoxFrame.Refresh();

        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                temporaryPoints.Clear();
                temporaryPoints.Add(e.Location);

                if (radioButtonText.Checked)
                {
                    groupBoxText.Visible = true;
                    groupBoxShape.Enabled = false;
                    Shape figura = new Text(buttonLineColor.BackColor, (int)numericUpDownLineThick.Value, temporaryPoints.First(), textBoxText.Text, font);
                    drawing.Add(figura);
                }
                else if (radioButtonFillTool.Checked)
                {
                    FloodFill(new Bitmap(pictureBoxFrame.Image), e.Location);
                }
            }
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabelCursorPosition.Text = $"X: {e.X} Y: {e.Y}";

            if (e.Button == MouseButtons.Left)
            {
                temporaryPoints.Add(e.Location);

                Shape shape = null;
                pictureBoxPreview.Image = new Bitmap(pictureBoxFrame.Image);
                gp = Graphics.FromImage(pictureBoxPreview.Image);

                if (radioButtonLine.Checked)
                {
                    shape = new Line(buttonLineColor.BackColor, (int)numericUpDownLineThick.Value, temporaryPoints.First(), temporaryPoints.Last());
                }
                else if (radioButtonCurve.Checked)
                {
                    shape = new Curve(buttonLineColor.BackColor, (int)numericUpDownLineThick.Value, temporaryPoints);
                }
                else if (radioButtonRectangle.Checked)
                {
                    shape = new Rectangle(buttonLineColor.BackColor, (int)numericUpDownLineThick.Value, buttonFillColor.BackColor, temporaryPoints.First(), temporaryPoints.Last());
                }
                else if (radioButtonElipse.Checked)
                {
                    shape = new Elipse(buttonLineColor.BackColor, (int)numericUpDownLineThick.Value, buttonFillColor.BackColor, temporaryPoints.First(), temporaryPoints.Last());
                }
                else if (radioButtonEraser.Checked)
                {
                    shape = new Eraser(Color.White, (int)numericUpDownLineThick.Value, temporaryPoints);
                }
                else if (radioButtonSelect.Checked)
                {
                    shape = new SelectTool(Color.Red, (int)numericUpDownLineThick.Value, temporaryPoints.First(), temporaryPoints.Last());
                }
                if (shape != null)
                {
                    shape.Draw(gp);
                    pictureBoxPreview.Refresh();
                }
            }
        }



        private void PictureBoxFrame_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                temporaryPoints.Add(e.Location);


                if (radioButtonLine.Checked)
                {
                    drawing.Add(new Line(buttonLineColor.BackColor, (int)numericUpDownLineThick.Value, temporaryPoints.First(), temporaryPoints.Last()));
                }
                else if (radioButtonCurve.Checked)
                {
                    drawing.Add(new Curve(buttonLineColor.BackColor, (int)numericUpDownLineThick.Value, temporaryPoints));
                }
                else if (radioButtonRectangle.Checked)
                {
                    drawing.Add(new Rectangle(buttonLineColor.BackColor, (int)numericUpDownLineThick.Value, buttonFillColor.BackColor, temporaryPoints.First(), temporaryPoints.Last()));
                }
                else if (radioButtonElipse.Checked)
                {
                    drawing.Add(new Elipse(buttonLineColor.BackColor, (int)numericUpDownLineThick.Value, buttonFillColor.BackColor, temporaryPoints.First(), temporaryPoints.Last()));
                }
                else if (radioButtonEraser.Checked)
                {
                    drawing.Add(new Eraser(Color.White, (int)numericUpDownLineThick.Value, temporaryPoints));
                }
                else if (radioButtonSelect.Checked)
                {
                    EnableCopyCutMenuItems(true);
                }
                else if (radioButtonColor.Checked)
                {
                    buttonLineColor.BackColor = new Bitmap(pictureBoxFrame.Image).GetPixel(e.Location.X, e.Location.Y);
                }

                drawing.Draw(g);

                pictureBoxFrame.Refresh();
            }
        }

        private void EnableCopyCutMenuItems(bool b)
        {
            copyToolStripMenuItem.Enabled = b;
            cutToolStripMenuItem.Enabled = b;
        }

        private void CopyToClipboard(Point p1, Point p2)
        {

            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(
                                Math.Min(p1.X, p2.X),
                                Math.Min(p1.Y, p2.Y),
                                Math.Abs(p1.X - p2.X),
                                Math.Abs(p1.Y - p2.Y));
            Bitmap bm = new Bitmap(rect.Width, rect.Height);

            using (Graphics gr = Graphics.FromImage(bm))
            {
                System.Drawing.Rectangle dest_rect =
                    new System.Drawing.Rectangle(0, 0, rect.Width, rect.Height);
                gr.DrawImage(pictureBoxFrame.Image, dest_rect, rect,
                    GraphicsUnit.Pixel);
            }

            Clipboard.SetImage(bm);
        }

        private void ButtonLineColor_Click(object sender, EventArgs e)
        {
            ColorDialog kolorOkno = new ColorDialog();
            if (kolorOkno.ShowDialog() == DialogResult.OK)
            {
                buttonLineColor.BackColor = kolorOkno.Color;
            }
        }

        private void ButtonFillColor_Click(object sender, EventArgs e)
        {
            ColorDialog kolorOkno = new ColorDialog();
            if (kolorOkno.ShowDialog() == DialogResult.OK)
            {
                buttonFillColor.BackColor = kolorOkno.Color;
            }
        }

        #region file options
        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawing.Undo(g);
            drawing.Draw(gp);
            pictureBoxPreview.Refresh();
        }

        private void RedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawing.Redo(g);
            drawing.Draw(gp);
            pictureBoxPreview.Refresh();
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewFileDialog dialog = new NewFileDialog();

            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                baseSize = dialog.ImageSize;
                pictureBoxFrame.Image = new Bitmap(baseSize.Width, baseSize.Height);
                pictureBoxPreview.Image = new Bitmap(baseSize.Width, baseSize.Height);
                g = Graphics.FromImage(pictureBoxFrame.Image);
                gp = Graphics.FromImage(pictureBoxPreview.Image);

                drawing = new Drawing(baseSize.Width, baseSize.Height, dialog.ImageBackColor);
                drawing.Draw(g);
                drawing.Draw(gp);
                pictureBoxFrame.Refresh();
                pictureBoxPreview.Refresh();
                Text = "MiniPaint - niezapisane*";
            }
        }

        private void FileSaveMenuItem_Click(object sender, EventArgs e)
        {
            if (imageFileDirectory != null)
            {
                pictureBoxFrame.Image.Save(imageFileDirectory, System.Drawing.Imaging.ImageFormat.Bmp);
            }
            else
            {
                FileSaveAsMenuItem_Click(sender, e);
            }
        }

        private void FileSaveAsMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.Filter = "Bitmap (*.bmp)|*.bmp";
            if (saveDlg.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFrame.Image.Save(saveDlg.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                Text = "MiniPaint - " + System.IO.Path.GetFileName(saveDlg.FileName);
                imageFileDirectory = saveDlg.FileName;
            }
        }
        private void FileOpenMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Filter = "Image Files .BMP .JPG .GIF .Png|*.BMP;*.JPG;*.GIF;*.PNG";
            if (openDlg.ShowDialog() == DialogResult.OK)
            {

                using (FileStream stream = new FileStream(openDlg.FileName, FileMode.Open))
                {
                    NewBackground(Image.FromStream(stream));
                }

                Text = "MiniPaint - " + openDlg.SafeFileName;
                baseSize = pictureBoxFrame.Size;
                trackBar1.Value = 10;
                imageFileDirectory = openDlg.FileName;

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument myPrintDocument1 = new PrintDocument();
            myPrintDocument1.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                myPrintDocument1.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(pictureBoxFrame.Image, 0, 0);
        }

        private void FlipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image image = pictureBoxFrame.Image;
            image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            NewBackground(image);
        }

        private void NewBackground(Image image)
        {

            pictureBoxFrame.Image = new Bitmap(image);
            pictureBoxPreview.Image = new Bitmap(image);

            g = Graphics.FromImage(pictureBoxFrame.Image);
            drawing = new Drawing(image);
            drawing.Draw(g);
            pictureBoxFrame.Refresh();
        }
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 AboutMe = new AboutBox1();
            AboutMe.Show();
        }

        private void ChangeScale(double scale)
        {
            NewBackground(Scale((Bitmap)pictureBoxFrame.Image, scale));

        }

        private Image Scale(Bitmap picture, double scale)
        {
            return (Image)new Bitmap(picture, new Size(Convert.ToInt32(baseSize.Width * scale), Convert.ToInt32(baseSize.Height * scale)));
        }

        private void TextBoxText_TextChanged(object sender, EventArgs e)
        {
            drawing.Undo(gp);

            Shape figura = new Text(buttonLineColor.BackColor, (int)numericUpDownLineThick.Value, temporaryPoints.First(), textBoxText.Text, font);
            drawing.Add(figura);
            gp = Graphics.FromImage(pictureBoxPreview.Image);
            figura.Draw(gp);
            pictureBoxPreview.Refresh();
        }

        private void ButtonAddText_Click(object sender, EventArgs e)
        {
            drawing.Add(new Text(buttonLineColor.BackColor, (int)numericUpDownLineThick.Value, temporaryPoints.First(), textBoxText.Text, font));
            drawing.Draw(g);
            pictureBoxFrame.Refresh();
            textBoxText.Text = "";
            groupBoxShape.Enabled = true;
            groupBoxText.Visible = false;
        }

        private void ButtonFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                font = fontDialog1.Font;
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            double skala = trackBar1.Value / 10.0;
            ChangeScale(skala);
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyToClipboard(temporaryPoints.First(), temporaryPoints.Last());
            HideSelect();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyToClipboard(temporaryPoints.First(), temporaryPoints.Last());
            drawing.Add(new Rectangle(Color.White, 1, Color.White, temporaryPoints.First(), temporaryPoints.Last()));
            drawing.Draw(g);
            HideSelect();
        }
        private void HideSelect()
        {
            EnableCopyCutMenuItems(false);
            pictureBoxPreview.Image = new Bitmap(pictureBoxFrame.Image);
            gp = Graphics.FromImage(pictureBoxPreview.Image);
            pictureBoxPreview.Refresh();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Clipboard.ContainsImage()) return;

            Image clipboard_image = Clipboard.GetImage();

            drawing.Add(new ImageUnscaled(Color.White, 1, temporaryPoints.First(), clipboard_image));
            drawing.Draw(g);
            pictureBoxPreview.Image = new Bitmap(pictureBoxFrame.Image);
            gp = Graphics.FromImage(pictureBoxPreview.Image);
            pictureBoxPreview.Refresh();
        }

        #region Floodfill
        private void FloodFill(Bitmap bmp, Point pt)
        {
            Stack<Point> pixels = new Stack<Point>();
            Color targetColor = bmp.GetPixel(pt.X, pt.Y);
            Color replacementColor = buttonLineColor.BackColor;
            pixels.Push(pt);

            while (pixels.Count > 0)
            {
                Point a = pixels.Pop();
                if (a.X < bmp.Width && a.X > 0 &&
                        a.Y < bmp.Height && a.Y > 0)
                {

                    if (bmp.GetPixel(a.X, a.Y) == targetColor)
                    {
                        bmp.SetPixel(a.X, a.Y, replacementColor);
                        pixels.Push(new Point(a.X - 1, a.Y));
                        pixels.Push(new Point(a.X + 1, a.Y));
                        pixels.Push(new Point(a.X, a.Y - 1));
                        pixels.Push(new Point(a.X, a.Y + 1));
                    }
                }
            }
            pictureBoxFrame.Image = bmp;
            pictureBoxPreview.Image = bmp;
            drawing = new Drawing(bmp);
            drawing.Draw(g);
            pictureBoxFrame.Refresh();
            pictureBoxPreview.Refresh();
        }
        #endregion
    }
}
