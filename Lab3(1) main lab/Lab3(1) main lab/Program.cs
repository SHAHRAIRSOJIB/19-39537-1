using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_1__main_lab
{
    public class Student 
    {
           string name;
            string id;
            string department;
            float cgpa;
            public int credit;

        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string Id
        {
            set { id = value; }
            get { return id; }
        }
      
        public string Department
        {
            set { department = value; }
            get { return department; }
        }
          public float Cgpa
        {
            set { cgpa = value; }
            get { return cgpa; }
        }
        
        public Student() {
          
            credit = 145;
        }
        public Student(string name, string id, string department, float cgpa)
        {
            
            this.name = name;
            this.id = id;
            this.department = department;
            this.cgpa = cgpa;
           
        }
        public void ShowInfo(){    
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Id : " + id);
            Console.WriteLine("Department : " +department);
            Console.WriteLine("Cgpa : " + cgpa);
        }
      
 
            
        }
    }
