using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{ 
    public partial class Form1 : Form
    {
        private Customer customer;
        public Form1()
        {
            customer = new Customer();
            InitializeComponent();
        }
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtbxFirst.Text == "" ||
                txtBxLast.Text == "" ||
                txtBxPhone.Text == "")
            {
                MessageBox.Show("All textboxes must be filled out to continue");
            }
            else
            {
                customer.FName = txtbxFirst.Text;
                customer.LName = txtBxLast.Text;
                customer.Phone = txtBxPhone.Text;
                Program.CustomerList.Add(customer);                
                lstBx1.Items.Add(Program.CustomerList);
                customer = new Customer();
               // lstBx1.Items.Add(Customer.GetCustomer(txtbxFirst.Text, txtBxLast.Text, txtBxPhone.Text));
                txtbxFirst.Clear();
                txtBxLast.Clear();
                txtBxPhone.Clear();
                txtbxFirst.Focus();
                btnAdd.Enabled = true;
                MessageBox.Show("New Customer has been added");
            }


            

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtBxSearch.Text == "")
            {
                MessageBox.Show("You must enter a customer name");
                txtBxSearch.Focus();
            }
            else
            {
                customer.FName = txtbxFirst.Text;
                customer.LName = txtBxLast.Text;
                customer.Phone = txtBxPhone.Text;
                Program.CustomerList.Add(customer);
                customer = new Customer();
            }
            txtBxSearch.Text = "";
        }

        private void btnClearLst_Click(object sender, EventArgs e)
        {
            lstBx1.Items.Clear();
            txtBxSearch.Focus();
            btnAdd.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbxFirst.Text = "";
            txtBxLast.Text = "";
            txtBxPhone.Text = "";
            txtbxFirst.Focus();
            btnAdd.Enabled = true;
        }
    }
}
