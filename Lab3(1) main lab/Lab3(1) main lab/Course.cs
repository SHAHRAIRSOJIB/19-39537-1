﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_1__main_lab
{
    class Course
    {
        string courseName;
        string courseCode;
        int coursCode;
        int courseCredit;

        public string CourseName
        {
            set { courseName = value; }
            get { return courseName; }
        }
        public  string CourseCode
        {
            set { courseCode = value; }
            get { return courseCode; }
        }
        public int CourseCredit
        {
            set { courseCredit = value; }
            get { return courseCredit; }

        }
        public Course() { }
        public Course(string courseName, string courseCode, int courseCredit)
        {
            this.CourseName = courseName;
            this.CourseCode = courseCode;
            this.CourseCredit = courseCredit;
        }
        public void ShowCourseInfo()
        {
            Console.WriteLine("Course Name: " + courseName);
            Console.WriteLine("Course Code: " + courseCode);
            Console.WriteLine("Course Credit: " + courseCredit);
        }

    }
}
