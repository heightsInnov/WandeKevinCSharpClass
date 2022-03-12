using System;

namespace WandeKevin
{
    internal class Rectangle
    {
        public static int drawRectagle(int number)
        {
            Console.WriteLine("============");
            Console.WriteLine($"{number}    {number}    {number}");
            Console.WriteLine($"{number}         {number}");
            Console.WriteLine($"{number}         {number}");
            Console.WriteLine($"{number}         {number}");
            Console.WriteLine($"{number}    {number}    {number}");
            Console.WriteLine("============");

            return number;
        }

    }
}
