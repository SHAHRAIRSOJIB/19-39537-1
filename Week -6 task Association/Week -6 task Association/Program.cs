using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week__6_task_Association
{
    class Program
    {
        static void Main(string[] args)
        {
      
            Student stu1 = new Student("19-39537-1", "Munem", 3.31F);
            Student stu2 = new Student("19-39537-2", "Al Shahrair", 3.81F);
            Student stu3 = new Student("19-39537-3", "Sojib", 3.5F);

            Department dept1 = new Department("CS", "Computer Science");
            Department dept2 = new Department("EE","Electronic Engineering");

            stu1.Dept = dept1;
            stu2.Dept = dept2;
            stu3.Dept = dept2;

            stu1.ShowInfo();
            stu1.ShowDepartment();

            stu2.ShowInfo();
            stu2.ShowDepartment();

            stu3.ShowInfo();
            stu3.ShowDepartment();

            dept1.Id = "CSE";
            dept1.Name = "Computer Science and Engineering";

            stu1.ShowInfo();
            stu1.ShowDepartment();


            dept1.AddStudent(stu1);
            dept1.AddStudent(stu2);

            dept1.PrintStudent();
        }
    }
}