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
 
            if(Math.Abs(x1) < Math.Abs(x2) && Math.Abs(y1) < Math.Abs(y2))
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}
