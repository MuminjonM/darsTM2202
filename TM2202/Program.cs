using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TM2202
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 36, b = 48;

            while (a != b)
            {
                if (a > b) a = a - b;
                else b = b - a;

            }
            Console.WriteLine("ekub= " + a);
            Console.ReadKey();  
        }
    }
}
