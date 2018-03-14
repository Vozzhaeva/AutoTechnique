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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if ((textBox1.Text=="")|| (textBox2.Text == "")|| (textBox3.Text == ""))
            {
                MessageBox.Show("Все поля должны быть заполнены", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else {
            string fio =textBox1.Text;
            string login = textBox2.Text;
            string pass = textBox3.Text;
            int id_dep = Convert.ToInt32(comboBox1.SelectedValue);
            int id_post = Convert.ToInt32(comboBox2.SelectedValue);
            string priznak = "В фирме";

            bool flag = SQLFunction.addEmployee(fio, id_dep, id_post,login,pass,priznak);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Должность". При необходимости она может быть перемещена или удалена.
            this.должностьTableAdapter.Fill(this.testDataSet.Должность);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Отдел". При необходимости она может быть перемещена или удалена.
            this.отделTableAdapter.Fill(this.testDataSet.Отдел);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
