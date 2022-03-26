using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WandeKevin
{
    class CountryAssignment
    {
        public static void ReadFile()
        {
            string contents = File.ReadAllText(@"C:\temp\test.txt");

            Console.WriteLine(contents);
        }
        
        public static void Main()
        {
            ReadFile();
        }
    }
}
