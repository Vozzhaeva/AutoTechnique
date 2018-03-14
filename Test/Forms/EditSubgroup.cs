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
    public partial class EditSubgroup : Form
    {
        public EditSubgroup(int id)
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

        private void EditSubgroup_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Группа_техники". При необходимости она может быть перемещена или удалена.
            this.группа_техникиTableAdapter.Fill(this.testDataSet.Группа_техники);
            dt = SQLFunction.getSubgroup(id);
            textBox1.Text = dt.Rows[0][1].ToString();
            comboBox1.SelectedValue = dt.Rows[0][2];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == ""))
            {
                MessageBox.Show("Введите название подгруппы техники", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string name = textBox1.Text;
                int id_gr = Convert.ToInt32(comboBox1.SelectedValue);
                bool flag = SQLFunction.updateSubgroup(id, name,id_gr);
                if (flag)
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Такая подгруппа техники уже существует", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
