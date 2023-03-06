namespace ExtensionMethod.Sample;

public sealed class Person
{
    public Person(string firstName, string lastName, DateTime birthday)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Birthday = birthday;
    }

    public string FirstName { get; }

    public string LastName { get; }

    public DateTime Birthday { get; }

    public override string ToString() =>
        $"My name is {this.FirstName} {this.LastName} - {this.Birthday:dd/MMMM/yyyy}";
}