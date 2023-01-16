namespace ExtensionMethod
{
    public class StartUp
    {
        private static void Main()
        {
            var result = new SealedClass(1, 3).Sum();
            Console.WriteLine(result);
        }
    }
}