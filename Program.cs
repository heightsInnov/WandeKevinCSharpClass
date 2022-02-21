using System;

namespace WandeKevin
{
    class Program
    {
        static void Mains(string[] args)
        {
            Console.WriteLine("Hello World!");

            ArrayOperations operations = new ArrayOperations();
            operations.operateArray();

            
            Console.WriteLine("======================================================================");
            BankBranch ubn = new BankBranch();
            ubn.bankAccronym = "UBN";
            ubn.bankName = "Union Bank of Nigeria";
            ubn.branchAddress = "36, Marina, Lagos";
            ubn.branchName = "Head Office ubn";
            ubn.branchSortCode = 2088545;
            ubn.hqAddress =  ubn.branchAddress;
            ubn.hqSortCode = ubn.branchSortCode;
            // ubn.ledgerBalance = 10000000;
            ubn.logoLink =  "https://unionbankng.com/logo";
            ubn.staffStrength = 30;
            ubn.swiftCode = "UBNINGLA";

            ubn.bankName = "Zenith Bank of Nigeria";

            // Console.WriteLine("The details of our ubn is:"+ ubn.ToString());

            Summation summation = new Summation();
            // summation.firstNumber = 23;
            summation.secondNumber = 34;

            Console.WriteLine(summation.calculateSum());

            User user = new User();
            user.username = " Wande ";
            user.password = "Wander";

            user.password = null;
            Console.WriteLine(user);
            
        }
    }

class User{
        string firstname;
        string lastname;
        public string username;
        public string password;
    }
}
