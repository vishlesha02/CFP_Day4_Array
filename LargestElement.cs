using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class LargestElement
    {
        public static void Main(String[] args)
        {
            int[] a = { 2, 60, 5, 20, 8, 6 };
            int largest = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > largest)
                {
                    largest = a[i];
                }
            }

            Console.WriteLine($"The largest element in the array is :{largest}");
        }
    }
}
