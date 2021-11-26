namespace Animals
{
    public class Engine1<T>
    {
        public void Action(T item)
        {
            (item as Animal).MakeSound();
        }
    }
}