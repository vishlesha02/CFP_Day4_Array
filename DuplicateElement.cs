using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class DuplicateElement
    {
        public static void Main(String[] args)
        {
            int[] a = { 2, 6, 5, 8, 5, 6, 9, 3 };


            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        Console.WriteLine($"Duplicate Element in Array {a[j]}");
                    }
                }
            }
        }
    }
}
