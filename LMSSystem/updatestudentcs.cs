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
    public partial class updatestudentcs : Form
    {
        public updatestudentcs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\LMSSystem\LMSSystem\Library.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            SqlCommand sc = new SqlCommand("select *from studentreg where id='" + textBox1.Text + "'", con);
            try
            {
                SqlDataReader sdr = sc.ExecuteReader();

                while (sdr.Read())
                {

                    textBox2.Text = sdr["name"].ToString();
                    textBox3.Text = sdr["intake"].ToString();
                    textBox4.Text = sdr["dept"].ToString();
                    textBox5.Text = sdr["personalno"].ToString();
                    textBox6.Text = sdr["guardianno"].ToString();
                    textBox7.Text = sdr["gender"].ToString();
                    textBox8.Text = sdr["email"].ToString();
                    textBox9.Text = sdr["adress"].ToString();
                    label10.Text = sdr["date"].ToString();
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
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            
            string cns = @"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\LMSSystem\LMSSystem\Library.mdf;Integrated Security=True;User Instance=True";
            SqlConnection cn1 = new SqlConnection(cns);
            cn1.Open();
            SqlCommand cmd1 = new SqlCommand("update studentreg set personalno='" + textBox5.Text + "',guardianno='" + textBox6.Text + "',email= '" + textBox8.Text + "',adress= '" + textBox9.Text + "' where id='"+textBox1.Text+"'", cn1);


            try
            {
                cmd1.ExecuteNonQuery();

                MessageBox.Show("Successfully Saved.");
            }
            catch
            {
                //Error when save data

                MessageBox.Show("UPDATED");
                cn1.Close();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
        
        }
    }
}
