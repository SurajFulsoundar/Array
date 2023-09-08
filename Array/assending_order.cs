using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class assending_order
    {
        // declare an array of 5 elements & sort it in asc order

        static void Main(string[] args)
        {
            int[] arr = new int[5] { 45, 67, 12, 89, 5 };
            
            for(int i = 0; i < arr.Length; i++) 
            {
                for(int j = 0; j <  arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
             
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }

            




        }
    }
}
