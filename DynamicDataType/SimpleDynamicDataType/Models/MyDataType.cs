namespace SimpleDynamicDataType.Models
{
    public abstract class MyDataType
    {
        protected MyDataType()
        {
        }

        public virtual object DataValue { get; private set; }

        public virtual void SetValue<T>(T value)
        {
            this.DataValue = value;
        }
    }
}