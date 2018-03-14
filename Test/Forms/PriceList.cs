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
    public partial class PriceList : Form
    {
        public PriceList()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ПрайсЛистcs_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Прайс_лист". При необходимости она может быть перемещена или удалена.
            this.прайс_листTableAdapter.Fill(this.testDataSet.Прайс_лист);
           

            //DataTable table = SQLFunction.getPriceList();

            //dataGridView1.DataSource = table;
            //dataGridView1.Refresh();

            //dataGridView1.Columns[0].Width = 150;
            //dataGridView1.Columns[0].HeaderText = ("Дата");

            //dataGridView1.Columns[1].Width = 450;
            //dataGridView1.Columns[1].HeaderText = ("Модель");

            //dataGridView1.Columns[2].Width = 190;
            //dataGridView1.Columns[2].HeaderText = ("Стоимость, руб.");

            //dataGridView1.Columns[3].Width = 220;
            //dataGridView1.Columns[3].HeaderText = ("Срок поставки, дней");



        }

        private void добавитьМодельВПрайслистToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddModelPriceList().ShowDialog();
            this.прайс_листTableAdapter.Fill(this.testDataSet.Прайс_лист);
        }

        private void удалитьМодельИзПрайслистаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить выбранную технику из прайс-листа?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                int id_model = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
                DateTime data = (DateTime) dataGridView1.CurrentRow.Cells[0].Value;
                bool flag = SQLFunction.deleteTechniquePriceList(data, id_model);

                if (!flag)
                {
                    MessageBox.Show("Удаление невозможно", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }

            this.прайс_листTableAdapter.Fill(this.testDataSet.Прайс_лист);

        }

        private void изменитьИнформациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id_model = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
            DateTime data = (DateTime)dataGridView1.CurrentRow.Cells[0].Value;
            new EditModelPriceList(data, id_model).ShowDialog();
            this.прайс_листTableAdapter.Fill(this.testDataSet.Прайс_лист);
        }
    }
}
