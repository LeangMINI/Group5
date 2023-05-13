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
    public partial class BorrowDetail : Form
    {
        OracleConnection conn = connectionDB.connect();
        public BorrowDetail()
        {
            InitializeComponent();
        }
        private void ShowBorrow()
        {
            //conn.Open();
            // int status = 0;
            OracleCommand cmd = new OracleCommand("showBorrow", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            // create dataset onbject
            DataSet ds = new DataSet();

            //fill data into dataset object: ds
            adapter.Fill(ds, "borrow");


            dataGridView1.RowTemplate.Height = 75;
            dataGridView1.DataSource = ds.Tables["borrow"];

            DataGridViewImageColumn cols = (DataGridViewImageColumn)dataGridView1.Columns[6];
            cols.ImageLayout = DataGridViewImageCellLayout.Zoom;

            ds.Dispose();
            adapter.Dispose();
            cmd.Dispose();
            //conn.Close();
        }
        private void ShowPayment()
        {
            conn.Open();
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

            // dataGridView1.DataSource = ds.Tables[0];

            ds.Dispose();
            adapter.Dispose();
            cmd.Dispose();
            conn.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            byte[] img = (byte[])dataGridView1.CurrentRow.Cells[6].Value;
            MemoryStream ms = new MemoryStream(img);
            BookImage.Image = Image.FromStream(ms);

            txtBorrowID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtUserName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtBookName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtBorrowQty.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cboPayment.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtStuname.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtBorrowDate.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtPrice.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();

        }

        private void BorrowDetail_Load(object sender, EventArgs e)
        {
            ShowBorrow();
            ShowPayment();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (btnReturn.Text == "Return Book")
            {

                if (string.IsNullOrEmpty(txtBorrowID.Text))
                {
                    MessageBox.Show("Please enter Product Name!", "Required Product Name",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBorrowID.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtBookName.Text))
                {
                    MessageBox.Show("Please enter QTY!", "Required QTY",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBookName.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtUserName.Text))
                {
                    MessageBox.Show("Please enter UnitPrice In!", "Required UnitPrice in",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUserName.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtBorrowQty.Text))
                {
                    MessageBox.Show("Please select Category Name!", "Required Category Name",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBorrowQty.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(cboPayment.Text))
                {
                    MessageBox.Show("Please enter UnitPrice In!", "Required UnitPrice in",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboPayment.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtReturn.Text))
                {
                    MessageBox.Show("Please enter UnitPrice In!", "Required UnitPrice in",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtReturn.Focus();
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
                        cmd_insert.CommandText = "addReturn";
                        cmd_insert.CommandType = CommandType.StoredProcedure;

                        //add values for parameter of store procedure
                        cmd_insert.Parameters.Add("vuserid", Userlogin.getUserID());
                        cmd_insert.Parameters.Add("vbookid",double.Parse( txtBookName.Text)); 
                        cmd_insert.Parameters.Add("vpayid", cboPayment.SelectedValue);
                        cmd_insert.Parameters.Add("vrqty", double.Parse(txtReturn.Text));
                        cmd_insert.Parameters.Add("vimage", OracleDbType.Blob).Value = ms.ToArray();
                        cmd_insert.Parameters.Add("vstuid", double.Parse(txtStuname.Text));
                        cmd_insert.Parameters.Add("vstatus", txtStatus.Text);
                        cmd_insert.Parameters.Add("vprice", double.Parse(txtPrice.Text));
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
                if (btnReturn.Text == "Return Book")
                {
                    if (string.IsNullOrEmpty(txtStatus.Text))
                    {
                        MessageBox.Show("Please enter Status!", "Required Status",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtStatus.Focus();
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
                            OracleCommand cmd_update = new OracleCommand();
                            cmd_update.Connection = conn;
                            cmd_update.CommandText = "UpdateBorrow";
                            cmd_update.CommandType = CommandType.StoredProcedure;

                            //add values for parameter of store procedure
                            cmd_update.Parameters.Add("vborrowid", Convert.ToInt32(txtBorrowID.Text));
                            cmd_update.Parameters.Add("vuserid", Userlogin.getUserID());
                            cmd_update.Parameters.Add("vbookid", double.Parse(txtBookName.Text));
                            cmd_update.Parameters.Add("vqty", double.Parse(txtBorrowQty.Text));
                            cmd_update.Parameters.Add("vpayid", cboPayment.SelectedValue);

                            cmd_update.Parameters.Add("vimage", OracleDbType.Blob).Value = ms.ToArray();
                            cmd_update.Parameters.Add("vstuid", double.Parse(txtStuname.Text));
                            cmd_update.Parameters.Add("vprice", double.Parse(txtPrice.Text));
                            cmd_update.Parameters.Add("vstatus", txtStatus.Text);

                            cmd_update.ExecuteNonQuery();

                            ShowBorrow(); // calling the method to show product

                            MessageBox.Show("One record has been added.", "Record Added",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cmd_update.Dispose();
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
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            OracleCommand cmd_select = new OracleCommand("searchBorrow", conn);
            cmd_select.CommandType = CommandType.StoredProcedure;
            //add value for parameter of store procedure
            cmd_select.Parameters.Add("vborrow", txtBookName.Text.Trim());

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
            txtSearch.Clear();
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
                if (string.IsNullOrEmpty(txtUserName.Text))
                {
                    MessageBox.Show("Please enter UnitPrice In!", "Required UnitPrice in",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUserName.Focus();
                    return;
                }
                
                if (string.IsNullOrEmpty(txtReturn.Text))
                {
                    MessageBox.Show("Please enter Return QTY!", "Required Retrun QTY",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtReturn.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtStatus.Text))
                {
                    MessageBox.Show("Please enter Status!", "Required Status",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtReturn.Focus();
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
                        cmd_insert.CommandText = "addPayment";
                        cmd_insert.CommandType = CommandType.StoredProcedure;

                        //add values for parameter of store procedure
                        cmd_insert.Parameters.Add("vbookid", Convert.ToInt32(txtBookName.Text));
                        cmd_insert.Parameters.Add("vuserid", Userlogin.getUserID());
                        cmd_insert.Parameters.Add("vpayid", cboPayment.SelectedValue);
                        cmd_insert.Parameters.Add("vstuid", double.Parse(txtStuname.Text));
                        cmd_insert.Parameters.Add("vprice", double.Parse(txtPrice.Text));
                        cmd_insert.Parameters.Add("vimage", OracleDbType.Blob).Value = ms.ToArray();
                        cmd_insert.Parameters.Add("vqty", double.Parse(txtReturn.Text));
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
    }
}
