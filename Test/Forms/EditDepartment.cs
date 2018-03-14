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
    public partial class EditDepartment : Form
    {
        public EditDepartment(int id)
        {
            InitializeComponent();
            this.id = id;
        }
        int id;
        DataTable dt;
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void EditDepartment_Load(object sender, EventArgs e)
        {
            dt = SQLFunction.getDepartment(id);
            textBox1.Text = dt.Rows[0][1].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == ""))
            {
                MessageBox.Show("Введите название отдела", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string name_dep = textBox1.Text;
                bool flag = SQLFunction.updateDepartment(id,name_dep);
                if (flag)
                {
                    this.Visible = false;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Такая отдел уже существует", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
