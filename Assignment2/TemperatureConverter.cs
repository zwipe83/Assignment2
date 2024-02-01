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
            int i = 1;
            return i;
        }

        public void Run()
        { 
            int option = ReadInput();
            PresentData(option);
        }
    }
}
