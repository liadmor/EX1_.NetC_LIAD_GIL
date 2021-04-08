using System;
using System.Text;

namespace B21_Ex01_2
{
    public class Program
    {
        public static void PrintHourGlass(int i_ClockHigh, int i_NumberOfSpaces)
        {
            if (i_ClockHigh == 1)
            {
                Console.WriteLine("*");
            }
            else
            {
                for (int i = 0; i < i_ClockHigh; i++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
                for (int j = 0; j < i_NumberOfSpaces; j++)
                {
                    Console.Write(" ");
                }

                PrintHourGlass(i_ClockHigh - 2, i_NumberOfSpaces + 1);
                for (int j = 0; j < i_NumberOfSpaces - 1; j++)
                {
                    Console.Write(" ");
                }

                for (int i = 0; i < i_ClockHigh; i++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
        public static void Main()
        {
            int numberOfStars = 5;

            PrintHourGlass(numberOfStars, 1);
        }
    }
}

