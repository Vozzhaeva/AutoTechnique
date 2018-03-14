using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.Forms;

namespace Test
{
    public partial class ViewContact : Form
    {
        public ViewContact(int id_Factory)
        {
            InitializeComponent();
            this.id_Factory = id_Factory;
        }

        int id_Factory;
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddContact(id_Factory).ShowDialog();
            this.контактTableAdapter.Fill(this.testDataSet.Контакт, id_Factory); // вставляю в качестве параметра
        }

        private void ViewContact_Load(object sender, EventArgs e)
        {
            this.контактTableAdapter.Fill(this.testDataSet.Контакт, id_Factory); // вставляю в качестве параметра
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
           int num = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
            (new EditContact(id, num)).ShowDialog();
            this.контактTableAdapter.Fill(this.testDataSet.Контакт, id_Factory);
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Вы действительно хотите удалить выбранный контакт?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                int num = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);

                bool flag = SQLFunction.deleteContact(id, num);

                if (!flag)
                {
                    MessageBox.Show("Невозможно удалить выбранный контакт", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            this.контактTableAdapter.Fill(this.testDataSet.Контакт, id_Factory);

        }
    }
}
