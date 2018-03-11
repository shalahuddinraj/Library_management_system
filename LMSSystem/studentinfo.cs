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
    public partial class studentinfo : Form
    {
        public studentinfo()
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
                    label2.Text = sdr["name"].ToString();
                    label3.Text = sdr["email"].ToString();
                    label4.Text = sdr["dept"].ToString();
                    label5.Text = sdr["personalno"].ToString();
                    label6.Text = sdr["guardianno"].ToString();
                    label7.Text = sdr["gender"].ToString();
                    label8.Text = sdr["date"].ToString();
                }

            }
            catch
            {
                MessageBox.Show("error from database");
                con.Close();
            }
        }
    }
}
