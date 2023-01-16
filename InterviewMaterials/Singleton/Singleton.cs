namespace Singleton
{
    public sealed class Singleton
    {
        private static Singleton? instance;
        private readonly int a;
        private readonly int b;

        private Singleton(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public static Singleton? GetInstance()
        {
            instance ??= new Singleton(1, 2);
            return instance;
        }

        public int Sum() => this.a + this.b;
    }
}