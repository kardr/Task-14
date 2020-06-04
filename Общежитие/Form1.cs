using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void комнатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            roomsForm form2 = new roomsForm();
            form2.Text = "Комнаты";
            form2.ShowDialog();
        }

        private void льготыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lgotaForm form3 = new lgotaForm();
            form3.Text = "Льготы";
            form3.ShowDialog();
        }

        private void студентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentsForm form4 = new studentsForm();
            form4.Text = "Студенты";
            form4.ShowDialog();
        }

        private void расселениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RasselenieForm form5 = new RasselenieForm();
            form5.Text = "Расселение";
            form5.ShowDialog();
        }
    }
}
