using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LMSSystem
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void sTUDENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentreg f = new studentreg();
            f.Show();
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            issue f = new issue();
            f.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            book f = new book();
            f.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
           password f = new password();
            f.Show();
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
           studentinfo f = new studentinfo();
            f.Show();
        }

        private void seaRchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           booksearch f = new booksearch();
            f.Show();
        }

        private void fILEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
