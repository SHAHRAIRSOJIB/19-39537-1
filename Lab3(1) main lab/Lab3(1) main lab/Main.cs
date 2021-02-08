using SimpleProject1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_1__main_lab
{
    class Operation
    {
        static void Main(string[] args)
        {
            
             //Student
             
       

            Student stu1 = new Student();

            stu1.Name = "Munem Al Shahrair Sojib";
            stu1.Id = "19-39537-1";
            stu1.Department = "CSE";
            stu1.Cgpa = 3.31F;

            stu1.ShowInfo();
            Console.WriteLine("\n");


            Student stu2 = new Student("Rubayed noor", "19-39424-1", "CSE", 3.93F);
            stu2.ShowInfo();

            Console.WriteLine("\n");

 


        //Triangle

            Triangle tri1 = new Triangle();

            tri1.Val_X = 10;
            tri1.Val_Y = 30;
            tri1.Val_Z = 15;

            tri1.ShowInfo();
            tri1.TestTriangle();
            Console.WriteLine("\n");


            Triangle tri2 = new Triangle(15, 30, 15);
            tri2.ShowInfo();
            tri2.TestTriangle();
            Console.WriteLine("\n");

            Triangle tri3 = new Triangle(15, 30, 10);
            tri3.ShowInfo();
            tri3.TestTriangle();

            Console.WriteLine("\n");

            

            //Account
         

            Account ac1 = new Account();

            ac1.AccName = "Nayem Ahmed";
            ac1.Acid = "932126544";
            ac1.Balance = 45000;

            Console.WriteLine("\n");


            ac1.Deposit(2000);
            Console.WriteLine("Name: {0}\nAcid: {1}\nBalance: {2}\n", ac1.AccName, ac1.Acid, ac1.Balance);

            ac1.Withdraw(1500);
            Console.WriteLine("Name: {0}\nAcid: {1}\nBalance: {2}\n", ac1.AccName, ac1.Acid, ac1.Balance);

            Console.WriteLine("\n");


            Account ac2 = new Account("Rahim Khan", "2156442582", 90000);

      

            ac2.Deposit(25000);
            Console.WriteLine("Name: {0}\nAcid: {1}\nBalance: {2}\n", ac2.AccName, ac2.Acid, ac2.Balance);

            ac2.Withdraw(900);
            Console.WriteLine("Name: {0}\nAcid: {1}\nBalance: {2}", ac2.AccName, ac2.Acid, ac2.Balance);

            Console.WriteLine("\n");


            //Course
             

          

            Course c1 = new Course();

            c1.CourseName = "OOP2";
            c1.CourseCode = "CSC00759";
            c1.CourseCredit = 3;

            c1.ShowCourseInfo();
            Console.WriteLine("\n");




            Course c2 = new Course("OOP", "CSC00750", 3);
            c2.ShowCourseInfo();
            Console.WriteLine("\n");

        }
    }
}

