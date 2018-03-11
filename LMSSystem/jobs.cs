using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace LMSSystem
{
    public partial class jobs : Form
    {
        public jobs()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.bdjobs.com/");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.chakri.com/");
        }
    }
}
