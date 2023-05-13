using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Library
{
    public partial class Report : Form
    {
        OracleConnection conn = connectionDB.connect();
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleConnection conn = connectionDB.connect();
            conn.Open();
            string sql = "SELECT * FROM vborrow";
            OracleDataAdapter adap = new OracleDataAdapter(sql, conn);
            DataSet1 ds = new DataSet1(); adap.Fill(ds, "BorrowDetail"); 
            CrystalReport1 rpt = new CrystalReport1(); 
            rpt.SetDataSource(ds.Tables["BorrowDetail"]);
            crystalReportViewer1.ReportSource = rpt;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OracleConnection conn = connectionDB.connect();
            conn.Open();
            string sql = "SELECT * FROM vbook";
            OracleDataAdapter adap = new OracleDataAdapter(sql, conn);
            DataSet1 ds = new DataSet1(); adap.Fill(ds, "Book");
            vbookreport rpt = new vbookreport();
            rpt.SetDataSource(ds.Tables["Book"]);
            crystalReportViewer1.ReportSource = rpt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleConnection conn = connectionDB.connect();
            conn.Open();
            string sql = "SELECT * FROM vreturn";
            OracleDataAdapter adap = new OracleDataAdapter(sql, conn);
            DataSet1 ds = new DataSet1(); adap.Fill(ds, "Return");
            vreturnreport rpt = new vreturnreport();
            rpt.SetDataSource(ds.Tables["Return"]);
            crystalReportViewer1.ReportSource = rpt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OracleConnection conn = connectionDB.connect();
            conn.Open();
            string sql = "SELECT * FROM vpayment";
            OracleDataAdapter adap = new OracleDataAdapter(sql, conn);
            DataSet1 ds = new DataSet1(); adap.Fill(ds, "Pay");
            vpayreport rpt = new vpayreport();
            rpt.SetDataSource(ds.Tables["Pay"]);
            crystalReportViewer1.ReportSource = rpt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OracleConnection conn = connectionDB.connect();
            conn.Open();
            string sql = "SELECT * FROM tbluser";
            OracleDataAdapter adap = new OracleDataAdapter(sql, conn);
            DataSet1 ds = new DataSet1(); adap.Fill(ds, "User");
            Userreport rpt = new Userreport();
            rpt.SetDataSource(ds.Tables["User"]);
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
