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
    public partial class EditGroup : Form
    {
        public EditGroup(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        int id;
        DataTable dt;
        private void EditGroup_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Отдел". При необходимости она может быть перемещена или удалена.
            this.отделTableAdapter.Fill(this.testDataSet.Отдел);

            dt = SQLFunction.getGroup(id);
            textBox1.Text = dt.Rows[0][1].ToString();
           comboBox1.SelectedValue= dt.Rows[0][2];

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if ((textBox1.Text == ""))
            {
                MessageBox.Show("Введите название группы техники", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string name = textBox1.Text;
                int id_dep=Convert.ToInt32(comboBox1.SelectedValue);
                bool flag = SQLFunction.updateGroup(id, name, id_dep);
                if (flag)
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Такая группа техники уже существует", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
