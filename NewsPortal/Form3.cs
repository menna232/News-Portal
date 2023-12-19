using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
namespace NewsPortal
{
    public partial class Form3 : Form
    {
        CrystalReport2 crr;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            crr= new CrystalReport2();
            foreach (ParameterDiscreteValue v in crr.ParameterFields[0].DefaultValues)
                comboBox1.Items.Add(v.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crr.SetParameterValue(0, comboBox1.Text);

            crystalReportViewer1.ReportSource = crr;

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
