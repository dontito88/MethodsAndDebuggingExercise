namespace CubeProperties
{
    using System;

    public class CubeProperties
    {
        public static void Main()
        {
            var side = int.Parse(Console.ReadLine());
            string cubeParameter = Console.ReadLine();
            cubeParameter = cubeParameter.ToLower();

            if (cubeParameter == "face")
            {
                Console.WriteLine(CubeFace(side).ToString("0.00"));
            }
            else if (cubeParameter == "space")
            {
                Console.WriteLine(CubeSpace(side).ToString("0.00"));
            }
            else if (cubeParameter == "volume")
            {
                Console.WriteLine(CubeVolume(side).ToString("0.00"));
            }
            else if (cubeParameter == "area")
            {
                Console.WriteLine(CubeArea(side).ToString("0.00"));
            }

        }

        private static double CubeFace(double side)
        {
            var faceDiagonal = Math.Sqrt(2 * Math.Pow(side, 2));
            return faceDiagonal;
        }

        private static double CubeSpace(double side)
        {
            var spaceDiagonal = Math.Sqrt(3 * Math.Pow(side, 2));
            return spaceDiagonal;
        }

        private static double CubeVolume(double side)
        {
            var cubeVolume = Math.Pow(side, 3);
            return cubeVolume;
        }

        private static double CubeArea(double side)
        {
            var cubeArea = 6 * (Math.Pow(side, 2));
            return cubeArea;
        }
    }
}