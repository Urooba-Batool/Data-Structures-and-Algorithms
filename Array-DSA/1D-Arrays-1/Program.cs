using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1D_Arrays_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 12, 1, 15, 10, 35, 7, 22, 3, 9, 41 };
            int even = 0, odd = 0, total = 0;
            double avg;

            // PAIRS WITH SUM OF 25 
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i; j < a.Length; j++)
                {
                    if (a[i] + a[j] == 25)
                    {
                        Console.WriteLine("The values at {0} and {1} indexes that are {2} and {3} make up a sum of 25", i, j, a[i], a[j]);
                    }
                }
            }

            Console.WriteLine("\n\n");

            //ELEMENTS OF A WHICH ARE EVEN AND ODD
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.WriteLine("{0} at index {1} is even", a[i], i);
                    even++;
                }
                else
                {
                    Console.WriteLine("{0} at index {1} is odd", a[i], i);
                    odd++;
                }
            }
            Console.WriteLine("\n {0} numbers from the array of 10 integers are even \n{1} numbers from the array of 10 integers are odd", even, odd);
            Console.WriteLine("\n\n");

            //AVERAGE OF THE VALUES OF A
            for (int i = 0; i < a.Length; i++)
            {
                total += a[i];
            }
            avg = total / 10;
            Console.WriteLine("The sum and average of the values of elements in array A is {0} and {1:F2}", total, avg);
        }
    }
}
