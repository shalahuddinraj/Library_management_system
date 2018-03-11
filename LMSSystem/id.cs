﻿using System;
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
    public partial class id : Form
    {
        public id()
        {
            InitializeComponent();
        }
        //global variables 
        SqlConnection sqlconnection;
        SqlCommand sqlcommand;
        string ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\LMSSystem\LMSSystem\Library.mdf;Integrated Security=True;User Instance=True";
        string Query;
        DataSet dataset;
        DataTable datatable;
        SqlDataAdapter sqladapter; 
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textchanged event of texbox when user enter a word in the textbox then through this dataview object string format it will filter and attached the filter result in to the datagridview 
            DataView DV = new DataView(datatable);
            DV.RowFilter = string.Format("catagory LIKE '%{0}%'", textBox1.Text);
            dataGridView1.DataSource = DV; 
        }

        private void id_Load(object sender, EventArgs e)
        {
            sqlconnection = new SqlConnection(ConnectionString);
            Query = "select * from book";
            sqlcommand = new SqlCommand(Query, sqlconnection);
            sqladapter = new SqlDataAdapter();
            datatable = new DataTable();
            sqladapter.SelectCommand = sqlcommand;
            sqladapter.Fill(datatable);
            dataGridView1.DataSource = datatable; 
        }
    }
}
