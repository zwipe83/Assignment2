/// < summary >
/// Filename: Utils.cs
/// Created on: 2024-02-17 00:00:00
/// Author: Samuel Jeffman
/// </summary>

namespace Utilities
{
    internal class Utils
    {

        /// <summary>
        /// Read input as Integer and do check for datatype.
        /// </summary>
        /// <returns></returns>
        public static int ReadInteger()
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
        /// Read input as Integer and do checks for datatype and in range.
        /// </summary>
        /// <param name="rangeStart"></param>
        /// <param name="rangeEnd"></param>
        /// <returns></returns>
        public static int ReadInteger(int rangeStart, int rangeEnd)
        {
            int rangeCount = rangeEnd - rangeStart + 1;
            int input;
            bool isInt;
            bool inRange = false;
            do
            {
                string? str = Console.ReadLine();
                isInt = int.TryParse(str, out input);
                if (!isInt)
                {
                    Console.WriteLine("Invalid number!");
                }
                else
                {
                    inRange = CheckIntInRange(rangeStart, rangeEnd, rangeCount, input);
                }
            }
            while (!isInt || !inRange); //Continue until input is of datatype int and value is in range.
            return input;
        }

        /// <summary>
        /// Checks in Integer is within range, including start and end (rangeStart <-> rangeEnd).
        /// </summary>
        /// <param name="rangeStart"></param>
        /// <param name="rangeEnd"></param>
        /// <param name="rangeCount"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        private static bool CheckIntInRange(int rangeStart, int rangeEnd, int rangeCount, int input)
        {
            bool inRange = Enumerable.Range(rangeStart, rangeCount).Contains(input);
            if (!inRange)
            {
                Console.WriteLine($"Value out of range ({rangeStart}-{rangeEnd})!");
            }

            return inRange;
        }

        /// <summary>
        /// Returns two integers
        /// </summary>
        /// <returns></returns>
        public static int[] ReadTwoIntegers()
        {
            int[] ints = new int[2];
            Console.WriteLine("\nEnter first number:");
            ints[0] = ReadInteger();
            Console.WriteLine("Enter second number:");
            ints[1] = ReadInteger();

            return ints;
        }

        /// <summary>
        /// Asks user for input y or n
        /// </summary>
        /// <returns></returns>
        private static bool AskUser()
        {
            Console.WriteLine("Run again(y/n)?");
            string? answer = Console.ReadLine();

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
        /// Asks if user want to continue or quit.
        /// </summary>
        /// <returns></returns>
        public static bool RunAgain()
        {
            return AskUser();
        }

        /// <summary>
        /// Asks if user want to continue or quit.
        /// </summary>
        /// <returns></returns>
        public static bool RunAgain(bool exitNow)
        {
            if (exitNow)
            {
                return true; //Quit instantly
            }
            else
            {
                return AskUser();
            }
        }
    }
}
