using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Display_alternative
    {
        static void Main(string[] args)
        {
            int[] arr = { 21,22,43,32,18,20,15,16, 17, };

            for(int i = 0; i < arr.Length; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
