using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Library
{
    public partial class ReturnBooks : Form
    {
        OracleConnection conn = connectionDB.connect();
        public ReturnBooks()
        {
            InitializeComponent();
        }


        private void ReturnBooks_Load(object sender, EventArgs e)
        {
            showReturn();
        }
        
        private void showReturn()
        {
            OracleCommand cmd = new OracleCommand("showreturn", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            // create data adapter object
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            // create dataset onbject
            DataSet ds = new DataSet();

            //fill data into dataset object: ds
            
            //fill data into dataset object: ds
            adapter.Fill(ds, "book");


            dataGridView1.RowTemplate.Height = 75;
            dataGridView1.DataSource = ds.Tables["book"];

            DataGridViewImageColumn cols = (DataGridViewImageColumn)dataGridView1.Columns[6];
            cols.ImageLayout = DataGridViewImageCellLayout.Zoom;

            ds.Dispose();
            adapter.Dispose();
            cmd.Dispose();
        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            byte[] img = (byte[])dataGridView1.CurrentRow.Cells[6].Value;
            MemoryStream ms = new MemoryStream(img);
            BookImage.Image = Image.FromStream(ms);

            txtReturnID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtBookName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtUserName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtPayment.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtReturnQTY.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtPrice.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtStatus.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtReturnDate.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtStuname.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

        }

       

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {

        }
    }
}
