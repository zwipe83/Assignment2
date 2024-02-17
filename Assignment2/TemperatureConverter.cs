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
    internal class TemperatureConverter
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
                //Console.WriteLine($"{fahrenheit}°F:{ConvertFtoC(fahrenheit):f2}°C");
                Console.WriteLine("{0,16:f2} °F = {1,6:f2} °C", fahrenheit, ConvertFtoC(fahrenheit));
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
                //Console.WriteLine($"{celsius}°C:{ConvertCtoF(celsius):f2}°F");
                Console.WriteLine("{0,16:f2} °C = {1,6:f2} °F", celsius, ConvertCtoF(celsius));
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
        /// Read input from console
        /// </summary>
        /// <returns></returns>
        private int ReadInput()
        {
            Console.Clear();
            Console.WriteLine($"\n*********************************");
            Console.WriteLine($"\n\tMAIN MENU");
            Console.WriteLine($"\n*********************************");
            Console.WriteLine($"\nChoose one of the options below\n");
            Console.WriteLine($"1. Convert from Fahrenheit to Celsius");
            Console.WriteLine($"2. Convert from Celsius to Fahrenheit");
            Console.WriteLine($"0. Quit\n");
            Console.WriteLine($"*********************************");
            int option = Utilities.Utils.ReadInteger(0,2);
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
