using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Test2
    {
        static void Main() {

            int j = 0;
            SimleMethod( ref j);
            Console.WriteLine(j);
        }
        public static void SimleMethod(ref int j) {

            j = 101;

        }
    }
}
