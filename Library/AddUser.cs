using Oracle.ManagedDataAccess.Client;
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



namespace Library
{
    public partial class AddUser : Form
    {
        OracleConnection conn = connectionDB.connect();
        public AddUser()
        {
            InitializeComponent();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            ShowUser();
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

        private void ShowUser()
        {
            //conn.Open();
            // int status = 0;
            OracleCommand cmd = new OracleCommand("showuser", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            // add value for parameterr of store procedure
            //cmd.Parameters.Add("visdeleted", status);
            // create data adapter object
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            // create dataset onbject
            DataSet ds = new DataSet();

            //fill data into dataset object: ds
            adapter.Fill(ds, "User");


            dvg1.RowTemplate.Height = 75;
            dvg1.DataSource = ds.Tables["User"];

            DataGridViewImageColumn cols = (DataGridViewImageColumn)dvg1.Columns[8];
            cols.ImageLayout = DataGridViewImageCellLayout.Zoom;

            // hide the columns of datagridview
            //dgv1.Columns[10].Visible = false;
            ds.Dispose();
            adapter.Dispose();
            cmd.Dispose();
            //conn.Close();
        }

       

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Image | *.png; *.jpg; *.jpeg; *.bmp;";
            openFileDialog1.FilterIndex = 4;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Userimage.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (btnAddNew.Text == "Add New")
            {
                btnAddNew.Text = "Save";
                btnDelete.Text = "Cancel";
                btnUpdate.Enabled = false;
                //btnRestore.Enabled = false;
                //clear method
                //Cleartext.Clear(this);
                txtStuName.Focus();
            }
            else if (btnAddNew.Text == "Save")
            {
                if (string.IsNullOrEmpty(txtStuName.Text))
                {
                    MessageBox.Show("Please enter Product Name!", "Required Product Name",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtStuName.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Please enter QTY!", "Required QTY",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPassword.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtGender.Text))
                {
                    MessageBox.Show("Please enter UnitPrice In!", "Required UnitPrice in",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtGender.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtPOB.Text))
                {
                    MessageBox.Show("Please enter Unitprice out!", "Required Unit priceout",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPOB.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtPhone.Text))
                {
                    MessageBox.Show("Please select Category Name!", "Required Category Name",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPhone.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtAddress.Text))
                {
                    MessageBox.Show("Please select Category Name!", "Required Category Name",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAddress.Focus();
                    return;
                }
                else
                {
                    try
                    {
                        conn.Open(); //open the connection
                        // create memorystream object
                        MemoryStream ms = new MemoryStream();
                        Userimage.Image.Save(ms, Userimage.Image.RawFormat);
                        //create command object
                        OracleCommand cmd_insert = new OracleCommand();
                        cmd_insert.Connection = conn;
                        cmd_insert.CommandText = "addUser";
                        cmd_insert.CommandType = CommandType.StoredProcedure;

                        //add values for parameter of store procedure

                        cmd_insert.Parameters.Add("vpname", txtStuName.Text);
                        cmd_insert.Parameters.Add("vpdesc", txtPassword.Text);
                        cmd_insert.Parameters.Add("vcatid", txtGender.Text);
                        cmd_insert.Parameters.Add("vdob", DateTimePicker1.Value);
                        cmd_insert.Parameters.Add("vpob", txtPOB.Text);
                        cmd_insert.Parameters.Add("vphone", txtPhone.Text);
                        cmd_insert.Parameters.Add("vaddress", txtAddress.Text);
                        cmd_insert.Parameters.Add("vimage", OracleDbType.Blob).Value = ms.ToArray();
                        cmd_insert.ExecuteNonQuery();

                        btnAddNew.Text = "Add New";
                        btnDelete.Text = "Delete";
                        btnUpdate.Enabled = true;
                        //  btnRestore.Enabled = true;

                        ShowUser(); // calling the method to show product

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

        private void dvg1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

            txtstuID.Text = dvg1.CurrentRow.Cells[0].Value.ToString();
            txtStuName.Text = dvg1.CurrentRow.Cells[1].Value.ToString();
            txtPassword.Text = dvg1.CurrentRow.Cells[2].Value.ToString();
            txtGender.Text = dvg1.CurrentRow.Cells[3].Value.ToString();
            //BookImage.Text = dvg1.CurrentRow.Cells[11].Value.ToString();
            DateTimePicker1.Text = dvg1.CurrentRow.Cells[4].Value.ToString();
            txtPOB.Text = dvg1.CurrentRow.Cells[5].Value.ToString();
            txtPhone.Text = dvg1.CurrentRow.Cells[6].Value.ToString();
            txtAddress.Text = dvg1.CurrentRow.Cells[7].Value.ToString();
            byte[] img = (byte[])dvg1.CurrentRow.Cells[8].Value;
            MemoryStream ms = new MemoryStream(img);
            Userimage.Image = Image.FromStream(ms);
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtstuID.Text))
            {
                MessageBox.Show("Please select a Category that you want to update", "No Category Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (string.IsNullOrEmpty(txtStuName.Text))
                {
                    MessageBox.Show("Category Name cannot be null!", "Required Category Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtStuName.Focus();
                }
                else
                {
                    try
                    {
                        conn.Open(); //open the connection
                        //create command object
                        MemoryStream ms = new MemoryStream();
                        Userimage.Image.Save(ms, Userimage.Image.RawFormat);
                        //Userimage.Image.Save(ms, Userimage.Image.RawFormat);

                        OracleCommand cmd_update = new OracleCommand();
                        cmd_update.Connection = conn;
                        cmd_update.CommandText = "UPDATEUSER";
                        cmd_update.CommandType = CommandType.StoredProcedure;

                        //set values for parameters

                        
                        cmd_update.Parameters.Add("vname", txtStuName.Text);
                        cmd_update.Parameters.Add("vpass", txtPassword.Text);
                        cmd_update.Parameters.Add("vgender", txtGender.Text);
                        cmd_update.Parameters.Add("vdob", DateTimePicker1.Value);
                        cmd_update.Parameters.Add("vpob", txtPOB.Text);
                        cmd_update.Parameters.Add("vphone", txtPhone.Text);
                        cmd_update.Parameters.Add("vaddress", txtAddress);
                        cmd_update.Parameters.Add("vphoto", OracleDbType.Blob).Value = ms.ToArray();
                        cmd_update.Parameters.Add("vid", Convert.ToInt32(txtstuID.Text));


                        cmd_update.ExecuteNonQuery();

                        // calling the method to show the category
                        ShowUser();
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
                //clear method
                Cleartext();
            }
            else if (btnDelete.Text == "Delete")
            {
                if (string.IsNullOrEmpty(txtstuID.Text))
                {
                    MessageBox.Show("Please select a student that you want to delate.", "No Student Selected",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show("Are you sure! you want to delete'" + txtStuName.Text + "'?",
                        "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            conn.Open();
                            OracleCommand cmd_Delete = new OracleCommand("Deleteuser", conn);
                            cmd_Delete.CommandType = CommandType.StoredProcedure;

                            //set value for parameter
                            cmd_Delete.Parameters.Add("vuserid", Convert.ToInt32(txtstuID.Text));
                            //cmd_Delete.Parameters.Add("isDeleted", 1);
                            cmd_Delete.ExecuteNonQuery();
                            // calling the method to show the category
                            ShowUser();
                            Cleartext();
                            MessageBox.Show("One record has been delated. ", "Student Deleted",
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

        private void txtstuID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            OracleCommand cmd_select = new OracleCommand("searchuser", conn);
            cmd_select.CommandType = CommandType.StoredProcedure;
            //add value for parameter of store procedure
            cmd_select.Parameters.Add("vname", txtStuName.Text.Trim());

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
