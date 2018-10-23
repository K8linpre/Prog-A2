using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Customer
    {


        public string FName { get; set; }
        public string LName { get; set; }
        public string Phone { get; set; }

    public static string GetCustomer(string fn, string ln, string ph)
        {
            return fn + '\t' + ln + '\t' + ph;
        }
        public static void LoadDB(string fn, string ln, string ph)
        {
            var LoadingList = new List<string> { "Jaarna", "Kereopa", "123-2514" };
            // { "Jaarna", "Kereopa", "123-2514"}
        }
    }
}
