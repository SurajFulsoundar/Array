using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Display_odd_position_number
    {
        static void Main(string[] args)
        {
            int[] arr = { 12,13,14,15,16,17,18,19,20 };

           
            for(int i = 0; i < arr.Length; i++) 
            {
                if (i % 2 != 0) 
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
