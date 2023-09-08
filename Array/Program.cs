using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            Console.WriteLine(numbers[4]);

            Console.WriteLine(numbers[0]);
            numbers[7] = 800;

            Console.WriteLine(" print all the values");
             
            for(int i = 0; i <= numbers.Length; i++)
            {
                Console.WriteLine($"numbers[{i}] = {numbers[i]}");

            }


        }
    }
}
