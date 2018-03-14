using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class СatalogTechniques : Form
    {
        public СatalogTechniques()
        {
            InitializeComponent();
            this.группа_техникиTableAdapter.Update(testDataSet);
            this.подгруппаTableAdapter.Update(testDataSet);
            this.техникаTableAdapter.Update(testDataSet);
        }

        private void Техника_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Техника". При необходимости она может быть перемещена или удалена.
            this.техникаTableAdapter.Fill(this.testDataSet.Техника);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Техника". При необходимости она может быть перемещена или удалена.
            this.техникаTableAdapter.Fill(this.testDataSet.Техника);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Подгруппа". При необходимости она может быть перемещена или удалена.
            this.подгруппаTableAdapter.Fill(this.testDataSet.Подгруппа);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Группа_техники". При необходимости она может быть перемещена или удалена.
            this.группа_техникиTableAdapter.Fill(this.testDataSet.Группа_техники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Техника". При необходимости она может быть перемещена или удалена.
            this.техникаTableAdapter.Fill(this.testDataSet.Техника);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Подгруппа". При необходимости она может быть перемещена или удалена.
            this.подгруппаTableAdapter.Fill(this.testDataSet.Подгруппа);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Группа_техники". При необходимости она может быть перемещена или удалена.
            this.группа_техникиTableAdapter.Fill(this.testDataSet.Группа_техники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Техника". При необходимости она может быть перемещена или удалена.
            this.техникаTableAdapter.Fill(this.testDataSet.Техника);
            // дите TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Подгруппа". При необходимости она может быть перемещена или удалена.
            this.подгруппаTableAdapter.Fill(this.testDataSet.Подгруппа);

        }

        private void Обновить_Click(object sender, EventArgs e)
        {
            this.группа_техникиTableAdapter.Update(testDataSet);
            this.подгруппаTableAdapter.Update(testDataSet);
            this.техникаTableAdapter.Update(testDataSet);
        }

        private void Выйти_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void новуюГруппуТехникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new ДобавитьГруппу()).ShowDialog();
            группа_техникиTableAdapter.Fill(testDataSet.Группа_техники);
            // this.Close();

        }

        private void новуюПодгруппуТехникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new ДобавитьПодгруппу()).ShowDialog();
            //this.Close();
            подгруппаTableAdapter.Fill(testDataSet.Подгруппа);
        }

        private void нToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить выбранную модель техники?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                int id_model =  Convert.ToInt32(dataGridView3.CurrentRow.Cells[0].Value);
                bool flag = SQLFunction.deleteModel(id_model);

                if (!flag)
                {
                    MessageBox.Show("Невозможно удалить выбранную модель техники, так как с этой моделью присутствует в прайс-листе", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


            техникаTableAdapter.Fill(testDataSet.Техника);


        }

        private void выбраннуюМодельТехникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        //private void fillByToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.техникаTableAdapter.FillBy(this.testDataSet.Техника);
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.техникаTableAdapter.Fill(this.testDataSet.Техника);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.техникаTableAdapter.Fill(this.testDataSet.Техника);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void bindingSource2_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string name_model = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            (new InformationModel(name_model)).ShowDialog();

        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new AddTechnique()).ShowDialog();
            // this.Close();
            техникаTableAdapter.Fill(testDataSet.Техника);
        }
    }
}
