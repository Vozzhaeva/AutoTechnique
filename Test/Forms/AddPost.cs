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
    public partial class AddPost : Form
    {
        public AddPost()
        {
            InitializeComponent();
        }

        private void AddPost_Load(object sender, EventArgs e)
        {

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           


            if ((textBox1.Text == ""))
            {
               
                MessageBox.Show("Введите название должности", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string name_post = textBox1.Text;
                bool flag = SQLFunction.addPost(name_post);
                if (flag)
                {
                    this.Visible = false;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    //this.Visible = false;
                    MessageBox.Show("Такая должность уже существует", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //  (new Техника()).ShowDialog();
                //Обработка: проверка уникальности логина(подключение к БД) 
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
