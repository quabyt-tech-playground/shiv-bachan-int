using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Test4
    {
        public static void Main()
        {
           
            ParamsMethod(1,2,3,4);
        }

        public static void ParamsMethod( params int[] Numbers) { 
       foreach (int i in Numbers)
            {

                Console.WriteLine(i);   
            }

        }

    }
}
