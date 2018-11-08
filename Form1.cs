using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Person_and_Customer_Classes
{
    public partial class Form1 : Form
    {
        Person person = new Person();
        Customer customer = new Customer();
        public class Person //base class
        {
            public string name; //string name
            public string address; //string address
            public string phoneNum; //string phone number 
        }
        public class Customer : Person //classes dervied 
        {
            public string CustomerNum;
            public bool Mail;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void getInfoBtn_Click(object sender, EventArgs e)
        {
            //user inputs
            customer.name = txtName.Text; 
            customer.address = txtAddress.Text;
            customer.phoneNum = Convert.ToString(txtNumber.Text);
            customer.CustomerNum = txtID.Text;
            customer.Mail = txtMail.Text == "1" ? true : false;
        }

        private void showInfoBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name: " + customer.name + Environment.NewLine + "Address: " + customer.address + Environment.NewLine + "Phone Number: " + customer.phoneNum + Environment.NewLine + "Mailing List? (1=Yes, 0=No)" + customer.Mail);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close(); //closes form
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            txtAddress.Text = ""; //clears address textbo 
            txtID.Text = ""; //clears ID textbox 
            txtMail.Text = ""; //clears mail textbox 
            txtName.Text = ""; //clears name textbox
            txtNumber.Text = ""; //clears phone number textbox 
        }
    }
}
