using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Even_odd
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] evenArr = new int[arr.Length];
            int[] oddArr = new int[arr.Length];
            int evenIndex = 0;
            int oddIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenArr[evenIndex] = arr[i];
                    evenIndex++;
                }
                else
                {
                    oddArr[oddIndex] = arr[i];
                    oddIndex++;
                }
            }

            Console.WriteLine("Even numbers:");
            for (int i = 0; i < evenIndex; i++)
            {
                Console.WriteLine(evenArr[i]);
            }

            Console.WriteLine("Odd numbers:");
            for (int i = 0; i < oddIndex; i++)
            {
                Console.WriteLine(oddArr[i]);
            }
        }
    }
}
