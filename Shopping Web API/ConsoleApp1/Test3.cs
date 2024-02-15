using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Test3
    {
        public static void Main() {

            int Total = 0;
            int Product = 0;
            Calculate(10,20, out Total, out Product);
            Console.WriteLine($"total:{Total}   product:{Product}");

        }
        public static void Calculate(int FN,int SN,out int Sum,out int Product) {

            Sum = FN + SN;
            Product = FN*SN;
        }


        

    }
    
}
