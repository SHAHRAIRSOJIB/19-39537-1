using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_task_15._2._21_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = new int[] { 1, 2, 3, 4, 5 };


            Console.WriteLine("Reverse");
            for (int i = a1.Length - 1; i >= 0; i--)
                Console.WriteLine(a1[i]);

            Console.WriteLine("\n");



            Console.WriteLine("Sum of array elements");

            int[] a2 = new int[] { 1, 2, 3, 4, 5 };
            int sum = 0;

            for (int i = 0; i < a2.Length; i++)
                sum += a2[i];
            Console.WriteLine(sum);

            Console.WriteLine("\n");



            Console.WriteLine("Duplicate values");

            int[] a3 = new int[] { 1, 2, 3, 3, 4, 5, 6, 5, 2 };
            for (int x = 0; x < a3.Length; x++)
            {
                for (int j = x + 1; j < a3.Length; j++)
                {
                    if (a3[x] == a3[j])
                        Console.WriteLine(a3[j]);
                }
            }


           



            }
        }

    }

