using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>();
            li.Add(1);
            li.Add(2);
            li.Add(3);
            li.Add(4);
            li.Add(5);
            li.Add(6);
            li.Add(7);
            li.Add(8);
            li.Add(8);
            li.Add(9);
            li.Add(8);
            Console.WriteLine("Elements in the list are:");
            foreach(int i in li)
            {
                Console.WriteLine(i);
            }
            int res= li.Find(x => x.Equals(11));
            Console.WriteLine("element 11 in the list:{0}",res);
            List<int> finres = li.FindAll(x => x.Equals(10));
            foreach(int i in finres)
            {
                Console.WriteLine(i);
            }
            int index = li.FindIndex( x =>x.Equals(5));
            Console.WriteLine(index);
            int last=li.FindLast(x =>x.Equals(11));
            Console.WriteLine(last);
            int findLastIndex = li.FindLastIndex(x => x.Equals(8));
            Console.WriteLine(findLastIndex);
            Console.Read();
        }
    }
}
