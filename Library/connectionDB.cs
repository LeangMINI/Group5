using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;

namespace Library
{
    class connectionDB
    {
        //data member , static field
        private static OracleConnection conn;


        // static method
        public static OracleConnection connect()
        {
            try
            {
                conn = new OracleConnection();
                conn.ConnectionString = "Data Source = localhost:1521/ORCLPDB ; User ID = library; Password = 123;";
                // conn.Open();
                //MessageBox.Show("Connect to database is OK!");
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Failed to connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
