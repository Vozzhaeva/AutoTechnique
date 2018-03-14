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
    public partial class ViewRequisite : Form
    {
        public ViewRequisite(int idFactory)
        {
            InitializeComponent();
            this.idFactory = idFactory;
          

        }
        int idFactory;

        private void Реквизиты_Load(object sender, EventArgs e)
        {


            this.банковские_реквизитыTableAdapter.Fill(this.testDataSet.Банковские_реквизиты, idFactory); // вставляю в качестве параметра


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new AddRequisite( idFactory)).ShowDialog();
            this.банковские_реквизитыTableAdapter.Fill(this.testDataSet.Банковские_реквизиты, idFactory); // вставляю в качестве параметра
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            string name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            (new EditRequisite(id, name)).ShowDialog();
            this.банковские_реквизитыTableAdapter.Fill(this.testDataSet.Банковские_реквизиты, idFactory); // вставляю в качестве параметра
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {



            if (MessageBox.Show("Вы действительно хотите удалить выбранные реквизиты?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            string name = dataGridView1.CurrentRow.Cells[1].Value.ToString();

                bool flag = SQLFunction.deleteRequisite(id,name);

                if (!flag)
                {
                    MessageBox.Show("Невозможно удалить выбранные реквизиты", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            this.банковские_реквизитыTableAdapter.Fill(this.testDataSet.Банковские_реквизиты, idFactory); // вставляю в качестве параметра

        }
    }
}
