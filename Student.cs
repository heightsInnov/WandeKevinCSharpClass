using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WandeKevin
{
    internal class Student
    {
        public string matricNumber { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string department { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public char gender { get; set; }
        public string dateOfBirth { get; set; }
        public string level { get; set; }
        public bool hasPaidFees { get; set; }


        public Student(string matricNumber)
        {
            this.matricNumber = matricNumber;
        }

        public Student(string firstName, string lastName, string email )
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
        }

        public Student(string matricNumber, string department, char gender, bool hasPaidFees)
        {
            this.matricNumber = matricNumber;
            this.department = department;
            this.gender = gender;
            this.hasPaidFees = hasPaidFees;
        }

        public string Print()
        {
            return " Matric Number: " + matricNumber
                             + "\n Name: " + firstName + " " + lastName
                             + "\n Department: " + department
                             + "\n Email: " + email
                             + "\n Phone Number: " + phoneNumber
                             + "\n Gender: " + gender
                             + "\n DOB: " + dateOfBirth
                             + "\n Level: " + level
                             + "\n Has Paid Fees: " + hasPaidFees;

        }

    }
}
