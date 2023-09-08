using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class prime_in_array
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of Array ");
            int num = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[num];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter the List");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i <arr.Length; i++)
            {
                int a = 0;
                for (int j = 2; j < arr[i]; j++)
                {
                    if (arr[i] % j == 0)
                    {
                        a = 1;
                        break;

                    }


                }
                if(a == 0)
                {
                    Console.WriteLine(arr[i]);
                }

            }

        }
    }
}




