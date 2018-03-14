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
    public partial class CatalogContractFactory : Form
    {
        public CatalogContractFactory()
        {
            InitializeComponent();
        }

        DataTable dt_new = new DataTable();
        private void ВсеДоговораСЗаводами_Load(object sender, EventArgs e)
        {
            DataTable dt = SQLFunction.getAllContract2();
            dt_new.Columns.Add("Номер договора");
            dt_new.Columns.Add("Дата договора");
            dt_new.Columns.Add("Завод-изготовитель");
            dt_new.Columns.Add("Сумма, руб.");
            dt_new.Columns.Add("ID_договора с заводом");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt_new.Rows.Add(dt.Rows[i][2].ToString(), dt.Rows[i][1].ToString().Substring(0, 10), SQLFunction.getNameFactory( Convert.ToInt32(dt.Rows[i][4])), dt.Rows[i][6].ToString(), dt.Rows[i][0].ToString());
            }

            dataGridView1.DataSource = dt_new;

            dataGridView1.Columns[4].Visible = false;

            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 300;
            dataGridView1.Columns[3].Width = 170;
        }


        DataTable dt = new DataTable();
        private void button3_Click(object sender, EventArgs e)
        {
            dt = SQLFunction.getAllContract2();


            dt_new.Clear();
            textBox1.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt_new.Rows.Add(dt.Rows[i][2].ToString(), dt.Rows[i][1].ToString().Substring(0, 10), SQLFunction.getNameFactory(Convert.ToInt32(dt.Rows[i][4])), dt.Rows[i][6].ToString(), dt.Rows[i][0].ToString());
            }

            dataGridView1.DataSource = dt_new;
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 300;
            dataGridView1.Columns[3].Width = 170;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text !="")
            {
                string numberContract1 = textBox1.Text.Trim();

                dt = SQLFunction.getContract2Number(numberContract1);

                dt_new.Clear();


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt_new.Rows.Add(dt.Rows[i][2].ToString(), dt.Rows[i][1].ToString().Substring(0, 10), SQLFunction.getNameFactory(Convert.ToInt32(dt.Rows[i][4])), dt.Rows[i][6].ToString(), dt.Rows[i][0].ToString());
                }

                dataGridView1.DataSource = dt_new;

                if (dt_new.Rows.Count == 0)
                {
                    MessageBox.Show("Договора с заводом с указанным номером не найдено.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                dataGridView1.Columns[0].Width = 200;
                dataGridView1.Columns[1].Width = 200;
                dataGridView1.Columns[2].Width = 300;
                dataGridView1.Columns[3].Width = 170;
            }

            else
            {
                MessageBox.Show("Введите номер договора для поиска.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int idContract2 = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value);


                new ViewContractFactory(idContract2).ShowDialog();
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
