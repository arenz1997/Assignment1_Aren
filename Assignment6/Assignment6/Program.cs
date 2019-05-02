using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiMap<int, string> multiMap = new MultiMap<int, string>();
            multiMap.Add(7, "A");//multiMap[7].Add "d";
            multiMap.Add(7, "R");
            multiMap.Add(7, "E");
            multiMap.Add(7, "N");
            multiMap.Add(7, "Z");

            multiMap.Add(8, "M");
            multiMap.Add(8, "A");
            multiMap.Add(8, "G");
            multiMap.Add(8, "A");
            multiMap.Print();
            Console.WriteLine("KeyCount = " + multiMap.Count);
            Console.WriteLine(multiMap.Contains(11));
            Console.WriteLine(multiMap.Contains(7));
            //multiMap[8] = multiMap[7];
            //multiMap.Clear();

            //string[] arr = new string [100];
            //multiMap.CopyTo(arr, 0);

            //multiMap.Remove(7);
            //multiMap.Add(7,"Zohranyan");
        }
    }
}