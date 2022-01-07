using DynamicDataType.Models;

var data = new List<BaseDataType>();

var text = new TextDataType();
text.SetValue("My Value");
data.Add(text);

var number = new NumberDataType();
number.SetValue(15);
data.Add(number);

var dynamicData = new MyDataType<char>();
dynamicData.SetValue('S');
data.Add(dynamicData);