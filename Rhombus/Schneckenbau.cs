using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Uebungsaufgaben
{
    public partial class Schneckenbau : Form
    {
        public Schneckenbau()
        {
            InitializeComponent();
        }

        Pen BlackPen = new Pen(Color.Black);

        private void Schneckenbau_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            int laenge = 100;
            Point start = new Point(ClientSize.Width/2,ClientSize.Height/2);
            Point ziel = new Point(ClientSize.Width/2 + laenge, ClientSize.Height/2);
            graphics.DrawLine(BlackPen, start, ziel);

            while (ziel.X < ClientSize.Width && ziel.X > 0&& ziel.Y < ClientSize.Height && ziel.Y > 0) //Überprüft, ob das ziel auserhalb der Form ist
            {
                if (Vektor(start.X, ziel.X) > 0) //Überprüft, ob sich strich nach rechts bewegt hat
                {
                    laenge -= 40;
                    start = ziel;
                    ziel = new Point(ziel.X, ziel.Y- laenge);
                }
                else if (Vektor(start.Y, ziel.Y) < 0) //Überprüft, ob sich strich nach oben bewegt hat
                {
                    start = ziel;
                    ziel = new Point(ziel.X - laenge, ziel.Y);
                }
                else if (Vektor(start.X, ziel.X) < 0) //Überprüft, ob sich strich nach link bewegt hat
                {
                    laenge -= 40;
                    start = ziel;
                    ziel = new Point(ziel.X, ziel.Y + laenge);
                }
                else //Überprüft, ob sich strich nach unten bewegt hat
                {
                    start = ziel;
                    ziel = new Point(ziel.X + laenge, ziel.Y);
                }
                laenge += 50;
                graphics.DrawLine(BlackPen, start, ziel);
            }
        }

        private int Vektor(int start, int ziel)
        {
            return ziel - start;
        }

        private void Schneckenbau_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Name == "Menue")
                {
                    frm.WindowState = FormWindowState.Normal;
                }
            }
        }

        private void Schneckenbau_Resize(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
