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
    public partial class ContractFactory : Form
    {
        public ContractFactory(int idModel, int count, int idContract1)
        {
            InitializeComponent();
            this.idModel = idModel;
            this.count = count;
            this.idContract1 = idContract1;

        }
        int idModel;
        int count;
        int idFactory;
        int idContract1;
        private void ДоговорСЗаводом_Load(object sender, EventArgs e)
        {
            idFactory = SQLFunction.getIDFactory(idModel);
            string nameFactory = SQLFunction.getNameFactory(idFactory);
            string nameModel =SQLFunction.getNameModel(idModel);
            label7.Text = nameFactory;
            label8.Text = nameModel;
            label10.Text = count.ToString();
            label14.Text = SQLFunction.GetInfoModel2(nameModel)[0];
            label12.Text = SQLFunction.GetInfoModel2(nameModel)[1];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите прервать процедуру оформления договора с заводом?", "Подтверждение закрытия", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            if ((textBox1.Text!="")&& (textBox3.Text != "")){
 int number = Convert.ToInt32(textBox1.Text);
            int summa = Convert.ToInt32(textBox3.Text);
            DateTime date = dateTimePicker1.Value;
            DateTime dateprice = dateTimePicker1.Value;
            int price = Convert.ToInt32(label12.Text);
            int term = Convert.ToInt32(label14.Text);
                bool flag = SQLFunction.addContractFactory(date,number,idFactory,dateprice,idContract1,summa,idModel,count,price,term);
                int idRequest = SQLFunction.getIDRequest(idContract1);


                if (flag)
                {
                    this.Close();
                    MessageBox.Show("Договор c заводом успешно добавлен.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    SQLFunction.updateStatus1(idModel, "оформлен");


                    int count = SQLFunction.getCountContract(idContract1,"не оформлен");
                    if (count == 0)
                    {
                        SQLFunction.updateStatus(idRequest, "Закрыта");
                    }                  
                    DialogResult = DialogResult.OK;

                }


            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены.", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
