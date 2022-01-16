using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Uebungsaufgaben;

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

        private void Maximize()
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void Minimize()
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSchraffierung_Click(object sender, EventArgs e)
        {
            Schraffierung frmSchraffierung = new Schraffierung();
            frmSchraffierung.Show();
            Minimize();
        }
    }
}
