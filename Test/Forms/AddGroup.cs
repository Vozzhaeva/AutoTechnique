using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class ДобавитьГруппу : Form
    {
        public ДобавитьГруппу()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addModel_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Отдел". При необходимости она может быть перемещена или удалена.
            this.отделTableAdapter.Fill(this.testDataSet.Отдел);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if ((textBox1.Text == ""))
            {
                MessageBox.Show("Введите название группы техники", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id_dept =Convert.ToInt32( comboBox1.SelectedValue);
                string name_group = textBox1.Text;
                bool flag = SQLFunction.addGroup(name_group,id_dept);
                if (flag)
                {
                    this.Visible = false;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    //this.Visible = false;
                    MessageBox.Show("Такая группа техники уже существует", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              //  (new Техника()).ShowDialog();
                //Обработка: проверка уникальности логина(подключение к БД) 
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
