using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_even_odd
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            int i;
            int Sum_of_even =0;
            int Sum_of_odd =0;
            Console.WriteLine(" Number= " + n);
            for (i = 1; i <= n; i++)
            {

                if (i % 2 == 0)

                    Sum_of_even = Sum_of_even + i;

                else

                    Sum_of_odd = Sum_of_odd + i;

            }
            Console.WriteLine(Sum_of_even);
            Console.WriteLine(Sum_of_odd);

        }
    }
}
