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
    public partial class studentlogin : Form
    {
        public studentlogin()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void searchBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            raz f = new raz();
            f.Show();
        }

        private void aDVERTISEMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
           student f = new student();
            f.Show();
        }

        private void eBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            librian f = new librian();
            f.Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newraz f = new newraz();
            f.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to close the program?", "SomeTitle", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
                //e.Cancel = true;
            }
        }

        private void cREDITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About f = new About();
            f.Show();
        }

        private void careerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jobs f = new jobs();
            f.Show();
        }
    }
}
