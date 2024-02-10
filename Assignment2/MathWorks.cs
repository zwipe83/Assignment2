/// < summary >
/// Filename: MathWorks.cs
/// Created on: 2024-02-01 00:00:00
/// Author: Samuel Jeffman
/// </summary>

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
            Console.WriteLine("\nPrinting even numbers:");
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
            Console.WriteLine("\nPrinting odd numbers:");
            for (int i = start; i <= end; ++i)
            {
                odd += (i % 2 != 0) ? $"{i} " : "";
            }
            Console.WriteLine($"Odd numbers between {start} and {end}:\n{odd}");
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
        public void PrintMultiplicationTable(int[] range)
        {
            int start = range[0];
            int end = range[1];
            Console.WriteLine("\nPrinting multiplication table:");
            for (int i = start; i <= end; i++) 
            {
                for(int j = start; j <= end; j++)
                {
                    Console.Write($"{i}*{j}: {i * j, 6:d}     ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Asks if user want to continue or quit.
        /// </summary>
        /// <returns></returns>
        private bool ExitCalculation()
        {
            Console.WriteLine("Run again(y/n)?");
            string? answer = Console.ReadLine();
            //maybe a do while here??????????????????????????????????????????????????????????
            if (answer != null)
            {
                answer = answer?.Trim();
            }

            char response = ((answer is not null && answer.Length > 0) ? answer[0] : '\0');

            if ((response == 'y') || (response == 'Y'))
            {
                Console.Clear();
                return false; //Run again
            }
            else
            {
                return true; //Exit
            }
        }

        /// <summary>
        /// Read input as Integer and do check for datatype.
        /// </summary>
        /// <returns></returns>
        private int ReadInteger()
        {
            int input;
            bool isInt;
            do
            {
                string? str = Console.ReadLine();
                isInt = int.TryParse(str, out input);
                if (!isInt)
                {
                    Console.WriteLine("Invalid input, not integer!");
                }
            }
            while (!isInt); //Continue until input is of datatype int
            return input;
        }

        /// <summary>
        /// Returns two integers
        /// </summary>
        private int[] ReadTwoIntegers()
        {
            int[] ints = new int[2];
            Console.WriteLine("Enter first number:");
            ints[0] = ReadInteger();
            Console.WriteLine("Enter second number:");
            ints[1] = ReadInteger();

            return ints;
        }

        public void Calculate()
        {
            do
            {
                range = ReadTwoIntegers();
                SumNumbers(range);
                PrintEvenNumbers(range);
                PrintOddNumbers(range);
                CalculateSquareRoot(range);
                PrintMultiplicationTable(range);
            }
            while(!ExitCalculation());
        }
    }
}
