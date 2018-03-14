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
    public partial class CatalogFactory : Form
    {
        public CatalogFactory()
        {
            InitializeComponent();
            this.завод_изготовительTableAdapter.Update(testDataSet);
          
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Заводы_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Завод_изготовитель". При необходимости она может быть перемещена или удалена.
            this.завод_изготовительTableAdapter.Fill(this.testDataSet.Завод_изготовитель);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Завод_изготовитель". При необходимости она может быть перемещена или удалена.
            this.завод_изготовительTableAdapter.Fill(this.testDataSet.Завод_изготовитель);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Завод_изготовитель". При необходимости она может быть перемещена или удалена.
            this.завод_изготовительTableAdapter.Fill(this.testDataSet.Завод_изготовитель);
         //   dataGridView1.Rows[0].Cells[1].Selected = false;   //снимает выделение с перовй ячейки

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.завод_изготовительTableAdapter.Update(testDataSet);
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new AddFactory()).ShowDialog();
            завод_изготовительTableAdapter.Fill(testDataSet.Завод_изготовитель);
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Вы действительно хотите удалить выбранный завод-изготовитель?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                bool flag = SQLFunction.deleteFactory(id);

                if (!flag)
                {
                    MessageBox.Show("Невозможно удалить выбранный завод-изготовитель, так как с ним связана поставляемая техника", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
           
            }
            завод_изготовительTableAdapter.Fill(testDataSet.Завод_изготовитель);



            dataGridView1.Rows[0].Cells[0].Selected = false;   //снимает выделение с перовй ячейки

        }

        private void просмотретьРеквизитыToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //    string name = dataGridView1.CurrentCell.Value.ToString();
            //   int id = SQLFunction.getIDFactory(name);
            //   if (idFactory == -1) {
            //      MessageBox.Show("Для просмотра реквизитов выберите завод-изготовитель из списка.", "Ошибка просмотра", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //  }
            //  else {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            (new ViewRequisite(id)).ShowDialog();// }


           

                завод_изготовительTableAdapter.Fill(testDataSet.Завод_изготовитель);

        }

      //  int idFactory=-1;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       //    int   str = e.RowIndex;     //нажата строка
       //     idFactory = Convert.ToInt32(dataGridView1.Rows[str].Cells[0].Value);     
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)  //выделение всей строки по щелчку
        {
         //   int index = dataGridView1.CurrentCell.RowIndex;
         //   dataGridView1.Rows[index].Selected = true;
          //  dgv_leftPanel.RowsDefaultCellStyle.SelectionForeColor = Color.Red;
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            new EditFactory(id).ShowDialog();
            завод_изготовительTableAdapter.Fill(testDataSet.Завод_изготовитель);
        }

        private void просмотретьКонтактыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            new ViewContact(id).ShowDialog();
            завод_изготовительTableAdapter.Fill(testDataSet.Завод_изготовитель);
        }
    }
}
