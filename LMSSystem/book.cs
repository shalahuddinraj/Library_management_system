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
    public partial class book : Form
    {
        public book()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cns = @"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\LMSSystem\LMSSystem\Library.mdf;Integrated Security=True;User Instance=True";
            SqlConnection cn1 = new SqlConnection(cns);
            cn1.Open();
            SqlCommand cmd1 = new SqlCommand("INSERT INTO book (book_id,book_name,isbn_no,writer,author,publisher,catagory,publising_year,edition,subject_code,date) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "','" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "', '" + comboBox1.Text + "', '" + comboBox2.Text + "', '" + comboBox3.Text + "','" + textBox7.Text + "','" + dateTimePicker1.Text + "')", cn1);


            try
            {
                cmd1.ExecuteNonQuery();

                MessageBox.Show("Successfully Saved.");
            }
            catch
            {
                //Error when save data

                MessageBox.Show("Error to save on database");
                cn1.Close();
            }
          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
