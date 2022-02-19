using System;
using System.Collections.Generic;

namespace WandeKevin
{
    class Progra
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            

            BankBranch branch = new BankBranch();
            branch.bankAccronym = "UBN";
            branch.bankName = "Union Bank of Nigeria";
            branch.branchAddress = "36, Marina, Lagos";
            branch.branchName = "Head Office branch";
            branch.branchSortCode = 2088545;
            branch.hqAddress =  branch.branchAddress;
            branch.hqSortCode = branch.branchSortCode;
            branch.ledgerBalance = 10000000;
            branch.logoLink =  "https://unionbankng.com/logo";
            branch.staffStrength = 30;
            branch.swiftCode = "UBNINGLA";

            Console.WriteLine("The details of our branch is:"+ branch.ToString());
        }
    }
}
