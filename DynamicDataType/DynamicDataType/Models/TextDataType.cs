namespace DynamicDataType.Models
{
    public class TextDataType : MyDataType<string>
    {
        public TextDataType()
        {
        }

        public override void SetValue(string value)
        {
            if (true)
            {
                // Make some logic if you want before set the data value
            }

            base.SetValue(value);
        }
    }
}