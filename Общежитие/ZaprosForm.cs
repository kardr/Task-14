﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Общежитие
{
    public partial class ZaprosForm : Form
    {
        public ZaprosForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection sqlconn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + 
                 "Data Source=C:\\Users\\KDroz\\OneDrive\\Рабочий стол\\Практика\\Неделя 5\\Задание 14\\Общежитие\\Общежитие.accdb");
             sqlconn.Open();
             string s = "";
             if (radioButton1.Checked) { s = "SELECT * FROM Students"; }
             if (radioButton2.Checked) { s = "SELECT SNP, Group, Address FROM Students"; }
             if (radioButton3.Checked) { s = "SELECT DISTINCT Group FROM Students"; }
             if (radioButton4.Checked) { s = "SELECT * FROM rooms where Flour=3"; }
             if (radioButton5.Checked) { s = "SELECT * FROM Students where Students.Group like 'ПО%'"; }
             OleDbDataAdapter oda = new OleDbDataAdapter(s, sqlconn);
             DataTable dt = new DataTable();
             oda.Fill(dt);
             dataGridView1.DataSource = dt;
             sqlconn.Close();

           /* OleDbConnection sqlconn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=C:\\Users\\KDroz\\OneDrive\\Рабочий стол\\Практика\\Неделя 5\\Задание 14\\Общежитие\\Общежитие.accdb");
            sqlconn.Open();
            OleDbDataAdapter ole = new OleDbDataAdapter();
            if (radioButton1.Checked) 
                ole =new OleDbDataAdapter("SELECT * FROM Students", sqlconn); 
            if (radioButton2.Checked)
                ole = new OleDbDataAdapter("SELECT SNP, Group, Address FROM Students", sqlconn); 
            if (radioButton3.Checked)
                ole = new OleDbDataAdapter("SELECT DISTINCT Group FROM Students", sqlconn); 
            if (radioButton4.Checked)
                ole = new OleDbDataAdapter("SELECT * FROM rooms where Flour=3", sqlconn); 
            if (radioButton5.Checked)
                ole = new OleDbDataAdapter("SELECT * FROM Students where Students.Group like 'ПО%'", sqlconn); 
            DataTable dt = new DataTable();
            ole.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = dataGridView1.Columns.Count;
            for(int i = 0; i < count; i++)
            {
                dataGridView1.Columns.RemoveAt(0);
            }
        }
    }
}
