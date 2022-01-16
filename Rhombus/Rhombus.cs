using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Rhombus
{
    public partial class Rhombus : Form
    {
        public Rhombus()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Skalieren();
        }

        Pen BluePen = new Pen(Color.Blue, 2F);
        Rectangle rectangle;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.HighQuality;

            Point obenMitte = new Point(rectangle.X + rectangle.Width / 2, rectangle.Y);
            Point untenMitte = new Point(rectangle.X + rectangle.Width / 2, rectangle.Height + rectangle.Y);
            Point rechtsMitte = new Point(rectangle.Width + rectangle.X, rectangle.Y + rectangle.Height / 2);
            Point linksMitte = new Point(rectangle.X, rectangle.Y + rectangle.Height / 2);

            graphics.DrawRectangle(BluePen, rectangle);

            GraphicsPath path = new GraphicsPath();
            path.AddLine(obenMitte, linksMitte);
            path.AddLine(linksMitte, untenMitte);
            path.AddLine(untenMitte, rechtsMitte);
            path.AddLine(rechtsMitte, obenMitte);
            path.CloseFigure();

            graphics.DrawPath(BluePen, path);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Skalieren();
            Refresh();
        }

        private void Skalieren()
        {
            rectangle = new Rectangle(0, 0, ClientSize.Width, ClientSize.Height);
        }

        private void Rhombus_FormClosing(object sender, FormClosingEventArgs e)
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
