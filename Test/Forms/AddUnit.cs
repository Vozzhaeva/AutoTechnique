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
    public partial class AddUnit : Form
    {
        public AddUnit()
        {
            InitializeComponent();
        }

        private void AddUnit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Отдел". При необходимости она может быть перемещена или удалена.
            this.отделTableAdapter.Fill(this.testDataSet.Отдел);

        }
    }
}
