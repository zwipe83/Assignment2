/// < summary >
/// Filename: StringFunctions.cs
/// Created on: 2024-02-01 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 
using Utilities;

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
        private static int GetStringLength(string inputString)
        {
            return inputString.Length;
        }

        /// <summary>
        /// Convert input string to uppercase
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        private static string ConvertStringToUpperCase(string inputString)
        { 
            return inputString.ToUpper();
        }

        /// <summary>
        /// Method returns a humorous remark as string depending on what day it is
        /// </summary>
        private static void PredictMyDay()
        {
            Console.WriteLine("\n\n**********Fortune teller**********\n");
            Console.WriteLine("\nEnter what day of the week it is(1-7):");
            int option = Utilities.Utils.ReadInteger(1,7);

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
        private static void PresentStringInfo(string inputString)
        {
            int length = GetStringLength(inputString);
            string uppercase = ConvertStringToUpperCase(inputString);
            Console.WriteLine($"String length is: {length} and the string in upper case: {uppercase}");
        }

        /// <summary>
        /// Execute methods of the class
        /// </summary>
        public void Run()
        {
            do
            {
                Console.WriteLine("**********String functions**********\n\n");
                PresentStringInfo(ReadInput());
                PredictMyDay();
            }
            while (!Utilities.Utils.RunAgain());
        }
    }
}
