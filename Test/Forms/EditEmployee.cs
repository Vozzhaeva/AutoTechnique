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
    public partial class EditEmployee : Form
    {
        public EditEmployee(int id)
        {
            InitializeComponent();
            this.id = id;
        }


        int id;
        DataTable dt;
        private void EditEmployee_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Должность". При необходимости она может быть перемещена или удалена.
            this.должностьTableAdapter.Fill(this.testDataSet.Должность);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Отдел". При необходимости она может быть перемещена или удалена.
            this.отделTableAdapter.Fill(this.testDataSet.Отдел);

            dt = SQLFunction.getEmployee(id);
            textBox1.Text = dt.Rows[0][1].ToString();
            textBox2.Text = dt.Rows[0][2].ToString();
            textBox3.Text = dt.Rows[0][3].ToString();
            comboBox1.SelectedValue = dt.Rows[0][4];
            comboBox2.SelectedValue = dt.Rows[0][5];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == ""))
            {
                MessageBox.Show("Все поля должны быть заполнены", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                string fio = textBox1.Text;
                string login = textBox2.Text;
                string pass = textBox3.Text;
                int id_dep = Convert.ToInt32(comboBox1.SelectedValue);
                int id_post = Convert.ToInt32(comboBox2.SelectedValue);

                bool flag = SQLFunction.updateEmployee(id,fio, id_dep, id_post, login, pass);
                if (flag)
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Такой логин уже существует", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
