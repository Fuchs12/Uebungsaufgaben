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

        private void Schneckenbau_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
