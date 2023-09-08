using System;
using System.Collections;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class DictionaryFun
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            dictionary.Add(".docx", "Word file");
            dictionary.Add(".xlsx", "Exel file");
            dictionary.Add(".cs", "C# file");
            Console.WriteLine( "......................................................" );
            foreach (KeyValuePair<string, string> items in dictionary)
            {
                Console.WriteLine($"{items.Key} {items.Value}");

            }

            Dictionary<int, string> dictionary2 = new Dictionary<int, string>();

            dictionary2.Add(102, "HR");
            dictionary2.Add(103, "Sales");
            dictionary2.Add(105, "Marketing");

            dictionary2.Remove(103);
            Console.WriteLine(  "//////////////////");
            foreach (KeyValuePair<int, string>  s in dictionary2)
            {
                Console.WriteLine($"{s.Key} {s.Value}");
            }



        }
    }
}
