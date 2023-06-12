using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class SecondLargest
    {
        public static void Main(String[] args)
        {
            int[] a = { 1, 5, 6, 3, 4 };


            int temp;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {

                    if (a[i] < a[j])
                    {

                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i] + " ");
            }
            Console.WriteLine("Second Largest = " + a[1]);
        }
    }
}
