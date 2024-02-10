/// < summary >
/// Filename: StringFunctions.cs
/// Created on: 2024-02-01 00:00:00
/// Author: Samuel Jeffman
/// </summary>

namespace Assignment2
{
    /// <summary>
    /// Class StringFunctions
    /// </summary>
    internal class StringFunctions
    {
        /// <summary>
        /// Get length of input string as int
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static int GetStringLength(string inputString)
        {
            return inputString.Length;
        }

        /// <summary>
        /// Convert input string to uppercase
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static string ConvertStringToUpperCase(string inputString)
        { 
            return inputString.ToUpper();
        }

        /// <summary>
        /// Read input as Integer and do checks for datatype and in range.
        /// </summary>
        /// <param name="rangeStart"></param>
        /// <param name="rangeEnd"></param>
        /// <returns></returns>
        private static int ReadInteger(int rangeStart, int rangeEnd)
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
                    inRange = Enumerable.Range(rangeStart, rangeCount).Contains(input);
                    if (!inRange)
                    {
                        Console.WriteLine($"Value out of range ({rangeStart}-{rangeEnd})!");
                    }
                }
            }
            while (!isInt || !inRange); //Continue until input is of datatype int and value is in range.
            return input;
        }

        /// <summary>
        /// Method returns a humorous remark as string depending on what day it is
        /// </summary>
        public static void PredictMyDay()
        {
            Console.WriteLine("Enter what day of the week it is(1-7)");
            int option = ReadInteger(1,7);

            string data;
            switch(option)
            {
                case 1:
                    data = "Get your coffee, it's Monday!";
                    break;
                case 2:
                case 3:
                    data = "Tuesdays and Wednesdays are too cool for school!";
                    break;
                case 4:
                    data = "Better get to work, it's Thursday already!";
                    break;
                case 5:
                    data = "Finally Friday for funs sake!";
                    break;
                case 6:
                    data = "It's Saturday, have some rest!";
                    break;
                case 7:
                    data = "Sunday already, her comes monday...";
                    break;
                default:
                    data = "No day... nothing to do here...";
                    break;
            }
            Console.WriteLine($"Here's one for you:\n{data}");
        }

        /// <summary>
        /// Read console input
        /// </summary>
        /// <returns></returns>
        private static string ReadInput()
        {
            string? inputString;
            Console.WriteLine("Enter some text to evaluate:");
            inputString = Console.ReadLine()?.ToString();

            if (inputString == null)
            {
                inputString = "String was 'null'";
            }

            return inputString;
        }

        /// <summary>
        /// Presents information about the input string
        /// </summary>
        /// <param name="inputString"></param>
        public static void PresentStringInfo(string inputString)
        {
            int length = GetStringLength(inputString);
            string uppercase = ConvertStringToUpperCase(inputString);
            Console.WriteLine($"String length is: {length} and the string in upper case: {uppercase}");
        }

        /// <summary>
        /// Figure out if we should run again or not
        /// </summary>
        /// <returns></returns>
        public static int RunAgain()
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
                return 1; //Run again
            }
            else
            {
                return 0; //Exit
            }
        }

        /// <summary>
        /// Execute methods of the class
        /// </summary>
        public void Run()
        {
            int option;
            do
            {
                PresentStringInfo(ReadInput());
                PredictMyDay();
                option = RunAgain();
            }
            while (option != 0);
        }
    }
}
