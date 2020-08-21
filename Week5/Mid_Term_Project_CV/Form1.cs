using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mid_Term_Project_CV
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
            Person contact = new Person();

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

            if (contact.Feedback.Contains("Error:"))
            {
                lblFeedback.Text = contact.Feedback;
            }
            else
            {
                lblFeedback.Text = $"Contact for {contact.FirstName} {contact.LastName} was created successfully.";
            }
        }
    }
}
