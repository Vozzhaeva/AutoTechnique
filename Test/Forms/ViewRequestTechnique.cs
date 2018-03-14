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
    public partial class ViewRequestTechnique : Form
    {
        public ViewRequestTechnique(int idClient, int id, string status)
        {
            InitializeComponent();
            this.idClient = idClient;
            this.id = id;
            this.status = status;
        }

        int idClient;
        int id;
        string status;
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ПросмотрЗаявки_Load(object sender, EventArgs e)
        {
           if( status== "Договор с клиентом оформлен") {
                button1.Visible = false;       //оформить договор с клиентом
                button4.Visible = false;      // отклонить
                button5.Visible = false;
            }
            if (status == "Отклонена")
            {
                button1.Visible = false;       //оформить договор с клиентом
                button4.Visible = false;      // отклонить
                button5.Visible = true;      // отклонить
            }
            if  (status == "Закрыта")
            {
                button1.Visible = false;       //оформить договор с клиентом
                button4.Visible = false;      // отклонить
                button5.Visible = false;      // отклонить
            }



            DataTable dt = SQLFunction.findClient(idClient);
            string type= dt.Rows[0][1].ToString();
            string address= dt.Rows[0][2].ToString();

            DataTable dt_new = new DataTable(); 
            // Добавляем столбцы, с именами
                dt_new.Columns.Add("");
                dt_new.Columns.Add("");

            dt_new.Rows.Add("Тип клиента",type);
            dt_new.Rows.Add("", "");
            dt_new.Rows.Add("Адрес", address);

            if( type=="Юридическое лицо")
            {
                DataTable dt1 = SQLFunction.findClient1(idClient);


                dt_new.Rows.Add("Название", dt1.Rows[0][1].ToString());
                dt_new.Rows.Add("ФИО директора", dt1.Rows[0][2].ToString());
                dt_new.Rows.Add("Банковские реквизиты", dt1.Rows[0][3].ToString());
                dt_new.Rows.Add("", "");
                dt_new.Rows.Add("Контактное лицо №1", dt1.Rows[0][4].ToString());
                dt_new.Rows.Add("Должность", dt1.Rows[0][5].ToString());
                dt_new.Rows.Add("Контактный телефон", dt1.Rows[0][6].ToString());
                dt_new.Rows.Add("Контактный e-mail", dt1.Rows[0][7].ToString());
                dt_new.Rows.Add("", "");
                dt_new.Rows.Add("Контактное лицо №2", dt1.Rows[0][8].ToString());
                dt_new.Rows.Add("Должность", dt1.Rows[0][9].ToString());
                dt_new.Rows.Add("Контактный телефон", dt1.Rows[0][10].ToString());
                dt_new.Rows.Add("Контактный e-mail", dt1.Rows[0][11].ToString());


            }


            else
            {
                DataTable dt1 = SQLFunction.findClient2(idClient);


                dt_new.Rows.Add("ФИО", dt1.Rows[0][1].ToString());
                dt_new.Rows.Add("", "");
                dt_new.Rows.Add("Серия паспорта", dt1.Rows[0][2].ToString());
                dt_new.Rows.Add("Номер паспорта", dt1.Rows[0][3].ToString());
                dt_new.Rows.Add("Где выдан", dt1.Rows[0][4].ToString());
                dt_new.Rows.Add("Кем выдан", dt1.Rows[0][5].ToString());
                dt_new.Rows.Add("Код подразделения выдачи", dt1.Rows[0][9].ToString());
                dt_new.Rows.Add("Дата выдачи паспорта", dt1.Rows[0][7].ToString());
                dt_new.Rows.Add("", "");
                dt_new.Rows.Add("Контактный телефон", dt1.Rows[0][6].ToString());
                dt_new.Rows.Add("Контактный e-mail", dt1.Rows[0][8].ToString());

            }

            dataGridView1.DataSource = dt_new;
            dataGridView1.Columns[0].Width = 310;
            dataGridView1.Columns[1].Width = 510;

            dataGridView1.CurrentCell.Selected = false;    //снимает выделение



            DataTable dt2 = SQLFunction.findModelsRequest(id);
            int number = dt2.Rows.Count;

            
            DataTable dt_new2 = new DataTable();
            // Добавляем столбцы, с именами
            dt_new2.Columns.Add("Модель");
            dt_new2.Columns.Add("Количество");
            dt_new2.Columns.Add("Цена за единицу");

            for(int i=0; i < number; i++)
            {
                dt_new2.Rows.Add(SQLFunction.getNameModel(Convert.ToInt32( dt2.Rows[i][0].ToString())), dt2.Rows[i][3].ToString(), dt2.Rows[i][4].ToString());

            }

            dataGridView2.DataSource = dt_new2;
            dataGridView2.Columns[0].Width = 500;
            dataGridView2.Columns[1].Width = 120;
            dataGridView2.Columns[2].Width = 200;


           dataGridView2.CurrentCell.Selected = false;


        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentCell.Selected = false;    //снимает выделение

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            (new ContractClient(idClient, id)).ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите отклонить заявку?", "Подтверждение отклонения", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                SQLFunction.updateStatus(id, "Отклонена");

                this.Close();
                //  this.Visible = false;
                MessageBox.Show("Заявка от клиента отклонена.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                DialogResult = DialogResult.OK;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();

            (new ContractClient(idClient, id)).ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
