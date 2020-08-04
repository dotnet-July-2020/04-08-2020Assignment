using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryInCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> di = new Dictionary<string, string>();
            di.Add("one", "first");
            di.Add("two", "second");
            di.Add("three", "third");
            di.Add("four", "fourth");
            di.Add("five", "fifth");
            foreach(var i in di)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(di.ContainsKey("one"));
            Console.WriteLine(di.ContainsValue("second"));
            Dictionary<string, string>.KeyCollection keyColl = di.Keys;
            foreach(var j in keyColl)
            {
                Console.WriteLine(j);
            }
          
            Console.Read();
        }
    }
}
