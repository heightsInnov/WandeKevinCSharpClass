using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WandeKevin
{
    class CountryAssignment
    {
        
        public static void ReadFile()
        {
            string contents = File.ReadAllText(@"\\Mac\Home\Documents\Taller\Demotek\WandeKevinCSharpClass\country-by-continent.json");

            var jArray = JsonConvert.DeserializeObject<JArray>(contents);

            Dictionary<string, string> countriesContinents = new Dictionary<string, string>();

            foreach (JObject jobject in jArray)
            {
                countriesContinents.Add(Convert.ToString(jobject["country"]), Convert.ToString(jobject["continent"]));

            }
        }
        
        public static void Main()
        {
            ReadFile();
        }
    }
}
