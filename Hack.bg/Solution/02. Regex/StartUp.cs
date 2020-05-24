namespace _02._Regex
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        private const string Pattern = @"^([a-z]{1,20})[\s]{1}([a-z@\.]{10,50})$";

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
                    var person = new Person(match.Groups[1].Value, match.Groups[2].Value);

                    // Is the user Email is Gmail.com
                    if (person.Email.EndsWith("@gmail.com"))
                    {
                        people.Add(person);
                    }
                }
            }

            // Print users name separated on a new line ordered alphabetically
            Console.WriteLine(string.Join("\n", people.OrderBy(x => x.Name).Select(x => x.Name)));
        }
    }
}