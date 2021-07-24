namespace FizzBuzz
{
    using System;

    public class StartUp
    {
        private static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Result.FizzBuzz(n);
        }
    }
}