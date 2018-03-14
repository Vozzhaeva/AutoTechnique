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
    public partial class EditCity : Form
    {
        public EditCity(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        int id;
        DataTable dt;
        private void EditCity_Load(object sender, EventArgs e)
        {
            dt = SQLFunction.getCity(id);
            textBox1.Text = dt.Rows[0][1].ToString();
            textBox2.Text = dt.Rows[0][2].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if ((textBox1.Text == "") || (textBox2.Text == ""))
            {
                MessageBox.Show("Все поля должны быть заполнены", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string name_city = textBox1.Text;
                int kil = Convert.ToInt32(textBox2.Text);
                bool flag = SQLFunction.updateCity(id,name_city, kil);
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
