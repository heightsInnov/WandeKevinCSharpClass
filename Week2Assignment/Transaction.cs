using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WandeKevin.Week2Assignment
{
    internal class Transaction
    {
        public  int transactionId { get; set; }
        public string transactionType { get; set; }
        public DateTime transactionDate { get; set; }
        public decimal transactionAmount { get; set; }
        public string narration { get; set; }

       
    }
}
