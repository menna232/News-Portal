using NewsPortal.Forms;
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
    public partial class UserControlLogin : UserControl
    {
        private OracleConnection conn;
        private OracleDataAdapter adapter;
        private OracleCommand cmd;

        public bool userFound = false;
        public static int userId;
        public UserControlLogin()
        {
            InitializeComponent();
        }

        private void UserControlLogin_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=ORCL;User Id=scott;Password=tiger;";
            conn = new OracleConnection(connectionString);
            adapter = new OracleDataAdapter();
            cmd = new OracleCommand();
            cmd.Connection = conn;
            adapter.SelectCommand = cmd;

            // Open the connection
            conn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the email and password entered by the user
            string email = textBox2.Text;
            string password = textBox1.Text;
            if (email == "" || password == "")
            {
                MessageBox.Show("Please fill all the fields.");
                return;
            }
            // Prepare the SQL command to select the user from the database
            /*Using ODP.Net connected mode:
             1. Select rows from DB using bind variables and command parameters*/
            string sql = "SELECT * FROM REGISTERED_USER WHERE EMAIL = :email AND PASSWORD_ = :password";
            cmd.CommandText = sql;
            cmd.Parameters.Clear();

            cmd.Parameters.Add(":email", OracleDbType.Varchar2, email, ParameterDirection.Input);
            cmd.Parameters.Add(":password", OracleDbType.Varchar2, password, ParameterDirection.Input);



            // Execute the command to select the user
            OracleDataReader reader = cmd.ExecuteReader();

            // Check if a user was found with the entered email and password
            if (reader.HasRows)
            {
                // Login successful
                MessageBox.Show("Login successful");
                userFound = true;

                // Get the value of the user_id parameter
                userId = Convert.ToInt32(reader["USER_ID"]);

                Portal_Home_Form p = new Portal_Home_Form();
                p.Show();
                this.Hide();
            }

            else
            {
                // Login failed
                MessageBox.Show("Invalid email or password");
            }
            reader.Close();
        }
    }
}