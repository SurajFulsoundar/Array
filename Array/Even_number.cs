using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Even_number
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(" Enter a number ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());

            }
            for(int i = 0; i < numbers.Length;i++)
            {
                if(numbers[i] % 2 == 0)
                {
                    Console.WriteLine($"Even number is {i} ");
                    
                }
            }
        }
    }
}
