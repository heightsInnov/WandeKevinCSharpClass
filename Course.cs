using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WandeKevin
{
    internal class Course : School
    {
        public string courseCode { get; set; }
        public string courseTitle { get; set; }
        public int creditUnits { get; set; }
        public string courseLevel { get; set; }
        public string[] courseLecturers { get; set; }
        public string semester { get; set; }


        public Course(string courseCode, string schoolName)
            : base(schoolName)
        {
            this.courseCode = courseCode;

        }

        public Course(string courseCode, int creditUnits, string semester, string schoolName)
            : base(schoolName)

        {
            this.courseCode = courseCode;
            this.creditUnits = creditUnits;
            this.semester = semester;

        }
        public Course(string courseCode, string courseTitle, string[] courseLecturers, string schoolName)
            : base(schoolName)

        {
            this.courseCode = courseCode;
            this.courseTitle = courseTitle;
            this.courseLecturers = courseLecturers;


        }

        public string Print()
        {
            return " Course Code: " + courseCode
                                    + "\n Title: " + courseTitle
                                    + "\n Credit Units: " + creditUnits
                                    + "\n Level: " + courseLevel
                                    + "\n Lecturers: " + courseLecturers
                                    + "\n Semester: " + semester
                                    + "\n University: " + name;


        }

        public string Prints()
        {
            return " Course Code: " + courseCode
                                    + "\n Title: " + courseTitle
                                    + "\n Lecturers: " + courseLecturers;

        }

    }
}
