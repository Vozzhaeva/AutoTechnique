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
    public partial class ViewContractClient : Form
    {
        public ViewContractClient(int idClient, int id)
        {
            InitializeComponent();
          
            this.idClient = idClient;
            this.id = id;
        }

        int idClient;
        int id;

        int idContract1;

        DataTable dt_new2 = new DataTable();
        DataTable dt2= new DataTable(); 
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ПросмотрДоговора1_Load(object sender, EventArgs e)
        {
            DataTable dt = SQLFunction.findClient(idClient);
            string type = dt.Rows[0][1].ToString();
            string address = dt.Rows[0][2].ToString();

            DataTable dt_new = new DataTable();
           
            // Добавляем столбцы, с именами
            dt_new.Columns.Add("");
            dt_new.Columns.Add("");

            dt_new.Rows.Add("Тип клиента", type);
            dt_new.Rows.Add("", "");
            dt_new.Rows.Add("Адрес", address);

            if (type == "Юридическое лицо")
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
                dt_new.Rows.Add("", "");


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
                dt_new.Rows.Add("", "");

            }




            DataTable dt3 = SQLFunction.findContract(idClient);
            dt_new.Rows.Add("Номер договора с клиентом", dt3.Rows[0][1].ToString());
            dt_new.Rows.Add("Дата договора с клиентом", dt3.Rows[0][2].ToString().Substring(0, 10));
            dt_new.Rows.Add("", "");
            dt_new.Rows.Add("Номер счета", dt3.Rows[0][3].ToString());
            dt_new.Rows.Add("Дата счета", dt3.Rows[0][4].ToString().Substring(0, 10));
            dt_new.Rows.Add("", "");
            dt_new.Rows.Add("Форма оплаты", dt3.Rows[0][5].ToString());
            dt_new.Rows.Add("", "");
            dt_new.Rows.Add("Номер ДКП", dt3.Rows[0][9].ToString());
            dt_new.Rows.Add("Дата ДКП", dt3.Rows[0][10].ToString().Substring(0, 10));
            dt_new.Rows.Add("", "");
            dt_new.Rows.Add("Номер АПП", dt3.Rows[0][11].ToString());
            dt_new.Rows.Add("Дата АПП", dt3.Rows[0][12].ToString().Substring(0, 10));
            dt_new.Rows.Add("", "");
            dt_new.Rows.Add("Признак доставки", dt3.Rows[0][13].ToString());
            dt_new.Rows.Add("Сумма", dt3.Rows[0][14].ToString());
            dt_new.Rows.Add("Признак оплаты", dt3.Rows[0][15].ToString());

            idContract1 = Convert.ToInt32(dt3.Rows[0][0]);

            dataGridView1.DataSource = dt_new;
            dataGridView1.Columns[0].Width = 450;
            dataGridView1.Columns[1].Width = 680;

            dataGridView1.CurrentCell.Selected = false;    //снимает выделение





            dt2 = SQLFunction.findModelsContract1(Convert.ToInt32(dt3.Rows[0][0]));
            int number = dt2.Rows.Count;


           // DataTable dt_new2 = new DataTable();
            // Добавляем столбцы, с именами
            dt_new2.Columns.Add("Модель");
            dt_new2.Columns.Add("Количество");
            dt_new2.Columns.Add("Цена за единицу");
            dt_new2.Columns.Add("Признак наличия товара");
            dt_new2.Columns.Add("Гарантийный срок");
            dt_new2.Columns.Add("Договор с заводом");
            dt_new2.Columns.Add("Заявка на доставку");

            for (int i = 0; i < number; i++)
            {
                dt_new2.Rows.Add(SQLFunction.getNameModel(Convert.ToInt32(dt2.Rows[i][1].ToString())), dt2.Rows[i][2].ToString(), dt2.Rows[i][3].ToString(), dt2.Rows[i][4].ToString(), dt2.Rows[i][5].ToString(), dt2.Rows[i][6].ToString(), dt2.Rows[i][7].ToString());

            }



            dataGridView2.DataSource = dt_new2;
            dataGridView2.Columns[0].Width = 350;
            dataGridView2.Columns[1].Width = 130;
            dataGridView2.Columns[2].Width = 200;
            dataGridView2.Columns[3].Width = 200;
            dataGridView2.Columns[4].Width = 150;
            dataGridView2.Columns[5].Width = 170;
            dataGridView2.Columns[6].Width = 170;
            //    dataGridView2.CurrentCell.Selected = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)


        {
            DataTable dt4 = new DataTable();
            dt4.Columns.Add("Модель");
            dt4.Columns.Add("Количество");


            string str = "нет";

            for (int i = 0; i < dataGridView2.RowCount; i++) {


                string str2 = dataGridView2.Rows[i].Cells[6].Value.ToString();
                if (str2==str)
                {
                    dt4.Rows.Add(dataGridView2.Rows[i].Cells[0].Value.ToString(), dataGridView2.Rows[i].Cells[1].Value.ToString());
                }

                else
                {

                }

             }



            new RequestDelivery(dt4, idContract1).ShowDialog();
            DialogResult = DialogResult.OK;
        }

        private void button3_Click(object sender, EventArgs e)
        {
 
            int index = dataGridView2.CurrentCell.RowIndex;

            string  nameModel = dataGridView2.Rows[index].Cells[0].Value.ToString();
            int idModel = SQLFunction.getIdModel(nameModel);
            int count = Convert.ToInt32(dataGridView2.Rows[index].Cells[1].Value);
            new ContractFactory(idModel,count,idContract1).ShowDialog();


            DialogResult = DialogResult.OK;

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
