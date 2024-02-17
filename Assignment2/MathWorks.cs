/// < summary >
/// Filename: MathWorks.cs
/// Created on: 2024-02-01 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 
using Utilities;

namespace Assignment2
{
    /// <summary>
    /// Class MathWorks
    /// </summary>
    internal class MathWorks
    {
        /// <summary>
        /// Class fields
        /// </summary>
        private int[] range = new int[2];

        /// <summary>
        /// Prints a sum of all numbers between input numbers
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        private void SumNumbers(int[] range)
        {
            int start = range[0];
            int end = range[1];
            int sum = 0;
            Console.WriteLine("Calculating sum:");
            for (int i = start; i <= end; i++) 
            {
                Console.WriteLine($"{sum}+{i}={sum+=i}");
            }
            Console.WriteLine($"\nThe total sum of all numbers between {start} and {end} is: {sum}");
        }

        /// <summary>
        /// Prints all even numbers between input numbers
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        private void PrintEvenNumbers(int[] range)
        {
            int start = range[0];
            int end = range[1];
            string even = "";
            for (int i = start; i <= end; ++i)
            {
                even += (i % 2 == 0) ? $"{i} " : "";
            }
            Console.WriteLine($"\nEven numbers between {start} and {end}:\n{even}");
        }

        /// <summary>
        /// Prints all odd numbers between input numbers
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        private void PrintOddNumbers(int[] range)
        {
            int start = range[0];
            int end = range[1];
            string odd = "";
            for (int i = start; i <= end; ++i)
            {
                odd += (i % 2 != 0) ? $"{i} " : "";
            }
            Console.WriteLine($"\nOdd numbers between {start} and {end}:\n{odd}");
        }

        /// <summary>
        /// Prints square roots of all numbers between input numbers
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        private void CalculateSquareRoot(int[] range)
        {
            int start = range[0];
            int end = range[1];
            Console.WriteLine("\nPrinting square roots:");
            for (int i = start; i <= end; i++)
            {
                Console.Write($"Square root of ({i} through {end})  ");
                for (int j = i; j <= end; j++)
                {
                    Console.Write($"{Math.Sqrt(j):N2}   ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Prints a muliplication table of all numbers betwen input numbers
        /// </summary>
        /// <param name="start"></param>
        /// <param name="limit"></param>
        private void PrintMultiplicationTable(int[] range)
        {
            int start = range[0];
            int end = range[1];
            Console.WriteLine("\nPrinting multiplication table:");
            for (int i = start; i <= end; i++) 
            {
                for(int j = start; j <= end; j++)
                {
                    Console.Write($"{i}*{j}: {i * j, 3:d}     ");
                }
                Console.WriteLine();
            }
        }

        public void Calculate()
        {
            do
            {
                Console.WriteLine("**********Let us do some maths!**********");
                range = Utilities.Utils.ReadTwoIntegers();
                SumNumbers(range);
                PrintEvenNumbers(range);
                PrintOddNumbers(range);
                CalculateSquareRoot(range);
                PrintMultiplicationTable(range);
            }
            while(!Utilities.Utils.RunAgain());
        }
    }
}
