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
        public float Cgpa
        {
            get { return this.cgpa; }
        }
        
        public Student() {
          
            credit = 145;
        }
        public Student(string name, string id)
        {
            
            this.name = name;
            this.id = id;
           
        }
        public void showInfo(){    
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Id : " + id);
            Console.WriteLine("Cgpa : " + cgpa);
        }
      
 
            
        }
    }
