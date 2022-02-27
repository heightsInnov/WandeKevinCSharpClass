using System;

class Person{

    public const int publicServiceYear = 35;
    public int currentYear = 2022;
    
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