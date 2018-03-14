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
    public partial class RequestDelivery : Form
    {
        public RequestDelivery(DataTable dt, int idContract1)
        {
            InitializeComponent();
            this.dt = dt;
            this.idContract1 = idContract1;
        }
        DataTable dt;
        DataTable dt_new = new DataTable();
        int idContract1;

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                    e.Handled = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ЗаявкаНаДоставку_Load(object sender, EventArgs e)
        {
            dt_new.Columns.Add("Модель");
            dt_new.Columns.Add("Количество");
            int number = dt.Rows.Count;

            for (int i = 0; i < number; i++)
            {
                dt_new.Rows.Add(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString());

            }

            dataGridView1.DataSource = dt_new;
            dataGridView1.Columns[0].Width = 350;
            dataGridView1.Columns[1].Width = 120;


            DataGridViewColumn column = new DataGridViewButtonColumn();
            column.Width = 100;
            dataGridView1.Columns.Add(column);

            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                this.dataGridView1.Rows[i].Cells[2].Value = "Добавить";
            }





          //  dataGridView1.CurrentCell.Selected = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                int str = e.RowIndex;     //нажата строка
                string name_model = dataGridView1.Rows[str].Cells[0].Value.ToString();     //выбрана техника

                bool flag = false;


                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    if (dataGridView2.Rows[i].Cells[0].Value.ToString() == name_model)
                    {
                        flag = true;
                        break;
                    }
                    else flag = false;

                }
                if ((flag == false)&&(dataGridView2.RowCount==0))
                {

                    dataGridView2.Rows.Add(name_model, 1);    // техника добавлена во второй список
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        List<string> listcheckmodels = new List<string>();

        private void button3_Click(object sender, EventArgs e)
        {
            


            if (dataGridView2.RowCount == 0)
            {
                MessageBox.Show("Добавьте технику в заявку", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if ((textBox1.Text!="") && (textBox2.Text != "") && (textBox3.Text != "") && (textBox4.Text != "") && (textBox5.Text != "")&& (textBox6.Text != "") && (textBox7.Text != "") && (textBox8.Text != ""))
                
                    {
DateTime dataReq = dateTimePicker1.Value;
            int priceDel = Convert.ToInt32(textBox1.Text);
            string city = textBox2.Text;
            string address = textBox3.Text;
            int kilCity = Convert.ToInt32(textBox4.Text);
            int countKil = Convert.ToInt32(textBox5.Text);
            int norma = Convert.ToInt32(textBox6.Text);
            int number1 = Convert.ToInt32(textBox7.Text);
            DateTime data1 = dateTimePicker2.Value;

            int number2 = Convert.ToInt32(textBox8.Text);
            DateTime data2 = dateTimePicker3.Value;
                        int idReqDel = SQLFunction.addReqDel(dataReq, priceDel,idContract1);
                        int idCity = SQLFunction.findIDCity(city);
                        if(idCity==-1)   //если города нет в справочник, то добавляем
                        {
                            idCity=SQLFunction.addCity(city,kilCity);

                        }


                    bool flag= SQLFunction.addRout(idReqDel, SQLFunction.getIdModel(dataGridView2.Rows[0].Cells[0].Value.ToString() )           , idCity,address, Convert.ToInt32(dataGridView2.Rows[0].Cells[1].Value), countKil,norma,number1,data1,number2,data2,Autorisation.id);
                    if(flag==true)
                    {
                        MessageBox.Show("Заявка на доставку успешно добавлена.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        SQLFunction.updatePriznakDelivery("есть",idContract1, SQLFunction.getIdModel(dataGridView2.Rows[0].Cells[0].Value.ToString()));

                        DialogResult = DialogResult.OK;
                    }

                    }
                

                else { MessageBox.Show("Все поля должны быть заполнены.", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error); }


            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
