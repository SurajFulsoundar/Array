using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class _2D_arry
    {
        static void Main(string[] args)
        {
           
            int[,] arr = new int[4, 5];

            Console.WriteLine("Enter a number ");
            /* {
                 {10,20,30,40,130},
                 {50,60,70,80,140},
                 {90,100,110,120,150},
                 {160,170,180,190,200 }
             };*/

            for (int row = 0; row < arr.GetLength(0); row++) 
            {
                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    arr[row, col] = Convert.ToInt32(Console.ReadLine());
                }

            }

            for (int row = 0; row < arr.GetLength(0); row++) 
            {
                for (int col = 0; col < arr.GetLength(1); col++) 
                {
                    Console.Write($"arr[{row},{col}] = {arr[row, col]}  ");
                }
                Console.WriteLine("\n");
            }

          







        }
    }
}
