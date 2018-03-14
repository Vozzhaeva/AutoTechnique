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
    public partial class RequestTechnique : Form
    {
        public RequestTechnique(List <string> listcheckmodels)
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            this.listcheckmodels = listcheckmodels;

             //снимает выделение с перовй ячейки
        }

        List<string> listcheckmodels;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                label2.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                textBox8.Visible = false;
                textBox9.Visible = false;

                label16.Visible = true;
                label17.Visible = true;
                label18.Visible = true;
                label19.Visible = true;
                label20.Visible = true;
                label21.Visible = true;
                label22.Visible = true;
                label23.Visible = true;
                label24.Visible = true;
                label25.Visible = true;

            }

            if (comboBox1.SelectedIndex == 0)
            {
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                label15.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;

                label16.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
                label23.Visible = false;
                label24.Visible = false;
                label25.Visible = false;
            }

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

        private void ЗаявкаОтКлиента_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.testDataSet.Сотрудник);

            for (int i = 0; i < listcheckmodels.Count; i++) // Цикл добавления строк
            {
                this.dataGridView1.Rows.Add();  // добавление строки 
            }

            for (int i = 0; i < listcheckmodels.Count; i++)
            {
                try
                {
                    this.dataGridView1.Rows[i].Cells[0].Value = listcheckmodels[i];
                    this.dataGridView1.Rows[i].Cells[1].Value = 1;
                    this.dataGridView1.Rows[i].Cells[2].Value=SQLFunction.GetInfoModel2(listcheckmodels[i])[1];

                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                }

                dataGridView1.Rows[0].Cells[0].Selected = false;
            }

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string type = comboBox1.Text;
           
            if(type == "Юридическое лицо")
            {
                
                string status = "Открыта";

                int flag1;
                bool flag2 = true; 

                if ((textBox1.Text!="")&& (textBox2.Text != "") && (textBox3.Text != "") && (textBox4.Text != "") &&(textBox5.Text != "") ||(textBox6.Text != "") && (textBox7.Text != "") &&(textBox8.Text != "") &&(textBox9.Text != "") &&(textBox10.Text != "") &&(textBox11.Text != "") &&(textBox12.Text != "")) {
string address = textBox2.Text;
                string name = textBox1.Text;
                string fio= textBox3.Text;
                string req= textBox4.Text;
                string contact1= textBox5.Text;
                string post1= textBox6.Text;
                string number1= textBox7.Text;
                string email1= textBox8.Text;
                string contact2= textBox12.Text;                
                string post2= textBox11.Text;
                string number2= textBox10.Text;
                string email2= textBox9.Text;

                DateTime data = dateTimePicker1.Value;
                    try
                    {
                        flag1 = SQLFunction.addClient(type, address, name, fio, req, contact1, number1, post1, email1, contact2, number2, post2, email2, data, status);

                        for (int i=0; i < dataGridView1.RowCount; i++)
                    {
                       string nameModel= dataGridView1.Rows[i].Cells[0].Value.ToString();
                       int number = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                       int price = Convert.ToInt32(SQLFunction.GetInfoModel2(listcheckmodels[i])[1]);
                       int id=SQLFunction.getIdModel(nameModel);
                       SQLFunction.addTechnique(id,flag1, Autorisation.id, number,price);
                    }
                   
                    }

                    catch {  this.Visible = false;
                    MessageBox.Show("Ошибка", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     }

                if (flag2)
                {
                        this.Close();
                  //  this.Visible = false;
                    MessageBox.Show("Заявка от клиента успешно добавлена.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    DialogResult = DialogResult.OK;

                       //  this.Hide();  
                        
                   //     (new Заявки()).ShowDialog();
                    }

                }
                else
                {
                   // this.Visible = false;
                    MessageBox.Show("Все поля должны быть заполнены.", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               


            }

            else
            {



                string status = "Открыта";

                int flag1;
                bool flag2 = true; ;

                if ((textBox1.Text != "") && (textBox2.Text != "") && (textBox3.Text != "") && (textBox4.Text != "") && (textBox5.Text != "") || (textBox6.Text != "") && (textBox7.Text != "") && (textBox8.Text != "") && (textBox9.Text != "") && (textBox10.Text != "") && (textBox11.Text != "") && (textBox12.Text != ""))
                {
                string fio = textBox1.Text;
                string email = textBox3.Text;
                string numberph = textBox4.Text;
                string seria = textBox5.Text.Substring(0,4);
                string place = textBox6.Text;
                string sub = textBox7.Text;
                    string address = textBox2.Text;
                    string numerp = textBox12.Text.Substring(0,6);
                string place2 = textBox11.Text;
                string datav = textBox10.Text;

                DateTime data = dateTimePicker1.Value;

                    try
                    {
                        flag1 = SQLFunction.addClient(type, address,fio, seria,numerp,place,place2,numberph,datav,email,sub, data, status);

                        for (int i = 0; i < dataGridView1.RowCount; i++)
                        {
                            string nameModel = dataGridView1.Rows[i].Cells[0].Value.ToString();
                            int number = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                            int price = Convert.ToInt32(SQLFunction.GetInfoModel2(listcheckmodels[i])[1]);
                            int id = SQLFunction.getIdModel(nameModel);
                            SQLFunction.addTechnique(id, flag1, Autorisation.id, number, price);
                        }

                    }

                    catch
                    {
                        this.Visible = false;
                        MessageBox.Show("Ошибка", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (flag2)
                    {
                     
this.Close();
                      //  this.Visible = false;
                      //  this.Hide();
                        MessageBox.Show("Заявка от клиента успешно добавлена.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        DialogResult = DialogResult.OK;
                       
                       
         //   (new Заявки()).ShowDialog();
                    }

                }
                else
                {
                  //  this.Visible = false;
                    MessageBox.Show("Все поля должны быть заполнены.", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }





















            }
          

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
