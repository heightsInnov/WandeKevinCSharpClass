using System;


namespace WandeKevin
{
    class Programs
    {
        public static void Main(string[] args)
        {
            School school1 = new School("Federal University of Technology, Akure", "Akure, Nigeria", 4);
            School school2 = new School("University of Port Harcourt", "https://www.uniport.edu.ng");
            School school3 = new School("University of  Lagos", "Lagos, Nigeria", "Public");


            Course course1 = new Course("MTH 101");
            Course course2 = new Course("CHM 130", 3, "Second Semester");
            Course course3 = new Course("CSC 101", "Introduction to Programming in C#", new string[2]{ "Ayotola Jinadu", "Yewande Akinjewe" });
            
            Student 



            Table table1 = new Table("Black Horse Power", "blue", true)
            Console.WriteLine(" The details of our Table is:" + "\n" + table1.ToString());
            
        }
    }

}
