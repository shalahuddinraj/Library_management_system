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
    public partial class studentreg : Form
    {
        public studentreg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string cns = @"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\LMSSystem\LMSSystem\Library.mdf;Integrated Security=True;User Instance=True";
            SqlConnection cn1 = new SqlConnection(cns);
            cn1.Open();
            SqlCommand cmd1 = new SqlCommand("INSERT INTO studentreg (id,name,intake,dept,personalno,guardianno,gender,email,adress,date) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "','" + comboBox1.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + comboBox2.Text + "', '" + textBox6.Text + "', '" + richTextBox1.Text + "','" + this.dateTimePicker1.Text + "')", cn1);


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

        private void button3_Click(object sender, EventArgs e)
        {
            
            string cns = @"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\LMSSystem\LMSSystem\Library.mdf;Integrated Security=True;User Instance=True";
            SqlConnection con = new SqlConnection(cns);

            con.Open();
            SqlDataAdapter sa = new SqlDataAdapter("select *from studentreg", con);
            DataTable data1 = new DataTable();
            sa.Fill(data1);
            dataGridView1.DataSource = data1;
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            richTextBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string cns = @"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\LMSSystem\LMSSystem\Library.mdf;Integrated Security=True;User Instance=True";

            SqlConnection cn1 = new SqlConnection(cns);
            cn1.Open();
            SqlCommand cmd1 = new SqlCommand("DELETE FROM studentreg WHERE id='" + textBox1.Text + "'", cn1);



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
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
