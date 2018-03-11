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
    public partial class issue : Form
    {
        public issue()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string cns = @"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\LMSSystem\LMSSystem\Library.mdf;Integrated Security=True;User Instance=True";

            SqlConnection cn1 = new SqlConnection(cns);
            cn1.Open();
            SqlCommand cmd1 = new SqlCommand("DELETE FROM issue WHERE book_id='" + comboBox4.Text + "'", cn1);



            try
            {
                cmd1.ExecuteNonQuery();

                MessageBox.Show("Avilable Now");

            }
            catch
            {
                //Error when save data

                MessageBox.Show("Error to save ");
                cn1.Close();

            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            DateTime a = dateTimePicker1.Value.Date;
            DateTime b = dateTimePicker2.Value.Date;
            TimeSpan s = b - a;
            int days = s.Days;
            label10.Text = days + ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cns = @"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\LMSSystem\LMSSystem\Library.mdf;Integrated Security=True;User Instance=True";
            SqlConnection con = new SqlConnection(cns);

            con.Open();
            SqlDataAdapter sa = new SqlDataAdapter("select *from issue", con);
            DataTable data1 = new DataTable();
            sa.Fill(data1);
            dataGridView1.DataSource = data1;
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            string cns = @"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\LMSSystem\LMSSystem\Library.mdf;Integrated Security=True;User Instance=True";
            SqlConnection cn1 = new SqlConnection(cns);
            cn1.Open();
            SqlCommand cmd1 = new SqlCommand("INSERT INTO issue (book_id,book_name,student_id,student_name,student_dept,student_phnno,issue_date,today,fine,book_type) VALUES ('" + comboBox4.Text + "', '" + comboBox3.Text + "', '" + textBox3.Text + "','" + textBox4.Text + "', '" + comboBox1.Text + "', '" + textBox5.Text + "', '" + dateTimePicker1.Text + "', '" + dateTimePicker2.Text + "', '" + textBox6.Text + "','" + comboBox2.Text + "')", cn1);


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
            DateTime a = dateTimePicker1.Value.Date;
            DateTime b = dateTimePicker2.Value.Date;
            TimeSpan s = b - a;
            int days = s.Days;
            textBox6.Text = days.ToString();
        }

        private void issue_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\LMSSystem\LMSSystem\Library.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            SqlCommand sc = new SqlCommand("select *from book", con);
            //SqlCommand sc = new SqlCommand("select *from book where book_id='" + comboBox4.Text + "'", con);
            try
            {
                SqlDataReader sdr = sc.ExecuteReader();

                while (sdr.Read())
                {

                    comboBox4.Items.Add(sdr["book_id"]);
                    comboBox3.Items.Add(sdr["book_name"]);
                    
                }

            }
            catch
            {
                MessageBox.Show("NOT ISSUE");
                con.Close();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
