namespace GeometryCalculator
{
    using System;

    public class GeometryCalculator
    {
        public static void Main()
        {
            string type = Console.ReadLine();
            type = type.ToLower();

            if (type == "triangle")
            {
                var triangleSide = double.Parse(Console.ReadLine());
                var triangleHeight = double.Parse(Console.ReadLine());
                var triangleArea = triangleSide * triangleHeight / 2;
                Console.WriteLine(triangleArea.ToString("0.00"));
            }
            else if (type == "square")
            {
                var squareSide = double.Parse(Console.ReadLine());
                var squareArea = Math.Pow(squareSide, 2);
                Console.WriteLine(squareArea.ToString("0.00"));
            }
            else if (type == "rectangle")
            {
                var rectangleSide = double.Parse(Console.ReadLine());
                var rectangleHeight = double.Parse(Console.ReadLine());
                var rectangleArea = rectangleSide * rectangleHeight;
                Console.WriteLine(rectangleArea.ToString("0.00"));
            }
            else if (type == "circle")
            {
                var circleRadius = double.Parse(Console.ReadLine());
                var circleArea = Math.PI * Math.Pow(circleRadius, 2);
                Console.WriteLine(circleArea.ToString("0.00"));
            }
        }
    }
}
