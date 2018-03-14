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
    public partial class ViewStoreAdmin : Form
    {
        public ViewStoreAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ViewStoreAdmin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Склад". При необходимости она может быть перемещена или удалена.
            this.складTableAdapter.Fill(this.testDataSet.Склад);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Склад". При необходимости она может быть перемещена или удалена.
            this.складTableAdapter.Fill(this.testDataSet.Склад);

        }

        private void добавитьТехникуНаСкладToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddModelStore().ShowDialog();
            складTableAdapter.Fill(testDataSet.Склад);
        }

        private void удалитьТехникуСоСкладаToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Вы действительно хотите удалить выбранную технику со склада?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                bool flag = SQLFunction.deleteTechniqueStore(id);

                if (!flag)
                {
                    MessageBox.Show("Невозможно удалить технику со склада", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                складTableAdapter.Fill(testDataSet.Склад);
            }
        }

        private void изменитьИнформациюToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int id_par = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            new EditTechniqueStore(id_par).ShowDialog();
            складTableAdapter.Fill(testDataSet.Склад);
        }
    }
}
