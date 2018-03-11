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
    public partial class view : Form
    {
        public view()
        {
            InitializeComponent();
        }


        private void view_Load(object sender, EventArgs e)
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
    }
}
