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
    public partial class transiction : Form
    {
        public transiction()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\LMSSystem\LMSSystem\Library.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            SqlCommand sc = new SqlCommand("select *from studentreg", con);
            try
            {
                SqlDataReader sdr = sc.ExecuteReader();

                while (sdr.Read())
                {

                    comboBox2.Items.Add(sdr["id"]);
                    
                }

            }
            catch
            {
                MessageBox.Show("error from database");
                con.Close();
            }
        }

        private void transiction_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\LMSSystem\LMSSystem\Library.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            SqlCommand sc = new SqlCommand("select *from book", con);
            try
            {
                SqlDataReader sdr = sc.ExecuteReader();

                while (sdr.Read())
                {

                    comboBox1.Items.Add(sdr["book_id"]);
                   
                }

            }
            catch
            {
                MessageBox.Show("error from database");
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\LMSSystem\LMSSystem\Library.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            SqlCommand sc = new SqlCommand("select *from book where book_id='" + comboBox1.Text + "'", con);
            try
            {
                SqlDataReader sdr = sc.ExecuteReader();

                while (sdr.Read())
                {

                    label1.Text = sdr["book_name"].ToString();
                    label2.Text = sdr["isbn_no"].ToString();
                    label3.Text = sdr["writer"].ToString();
                    label4.Text = sdr["author"].ToString();
                    label6.Text = sdr["publisher"].ToString();
                    label7.Text = sdr["subject_code"].ToString();
                    label8.Text = sdr["edition"].ToString();
                    label9.Text = sdr["catagory"].ToString();
                    label20.Text = sdr["publising_year"].ToString();
                    //dateTimePicker1.Text = sdr["date"].ToString();
                }

            }
            catch
            {
                MessageBox.Show("error from database");
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\LMSSystem\LMSSystem\Library.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            SqlCommand sc = new SqlCommand("select *from studentreg where id='" + comboBox2.Text + "'", con);
            try
            {
                SqlDataReader sdr = sc.ExecuteReader();

                while (sdr.Read())
                {

                    label26.Text = sdr["name"].ToString();
                    label27.Text = sdr["intake"].ToString();
                    label28.Text = sdr["dept"].ToString();
                    label29.Text = sdr["personalno"].ToString();
                    label30.Text = sdr["guardianno"].ToString();
                   // label7.Text = sdr["subject_code"].ToString();
                   // label8.Text = sdr["edition"].ToString();
                    //label9.Text = sdr["catagory"].ToString();
                    //label20.Text = sdr["publising_year"].ToString();
                    //dateTimePicker1.Text = sdr["date"].ToString();
                }

            }
            catch
            {
                MessageBox.Show("error from database");
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
