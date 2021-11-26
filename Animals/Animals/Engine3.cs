namespace Animals
{
    public class Engine3
    {
        public void Action<T>(T item)
        {
            (item as Animal).MakeSound();
        }
    }
}