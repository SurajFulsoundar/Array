using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class negative_element
    {
        static void Main(string[] args)
        {
            int count = 0;
            int[] num = new int[10];

            for(int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("Enter a number ");
                num[i] = Convert.ToInt32(Console.ReadLine());

              
            
            }
            for(int i = 0; i < num.Length; ++i)
            {
                if (num[i] < 0)
                {
                    count++;
                    Console.WriteLine($" Negative num[{i}] = {num[i]}");

                }
            }
            Console.WriteLine($" Negative Number count is {count}");

        }
    }
}
