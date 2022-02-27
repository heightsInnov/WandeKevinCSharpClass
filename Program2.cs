using System;

class Program2{

    public static void Main(){

        // RechargeAirtime airtime = new RechargeAirtime("0049762085", 800.50, "07037952273", 100);

        // RechargeAirtime airtime2 = new RechargeAirtime("0049762085", 800.50, "07037952273");

        RechargeAirtime airtime1 = new RechargeAirtime();
        airtime1.accountNumber = "0049762085";
        airtime1.fund = 800.50;
        airtime1.phoneNumber = "07037952273";
        airtime1.isInternetConnected = true;
        airtime1.isMobileConnected = true;

        Force f = new Force();
        double force = f.calculateStaticForce(20.78);
        Console.WriteLine("The force needed to move the mass is >> "+f);
    }
}