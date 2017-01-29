namespace CenterPoint
{
    using System;

    public class CenterPoint
    {
        public static void Main()
        {
            var x1 = int.Parse(Console.ReadLine());
            var y1 = int.Parse(Console.ReadLine());
            var x2 = int.Parse(Console.ReadLine());
            var y2 = int.Parse(Console.ReadLine());

            if (x1 < x2 && y1 < y2)
            {
                Console.WriteLine($"({}");
            }
        }
    }
}
