using System.Text.Json;
using System.Text.RegularExpressions;

using LoopEnum;

var values = GetEnumaration<MyEnum>();
Console.WriteLine(JsonSerializer.Serialize(values));

List<MyEnumModel> GetEnumaration<T>()
{
    var values = Enum.GetValues(typeof(T))
        .Cast<T>()
        .Where(x => x != null)
        .Select(x => new MyEnumModel(Convert.ToInt32(x), Convert.ToString(x).SplitCamelCase()))
        .ToList();

    return values;
}

public static class SplitCamelCaseExtension
{
    public static string SplitCamelCase(this string source)
    {
        const string pattern = @"[A-Z][a-z]*|[a-z]+|\d+";
        var matches = Regex.Matches(source, pattern);
        return string.Join(" ", matches.Select(x => x.Value).ToList());
    }
}