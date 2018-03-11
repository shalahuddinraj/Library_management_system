using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LMSSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            textBox2.PasswordChar = '@';
            textBox2.MaxLength = 8;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\LMSSystem\LMSSystem\Library.mdf;Integrated Security=True;User Instance=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*)From password where username='" + textBox1.Text + "' and password ='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                progressBar1.Visible = true;
                timer2.Start();
                //this.Hide();
                //mainfrom f = new mainfrom();
                //f.Show();
                //MessageBox.Show("WELLCOME TO OUR LIBRARY");
            }
            else
            {
                MessageBox.Show("Wrong Password");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           studentlogin f = new studentlogin();
            f.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time_lbl.Text = DateTime.Now.ToLongDateString();
            label5.Text = DateTime.Now.ToLongTimeString();
            //DateTime dateTime = DateTime.Now;
            //this.time_lbl.Text = dateTime.ToString();
        }

        private void time_lbl_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = Convert.ToInt32(progressBar1.Value) + 10;
            if (Convert.ToInt32(progressBar1.Value) > 90)
            {
                timer2.Stop();
                mainfrom f = new mainfrom();

                f.Show();
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;
            timer3.Start();
            timer3.Enabled = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int A = rand.Next(0, 255);
            int R = rand.Next(0, 255);
            int G = rand.Next(0, 255);
            int B = rand.Next(0, 255);
            label3.ForeColor = Color.FromArgb(A, R, G, B);
            label3.Location = new Point(label3.Location.X + 5, label3.Location.Y);
            if (label3.Location.X > this.Width)
            {

                label3.Location = new Point(0 - label3.Width, label3.Location.Y);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            pictureBox2.Visible = pictureBox2.Visible == true ? false : true;
        }
    }
}

