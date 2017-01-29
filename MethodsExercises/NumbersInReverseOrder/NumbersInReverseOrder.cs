namespace NumbersInReverseOrder
{
    using System;

    public class NumbersInReverseOrder
    {
        public static void Main()
        {
            var number = double.Parse(Console.ReadLine());
            var numberInReverse = ReversedNumber(number);
            Console.WriteLine(numberInReverse);
        }

        private static double ReversedNumber(double number)
        {
            var numString = number.ToString();
            var reversedString = string.Empty;
            for (int i = numString.Length - 1; i >= 0; i--)
            {
                reversedString += numString[i];
            }

            var reversedNum = double.Parse(reversedString);
            return reversedNum;
        }
    }
}
