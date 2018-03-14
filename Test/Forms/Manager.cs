using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.Forms;

namespace Test
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
            //dataGridView1.DataBindings.Add(nameof(DataGrid.BackgroundColor),
            //                    this,
            //                    nameof(Control.BackColor));
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите закрыть программу?", "Закрытие программы", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void справочникТехникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new СatalogTechniques()).ShowDialog();
        }



        private void dataGridView3_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void справочникЗаводовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new CatalogFactory()).ShowDialog();
        }

        private void Заявки_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Заявка_на_доставку". При необходимости она может быть перемещена или удалена.
            this.заявка_на_доставкуTableAdapter.Fill(this.testDataSet.Заявка_на_доставку);
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Заявка_от_клиента". При необходимости она может быть перемещена или удалена.
            this.заявка_от_клиентаTableAdapter.Fill(this.testDataSet.Заявка_от_клиента);
            this.заявка_от_клиентаTableAdapter.Update(testDataSet);

            //for (int y = 0; y < dataGridView1.Rows.Count; y++)
            //{
            //    dataGridView1.Rows[y].Cells[2].Style.BackColor =
            //    System.Drawing.Color.Transparent;
            //}

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // int index = dataGridView1.CurrentCell.RowIndex;
          //  dataGridView1.Rows[index].Selected = true;
        }

        private void menuStrip4_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }



        //private void button1_Click_1(object sender, EventArgs e)
      //  {
      //      this.заявка_от_клиентаTableAdapter.Update(testDataSet);
      //      заявка_от_клиентаTableAdapter.Fill(testDataSet.Заявка_от_клиента);
       //     dataGridView1.Update();
       //     dataGridView1.Refresh();

        //    this.заявка_на_доставкуTableAdapter.Update(testDataSet);
         //   заявка_на_доставкуTableAdapter.Fill(testDataSet.Заявка_на_доставку);
         //   dataGridView2.Update();
        //    dataGridView2.Refresh();
     //   }



        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void открытьДоговорToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
          

        }

        private void наТехникуToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void заявкуНаДоставкуToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void заявкуНаТехникуToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void сToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            int idСlient = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);

            (new ContractClient(idСlient, id)).ShowDialog();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void наДоставкуToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сЗАВОДОМToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void menuStrip5_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            int idСlient = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
            string status = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            (new ViewRequestTechnique(idСlient, id,status)).ShowDialog();

            заявка_от_клиентаTableAdapter.Fill(this.testDataSet.Заявка_от_клиента);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //this.Close();
            (new SelectionTechniques()).ShowDialog();
            заявка_от_клиентаTableAdapter.Fill(this.testDataSet.Заявка_от_клиента);
        }

        private void сКлиентомToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    string status = dataGridView1.CurrentRow.Cells[3].Value.ToString();


                if (status == "Открыта") {

                if (MessageBox.Show("Вы действительно хотите отклонить выбранную заявку?", "Подтверждение отклонения", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    

                    SQLFunction.updateStatus(id, "Отклонена");
                    MessageBox.Show("Заявка от клиента отклонена.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                  //  DialogResult = DialogResult.OK;
                }
                }

                if(status == "Договор с клиентом оформлен")
                {
                    MessageBox.Show("Невозможно отклонить заявку, так как договор с клиентом уже оформлен.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                  //  DialogResult = DialogResult.OK;

                }

                if (status == "Закрыта")
                {
                    MessageBox.Show("Невозможно отклонить заявку, так как договор с клиентом и с заводом уже оформлен.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //    DialogResult = DialogResult.OK;

                }

            if (status == "Отклонена")
            {
                MessageBox.Show("Заявка уже отклонена.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //    DialogResult = DialogResult.OK;

            }

            заявка_от_клиентаTableAdapter.Fill(testDataSet.Заявка_от_клиента);
            
        }

        private void toolStripMenuItem8_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            int idСlient = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
            string status = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            if(status=="Открыта")
            {
                MessageBox.Show("Договор с клиентом еще не оформлен. Оформите договор.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            if (status == "Отклонена")
            {
                MessageBox.Show("Договор с клиентом не может быть открыт, так как заявка на технику была отклонена.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            else { 
            (new ViewContractClient(idСlient, id)).ShowDialog();
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);


            (new ViewRequestDelivery( id)).ShowDialog();
        }

        private void прайсЛистToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new PriceList()).ShowDialog();
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {



            int idRequest = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            string status = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            if (status == "Открыта")
            {
                MessageBox.Show("Договор с заводом еще не оформлен. Оформите договор.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            if (status == "Отклонена")
            {
                MessageBox.Show("Договор с заводом не может быть открыт, так как заявка на технику была отклонена.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }


            if (status == "Договор с клиентом оформлен")
            {
                MessageBox.Show("Договор с заводом еще не оформлен. Оформите договор.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else { 
            (new ДоговораСЗаводами(idRequest)).ShowDialog();
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            int idСlient = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
            string status = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            if (status == "Открыта")
            {
                MessageBox.Show("Договор с клиентом еще не оформлен. Оформите договор.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            if (status == "Отклонена")
            {
                MessageBox.Show("Договор с клиентом не может быть открыт, так как заявка на технику была отклонена.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            else
            {
                (new ViewContractClient(idСlient, id)).ShowDialog();
            }
        }

        private void toolStripMenuItem10_Click_1(object sender, EventArgs e)
        {

        }

        private void сКлиентамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new CatalogContractClient()).ShowDialog();
        }

        private void сЗаводамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new CatalogContractFactory()).ShowDialog();
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {

        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem11_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {

        }

        private void складToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ViewStore().ShowDialog();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void поРаботеСотрудниковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormData2().ShowDialog();
        }

        private void договоровВУказанныйПромежутокВремениToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormData().ShowDialog();
        }

        private void поМоделямToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
        }
    }
    }

