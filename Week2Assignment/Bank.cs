using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WandeKevin.Week2Assignment
{
    internal class Bank
    {
        public int bankId { get; set; }
        public string bankName { get; set; }
        public string bankAddress { get; set; }
        public string bankAccronym { get; set; }
        public int bankSortCode { get; set; }
        public string swiftCode { get; set; }

        public string [] bankBranches = { 
            "Broad Street", 
            "Ebutte Metta", 
            "Ijede", 
            "Ikeja", 
            "Lapal House", 
            "Orile Iganmu",
            "Maryland"
        };

    }
}
