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
    public partial class ДобавитьПодгруппу : Form
    {
        public ДобавитьПодгруппу()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ДобавитьПодгруппу_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Группа_техники". При необходимости она может быть перемещена или удалена.
            this.группа_техникиTableAdapter.Fill(this.testDataSet.Группа_техники);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id_group = 0;
            string name_subgroup = textBox1.Text;

            if (comboBox1.Text != "")
                id_group = comboBox1.SelectedIndex + 1;
            else MessageBox.Show("Выберите группу техники", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if ((textBox1.Text == ""))
            {
                MessageBox.Show("Введите название подгруппы техники", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool flag = SQLFunction.addSubgroup(name_subgroup, id_group);
                if (flag)
                {
                    this.Visible = false;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    this.Visible = false;
                    MessageBox.Show("Такая подгруппа техники уже существует", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
             //   (new Техника()).ShowDialog();
                //Обработка: проверка уникальности логина(подключение к БД) 
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
