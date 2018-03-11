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
    public partial class clock : Form
    {
        public clock()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm");
            label2.Text = DateTime.Now.ToString("ss");
            label3.Text = DateTime.Now.ToString("MM dd yyyy");
            label4.Text = DateTime.Now.ToString("dddd");
            label2.Location = new Point(label1.Location.X + label1.Width-5,label2.Location.Y);




        }

        private void clock_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
