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
    public partial class EditFactory : Form
    {
        public EditFactory(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        int id;
        DataTable dt;
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditFactory_Load(object sender, EventArgs e)
        {
            dt = SQLFunction.getFactory(id);
            textBox1.Text = dt.Rows[0][1].ToString();
            textBox3.Text= dt.Rows[0][2].ToString();
            textBox4.Text = dt.Rows[0][3].ToString();
            textBox5.Text = dt.Rows[0][4].ToString();
            textBox2.Text = dt.Rows[0][6].ToString();
            textBox6.Text = dt.Rows[0][7].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == "") || (textBox5.Text == "") || (textBox6.Text == ""))
            {

                MessageBox.Show("Заполните все поля", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {


                string name = textBox1.Text;
                string inn = textBox2.Text;
                string address = textBox3.Text;
                string number = textBox4.Text;
                string email = textBox5.Text;
                string kpp = textBox6.Text;

                {
                    bool flag = SQLFunction.updateFactory(id,name, address, number, email, Autorisation.id, inn, kpp);
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
    }
}
