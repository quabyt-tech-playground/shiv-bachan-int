// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//int[] numbers = {1,2,3,4,5,6 };
//numbers.GetValue(2);
//Console.WriteLine(numbers.Length);
//Console.WriteLine(numbers.GetValue(2)); 
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Collections_Practice
{
    internal class Geeks
    {
        public static void Main(string[] args)
        {
            //List<int> list = new List<int>();
            //for (int j = 5; j < 10; j++)
            //{
            //    list.Add(j * 3);
            //}
            //foreach (int items in list)
            //{
            //    Console.WriteLine(items);
            //}

            //List<string> salmons = ["chinook", "coho", "pink", "sockeye"];
            ArrayList arrayList = new ArrayList();

            // Adding elements to the ArrayList
            //arrayList.Add(10);
            //arrayList.Add("Hello");
            //arrayList.Add(3.14);

            //// Accessing elements
            //Console.WriteLine("ArrayList Elements:");
            //foreach (object item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            Dictionary<string,int> ageMap = new Dictionary<string,int>();

            ageMap.Add("john", 25);
            ageMap["jane"] = 30;

            foreach (KeyValuePair<string, int> kvp in ageMap)
            {
                Console.WriteLine($"{kvp.Key}, {kvp.Value}");


            }

            //Linked List----------------
            LinkedList<string> linkedList = new LinkedList<string>();

            // Adding elements to the LinkedList
            linkedList.AddLast("apple");
            linkedList.AddLast("banana");
            linkedList.AddLast("orange");

            // Accessing elements sequentially (fast)
            Console.WriteLine("LinkedList elements:");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }

            // Inserting an element in the middle (fast)
            LinkedListNode<string> node = linkedList.Find("banana");
            linkedList.AddAfter(node, "grape");

            // Displaying elements after insertion
            Console.WriteLine("\nLinkedList elements after insertion:");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
