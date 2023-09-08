using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Generic
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3 };
            List<int> L = new List<int>();
            L.Add(10);
            L.Add(30);
            L.Add(20);
            L.AddRange(arr);
            foreach (int i in L)
            {
                Console.WriteLine(i);

            }

           // L.Insert(1, 11);
         

          /*  L.Remove(2);
            L.Remove(0);
            L.RemoveRange(2, 3);*/
            Console.WriteLine("Total Count "+L.Count);

           /* L.Sort();
            L.Reverse();



            Stack<int> S = new Stack<int>();

            Queue<string> Q = new Queue<string>();
           // Enqueue("Pune");
*/

        }
    }
}
