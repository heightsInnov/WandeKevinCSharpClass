using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WandeKevin.Week2Assignment
{
    internal class Account
    {
        public int accountId { get; set; }
        public string accountNumber { get; set; }
        public string bvn { get; set; }
        public string accountType { get; set; }
        public decimal accountBalance { get; set; }
        public int transactionPin { get; set; }

    }
}
