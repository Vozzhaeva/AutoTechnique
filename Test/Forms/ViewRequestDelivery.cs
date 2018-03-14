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
    public partial class ViewRequestDelivery : Form
    {
        public ViewRequestDelivery(int id)
        {
            InitializeComponent();
            this.id = id;
        }
        int id;
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ПросмотрЗаявкиНаДоставку_Load(object sender, EventArgs e)
        {

            DataTable dt_new = new DataTable();
            // Добавляем столбцы, с именами
            dt_new.Columns.Add("");
            dt_new.Columns.Add("");



                DataTable dt1 = SQLFunction.getReqDel(id);


                dt_new.Rows.Add("Дата заявки", dt1.Rows[0][1].ToString().Substring(0,10));
                dt_new.Rows.Add("Стоимость доставки", dt1.Rows[0][2].ToString());


            DataTable dt2 = SQLFunction.getRout(id);
            dt_new.Rows.Add("Техника", SQLFunction.getNameModel( Convert.ToInt32(dt2.Rows[0][1])));
            dt_new.Rows.Add("Город", SQLFunction.getNameCity(Convert.ToInt32(dt2.Rows[0][2])));
            dt_new.Rows.Add("Адрес", dt2.Rows[0][3].ToString());
            dt_new.Rows.Add("Количество", dt2.Rows[0][4].ToString());
            dt_new.Rows.Add("Общий километраж", dt2.Rows[0][5].ToString());
            dt_new.Rows.Add("Норма расхода топлива", dt2.Rows[0][6].ToString());
            dt_new.Rows.Add("Номер командировочного удостоверения", dt2.Rows[0][7].ToString());
            dt_new.Rows.Add("Дата командировачного удостоверения", dt2.Rows[0][8].ToString().Substring(0, 10));
            dt_new.Rows.Add("Номер доверенности", dt2.Rows[0][9].ToString());
            dt_new.Rows.Add("Дата доверенности", dt2.Rows[0][10].ToString().Substring(0, 10));



            dataGridView1.DataSource = dt_new;
            dataGridView1.Columns[0].Width = 300;
            dataGridView1.Columns[1].Width = 500;

            dataGridView1.CurrentCell.Selected = false;    //снимает выделение

        }
    }
}
