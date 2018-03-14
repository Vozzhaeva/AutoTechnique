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
    public partial class InformationModel : Form
    {
        public InformationModel(string name_model)
        {
            InitializeComponent();
            this.name_model = name_model;
        }
        string name_model;

        private void ИнформацияОМодели_Load(object sender, EventArgs e)
        {
            List<string> list = SQLFunction.GetInfoModel(name_model);
       //     List<string> list2 = SQLFunction.GetInfoModel2(name_model);
            label1.Text += name_model;
            label2.Text += list[1].ToString();      
            label4.Text += list[2].ToString();
            label5.Text += list[3].ToString();
            label6.Text += list[4].ToString();
            label7.Text += list[6].ToString();
            label8.Text += list[7].ToString();
            //label7.Text += list2[0].ToString() + "дней";
            //label8.Text += list2[1].ToString()+ "рублей";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
