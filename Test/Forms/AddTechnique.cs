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
    public partial class AddTechnique : Form
    {
        public AddTechnique()
        {
            InitializeComponent();
        }

        private void ДобавитьМодель_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Техническая_характеристика". При необходимости она может быть перемещена или удалена.
            this.техническая_характеристикаTableAdapter.Fill(this.testDataSet.Техническая_характеристика);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.testDataSet.Сотрудник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Завод_изготовитель". При необходимости она может быть перемещена или удалена.
            this.завод_изготовительTableAdapter.Fill(this.testDataSet.Завод_изготовитель);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Подгруппа". При необходимости она может быть перемещена или удалена.
            this.подгруппаTableAdapter.Fill(this.testDataSet.Подгруппа);

        }

        private void button1_Click(object sender, EventArgs e)
        {


            int count_er = 0;
            int id_model=0;
            if( textBox1.Text=="")
            {
                MessageBox.Show("Все поля должны быть заполнены", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                string name_model = textBox1.Text;
                int  id_subgroup = Convert.ToInt32(comboBox1.SelectedValue);
                int id_factory = Convert.ToInt32(comboBox2.SelectedValue);

                bool flag = SQLFunction.addModel(name_model, id_subgroup,id_factory, Autorisation.id );
                if (flag)
                {



                    for (int i = 0; i < dataGridView1.ColumnCount - 1; i++)
                    {


                        if ((dataGridView1.Rows[i].Cells[0].Value == null) || (dataGridView1.Rows[i].Cells[1].Value == null)) {
                            count_er++;
                            id_model = SQLFunction.getIdModel(name_model);
                            SQLFunction.deleteModel(id_model);
                            MessageBox.Show("Все поля технических характеристик должны быть заполнены ", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                        else
                        {

                            string name = dataGridView1.Rows[i].Cells[0].Value.ToString();
                            string value = dataGridView1.Rows[i].Cells[1].Value.ToString();
                            int id_character = SQLFunction.getIDCharacter(name);
                             id_model = SQLFunction.getIdModel(name_model);

                            bool flag1 = SQLFunction.addCharacter(id_model, id_character, value);


                            if (!flag)
                            {
                                count_er++;
                                id_model = SQLFunction.getIdModel(name_model);
                                SQLFunction.deleteModel(id_model);
                                MessageBox.Show("Невозможно добавить техническую характеристику " + name, "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        
                    }

                }
                else
                {
                    count_er++;
                    MessageBox.Show("Такая модель техники уже существует", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }





                if (count_er == 0) { DialogResult = DialogResult.OK; }
                    }


                
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
