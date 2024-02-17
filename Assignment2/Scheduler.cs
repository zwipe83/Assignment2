/// < summary >
/// Filename: Scheduler.cs
/// Created on: 2024-02-01 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 
using Utilities;

namespace Assignment2
{
    /// <summary>
    /// Class Scheduler
    /// </summary>
    internal class Scheduler
    {
        /// <summary>
        /// Class fields
        /// </summary>
        private string? employeeName;
        private int startWeekends;
        private int startNights;
        private bool exitNow = false;

        /// <summary>
        /// Constructor initializes a new employee with input which week to work weekends and which week to work nights
        /// </summary>
        /// <param name="start_weekends"></param>
        /// <param name="start_nights"></param>
        public Scheduler(string? employee_name, int start_weekends, int start_nights)
        {
            employeeName = employee_name;
            startWeekends = start_weekends;
            startNights = start_nights;
        }

        /// <summary>
        /// Prints which weeks to work weekends
        /// </summary>
        private void ShowWeekends()
        {
            Console.WriteLine($"{employeeName}, Weekends to work:");
            for (int i = startWeekends; i <= 52; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i}     ");
                }
            }
        }

        /// <summary>
        /// Prints which weeks to work nights
        /// </summary>
        private void ShowNights()
        {
            Console.WriteLine($"{employeeName}, Nights to work:");
            for (int i = startNights; i <= 52; i++)
            {
                if (i % 4 == 1)
                {
                    Console.WriteLine($"{i}     ");
                }
            }
        }

        /// <summary>
        /// Read input from console
        /// </summary>
        /// <returns></returns>
        private int ReadInput()
        {
            Console.Clear();
            Console.WriteLine($"\n{employeeName}, choose one of the options below\n");
            Console.WriteLine($"1. Show a list of weekends to work");
            Console.WriteLine($"2. Show a list of nights to work");
            Console.WriteLine($"0. Quit\n");
            int option = Utilities.Utils.ReadInteger(0, 2);
            return option;
        }

        /// <summary>
        /// Present data based on input option
        /// </summary>
        /// <param name="option"></param>
        private int PresentData(int option)
        {
            switch (option)
            {
                case 1:
                    ShowWeekends();
                    Pause();
                    break;
                case 2:
                    ShowNights();
                    Pause();
                    break;
                case 0:
                    exitNow = true;
                    break;
                default: //Nothing to do.
                    break;
            }

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
        /// Execute class methods
        /// </summary>
        public void Run()
        {
            Console.Clear();
            do
            {
                PresentData(ReadInput());
            }
            while (!Utilities.Utils.RunAgain(exitNow));
        }
    }
}
