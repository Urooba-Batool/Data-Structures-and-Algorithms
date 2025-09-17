using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_3
{
    internal class Program
    {
        static int Sum(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                return (n % 10) + Sum(n / 10);
            }
        }

        public static void Main(string[] args)
        {
            Console.Write("Enter a number for sum: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int add = Sum(number);

            Console.WriteLine("Sum of digits = " + add);
        }
    }
}

