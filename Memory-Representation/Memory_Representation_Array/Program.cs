using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory_Representation_Array
{
    internal class Program
    {
        unsafe static void Main(string[] args) //enable unsafe mode for compiling the code of pointers
        // open solution explorer > right click > select properties > open Build tab > select Allow unsafe code 
        {
            char[] letters = { 'A', 'B', 'C', 'D' };

            unsafe
            {
                fixed (char* ptr = letters)
                {
                    for (int i = 0; i < letters.Length; i++)
                    {
                        Console.WriteLine("Address in RAM/Virtual Memory of letters on index {0} = {1}", i, (int)(ptr + i));
                        Console.WriteLine("Value of letter on index [{0}] = {1}", i, *(ptr + i));
                    }
                }
            }

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            Console.WriteLine();
            unsafe
            {
                fixed (int* ptrN  = numbers)
                {
                    for(int i = 0; i < numbers.Length;i++)
                    {
                        Console.WriteLine("Address in RAM/Virtual Memory of numbers on index {0} = {1}", i, (int)(ptrN + i));
                        Console.WriteLine("Value of numbers on index [{0}] = {1}", i, *(ptrN + i));
                    }
                }
            }

        }
    }
}
