namespace EnglishNameOfLastDigit
{
    using System;

    public class EnglishNameOfLastDigit
    {
        public static void Main()
        {
            var input = long.Parse(Console.ReadLine());
            var lastDigit = LastDigit(input);
            var digitToWord = ConverDigitToWord(lastDigit);
            Console.WriteLine(digitToWord);
        }

        private static long LastDigit(long digit)
        {
            long lastDigit = Math.Abs(digit % 10);
            return lastDigit;
        }

        private static string ConverDigitToWord(long lastDigit)
        {
            var digitAsWord = string.Empty;
            switch (lastDigit)
            {
                case 1:
                    digitAsWord = "one";
                    break;
                case 2:
                    digitAsWord = "two";
                    break;
                case 3:
                    digitAsWord = "three";
                    break;
                case 4:
                    digitAsWord = "four";
                    break;
                case 5:
                    digitAsWord = "fice";
                    break;
                case 6:
                    digitAsWord = "six";
                    break;
                case 7:
                    digitAsWord = "seven";
                    break;
                case 8:
                    digitAsWord = "eight";
                    break;
                case 9:
                    digitAsWord = "nine";
                    break;
                case 0:
                    digitAsWord = "zero";
                    break;
            }
            return digitAsWord;
        }
    }
}
