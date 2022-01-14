using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Rhombus
{
    public partial class Menue : Form
    {
        public Menue()
        {
            InitializeComponent();
        }

        private void btnRhombus_Click(object sender, EventArgs e)
        {
            Rhombus frmRhombus = new Rhombus();
            frmRhombus.Show();
            Minimize();

        }

        private void Minimize()
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
