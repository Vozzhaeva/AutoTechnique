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
    public partial class AddFactory : Form
    {
        public AddFactory()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {





            if ((textBox1.Text == "")|| (textBox2.Text == "")|| (textBox3.Text == "")|| (textBox4.Text == "")|| (textBox5.Text == "")|| (textBox6.Text == ""))
            {

                MessageBox.Show("Заполните все поля", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else{ 


           string name = textBox1.Text;
           string inn = textBox2.Text;
           string address = textBox3.Text; 
           string number = textBox4.Text;
           string email = textBox5.Text;
           string kpp = textBox6.Text;

            {
                bool flag = SQLFunction.addFactory(name, address, number, email, Autorisation.id, inn,kpp);
                if (flag)
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {

                    MessageBox.Show("Такой завод-изготовитель уже существует", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;


        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void AddFactory_Load(object sender, EventArgs e)
        {

        }
    }
}
