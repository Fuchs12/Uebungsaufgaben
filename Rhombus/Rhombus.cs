using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

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

        Pen blackPen = new Pen(Color.Black);
        Rectangle rectangle;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            
            Point obenMitte = new Point(rectangle.X + rectangle.Width/2 ,rectangle.Y);
            Point untenMitte = new Point(rectangle.X + rectangle.Width/2,rectangle.Height + rectangle.Y);
            Point rechtsMitte = new Point(rectangle.Width + rectangle.X, rectangle.Y + rectangle.Height/2);
            Point linksMitte = new Point(rectangle.X, rectangle.Y + rectangle.Height/2);

            graphics.DrawRectangle(blackPen, rectangle);
            
            GraphicsPath path = new GraphicsPath();
            path.AddLine(obenMitte, linksMitte);
            path.AddLine(linksMitte, untenMitte);
            path.AddLine(untenMitte, rechtsMitte);
            path.AddLine(rechtsMitte, obenMitte);
            path.CloseFigure();

            graphics.DrawPath(blackPen, path);
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

        private void btnRhombus_Click(object sender, EventArgs e)
        {

        }
    }
}
