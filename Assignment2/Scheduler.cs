/// < summary >
/// Filename: Scheduler.cs
/// Created on: 2024-02-01 00:00:00
/// Author: Samuel Jeffman
/// </summary>

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
        private string? name;
        private int startWeekends;
        private int startNights;

        /// <summary>
        /// Constructor initializes a new employee with input which week to work weekends and which week to work nights
        /// </summary>
        /// <param name="start_weekends"></param>
        /// <param name="start_nights"></param>
        public Scheduler(string? employee_name, int start_weekends, int start_nights)
        {
            name = employee_name;
            startWeekends = start_weekends;
            startNights = start_nights;
        }

        /// <summary>
        /// Prints which weeks to work weekends
        /// </summary>
        private void ShowWeekends()
        {
            Console.WriteLine($"{name}, Weekends to work:");
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
            Console.WriteLine($"{name}, Nights to work:");
            for (int i = startNights; i <= 52; i++)
            {
                if (i % 4 == 1)
                {
                    Console.WriteLine($"{i}     ");
                }
            }
        }

        /// <summary>
        /// Execute class methods
        /// </summary>
        public void Run()
        {
            Console.Clear();
            ShowWeekends();
            ShowNights();
        }
    }
}
