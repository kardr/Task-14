﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Общежитие
{
    public partial class studentsForm : Form
    {
        public studentsForm()
        {
            InitializeComponent();
        }

        private void studentsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "общежитиеDataSet.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.общежитиеDataSet.Students);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentsTableAdapter.Update(общежитиеDataSet);
        }
    }
}
