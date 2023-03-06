namespace ExtensionMethod;

using ExtensionMethod.Sample;

public static class ExtensionMethods
{
    public static string FormatBirthday(this Person person) =>
        "Extendion bithday " + person.Birthday.ToString("dd-MMMM-yyyy");

    public static int ExtensionMethod(this SealedClass item) => item.Sum();

    public static string FormatString(this string item) =>
        $"Formatted \"{item}\" System.String";
}