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
    public partial class EditContact : Form
    {
        public EditContact(int id, int num)
        {
            InitializeComponent();
            this.id = id;
            this.num = num;
        }

        int id;
          int num;
        DataTable dt;
        private void EditContact_Load(object sender, EventArgs e)
        {
            dt = SQLFunction.getContact(id, num);
            textBox1.Text = dt.Rows[0][2].ToString();
            textBox2.Text = dt.Rows[0][3].ToString();
            textBox3.Text = dt.Rows[0][4].ToString();
            textBox4.Text = dt.Rows[0][5].ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == ""))
            {
                MessageBox.Show("Все поля должны быть заполнены", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string contact = textBox1.Text;
                string post = textBox2.Text;
                string number = textBox3.Text;
                string email = textBox4.Text;


                bool flag = SQLFunction.updateContact(id, num, contact, post, number, email);
                if (flag)
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Невозможно изменить контакт", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
