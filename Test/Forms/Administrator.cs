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
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }

        private void АдминистраторБД_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.testDataSet.Сотрудник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.testDataSet.Сотрудник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Должность". При необходимости она может быть перемещена или удалена.
            this.должностьTableAdapter.Fill(this.testDataSet.Должность);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Должность". При необходимости она может быть перемещена или удалена.
            this.должностьTableAdapter.Fill(this.testDataSet.Должность);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Должность". При необходимости она может быть перемещена или удалена.
            this.должностьTableAdapter.Fill(this.testDataSet.Должность);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Должность". При необходимости она может быть перемещена или удалена.
            this.должностьTableAdapter.Fill(this.testDataSet.Должность);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.testDataSet.Сотрудник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Отдел". При необходимости она может быть перемещена или удалена.
            this.отделTableAdapter.Fill(this.testDataSet.Отдел);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.testDataSet.Сотрудник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Должность". При необходимости она может быть перемещена или удалена.
            this.должностьTableAdapter.Fill(this.testDataSet.Должность);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.testDataSet.Сотрудник);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите закрыть программу?", "Закрытие программы", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void fKСотрудникIDдо173876EABindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void новыйОтелToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            new CatalogGroupTechnique().ShowDialog();
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            new CatalogGroupTechnique().ShowDialog();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Вы действительно хотите удалить выбранный отдел?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridView3.CurrentRow.Cells[0].Value);
                bool flag = SQLFunction.deleteDepartment(id);

                if (!flag)
                {
                    MessageBox.Show("Невозможно удалить выбранный отдел, так как в нем имеются действующие сотрудники", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //  testDataSet.Clear();
            }

            отделTableAdapter.Fill(testDataSet.Отдел);
        }

        private void toolStripMenuItem27_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить выбранную должность?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                bool flag = SQLFunction.deletePost(id);

                if (!flag)
                {
                    MessageBox.Show("Невозможно удалить выбранную должноcть, так как на этой должности в фирме имеются сотрудники", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //  testDataSet.Clear();
            }

           должностьTableAdapter.Fill(testDataSet.Должность);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            new AddDepartment().ShowDialog();
            отделTableAdapter.Fill(testDataSet.Отдел);
        }

        private void toolStripMenuItem25_Click(object sender, EventArgs e)
        {
          
        }

        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {
            new Add().ShowDialog();
            сотрудникTableAdapter.Fill(testDataSet.Сотрудник);
        }

        private void toolStripMenuItem26_Click(object sender, EventArgs e)
        {

            new AddPost().ShowDialog();
            должностьTableAdapter.Fill(testDataSet.Должность);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ViewStoreAdmin().ShowDialog();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            new Add().ShowDialog();
            сотрудникTableAdapter.Fill(testDataSet.Сотрудник);
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить сотрудника из системы?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);

                if (id == 8)
                {
                    MessageBox.Show("Невозможно удалить главного администратора", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool flag = SQLFunction.deleteEmployee(id);
                }
}

            сотрудникTableAdapter.Fill(testDataSet.Сотрудник);
        }

        private void изменитьИнформациюОСотрудникеToolStripMenuItem_Click(object sender, EventArgs e)
        {


            int id = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
            new EditEmployee(id).ShowDialog();
        

        сотрудникTableAdapter.Fill(testDataSet.Сотрудник);
        }

        private void изменитьИнфорациюОбОтделеToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(dataGridView3.CurrentRow.Cells[0].Value);
            new EditDepartment(id).ShowDialog();
            отделTableAdapter.Fill(testDataSet.Отдел);
        }

        private void изменитьИнформациюОДолжностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            new EditPost(id).ShowDialog();
            должностьTableAdapter.Fill(testDataSet.Должность);
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            new ViewStoreAdmin().ShowDialog();
        }

        private void изменитьИнформациюОСотрудникеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView4.CurrentRow.Cells[0].Value);
            new EditEmployee(id).ShowDialog();

            сотрудникTableAdapter.Fill(testDataSet.Сотрудник);
        }

        private void toolStripMenuItem24_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить сотрудника из системы?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridView4.CurrentRow.Cells[0].Value);

                if (id == 8)
                {
                    MessageBox.Show("Невозможно удалить главного администратора", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool flag = SQLFunction.deleteEmployee(id);
                }
            }

            сотрудникTableAdapter.Fill(testDataSet.Сотрудник);
        }

        private void toolStripMenuItem29_Click(object sender, EventArgs e)
        {
            new CatalogCity().ShowDialog();
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            new CatalogCity().ShowDialog();
        }

        private void toolStripMenuItem30_Click(object sender, EventArgs e)
        {
            new CatalogUnits().ShowDialog();
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            new CatalogUnits().ShowDialog();
        }

       
    }
}
