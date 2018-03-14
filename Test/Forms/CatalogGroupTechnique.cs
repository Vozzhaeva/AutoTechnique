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
    public partial class CatalogGroupTechnique : Form
    {
        public CatalogGroupTechnique()
        {
            InitializeComponent();
        }

        private void CatalogGroupTechnique_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Подгруппа". При необходимости она может быть перемещена или удалена.
            this.подгруппаTableAdapter.Fill(this.testDataSet.Подгруппа);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Группа_техники". При необходимости она может быть перемещена или удалена.
            this.группа_техникиTableAdapter.Fill(this.testDataSet.Группа_техники);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void новуюПодгруппуТехникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ДобавитьПодгруппу().ShowDialog();
            подгруппаTableAdapter.Fill(testDataSet.Подгруппа);
        }

        private void новуюГруппуТехникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ДобавитьГруппу().ShowDialog();
            группа_техникиTableAdapter.Fill(testDataSet.Группа_техники);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.группа_техникиTableAdapter.Update(testDataSet);
            this.подгруппаTableAdapter.Update(testDataSet);
        }

        private void выбраннуюПодгруппуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить выбранную подгруппу техники?", "Закрытие программы", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                 int id_subgroup = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value); 
           bool flag =  SQLFunction.deleteSubgroup(id_subgroup);

            if (!flag)
            {
                MessageBox.Show("Невозможно удалить подгруппу техники, так как в базе имеются модели техники связанные с этой подгруппой", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //  testDataSet.Clear();
            }

            подгруппаTableAdapter.Fill(testDataSet.Подгруппа);
        }

        private void выбраннуюГруппуТехникиToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Вы действительно хотите удалить выбранную группу техники?", "Закрытие программы", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                int id_group = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                bool flag = SQLFunction.deleteGroup(id_group);

                if (!flag)
                {
                    MessageBox.Show("Невозможно удалить группу техники, так как в базе имеются подгруппы техники, связанные с этой группой", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //  testDataSet.Clear();
            }

            группа_техникиTableAdapter.Fill(testDataSet.Группа_техники);
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void группуТехникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            new EditGroup(id).ShowDialog();
            группа_техникиTableAdapter.Fill(testDataSet.Группа_техники);
        }

        private void подгруппуТехникиToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
            new EditSubgroup(id).ShowDialog();
            подгруппаTableAdapter.Fill(testDataSet.Подгруппа);
        }
    }
}
