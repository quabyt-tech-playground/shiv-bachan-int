using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Practice
{
    public class FirstOrDefault
    {
        public static void main(string[] args) {

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            int firstEvenNumber = numbers.FirstOrDefault(x => x % 2 == 0);

            Console.WriteLine(firstEvenNumber); // Output: 2

        }
    }
}
