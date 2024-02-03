using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class TemperatureConverter
    {
        private double ConvertCtoF(double celsius)
        {
            return 9 / 5 * celsius + 32;
        }
        private double ConvertFtoC(double fahrenheit)
        {
            return (double)5 / 9 * (fahrenheit - 32);
        }

        private void IterateFtoC(double limit, int interval)
        {
            for (int i = 0; i <= limit; i += interval)
            {
                Console.WriteLine($"{i}F:{ConvertFtoC(i):f2}");
            }
        }
        private void IterateCtoF(double limit, int interval)
        {
            for (int i = 0; i <= limit; i += interval)
            {
                Console.WriteLine($"{i}F:{ConvertCtoF(i):f2}");
            }
        }

        private void PresentData(int option)
        {
            switch(option)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    IterateFtoC(210, 10);
                    break;
                case 2:
                    IterateCtoF(100, 5);
                    break;
                default:
                    break;
            }
        }

        private int ReadInput()
        {
            Console.WriteLine($"\nChoose one of the options below");
            Console.WriteLine($"\n0. Exit application");
            Console.WriteLine($"\n1. Convert from Fahrenheit to Celsius");
            Console.WriteLine($"\n2. Convert from Celsius to Fahrenheit");
            int option;
            bool ok = int.TryParse(Console.ReadLine(), out option);
            if(!ok)
            {
                Console.Clear();
                ReadInput(); // This will cause recursion, fix!!!
            }
            else
            {
                if(option < 0 || option > 2)
                {
                    Console.Clear();
                    ReadInput(); // This will cause recursion, fix!!!
                }
            }
            return option;
        }

        public void Run()
        { 
            PresentData(ReadInput());
            Run();
        }
    }
}
