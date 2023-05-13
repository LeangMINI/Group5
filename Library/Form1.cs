using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace Library
{
    public partial class Form1 : Form
    {
        OracleConnection conn = connectionDB.connect();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("UserName is required!", "Missing UserName",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Password is required!", "Missing Password",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
            }
            else
            {
                try
                {
                    conn.Open();// open the connction

                    //if (txtUsername.Text == "" || txtPassword.Text == "")
                    // {
                    // MessageBox.Show(" Enter UserName and Password .");
                    // return;
                    //}

                    OracleCommand cmd = new OracleCommand("SELECT * FROM tblUser where UserName=:UserName and Password=:Password", conn);
                    cmd.Parameters.Add(new OracleParameter(":UserName", txtUsername.Text));
                    cmd.Parameters.Add(new OracleParameter(":Password", txtPassword.Text));

                    OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    //int i = dt.Tables[0].Rows.Count;
                    int i = dt.Rows.Count;  

                    dt.Dispose();
                    adapter.Dispose();
                    cmd.Dispose();
                    conn.Close();
                    if (i == 1)
                    {
                        Dashboard frm = new Dashboard();
                        this.Hide(); // hide login form
                        frm.Show(); // show main form
                    }
                    else
                    {
                        MessageBox.Show("Failed to login the User ", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                finally
                {
                    conn.Close();
                }
            }
        }*/
        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Clear();
            }
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("UserName is required!", "Missing UserName",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Password is required!", "Missing Password",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
            }
            else
            {
                try
                {
                    conn.Open();// open the connction

                    //if (txtUsername.Text == "" || txtPassword.Text == "")
                    // {
                    // MessageBox.Show(" Enter UserName and Password .");
                    // return;
                    //}

                    OracleCommand cmd = new OracleCommand("SELECT * FROM tblUser where UserName=:UserName and Password=:Password", conn);
                    cmd.Parameters.Add(new OracleParameter(":UserName", txtUsername.Text));
                    cmd.Parameters.Add(new OracleParameter(":Password", txtPassword.Text));

                    OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    //int i = dt.Tables[0].Rows.Count;
                    int i = dt.Rows.Count;

                    dt.Dispose();
                    adapter.Dispose();
                    cmd.Dispose();
                    conn.Close();
                    if (i == 1)
                    {
                        Userlogin.setUserID(dt.Rows[0]["UserID"].ToString());
                        Userlogin.setUserName(dt.Rows[0]["UserName"].ToString());
                        Userlogin.setUserPassword(dt.Rows[0]["Password"].ToString());
                        Dashboard frm = new Dashboard();
                        this.Hide(); // hide login form
                        frm.Show(); // show main form
                    }
                    else
                    {
                        MessageBox.Show("Failed to login the User ", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    conn.Close();
                }
            }
        }


        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Clear();
            }
        }

/*        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            panelRegister.Visible = true;
            guna2Transition1.ShowSync(panelRegister);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            panelRegister.Visible = false;
            guna2Transition1.HideSync(panelRegister);
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
