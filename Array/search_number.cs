using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class search_number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of Array");
            int num = Convert.ToInt32(Console.ReadLine());

           

            int[] arr = new int[num];
            Console.WriteLine("Enter the list");

            for (int i = 0; i < arr.Length; i++) 
            {
                
                arr[i]= Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Enter the number want to search ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            bool isfound = false;
            for (int i = 0; i < arr.Length;i++)
            {
                
                if (arr[i] == num2)
                {
                    isfound = true;
                    break;

                }
            }
            if (isfound==true)
            {
                Console.WriteLine("number is present");
            }
            else
            {
                Console.WriteLine("number not present");
            }
        }
    }
}
