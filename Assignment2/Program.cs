namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureConverter temperatureConverter = new ();
            StringFunctions stringFunctions = new ();
            MathWorks mathWorks = new ();
            Scheduler employee1 = new("John", 2, 1);
            Scheduler employee2 = new("Carl", 5, 7);

            temperatureConverter.Run();
            Pause();
            stringFunctions.Run();
            Pause();
            mathWorks.Calculate();
            Pause();
            employee1.Run();
            Pause();
            employee2.Run();
        }

        /// <summary>
        /// Pause input before moving on
        /// </summary>
        static void Pause()
        {
            Console.WriteLine("\nPress Enter to continue to next part!");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
