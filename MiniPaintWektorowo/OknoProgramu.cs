﻿using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPaintWektorowo
{
    public partial class OknoProgramu : Form
    {
        private string imageFileDirectory = null;
        Graphics g;
        Graphics gp;
        List<Point> punktyRobocze = new List<Point>();
        Rysunek rysunek;
        Size bazowyRozmiar;
        Font font;
        public OknoProgramu()
        {
            InitializeComponent();
            pictureBoxRamka.Image = new Bitmap(pictureBoxRamka.Width, pictureBoxRamka.Height);
            pictureBoxPodglad.Image = new Bitmap(pictureBoxPodglad.Width, pictureBoxPodglad.Height);
            bazowyRozmiar = pictureBoxRamka.Size;
            pictureBoxPodglad.BackColor = Color.White;
            g = Graphics.FromImage(pictureBoxRamka.Image);
            font = new Font("Arial", 16);

            rysunek = new Rysunek(pictureBoxRamka.Width, pictureBoxRamka.Height, Color.White);
            rysunek.Rysuj(g);
            pictureBoxRamka.Refresh();

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                punktyRobocze.Clear();
                punktyRobocze.Add(e.Location);

                if (radioButtonTekst.Checked)
                {
                    groupBoxTekst.Visible = true;
                    groupBoxKsztalt.Enabled = false;
                    Figura figura = new Tekst(buttonKolorLinii.BackColor, (int)numericUpDownGruboscLinii.Value, punktyRobocze.First(), textBoxTekst.Text, font);
                    rysunek.Dodaj(figura);
                }else if (radioButtonWiadro.Checked) {
                    FloodFill(new Bitmap(pictureBoxRamka.Image), e.Location);
                }
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabelCursorPosition.Text = $"X: {e.X} Y: {e.Y}";

            if (e.Button == MouseButtons.Left)
            {
                punktyRobocze.Add(e.Location);

                Figura figura = null;
                pictureBoxPodglad.Image = new Bitmap(pictureBoxRamka.Image);
                gp = Graphics.FromImage(pictureBoxPodglad.Image);

                if (radioButtonProsta.Checked)
                {
                    figura = new Linia(buttonKolorLinii.BackColor, (int)numericUpDownGruboscLinii.Value, punktyRobocze.First(), punktyRobocze.Last());
                }
                else if (radioButtonKrzywa.Checked)
                {
                    figura = new Krzywa(buttonKolorLinii.BackColor, (int)numericUpDownGruboscLinii.Value, punktyRobocze);
                }
                else if (radioButtonProstokat.Checked)
                {
                    figura = new Prostokat(buttonKolorLinii.BackColor, (int)numericUpDownGruboscLinii.Value, buttonKolorWypelnienia.BackColor, punktyRobocze.First(), punktyRobocze.Last());
                }
                else if (radioButtonElipsa.Checked)
                {
                    figura = new Elipsa(buttonKolorLinii.BackColor, (int)numericUpDownGruboscLinii.Value, buttonKolorWypelnienia.BackColor, punktyRobocze.First(), punktyRobocze.Last());
                }
                else if (radioButtonGumka.Checked)
                {
                    figura = new Gumka(Color.White, (int)numericUpDownGruboscLinii.Value, punktyRobocze);
                }
                else if (radioButtonSelect.Checked)
                {
                    figura = new Zaznaczenie(Color.Red, (int)numericUpDownGruboscLinii.Value, punktyRobocze.First(), punktyRobocze.Last());
                }
                if (figura != null)
                {
                    figura.Rysuj(gp);
                    pictureBoxPodglad.Refresh();
                }
            }
        }



        private void pictureBoxRamka_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                punktyRobocze.Add(e.Location);


                if (radioButtonProsta.Checked)
                {
                    rysunek.Dodaj(new Linia(buttonKolorLinii.BackColor, (int)numericUpDownGruboscLinii.Value, punktyRobocze.First(), punktyRobocze.Last()));
                }
                else if (radioButtonKrzywa.Checked)
                {
                    rysunek.Dodaj(new Krzywa(buttonKolorLinii.BackColor, (int)numericUpDownGruboscLinii.Value, punktyRobocze));
                }
                else if (radioButtonProstokat.Checked)
                {
                    rysunek.Dodaj(new Prostokat(buttonKolorLinii.BackColor, (int)numericUpDownGruboscLinii.Value, buttonKolorWypelnienia.BackColor, punktyRobocze.First(), punktyRobocze.Last()));
                }
                else if (radioButtonElipsa.Checked)
                {
                    rysunek.Dodaj(new Elipsa(buttonKolorLinii.BackColor, (int)numericUpDownGruboscLinii.Value, buttonKolorWypelnienia.BackColor, punktyRobocze.First(), punktyRobocze.Last()));
                }
                else if (radioButtonGumka.Checked)
                {
                    rysunek.Dodaj(new Gumka(Color.White, (int)numericUpDownGruboscLinii.Value, punktyRobocze));
                }
                else if (radioButtonSelect.Checked)
                {
                    EnableCopyCutMenuItems(true);
                }
                else if (radioButtonKolor.Checked)
                {
                    buttonKolorLinii.BackColor = new Bitmap(pictureBoxRamka.Image).GetPixel(e.Location.X, e.Location.Y);
                }

                rysunek.Rysuj(g);

                pictureBoxRamka.Refresh();
            }
        }

        private void EnableCopyCutMenuItems(bool b)
        {
            kopiujToolStripMenuItem.Enabled = b;
            wytnijToolStripMenuItem.Enabled = b;
        }

        private void copyToClipboard(Point p1, Point p2)
        {

            Rectangle rect = new Rectangle(
                                Math.Min(p1.X, p2.X),
                                Math.Min(p1.Y, p2.Y),
                                Math.Abs(p1.X - p2.X),
                                Math.Abs(p1.Y - p2.Y));
            Bitmap bm = new Bitmap(rect.Width, rect.Height);

            using (Graphics gr = Graphics.FromImage(bm))
            {
                Rectangle dest_rect =
                    new Rectangle(0, 0, rect.Width, rect.Height);
                gr.DrawImage(pictureBoxRamka.Image, dest_rect, rect,
                    GraphicsUnit.Pixel);
            }

            Clipboard.SetImage(bm);
        }

        private void buttonKolorLinii_Click(object sender, EventArgs e)
        {
            ColorDialog kolorOkno = new ColorDialog();
            if (kolorOkno.ShowDialog() == DialogResult.OK)
            {
                buttonKolorLinii.BackColor = kolorOkno.Color;
            }
        }

        private void buttonKolorWypelnienia_Click(object sender, EventArgs e)
        {
            ColorDialog kolorOkno = new ColorDialog();
            if (kolorOkno.ShowDialog() == DialogResult.OK)
            {
                buttonKolorWypelnienia.BackColor = kolorOkno.Color;
            }
        }

        #region file options
        private void cofnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rysunek.Usun(g);
            rysunek.Rysuj(gp);
            pictureBoxPodglad.Refresh();
        }

        private void ponówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rysunek.Ponow(g);
            rysunek.Rysuj(gp);
            pictureBoxPodglad.Refresh();
        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewDialog dialog = new NewDialog();

            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                bazowyRozmiar = dialog.ImageSize;
                pictureBoxRamka.Image = new Bitmap(bazowyRozmiar.Width, bazowyRozmiar.Height);
                pictureBoxPodglad.Image = new Bitmap(bazowyRozmiar.Width, bazowyRozmiar.Height);
                g = Graphics.FromImage(pictureBoxRamka.Image);
                gp = Graphics.FromImage(pictureBoxPodglad.Image);

                rysunek = new Rysunek(bazowyRozmiar.Width, bazowyRozmiar.Height, dialog.imageBackColor);
                rysunek.Rysuj(g);
                rysunek.Rysuj(gp);
                pictureBoxRamka.Refresh();
                pictureBoxPodglad.Refresh();
                Text = "MiniPaint wektorowy - niezapisane*";
            }
        }

        private void fileSaveMenuItem_Click(object sender, EventArgs e)
        {
            if (imageFileDirectory != null)
                pictureBoxRamka.Image.Save(imageFileDirectory, System.Drawing.Imaging.ImageFormat.Bmp);
            else
                fileSaveAsMenuItem_Click(sender, e);
        }

        private void fileSaveAsMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.Filter = "Bitmap (*.bmp)|*.bmp";
            if (saveDlg.ShowDialog() == DialogResult.OK)
            {
                pictureBoxRamka.Image.Save(saveDlg.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                Text = "MiniPaint wektorowy - " + System.IO.Path.GetFileName(saveDlg.FileName);
                imageFileDirectory = saveDlg.FileName;
            }
        }
        private void fileOpenMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Filter = "Image Files .BMP .JPG .GIF .Png|*.BMP;*.JPG;*.GIF;*.PNG";
            if (openDlg.ShowDialog() == DialogResult.OK)
            {

                using (FileStream stream = new FileStream(openDlg.FileName, FileMode.Open))
                {
                    noweTlo(Image.FromStream(stream));
                }

                Text = "MiniPaint wektorowy - " + openDlg.SafeFileName;
                bazowyRozmiar = pictureBoxRamka.Size;
                trackBar1.Value = 10;
                imageFileDirectory = openDlg.FileName;

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        private void drukujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument myPrintDocument1 = new PrintDocument();
            myPrintDocument1.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                myPrintDocument1.Print();
            }
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(pictureBoxRamka.Image, 0, 0);
        }

        private void obrocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image image = pictureBoxRamka.Image;
            image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            noweTlo(image);
        }

        private void noweTlo(Image image)
        {

            pictureBoxRamka.Image = new Bitmap(image);
            pictureBoxPodglad.Image = new Bitmap(image);

            g = Graphics.FromImage(pictureBoxRamka.Image);
            rysunek = new Rysunek(image);
            rysunek.Rysuj(g);
            pictureBoxRamka.Refresh();
        }
        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 AboutMe = new AboutBox1();
            AboutMe.Show();
        }

        private void zmienSkale(double skala)
        {
            noweTlo(przeskaluj((Bitmap)pictureBoxRamka.Image, skala));

        }

        private Image przeskaluj(Bitmap obraz, double skala)
        {
            return (Image)new Bitmap(obraz, new Size(Convert.ToInt32(bazowyRozmiar.Width * skala), Convert.ToInt32(bazowyRozmiar.Height * skala)));
        }

        private void textBoxTekst_TextChanged(object sender, EventArgs e)
        {
            rysunek.Usun(gp);

            Figura figura = new Tekst(buttonKolorLinii.BackColor, (int)numericUpDownGruboscLinii.Value, punktyRobocze.First(), textBoxTekst.Text, font);
            rysunek.Dodaj(figura);
            gp = Graphics.FromImage(pictureBoxPodglad.Image);
            figura.Rysuj(gp);
            pictureBoxPodglad.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rysunek.Dodaj(new Tekst(buttonKolorLinii.BackColor, (int)numericUpDownGruboscLinii.Value, punktyRobocze.First(), textBoxTekst.Text, font));
            rysunek.Rysuj(g);
            pictureBoxRamka.Refresh();
            textBoxTekst.Text = "";
            groupBoxKsztalt.Enabled = true;
            groupBoxTekst.Visible = false;
        }

        private void buttonCzcionka_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                font = fontDialog1.Font;
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            double skala = trackBar1.Value / 10.0;
            zmienSkale(skala);
        }

        private void kopiujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copyToClipboard(punktyRobocze.First(), punktyRobocze.Last());
            hideSelect();
        }

        private void wytnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copyToClipboard(punktyRobocze.First(), punktyRobocze.Last());
            rysunek.Dodaj(new Prostokat(Color.White, 1, Color.White, punktyRobocze.First(), punktyRobocze.Last()));
            rysunek.Rysuj(g);
            hideSelect();
        }
        private void hideSelect()
        {
            EnableCopyCutMenuItems(false);
            pictureBoxPodglad.Image = new Bitmap(pictureBoxRamka.Image);
            gp = Graphics.FromImage(pictureBoxPodglad.Image);
            pictureBoxPodglad.Refresh();
        }

        private void wklejToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Clipboard.ContainsImage()) return;

            Image clipboard_image = Clipboard.GetImage();

            rysunek.Dodaj(new Obraz(Color.White, 1, punktyRobocze.First(), clipboard_image));
            rysunek.Rysuj(g);
            pictureBoxPodglad.Image = new Bitmap(pictureBoxRamka.Image);
            gp = Graphics.FromImage(pictureBoxPodglad.Image);
            pictureBoxPodglad.Refresh();
        }

        #region Floodfill
        private void FloodFill(Bitmap bmp, Point pt) {
            Stack<Point> pixels = new Stack<Point>();
            Color targetColor = bmp.GetPixel(pt.X, pt.Y);
            Color replacementColor = buttonKolorLinii.BackColor;
            pixels.Push(pt);

            while (pixels.Count > 0) {
                Point a = pixels.Pop();
                if (a.X < bmp.Width && a.X > 0 &&
                        a.Y < bmp.Height && a.Y > 0) {

                    if (bmp.GetPixel(a.X, a.Y) == targetColor) {
                        bmp.SetPixel(a.X, a.Y, replacementColor);
                        pixels.Push(new Point(a.X - 1, a.Y));
                        pixels.Push(new Point(a.X + 1, a.Y));
                        pixels.Push(new Point(a.X, a.Y - 1));
                        pixels.Push(new Point(a.X, a.Y + 1));
                    }
                }
            }
            pictureBoxRamka.Image = bmp;
            pictureBoxPodglad.Image = bmp;
            rysunek = new Rysunek(bmp);
            rysunek.Rysuj(g);
            pictureBoxRamka.Refresh();
            pictureBoxPodglad.Refresh();
        }
        #endregion
    }
}
