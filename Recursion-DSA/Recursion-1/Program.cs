using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_1
{
    internal class Program
    {
        static void Series(int s, int n)
        {
            if (s > n)
            {
                return;
            }
            else
            {
                Console.Write(s + " ");
                Series(s * 2, n);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the starting value: ");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the nth value: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Series from {0} to {1}: ", s, n);
            Series(s,n);
        }
        
    }
}
