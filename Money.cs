using System;
using System.Linq;

namespace WandeKevin
{
    internal class Money
    {
        //public static List<int> notes = new List<int>() { 5, 10, 15, 29, 50, 100, 200, 500, 1000};
        public static string[] notes = new string[8] { "5", "10", "20", "50", "100", "200", "500", "1000" };
        public static string printColour(string note)
        {
            if (notes.Contains(note))
            {
                if (note =="5")
                {
                    Console.WriteLine("Outdated Note");

                }
                
                switch (note)
                {
                    case "10":
                        Console.WriteLine("Red, Orange");
                        break;
                    case "20":
                        Console.WriteLine("Green");
                        break;
                    case "50":
                        Console.WriteLine("Blue");
                        break;
                    case "100":
                        Console.WriteLine("Red");
                        break;
                    case "200":
                        Console.WriteLine("Brown");
                        break;
                    case "500":
                        Console.WriteLine("Dark Blue, Brown, Green");
                        break;
                    case "1000":
                        Console.WriteLine("Gold");
                        break;

                }

            }
            else
            {
                Console.WriteLine("Note DOES NOT exist");
            }
            return note;
        }
    }
}
