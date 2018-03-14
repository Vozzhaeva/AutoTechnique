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
    public partial class CatalogCity : Form
    {
        public CatalogCity()
        {
            InitializeComponent();
        }

        private void CatalogCity_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Город". При необходимости она может быть перемещена или удалена.
            this.городTableAdapter.Fill(this.testDataSet.Город);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void добавитьНовыйГородToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddCity().ShowDialog();
            городTableAdapter.Fill(this.testDataSet.Город);

        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Вы действительно хотите удалить выбранный город?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                bool flag = SQLFunction.deleteCity(id);

                if (!flag)
                {
                    MessageBox.Show("Невозможно удалить выбранный город, так как с ним есть связанные маршруты", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //  testDataSet.Clear();
            }

            городTableAdapter.Fill(testDataSet.Город);
        }

        private void изменитьИнформациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            new EditCity(id).ShowDialog();
            городTableAdapter.Fill(testDataSet.Город);
        }
    }
}
