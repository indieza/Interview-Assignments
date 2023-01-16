namespace Singleton
{
    public class StartUp
    {
        private static void Main()
        {
            Singleton? s1 = Singleton.GetInstance();
            Singleton? s2 = Singleton.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }

            Console.WriteLine(s1?.Sum());
            Console.WriteLine(s2?.Sum());
        }
    }
}