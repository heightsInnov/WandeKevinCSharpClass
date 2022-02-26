using System;


namespace WandeKevin
{
    class Programs
    {
        public static void Main(string[] args)
        {
            Table table1 = new Table("Black Horse Power", "blue", true);
            Console.WriteLine(" The details of our Table is:" + "\n" + table1.ToString());
            
        }
    }

}
