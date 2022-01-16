using System.Drawing;
using System.Windows.Forms;

namespace Uebungsaufgaben
{
    public partial class Schraffierung : Form
    {
        public Schraffierung()
        {
            InitializeComponent();
            rectangle = new Rectangle(10, 10, 500, 500);
        }
        public Rectangle rectangle;
        private Pen blackPen = new Pen(Color.Black);

        private void Schraffierung_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            graphics.DrawRectangle(blackPen, rectangle);

            int abstand = 10;

            for (int x = rectangle.X + abstand; x < rectangle.Width + rectangle.X; x += abstand)
            {
                graphics.DrawLine(blackPen, x, rectangle.Y, rectangle.X, x);
            }
            for (int y = rectangle.Y; y < rectangle.Height + rectangle.Y; y += 10)
            {
                graphics.DrawLine(blackPen, rectangle.X + rectangle.Width, y, y, rectangle.Y + rectangle.Height);
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
