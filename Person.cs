using System;

class Person{
    public static void calculateDateDifference(String stringDate1, String stringDate2){

    const int publicServiceYear = 35;

        DateTime date1 = DateTime.Parse(stringDate1);
        DateTime date2 = DateTime.Parse(stringDate2);

        Console.WriteLine("Year difference is >> "+ (date1.Year - date2.Year));

        int monthDifference = ((date1.Year - date2.Year) * 12) + date1.Month - date2.Month;
        Console.WriteLine("Month difference is >> " + monthDifference);

        Console.WriteLine("Day difference is >> "+ (date1 - date2).TotalDays);

    }
    public const int publicServiceYear = 35;
    public int currentYear = DateTime.Now.Year;

    public int calculateAge(int birthYear){
        // Kevin
        int age = currentYear - birthYear;
        return age;
    }

    public double calculateBMI(double height, double weight){
        // Kevin
        double bmi = weight / Math.Pow(height, 2);
        return bmi;
    }

    public int calculateRetirementYear(int yearOfFirstAppointment){
        // Kevin
        int retirementYear = yearOfFirstAppointment + publicServiceYear;
        return retirementYear;
    }
}