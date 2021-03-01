using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week__6_task_Association
{
    class Department
    {
         private string id;
        private string name;

        private int studentCount; 
        private Student[] students;

        public Department()
        {
            students = new Student[50];
        }

        public Department(string id, string name)
        {
            this.Name = name;
            this.Id = id;
            students = new Student[100];
        }

        public string Id
        {
            set { this.id = value; }
            get { return this.id; }
        }

        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }

        public int StudentCount
        {
            set { this.studentCount = value; }
            get { return this.studentCount; }
        }

        public void AddStudent(params Student[] stdns)
        {
            foreach (Student s in stdns)
            {
                this.students[this.StudentCount++] = s;
                s.Dept = this;
            }
        }

        public void RemoveStudent(Student s)
        {
            
        }

        public Student GetStudent(string id)
        {
            
            return null;
        }

        public void PrintStudent()
        {
            foreach (Student s in this.students)
            {
                s.ShowInfo();
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Department Id: {0}", this.Id);
            Console.WriteLine("Department Name: {0}", this.Name);
            Console.WriteLine("     ");
        }
    }
}
   