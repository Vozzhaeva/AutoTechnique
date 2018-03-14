using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test.Forms
{
    public partial class Form2 : Form
    {
        public Form2(DateTime data1, DateTime data2)
        {
            InitializeComponent();
            this.data1 = data1;
            this.data2 = data2;
        }
        DateTime data1;
        DateTime data2;
        private void Form2_Load(object sender, EventArgs e)
        {
            string sConn = "Data Source = DESKTOP-793AVME; Initial Catalog = test; Integrated Security = True";
            SqlConnection cnn = new SqlConnection(sConn);
            cnn.Open();


            String request = string.Format("SELECT * FROM  Заявка_от_клиента WHERE ID_сотрудника='{0}' AND (Дата_заявки BETWEEN '{1}' AND '{2}')", Autorisation.id, data1, data2);
            //String request = $"SELECT *  from Договор_с_клиентом WHERE Дата_договора_с_клиентом BETWEEN {data1} AND {data2}";
            SqlDataAdapter da = new SqlDataAdapter(request, cnn);
            testDataSet ds = new testDataSet();
            da.Fill(ds, "Заявка_от_клиента");

            ReportDocument rDoc = new ReportDocument();
            rDoc.Load("CrystalReport3.rpt");
            rDoc.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rDoc;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
