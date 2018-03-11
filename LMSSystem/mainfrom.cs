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
    public partial class mainfrom : Form
    {
        public mainfrom()
        {
            InitializeComponent();
        }

        private void passwordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            password f = new password();
            f.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentreg f = new studentreg();
            f.Show();
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentinfo f = new studentinfo();
            f.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            book f = new book();
            f.Show();
        }

        private void byNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            booksearch f = new booksearch();
            f.Show();
        }

        private void cancellRegistationToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            updatestudentcs f = new updatestudentcs();
            f.Show();
        }

        private void byIdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            id f = new id();
            f.Show();
        }

        private void bywriterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            writer f = new writer();
            f.Show();
        }

        private void byPublisherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            publisher f = new publisher();
            f.Show();
        }

        private void bookTransictionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view f = new view();
            f.Show();
        }

        private void bookStorageToolStripMenuItem_Click(object sender, EventArgs e)
        {
           issue f = new issue ();
            f.Show();
        }

        private void updateBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updatebook f = new updatebook();
            f.Show();
        }

        private void aBOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Location = new Point(label1.Location.X + 5, label1.Location.Y);
            if (label1.Location.X > this.Width)
            {

                label1.Location = new Point(0 - label1.Width, label1.Location.Y);
            }
            //label1.Text = " "+label1.Text;
            //label1.Text = " " + label1.Text;
        }

        private void mainfrom_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int A = rand.Next(0, 255);
            int R = rand.Next(0, 255);
            int G = rand.Next(0, 255);
            int B = rand.Next(0, 255);
            label2.ForeColor = Color.FromArgb(A, R, G, B);
        }

        private void studentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            transiction f = new transiction();
            f.Show();
        }

        private void aBOUTUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            librian f = new librian();
            f.Show();
        }

        private void bookToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            student f = new student();
            f.Show();

        }

        private void digitalClockToolStripMenuItem_Click(object sender, EventArgs e)
        {
           clock f = new clock();
            f.Show();
        }

        private void aboutUsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            newraz f = new newraz();
            f.Show();
        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to close the program?", "SomeTitle", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
                //don't do anything
            }
        }

        private void cRADITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About f = new About();
            f.Show();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox2.Visible = pictureBox2.Visible == true ? false : true;
        }

        private void deleteBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deletebook f = new deletebook();
            f.Show();
        }
    }
}
