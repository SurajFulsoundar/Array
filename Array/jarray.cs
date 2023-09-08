using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class jarray
    {
        static void Main(string[] args)
        {
            // [,] --> 2D array  [3,4]
            // [][]  --> jagged  [3][]

            //Jagged array

            int[][] jarray = new int[4][];

            jarray[0] = new int[] { 1, 2, 3, 4, 5 };
            jarray[1] = new int[] { 10, 20, 30 };
            jarray[2] = new int[] { 100, 200 };
            jarray[3] = new int[] { 1000 };

            // OR
            //jarray[0] = new int[5] ;
            //jarray[1] = new int[3] ;
            //jarray[2] = new int[2] ;
            //jarray[3] = new int[1] ;

            //        row=0       0<4
            for (int row = 0; row < jarray.Length; row++) // row length
            {
                //        col=0    0<   5  --> jarray[0].Length
                for (int col = 0; col < jarray[row].Length; col++)
                {
                    Console.Write(jarray[row][col] + "  ");
                }
                Console.WriteLine("\n");
            }

        }

    }
}
