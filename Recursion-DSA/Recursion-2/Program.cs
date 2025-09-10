using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_2
{
    internal class Program
    {
        static void OddSeries(int s, int n)
        {
            if(s > n)
            {
                return;
            }
            else
            {
                if (s % 2 != 0)
                {
                    if (s % 2 != 0)
                    {
                        Console.Write(s + " " + s*s + " ");
                    }
                }
                OddSeries(s + 1, n);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter starting value of series: ");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the nth value of series: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Odd number square series till {0}: ", n);
            OddSeries(s, n);
            Console.WriteLine("\n\n");
        }
    }
}
