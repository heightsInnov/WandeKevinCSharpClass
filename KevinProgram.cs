using System;
// using System.String[];


namespace WandeKevin
{
    class Programs
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("================= School Details =========================");
            School futa = new School("Federal University of Technology, Akure", "Akure, Nigeria", 4);
            Console.WriteLine(futa.Print() + "\n");

            School uniport = new School("University of Port Harcourt", "https://www.uniport.edu.ng");
            Console.WriteLine(uniport.Print() + "\n");

            School unilag = new School("University of  Lagos", "Lagos, Nigeria", "Public");
            Console.WriteLine(unilag.Print());
            Console.WriteLine("===========================================================" + "\n");



            Console.WriteLine("================= Course Details =========================");
            Course calculus = new Course("MTH 120", "University of  Lagos");
            Console.WriteLine(calculus.Print() + "\n");

            Course organicChemistry = new Course("CHM 130", 3, "Second Semester", "University of  Port Harcourt");
            Console.WriteLine(organicChemistry.Print() + "\n");

            Course cSharp = new Course("CSC 101", "Introduction to Programming in C#", new string[]{"Ayotola Jinadu", "Yewande Akinjewe"}, "University of  Lagos");
            Console.WriteLine(cSharp.Print());
            Console.WriteLine("===========================================================" + "\n");



            Console.WriteLine("================= Student Details =========================");
            Student tola = new Student("U2019/2035001");
            Console.WriteLine(tola.Print() + "\n");

            Student kevin = new Student("Kevin","Omini", "kevinomini@gmail.com" );
            Console.WriteLine(kevin.Print() + "\n");

            Student yewande = new Student("U2022/1015007", "Computer Science", 'M', true);
            Console.WriteLine(yewande.Print());
            Console.WriteLine("===========================================================" + "\n");







            Table table1 = new Table("Black Horse Power", "blue", true);
            Console.WriteLine(" The details of our Table is:" + "\n" + uniport.Print());
            
        }
    }

}
