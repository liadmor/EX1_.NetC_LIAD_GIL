using System;
using System.Text;

namespace B21_Ex01_3
{
    class Program
    {
        public static void PrintHourGlassAdvence(string i_High)
        {
            int highStars;
            bool convertToNumber;

            convertToNumber = Int32.TryParse(i_High, out highStars);
            while (!convertToNumber)
            {
                Console.WriteLine("Invalid number, Please enter the high of the clock");
                i_High = Console.ReadLine();
                convertToNumber = Int32.TryParse(i_High, out highStars);
            }

            if (highStars % 2 == 0)
            {
                Console.WriteLine("The number is even so we added one for the high of the clock");
                B21_Ex01_2.Program.PrintHourGlass(highStars + 1, 1);
            }
            else
            {
                B21_Ex01_2.Program.PrintHourGlass(highStars, 1);
            }
        }

        public static bool ValidInput(string i_High)
        {
            int highStars;

            return Int32.TryParse(i_High, out highStars);
        }
        public static void Main()
        {
            string high;

            Console.WriteLine("Please enter the high of the clock");
            high = Console.ReadLine();
            while (!ValidInput(high))
            {
                Console.WriteLine("Please enter a valid high of the clock");
                high = Console.ReadLine();
            }

            PrintHourGlassAdvence(high);
            Console.WriteLine("Examle with input 4");
            PrintHourGlassAdvence("4");
            Console.WriteLine("Examle with input 5");
            PrintHourGlassAdvence("5");
            Console.WriteLine("Examle with input 6");
            PrintHourGlassAdvence("6");
            Console.WriteLine("Examle with input 8");
            PrintHourGlassAdvence("8");
        }
    }
}

