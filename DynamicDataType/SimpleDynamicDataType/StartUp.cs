using SimpleDynamicDataType.Models;

var data = new List<MyDataType>();

var text = new TextDataType();
text.SetValue<string>("My Value");
data.Add(text);

var number = new NumberDataType();
number.SetValue<int>(15);
data.Add(number);