using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory_Representation
{
    internal class Program
    {
        unsafe static void Main(string[] args)//enable unsafe mode for compiling the code of pointers
            // open solution explorer > right click > select properties > open Build tab > select Allow unsafe code 
        {
            char x = 'a';
            int y = 100;
            float z = 50.4f;

            char* ptrX = &x;
            Console.WriteLine("Address of char x in RAM/Virtual Memory = {0}", (int)ptrX);
            Console.WriteLine("Value of x = {0}", *ptrX);

            int* ptrY = &y;
            Console.WriteLine("Address of int in RAM/Virtual Memory = {0}", (int)ptrY);
            Console.WriteLine("Value of y = {0}", *ptrY);

            float* ptrZ = &z;
            Console.WriteLine("Address of float in RAM/Virtual Memory = {0}", (int)ptrZ);
            Console.WriteLine("Value of z = {0}", *ptrZ);
        }
    }
}
