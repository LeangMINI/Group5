using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
using Oracle.ManagedDataAccess.Client;

namespace Library
{
    public partial class Payment : Form
    {
        OracleConnection conn = connectionDB.connect();
        public Payment()
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
                //clear method
                //Cleartext.Clear(this);
                txtpayment.Focus();
            }
            else if (btnAddNew.Text == "Save")
            {
                if (string.IsNullOrEmpty(txtpayment.Text))
                {
                    MessageBox.Show("Please enter Product Name!", "Required Product Name",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtpayment.Focus();
                    return;
                }

                else
                {
                    try
                    {
                        conn.Open(); //open the connection
                                     // create memorystream object

                        //create command object
                        OracleCommand cmd_insert = new OracleCommand();
                        cmd_insert.Connection = conn;
                        cmd_insert.CommandText = "addPayDetails";
                        cmd_insert.CommandType = CommandType.StoredProcedure;

                        //add values for parameter of store procedure

                        cmd_insert.Parameters.Add("vpay", txtpayment.Text);


                        cmd_insert.ExecuteNonQuery();

                        btnAddNew.Text = "Add New";
                        btnDelete.Text = "Delete";
                        btnUpdate.Enabled = true;

                        ShowPayment(); // calling the method to show product

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
        private void ShowPayment()
        {
            OracleCommand cmd = new OracleCommand("showpaydetails", conn);
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
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Payment_Load(object sender, EventArgs e)
        {
            ShowPayment();
        }
    }
}
