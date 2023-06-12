using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class ReverseOrder
    {
        public static void Main(String[] args)
        {

            int[] a = { 2, 5, 3, 4, 5, 8 };
            Console.WriteLine("Elements of array are");


            for (int i = a.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(a[i]);

            }
        }
    }
}
