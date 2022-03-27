using System.Collections.Generic;
class Mapps{
    //They are a multi-value map
    //Maps in C# are data collection storage that stores information in the form of kry-value pairs
    //They are used to keep data that has an equivalent value.

    //e.g ip-address : 172.5.5.255
    //This is used commonly in JSON implementations
    //It implements the IDictionary Interface which is within the System.Collection.Generic package of C#
    //Syntax => 
    /*
        Dictionary<{key-DataType}, {Value-DataType}> {variable name} = new Dictionary<key-DataType, Value-DataType>():
    */

    public void DeclareDictionary(){
        Dictionary<int, string> nairaNotes = new Dictionary<int, string>();
        nairaNotes.Add(10, "Orange");
        nairaNotes.Add(20, "Green");
        nairaNotes.Add(50, "Blue");
        nairaNotes.Add(100, "Browm");
        nairaNotes.Add(200, "Mint");
        nairaNotes.Add(500, "Pink");
        nairaNotes.Add(1000, "Grey");

        nairaNotes.ContainsKey(5);

        Dictionary<string, List<string>> continentCountries = new Dictionary<string, List<string>>();
        List<string> africanCountries = new List<string>();
        africanCountries.Add("Nigeria");
        africanCountries.Add("Botswana");
        continentCountries.Add("Africa", africanCountries);
    }
}