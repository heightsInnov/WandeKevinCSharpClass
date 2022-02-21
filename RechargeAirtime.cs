using System;
class RechargeAirtime{
    //5 default methods
        //Equals
        //HashCode
        //ToString
        //GetType
        /// No-arguement constructor

        public string accountNumber;
        public double fund;
        public string phoneNumber;
        public bool isInternetConnected;
        public bool isMobileConnected;
        public double rechargeAmount;

        //We create a required arguements constructor.
            //It has same name as the class
            //It takes arguements that are compulsory for setting up the class
        public RechargeAirtime(string accountNumber, double balance, string phone, double rechargeAmount){
            this.accountNumber = accountNumber;
            this.fund = balance;
            this.phoneNumber = phone;
            this.isInternetConnected = true;
            this.isMobileConnected = true;
            this.rechargeAmount = rechargeAmount;
            Console.WriteLine("This is constructor 1");
        }

        //No-args constructor
        public RechargeAirtime(){
            Console.WriteLine("This is no args constructor");
        }

        //Method Overloading : Creating methods of the same name but different parameters/args.
            //When it is done on a constructor, it is called constructor overloading
        public RechargeAirtime(string accountNumber, double balance, string phone){
            this.accountNumber = accountNumber;
            this.fund = balance;
            this.phoneNumber = phone;
            this.isInternetConnected = true;
            this.isMobileConnected = true;
            this.rechargeAmount = 100;

            Console.WriteLine("This is constructor 2");
        }

        //Constructors are loaded from the start/instantiation of the class
}