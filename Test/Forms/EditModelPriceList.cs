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
    public partial class EditModelPriceList : Form
    {
        public EditModelPriceList(DateTime data, int id_model)
        {
            InitializeComponent();
            this.data = data;
            this.id_model = id_model;
        }
        DateTime data;
        int id_model;
        DataTable dt;
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditModelPriceList_Load(object sender, EventArgs e)
        {

            dt = SQLFunction.getTechniquePriceList(data, id_model);
            label3.Text += " " + SQLFunction.getNameModel(Convert.ToInt32(dt.Rows[0][1]));
            label6.Text += "" + dt.Rows[0][0].ToString().Substring(0,10);
            textBox1.Text = dt.Rows[0][2].ToString();
            textBox2.Text = dt.Rows[0][3].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == ""))
            {
                MessageBox.Show("Все поля должны быть заполнены", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                int price = Convert.ToInt32(textBox1.Text);
                int crok = Convert.ToInt32(textBox2.Text);


                bool flag = SQLFunction.updateTechniquePriceList(data, id_model, price, crok);
                if (flag)
                {

                    DialogResult = DialogResult.OK;
                }
                else
                {

                    MessageBox.Show("Изменение невозможно", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

