using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class evan_sum
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 23, 32, 24, 25, 26, 27, 28, 29 };
            int sum = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                { 
                    sum = sum + arr[i];
                    

                }
            }
            Console.WriteLine(sum);
        }
    }
}
