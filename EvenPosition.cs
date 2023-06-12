using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class EvenPosition
    {
        public static void Main(String[] args)
        {
            int[] a = { 2, 5, 6, 8, 7, 9 };
            Console.WriteLine("Elements in array are : ");


            for (int i = 0; i < a.Length; i += 2)
            {

                Console.WriteLine(a[i]);

            }
        }
    }
}

