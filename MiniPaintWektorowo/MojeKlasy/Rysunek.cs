﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPaintWektorowo
{
    class Rysunek
    {
        private Int32 wysokosc;
        private Int32 szerokosc;
        private List<Figura> figury;
        private List<Figura> figuryUsuniete;
        private Color kolorTla;
        private Image imageFile = null;

        public Rysunek(int szerokosc, int wysokosc, Color kolorTla)
        {
            this.szerokosc = szerokosc;
            this.wysokosc = wysokosc;
            this.kolorTla = kolorTla;
            figury = new List<Figura>();
            figuryUsuniete = new List<Figura>();
        }
        public Rysunek(int szerokosc, int wysokosc, Image imageFile)
        {
            this.szerokosc = szerokosc;
            this.wysokosc = wysokosc;
            this.imageFile = imageFile;
            figury = new List<Figura>();
            figuryUsuniete = new List<Figura>();
        }

        public void Rysuj(Graphics g)
        {
            if (g != null)
            {
                if (imageFile != null)
                {
                    g = Graphics.FromImage(imageFile);
                }
                else
                {
                    g.Clear(kolorTla);
                }

                foreach (Figura f in figury)
                {
                    f.Rysuj(g);
                }
            }
        }

        internal void Dodaj(Figura f)
        {
            figury.Add(f);
        }

        internal void Usun(Graphics g)
        {
            if (figury.Any())
            {
                figuryUsuniete.Add(figury.Last());
                figury.RemoveAt(figury.Count - 1);
            }
            Rysuj(g);
        }

        internal void Ponow(Graphics g)
        {
            if (figuryUsuniete.Any())
            {
                figury.Add(figuryUsuniete.Last());
                figuryUsuniete.RemoveAt(figuryUsuniete.Count - 1);
            }
            Rysuj(g);
        }
    }
}
