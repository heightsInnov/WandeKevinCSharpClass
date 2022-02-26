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

        public static void Main(string[] args)
        {
            Table table = new Table("Black Horse Power", "blue", true);
            Table table1 = new Table(2, 4, 3, true);
            Console.WriteLine(" The details of our Table is:" + "\n" + table1.Print());

        }


        /*        public static void Main(string[] args)
                {
                    Console.WriteLine("=============== Hello Calculator! ===============" + "\n");
                    Calculator testScores = new Calculator(6,2);

                    Console.WriteLine("Sum of " + testScores.firstNumber + " and " + testScores.secondNumber + " is: " + testScores.SumOf());
                    Console.WriteLine("Difference between " + testScores.firstNumber + " and " + testScores.secondNumber + " is: " + testScores.DifferenceOf());
                    Console.WriteLine("Product of " + testScores.firstNumber + " and " + testScores.secondNumber + " is " + testScores.ProductOf());
                    Console.WriteLine("Ratio of " + testScores.firstNumber + " and " + testScores.secondNumber + " is " + testScores.RatioOf());

                }
        */
    }

}
