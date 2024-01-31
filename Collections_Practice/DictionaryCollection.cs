using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Practice
{
    internal class DictionaryCollection
    {
        public static void Main(string[] args)
        {
           Dictionary<string,object> dt = new Dictionary<string,object>();

            dt.Add("Eid",1010);
            dt.Add("Ename","Scott");
            dt.Add("Job","Manager");

            foreach(string key in dt.Keys)
            {
                Console.WriteLine(key +" : "+ dt[key]);
                
                

            }
        }
        }
}
