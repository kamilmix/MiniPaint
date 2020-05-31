using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
        public OknoProgramu()
        {
            InitializeComponent();
            pictureBoxRamka.Image = new Bitmap(pictureBoxRamka.Width, pictureBoxRamka.Height);
            pictureBoxPodglad.Image = new Bitmap(pictureBoxPodglad.Width, pictureBoxPodglad.Height);
            pictureBoxPodglad.BackColor = Color.White;
            g = Graphics.FromImage(pictureBoxRamka.Image);



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

                figura.Rysuj(gp);
                pictureBoxPodglad.Refresh();

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

                rysunek.Rysuj(g);

                pictureBoxRamka.Refresh();
            }
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

        private void pictureBoxRamka_Click(object sender, EventArgs e)
        {

        }

        #region file options
        private void cofnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rysunek.Usun(g);
            rysunek.Rysuj(gp);
            pictureBoxPodglad.Refresh();
        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rysunek = new Rysunek(pictureBoxRamka.Width, pictureBoxRamka.Height, Color.White);
            rysunek.Rysuj(g);
            rysunek.Rysuj(gp);
            pictureBoxPodglad.Refresh();
        }

        private void fileSaveMenuItem_Click(object sender, EventArgs e) {
          if (imageFileDirectory != null)   
              try{
                  pictureBoxRamka.Image.Save(imageFileDirectory, System.Drawing.Imaging.ImageFormat.Bmp);
              }catch{
                  MessageBox.Show("Error");
              }
          else
              fileSaveAsMenuItem_Click(sender,e);
        }

        private void fileSaveAsMenuItem_Click(object sender, EventArgs e) {
          SaveFileDialog saveDlg = new SaveFileDialog();
          saveDlg.Filter = "Bitmap (*.bmp)|*.bmp";
          if (saveDlg.ShowDialog() == DialogResult.OK) {
              try{                                                        
                  pictureBoxRamka.Image.Save(saveDlg.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                  imageFileDirectory = saveDlg.FileName;
              }catch{
                  MessageBox.Show("Error");
              }
          }
        }
        private void fileOpenMenuItem_Click(object sender, EventArgs e) {   // TODO zmiana rozmiaru ramki gdy inny
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Filter = "Image Files .BMP .JPG .GIF .Png|*.BMP;*.JPG;*.GIF;*.PNG";
            if (openDlg.ShowDialog() == DialogResult.OK) {
                try  { 
                    Image imageFile = Image.FromFile(openDlg.FileName);
                    pictureBoxRamka.Image = (Bitmap) imageFile;
                    pictureBoxPodglad.Image = new Bitmap(pictureBoxRamka.Width, pictureBoxRamka.Height);  

                    rysunek = new Rysunek(pictureBoxRamka.Width, pictureBoxRamka.Height, imageFile);
                    rysunek.Rysuj(g);
                    pictureBoxRamka.Refresh();

                    imageFileDirectory = openDlg.FileName;
                }catch{
                    MessageBox.Show("Error");
                }
            }else{
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
    }
}
