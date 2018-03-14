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
    public partial class ContractClient : Form
    {
        public ContractClient(int idClient, int id)
        {
            Opacity = 0;

            InitializeComponent();
            this.idClient = idClient;
            this.id = id;
        }
        int id;
        int idClient;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

            DataTable dt_new = new DataTable();
        private void Договор_Load(object sender, EventArgs e)
        {

            DataTable dt = SQLFunction.findClient(idClient);
            string type = dt.Rows[0][1].ToString();
            string address = dt.Rows[0][2].ToString();

            textBox3.Text = type;
            textBox15.Text = type;

            if (type == "Юридическое лицо")
            {             
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
                label26.Visible = true;
                    label27.Visible = true;
                    textBox8.Visible = true;
                    textBox9.Visible = true;
                

                DataTable dt1 = SQLFunction.findClient1(idClient);


                textBox4.Text= dt1.Rows[0][1].ToString();
                textBox14.Text=dt1.Rows[0][2].ToString();
                textBox13.Text= dt1.Rows[0][3].ToString();

                textBox5.Text=dt1.Rows[0][4].ToString();
                textBox7.Text=dt1.Rows[0][5].ToString();
                textBox6.Text = dt1.Rows[0][6].ToString();
                textBox8.Text = dt1.Rows[0][7].ToString();
                textBox12.Text = dt1.Rows[0][8].ToString();
                textBox10.Text = dt1.Rows[0][9].ToString();
                textBox11.Text = dt1.Rows[0][10].ToString();
                textBox9.Text = dt1.Rows[0][11].ToString();
                textBox15.Text = address;
            }


            else
            {
                DataTable dt1 = SQLFunction.findClient2(idClient);


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
                label27.Visible = false;
                textBox8.Visible = false;
                textBox9.Visible = false;


                textBox4.Text = dt1.Rows[0][1].ToString();

                textBox5.Text = dt1.Rows[0][2].ToString();
                textBox12.Text = dt1.Rows[0][3].ToString();
                textBox6.Text = dt1.Rows[0][4].ToString();
                textBox11.Text = dt1.Rows[0][5].ToString();
                textBox7.Text = dt1.Rows[0][9].ToString();
                textBox10.Text = dt1.Rows[0][7].ToString();

                textBox13.Text = dt1.Rows[0][6].ToString();
                textBox14.Text = dt1.Rows[0][8].ToString();
                textBox15.Text = address;

            }

            DataTable dt2 = SQLFunction.findModelsRequest(id);


            // Добавляем столбцы, с именами
            dt_new.Columns.Add("Наименование модели");
            dt_new.Columns.Add("Количество");
            dt_new.Columns.Add("Цена за единицу");
            dt_new.Columns.Add("Наличие товара на складе");
            dt_new.Columns.Add("Гарантийный срок");

            for (int i=0;i<dt2.Rows.Count; i++)
            {

                dt_new.Rows.Add(SQLFunction.getNameModel(Convert.ToInt32( dt2.Rows[i][0].ToString())), dt2.Rows[i][3].ToString(), dt2.Rows[i][4].ToString(), SQLFunction.findModelStore(Convert.ToInt32(dt2.Rows[i][0].ToString())).ToString()," 10 лет");

            }

            dataGridView1.DataSource = dt_new;
            dataGridView1.Columns[0].Width = 400;
            dataGridView1.Columns[1].Width = 140;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 230;
            dataGridView1.Columns[4].Width = 230;

            int summa = 0;
            for(int i = 0; i < dt_new.Rows.Count; i++)
            {

                summa += Convert.ToInt32(dt2.Rows[i][3].ToString()) * Convert.ToInt32(dt2.Rows[i][4].ToString());

            }

            textBox18.Text = summa.ToString();
            dataGridView1.CurrentCell.Selected = false;    //снимает выделение

            Opacity = 1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите прервать процедуру оформления договора с клиентом?", "Подтверждение закрытия", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                //  this.Hide();
                //  (new Заявки()).ShowDialog();
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;
                string number = textBox1.Text;
                int numberScore = Convert.ToInt32(textBox2.Text);
                DateTime dateScore = dateTimePicker2.Value;
                string forma = textBox17.Text;
                int summa = Convert.ToInt32(textBox18.Text);
                string numberDKP = textBox19.Text;
                DateTime dateDKP = dateTimePicker3.Value;
                string numberAPP = textBox22.Text;
                DateTime dateAPP = dateTimePicker4.Value;
                string payment = textBox24.Text;
                string delivery = textBox23.Text;



            if ((number != "") && (numberScore != 0) && (forma != "") && (summa != 0) &&  (numberDKP != "") && (numberAPP != "") && (payment != "") && (delivery != ""))
            {

                int flag1;
                bool flag2 = true;


                try
                {

                    flag1 = SQLFunction.addContract(date, number, Autorisation.id, idClient, id, numberScore, dateScore, forma, summa, numberDKP, dateDKP, numberAPP, dateAPP, payment, delivery);


                    for (int i = 0; i < dt_new.Rows.Count; i++)
                    {
                    

                        string nameModel = dt_new.Rows[i][0].ToString();
                        int count = Convert.ToInt32(dt_new.Rows[i][1]);
                        int price = Convert.ToInt32(dt_new.Rows[i][2]);
                        int idModel = SQLFunction.getIdModel(nameModel);
                        string presence = dt_new.Rows[i][3].ToString();
                        string guarante = dt_new.Rows[i][4].ToString();
                        SQLFunction.addContractTechnique(flag1, idModel, count, price, presence, guarante, "не оформлен", "нет");
                    }


                    if (flag2)
                    {
                        this.Close();
                        MessageBox.Show("Договор успешно добавлен.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        SQLFunction.updateStatus(id,"Договор с клиентом оформлен");
                        
                        DialogResult = DialogResult.OK;

                    }

                }

                catch { MessageBox.Show("Ошибка2", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error); }

}



            else { MessageBox.Show("Все поля должны быть заполнены.", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                    e.Handled = true;
            }
        }

        private void textBox23_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                    e.Handled = true;
            }
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }
    }
}
