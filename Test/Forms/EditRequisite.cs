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
    public partial class EditRequisite : Form
    {
        public EditRequisite(int id, string name)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
        }
        int id;
        string name;
        DataTable dt;
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditRequisite_Load(object sender, EventArgs e)
        {
            dt = SQLFunction.getRequisite(id, name);
            textBox1.Text = name;
            textBox2.Text = dt.Rows[0][2].ToString();
            textBox3.Text = dt.Rows[0][3].ToString();
            textBox4.Text = dt.Rows[0][4].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == ""))
            {
                MessageBox.Show("Все поля должны быть заполнены", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string name_new = textBox1.Text;
                int ras = Convert.ToInt32(textBox2.Text);
                int korr = Convert.ToInt32(textBox3.Text);
                int bik = Convert.ToInt32(textBox4.Text);

                bool flag = SQLFunction.updateRequisite(id, name, ras, korr, bik, name_new);
                if (flag)
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Невозможно изменить реквизиты", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
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

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
