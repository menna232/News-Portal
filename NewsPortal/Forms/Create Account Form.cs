using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewsPortal.Forms
{
    public partial class Create_Account_Form : Form
    {

       
        public Create_Account_Form()
        {
            InitializeComponent();

        }

        private void Create_Account_Form_Load(object sender, EventArgs e)
        {
            
             LoadTheme();
           
            userControlLogin1.Visible = true;
            userControl2Register1.Visible = false;

        }




        


        //it will apply the same theme in the buttons only
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }

        }

        private void lblPortalName_Click(object sender, EventArgs e)
        {

        }

        private void userControlLogin1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSwatch_Click(object sender, EventArgs e)
        {
            userControlLogin1.Visible = false;
            userControl2Register1.Visible = true;
        }

        private void userControl2Register1_Load(object sender, EventArgs e)
        {

        }
    }



}

