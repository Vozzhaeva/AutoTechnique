using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test.Forms
{
    public partial class FormData : Form
    {
        public FormData()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime data1 = dateTimePicker1.Value;
            DateTime data2 = dateTimePicker2.Value;
            new Form1(data1, data2).ShowDialog();
        }

        private void FormData_Load(object sender, EventArgs e)
        {

        }
    }
}
