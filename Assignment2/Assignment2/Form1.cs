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
                customer = new Customer(txtbxFirst.Text, txtBxLast.Text, txtBxPhone.Text);
                Customer.CustomerDB.Add(customer);
                ClearBoxes();
                ClearDisplay();
                DisplayCustomers();
                MessageBox.Show("New Customer has been added");
            }      
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtBxSearch.Text == "")
            {
                MessageBox.Show("You must enter a customer name");
                txtBxSearch.Focus();
                //need to store data from search textbox in string variable
                txtBxSearch.Clear();
                ClearDisplay();
            }
            if (txtBxSearch.Text == "Jaarna")
            {
                MessageBox.Show("Jaarna found - Make this work");
                txtBxSearch.Clear();
                txtBxSearch.Focus();

            }
            else
            {
                MessageBox.Show("Customer not found, please try again");
                txtBxSearch.Clear();
                txtBxSearch.Focus();
            }
        }

        private void btnClearLst_Click(object sender, EventArgs e)
        {
            ClearDisplay();
            txtBxSearch.Focus();
            btnAdd.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbxFirst.Clear();
            txtBxLast.Clear();
            txtBxPhone.Clear();
            txtbxFirst.Focus();
            btnAdd.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDB();        
        }

        public void LoadDB()
        {
            Customer.CustomerDB.Add(new Customer("Jaarna", "Kereopa", "123-2514"));
            Customer.CustomerDB.Add(new Customer("Sue", "Stook", "123-1263"));
            Customer.CustomerDB.Add(new Customer("Jamie", "Allom", "123-3658"));
            Customer.CustomerDB.Add(new Customer("Brian", "Janes", "123-9898"));
        }
        public void ClearBoxes()
        {
            txtbxFirst.Clear();
            txtBxLast.Clear();
            txtBxPhone.Clear();
        }
        public void ClearDisplay()
        {
            lstBx1.Items.Clear();
        }
        public void DisplayCustomers()
        {
            foreach (var Customer in Customer.CustomerDB)
            {
                lstBx1.Items.Add(Customer.GetCustomer());
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ClearDisplay();
            DisplayCustomers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstBx1.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this customer?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ClearBoxes();
                    ClearDisplay();
                    DisplayCustomers();
                    MessageBox.Show("The customer has been deleted");
                    btnAdd.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Operation Cancelled");
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to delete");
                ClearDisplay();
                DisplayCustomers();
            }
        }
    }
}
