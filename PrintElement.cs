using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class PrintElement
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 5, 6, 8, 7 };

            Console.WriteLine("Elements in array are: ");
            for (int i = 0; i <= a.Length; i++)
            {
                Console.WriteLine(a);
            }
        }
    }
}
