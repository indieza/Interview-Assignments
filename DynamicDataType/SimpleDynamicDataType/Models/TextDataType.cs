using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDynamicDataType.Models
{
    public class TextDataType : MyDataType
    {
        public TextDataType()
        {
        }

        public string TextValue { get; private set; }

        public override object DataValue => this.TextValue;

        public override void SetValue<T>(T value)
        {
            this.TextValue = value.ToString();
        }
    }
}