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
    public partial class deletebook : Form
    {
        public deletebook()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\LMSSystem\LMSSystem\Library.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            SqlCommand sc = new SqlCommand("select *from book where book_id='" + textBox1.Text + "'", con);
            try
            {
                SqlDataReader sdr = sc.ExecuteReader();

                while (sdr.Read())
                {

                    textBox2.Text = sdr["book_name"].ToString();
                    textBox3.Text = sdr["isbn_no"].ToString();
                    textBox4.Text = sdr["writer"].ToString();
                    textBox5.Text = sdr["author"].ToString();
                    textBox6.Text = sdr["publisher"].ToString();
                    textBox7.Text = sdr["subject_code"].ToString();
                    comboBox3.Text = sdr["edition"].ToString();
                    comboBox1.Text = sdr["catagory"].ToString();
                    comboBox2.Text = sdr["publising_year"].ToString();
                    //dateTimePicker1.Text = sdr["date"].ToString();
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
            string cns = @"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\LMSSystem\LMSSystem\Library.mdf;Integrated Security=True;User Instance=True";

            SqlConnection cn1 = new SqlConnection(cns);
            cn1.Open();
            SqlCommand cmd1 = new SqlCommand("DELETE FROM book WHERE book_id='" + textBox1.Text + "'", cn1);



            try
            {
                cmd1.ExecuteNonQuery();

                MessageBox.Show("delete sucessfully");

            }
            catch
            {
                //Error when save data

                MessageBox.Show("Error to save on database");
                cn1.Close();

            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox7.Text = "";
        }
    }
}
