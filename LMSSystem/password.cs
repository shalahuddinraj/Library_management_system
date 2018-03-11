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
    public partial class password : Form
    {
        public password()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\LMSSystem\LMSSystem\Library.mdf;Integrated Security=True;User Instance=True");

            // con.Open();
            if (textBox1.Text != "" & textBox2.Text != " ")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update password set password='" + textBox3.Text + "' where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'", con);

                try
                {
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Password Change SuccenfullY ");
                }

                catch
                {
                    MessageBox.Show("WRONG PassWOrd");
                }

            }
            else
            {
                MessageBox.Show("Enter User Name and Password");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\LMSSystem\LMSSystem\Library.mdf;Integrated Security=True;User Instance=True");

            con.Open();
            SqlCommand sda = new SqlCommand("insert into password(username,password) values('" + textBox1.Text + "','" + textBox2.Text + "') ", con);
            //SqlDataAdapter sda = new SqlDataAdapter("insert into login(username,password) values('" + textBox1.Text + "','" + textBox2.Text + "') ", con);

            try
            {
                sda.ExecuteNonQuery();
                textBox1.Text = " ";
                textBox2.Text = " ";
                // con.Close();
                MessageBox.Show("Add succesfully");
            }
            catch
            {

                MessageBox.Show("Data error");
                con.Close();

            }

        }
    }
}
