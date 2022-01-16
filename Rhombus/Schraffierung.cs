using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Uebungsaufgaben
{
    public partial class Schraffierung : Form
    {
        public Schraffierung()
        {
            InitializeComponent();
            rectangle = new Rectangle(10,10,100,100);
        }
        private Rectangle rectangle;
        private Pen blackPen = new Pen(Color.Black);

        private void Schraffierung_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            graphics.DrawRectangle(blackPen, rectangle);

            int abstand = 10;
            int x = rectangle.X + abstand;

            while (x < rectangle.Width + rectangle.X)
            {
                graphics.DrawLine(blackPen, x, rectangle.Y, rectangle.X, x);
                x += abstand;
            }
            int y = rectangle.Y;
            while (y < rectangle.Height + rectangle.Y)
            {
                graphics.DrawLine(blackPen, rectangle.X + rectangle.Width, y, y, rectangle.Y + rectangle.Height);
                y += 10;
            }
        }

        private void Schraffierung_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
