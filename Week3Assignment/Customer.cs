using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WandeKevin.Week3Assignment
{
    public class Customer
    {
        // Defining properties of customer class
        public int customerBvn { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string emailAddress { get; set; }
        public string phoneNumber { get; set; }
        public string address { get; set; }
        public string password { get; set; }
        public string gender { get; set; }


        // Defining one required argument constructor
        public Customer(int bvn)
        {
            this.customerBvn = bvn;
        }

        public Customer(int bvn, string gender)
        {
            this.customerBvn = bvn;
        }

        public Customer(){

        }
    }

}
