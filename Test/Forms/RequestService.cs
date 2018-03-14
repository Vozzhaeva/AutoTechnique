using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class RequestService : Form
    {
        public RequestService(int idContract1, string numberContract1)
        {
            InitializeComponent();
            this.idContract1 = idContract1;
            this.numberContract1 = numberContract1;
        }

        int idContract1;
        string numberContract1;
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void ЗаявкаНаТО_Load(object sender, EventArgs e)
        {

            List<int> list = SQLFunction.getModelsContract1(idContract1);
            List<string> listModels = new List<string>();

            for(int i=0; i<list.Count;i++)
            {
                listModels.Add(SQLFunction.getNameModel(list[i]));
            }
            label4.Text = numberContract1;
            comboBox1.DataSource = listModels;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime data1 = dateTimePicker1.Value;
            string number = textBox1.Text;
            int summa1 = Convert.ToInt32(textBox2.Text);
            int summa2 = Convert.ToInt32(textBox3.Text);
            int number2 = Convert.ToInt32(textBox4.Text);
            DateTime data2 = dateTimePicker2.Value;




        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
