namespace Animals
{
    public class Engine2<T>
    {
        public T Item { get; set; }

        public void Action()
        {
            (this.Item as Animal).MakeSound();
        }
    }
}