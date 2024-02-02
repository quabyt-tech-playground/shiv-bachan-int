using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Practice
{
    internal class RemoveDuplicate
    {
        static void Main()
        {
            List<string> stringList = new List<string>
                //HashSet<string> stringSet = new HashSet<string>()

            {
                "apple", "orange", "banana", "grape","apple","banana",  "kiwi"
            };
            HashSet<string> uniqueSet = new HashSet<string>();

            List<string> uniqueStrings = stringList.Where(s => uniqueSet.Add(s)).ToList();
            Console.WriteLine("List of all fruits");
            PrintList(uniqueStrings);
            Console.WriteLine("List of all unique fruits");
            PrintList(stringList);
        }

        static void PrintList(List<string> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
