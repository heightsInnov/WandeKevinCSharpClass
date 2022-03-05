using System;

class Person{
    public static void calculateDateDifference(String stringDate1, String stringDate2){

        DateTime date1 = DateTime.Parse(stringDate1);
        DateTime date2 = DateTime.Parse(stringDate2);

        Console.WriteLine("Year difference is >> "+ (date1.Year - date2.Year));

        int monthDifference = ((date1.Year - date2.Year) * 12) + date1.Month - date2.Month;
        Console.WriteLine("Month difference is >> " + monthDifference);

        Console.WriteLine("Day difference is >> "+ (date1 - date2).TotalDays);
    }
}