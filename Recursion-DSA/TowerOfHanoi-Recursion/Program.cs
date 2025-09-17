using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi_Recursion
{
    internal class Program
    {
        static int count(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return 2 * count(n - 1) + 1;
            }
        }
        static void towerOfHanoi(int n, char from_rod, char to_rod, char aux_rod)
        {
            if (n == 1)
            {
                Console.WriteLine("Move disk 1 from rod " + from_rod + " to rod " + to_rod);
                return;
            }
            towerOfHanoi(n - 1, from_rod, aux_rod, to_rod);
            Console.WriteLine("Move disk " + n + " from rod " + from_rod + " to rod " + to_rod);
            towerOfHanoi(n - 1, aux_rod, to_rod, from_rod);
        }
        public static void Main(String[] args)
        {
            int n = 4;
            Console.WriteLine("Tower of Hanoi solving steps:");
            towerOfHanoi(n, 'A', 'C', 'B');
            int moves = count(n);
            Console.WriteLine("Total moves = " + moves);
        }
    }
}
