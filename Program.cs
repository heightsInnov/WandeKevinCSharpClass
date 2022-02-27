using System;
// using System.String[];


namespace WandeKevin
{
    class Program
    {
        /*        public static void Mains(string[] args)
                {
                    Console.WriteLine("================= School Details =========================");
                    School futa = new School("Federal University of Technology, Akure", "Akure, Nigeria", 4);
                    School uniport = new School("University of Port Harcourt", "https://www.uniport.edu.ng");
                    School unilag = new School("University of  Lagos", "Lagos, Nigeria", "Public");
                    Console.WriteLine(futa.Print() + "\n" + "\n" + uniport.Print() + "\n" + "\n" + unilag.Print());
                    Console.WriteLine("===========================================================" + "\n");



                    Console.WriteLine("================= Course Details =========================");
                    Course calculus = new Course("MTH 120", "University of  Lagos");
                    Course organicChemistry = new Course("CHM 130", 3, "Second Semester", "University of  Port Harcourt");
                    Course cSharp = new Course("CSC 101", "Introduction to Programming in C#", new string[] { "Ayotola Jinadu", "Yewande Akinjewe" }, "University of  Lagos");
                    Console.WriteLine(calculus.Print() + "\n" + "\n" + organicChemistry.Print() + "\n" + "\n" + cSharp.Print());
                    Console.WriteLine("===========================================================" + "\n");



                    Console.WriteLine("================= Student Details =========================");
                    Student tola = new Student("U2019/2035001");
                    Student kevin = new Student("Kevin", "Omini", "kevinomini@gmail.com");
                    Student yewande = new Student("U2022/1015007", "Computer Science", 'M', true);
                    Console.WriteLine(tola.Print() + "\n" + "\n" + kevin.Print() + "\n" + "\n" + yewande.Print());
                    Console.WriteLine("===========================================================" + "\n");

                }*/

        /*        public static void Main(string[] args)
                {
                    Console.WriteLine("================= Table Description =========================");
                    Table table = new Table("Black Horse Power", "blue", true);
                    Table table1 = new Table(40.5m, 17.3m, 38, true);
                    Table table2 = new Table("Hard Rocks", 3.4m);
                    Console.WriteLine(table.Print() + "\n" + "\n" + table1.Print() + "\n" + "\n" + table2.Print());
                    Console.WriteLine("===========================================================" + "\n");



                }
        */

        public static void Main(string[] args)
        {
            Console.WriteLine("=============== Hello Calculator! ===============" + "\n");
            Calculator testScores = new Calculator(3.5m, 2);

            Console.WriteLine("Sum of " + testScores.firstNumber + " and " + testScores.secondNumber + " is: " + testScores.SumOf());
            Console.WriteLine("Difference between " + testScores.firstNumber + " and " + testScores.secondNumber + " is: " + testScores.DifferenceOf());
            Console.WriteLine("Product of " + testScores.firstNumber + " and " + testScores.secondNumber + " is " + testScores.ProductOf());
            Console.WriteLine("Ratio of " + testScores.firstNumber + " and " + testScores.secondNumber + " is " + testScores.RatioOf());

        }

    }

}
