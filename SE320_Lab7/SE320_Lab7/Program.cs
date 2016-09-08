using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE320_Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            // create arrays of int, double and char
            int[] intArray = { 1, 2, 3, 4, 5, 6 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };

            Console.WriteLine("Array intArray contains:");
            DisplayArray(intArray); // pass an int array argument
            Console.WriteLine("Array doubleArray contains:");
            DisplayArray(doubleArray); // pass a double array argument
            Console.WriteLine("Array charArray contains:");
            DisplayArray(charArray); // pass a char array argument
            Console.WriteLine("Array intArray index 2 to 4 contains:");
            DisplayArray(intArray, 2, 4);
            Console.ReadLine();
        } // end Main

        // output array of all types
        private static void DisplayArray<T>(T[] inputArray)
        {
            foreach (T element in inputArray)
                Console.Write(element + " ");
            Console.WriteLine("\n");
        } // end method DisplayArray
        private static void DisplayArray<T>(T[] inputArray, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                if ((lowIndex > 0) || (highIndex < inputArray.Length))
                {
                    for (int flc = lowIndex; flc <= highIndex; flc++)
                    {
                        Console.Write(inputArray[flc] + " ");
                    }
                }
                else
                {
                    throw new Exception("Index out of range");
                }
            }
            else
            {
                throw new Exception("Index out of range");
            }
        }
    }
}
