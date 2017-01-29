namespace MaxMethod
{
    using System;

    public class MaxMethod
    {
        public static void Main()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            var maxNumber = GetMax(a, b, c);
            Console.WriteLine(maxNumber);
        }

        private static int GetMax(int a, int b, int c)
        {
            int tempMax = Math.Max(a, b);
            int max = tempMax;
            int finalMax = Math.Max(max, c);
            return finalMax;
        }
    }
}
