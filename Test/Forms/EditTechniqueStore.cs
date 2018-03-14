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
    public partial class EditTechniqueStore : Form
    {
        public EditTechniqueStore(int id_part)
        {
            InitializeComponent();
            this.id_part = id_part;
        }

        int id_part;
        DataTable dt;
        private void EditTechniqueStore_Load(object sender, EventArgs e)
        {
            dt = SQLFunction.getTechniqueStoreId(id_part);
            label3.Text +=" "+ SQLFunction.getNameModel(Convert.ToInt32(dt.Rows[0][1]));
            textBox1.Text = dt.Rows[0][4].ToString();
            textBox2.Text= dt.Rows[0][3].ToString();
            textBox3.Text = dt.Rows[0][5].ToString();
            dateTimePicker1.Value = (DateTime)dt.Rows[0][2];
            if (dt.Rows[0][6].ToString()=="Для продажи")
            {
                radioButton1.Checked = true;
                    }
            else
            {
                radioButton2.Checked = true;
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

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text=="")|| (textBox2.Text == "")|| (textBox3.Text == ""))
            {
                MessageBox.Show("Все поля должны быть заполнены", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                int id_model = Convert.ToInt32(dt.Rows[0][1]);
                int price = Convert.ToInt32(textBox1.Text);
                int count = Convert.ToInt32(textBox2.Text);
                int ostat = Convert.ToInt32(textBox3.Text);
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
                    bool flag = SQLFunction.updateTechniqueStore(id_part, data, count, price, ostat, priznak);
                    if (flag)
                    {
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Изменение техники на склад невозможно", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
