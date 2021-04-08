using System;
using System.Text;


namespace B21_Ex01_1
{
    class Program
    {
        public static bool CheckValidInput(string i_Str)
        {
            bool isValid = true;

            if (i_Str.Length != 7)
            {
                isValid = false;
            }

            for (int i = 0; i < i_Str.Length; i++)
            {
                if ((i_Str[i] != '1') && (i_Str[i] != '0'))
                {
                    isValid = false;
                }
            }

            return isValid;
        }
        public static int ConvertToDecimal(string i_BinNumber)
        {
            int decimalNumber = 0;

            for (int i = i_BinNumber.Length - 1; i >= 0; i--)
            {
                decimalNumber += (i_BinNumber[i] - '0') * (int)(Math.Pow(2, i_BinNumber.Length - 1 - i));
            }

            return decimalNumber;
        }
        public static int NumberOfZeros(string i_BinNumber)
        {
            int countZeros = 0;

            for (int i = i_BinNumber.Length - 1; i >= 0; i--)
            {
                if (i_BinNumber[i] == '0')
                {
                    countZeros++;
                }
            }

            return countZeros;
        }
        public static int NumberOfOnes(string i_BinNumber)
        {
            int countOnes = 0;

            for (int i = i_BinNumber.Length - 1; i >= 0; i--)
            {
                if (i_BinNumber[i] == '1')
                {
                    countOnes++;
                }
            }

            return countOnes;
        }
        public static bool IsPowerOfTwo(int i_Number)
        {
            bool isPowerTwo = true;

            if (i_Number == 0)
            {
                isPowerTwo = false;
            }

            while (i_Number != 1)
            {
                if (i_Number % 2 != 0)
                {
                    isPowerTwo = false;
                }

                i_Number /= 2;
            }

            return isPowerTwo;
        }
        public static bool IsMonotonousUp(int i_Number)
        {
            bool isMonotoneUp = true;

            while (i_Number > 0)
            {
                if (i_Number % 10 <= (i_Number / 10) % 10)
                {
                    isMonotoneUp = false;
                }

                i_Number /= 10;
            }

            return isMonotoneUp;
        }
        public static void Main()
        {
            int decimalNumber;
            int num_of_binary_number = 3;
            int countZeros = 0, countOnes = 0, countPowerTwo = 0, countMonotonic = 0;
            int maxNumber = -1;
            int minNumber = 999999999;
            string avgZeros, avgOnes, monotonic, maxMin, powerOfTwo;
            string inputFromUser = String.Format("Please enter {0} binary numbers", num_of_binary_number);
            StringBuilder inputs = new StringBuilder();

            Console.WriteLine(inputFromUser);
            for (int i = 0; i < num_of_binary_number; i++)
            {
                string binNumber = Console.ReadLine();
                while (!CheckValidInput(binNumber))
                {
                    Console.WriteLine("Please enter a valid numbers");
                    binNumber = Console.ReadLine();
                }

                decimalNumber = ConvertToDecimal(binNumber);
                inputs.AppendLine(decimalNumber.ToString());
                countZeros += NumberOfZeros(binNumber);
                countOnes += NumberOfOnes(binNumber);
                if (IsPowerOfTwo(decimalNumber))
                {
                    countPowerTwo++;
                }

                if (IsMonotonousUp(decimalNumber))
                {
                    countMonotonic++;
                }

                if (decimalNumber > maxNumber)
                {
                    maxNumber = decimalNumber;
                }

                if (decimalNumber < minNumber)
                {
                    minNumber = decimalNumber;
                }
            }

            avgZeros = String.Format("The average number of zeros is: {0} ", (double)countZeros / (double)num_of_binary_number);
            avgOnes = String.Format("The average number of ones is: {0} ", (double)countOnes / (double)num_of_binary_number);
            monotonic = String.Format("There is a {0} monotonic ", countMonotonic);
            maxMin = String.Format("The maximal number is: {0} and the minimal number is: {1}", maxNumber, minNumber);
            powerOfTwo = String.Format("{0} of the numbers power of 2 ", countPowerTwo);
            Console.WriteLine("The numbers are:\n" + inputs.ToString());
            Console.WriteLine(avgZeros + '\n' + avgOnes + '\n' + monotonic + '\n' + powerOfTwo + '\n' + maxMin);
        }
    }
}

