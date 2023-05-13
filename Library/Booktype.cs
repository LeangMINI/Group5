using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;


namespace Library
{
    public partial class Booktype : Form
    {
        OracleConnection conn = connectionDB.connect(); // Calling the static method
        public Booktype()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (btnAddNew.Text == "Add New")
            {
                btnAddNew.Text = "Save";
                btnDelete.Text = "Cancel";
                btnUpdate.Enabled = false;
                // clear text of textbox
                txtBooktypeID.Clear();
                txtBooktype.Clear();
                txtDescription.Clear();
                txtBooktype.Focus();
            }
            else if (btnAddNew.Text == "Save")
            {
                if (string.IsNullOrEmpty(txtBooktype.Text))
                {
                    MessageBox.Show("Please enter Category Name!", "Required Category Name",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        conn.Open(); //open the connection
                        //create command object
                        OracleCommand cmd_insert = new OracleCommand();
                        cmd_insert.Connection = conn;
                        cmd_insert.CommandText = "addBooktype";
                        cmd_insert.CommandType = CommandType.StoredProcedure;

                        //add values for parameter of store procedure
                        cmd_insert.Parameters.Add("vbooktype", txtBooktype.Text);
                        cmd_insert.Parameters.Add("vdesc", txtDescription.Text);
                        //cmd_insert.Parameters.Add("vby", "Khunhy");
                        cmd_insert.ExecuteNonQuery();

                        btnAddNew.Text = "Add New";
                        btnDelete.Text = "Delete";
                        btnUpdate.Enabled = true;
                        showBooktype(); // calling the method to show categories
                        MessageBox.Show("One record has been added.", "Record Added",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void showBooktype()
        {
            //conn.Open();
            // create command object
            OracleCommand cmd = new OracleCommand("showBooktype", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            // create data adapter object
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            // create dataset onbject
            DataSet ds = new DataSet();

            //fill data into dataset object: ds
            adapter.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

            ds.Dispose();
            adapter.Dispose();
            cmd.Dispose();
            //conn.Close();
        }

        private void Booktype_Load(object sender, EventArgs e)
        {
            showBooktype();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBooktypeID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtBooktype.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtDescription.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            OracleCommand cmd_select = new OracleCommand("searchBooktype", conn);
            cmd_select.CommandType = CommandType.StoredProcedure;
            //add value for parameter of store procedure
            cmd_select.Parameters.Add("vbtype", txtSearch.Text.Trim());

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (btnDelete.Text == "Cancel")
            {
                btnAddNew.Text = "Add New";
                btnDelete.Text = "Delete";
                btnUpdate.Enabled = true;
            }
            else if (btnDelete.Text == "Delete")
            {
                if (string.IsNullOrEmpty(txtBooktypeID.Text))
                {
                    MessageBox.Show("Please select a category that you want to delate.", "No Category Selected",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show("Are you sure! you want to delete'" + txtBooktype.Text + "'?",
                        "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            conn.Open();
                            OracleCommand cmd_Delete = new OracleCommand("DeleteBooktype", conn);
                            cmd_Delete.CommandType = CommandType.StoredProcedure;

                            //set value for parameter
                            cmd_Delete.Parameters.Add("vid", Convert.ToInt32(txtBooktypeID.Text));
                            //cmd_Delete.Parameters.Add("isDeleted", 1);
                            cmd_Delete.ExecuteNonQuery();
                            // calling the method to show the category
                            showBooktype();
                            ClearText();
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
        private void ClearText()
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
        
                if (string.IsNullOrEmpty(txtBooktypeID.Text))
                {
                    MessageBox.Show("Please select a Category that you want to update", "No Category Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (string.IsNullOrEmpty(txtBooktype.Text))
                    {
                        MessageBox.Show("Category Name cannot be null!", "Required Category Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtBooktype.Focus();
                    }
                    else
                    {
                        try
                        {
                            conn.Open(); //open the connection
                                         //create command object
                            OracleCommand cmd_update = new OracleCommand();
                            cmd_update.Connection = conn;
                            cmd_update.CommandText = "UpdateBooktype";
                            cmd_update.CommandType = CommandType.StoredProcedure;

                            //set values for parameters

                            cmd_update.Parameters.Add("vbooktype", txtBooktype.Text);
                            cmd_update.Parameters.Add("vdesc", txtDescription.Text);
                            cmd_update.Parameters.Add("vbtypeid", Convert.ToInt32(txtBooktypeID.Text));
                            cmd_update.ExecuteNonQuery();

                            // calling the method to show the category
                            showBooktype();
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
    }
}
