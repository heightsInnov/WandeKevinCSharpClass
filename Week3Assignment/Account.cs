using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WandeKevin.Week3Assignment
{
    internal class Account : Customer
    {
        // Defining properties of Account Class
        public int accountId { get; set; }
        public string accountNumber { get; set; }
        public string bvn { get; set; }
        public string accountType { get; set; }
        public decimal accountBalance { get; set; }
        public int transactionPin { get; set; }


        // Defining a constructor of the Account Class
        public void account(int accountId, string accountNumber)
        {

        }
    }
}
