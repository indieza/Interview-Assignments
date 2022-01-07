namespace DynamicDataType.Models
{
    public class NumberDataType : MyDataType<int>
    {
        public NumberDataType()
        {
        }

        public override void SetValue(int value)
        {
            if (true)
            {
                // Make some logic if you want before set the data value
            }

            base.SetValue(value);
        }
    }
}