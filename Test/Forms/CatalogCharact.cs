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
    public partial class CatalogUnits : Form
    {
        public CatalogUnits()
        {
            InitializeComponent();
        }

        private void CatalogUnits_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Техническая_характеристика". При необходимости она может быть перемещена или удалена.
            this.техническая_характеристикаTableAdapter.Fill(this.testDataSet.Техническая_характеристика);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void добавитьТехническуюХарактеристикуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddCharact().ShowDialog();
            техническая_характеристикаTableAdapter.Fill(this.testDataSet.Техническая_характеристика);

        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            new EditCharact(id).ShowDialog();
            техническая_характеристикаTableAdapter.Fill(this.testDataSet.Техническая_характеристика);
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить выбранную характеристику?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                bool flag = SQLFunction.deleteCharact(id);

                if (!flag)
                {
                    MessageBox.Show("Невозможно удалить техническую характеристику, так как с ней связаны модели техники", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                техническая_характеристикаTableAdapter.Fill(this.testDataSet.Техническая_характеристика);
            }
        }
    }
}
