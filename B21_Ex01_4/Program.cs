using System;
using System.Text;

namespace B21_Ex01_4
{
    class Program
    {
        public static bool IsPolindrom(string i_Word, int i_LeftIndex, int i_RightIndex)
        {
            bool answer = true;
            bool temp = true;

            if (i_Word[i_LeftIndex] != i_Word[i_RightIndex])
            {
                answer = false;
            }

            temp = answer;

            if (i_LeftIndex < i_RightIndex)
            {
                answer = IsPolindrom(i_Word, i_LeftIndex + 1, i_RightIndex - 1);
            }

            return answer && temp;
        }
        public static bool IsDividedByFour(int i_Number)
        {
            bool answer = false;

            answer = i_Number % 4 == 0;

            return answer;
        }
        public static int NumberOfUpperCase(string i_Str)
        {
            int countUpperCase = 0;

            for (int i = 0; i < i_Str.Length; i++)
            {
                if ((i_Str[i] >= 'A') && (i_Str[i] <= 'Z'))
                {
                    countUpperCase++;
                }
            }

            return countUpperCase;
        }
        public static bool IsValidInput(string i_Input)
        {
            int result = 0;
            bool answer = true;

            if (i_Input.Length != 10)
            {
                answer = false;
            }
            else
            {
                if (Int32.TryParse(i_Input, out result))
                {
                    answer = true;
                }
                else
                {
                    for (int i = 0; i < i_Input.Length; i++)
                    {
                        if (((i_Input[i] < 'A') || (i_Input[i] > 'Z')) && ((i_Input[i] < 'a') || (i_Input[i] > 'z')))
                        {
                            answer = false;
                        }
                    }
                }
            }

            return answer;
        }
        public static void Main()
        {
            int result = 0;
            string inputString;
            StringBuilder outputString;

            Console.WriteLine("Please enter string in length 10 with letter or digit only");
            inputString = Console.ReadLine();
            outputString = new StringBuilder();
            while (!IsValidInput(inputString))
            {
                Console.WriteLine("Invalid input.\nPlease enter string in lenght 10 with letter or digit only");
                inputString = Console.ReadLine();
            }

            if (IsPolindrom(inputString, 0, inputString.Length - 1))
            {
                outputString.AppendLine("The string is Polindrom");
            }
            else
            {
                outputString.AppendLine("The string is NOT Polindrom");
            }

            if (Int32.TryParse(inputString, out result))
            {
                if (IsDividedByFour(result))
                {
                    outputString.AppendLine("The string is a number divided by 4 ");
                }
                else
                {
                    outputString.AppendLine("The string is a number that NOT divided by 4");
                }
            }
            else
            {
                string upperCaseString = String.Format("The number of upper case letters in the string is {0} ", NumberOfUpperCase(inputString));
                outputString.AppendLine(upperCaseString);
            }

            Console.WriteLine(outputString.ToString());
        }
    }
}

