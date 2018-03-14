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
    public partial class AddModelStore : Form
    {
        public AddModelStore()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AddTechniqueStore_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Техника". При необходимости она может быть перемещена или удалена.
            this.техникаTableAdapter.Fill(this.testDataSet.Техника);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Подгруппа". При необходимости она может быть перемещена или удалена.
            this.подгруппаTableAdapter.Fill(this.testDataSet.Подгруппа);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Группа_техники". При необходимости она может быть перемещена или удалена.
            this.группа_техникиTableAdapter.Fill(this.testDataSet.Группа_техники);

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if ((textBox1.Text =="" ) || (textBox2.Text == "")||(comboBox3.Text==""))
            {
                MessageBox.Show("Все поля должны быть заполнены", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                int id_model = Convert.ToInt32(comboBox3.SelectedValue);
                int price = Convert.ToInt32(textBox1.Text);
                int count = Convert.ToInt32(textBox2.Text);
                DateTime data = dateTimePicker1.Value; ;
                string priznak = null;
                if (radioButton1.Checked)
                {
                    priznak = "Для продажи";
                }
                if (radioButton2.Checked)
                {
                    priznak = "По договору";
                }
                if ((!radioButton1.Checked) & (!radioButton2.Checked))
                {
                    MessageBox.Show("Укажите признак техники", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool flag = SQLFunction.addTechniqueStore(id_model, data, count, price, count, priznak);
                    if (flag)
                    {
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Добавление техники на склад невозможно", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
