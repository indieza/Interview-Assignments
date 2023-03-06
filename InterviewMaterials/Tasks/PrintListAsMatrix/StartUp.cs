namespace PrintListAsMatrix;

public class StartUp
{
    private const int colls = 4;

    private static readonly List<string> lists = new()
    {
        new string('.', 1),
        new string('.', 2),
        new string('.', 3),
        new string('.', 4),
        new string('.', 5),
        new string('.', 6),
        new string('.', 7),
        new string('.', 8),
        new string('.', 9),
        new string('.', 10),
    };

    private static void Main()
    {
        foreach (var text in lists)
        {
            var items = text.ToCharArray();
            Console.WriteLine($"Text with {text.Length} dots");

            for (int row = 0; row < (int)Math.Ceiling(items.Count() / (decimal)colls); row++)
            {
                var endColl = row * colls + Math.Min(colls, items.Count() - row * colls);

                for (int coll = row * 4; coll < endColl; coll++)
                {
                    Console.Write(items[coll] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}