using System;

class ArrayOperations{

    public string[] bankBranches = new string[5]{"Ikeja", "V.I", "Lekki", "Yaba", "Marina"};
    public string[] bankNames = new string[6];
    public static int[] numbers = new int[3]{1, 2, 3};
    

    public void operateArray(){

        Console.WriteLine("=== Before Overwritten branch names");
        foreach(string branch in bankBranches){
            Console.WriteLine("Branch name is : " + branch);
        }

        bankBranches[0] = "Somolu";
        bankBranches[4] = "Bariga";

        bankNames[0] = "UBA";
        bankNames[2] = "UBN";
        bankNames[5] = "FBN";

        Console.WriteLine("\n === After Overwritten branch names");
        foreach(string branch in bankBranches){
            Console.WriteLine("Branch name is : " + branch);
        }
        
        Console.WriteLine("\n === Bank names");
        foreach(string bank in bankNames){
            Console.WriteLine("Bank name is : " + bank);
        }
        
        Console.WriteLine("\n === Reading Array values");
        int firstNumber = numbers[0];
        int secondNumber = numbers[1];
        
        Console.WriteLine("Sum of first two values = " + firstNumber + secondNumber);
        Console.WriteLine("Sum of first two values = " + (firstNumber + secondNumber));

        // The above 2 lines are not the same and will not return the same value.
            // The first line is a concatenated string value
            //while
            //The second line applies bodmas in calculating the addition first before concatenation.

        Console.WriteLine("Sum of array values = "+ (numbers[0]+numbers[1]+numbers[2]));

    }
}