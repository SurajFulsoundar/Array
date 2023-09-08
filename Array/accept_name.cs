using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class accept_name
    {
        static void Main(string[] args)
        {

            string[] names = new string[5];

            

             for (int i = 0; i < 5; i++)
             {
                 Console.WriteLine("Enter name", i + 1);
                 names[i] = Console.ReadLine();
             }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(names[i]);
            }

           
        }
    }
}
