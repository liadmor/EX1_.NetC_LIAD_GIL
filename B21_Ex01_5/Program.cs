using System;
using System.Text;

namespace B21_Ex01_5
{
    class Program
    {
        public static int MaxDigit(int i_inputNumber)
        {
            int maxDigit = i_inputNumber % 10;
            int unit = 0;

            for (int i = 0; i < 6; i++)
            {
                unit = i_inputNumber % 10;
                if (unit >= maxDigit)
                {
                    maxDigit = unit;
                }

                i_inputNumber /= 10;
            }

            return maxDigit;
        }
        public static int MinDigit(int i_inputNumber)
        {
            int minDigit = i_inputNumber % 10;
            int unit;

            for (int i = 0; i < 6; i++)
            {
                unit = i_inputNumber % 10;
                if (unit <= minDigit)
                {
                    minDigit = unit;
                }

                i_inputNumber /= 10;
            }

            return minDigit;
        }
        public static int DividedByThree(int i_inputNumber)
        {
            int countDigitDivided = 0;
            int unit;

            for (int i = 0; i < 6; i++)
            {
                unit = i_inputNumber % 10;
                if (unit % 3 == 0)
                {
                    countDigitDivided++;
                }

                i_inputNumber /= 10;
            }

            return countDigitDivided;
        }
        public static int BiggerThanFirstUnit(int i_inputNumber)
        {
            int unit = i_inputNumber % 10;
            int digit;
            int countDigitBiggerThan = 0;

            i_inputNumber /= 10;
            for (int i = 0; i < 6; i++)
            {
                digit = i_inputNumber % 10;
                if (digit > unit)
                {
                    countDigitBiggerThan++;
                }

                i_inputNumber /= 10;
            }

            return countDigitBiggerThan;
        }
        public static bool IsValidInput(string i_input)
        {
            int result = 0;
            bool answer = false;
            if (i_input.Length != 6)
            {
                answer = false;
            }
            else
            {
                if (Int32.TryParse(i_input, out result) && (result >= 0))
                {
                    answer = true;
                }
            }

            return answer;
        }
        public static void Main()
        {
            string inputString;
            int result = 0;
            bool sucssiedParse;
            string biggerDigit;
            string smallDigit;
            string divInThree;
            string numDigitBig;

            Console.WriteLine("Please enter string in length 6 with digit only");
            inputString = Console.ReadLine();
            while (!IsValidInput(inputString))
            {
                Console.WriteLine("Invalid input.\nPlease enter string in lenght 10 with letter or digit only");
                inputString = Console.ReadLine();
            }
            sucssiedParse = Int32.TryParse(inputString, out result);
            biggerDigit = String.Format("The biggest digit in the number is: {0}", MaxDigit(result));
            smallDigit = String.Format("The smallest digit in the number is: {0}", MinDigit(result));
            divInThree = String.Format("The number of digits which divided by 3 is: {0}", DividedByThree(result));
            numDigitBig = String.Format("The number of digits which bigger than the unit digit is: {0}", BiggerThanFirstUnit(result));
            Console.WriteLine(biggerDigit + '\n' + numDigitBig + '\n' + smallDigit + '\n' + divInThree);
        }
    }
}

