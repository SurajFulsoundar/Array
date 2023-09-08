using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class prime_number_11_to_21
    {
        static void Main(string[] args)
        {
            
            for(int i = 50; i <= 100; i++)
            {
                int a = 0;
                
                for(int j = 2; j <= i/2; j++)
                {
                   
                    if(i % j == 0)
                    {
                        a = 1;
                      
                        
                        break;
                    }
                    

                }
                if(a == 0)
                {
                    Console.WriteLine(i);
                }
               
            }
        }
    }
}
