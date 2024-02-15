using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Test5
    {
     //Parameter Arrays
        static void Main()
        {
            // Example 1: Using params with an array
            DisplayNumbers("Numbers:", 1, 2, 3, 4, 5);

            // Example 2: Using params with different data types
            DisplayValues("Values:", "Hello", 42, 3.14, true);

            ShowNames("students:","hjdsf","jff","fhjehf");
        }

        // Example 1: Using params with an array
        static void DisplayNumbers(string message, params int[] numbers)
        {
            Console.WriteLine(message);
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        // Example 2: Using params with different data types
        static void DisplayValues(string message, params object[] values)
        {
            Console.WriteLine(message);
            foreach (var value in values)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }

        static void ShowNames(string name, params string[] names) {
            Console.WriteLine(name);

            foreach (var student in names) { 

                Console.WriteLine(student);
            }
        }
       
    }

}

