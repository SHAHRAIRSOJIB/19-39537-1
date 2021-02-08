using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_1__main_lab
{
    public class Triangle
    {
        int x;
        int y;
        int z;
    

        public int Val_X
        {
            set { x = value; }
            get { return x; }
        }
        public int Val_Y
        {
            set { y = value; }
            get { return y; }
        }
        public int Val_Z
        {
            set { z = value; }
            get { return z; }

        }
        public Triangle()
        {
            
        }
        public Triangle(int x, int y, int z)
        {
            this.Val_X = x;
            this.Val_Y = y;
            this.Val_Z = z;
        }
       
        public void TestTriangle(){

            if (x == y)
            {
               Console.WriteLine("It ia a Isosceles ");
            }
            else if (x == y || y == z || x == z)
            {
                Console.WriteLine("It is a Equilateral  ");

            }
            else
            {
                Console.WriteLine("It is a scalene ");
            }
        }
             public void ShowInfo()
        {
            Console.WriteLine("X=" + Val_X);
            Console.WriteLine("Y=" + Val_Y);
            Console.WriteLine("Z=" + Val_Z);
            
        }
        }
    }

