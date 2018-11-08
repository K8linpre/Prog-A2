using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Customer
    {
        //Auto-implemented properties for getters and setters
        public string FName { get; set; }
        public string LName { get; set; }
        public string Phone { get; set; }

        //Constructor
        public Customer(string fn, string ln, string ph)
        {
            FName = fn;
            LName = ln;
            Phone = ph;
        }
        //Method for GetCustomer
        public string GetCustomer()
        {
            return FName + '\t' + LName + '\t' + Phone;
        }
        //List for the collection of customers in the database
        public static List<Customer> CustomerDB = new List<Customer>();    
    }
}
