
using System;

class Program2{

    public static void Main(){

        // RechargeAirtime airtime = new RechargeAirtime("0049762085", 800.50, "07037952273", 100);

        // RechargeAirtime airtime2 = new RechargeAirtime("0049762085", 800.50, "07037952273");

        // RechargeAirtime airtime1 = new RechargeAirtime();
        // airtime1.accountNumber = "0049762085";
        // airtime1.fund = 800.50;
        // airtime1.phoneNumber = "07037952273";
        // airtime1.isInternetConnected = true;
        // airtime1.isMobileConnected = true;

        Person.calculateDateDifference("2022/12/03", "2020/12/03");

        RechargeAirtime airtime1 = new RechargeAirtime();
        airtime1.accountNumber = "0049762085";
        airtime1.fund = 800.50;
        airtime1.phoneNumber = "07037952273";
        airtime1.isInternetConnected = true;
        airtime1.isMobileConnected = true;

        
        Console.WriteLine("The force needed to move the mass is >> "+ Fibonancci.GetNthFibonacci_Rec(2));

        ControlStructure cs = new ControlStructure();

        cs.IfMethod("Yewande", 11);
        cs.IfMethod("Kevin", 16);

        cs.IfElseMethod("Kevin", 16);
        
        cs.WhileMethod(3);
    }
}