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
             
       

            Student student1 = new Student();

            student1.Name = "Munem Al Shahrair Sojib";
            student1.Id = "19-39537-1";
            student1.Department = "CSE";
            student1.Cgpa = 3.31F;

            student1.ShowInfo();
            Console.WriteLine("\n");


            Student student2 = new Student("Rubayed noor", "19-39424-1", "CSE", 3.93F);
            student2.ShowInfo();

            Console.WriteLine("\n");

 


        //Triangle

            Triangle triangle1 = new Triangle();

            triangle1.Val_X = 10;
            triangle1.Val_Y = 30;
            triangle1.Val_Z = 15;

            triangle1.ShowInfo();
            triangle1.TestTriangle();
            Console.WriteLine("\n");


            Triangle triangle2 = new Triangle(15, 30, 15);
            triangle2.ShowInfo();
            triangle2.TestTriangle();
            Console.WriteLine("\n");

            Triangle triangle3 = new Triangle(15, 30, 10);
            triangle3.ShowInfo();
            triangle3.TestTriangle();

            Console.WriteLine("\n");

            

            //Account
         

            Account account1 = new Account();

            account1.AccName = "Nayem Ahmed";
            account1.Acid = "932126544";
            account1.Balance = 45000;

            Console.WriteLine("\n");


            account1.Deposit(2000);
            Console.WriteLine("Name: {0}\nAcid: {1}\nBalance: {2}\n", account1.AccName, account1.Acid, account1.Balance);

            account1.Withdraw(1500);
            Console.WriteLine("Name: {0}\nAcid: {1}\nBalance: {2}\n", account1.AccName, account1.Acid, account1.Balance);

            Console.WriteLine("\n");


            Account account2 = new Account("Rahim Khan", "2156442582", 90000);

      

            account1.Deposit(25000);
            Console.WriteLine("Name: {0}\nAcid: {1}\nBalance: {2}\n", account1.AccName, account1.Acid, account1.Balance);

            account1.Withdraw(900);
            Console.WriteLine("Name: {0}\nAcid: {1}\nBalance: {2}", account1.AccName, account1.Acid, account1.Balance);

            Console.WriteLine("\n");


            //Course
             

          

            Course course1 = new Course();

            course1.CourseName = "OOP2";
            course1.CourseCode = "CSC00759";
            course1.CourseCredit = 3;

            course1.ShowCourseInfo();
            Console.WriteLine("\n");




            Course course2 = new Course("OOP", "CSC00750", 3);
            course2.ShowCourseInfo();
            Console.WriteLine("\n");

        }
    }
}

