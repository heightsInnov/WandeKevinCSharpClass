using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WandeKevin
{
    internal class Course
    {
        public string courseCode { get; set; }
        public string courseTitle { get; set; }
        public int creditUnits { get; set; }
        public string courseLevel { get; set; }
        public string[] courseLecturers { get; set; }
        public string semester { get; set; }


        public Course(string courseCode)
        {
            this.courseCode = courseCode;

        }

        public Course(string courseCode, int creditUnits, string semester)
        {
            this.courseCode = courseCode;
            this.creditUnits = creditUnits;
            this.semester = semester;

        }
        public Course(string courseCode, string courseTitle, string semester, string[] courseLecturers)
        {
            this.courseCode = courseCode;
            this.courseTitle = courseTitle;
            this.semester = semester;
            this.courseLecturers = courseLecturers;
        }

    }
}
