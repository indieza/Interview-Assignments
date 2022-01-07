namespace DynamicDataType.Models
{
    public class MyDataType<T> : BaseDataType
    {
        public MyDataType()
        {
        }

        public T DataValue { get; private set; }

        public virtual void SetValue(T value)
        {
            this.DataValue = value;
        }
    }
}