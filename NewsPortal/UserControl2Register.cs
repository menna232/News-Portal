using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewsPortal
{
    public partial class UserControl2Register : UserControl
    {
        private OracleConnection conn;
        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        public UserControl2Register()
        {
            InitializeComponent();
        }

        private void UserControl2Register_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=ORCL;User Id=scott;Password=tiger;";
            conn = new OracleConnection(connectionString);
            cmd = new OracleCommand();
            cmd.Connection = conn;

            // Open the connection
            conn.Open();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Get the user data entered by the user
            string firstName = textBox4.Text;
            string lastName = textBox3.Text;
            string email = textBox5.Text;
            string password = textBox6.Text;



            if (firstName == "" || lastName == "" || email == "" || password == "")
            {
                MessageBox.Show("Please fill all the fields.");
                return;
            }


            /*Using ODP.Net connected mode:
             * 3. Select ONE row from DB using stored Procedures (Without using SysRefCursor) [use out 
                  parameters of Number data type]*/
            // Get max id and increment by 1 :
            int maxID, newID;
            OracleCommand maxIDCommand = new OracleCommand();
            maxIDCommand.Connection = conn;
            maxIDCommand.CommandText = "GetMaxUserID";
            maxIDCommand.CommandType = CommandType.StoredProcedure;
            maxIDCommand.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
            maxIDCommand.ExecuteNonQuery();

            try
            {
                maxID = Convert.ToInt32(maxIDCommand.Parameters["id"].Value.ToString());
                newID = maxID + 1;
            }
            catch
            {
                // First user to be created.
                newID = 1;
            }



            // Prepare the SQL command to insert the user into the database
            /*Using ODP.Net connected mode:
             2. Insert rows (Without using Procedures)*/
            cmd.CommandText = "INSERT INTO REGISTERED_USER (FIRST_NAME, LAST_NAME, PASSWORD_, EMAIL) VALUES (:firstName, :lastName, :password, :email)";
            cmd.Parameters.Clear();
            cmd.Parameters.Add(":firstName", OracleDbType.Varchar2, firstName, ParameterDirection.Input);
            cmd.Parameters.Add(":lastName", OracleDbType.Varchar2, lastName, ParameterDirection.Input);
            cmd.Parameters.Add(":password", OracleDbType.Varchar2, password, ParameterDirection.Input);

            cmd.Parameters.Add(":email", OracleDbType.Varchar2, email, ParameterDirection.Input);

            // Execute the command to insert the user
            int rowsAffected = cmd.ExecuteNonQuery();

            // Check if the user was inserted successfully
            if (rowsAffected > 0)
            {
                // Registration successful
                maxIDCommand.Dispose();
                MessageBox.Show("You have been registered successfully");
            }
            else
            {
                // Registration failed
                maxIDCommand.Dispose();
                MessageBox.Show("Registration failed");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
