using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Practice
{
    internal class ExpTest
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter the numerator: ");
                int numerator = int.Parse(Console.ReadLine());

                Console.Write("Enter the denominator: ");
                int denominator = int.Parse(Console.ReadLine());

                int result = DivideNumbers(numerator, denominator);
                Console.WriteLine($"Result: {result}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message}\nPlease enter valid numeric values.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}\nCannot divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Finally block executed.");
            }
        }

        static int DivideNumbers(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }

            return numerator / denominator;
        }




    }
}
