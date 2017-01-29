namespace HelloName
{
    using System;

    public class HelloName
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            Console.WriteLine($"Hello, {PrintName(input)}");
        }

        private static string PrintName(string name)
        {
            return name;
        }
    }
}
