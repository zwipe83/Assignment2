/// < summary >
/// Filename: TemperatureConverter.cs
/// Created on: 2024-02-01 00:00:00
/// Author: Samuel Jeffman
/// </summary>

namespace Assignment2
{
    /// <summary>
    /// Class TemperatureConverter
    /// </summary>
    public class TemperatureConverter
    {
        /// <summary>
        /// Convert Celsius value to Fahrenheit
        /// </summary>
        /// <param name="celsius"></param>
        /// <returns></returns>
        private double ConvertCtoF(double celsius)
        {
            return 9.0 / 5.0 * celsius + 32;
        }

        /// <summary>
        /// Convert Fahrenheit value to Celsius
        /// </summary>
        /// <param name="fahrenheit"></param>
        /// <returns></returns>
        private double ConvertFtoC(double fahrenheit)
        {
            return 5.0 / 9.0 * (fahrenheit - 32);
        }

        /// <summary>
        /// Iterate interval of Fahenheit values
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="interval"></param>
        private void IterateFtoC(double limit, int interval)
        {
            int fahrenheit = 0;
            Console.WriteLine("\nConverting Fahrenheit to Celsius:\n");
            do
            {
                Console.WriteLine($"{fahrenheit}°F:{ConvertFtoC(fahrenheit):f2}°C");
                fahrenheit += interval;
            }
            while (fahrenheit <= limit);

            //Alternate solution
            /*for (int fahrenheit = 0; fahrenheit <= limit; fahrenheit += interval)
            {
                Console.WriteLine($"{fahrenheit}°F:{ConvertFtoC(fahrenheit):f2}°C");
            }*/
        }

        /// <summary>
        /// Iterate interval of Celsius values
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="interval"></param>
        private void IterateCtoF(double limit, int interval)
        {
            int celsius = 0;
            Console.WriteLine("\nConverting Celsius to Fahrenheit:\n");
            do
            {
                Console.WriteLine($"{celsius}°C:{ConvertCtoF(celsius):f2}°F");
                celsius += interval;
            }
            while (celsius <= limit);

            //Alternate solution
            /*for (int celsius = 0; celsius <= limit; celsius += interval)
            {
                Console.WriteLine($"{celsius}°C:{ConvertCtoF(celsius):f2}°F");
            }*/
        }

        /// <summary>
        /// Present data based on input option
        /// </summary>
        /// <param name="option"></param>
        private int PresentData(int option)
        {
            switch(option)
            {
                case 1:
                    IterateFtoC(210, 10);
                    Pause();
                    break;
                case 2:
                    IterateCtoF(100, 5);
                    Pause();
                    break;
                case 0:
                default: //Nothing to do.
                    break;
            }

            return option;
        }

        /// <summary>
        /// Read input as Integer and do checks for datatype and in range.
        /// </summary>
        /// <param name="rangeStart"></param>
        /// <param name="rangeEnd"></param>
        /// <returns></returns>
        private int ReadInteger(int rangeStart, int rangeEnd)
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
                    if(!inRange)
                    {
                        Console.WriteLine($"Value out of range ({rangeStart}-{rangeEnd})!");
                    }
                }
            }
            while (!isInt || !inRange); //Continue until input is of datatype int and value is in range.
            return input;
        }

        /// <summary>
        /// Read input from console
        /// </summary>
        /// <returns></returns>
        private int ReadInput()
        {
            Console.Clear();
            Console.WriteLine($"\nChoose one of the options below\n");
            Console.WriteLine($"1. Convert from Fahrenheit to Celsius");
            Console.WriteLine($"2. Convert from Celsius to Fahrenheit");
            Console.WriteLine($"0. Exit application\n");
            int option = ReadInteger(0,2);
            return option;
        }

        /// <summary>
        /// Pause console and wait for input [ENTER]
        /// </summary>
        private void Pause()
        {
            Console.WriteLine("\nPress [ENTER] to continue.");
            Console.ReadLine();
            Console.Clear();
        }

        /// <summary>
        /// Execute methods of the class
        /// </summary>
        public void Run()
        {
            int option;
            do
            {
                option = PresentData(ReadInput());
            }
            while (option != 0);
        }
    }
}
