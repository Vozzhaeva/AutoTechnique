using System;
using CrystalDecisions.CrystalReports.Engine;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string sConn = "Data Source = DESKTOP-793AVME; Initial Catalog = test; Integrated Security = True";
            SqlConnection cnn = new SqlConnection(sConn);
            cnn.Open();
            String request = string.Format("SELECT * FROM view_Count1");
            SqlDataAdapter da = new SqlDataAdapter(request, cnn);
            testDataSet ds = new testDataSet();
            da.Fill(ds, "view_Count1");

            ReportDocument rDoc = new ReportDocument();
            rDoc.Load("CrystalReport5.rpt");
            rDoc.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rDoc;
        }
    }
}
