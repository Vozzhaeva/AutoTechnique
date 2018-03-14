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
    public partial class ViewContractFactory : Form
    {
        public ViewContractFactory(int idContract2)
        {
            InitializeComponent();
            this.idContract2 = idContract2;
        }
        int idContract2;
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DataTable dt_new = new DataTable();
        private void ПросмотрДоговораСЗаводом_Load(object sender, EventArgs e)
        {
           


            List<string> list = SQLFunction.getContract2(idContract2);

            dt_new.Columns.Add("");
            dt_new.Columns.Add("");

            dt_new.Rows.Add("Дата договора", list[1].ToString().Substring(0, 10));
            dt_new.Rows.Add("Номер договора", list[2].ToString());          
            dt_new.Rows.Add("", "");
            dt_new.Rows.Add("Завод-изготовитель",SQLFunction.getNameFactory(Convert.ToInt32(list[4])));
            dt_new.Rows.Add("Дата оплаты", list[3].ToString().Substring(0, 10));
            dt_new.Rows.Add("Сумма для оплаты, руб.",list[5].ToString());
            dt_new.Rows.Add("", "");

            DataTable dt2 = SQLFunction.getContract2Technique(idContract2);
            dt_new.Rows.Add("Модель техники",SQLFunction.getNameModel(Convert.ToInt32( dt2.Rows[0][1])));
            dt_new.Rows.Add("Количество", dt2.Rows[0][2].ToString());
            dt_new.Rows.Add("Цена за единицу, руб.", dt2.Rows[0][3].ToString());
            dt_new.Rows.Add("Срок поставки, дней", dt2.Rows[0][4].ToString());

            dataGridView1.DataSource = dt_new;
            dataGridView1.Columns[0].Width = 300;
            dataGridView1.Columns[1].Width = 400;

            dataGridView1.CurrentCell.Selected = false;    //снимает выделение



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
