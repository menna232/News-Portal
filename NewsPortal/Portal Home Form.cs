using NewsPortal.Forms;
using static NewsPortal.UserControlLogin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NewsPortal.Forms
{
    public partial class Portal_Home_Form : Form
    {
        // disconnected
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;

        // connected
        OracleConnection conn;
        string ordb = "Data Source=ORCL;User Id = scott;Password=tiger";
        
        bool mousedown;

        public Portal_Home_Form()
        {
            InitializeComponent();
        }

        private void minimize_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void resize_button_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
        private void close_button_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void info_button_Click(object sender, EventArgs e)
        {
            info_panel.BringToFront();
        }
        String constr = "Data Source=orcl; User Id=scott;password=tiger;";
        private void personal_info_button_Click(object sender, EventArgs e)
        {
            if (userId > 0)
            {
                personal_info_panel.BringToFront();
                //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$

                /*
                 * Using ODP.Net Disconnected mode:
                 1. Select certain rows for a given value entered by the user on the form
                 */
                String cmdstr = @"select * 
                              from registered_user r 
                              where r.user_id = :id ";
                // first_name,last_name,password_
                adapter = new OracleDataAdapter(cmdstr, constr);
                //take the loged in user id
                adapter.SelectCommand.Parameters.Add("id", userId); //MessageBox.Show(userId.ToString());
                ds = new DataSet();
                adapter.Fill(ds);

                //assigning to the textbox
                first_name_textBox.AppendText(ds.Tables[0].Rows[0][1].ToString());
                last_name_textBox.AppendText(ds.Tables[0].Rows[0][2].ToString());
                pi_dataGridView.DataSource = ds.Tables[0];
                //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
            }
        }
        private void favorite_list_button_Click(object sender, EventArgs e)
        {
            if (userId > 0)
            {
                favorite_list_panel.BringToFront();
                //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$

                conn = new OracleConnection(ordb);
                conn.Open();

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                /*
                 * Using ODP.Net connected mode:
                 * 4. Select multiple rows from DB using stored procedures.
                 */
                cmd.CommandText = "GET_USER_FAVORITES";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("userId_vspar", userId);
                cmd.Parameters.Add("fav_art_vspar", OracleDbType.RefCursor, ParameterDirection.Output);

                OracleDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    //fl_listView.Items.Add(dr[0].ToString());
                    string name = dr[0].ToString();
                    string description = dr[1].ToString();
                    //fl_listView.Items.Add(name + ": " + description);
                    //fl_listView.Items.Add(dr[0].ToString());
                    //fl_listView.Items.Add(dr[1].ToString());

                    ListViewItem item = new ListViewItem(name);
                    item.SubItems.Add(description);
                    fl_listView.Items.Add(item);
                }
                dr.Close();

                //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
            }
        }
        private void home_button_Click(object sender, EventArgs e)
        {
            home_panel.BringToFront();
            //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$

           
            

            //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
        }
        private void info_close_button_Click(object sender, EventArgs e)
        {
            info_panel.SendToBack();
        }

        private void personal_info_close_button_Click(object sender, EventArgs e)
        {
            home_panel.BringToFront();
        }
        private void favorite_list_close_button_Click(object sender, EventArgs e)
        {
            home_panel.BringToFront();
        }
        private void save_pi_button_Click(object sender, EventArgs e)
        {
            //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
            /*Using ODP.Net Disconnected mode:
             2. Update using oracle command builder
             */
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
            
            //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
            MessageBox.Show("Saved");
        }

        private void title_bar_panel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void title_bar_panel_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
        }
        private void title_bar_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                int mousex = MousePosition.X - 300;
                int mousey = MousePosition.Y - 20;
                this.SetDesktopLocation(mousex, mousey);
            }
        }
        private void title_bar_panel_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            /*
             * Using ODP.Net Disconnected mode:
             1. Select certain rows for a given value entered by the user on the form
             */

            String constr = "Data Source=orcl; User Id=scott;password=tiger;";
            string cmdstr = "";
            if (radioButton1.Checked)
            {
                cmdstr = "select * from Article";
            }
           
           
            adapter = new OracleDataAdapter(cmdstr, constr);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
