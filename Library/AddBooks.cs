using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Library
{
    public partial class AddBooks : Form
    {
        OracleConnection conn = connectionDB.connect();
        public AddBooks()
        {
            InitializeComponent();
        }

        private void showBook()
        {
            //conn.Open();
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
            adapter.Fill(ds, "User");


            dvg1.RowTemplate.Height = 75;
            dvg1.DataSource = ds.Tables["User"];

            DataGridViewImageColumn cols = (DataGridViewImageColumn)dvg1.Columns[11];
            cols.ImageLayout = DataGridViewImageCellLayout.Zoom;

            // hide the columns of datagridview
            //dgv1.Columns[10].Visible = false;
            ds.Dispose();
            adapter.Dispose();
            cmd.Dispose();
            //conn.Close();
        }

        private void Cleartext()
        {


            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = string.Empty;

                    if (ctrl is ComboBox)
                    {
                        ctrl.Text = string.Empty;
                    }
                }
            }

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Image | *.png; *.jpg; *.jpeg; *.bmp;";
            openFileDialog1.FilterIndex = 4;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                BookImage.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            OracleCommand cmd_select = new OracleCommand("searchBook", conn);
            cmd_select.CommandType = CommandType.StoredProcedure;
            //add value for parameter of store procedure
            cmd_select.Parameters.Add("vbname", txtSearch.Text.Trim());

            OracleDataAdapter adapter = new OracleDataAdapter(cmd_select);

            DataTable dt = new DataTable();

            //fill data into dataset object: ds
            adapter.Fill(dt);

            dvg1.DataSource = dt;

            dt.Dispose();
            adapter.Dispose();
            cmd_select.Dispose();
            conn.Close();
        }
        private void AddBooks_Load(object sender, EventArgs e)
        {
            showBooktype();
            showAuthor();
            showCloset();
            showBook();
        }
        private void showBooktype()
        {

            conn.Open();
            // create command object
            OracleCommand cmd = new OracleCommand("showBooktype", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            // create data adapter object
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            // create dataset onbject
            DataSet ds = new DataSet();

            //fill data into dataset object: ds
            adapter.Fill(ds, "Booktype");

            CboType.DataSource = ds.Tables[0];
            CboType.DisplayMember = "Booktype";
            CboType.ValueMember = "BooktypeID";

            ds.Dispose();
            adapter.Dispose();
            cmd.Dispose();
            conn.Close();

        }
        private void showAuthor()
        {
            conn.Open();
            // create command object
            OracleCommand cmd = new OracleCommand("showAuthor", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            // create data adapter object
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            // create dataset onbject
            DataSet ds = new DataSet();

            //fill data into dataset object: ds
            adapter.Fill(ds, "Author");

            CboAuthor.DataSource = ds.Tables[0];
            CboAuthor.DisplayMember = "AuthorName";
            CboAuthor.ValueMember = "AuthorID";

            ds.Dispose();
            adapter.Dispose();
            cmd.Dispose();
            conn.Close();
        }

        private void showCloset()
        {
            conn.Open();
            // create command object
            OracleCommand cmd = new OracleCommand("showCloset", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            // create data adapter object
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            // create dataset onbject
            DataSet ds = new DataSet();

            //fill data into dataset object: ds
            adapter.Fill(ds, "Category");

            CboCompare.DataSource = ds.Tables[0];
            CboCompare.DisplayMember = "Closet";
            CboCompare.ValueMember = "ClosetID";

            ds.Dispose();
            adapter.Dispose();
            cmd.Dispose();
            conn.Close();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddNew_Click_1(object sender, EventArgs e)
        {
            if (btnAddNew.Text == "Add Book")
            {
                btnAddNew.Text = "Save";
                btnDelete.Text = "Cancel";
                btnUpdate.Enabled = false;
                txtaddQTY.Enabled = false;
                //btnRestore.Enabled = false;
                //clear method
                Cleartext();
                txtBookName.Focus();
            }
            else if (btnAddNew.Text == "Save")
            {
                if (string.IsNullOrEmpty(txtBookName.Text))
                {
                    MessageBox.Show("Please enter Product Name!", "Required Product Name",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBookName.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(CboType.Text))
                {
                    MessageBox.Show("Please enter QTY!", "Required QTY",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CboType.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtYear.Text))
                {
                    MessageBox.Show("Please enter UnitPrice In!", "Required UnitPrice in",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtYear.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(CboAuthor.Text))
                {
                    MessageBox.Show("Please enter Unitprice out!", "Required Unit priceout",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CboAuthor.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(CboCompare.Text))
                {
                    MessageBox.Show("Please select Category Name!", "Required Category Name",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CboCompare.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtFloor.Text))
                {
                    MessageBox.Show("Please enter UnitPrice In!", "Required UnitPrice in",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtFloor.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtQty.Text))
                {
                    MessageBox.Show("Please enter UnitPrice In!", "Required UnitPrice in",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtQty.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtPrice.Text))
                {
                    MessageBox.Show("Please enter UnitPrice In!", "Required UnitPrice in",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPrice.Focus();
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
                        cmd_insert.CommandText = "addBook";
                        cmd_insert.CommandType = CommandType.StoredProcedure;

                        //add values for parameter of store procedure
                        
                        cmd_insert.Parameters.Add("vbname", txtBookName.Text);
                        cmd_insert.Parameters.Add("vbtype", CboType.SelectedValue);
                        cmd_insert.Parameters.Add("vbyear", txtYear.Text);
                        cmd_insert.Parameters.Add("vbauthor", CboAuthor.SelectedValue);
                        cmd_insert.Parameters.Add("vbcloset", CboCompare.SelectedValue);
                        cmd_insert.Parameters.Add("vbfloor", txtFloor.Text);
                        cmd_insert.Parameters.Add("vbby", Userlogin.getUserName());
                        cmd_insert.Parameters.Add("vbdate", DateTime.Now);
                        cmd_insert.Parameters.Add("vbprice", double.Parse(txtPrice.Text));
                        cmd_insert.Parameters.Add("vbqty", double.Parse(txtQty.Text));
                        cmd_insert.Parameters.Add("vbimage", OracleDbType.Blob).Value = ms.ToArray();
                        cmd_insert.ExecuteNonQuery();

                        btnAddNew.Text = "Add New";
                        btnDelete.Text = "Delete";
                        btnUpdate.Enabled = true;
                        txtQty.Enabled = false;
                       // btnRestore.Enabled = true;

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

        private void btnDelete_Click_1(object sender, EventArgs e)
        {

            if (btnDelete.Text == "Cancel")
            {
                btnAddNew.Text = "Add Book";
                btnDelete.Text = "Delete";
                btnUpdate.Enabled = true;
                //clear method
                Cleartext(); 
            }
            else if (btnDelete.Text == "Delete")
            {
                if (string.IsNullOrEmpty(txtBookID.Text))
                {
                    MessageBox.Show("Please select a category that you want to delate.", "No Category Selected",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show("Are you sure! you want to delete'" + txtBookName.Text + "'?",
                        "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            conn.Open();
                            OracleCommand cmd_Delete = new OracleCommand("DeleteBook", conn);
                            cmd_Delete.CommandType = CommandType.StoredProcedure;

                            //set value for parameter
                            cmd_Delete.Parameters.Add("vbookid", Convert.ToInt32(txtBookID.Text));
                            //cmd_Delete.Parameters.Add("isDeleted", 1);
                            cmd_Delete.ExecuteNonQuery();
                            // calling the method to show the category
                            showBook();
                            Cleartext();
                            MessageBox.Show("One record has been delated. ", "Booktype Deleted",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cmd_Delete.Dispose();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Failed to delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            conn.Close();
                        }
                    }
                }
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBookID.Text))
            {
                MessageBox.Show("Please select a Category that you want to update", "No Category Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (string.IsNullOrEmpty(txtQty.Text))
            {
                MessageBox.Show("Please select a Category that you want to update", "No Category Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (string.IsNullOrEmpty(txtBookName.Text))
                {
                    MessageBox.Show("Category Name cannot be null!", "Required Category Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBookName.Focus();
                }
                else
                {
                    try
                    {
                        conn.Open(); //open the connection
                        //create command object
                        MemoryStream ms = new MemoryStream();
                        BookImage.Image.Save(ms, BookImage.Image.RawFormat);
                        //Userimage.Image.Save(ms, Userimage.Image.RawFormat);

                        OracleCommand cmd_update = new OracleCommand();
                        cmd_update.Connection = conn;
                        cmd_update.CommandText = "UPDATEBOOK";
                        cmd_update.CommandType = CommandType.StoredProcedure;

                        //set values for parameters
                        
                        
                        cmd_update.Parameters.Add("vbname", txtBookName.Text);
                        cmd_update.Parameters.Add("vbtype", CboType.SelectedValue);
                        cmd_update.Parameters.Add("vbyear", txtYear.Text);
                        cmd_update.Parameters.Add("vbauthor", CboAuthor.SelectedValue);
                        cmd_update.Parameters.Add("vbcloset", CboCompare.SelectedValue);
                        cmd_update.Parameters.Add("vbfloor", txtFloor.Text);
                        cmd_update.Parameters.Add("vupdateby", Userlogin.getUserName());
                        cmd_update.Parameters.Add("vudate", DateTime.Now);
                        
                        cmd_update.Parameters.Add("vbprice", double.Parse(txtPrice.Text));
                        cmd_update.Parameters.Add("vbqty", double.Parse(txtQty.Text));
                        cmd_update.Parameters.Add("vbimage", OracleDbType.Blob).Value = ms.ToArray();
                        cmd_update.Parameters.Add("vbid", double.Parse(txtBookID.Text));

                        cmd_update.ExecuteNonQuery();
                        

                        // calling the method to show the category
                        showBook();
                        MessageBox.Show("One record has been updated", "Required Updated",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Required Update Failed",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            int input1 = Convert.ToInt32(txtQty.Text);
            
            int input2 = Convert.ToInt32(txtaddQTY.Text);
            int result = input1 + input2;
            txtQty.Text = result.ToString();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

            txtBookID.Text =  dvg1.CurrentRow.Cells[0].Value.ToString();
            byte[] img = (byte[])dvg1.CurrentRow.Cells[11].Value;
            MemoryStream ms = new MemoryStream(img);
            BookImage.Image = Image.FromStream(ms);
            txtBookName.Text = dvg1.CurrentRow.Cells[1].Value.ToString();
            CboType.Text = dvg1.CurrentRow.Cells[2].Value.ToString();
            txtYear.Text = dvg1.CurrentRow.Cells[3].Value.ToString();
            CboAuthor.Text = dvg1.CurrentRow.Cells[4].Value.ToString();
            CboCompare.Text = dvg1.CurrentRow.Cells[5].Value.ToString();
            txtFloor.Text = dvg1.CurrentRow.Cells[6].Value.ToString();
            txtPrice.Text = dvg1.CurrentRow.Cells[12].Value.ToString();
            txtQty.Text = dvg1.CurrentRow.Cells[13].Value.ToString();
            
            
        }

        private void gunaLabel11_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel5_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            conn.Open();
            OracleCommand cmd_select = new OracleCommand("searchbook", conn);
            cmd_select.CommandType = CommandType.StoredProcedure;
            //add value for parameter of store procedure
            cmd_select.Parameters.Add("vbname", txtBookName.Text.Trim());

            OracleDataAdapter adapter = new OracleDataAdapter(cmd_select);

            DataTable dt = new DataTable();

            //fill data into dataset object: ds
            adapter.Fill(dt);

            dvg1.DataSource = dt;

            dt.Dispose();
            adapter.Dispose();
            cmd_select.Dispose();
            conn.Close();
        }
    }

}
