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
    public partial class EditPost : Form
    {
        public EditPost(int id)
        {
            InitializeComponent();
            this.id = id;
        }
        int id;
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        DataTable dt;
        private void EditPost_Load(object sender, EventArgs e)
        {
            dt = SQLFunction.getPost(id);
            textBox1.Text = dt.Rows[0][1].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == ""))
            {
                MessageBox.Show("Введите название должности", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string name_post= textBox1.Text;
                bool flag = SQLFunction.updatePost(id, name_post);
                if (flag)
                {
                    this.Visible = false;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Такая должность уже существует", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
