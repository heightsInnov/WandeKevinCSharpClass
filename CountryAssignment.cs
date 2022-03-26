using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
            string contents = File.ReadAllText(@"C:\Users\User\Documents\Demotek\CSharpTrainning\WandeKevin\country-by-continent.json");

            var jArray = JsonConvert.DeserializeObject<JArray>(contents);

            HashSet<string> continents = new HashSet<string>();

            foreach(JObject jobject in jArray)
            {
                Console.WriteLine(Convert.ToString(jobject["country"]));
            }
            
            


        }
        
        public static void Main()
        {
            ReadFile();
        }
    }
}
