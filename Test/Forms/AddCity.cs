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
    public partial class AddCity : Form
    {
        public AddCity()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           


            if ((textBox1.Text == "")|| (textBox2.Text == ""))
            {
                MessageBox.Show("Все поля должны быть заполнены", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string name_city = textBox1.Text;
                int kil = Convert.ToInt32(textBox2.Text);
                bool flag = SQLFunction.addCity1(name_city, kil);
                if (flag)
                {
                    this.Visible = false;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                 MessageBox.Show("Такой город уже существует", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
             
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
