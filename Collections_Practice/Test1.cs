using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Practice
{
    internal class Test1
    {
        public static void Main(string[] args)
        {
            // string str2 = "hello";
            // string str1 = new string('a',5);
            // //Console.WriteLine(str1);

            // string firstName = "John";
            // string lastName = "Doe";
            // // string fullName = firstName + " " + lastName; // Concatenation using the + operator
            //string concated= string.Concat(str2+" "+firstName+" "+lastName);

            // Console.WriteLine(concated);
            


                // Example string
                string originalString = "   Hello, World!   ";

                // Length
                int length = originalString.Length;
                Console.WriteLine($"Length: {length}"); // Output: Length: 17

                // Substring
                string substring = originalString.Substring(7, 5);
                Console.WriteLine($"Substring: {substring}"); // Output: Substring: World

                // ToUpper and ToLower
                string upperCase = originalString.ToUpper();
                string lowerCase = originalString.ToLower();
                Console.WriteLine($"Upper Case: {upperCase}\nLower Case: {lowerCase}");

                // Trim
                string trimmedString = originalString.Trim();
                Console.WriteLine($"Trimmed: {trimmedString}"); // Output: Trimmed: Hello, World!

                // Replace
                string replacedString = originalString.Replace("Hello", "Hi");
                Console.WriteLine($"Replaced: {replacedString}"); // Output: Replaced:   Hi, World!   

                // Contains
                bool containsWorld = originalString.Contains("World");
                Console.WriteLine($"Contains 'World': {containsWorld}"); // Output: Contains 'World': true

                // IndexOf
                int indexOfComma = originalString.IndexOf(',');
                Console.WriteLine($"Index of ',': {indexOfComma}"); // Output: Index of ',': 7

                // LastIndexOf
                int lastIndexOfSpace = originalString.LastIndexOf(' ');
                Console.WriteLine($"Last Index of ' ': {lastIndexOfSpace}"); // Output: Last Index of ' ': 14

                // String Comparison
                string str1 = "abc";
                string str2 = "ABC";
                bool areEqual = String.Equals(str1, str2, StringComparison.OrdinalIgnoreCase);
                Console.WriteLine($"String Comparison: {areEqual}"); // Output: String Comparison: true

                // String Concatenation
                string firstName = "John";
                string lastName = "Doe";
                string fullName = firstName + " " + lastName;
                Console.WriteLine($"Full Name: {fullName}"); // Output: Full Name: John Doe

                // String Interpolation
                string interpolatedString = $"{firstName} {lastName}";
                Console.WriteLine($"Interpolated String: {interpolatedString}"); // Output: Interpolated String: John Doe

                // String Format
                string formattedString = String.Format("Name: {0}, Age: {1}", "John", 30);
                Console.WriteLine($"Formatted String: {formattedString}"); // Output: Formatted String: Name: John, Age: 30

                // Escape Sequences
                string escapeSequence = "This is a new line.\n\tThis is a tab.\n\"This is in double quotes.\"";
                Console.WriteLine($"Escape Sequences:\n{escapeSequence}");
            }
        }

    }

