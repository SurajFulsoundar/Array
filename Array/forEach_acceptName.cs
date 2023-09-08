using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class forEach_acceptName
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];



            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter name", i + 1);
                names[i] = Console.ReadLine();
            }


            foreach (string items in names)
            {
                Console.WriteLine(items);
            }
        }
    }
}

