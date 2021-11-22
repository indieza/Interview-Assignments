namespace LoopEnum
{
    public class MyEnumModel
    {
        public MyEnumModel(int id, string value)
        {
            this.ID = id;
            this.Value = value;
        }

        public int ID { get; set; }

        public string Value { get; set; }
    }
}