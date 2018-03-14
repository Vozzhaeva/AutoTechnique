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
    public partial class CatalogContractClient : Form
    {
        public CatalogContractClient()
        {
            InitializeComponent();
        }


        DataTable dt_new = new DataTable();
        private void ВсеДоговораСКлиентами_Load(object sender, EventArgs e)
        {
            DataTable dt = SQLFunction.getAllContract1();
            dt_new.Columns.Add("Номер договора");
            dt_new.Columns.Add("Дата договора");
            dt_new.Columns.Add("Номер счета");
            dt_new.Columns.Add("Сумма");
            dt_new.Columns.Add("ID_клиента");
            dt_new.Columns.Add("ID заявки от клиента");
            dt_new.Columns.Add("ID договора с клиентом");


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt_new.Rows.Add(dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString().Substring(0, 10), dt.Rows[i][3].ToString(), dt.Rows[i][14].ToString(), dt.Rows[i][7].ToString(), dt.Rows[i][8].ToString(), dt.Rows[i][0].ToString());
            }

            dataGridView1.DataSource = dt_new;

            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;

            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 200;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "")
            {
                string numberContract1 = textBox1.Text.Trim();

                dt = SQLFunction.getContract1Number(numberContract1);

                dt_new.Clear();


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt_new.Rows.Add(dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString().Substring(0, 10), dt.Rows[i][3].ToString(), dt.Rows[i][14].ToString(), dt.Rows[i][7].ToString(), dt.Rows[i][8].ToString(), dt.Rows[i][0].ToString());
                }

                dataGridView1.DataSource = dt_new;

                if (dt_new.Rows.Count == 0)
                {
                    MessageBox.Show("Договора с клиентом с указанным номером не найдено.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                dataGridView1.Columns[0].Width = 200;
                dataGridView1.Columns[1].Width = 200;
                dataGridView1.Columns[2].Width = 200;
                dataGridView1.Columns[3].Width = 200;
            }

            else
            {
                MessageBox.Show("Введите номер договора для поиска.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }


        DataTable dt = new DataTable();
        private void button3_Click(object sender, EventArgs e)
        {
            dt = SQLFunction.getAllContract1();


            dt_new.Clear();
            textBox1.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt_new.Rows.Add(dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString().Substring(0, 10), dt.Rows[i][3].ToString(), dt.Rows[i][14].ToString(), dt.Rows[i][7].ToString(), dt.Rows[i][8].ToString(), dt.Rows[i][0].ToString());
            }

            dataGridView1.DataSource = dt_new;
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 200;

        }

        private void button4_Click(object sender, EventArgs e)
        {


            try
            {
                int idRequest = Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value);   //id заявки
                int idСlient = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value);


                (new ViewContractClient(idСlient, idRequest)).ShowDialog();
            }
            catch { }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                int idContract1 = Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value);
                string numberContract1 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                (new RequestService(idContract1, numberContract1)).ShowDialog();
            }
            catch { }
        }
    }
}
