using Newtonsoft.Json;
using System;
using System.IO;

namespace WandeKevin
{
    internal class Week7Assignment
    {

        static void Main(string[] args)
        {
            string filePath = @"C:\Users\kevin\Documents\country-by-continent.json";

            string countryList = new StreamReader(filePath).ReadToEnd();

            dynamic countries = JsonConvert.DeserializeObject(countryList);

            foreach (var country in countries)
            {
                Console.WriteLine($"Country: {country.country}\n" +
                                  $"Continent: {country.continent}\n" +
                                  $"");

            }
        }
    }
}

