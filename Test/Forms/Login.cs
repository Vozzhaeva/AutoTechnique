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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
           // textBox1.Text ="Acer";
           // textBox2.Text = "test";
           // textBox3.Text = "Vozzhaeva";
            textBox4.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (conn = new System.Data.SqlClient.SqlConnection("Server=" + textBox1.Text + ";Database=" + textBox2.Text + ";uid=" + textBox3.Text + ";pwd=" + textBox4.Text))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Соединено");
                    Data.value = "Server=" + textBox1.Text + ";Database=" + textBox2.Text + ";uid=" + textBox3.Text + ";pwd=" + textBox4.Text;
                    this.Close();

                }
                catch (Exception help)
                {
                    MessageBox.Show(help.Message);
                }
            }
        }
    }
}
