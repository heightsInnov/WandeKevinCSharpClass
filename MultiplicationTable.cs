using System;

namespace WandeKevin
{
    internal class MultiplicationTable
    {
        public static int multiplicationTableOf(int number)
        {
            // Design layout of multiplcation table
            Console.WriteLine("===========================");
            Console.WriteLine($"Multiplication Table of {number}");
            Console.WriteLine("===========================");

            // Sets a counter used to multiply number by 1 to 12
            int i = 1;
            while (i <= 12)
            {
                Console.WriteLine($"{number} X {i} = {number * i}");
                i++;
                
            }
            Console.WriteLine("===========================");
            return i;
        }
    }
}
