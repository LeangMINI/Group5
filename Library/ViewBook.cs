using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
using Oracle.ManagedDataAccess.Client;

namespace Library
{
    public partial class ViewBook : Form
    {
        OracleConnection conn = connectionDB.connect();
        public ViewBook()
        {
            InitializeComponent();
        }

        
        private void showBook()
        {
           /* conn.Open();*/
            int status = 0;
            OracleCommand cmd = new OracleCommand("showBook", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            // add value for parameterr of store procedure
            cmd.Parameters.Add("visdeleted", status);
            // create data adapter object
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            // create dataset onbject
            DataSet ds = new DataSet();

            //fill data into dataset object: ds
            adapter.Fill(ds, "book");


            dataGridView1.RowTemplate.Height = 75;
            dataGridView1.DataSource = ds.Tables["book"];

            DataGridViewImageColumn cols = (DataGridViewImageColumn)dataGridView1.Columns[11];
            cols.ImageLayout = DataGridViewImageCellLayout.Zoom;

            // hide the columns of datagridview
            //dgv1.Columns[10].Visible = false;
            ds.Dispose();
            adapter.Dispose();
            cmd.Dispose();
            //conn.Close();
        }

        private void ViewBook_Load(object sender, EventArgs e)
        {
            showBook();
            ShowPayment();
            ShowStudent();
        }
        private void ShowPayment()
        {
            //conn.Open();
            OracleCommand cmd = new OracleCommand("showpaydetails", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            // create data adapter object
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            // create dataset onbject
            DataSet ds = new DataSet();

            //fill data into dataset object: ds
            adapter.Fill(ds);

            cboPayment.DataSource = ds.Tables[0];
            cboPayment.DisplayMember = "Pay";
            cboPayment.ValueMember = "PaymentDetailID";


            ds.Dispose();
            adapter.Dispose();
            cmd.Dispose();
           // conn.Close();
        }

        private void ShowStudent()
        {
            //conn.Open();
            OracleCommand cmd = new OracleCommand("showStudent", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            // create data adapter object
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            // create dataset onbject
            DataSet ds = new DataSet();

            //fill data into dataset object: ds
            adapter.Fill(ds);

            cboStuname.DataSource = ds.Tables[0];
            cboStuname.DisplayMember = "StuName";
            cboStuname.ValueMember = "StuID";


            ds.Dispose();
            adapter.Dispose();
            cmd.Dispose();
            // conn.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            OracleCommand cmd_select = new OracleCommand("searchBook", conn);
            cmd_select.CommandType = CommandType.StoredProcedure;
            //add value for parameter of store procedure
            cmd_select.Parameters.Add("vbname", txtBookName.Text.Trim());

            OracleDataAdapter adapter = new OracleDataAdapter(cmd_select);

            DataTable dt = new DataTable();

            //fill data into dataset object: ds
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;

            dt.Dispose();
            adapter.Dispose();
            cmd_select.Dispose();
            conn.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSeacrh.Clear();
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnBorrow.Text == "Borrow")
            {

                if (string.IsNullOrEmpty(txtBookID.Text))
                {
                    MessageBox.Show("Please enter Product Name!", "Required Product Name",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBookID.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtBookType.Text))
                {
                    MessageBox.Show("Please enter QTY!", "Required QTY",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBookType.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtAuthor.Text))
                {
                    MessageBox.Show("Please enter UnitPrice In!", "Required UnitPrice in",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAuthor.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtBookType.Text))
                {
                    MessageBox.Show("Please enter Unitprice out!", "Required Unit priceout",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBookType.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtBorrowQty.Text))
                {
                    MessageBox.Show("Please select Category Name!", "Required Category Name",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBorrowQty.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtPrice.Text))
                {
                    MessageBox.Show("Please enter UnitPrice In!", "Required UnitPrice in",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPrice.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(cboPayment.Text))
                {
                    MessageBox.Show("Please enter UnitPrice In!", "Required UnitPrice in",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboPayment.Focus();
                    return;
                }
                else
                {
                    try
                    {
                        conn.Open(); //open the connection
                        // create memorystream object
                        MemoryStream ms = new MemoryStream();
                        BookImage.Image.Save(ms, BookImage.Image.RawFormat);
                        //create command object
                        OracleCommand cmd_insert = new OracleCommand();
                        cmd_insert.Connection = conn;
                        cmd_insert.CommandText = "addBorrow";
                        cmd_insert.CommandType = CommandType.StoredProcedure;

                        //add values for parameter of store procedure
                        cmd_insert.Parameters.Add("vuserid", Userlogin.getUserID());
                        cmd_insert.Parameters.Add("vbookid", txtBookID.Text);
                        cmd_insert.Parameters.Add("vqty", double.Parse(txtBorrowQty.Text));
                        cmd_insert.Parameters.Add("vpayid", cboPayment.SelectedValue);
                        
                        cmd_insert.Parameters.Add("vimage", OracleDbType.Blob).Value = ms.ToArray();
                        cmd_insert.Parameters.Add("vstuid", cboStuname.SelectedValue);
                        cmd_insert.Parameters.Add("vprice", txtPrice.Text);
                        cmd_insert.ExecuteNonQuery();

                        showBook(); // calling the method to show product

                        MessageBox.Show("One record has been added.", "Record Added",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmd_insert.Dispose();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Failed to Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close(); // close the connection
                    }
                }

            }
        }


       

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            txtBookName.Clear();
        }

        private void txtBookName_TextChanged_1(object sender, EventArgs e)
        {
            conn.Open();
            OracleCommand cmd_select = new OracleCommand("searchBook", conn);
            cmd_select.CommandType = CommandType.StoredProcedure;
            //add value for parameter of store procedure
            cmd_select.Parameters.Add("vbname", txtBookName.Text.Trim());

            OracleDataAdapter adapter = new OracleDataAdapter(cmd_select);

            DataTable dt = new DataTable();

            //fill data into dataset object: ds
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;

            dt.Dispose();
            adapter.Dispose();
            cmd_select.Dispose();
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            byte[] img = (byte[])dataGridView1.CurrentRow.Cells[11].Value;
            MemoryStream ms = new MemoryStream(img);
            BookImage.Image = Image.FromStream(ms);

            txtBookID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtBookName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtAuthor.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtBookType.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtPrice.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        

        private void txtBookName_TextChanged_2(object sender, EventArgs e)
        {
            
        }

        private void BookID_Click(object sender, EventArgs e)
        {

        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (btnPayment.Text == "Payment")
            {


                if (string.IsNullOrEmpty(txtBookName.Text))
                {
                    MessageBox.Show("Please enter QTY!", "Required QTY",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBookName.Focus();
                    return;
                }
                

                if (string.IsNullOrEmpty(txtBorrowQty.Text))
                {
                    MessageBox.Show("Please enter Return QTY!", "Required Retrun QTY",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBorrowQty.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(cboStuname.Text))
                {
                    MessageBox.Show("Please select Student Name!", "Required Student Name",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboStuname.Focus();
                    return;
                }

                else
                {
                    try
                    {
                        conn.Open(); //open the connection
                        // create memorystream object
                        MemoryStream ms = new MemoryStream();
                        BookImage.Image.Save(ms, BookImage.Image.RawFormat);
                        //create command object
                        OracleCommand cmd_insert = new OracleCommand();
                        cmd_insert.Connection = conn;
                        cmd_insert.CommandText = "ADDPAYMENT";
                        cmd_insert.CommandType = CommandType.StoredProcedure;

                        //add values for parameter of store procedure
                        cmd_insert.Parameters.Add("vbookid", Convert.ToInt32(txtBookName.Text));
                        cmd_insert.Parameters.Add("vuserid", Userlogin.getUserID());
                        cmd_insert.Parameters.Add("vpayid", cboPayment.SelectedValue);
                        cmd_insert.Parameters.Add("vstuid", cboStuname.SelectedValue);
                        cmd_insert.Parameters.Add("vprice", double.Parse(txtPrice.Text));
                        cmd_insert.Parameters.Add("vimage", OracleDbType.Blob).Value = ms.ToArray();
                        cmd_insert.Parameters.Add("vqty", double.Parse(txtBorrowQty.Text));
                        cmd_insert.ExecuteNonQuery();



                        MessageBox.Show("One record has been added.", "Record Added",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmd_insert.Dispose();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Failed to Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close(); // close the connection
                    }
                }
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBorrowQty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtBorrowQty.Text) && !string.IsNullOrEmpty(txtPrice.Text))
                {
                    txtPrice.Text = (Convert.ToInt32(txtBorrowQty.Text) * Convert.ToInt32(txtPrice.Text)).ToString();
                }
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
        }
    }
}
