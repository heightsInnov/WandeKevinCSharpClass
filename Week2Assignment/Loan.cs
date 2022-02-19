using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WandeKevin.Week2Assignment
{
    internal class Loan
    {
        public int loanId { get; set; }
        public decimal amount { get; set; }
        public double interestRate { get; set; }
        public DateTime applicationDate { get; set; }
        public DateTime approvalDate { get; set; }
        public DateTime paymentTime { get; set; }

    }
}
