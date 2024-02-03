using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class StringFunctions
    {
        private string? inputString;
        public static int GetStringLength(string inputString)
        {
            return inputString.Length;
        }

        public static string ConvertStringToUpperCase(string inputString)
        { 
            return inputString.ToUpper(); 
        }

        public void PredictMyDay()
        {
            Console.WriteLine("Enter what day of the week it is(1-7)");
            int option;
            bool ok = int.TryParse(Console.ReadLine(), out option);
            if (!ok)
            {
                Console.Clear();
                PredictMyDay(); // This will cause recursion, fix!!!
            }
            else
            {
                if (option < 1 || option > 7)
                {
                    Console.Clear();
                    PredictMyDay(); // This will cause recursion, fix!!!
                }
            }
            string data;
            switch(option)
            {
                case 1:
                    data = "Get your coffee, it's Monday!";
                    break;
                case 2:
                case 3:
                    data = "Tuesdays and Wednesdays are to cool for school!";
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


        public void ReadInput()
        {
            Console.WriteLine("Enter some text to evaluate:");
            inputString = Console.ReadLine()?.ToString();
        }

        public void PresentInfo()
        {
            int length = GetStringLength(inputString);
            string uppercase = ConvertStringToUpperCase(inputString);
            Console.WriteLine($"String length is: {length} and the string in upper case: {uppercase}");
        }

        public void RunAgain()
        {
            Console.WriteLine("Continue(y/n)?");
            string? answer = Console.ReadLine();

            if (answer != null)
            {
                answer = answer?.Trim();
            }

            char response = ((answer is not null && answer.Length > 0) ? answer[0] : '\0');

            if ((response == 'y') || (response == 'Y'))
            {
                Console.Clear();
                Run();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        public void Run()
        {
            ReadInput();
            PresentInfo();
            PredictMyDay();
            RunAgain();
        }
    }
}
