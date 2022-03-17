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
    public partial class CustomerForm : Form
    {


        public CustomerForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            errCustForm.SetError(textBox1, "");
            errCustForm.SetError(textBox2, "");
            errCustForm.SetError(textBox3, "");
            errCustForm.SetError(textBox4, "");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool flag; 
            flag = true;
            if (textBox1.Text == "")
            {
                errCustForm.SetError(textBox1, "Please specify a valid car number.");
                flag = false;
            } 
            else
                errCustForm.SetError(textBox1, "");
            if (textBox2.Text == "")
            {
                errCustForm.SetError(textBox2, "Please specify a valid name.");
                flag = false;
            }
            else
                errCustForm.SetError(textBox2, "");
                if (textBox3.Text == "")
                {
                    errCustForm.SetError(textBox3, "Please specify a valid address.");
                    flag = false;
                }
            else
                errCustForm.SetError(textBox3, "");
                if (textBox4.Text == "")
                {
                    errCustForm.SetError(textBox4, "Please specify a valid make. "); 
                    flag = false;
                }
                else
                errCustForm.SetError(textBox4, "");
                if (flag == false)
                return;
                else
                    {
                sqlDataAdapter1.Update(customerDataSet1);
                MessageBox.Show("Database updated ! ");
                    }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            customerDataSet1.Clear();
            sqlDataAdapter1.Fill(customerDataSet1);
            CurrentPosition();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnNext.BindingContext[customerDataSet1, "tblCustomer"].Position += 1;
            CurrentPosition();
        }
        private void CurrentPosition()
        {
            int currentPosition, ctr;
            ctr = this.BindingContext[customerDataSet1,"tblCustomer"].Count;
            if (ctr == 0)
            {
                textBox5.Text = "No Records";
            }
            else
            {
                currentPosition = this.BindingContext[customerDataSet1, "tblCustomer"].Position + 1;
                textBox5.Text = currentPosition.ToString()+" of "+ctr.ToString();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            btnNext.BindingContext[customerDataSet1, "tblCustomer"].Position -= 1;
            CurrentPosition();
        }

        private void btnCencel_Click(object sender, EventArgs e)
        {
            customerDataSet1.Clear();
        }
    }
}
