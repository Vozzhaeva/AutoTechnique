using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {


        public Form1(DateTime data1, DateTime data2)
        {
            InitializeComponent();
            this.data1 = data1;
            this.data2 = data2;
        }

        DateTime data1;
        DateTime data2;
        private void button1_Click(object sender, EventArgs e)
        {

           





        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string sConn= "Data Source =DESKTOP-793AVME; Initial Catalog = test; Integrated Security = True";
            SqlConnection cnn = new SqlConnection(sConn);
            cnn.Open();


            String request = string.Format("SELECT *  from Договор_с_клиентом WHERE ID_сотрудника='{0}' AND  (Дата_договора_с_клиентом BETWEEN '{1}' AND '{2}')", Autorisation.id, data1,data2);
            //String request = $"SELECT *  from Договор_с_клиентом WHERE Дата_договора_с_клиентом BETWEEN {data1} AND {data2}";
            SqlDataAdapter da = new SqlDataAdapter(request, cnn);
            testDataSet ds = new testDataSet();
            da.Fill(ds, "Договор_с_клиентом");

            ReportDocument rDoc = new ReportDocument();
            rDoc.Load("CrystalReport2.rpt");
            rDoc.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rDoc;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
