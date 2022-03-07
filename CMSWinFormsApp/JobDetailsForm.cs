using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMSWinFormsApp
{
    public partial class JobDetailsForm : Form
    {
        public JobDetailsForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void txtCarNo_Leave(object sender, EventArgs e)
        {
            if ((txtCarNo.Text == "") || (txtCarNo.Text == null))
            {
                MessageBox.Show("Please Specify a Valid Value " +
                    "of the Car Number", "error in input");
                txtCarNo.Focus();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCarNo.Text.Length < 6)
            {
                MessageBox.Show("Please Specify a valid car number");
                txtCarNo.Focus();
                return;
            }
            try
            {
                if(Convert.ToInt32(txtWorkerid.Text) < 1)
                {
                    MessageBox.Show("Please Specify a valid worker Id");
                    txtWorkerid.Focus();
                    return;
                }
                if(Convert.ToDateTime(dateTimePicker1.Value) > DateTime.Today)
                {
                    MessageBox.Show("Please Specify valid Date");
                    dateTimePicker1.Focus();    
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
