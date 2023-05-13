using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace Library
{
    public partial class BookCloset : Form
    {
        OracleConnection conn = connectionDB.connect(); // Calling the static method
        public BookCloset()
        {
            InitializeComponent();
        }


        private void showCloset()
        {
            OracleCommand cmd = new OracleCommand("showCloset", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            // create data adapter object
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            // create dataset onbject
            DataSet ds = new DataSet();

            //fill data into dataset object: ds
            adapter.Fill(ds);

            dgv.DataSource = ds.Tables[0];

            ds.Dispose();
            adapter.Dispose();
            cmd.Dispose();
        }

        private void BookCloset_Load(object sender, EventArgs e)
        {
            showCloset();
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


        private void btnAddNew_Click_1(object sender, EventArgs e)
        {
            if (btnAddNew.Text == "Add New")
            {
                btnAddNew.Text = "Save";
                btnDelete.Text = "Cancel";
                btnUpdate.Enabled = false;
                // clear text of textbox
                txtClosetID.Clear();
                txtCloset.Clear();
                txtCloset.Focus();
            }
            else if (btnAddNew.Text == "Save")
            {
                if (string.IsNullOrEmpty(txtCloset.Text))
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
                        cmd_insert.CommandText = "addCloset";
                        cmd_insert.CommandType = CommandType.StoredProcedure;

                        //add values for parameter of store procedure
                        cmd_insert.Parameters.Add("vcloset", txtCloset.Text);

                        cmd_insert.ExecuteNonQuery();

                        btnAddNew.Text = "Add New";
                        btnDelete.Text = "Delete";
                        btnUpdate.Enabled = true;
                        showCloset(); // calling the method to show categories
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

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            conn.Open();
            OracleCommand cmd_select = new OracleCommand("searchCloset", conn);
            cmd_select.CommandType = CommandType.StoredProcedure;
            //add value for parameter of store procedure
            cmd_select.Parameters.Add("vcloset", txtSearch.Text.Trim());

            OracleDataAdapter adapter = new OracleDataAdapter(cmd_select);

            DataTable dt = new DataTable();

            //fill data into dataset object: ds
            adapter.Fill(dt);

            dgv.DataSource = dt;

            dt.Dispose();
            adapter.Dispose();
            cmd_select.Dispose();
            conn.Close();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClosetID.Text))
            {
                MessageBox.Show("Please select a Category that you want to update", "No Category Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (string.IsNullOrEmpty(txtCloset.Text))
                {
                    MessageBox.Show("Category Name cannot be null!", "Required Category Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCloset.Focus();
                }
                else
                {
                    try
                    {
                        conn.Open(); //open the connection
                        //create command object
                        OracleCommand cmd_update = new OracleCommand();
                        cmd_update.Connection = conn;
                        cmd_update.CommandText = "UpdateCloset";
                        cmd_update.CommandType = CommandType.StoredProcedure;

                        //set values for parameters

                        cmd_update.Parameters.Add("vcloset", txtCloset.Text);
                        cmd_update.Parameters.Add("vcid", Convert.ToInt32(txtClosetID.Text));
                        cmd_update.ExecuteNonQuery();

                        // calling the method to show the category
                        showCloset();
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

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (btnDelete.Text == "Cancel")
            {
                btnAddNew.Text = "Add New";
                btnDelete.Text = "Delete";
                btnUpdate.Enabled = true;
            }
            else if (btnDelete.Text == "Delete")
            {
                if (string.IsNullOrEmpty(txtClosetID.Text))
                {
                    MessageBox.Show("Please select a category that you want to delate.", "No Category Selected",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show("Are you sure! you want to delete'" + txtCloset.Text + "'?",
                        "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            conn.Open();
                            OracleCommand cmd_Delete = new OracleCommand("DeleteCloset", conn);
                            cmd_Delete.CommandType = CommandType.StoredProcedure;

                            //set value for parameter
                            cmd_Delete.Parameters.Add("vid", Convert.ToInt32(txtClosetID.Text));
                            //cmd_Delete.Parameters.Add("isDeleted", 1);
                            cmd_Delete.ExecuteNonQuery();
                            // calling the method to show the category
                            showCloset();
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

        private void dgv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtClosetID.Text = dgv.CurrentRow.Cells[0].Value.ToString();
            txtCloset.Text = dgv.CurrentRow.Cells[1].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
