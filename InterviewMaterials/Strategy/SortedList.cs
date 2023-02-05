namespace Strategy
{
    public class SortedList
    {
        private List<string> list = new();
        private SortStrategy sortstrategy;

        public void SetSortStrategy(SortStrategy sortstrategy)
        {
            this.sortstrategy = sortstrategy;
        }

        public void Add(string name)
        {
            list.Add(name);
        }

        public void Sort()
        {
            sortstrategy.Sort(list);
            list.ForEach(i => Console.WriteLine($" {i}"));
            Console.WriteLine();
        }
    }
}