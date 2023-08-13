using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeCare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double bmi = 0;
        private void btnShowBmi_Click(object sender, EventArgs e)
        {
            try
            {
                bmi = double.Parse(txtWeight.Text) / (double.Parse(txtHeight.Text) * double.Parse(txtHeight.Text));
                MessageBox.Show("Your BMI rate is " + bmi.ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Enter required information Correctly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }           
        }

        private void btnBloodScreen_Click(object sender, EventArgs e)
        {
            try
            { 
            if (bmi>25)
            {
                txtResult.Text = "Take an initial Blood screen test immediately";
            }
             else if (rabYes.Checked)
            {
                txtResult.Text = "Take a Blood screen test per every year";
            }
            else if (int.Parse(txtAge.Text)>25)
            {
                txtResult.Text = "Take an initial Blood screen test per every three years"; 
            }
            else
            {
                txtResult.Text = "You do not need to have a Blood screen test";
            }
            }
            catch
            {
                MessageBox.Show("Enter required information correctly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtWeight.Text=string.Empty; 
            txtHeight.Text=string.Empty;
            txtAge.Text=string.Empty;
            txtResult.Text=string.Empty;
        }
    }
}
