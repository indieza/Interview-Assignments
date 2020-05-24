namespace _04._RegexThirdSolution
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        private const string Pattern = @"^([a-z]{1,20})[\s]{1}([a-z]+\@[a-z]+\.[a-z]+)$";

        private static void Main()
        {
            Console.Write($"n = ");
            int n = int.Parse(Console.ReadLine());

            // Validate n is in range [2, 30]
            while (n < 2 || n > 30)
            {
                Console.Write($"n = ");
                n = int.Parse(Console.ReadLine());
            }

            List<Person> people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                var match = Regex.Match(input, Pattern);

                if (match.Success)
                {
                    // Is the user Email is Gmail.com and length is in range [10, 50]
                    // 10 is the length of @gmail.com
                    if (match.Groups[2].Value.Length <= 50 &&
                        match.Groups[2].Value.Length >= 10 &&
                        match.Groups[2].Value.EndsWith("@gmail.com"))
                    {
                        var person = new Person(match.Groups[1].Value, match.Groups[2].Value);
                        people.Add(person);
                    }
                }
            }

            // Print users name separated on a new line ordered alphabetically
            Console.WriteLine(string.Join("\n", people.OrderBy(x => x.Name).Select(x => x.Name)));
        }
    }
}