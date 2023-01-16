namespace ExtensionMethod
{
    using ExtensionMethod.Sample;

    public class StartUp
    {
        private static void Main()
        {
            var result = new SealedClass(1, 3).Sum();
            Console.WriteLine(result);

            var person = new Person("Simeon", "Valev", new DateTime(2000, 01, 23));
            Console.WriteLine(person.ToString());
            Console.WriteLine(person.FormatBirthday());

            Console.WriteLine("My string".FormatString());
        }
    }
}