using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_CV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Customer contact = new Customer();

            contact.FirstName = txtFirstName.Text;           
            contact.MiddleName = txtMiddleName.Text;           
            contact.LastName = txtLastName.Text;
            contact.Street1 = txtStreet1.Text;           
            contact.Street2 = txtStreet2.Text;          
            contact.City = txtCity.Text;          
            contact.State = txtState.Text;          
            contact.Zip = txtZip.Text;          
            contact.Phone = txtPhone.Text;        
            contact.Email = txtEmail.Text;
            contact.CellPhone = txtCellPhone.Text;
            contact.InstagramURL = txtInstagramURL.Text;
            contact.CustomerSince = dtpCustomerSince.Value;

            double TP;
            if (Double.TryParse(txtTotalPurchases.Text, out TP)==true)
            {
                contact.TotalPurchases = TP;
            }
            else
            {
                contact.TotalPurchases = -1;
            }
            contact.DiscountMember = checkDiscountMember.Checked;
            Int32 RE;
            if (Int32.TryParse(txtRewardsEarned.Text, out RE) == true)
            {
                contact.RewardsEarned = RE;
            }
            else
            {
                contact.RewardsEarned = -1;
            }

            if (contact.Feedback.Contains("Error:"))
            {
                lblFeedback.Text = contact.Feedback;
            }
            else
            {
                lblFeedback.Text = $"Contact for {contact.FirstName} {contact.LastName} was created successfully.";
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void lblRewardsEarned_Click(object sender, EventArgs e)
        {

        }

        private void checkDiscountMember_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
