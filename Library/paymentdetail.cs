using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class paymentdetail : Form
    {

        OracleConnection conn = connectionDB.connect();
        public paymentdetail()
        {
            InitializeComponent();
        }

        private void paymentdetail_Load(object sender, EventArgs e)
        {
            showPaymentDetail();
        }
        private void showPaymentDetail()
        {
            OracleCommand cmd = new OracleCommand("SHOWPAYTMENT", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            // create data adapter object
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            // create dataset onbject
            DataSet ds = new DataSet();

            //fill data into dataset object: ds
            
            adapter.Fill(ds, "payment");


            dataGridView1.RowTemplate.Height = 75;
            dataGridView1.DataSource = ds.Tables["payment"];

            DataGridViewImageColumn cols = (DataGridViewImageColumn)dataGridView1.Columns[7];
            cols.ImageLayout = DataGridViewImageCellLayout.Zoom;

            ds.Dispose();
            adapter.Dispose();
            cmd.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            byte[] img = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
            MemoryStream ms = new MemoryStream(img);
            BookImage.Image = Image.FromStream(ms);

            txtPayID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtUser.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtBook.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtStudent.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtPaytype.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtPrice.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtQty.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtPaydate.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }
    }
}
