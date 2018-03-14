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
    public partial class ДоговораСЗаводами : Form
    {
        public ДоговораСЗаводами(int idRequest)
        {
            InitializeComponent();
            this.idRequest = idRequest;
        }
        int idRequest;
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ДоговораСЗаводами_Load(object sender, EventArgs e)
        {
            List<int> listData = SQLFunction.getIDContract2(idRequest);
            DataTable dt_new = new DataTable();
            dt_new.Columns.Add("Дата договора");
            dt_new.Columns.Add("Номер договора");
            dt_new.Columns.Add("Завод-изготовитель");
            dt_new.Columns.Add("Дата оплаты");
            dt_new.Columns.Add("Сумма для оплаты, руб.");
            for ( int i=0; i < listData.Count; i++)
            {
                int idContract2 = listData[i];
                List <string> list = SQLFunction.getContract2(idContract2);
                dt_new.Rows.Add(list[1].Substring(0, 10), list[2], SQLFunction.getNameFactory(Convert.ToInt32(list[4])),list[3].Substring(0,10),list[6]);
            }

            dataGridView1.DataSource = dt_new;
            dataGridView1.Columns[0].Width = 170;
            dataGridView1.Columns[1].Width = 180;
            dataGridView1.Columns[2].Width = 300;
            dataGridView1.Columns[3].Width = 170;
            dataGridView1.Columns[4].Width = 250;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numberContract2 = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
            int idContract2 = SQLFunction.getIDContract2Number(numberContract2);
            new ViewContractFactory(idContract2).ShowDialog();
        }
    }
}
