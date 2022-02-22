using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WandeKevin.Week3Assignment
{
    public class Account : Customer
    {
        // Defining properties of account class
        public int accountId { get; set; }
        public string accountNumber { get; set; }
        public string bvn { get; set; }
        public string accountType { get; set; }
        public decimal accountBalance { get; set; }
        public int transactionPin { get; set; }


        // Defining a 2-argument constructor with fields from the parent class
      public Account(string customerEmailAddress, string customerPhoneNumber, int customerID)
            :base(customerID)
        {
            this.emailAddress = customerEmailAddress;
            this.phoneNumber = customerPhoneNumber;

        }

/*        //This applies when the parent argument constructor requires 2 arguments for instance
 *        public Account(string firstName, int customerId)
            : base(customerId, firstName)
        {

        }
*/


    }

}
