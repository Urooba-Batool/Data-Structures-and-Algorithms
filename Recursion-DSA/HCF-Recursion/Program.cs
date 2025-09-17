using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCF_Recursion
{
    internal class Program
    {
        public static int HCF(int n1, int n2)
        {
            if (n2 == 0)
            {
                return n1; 
            }

            return HCF(n2, n1 % n2);
        }
        public static void Main(string[] args)
        {
            Console.Write("Enter first number for HCF: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number for HCF: ");
            int num2 = int.Parse(Console.ReadLine());
            int hcf = HCF(num1, num2);
            Console.WriteLine("The HCF of {0} and {1} is: {2}", num1, num2, hcf);
        }

    }
}
