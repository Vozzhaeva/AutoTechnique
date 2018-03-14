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
    public partial class EditCharact : Form
    {
        public EditCharact(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        int id;
        DataTable dt;
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите название характеристики", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string name = textBox1.Text;
                bool flag = SQLFunction.updateCharact(id, name);
                if (flag)
                {
                    this.Visible = false;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Такая характеристика уже существует", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void EditCharact_Load(object sender, EventArgs e)
        {
            dt = SQLFunction.getCharact(id);
            textBox1.Text = dt.Rows[0][1].ToString();
        }
    }
}
