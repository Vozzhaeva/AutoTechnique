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
    public partial class Autorisation : Form
    {
        private User user;
        public string idUser
        {
            get { return user.Id; }
            set { user.Id = value; }
        }

        public string userType
        {
            get { return user.UserType; }
            set { user.UserType = value; }
        }
        public string identif
        {
            get { return user.Identif.ToString(); }
            set { user.Identif = value; }
        }

        public Autorisation()
        {
            InitializeComponent();
        }

        public void setTextoxRed()
        {
            textLogin.BackColor = Color.Red;
            textPassword.BackColor = Color.Red;
        }

        public static string login;
        public static int id;
        private void button1_Click(object sender, EventArgs e)
        {
            string pass;
            login = textLogin.Text;
            pass = textPassword.Text;
            user = SQLFunction.getUserByLogPass(login, pass);
            if (user == null)
            {
                DialogResult = DialogResult.Retry;
            }
            else
            {
                DialogResult = DialogResult.OK;
                id = Convert.ToInt32(user.Identif);
                this.Visible = false;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите закрыть программу?", "Закрытие программы", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void validationControl1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Авторизация_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
