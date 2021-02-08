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

        public int x
        {
            set { x = value; }
            get { return x; }
        }
        public int y
        {
            set { y = value; }
            get { return y; }
        }
        public int z
        {
            set { z = value; }
            get { return z; }

        }
        public void showinfo()
        {
            Console.WriteLine("X=" + x);
            Console.WriteLine("y=" + y);
            Console.WriteLine("z=" + z);
        }
    }
}
