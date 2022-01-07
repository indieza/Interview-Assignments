namespace SimpleDynamicDataType.Models
{
    public class NumberDataType : MyDataType
    {
        public NumberDataType()
        {
        }

        public int NumberValue { get; private set; }

        public override object DataValue => this.NumberValue;

        public override void SetValue<T>(T value)
        {
            this.NumberValue = (int)this.DataValue;
        }
    }
}