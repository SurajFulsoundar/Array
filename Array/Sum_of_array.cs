using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Sum_of_array
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Size ");
            int num = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[num];
            Console.WriteLine("Enter the List ");
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum = sum + arr[i];

            }
            Console.WriteLine(sum);



        }
    }
}
