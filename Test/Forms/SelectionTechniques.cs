using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class SelectionTechniques : Form
    {
            
        public SelectionTechniques()
        {
            InitializeComponent();
            dataGridView1.DataSource = SQLFunction.AllModel();
            dataGridView1.Columns[0].Width = 590;
            dataGridView1.Columns[0].HeaderText = ("Наименование модели");



            DataGridViewColumn column = new DataGridViewButtonColumn();
           // DataGridViewColumn column = new DataGridViewCheckBoxColumn();
            column.Width = 120;
            column.DataPropertyName = "Добавить";
            column.Name = "Добавить";
            column.HeaderText = "Добавить";
          //  column.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(column);



          


        }
    private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите прервать процедуру оформления заявки?", "Подтверждение закрытия", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                
            this.Close();
          //  this.Hide();
          //  (new Заявки()).ShowDialog();
            }



        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(textBox1.Text);
            if ((value >= 0) & (value <= trackBar1.Maximum))
                {
                trackBar1.Value = value; }
            else { textBox1.Text = Convert.ToString(trackBar1.Maximum);
                trackBar1.Value = trackBar1.Maximum;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[0,1,2,3,4,5,6,7,8,9,\b]");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            textBox2.Text = trackBar2.Value.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(textBox2.Text);
            if ((value >= 0) & (value <= trackBar2.Maximum))
            {
                trackBar2.Value = value;
            }
            else
            {
                textBox2.Text = Convert.ToString(trackBar2.Maximum);
                trackBar2.Value = trackBar2.Maximum;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[0,1,2,3,4,5,6,7,8,9,\b]");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int price = Convert.ToInt32(textBox1.Text);
            int day = Convert.ToInt32(textBox2.Text);
            string name_group = comboBox1.Text;
            int id_group = comboBox1.SelectedIndex+1;
          
            dataGridView1.DataSource = SQLFunction.FindModel(id_group,price, day);
            dataGridView1.Columns[1].Width = 590;
            dataGridView1.Columns[1].HeaderText = ("Наименование модели");

            dataGridView1.Columns[0].Width = 120;
            dataGridView1.Columns[0].HeaderText = ("Добавить");

            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                this.dataGridView1.Rows[i].Cells[0].Value = "Добавить";
            }


           



        }

        private void ПодборТехники_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Подгруппа". При необходимости она может быть перемещена или удалена.
            this.подгруппаTableAdapter.Fill(this.testDataSet.Подгруппа);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Группа_техники". При необходимости она может быть перемещена или удалена.
            this.группа_техникиTableAdapter.Fill(this.testDataSet.Группа_техники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Группа_техники". При необходимости она может быть перемещена или удалена.
            this.группа_техникиTableAdapter.Fill(this.testDataSet.Группа_техники);
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                this.dataGridView1.Rows[i].Cells[0].Value = "Добавить";
            }


            
            //DataGridViewColumn column_name = new DataGridViewColumn();
            //column_name.Width = 690;
            //column_name.HeaderText = "Наименование техники";
            //dataGridView2.Columns.Add(column_name);


            //DataGridViewColumn column_delete = new DataGridViewButtonColumn();
            //column_delete.Width = 100;
            //column_delete.DataPropertyName = "Удалить";
            //column_delete.Name = "Удалить";
            //column_delete.HeaderText = "Удалить";
            //dataGridView2.Columns.Add(column_delete);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0)
            {
            int str = e.RowIndex;     //нажата строка
            string name_model = dataGridView1.Rows[str].Cells[1].Value.ToString();     //выбрана техника

                bool flag=false;


                for(int i=0; i<dataGridView2.RowCount; i++)
                {
                    if (dataGridView2.Rows[i].Cells[0].Value.ToString() == name_model)
                    {
                        flag = true;
                        break;
                    }
                    else flag = false;
               
                }
                if (flag == false)
                {
                    dataGridView2.Rows.Add(name_model, 1);    // техника добавлена во второй список
                }            
 }
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

           int index = dataGridView1.CurrentCell.RowIndex;
           string name_model=dataGridView1.Rows[index].Cells[1].Value.ToString();
          (new InformationModel(name_model)).ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Layout(object sender, LayoutEventArgs e)
        {


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        List<string> listcheckmodels = new List<string>();
        private void button3_Click(object sender, EventArgs e)
        {
            if(dataGridView2.RowCount==0)
            {
                MessageBox.Show("Добавьте технику в заявку", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { 
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                listcheckmodels.Add( dataGridView2.Rows[i].Cells[0].Value.ToString());
            }

            this.Close();
            (new RequestTechnique(listcheckmodels)).ShowDialog();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
 
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {


            dataGridView1.DataSource = SQLFunction.AllModel();
            dataGridView1.Columns[1].Width = 590;
            dataGridView1.Columns[1].HeaderText = ("Наименование модели");

            dataGridView1.Columns[0].Width = 120;
            dataGridView1.Columns[0].HeaderText = ("Добавить");

            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                this.dataGridView1.Rows[i].Cells[0].Value = "Добавить";
            }


        }
    }
}

